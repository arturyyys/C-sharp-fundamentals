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

         for (var index = 0; index < grades.Count; index += 1)
         {
            if (grades[index] == 42.1)
            {
               break; // jump out of a loop
               // continue; // skip specific condition and continues with the next iteration in the loop
            }
            result.Low = Math.Min(grades[index], result.Low);
            result.High = Math.Max(grades[index], result.High);
            result.Average += grades[index];
         };

         result.Average /= grades.Count;

         return result;
      }

      private List<double> grades;
      public string Name;
   }
}