using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }

        public Tag()
        {
            Tasks = new List<Task>();
        }
    }
}
