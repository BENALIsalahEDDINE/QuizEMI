namespace QuizEMI.Web.ViewModels.Events
{
    using System.Collections.Generic;

    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;
    using QuizEMI.Web.ViewModels.Quizzes;

    public class EventWithQuizzesViewModel : IMapFrom<Event>
    {
        public EventWithQuizzesViewModel()
        {
            this.Quizzes = new List<QuizAssignViewModel>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public bool Error { get; set; }

        public string TimeZone { get; set; }

        public IList<QuizAssignViewModel> Quizzes { get; set; }
    }
}
