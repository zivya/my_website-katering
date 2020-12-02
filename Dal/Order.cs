//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.ExtraToOrders = new HashSet<ExtraToOrder>();
            this.OrderDishes = new HashSet<OrderDish>();
        }
    
        public int idOrder { get; set; }
        public string tz { get; set; }
        public Nullable<int> idEvent { get; set; }
        public Nullable<System.DateTime> dateOrder { get; set; }
        public Nullable<bool> statusOrder { get; set; }
        public string nameEvent { get; set; }
        public Nullable<int> amount { get; set; }
    
        public virtual BusyDate BusyDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual EventsType EventsType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtraToOrder> ExtraToOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDish> OrderDishes { get; set; }
    }
}