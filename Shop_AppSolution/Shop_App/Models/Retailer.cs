//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop_App.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]

    public partial class Retailer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Retailer()
        {
            this.Orders = new HashSet<Order>();
            this.Products = new HashSet<Product>();
            this.Update_Products = new HashSet<Update_Products>();
        }
        [DataMember]
        public int Retail_Id { get; set; }
        [DataMember]
        public string Company_Name { get; set; }
        [DataMember]
        public string Retail_Name { get; set; }
        [DataMember]
        public string Retail_Password { get; set; }
        [DataMember]
        public string Retail_Phone { get; set; }
        [DataMember]
        public string Retail_Email { get; set; }
        [DataMember]
        public string Retail_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Update_Products> Update_Products { get; set; }
    }
}
