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
            Tasks = new List<Task>();
            Tags = new List<Tag>();
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

        public void Update(Task item)
        {
            Task oldItem=dbContext.Tasks.First(p=>p.Id==item.Id);
            dbContext.Tasks.Remove(oldItem);
            dbContext.Tasks.Add(item);
            Tasks.Remove(oldItem);
            Tasks.Add(item);
            dbContext.SaveChanges();
        }

        public void Update(Tag item)
        {
            Tag oldItem = dbContext.Tags.First(p => p.Id == item.Id);
            dbContext.Tags.Remove(oldItem);
            dbContext.Tags.Add(item);
            Tags.Remove(oldItem);
            Tags.Add(item);
            dbContext.SaveChanges();
        }
    }
}
