namespace Lab2Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accountant")]
    public partial class Accountant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accountant()
        {
            Accounts = new HashSet<Account>();
            AgentOrders = new HashSet<AgentOrder>();
            GoodsDeliveries = new HashSet<GoodsDelivery>();
            GoodsReceives = new HashSet<GoodsReceive>();
        }

        public int AccountantID { get; set; }

        [StringLength(50)]
        public string AccountantName { get; set; }

        [StringLength(15)]
        public string AccountantSdt { get; set; }

        [StringLength(50)]
        public string AccountantEmail { get; set; }

        [StringLength(50)]
        public string AccountantAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentOrder> AgentOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsDelivery> GoodsDeliveries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsReceive> GoodsReceives { get; set; }
    }
}
