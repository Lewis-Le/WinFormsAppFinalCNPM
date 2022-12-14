namespace Lab2Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsReceive")]
    public partial class GoodsReceive
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodsReceive()
        {
            Goods_Receive = new HashSet<Goods_Receive>();
        }

        [Key]
        public int AorderID { get; set; }

        public int? AccountantID { get; set; }

        public double? AorderPrice { get; set; }

        public int? AgentPayment { get; set; }

        public int? AgentDelivery { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual Accountant Accountant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_Receive> Goods_Receive { get; set; }
    }
}
