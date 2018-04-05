using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL;

namespace TaskManager.BLL
{
    public interface ITaskFinder
    {
        void FindByName(string name);
        void FindByDeadline(DateTime deadline);
        void FindByTag(Tag tag);
        void FindByCreationDate(DateTime creationDate);
        void FindByPriority(int priority);
    }
}
