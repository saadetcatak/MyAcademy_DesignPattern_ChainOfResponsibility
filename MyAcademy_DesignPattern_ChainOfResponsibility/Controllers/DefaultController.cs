using Microsoft.AspNetCore.Mvc;
using MyAcademy_DesignPattern_ChainOfResponsibility.ChainOfResponsibility;
using MyAcademy_DesignPattern_ChainOfResponsibility.ChainOfResponsibility.Models;
using MyAcademy_DesignPattern_ChainOfResponsibility.Models;

namespace MyAcademy_DesignPattern_ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant= new ManagerAssistant();
            Employee manager=new Manager();
            Employee areaDirector= new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);
            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
