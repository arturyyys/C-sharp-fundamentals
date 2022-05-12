namespace GradeBook
{
   public delegate void GradeAddedDelegate(object sender, EventArgs args);

   public class NamedObject
   {
      public NamedObject(string name)
      {
         Name = name;
      }

      public string Name
      {
         get;
         set;
      }
   }

   public interface IBook
   {
      void AddGrade(double grade);
      Statistics GetStatistics();
      string Name { get; }
      event GradeAddedDelegate GradeAdded;
   }

   public abstract class Book : NamedObject, IBook
   {
      public Book(string name) : base(name)
      {
      }

      public abstract event GradeAddedDelegate GradeAdded;
      public abstract void AddGrade(double grade);
      public abstract Statistics GetStatistics();
   }

   public class DiskBook : Book
   {
      public DiskBook(string name) : base(name)
      {
      }

      public override event GradeAddedDelegate GradeAdded;

      public override void AddGrade(double grade)
      {
         var writer = File.AppendText($"{Name}.txt");
         writer.WriteLine(grade);
      }

      public override Statistics GetStatistics()
      {
         throw new NotImplementedException();
      }
   }

   public class InMemoryBook : Book
   {
      public InMemoryBook(string name) : base(name)
      {
         grades = new List<double>();
         Name = name;
      }

      public void AddGrade(char letter)
      {
         switch (letter)
         {
            case 'A':
               AddGrade(90);
               break;

            case 'B':
               AddGrade(80);
               break;

            case 'C':
               AddGrade(70);
               break;

            default:
               AddGrade(0);
               break;
         }
      }

      public override void AddGrade(double grade)
      {
         if (grade <= 100 && grade >= 0)
         {
            grades.Add(grade);
            if (GradeAdded != null)
            {
               GradeAdded(this, new EventArgs());
            }
         }
         else
         {
            throw new ArgumentException($"Invalid {nameof(grade)}");
         }
      }

      public override event GradeAddedDelegate GradeAdded;

      public override Statistics GetStatistics()
      {
         var result = new Statistics();
         result.Average = 0.0;
         result.High = double.MinValue;
         result.Low = double.MaxValue;

         var book = new InMemoryBook("Scott's Grade Book");
         book.AddGrade(89.1);
         book.AddGrade(90.5);
         book.AddGrade(77.5);

         for (var index = 0; index < grades.Count; index += 1)
         {
            if (grades[index] == 42.1)
            {
               break;
            }
            result.Low = Math.Min(grades[index], result.Low);
            result.High = Math.Max(grades[index], result.High);
            result.Average += grades[index];
         };

         result.Average /= grades.Count;

         switch (result.Average)
         {
            case var d when d >= 90.0:
               result.Letter = 'A';
               break;

            case var d when d >= 80.0:
               result.Letter = 'B';
               break;

            case var d when d >= 70.0:
               result.Letter = 'C';
               break;

            case var d when d >= 60.0:
               result.Letter = 'D';
               break;

            default:
               result.Letter = 'F';
               break;
         }

         return result;
      }

      private List<double> grades;

      public string Name
      {
         get;
         set;
      }

      public const string CATEGORY = "Science";
   }
}