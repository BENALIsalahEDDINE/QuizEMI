namespace QuizEMI.Web.ViewModels.Quizzes
{
    using System.Collections.Generic;

    using Ganss.XSS;
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class AttemtedQuizViewModel : IMapFrom<Quiz>
    {
        public AttemtedQuizViewModel()
        {
            this.Questions = new List<AttemtedQuizQuestionViewModel>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SanitizedDescription => new HtmlSanitizer().Sanitize(this.Description);

        public int Timer { get; set; }

        public IList<AttemtedQuizQuestionViewModel> Questions { get; set; }
    }
}
