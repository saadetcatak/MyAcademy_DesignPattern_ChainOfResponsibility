using Microsoft.EntityFrameworkCore;
using MyAcademy_DesignPattern_ChainOfResponsibility.DAL.Entities;

namespace MyAcademy_DesignPattern_ChainOfResponsibility.DAL.Context
{
    public class ChainofRespContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAADET\\SQLEXPRESS01; initial catalog=DbChainOfResponsibility; integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
