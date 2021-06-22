namespace QuizEMI.Web.ViewModels.Quizzes
{
    using System.Collections.Generic;

    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;
    using QuizEMI.Web.ViewModels.Questions;

    public class QuizPDFViewModel : IMapFrom<Quiz>
    {
        public QuizPDFViewModel()
        {
            this.Questions = new List<QuestionViewModel>();
        }

        public string Name { get; set; }

        public IEnumerable<QuestionViewModel> Questions { get; set; }
    }
}
