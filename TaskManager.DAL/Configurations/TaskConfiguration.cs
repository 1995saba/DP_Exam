using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL.Configurations
{
    public class TaskConfiguration : EntityTypeConfiguration<Task>
    {
        public TaskConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                    .HasMaxLength(100).IsRequired();

            Property(p => p.Description)
                    .HasMaxLength(1000).IsOptional();

            Property(p => p.DateOfCreating)
                    .IsRequired();

            Property(p => p.Priority)
                    .IsOptional();

            HasMany(p => p.Tags)
                    .WithMany(p => p.Tasks)
                    .Map(m =>
                    {
                        m.MapLeftKey("TaskId");
                        m.MapRightKey("TagId");
                        m.ToTable("TaskTag");
                    });
        }
    }
}
