//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LURecCenter.DAL.DataRepo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEquipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEquipment()
        {
            this.TblIssuedEquipments = new HashSet<TblIssuedEquipment>();
        }
    
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentBARCode { get; set; }
        public string EquipmentBrand { get; set; }
        public Nullable<int> EquipmentType { get; set; }
        public Nullable<System.DateTime> EquipmentAddDate { get; set; }
        public Nullable<long> EquipmentUserCount { get; set; }
        public Nullable<decimal> EquipmentPrice { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedON { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblIssuedEquipment> TblIssuedEquipments { get; set; }
        public virtual tblMstrEquipmentType tblMstrEquipmentType { get; set; }
    }
}
