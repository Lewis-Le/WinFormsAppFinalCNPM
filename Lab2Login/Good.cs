namespace Lab2Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Good
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Good()
        {
            AorderGoods = new HashSet<AorderGood>();
            Goods_Receive = new HashSet<Goods_Receive>();
            GoodsDeliveries = new HashSet<GoodsDelivery>();
        }

        [Key]
        public int GID { get; set; }

        [StringLength(60)]
        public string GName { get; set; }

        [StringLength(400)]
        public string GDescription { get; set; }

        public double? GPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AorderGood> AorderGoods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_Receive> Goods_Receive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsDelivery> GoodsDeliveries { get; set; }
    }
}
