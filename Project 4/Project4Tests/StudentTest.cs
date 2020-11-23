using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_4;

namespace Project4Tests
{
    [TestClass]
    public class StudentTest
    {
        public const string TestName = "John Doe";

        [TestMethod]
        public void GettersAndSetters()
        {
            Student overloadedStudent = new Student(100, TestName);

            DormStudent overloadedDormStudent = new DormStudent(100, TestName, DormLocation.Oak, MealPlan.B);

            Assert.AreEqual(100, overloadedStudent.Id);
            Assert.AreEqual(TestName, overloadedStudent.Name);

            Assert.AreEqual(100, overloadedDormStudent.Id);
            Assert.AreEqual(TestName, overloadedDormStudent.Name);
            Assert.AreEqual(DormLocation.Oak, overloadedDormStudent.Location);
            Assert.AreEqual(MealPlan.B, overloadedDormStudent.MealPlan);
        }

        [TestMethod]
        public void SortStudents()
        {
            Student Student1 = new Student(400, TestName);
            Student Student2 = new Student(300, TestName);
            DormStudent Student3 = new DormStudent(200, TestName, DormLocation.Trustee, MealPlan.H);
            DormStudent Student4 = new DormStudent(100, TestName, DormLocation.Mahaska, MealPlan.B);

            List<Student> StudentList = new List<Student>();

            StudentList.Add(Student1);
            StudentList.Add(Student2);
            StudentList.Add(Student3);
            StudentList.Add(Student4);

            StudentList.Sort();

            Assert.AreEqual(StudentList[0], Student4);
            Assert.AreEqual(StudentList[1], Student3);
            Assert.AreEqual(StudentList[2], Student2);
            Assert.AreEqual(StudentList[3], Student1);
        }

        [TestMethod]
        public void StudentToString()
        {
            Student s = new Student(100, TestName);
            DormStudent ds = new DormStudent(300, TestName, DormLocation.Trustee, MealPlan.H);

            Assert.AreEqual("My name is John Doe and my student id is #100", s.ToString());
            Assert.AreEqual("My name is John Doe and my student id is #300. I live in Trustee and I have the H meal plan", ds.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StudentNameValidation()
        {
            Student expected = new Student(100, "");
        }
    }
}
