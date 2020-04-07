using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquipmentManager.Models;

namespace EquipmentManager.Controllers
{
    public class AssignmentsDetailsController : Controller
    {
        public readonly UcInventoryContext Context;

        public AssignmentsDetailsController(UcInventoryContext context)
        {
            Context = context;
        }
        // GET: AssignmentsDetails
        public IActionResult Active()
        {
            return View();
        }




    }
}
