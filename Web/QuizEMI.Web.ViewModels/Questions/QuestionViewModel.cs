namespace QuizEMI.Web.ViewModels.Questions
{
    using System.Collections.Generic;

    using Ganss.XSS;
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;
    using QuizEMI.Web.ViewModels.Answers;

    public class QuestionViewModel : IMapFrom<Question>
    {
        public QuestionViewModel()
        {
            this.Answers = new List<AnswerViewModel>();
        }

        public string Id { get; set; }

        public string Text { get; set; }

        public string SanitizedText => new HtmlSanitizer().Sanitize(this.Text);

        public IList<AnswerViewModel> Answers { get; set; }

        public int Number { get; set; }
    }
}
