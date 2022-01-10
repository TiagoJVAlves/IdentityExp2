using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExp2.Utility
{
    public static class Helper
    {

        public static string Admin="Admin";
        public static string Teacher= "Professor";
        public static string Student= "Estudante";

        public static List<SelectListItem> GetRolesDropdown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Admin, Text=Helper.Admin},
                new SelectListItem{Value=Helper.Teacher, Text=Helper.Teacher},
                new SelectListItem{Value=Helper.Student, Text=Helper.Student}
            };
        }


    }
}
