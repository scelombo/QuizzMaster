﻿using System.Linq;

namespace QuizzMaster.Quizz
{
  public static class Palindrome
  {
    public static bool IsPalindrome(string first, string second)
    { 
      first = first.ToLower();
      second = second.ToLower();

      var str1 = first.ToCharArray().Distinct().ToList();
      var str2 = second.ToCharArray().Distinct().ToList();


      if (str1.Count != str2.Count)
      return false;

      var palindrome = true;

      str1.ForEach(ch =>
      {
        if (first.ToCharArray().Count(l => l == ch) != second.ToCharArray().Count(l => l == ch))
        {
          palindrome = false;
          return;
        }
      });

      return palindrome;
    }
  }
}
