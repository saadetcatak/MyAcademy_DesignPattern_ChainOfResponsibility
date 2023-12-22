namespace MyAcademy_DesignPattern_ChainOfResponsibility.DAL.Entities
{
    public class CustomerProcess
    {
        public int CustomerProcessID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
