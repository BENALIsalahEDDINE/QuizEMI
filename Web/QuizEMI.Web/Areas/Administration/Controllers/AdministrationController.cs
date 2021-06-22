namespace QuizEMI.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using QuizEMI.Common;
    using QuizEMI.Web.Controllers;

    [Authorize(Roles = GlobalConstants.AdministratorAndTeacherAuthorizationString)]
    [Area(GlobalConstants.Administration)]
    public class AdministrationController : BaseController
    {
    }
}
