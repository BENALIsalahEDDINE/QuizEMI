namespace QuizEMI.Web.ViewModels.Categories
{
    using QuizEMI.Data.Models;
    using QuizEMI.Services.Mapping;

    public class CategorySimpleViewModel : IMapFrom<Category>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
