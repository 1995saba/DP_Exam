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
        public TaskManager()
        {
            InitializeComponent();
            taskFinder = new TaskFinder();
            foreach(var tag in taskFinder.Repository.Tags)
            {
                tagsListBox.Items.Add(tag.Name);
            }
            taskListView.Columns.Add("Id");
            taskListView.Columns.Add("Name");
            taskListView.Columns.Add("CreationDate");
            taskListView.Columns.Add("Deadline");
            taskListView.Columns.Add("Priority");
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {

        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {

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
            foreach(var task in taskFinder.Repository.Tasks)
            {
                ListViewItem taskItem = new ListViewItem();
                taskItem.SubItems.Add(task.Id.ToString());
                taskItem.SubItems.Add(task.Name);
                taskItem.SubItems.Add(task.DateOfCreating.ToString());
                taskItem.SubItems.Add(task.DeadLine.ToString());
                taskItem.SubItems.Add(task.Priority.ToString());
                taskListView.Items.Add(taskItem);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void TaskListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //currentDescriptionTextBox.Text=
            //    taskFinder.Repository
            //    .Tasks.First(p=>p.Id==taskListView.SelectedItems)
        }
    }
}
