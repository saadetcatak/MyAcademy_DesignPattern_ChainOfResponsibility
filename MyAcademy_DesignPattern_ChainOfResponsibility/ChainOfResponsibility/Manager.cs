using MyAcademy_DesignPattern_ChainOfResponsibility.ChainOfResponsibility.Models;
using MyAcademy_DesignPattern_ChainOfResponsibility.DAL.Context;
using MyAcademy_DesignPattern_ChainOfResponsibility.DAL.Entities;
using MyAcademy_DesignPattern_ChainOfResponsibility.Models;

namespace MyAcademy_DesignPattern_ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            ChainofRespContext context = new ChainofRespContext();

            if (req.Amount <= 280000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür -İpek Çelik";
                customerProcess.Description = "Müşterinin talep ettiği kredi tuttarı ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür -İpek Çelik";
                customerProcess.Description = "Müşterinin talep ettiği kredi tuttar tarafınca ödenemediği için işlem bölge müdürüne aktarılmıştır";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

                NextApprover.ProcessRequest(req);
            }
        }
    }
}

