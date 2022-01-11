using IdentityExp2.Models;
using IdentityExp2.Models.ViewModels;
using IdentityExp2.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExp2.Services
{
    public class AppointmentService : IAppointmentService
    {

        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<TeacherViewModel> GetTeacherList()
        {
            var teachers = (from user in _db.Users
                            join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                            join roles in _db.Roles.Where(x=>x.Name==Helper.Teacher) on userRoles.RoleId equals roles.Id
                            select new TeacherViewModel
                            {
                                Id = user.Id,
                                Name = user.Name
                            }
                            ).ToList();
            return teachers;
        }

        public List<StudentViewModel> GetStudentList()
        {
            var students = (from user in _db.Users
                            join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
                            join roles in _db.Roles.Where(x => x.Name == Helper.Student) on userRoles.RoleId equals roles.Id
                            select new StudentViewModel
                            {
                                Id = user.Id,
                                Name = user.Name
                            }
                            ).ToList();
            return students;
        }

    }
}
