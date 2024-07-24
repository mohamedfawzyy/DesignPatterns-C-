using AbstractFactoryDesignPattern;
using CreationalDessignPatterns;
using FactoryDesignPattern;

namespace DessignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sigleton
            /* Singleton Design pattern
            Singleton singleton1 = Singleton.getInstance();
            Singleton singleton2 = Singleton.getInstance();
            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());
            */

            #endregion

            #region Factory
            /*
      string CreditType = "MoneyBank";
      ICreditCard creditCard = CreditCardFactory.GetCreditCard(CreditType);
      if (creditCard != null)
      {
          Console.WriteLine($"CreditCardType {creditCard.GetCardType()}");
          Console.WriteLine($"CreditCardLimit {creditCard.GetCardLimit()}");
          Console.WriteLine($"CreditCardNumber {creditCard.GetCardNumber()}");
      }
      else
      {
          Console.WriteLine("Credit Card is not Valid !!!");
      }
      */
            #endregion

            #region Abstract Factory
            var onlineCoursesFactory=new OnlineCourseFactory();
            var course=onlineCoursesFactory.CreateCourse();
            var source=onlineCoursesFactory.CreateSource();
            Console.WriteLine($"course type : {course.getCourseName()}");
            Console.WriteLine($"Course Duration : {course.getCourseDuration()}");
            Console.WriteLine($"Course Fees :{course.getCourseFees()}");
            Console.WriteLine($"Course source: {source.GetSourceType()}");
            Console.WriteLine("----------------------------------------");
            var offlineCoursesFactory = new OfflineCourseFactory();
            var course1 = offlineCoursesFactory.CreateCourse();
            var source1 = offlineCoursesFactory.CreateSource();
            Console.WriteLine($"course type : {course1.getCourseName()}");
            Console.WriteLine($"Course Duration : {course1.getCourseDuration()}");
            Console.WriteLine($"Course Fees :{course1.getCourseFees()}");
            Console.WriteLine($"Course source: {source1.GetSourceType()}");
            #endregion


        }
    }
}
