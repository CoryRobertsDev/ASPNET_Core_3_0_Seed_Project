﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentManager.Models
{

    [Table("Assignment")]
    public class Assignment
    {
        /* Database Fields and Annotations
        -------------------------------------------------- */
        [Key]
        [Display(Name = "Assignment Id")]
        public int Id { get; set; }

        [Display(Name = "Colleague Id")] public string ColleagueId { get; set; }

        [Display(Name = "Equipment Id")] public int EquipmentId { get; set; }

        [Display(Name = "Building")] public string Location { get; set; }

        [Display(Name = "Floor")] public int Floor { get; set; }

        [Display(Name = "Room Number")] public int RoomNumber { get; set; }


        [Display(Name = "Requesting Dept.")] public string RequestingDepartment { get; set; }

        [Display(Name = "Assigned By")] public string AssignedBy { get; set; }

        [Display(Name = "Date Assigned")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AssignedDate { get; set; }

        [Display(Name = "Unassigned By")] public string UnassignedBy { get; set; }


        [Display(Name = "Date Unassigned")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UnassignedDate { get; set; }
    }
}
