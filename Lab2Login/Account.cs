namespace Lab2Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int AccountID { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountPassword { get; set; }

        public int? AccountantID { get; set; }

        public int? CustomerID { get; set; }

        public int? AgentID { get; set; }

        public virtual Accountant Accountant { get; set; }

        public virtual Agent Agent { get; set; }
    }
}
