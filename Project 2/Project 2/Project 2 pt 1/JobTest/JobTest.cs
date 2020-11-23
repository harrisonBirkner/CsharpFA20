using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_2_pt_1;

namespace JobTest
{
    [TestClass]
    public class JobTest
    {
        [TestMethod]
        public void DefaultConstructor()
        {
            Job expected = new Job("mow yard", 1, 10);
            Job actual = new Job();
            Assert.AreEqual(expected.Desc, actual.Desc);
            Assert.AreEqual(expected.Hrs, actual.Hrs);
            Assert.AreEqual(expected.Rate, actual.Rate);
        }

        [TestMethod]
        public void PartialConstructor()
        {
            Job expected = new Job("test desc", 1, 10);
            Job actual = new Job("test desc");
            Assert.AreEqual(expected.Desc, actual.Desc);
            Assert.AreEqual(expected.Hrs, actual.Hrs);
            Assert.AreEqual(expected.Rate, actual.Rate);
        }

        [TestMethod]
        public void FullConstructor()
        {
            Job expected = new Job("clip hedges", 2, 14);
            Job actual = new Job("clip hedges", 2, 14);
            Assert.AreEqual(expected.Desc, actual.Desc);
            Assert.AreEqual(expected.Hrs, actual.Hrs);
            Assert.AreEqual(expected.Rate, actual.Rate);
        }

        [TestMethod]
        public void SortJobs()
        {
            Job job1 = new Job("job1", 5, 50);
            Job job2 = new Job("job2", 4, 50);
            Job job3 = new Job("job3", 3, 50);
            Job job4 = new Job("job4", 2, 50);
            Job job5 = new Job("job5", 1, 50);

            List<Job> jobList = new List<Job>();
            jobList.Add(job1);
            jobList.Add(job2);
            jobList.Add(job3);
            jobList.Add(job4);
            jobList.Add(job5);

            jobList.Sort();

            Assert.AreEqual(job5, jobList[0]);
            Assert.AreEqual(job4, jobList[1]);
            Assert.AreEqual(job3, jobList[2]);
            Assert.AreEqual(job2, jobList[3]);
            Assert.AreEqual(job1, jobList[4]);
        }

        [TestMethod]
        public void plusOperator()
        {
            Job first = new Job("mow yard", 2, 10);
            Job second = new Job("trim bushes", 1, 15);

            Job actual = first + second;

            Assert.AreEqual("mow yard and trim bushes", actual.Desc);
            Assert.AreEqual(3, actual.Hrs);
            Assert.AreEqual((first.Rate + second.Rate) / 2, actual.Rate);
        }

        [TestMethod]
        public void multiplePlusOperators()
        {
            Job first = new Job("mow yard", 2, 10);
            Job second = new Job("trim bushes", 1, 15);
            Job third = new Job("spread mulch", 2, 12);

            Job actual = first + second + third;

            Assert.AreEqual("mow yard and trim bushes and spread mulch", actual.Desc);
            Assert.AreEqual(5, actual.Hrs);
            Assert.AreEqual((((first.Rate + second.Rate) / 2) + third.Rate) / 2, actual.Rate);
        }
    }
}
