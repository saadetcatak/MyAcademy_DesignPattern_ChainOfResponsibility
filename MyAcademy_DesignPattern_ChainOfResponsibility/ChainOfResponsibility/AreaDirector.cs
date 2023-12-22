using MyAcademy_DesignPattern_ChainOfResponsibility.ChainOfResponsibility.Models;
using MyAcademy_DesignPattern_ChainOfResponsibility.DAL.Context;
using MyAcademy_DesignPattern_ChainOfResponsibility.DAL.Entities;
using MyAcademy_DesignPattern_ChainOfResponsibility.Models;

namespace MyAcademy_DesignPattern_ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            ChainofRespContext context = new ChainofRespContext();

            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü -Özlem Karakoç";
                customerProcess.Description = "Müşterinin talep ettiği kredi tuttarı ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü -Özlem Karakoç";
                customerProcess.Description = "Müşterinin talep ettiği kredi tuttarı bankanın günlük ödeme limitini aştığı için gerçekleştirilemedi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
        }
    }
}
