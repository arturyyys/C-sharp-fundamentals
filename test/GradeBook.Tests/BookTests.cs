using System;
using Xunit;

namespace GradeBook.Tests;

public class BookTests
{
   [Fact]
   public void Test1()
   {
      // triple a = arrange => act => assert
      // arrange section
      var book = new Book("");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.3);

      // act section
      book.ShowStatistics();


      // assert section

   }
}