namespace Lab2Login
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AgentOrderContextRPT : DbContext
    {
        public AgentOrderContextRPT()
            : base("name=AgentOrderContextRPT")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Accountant> Accountants { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AgentOrder> AgentOrders { get; set; }
        public virtual DbSet<AorderGood> AorderGoods { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<Goods_Receive> Goods_Receive { get; set; }
        public virtual DbSet<GoodsDelivery> GoodsDeliveries { get; set; }
        public virtual DbSet<GoodsReceive> GoodsReceives { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountPassword)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Accountant>()
                .Property(e => e.AccountantSdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Discount)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.Accounts)
                .WithOptional(e => e.Agent)
                .HasForeignKey(e => e.AgentID);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentOrders)
                .WithOptional(e => e.Agent)
                .HasForeignKey(e => e.AgentID);
        }
    }
}
