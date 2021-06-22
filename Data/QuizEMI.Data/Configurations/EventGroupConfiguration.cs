namespace QuizEMI.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using QuizEMI.Data.Models;

    public class EventGroupConfiguration : IEntityTypeConfiguration<EventGroup>
    {
        public void Configure(EntityTypeBuilder<EventGroup> eventGroup)
        {
            eventGroup.HasKey(pg => new { pg.EventId, pg.GroupId });
        }
    }
}
