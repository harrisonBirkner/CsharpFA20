using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class StudentIdAlreadyExistsException : Exception
    {
        private static string msg = "A student with the selected id already exists";

        public StudentIdAlreadyExistsException() : base(msg) 
        {
            MainForm.validStudentFlag = false;
        }
    }
}
