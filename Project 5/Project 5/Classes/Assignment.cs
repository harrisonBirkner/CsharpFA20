using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    [Serializable]
    public class Assignment
    {
        private string name;
        private double pointsEarned;
        private double pointsPossible;

        public string Name { get => name; set => name = value; }
        public double PointsEarned { get => pointsEarned; set => pointsEarned = value; }
        public double PointsPossible { get => pointsPossible; set => pointsPossible = value; }

        public Assignment(string name, double pointsEarned, double pointsPossible)
        {
            Name = name;
            PointsEarned = pointsEarned;
            PointsPossible = pointsPossible;
        }
    }
}
