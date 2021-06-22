namespace QuizEMI.Web.Infrastructure.Helpers
{
    using System.Collections.Generic;

    using QuizEMI.Web.ViewModels.Questions;
    using QuizEMI.Web.ViewModels.Quizzes;

    public interface IResultHelper
    {
        int CalculateResult(IList<QuestionViewModel> originalQuizQuestions, IList<AttemtedQuizQuestionViewModel> attemptedQuizQuestions);
    }
}
