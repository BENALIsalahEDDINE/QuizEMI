namespace QuizEMI.Web.ViewModels.Quizzes
{
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class QuizResultViewModel : IMapFrom<Result>
    {
        public string QuizName { get; set; }

        public int Points { get; set; }

        public int MaxPoints { get; set; }
    }
}
