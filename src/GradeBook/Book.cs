namespace GradeBook
{
   public class Book
   {
      public Book(string name)
      {
         grades = new List<double>();
         Name = name;
      }
      public void AddGrade(double grade)
      {
         if (grade <= 100 && grade >= 0)
         {
            grades.Add(grade);
         }
         else
         {
            Console.WriteLine("Invalid value!");
         }
      }
      public Statistics GetStatistics()
      {
         var result = new Statistics();
         result.Average = 0.0;
         result.High = double.MinValue;
         result.Low = double.MaxValue;

         var book = new Book("Scott's Grade Book");
         book.AddGrade(89.1);
         book.AddGrade(90.5);
         book.AddGrade(77.5);

         foreach (var grade in grades)
         {
            result.Low = Math.Min(grade, result.Low);
            result.High = Math.Max(grade, result.High);
            result.Average += grade;
         }
         System.Console.WriteLine("That is lowest grade" + " " + result.Low);
         System.Console.WriteLine("That is highest grade" + " " + result.High);
         System.Console.WriteLine("That is average grade" + " " + result.Average);

         // output: That is lowest grade 77.5
         //         That is highest grade 90.5
         //         That is average grade 257.1

         // for (var index = 0; index < grades.Count; index += 1)
         // {
         //    result.Low = Math.Min(grades[index], result.Low);
         //    result.High = Math.Max(grades[index], result.High);
         //    result.Average += grades[index];
         // };

         // var index = 0;
         // while (index < grades.Count)
         // {
         //    result.Low = Math.Min(grades[index], result.Low);
         //    result.High = Math.Max(grades[index], result.High);
         //    result.Average += grades[index];
         //    index += 1; // index++;
         // };

         // var index = 0;
         // do
         // {
         //    result.Low = Math.Min(grades[index], result.Low);
         //    result.High = Math.Max(grades[index], result.High);
         //    result.Average += grades[index];
         //    index += 1; // index++;
         // } while (index < grades.Count);



         result.Average /= grades.Count;

         return result;
      }

      private List<double> grades;
      public string Name;
   }
}