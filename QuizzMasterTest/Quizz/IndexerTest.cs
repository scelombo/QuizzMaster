using NUnit.Framework;
using QuizzMaster.Quizz;

namespace QuizzMasterTest
{
  public class IndexerTest
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void List_1_Search20_ShouldReturn1()
    {
      //Arrange
      var array = new int[] { 1 };
      var searchVal = 20;

      //Process
      var ans = Indexer.GetClosest(array, searchVal);

      //Assert
      Assert.AreEqual(1, ans);
    }

    [Test]
    public void List_1_3_9_20_Search7_ShouldReturn9()
    {
      //Arrange
      var array = new int[] { 1, 3, 9, 20 };
      var searchVal = 7;

      //Process
      var ans = Indexer.GetClosest(array, searchVal);

      //Assert
      Assert.AreEqual(9, ans);
    }


    [Test]
    public void List_NEG6_8_NEG5_0_Search4_ShouldReturn3()
    {
      //Arrange
      var array = new int[] { -6, 8, -5, 3 };
      var searchVal = 4;

      //Process
      var ans = Indexer.GetClosest(array, searchVal);

      //Assert
      Assert.AreEqual(3, ans);
    }


    [Test]
    public void List_NEG4_0_SearchNEG7_ShouldReturnNEG4()
    {
      //Arrange
      var array = new int[] { -4, 0 };
      var searchVal = -7;

      //Process
      var ans = Indexer.GetClosest(array, searchVal);

      //Assert
      Assert.AreEqual(-4, ans);
    }


    [Test]
    public void List_6_8_9_NEG5_SearchZero_ShouldReturn()
    {
      //Arrange
      var array = new int[] { 6, 8, 9, -5 };
      var searchVal = 0;

      //Process
      var ans = Indexer.GetClosest(array, searchVal);

      //Assert
      Assert.AreEqual(-5, ans);
    }
  }
}