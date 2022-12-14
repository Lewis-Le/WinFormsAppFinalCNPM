namespace Lab2Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentOrder")]
    public partial class AgentOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgentOrder()
        {
            AorderGoods = new HashSet<AorderGood>();
            GoodsDeliveries = new HashSet<GoodsDelivery>();
        }

        [Key]
        public int AorderID { get; set; }

        public int? AgentID { get; set; }

        public int? AccountantID { get; set; }

        public double? AorderPrice { get; set; }

        public int? AgentPayment { get; set; }

        public int? AgentDelivery { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual Accountant Accountant { get; set; }

        public virtual Agent Agent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AorderGood> AorderGoods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsDelivery> GoodsDeliveries { get; set; }
    }
}
