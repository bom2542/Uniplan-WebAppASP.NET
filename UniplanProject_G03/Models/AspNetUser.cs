//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniplanProject_G03.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }
        public System.DateTime Dob { get; set; }
        public string Sex { get; set; }
        public string StudentID { get; set; }
        public string University { get; set; }
        public string Institute { get; set; }
        public string Branch { get; set; }
        public string Year { get; set; }
        public string Motto { get; set; }
        public string Url { get; set; }
    }
}