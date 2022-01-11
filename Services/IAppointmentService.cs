using IdentityExp2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExp2.Services
{
    public interface IAppointmentService
    {
        public List<TeacherViewModel> GetTeacherList();
        public List<StudentViewModel> GetStudentList();

    }
}
