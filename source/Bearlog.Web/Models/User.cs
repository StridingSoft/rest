//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace Bearlog.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("user_name")]
        public string UserName { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("registration_date")]
        public System.DateTime RegistrationDate { get; set; }
        [Column("last_activity_date")]
        public Nullable<System.DateTime> LastActivityDate { get; set; }
    
        public virtual GenTree GenTree { get; set; }
    }
}
