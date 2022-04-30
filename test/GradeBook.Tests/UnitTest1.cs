using System;
using Xunit;

namespace GradeBook.Tests;

public class UnitTest1
{
  [Fact]
  public void Test1()
  {
    // triple a = arrange => act => assert
    // arrange section
    var x = 5;
    var y = 2;
    var actual = x + y;

    // act section
    var expected = 7;

    // assert section
    Assert.Equal(expected, actual);
  }
}