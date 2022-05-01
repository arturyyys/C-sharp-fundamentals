using System;
using Xunit;

namespace GradeBook.Tests;

public class TypeTests
{
   [Fact]
   public void GetBookReturnDifferentObjects()
   {
      var book1 = GetBook("Book 1");
      var book2 = GetBook("Book 2");

      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 2", book2.Name);
      Assert.NotSame(book1, book2);
   }

   [Fact]
   public void TwoVarsCanReferenceSameObject()
   {
      var book1 = GetBook("Book 1");
      var book2 = book1;

      Assert.Same(book1, book2);
      Assert.True(Object.ReferenceEquals(book1, book2));
   }

   Book GetBook(string name)
   {
      return new Book(name);
   }
}