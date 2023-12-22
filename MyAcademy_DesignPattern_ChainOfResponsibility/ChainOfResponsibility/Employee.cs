using MyAcademy_DesignPattern_ChainOfResponsibility.Models;

namespace MyAcademy_DesignPattern_ChainOfResponsibility.ChainOfResponsibility.Models
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee supervisor)
        {
            this.NextApprover = supervisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
