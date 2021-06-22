namespace QuizEMI.Web.ViewModels.Answers
{
    using Ganss.XSS;
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class AttemtedQuizAnswerViewModel : IMapFrom<Answer>
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public string SanitizedText => new HtmlSanitizer().Sanitize(this.Text);

        public bool IsRightAnswerAssumption { get; set; }
    }
}
