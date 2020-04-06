using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizzMaster.Quizz
{
  public static class Indexer
  {

    ///Received an arrao with numbers and a search value, it should return the closest number within the array elements 
    ///Example {6,8,9,-5} , 0 : Sould return -5
    public static int GetClosest(int [] values, int searchValue)
    {
      var min = 0;
      var max = 0;
      var lstValues = values.ToList().OrderBy(t => t);

      if (lstValues.Any(t => t <= searchValue))
        min = lstValues.OrderByDescending(t => t).Where(t => t <= searchValue).FirstOrDefault();
      else
        return lstValues.OrderBy(t => t).Where(t => t >= searchValue).FirstOrDefault();

      if (lstValues.Any(t => t >= searchValue))
        max = lstValues.OrderBy(t => t).Where(t => t >= searchValue).FirstOrDefault();
      else
        return min;

      return (searchValue - min) <= (max - searchValue) ? min : max;
    }
  }
}
