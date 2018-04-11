using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.BLL;
using TaskManager.DAL;

namespace TaskManager.UI
{
    public partial class TaskManager : Form
    {

        private TaskFinder taskFinder;
        private TaskSaver taskSaver;
        public TaskManager()
        {
            InitializeComponent();
            taskFinder = new TaskFinder();
            if (taskFinder.Repository.Tags != null)
            {
                foreach (var tag in taskFinder.Repository.Tags)
                {
                    tagsListBox.Items.Add(tag.Name);
                }
            }
            taskSaver = new TaskSaver();
            taskListView.Columns.Add("Id");
            taskListView.Columns.Add("Name");
            taskListView.Columns.Add("CreationDate");
            taskListView.Columns.Add("Deadline");
            taskListView.Columns.Add("Priority");
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            if (taskFinder.Tasks != null)
            {
                taskSaver.Tasks = taskFinder.Tasks;
                saveFileDialog.ShowDialog();
                string path = saveFileDialog.FileName;
                taskSaver.SaveToFile(path);
            }
            else
            {
                taskSaver.Tasks = taskFinder.Repository.Tasks;
                saveFileDialog.ShowDialog();
                string path = saveFileDialog.FileName;
                taskSaver.SaveToFile(path);
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != null)
            {
                DAL.Task newTask = new DAL.Task
                {
                    Name = nameTextBox.Text,
                    DateOfCreating = DateTime.Now,
                    DeadLine=deadlinePicker.Value,
                    Priority=(int)priorityNum.Value
                };
                foreach (var item in tagsListBox.SelectedItems)
                {
                   newTask.Tags.Add(
                       taskFinder.Repository.Tags.Find(
                           p => p.Name == item.ToString()));
                }
                taskFinder.Repository.Create(newTask);
            }
        }

        private void AddTagButton_Click(object sender, EventArgs e)
        {
            if (tagTextBox.Text != null)
            {
                Tag newTag = new Tag { Name = tagTextBox.Text };
                taskFinder.Repository.Create(newTag);
                tagsListBox.Items.Add(newTag.Name);
                tagsListBox.Refresh();
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            taskListView.Items.Clear();
            foreach (var task in taskFinder.Repository.Tasks)
            {
                ListViewItem taskItem = taskListView.Items.Add(task.Id.ToString());
                taskItem.SubItems.Add(task.Name);
                taskItem.SubItems.Add(task.DateOfCreating.ToString());
                taskItem.SubItems.Add(task.DeadLine.ToString());
                taskItem.SubItems.Add(task.Priority.ToString());
            }
            taskListView.Refresh();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (paramTextBox.Text != null)
            {
                if (nameRadioButton.Checked)
                {
                    taskListView.Items.Clear();
                    taskFinder.FindByName(paramTextBox.Text);
                    if (taskFinder.Tasks != null)
                    {
                        foreach (var task in taskFinder.Tasks)
                        {
                            ListViewItem taskItem = taskListView.Items.Add(task.Id.ToString());
                            taskItem.SubItems.Add(task.Name);
                            taskItem.SubItems.Add(task.DateOfCreating.ToString());
                            taskItem.SubItems.Add(task.DeadLine.ToString());
                            taskItem.SubItems.Add(task.Priority.ToString());
                        }
                        taskListView.Refresh();
                    }
                }
                if (creationDateRadioButton.Checked)
                {
                    taskListView.Items.Clear();
                    DateTime date;
                    bool result = DateTime.TryParse(paramTextBox.Text, out date);
                    if (result)
                    {
                        taskFinder.FindByCreationDate(date);
                        if (taskFinder.Tasks != null)
                        {
                            foreach (var task in taskFinder.Tasks)
                            {
                                ListViewItem taskItem = taskListView.Items.Add(task.Id.ToString());
                                taskItem.SubItems.Add(task.Name);
                                taskItem.SubItems.Add(task.DateOfCreating.ToString());
                                taskItem.SubItems.Add(task.DeadLine.ToString());
                                taskItem.SubItems.Add(task.Priority.ToString());
                            }
                            taskListView.Refresh();
                        }
                    }
                }
                if (deadlineRadioButton.Checked)
                {
                    taskListView.Items.Clear();
                    DateTime date;
                    bool result = DateTime.TryParse(paramTextBox.Text, out date);
                    if (result)
                    {
                        taskFinder.FindByDeadline(date);
                        if (taskFinder.Tasks != null)
                        {
                            foreach (var task in taskFinder.Tasks)
                            {
                                ListViewItem taskItem = taskListView.Items.Add(task.Id.ToString());
                                taskItem.SubItems.Add(task.Name);
                                taskItem.SubItems.Add(task.DateOfCreating.ToString());
                                taskItem.SubItems.Add(task.DeadLine.ToString());
                                taskItem.SubItems.Add(task.Priority.ToString());
                            }
                            taskListView.Refresh();
                        }
                    }
                }
                if (priorityRadioButton.Checked)
                {
                    taskListView.Items.Clear();
                    int priority;
                    bool result = Int32.TryParse(paramTextBox.Text, out priority);
                    if (result)
                    {
                        taskFinder.FindByPriority(priority);
                        if (taskFinder.Tasks != null)
                        {
                            foreach (var task in taskFinder.Tasks)
                            {
                                ListViewItem taskItem = taskListView.Items.Add(task.Id.ToString());
                                taskItem.SubItems.Add(task.Name);
                                taskItem.SubItems.Add(task.DateOfCreating.ToString());
                                taskItem.SubItems.Add(task.DeadLine.ToString());
                                taskItem.SubItems.Add(task.Priority.ToString());
                            }
                            taskListView.Refresh();
                        }
                    }
                }
                if (tagRadioButton.Checked)
                {
                    taskListView.Items.Clear();
                    if (paramTextBox.Text!=null)
                    {
                        taskFinder.FindByTag(
                            taskFinder.Repository.Tags.Find(p=>p.Name==paramTextBox.Text));
                        if (taskFinder.Tasks != null)
                        {
                            foreach (var task in taskFinder.Tasks)
                            {
                                ListViewItem taskItem = taskListView.Items.Add(task.Id.ToString());
                                taskItem.SubItems.Add(task.Name);
                                taskItem.SubItems.Add(task.DateOfCreating.ToString());
                                taskItem.SubItems.Add(task.DeadLine.ToString());
                                taskItem.SubItems.Add(task.Priority.ToString());
                            }
                            taskListView.Refresh();
                        }
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DAL.Task taskToDelete = taskFinder.FindById((int)delNumericUpDown.Value);
            if (taskToDelete != null)
            {
                taskFinder.Repository.Delete(taskToDelete);
                MessageBox.Show("Task was successfully deleted");
            }
            else MessageBox.Show("Entered incorrect Id number");
        }
    }
}
