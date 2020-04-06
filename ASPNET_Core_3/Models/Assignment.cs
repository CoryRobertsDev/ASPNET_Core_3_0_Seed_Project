﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EquipmentManager.Models
{
    public partial class Assignment
    {

        [Key] public int Id { get; set; }
        public string ColleagueId { get; set; }
        public int EquipmentId { get; set; }
        public string RequestingDepartment { get; set; }
        public string AssignedBy { get; set; }
        public DateTime AssignedDate { get; set; }
        public int? UnassignedBy { get; set; }
        public DateTime? UnassignedDate { get; set; }
        public string Location { get; set; }
        public int? RoomNumber { get; set; }
        public int? Floor { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}