using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserServices.BusinessLayer;

namespace UserServices.BusinessLayerTests
{
    [TestClass]
    public class SessionTest
    {
        Course cou1 = new Course { ID = 1, Name = "Course01" };
        Course cou2 = new Course { ID = 2, Name = "Course02" };
        Course cou3 = new Course { ID = 3, Name = "Course03" };

        User teacher = new User { ID = 1, Name = "User_Teacher", IsActivated = true, Company = "Company 01", Role = UserRole.Teacher, Email = "teacher@gmail.com" };
        User attendee = new User { ID = 2, Name = "User_Attendee", IsActivated = false, Company = "Company 02", Role = UserRole.Attendee, Email = "student@gmail.com" };


        [TestMethod]
        public void GetCoursesAll()
        {
            var startDate = DateTime.Now;
            var endDate = startDate.AddDays(30);

            var ses = new Session { ID = 1, Teacher = teacher, Course = cou1, Attendees = new System.Collections.Generic.List<User> {attendee}, Dates = new System.Collections.Generic.List<DateTime> {startDate } };


            //Course
            Assert.AreEqual(cou1.Name, ses.Course.Name);
        }

        [TestMethod()]
        public void GetCourse_by_Session()
        {
            var startDate = DateTime.Now;
            var endDate = startDate.AddDays(30);

            var ses = new Session { ID = 1, Teacher = teacher, Course = cou1, Attendees = new System.Collections.Generic.List<User> { attendee }, Dates = new System.Collections.Generic.List<DateTime> { startDate } };

            //Course
            Assert.AreEqual(cou1.ID, ses.Course.ID);
            Assert.AreEqual(cou1.Name, ses.Course.Name);

            //Teacher
            Assert.AreEqual(teacher.ID, ses.Teacher.ID);
            Assert.AreEqual(teacher.Name, ses.Teacher.Name);
            Assert.AreEqual(teacher.IsActivated, ses.Teacher.IsActivated);
            Assert.AreEqual(teacher.Company, ses.Teacher.Company);
            Assert.AreEqual(teacher.Role, ses.Teacher.Role);
            Assert.AreEqual(teacher.Email, ses.Teacher.Email);

            //Attendee
            //Assert.AreEqual(attendee.ID, ses.Attendees.ID);
            //Assert.AreEqual(attendee.Name, ses.Attendees.Name);
            //Assert.AreEqual(attendee.IsActivated, ses.Attendees.IsActivated);
            //Assert.AreEqual(attendee.Company, ses.Attendees.Company);
            //Assert.AreEqual(attendee.Role, ses.Attendees.Role);
            //Assert.AreEqual(attendee.Email, ses.Attendees.Email);

            //IsActivatedFalse
            Assert.IsFalse(attendee.IsActivated);

            //IsActivatedTrue
            Assert.IsTrue(teacher.IsActivated);

        }
    }
}
