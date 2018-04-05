using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL;

namespace TaskManager.BLL
{
    public class TaskFinder : ITaskFinder
    {
        public List<DAL.Task> Tasks { get; set; }
        public Repository Repository { get; set; }

        public TaskFinder()
        {
            Repository = new Repository();
        }

        public void FindByName(string name)
        {
            Tasks = Repository.Tasks.FindAll(p => p.Name.Contains(name));
        }

        public void FindByDeadline(DateTime deadline)
        {
            Tasks = Repository.Tasks.FindAll(
                p => p.DeadLine.Day == deadline.Day &&
                     p.DeadLine.Month == deadline.Month &&
                     p.DeadLine.Year == deadline.Year);
        }

        public void FindByTag(Tag tag)
        {
            Tasks = Repository.Tasks.FindAll(p => p.Tags.Contains(tag));
        }

        public void FindByCreationDate(DateTime creationDate)
        {
            Tasks = Repository.Tasks.FindAll(
                p => p.DateOfCreating.Day == creationDate.Day &&
                     p.DateOfCreating.Month == creationDate.Month &&
                     p.DateOfCreating.Year == creationDate.Year);
        }

        public void FindByPriority(int priority)
        {
            Tasks = Repository.Tasks.FindAll(p => p.Priority>=priority);
        }
    }
}
