namespace BankingSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Purse> Purse { get; set; }
        public DbSet<PaymentHistory> PaymentHistorys { get; set; }
    }
}