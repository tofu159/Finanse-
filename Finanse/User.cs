//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finanse
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.PayablesReceivables = new HashSet<PayablesReceivable>();
            this.Transactions = new HashSet<Transaction>();
        }
        /// <summary>
        /// Właściwość przechowująca id uzytkownika
        /// </summary>
        public int ID_User { get; set; }
        /// <summary>
        /// Właściwość przechowująca imie uzytkowniak
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Właściwość przechowująca nazwisko uzytkowniak
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Właściwość przechowująca login uzytkowniak
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Właściwość przechowująca haslo uzytkowniak
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Właściwość przechowująca dostepne srodki uzytkowniak
        /// </summary>
        public double AvailableFunds { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayablesReceivable> PayablesReceivables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
