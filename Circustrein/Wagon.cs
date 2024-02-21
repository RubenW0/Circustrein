using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    internal class Wagon
    {
        private int Points {  get; set; }

        public Wagon()
        {
            Points = 0;
        }

        public bool AddPoints(int pointsToAdd)
        {
            if (Points + pointsToAdd <= 10)
            {
                Points = Points + pointsToAdd;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
