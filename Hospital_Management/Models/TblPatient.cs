//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblPatient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblPatient()
        {
            this.RadiologyImages = new HashSet<RadiologyImages>();
            this.Appointments = new HashSet<Appointments>();
        }
    
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MedicalHistory { get; set; }
        public string BloodType { get; set; }
        public Nullable<bool> Insurance { get; set; }
        public Nullable<System.DateTime> AdmissionDate { get; set; }
        public Nullable<System.DateTime> DischarDate { get; set; }
        public string Status { get; set; }
        public string EmergencyStatus { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string PatientIdentityNumber { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public string Notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadiologyImages> RadiologyImages { get; set; }
        public virtual TblDoctor TblDoctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
