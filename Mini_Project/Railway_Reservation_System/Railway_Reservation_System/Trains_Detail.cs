//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Railway_Reservation_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trains_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trains_Detail()
        {
            this.Book_Ticket = new HashSet<Book_Ticket>();
            this.Cancel_Ticket = new HashSet<Cancel_Ticket>();
            this.Fair_S = new HashSet<Fair_S>();
            this.Seat_Availability = new HashSet<Seat_Availability>();
        }
    
        public decimal Train_id { get; set; }
        public string Train_name { get; set; }
        public string Depart_city { get; set; }
        public string Arrival_city { get; set; }
        public bool Active_or_Not { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_Ticket> Book_Ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cancel_Ticket> Cancel_Ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fair_S> Fair_S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seat_Availability> Seat_Availability { get; set; }
    }
}
