namespace QuizEMI.Data.Models
{
    using QuizEMI.Data.Common.Models;

    public class EventGroup : BaseDeletableModel<string>
    {
        public string EventId { get; set; }

        public virtual Event Event { get; set; }

        public string GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
