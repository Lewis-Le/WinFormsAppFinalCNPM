namespace Lab2Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            Accounts = new HashSet<Account>();
            AgentOrders = new HashSet<AgentOrder>();
        }

        [Key]
        public int AID { get; set; }

        [StringLength(50)]
        public string A_name { get; set; }

        [StringLength(50)]
        public string A_address { get; set; }

        [StringLength(50)]
        public string A_description { get; set; }

        [StringLength(12)]
        public string Discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentOrder> AgentOrders { get; set; }
    }
}
