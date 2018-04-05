using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL.Configurations
{
    public class TagConfiguration: EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                    .HasMaxLength(100).IsRequired();
        }
    }
}
