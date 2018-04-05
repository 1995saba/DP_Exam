using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreating { get; set; }
        public DateTime DeadLine { get; set; }
        public int Priority { get; set; }
        public ICollection<Tag> Tags { get; set; }
        
        public Task()
        {
            Tags = new List<Tag>();
        }
    }
}
