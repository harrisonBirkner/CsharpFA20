using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_pt_1
{
    public class Job : IComparable
    {
        private string desc;
        private double hrs;
        private double rate;

        public string Desc { get => desc; set => desc = value; }
        public double Hrs { get => hrs; set => hrs = value; }
        public double Rate { get => rate; set => rate = value; }

        //Default constructor
        public Job() : this("mow yard", 1, 10) { }

        //Constructor w/ variable description
        public Job(string desc) : this(desc, 1, 10) { }

        //Constructor with all properties variable
        public Job(string desc, double hrs, double rate)
        {
            Desc = desc;
            Hrs = hrs;
            Rate = rate;
        }

        /// <summary>
        /// Returns the product of a Job object's Hrs and Rate properties
        /// </summary>
        /// <returns></returns>
        double CalcFee()
        {
            return Hrs * Rate;
        }

        /// <summary>
        /// Override of method that compares results of CalcFee method and uses it to determine which Job object is greater
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        int IComparable.CompareTo(Object o)
        {
            Job temp = (Job)o;

            if (this.CalcFee() > temp.CalcFee())
            {
                return 1;
            }
            else if (this.CalcFee() < temp.CalcFee())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        //
        /// <summary>
        /// Adds two Job objects together by concatenating description, summing hours, averaging rate and returns a new Job object with the new values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Job operator +(Job first, Job second)
        {
            string newDesc = first.Desc + " and " + second.Desc;
            double newHrs = first.Hrs + second.Hrs;
            double newRate = (first.Rate + second.Rate) / 2;
     
            return (new Job(newDesc, newHrs, newRate));
        }
    }
}
