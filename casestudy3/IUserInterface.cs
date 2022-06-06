using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy3
{
    interface IUserInterface
    {
		public void showFirstScreen();
		public void showStudentScreen();
		public void showAdminScreen();
		public void showAllStudentsScreen();
		public void showStudentRegistrationScreen(); // Execute the register method of AppEngine class
		public void introduceNewCourseScreen();
		public void showAllCoursesScreen();
	}
}
