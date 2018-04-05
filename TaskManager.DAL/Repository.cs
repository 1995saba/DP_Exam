using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL
{
    public class Repository : IRepository<Task>, IRepository<Tag>
    {
        private ApplicationDbContext dbContext;
        public List<Task> Tasks { get; set; }
        public List<Tag> Tags { get; set; }

        public Repository()
        {
            dbContext = new ApplicationDbContext();
            Tasks = dbContext.Tasks.ToList();
            Tags = dbContext.Tags.ToList();
        }

        public void Create(Task item)
        {
            dbContext.Tasks.Add(item);
            Tasks.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(Task item)
        {
            dbContext.Tasks.Remove(item);
            Tasks.Remove(item);
            dbContext.SaveChanges();
        }

        public void Create(Tag item)
        {
            dbContext.Tags.Add(item);
            Tags.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(Tag item)
        {
            dbContext.Tags.Remove(item);
            Tags.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
