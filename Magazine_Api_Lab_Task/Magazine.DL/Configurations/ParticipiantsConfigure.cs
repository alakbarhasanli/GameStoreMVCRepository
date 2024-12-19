using Magazine.DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DL.Configurations
{
    public class ParticipiantsConfigure : IEntityTypeConfiguration<Participants>
    {
        public void Configure(EntityTypeBuilder<Participants> builder)
        {

            builder.HasOne(w => w.Workshops)
                .WithMany(p => p.Participants)
                .HasForeignKey(w => w.WorkShopId);
        }
    }
}
