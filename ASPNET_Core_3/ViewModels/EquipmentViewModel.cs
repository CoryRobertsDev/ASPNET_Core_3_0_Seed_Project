//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Threading.Tasks;
//using EquipmentManager.Models;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using static EquipmentManager.ViewModels.EquipmentViewModels;

//namespace EquipmentManager.ViewModels
//{

//    public class EquipmentViewModels
//    {

//        [Table("Equipment")]
//        public class Equipment
//        {
//            [Key] [DisplayName("Equip. Id")] public int Id { get; set; }

//            [DisplayName("Type")]
//            [Required(ErrorMessage = "Please enter equipment type.")]
//            public string EquipType { get; set; }

//            [Display(Name = "Model")]
//            [Required(ErrorMessage = "Please enter model name.")]
//            public string Model { get; set; }

//            [DisplayName("Sub-Model")] public string SubModel { get; set; }

//            [DisplayName("Serial Num.")]
//            [Required(ErrorMessage = "Please enter serial number.")]
//            public string SerialNum { get; set; }


//            [Required(ErrorMessage = "Please enter invoice number.")]
//            [DisplayName("Service Tag")]
//            public string ServiceTag { get; set; }

//            [DataType(DataType.Date)]
//            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
//            //[Required(ErrorMessage = "Please select a date.")]
//            [DisplayName("Date Received")]
//            public DateTime DateReceived { get; set; }

//            [DisplayName("Requesting Dept.")]
//            [Required(ErrorMessage = "Please select a department from the dropdown.")]
//            public string RequestingDept { get; set; }

//            [DisplayName("Requesting Employee")]
//            //[Required(ErrorMessage = "Please select an employee from the dropdown.")]
//            public string RequestedBy { get; set; }

//            public int InvoiceNum { get; set; }

//            [Display(Name = "Warranty")] public bool Warranty { get; set; }

//            [DataType(DataType.Date)]
//            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
//            [DisplayName("Decommission Date")]
//            //[Required(ErrorMessage = "Please select a date.")]
//            public DateTime? DecommissionDate { get; set; }

//            [DisplayName("Decommission Status")]
//            //[Required(ErrorMessage = "Please select a decommission status")]
//            public bool? DecommissionStatus { get; set; }

//            [DataType(DataType.Date)]
//            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
//            [DisplayName("Destroy Date")]
//            //[Required(ErrorMessage = "Please select a date.")]
//            public DateTime? DestroyDate { get; set; }

//            [DisplayName("Destroy Status")]
//            //[Required(ErrorMessage = "Please select a destroy status")]
//            public bool? DestroyStatus { get; set; }

//            public List<SelectListItem> ManufacturerId { get; set; }

//            public List<SelectListItem> VendorId {get; set; }

//            public List<SelectListItem> EquipmentTypeId { get; set; }

//        }

//        [Table("Manufacturer")]
//        public class Manufacturer
//        {
//            [ForeignKey("ManufacturerId")] public int Id { get; set; }

//            [Required] public string Name { get; set; }


//        }
    

    
//        [Table("EquipmentType")]
//        public class EquipmentType
//        {
//            [ForeignKey("EquipmentTypeId")] public int Id { get; set; }

//            [Required] public string Name { get; set; }
        
//        }
    
//        [Table("Vendor")]
//        public class Vendor
//        {
//            [ForeignKey("VendorId")] public int Id { get; set; }

//            [Required] public string Name { get; set; }
//        }
    
//    }

    
//}
