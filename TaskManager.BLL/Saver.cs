using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.BLL
{
    public class TaskSaver : ISaver
    {
        public List<DAL.Task> Tasks { get; set; }

        public void SaveToFile(string path)
        {
            using (StreamWriter stream = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach(var task in Tasks)
                {
                    stream.WriteLine($"{task.Id}. " +
                        $"{task.Name}\n" +
                        $"{task.Description}\n " +
                        $"Creation date: {task.DateOfCreating}\n" +
                        $"Deadline: {task.DeadLine}\n" +
                        $"Priority Level: {task.Priority}\n");
                    if (task.Tags != null)
                    {
                        stream.WriteLine("Tags: ");
                        foreach (var tag in task.Tags)
                        {
                            stream.WriteLine($"{tag} ");
                        }
                    }
                    stream.WriteLine("\n--------------------------------------------\n");
                }
            }
        }
    }
}
