using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandNumGenerator
{
    internal class FibonachiSeries
    {
        public static void CreateFibSeries()
        //This method is used to create a list including first 10 elements of fibonacci series
        {
            int i;
            //Add first to elements of fibonacci series 0 and 1 to the list.
            Container.fibseries.Add(0);
            Container.fibseries.Add(1);
            //Starting from 2nd index, insert the other elements of fibonacci in the list.
            for (i = 2; i < 10; ++i)
                Container.fibseries.Insert(i, Container.fibseries[i - 1] + Container.fibseries[i - 2]);
        }
    }
}
