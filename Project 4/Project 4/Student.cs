using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    [Serializable]
    public class Student : IComparable
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Trim().Length > 0)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name required for student creation");
                }
            }
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CompareTo(object obj)
        {
            Student temp = (Student)obj;

            if (this.Id > temp.Id)
            {
                return 1;
            }
            else if (this.Id < temp.Id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "My name is " + this.Name + " and my student id is #" + this.Id;
        }
    }

    [Serializable]
    public class DormStudent : Student
    {
        private DormLocation location;
        private MealPlan mealPlan;
        public DormLocation Location { get => location; set => location = value; }
        public MealPlan MealPlan { get => mealPlan; set => mealPlan = value; }

        public DormStudent(int id, string name, DormLocation location, MealPlan mealPlan) : base(id, name)
        {
            Location = location;
            MealPlan = mealPlan;
        }

        public override string ToString()
        {
            return base.ToString() + ". I live in " + this.Location + " and I have the " + this.MealPlan + " meal plan";
        }
    }
}
