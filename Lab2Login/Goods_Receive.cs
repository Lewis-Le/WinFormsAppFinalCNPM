namespace Lab2Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods_Receive
    {
        [Key]
        public int AorderGoodsID { get; set; }

        public int? AorderID { get; set; }

        public int? GID { get; set; }

        public int? Quantity { get; set; }

        [StringLength(60)]
        public string GName { get; set; }

        public double? TotalPrice { get; set; }

        public virtual Good Good { get; set; }

        public virtual GoodsReceive GoodsReceive { get; set; }
    }
}
