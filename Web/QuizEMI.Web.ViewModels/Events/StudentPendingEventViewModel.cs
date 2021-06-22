namespace QuizEMI.Web.ViewModels.Events
{
    using System;

    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class StudentPendingEventViewModel : IMapFrom<Event>
    {
        public string Name { get; set; }

        public string QuizName { get; set; }

        public string Date { get; set; }

        public string Duration { get; set; }

        public DateTime ActivationDateAndTime { get; set; }

        public TimeSpan DurationOfActivity { get; set; }
    }
}
