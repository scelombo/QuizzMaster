using NUnit.Framework;
using QuizzMaster.Quizz;

namespace QuizzMasterTest.Quizz
{
  public class PalindromeTest
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SameWord_ShouldReturn_True()
    {
      //Arrange
      var first = "same";
      var last = "same";

      //Process
      var result = Palindrome.IsPalindrome(first, last);

      //Assert
      Assert.AreEqual(true, result);
    }

    [Test]
    public void SameWord_DifferentCase_ShouldReturn_True()
    {
      //Arrange
      var first = "Same";
      var last = "sAmE";

      //Process
      var result = Palindrome.IsPalindrome(first, last);

      //Assert
      Assert.AreEqual(true, result);
    }

    [Test]
    public void DifferentWords_ShouldReturn_False()
    {
      //Arrange
      var first = "Not";
      var last = "Same";

      //Process
      var result = Palindrome.IsPalindrome(first, last);

      //Assert
      Assert.AreEqual(false, result);
    }

    [Test]
    public void DifferentStrings_ShouldReturn_False()
    {
      //Arrange
      var first = "altittude";
      var last = "attitude";


      //Process
      var result = Palindrome.IsPalindrome(first, last);

      //Assert
      Assert.AreEqual(false, result);
    }
    
    [Test]
    public void PalindromeDigits_ShouldReturn_True()
    {
      //Arrange
      var first = "58236";
      var last = "68532";

      //Process
      var result = Palindrome.IsPalindrome(first, last);

      //Assert
      Assert.AreEqual(true, result);
    }

    [Test]
    public void PalindromeSigns_ShouldReturn_True()
    {
      //Arrange
      var first = "!@#$%^&*()";
      var last = "^&*()!@#$%";

      //Process
      var result = Palindrome.IsPalindrome(first, last);

      //Assert
      Assert.AreEqual(true, result);
    }
  }
}
