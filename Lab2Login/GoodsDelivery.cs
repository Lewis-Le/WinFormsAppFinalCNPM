namespace Lab2Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsDelivery")]
    public partial class GoodsDelivery
    {
        [Key]
        public int GDID { get; set; }

        public int? AorderID { get; set; }

        public int? GID { get; set; }

        public int? GD_quantity { get; set; }

        public double? GD_price { get; set; }

        public int? AccountantID { get; set; }

        public virtual Accountant Accountant { get; set; }

        public virtual AgentOrder AgentOrder { get; set; }

        public virtual Good Good { get; set; }
    }
}
