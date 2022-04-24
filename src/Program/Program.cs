using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "4.912.256-8");
            Person jane = new Person("Jane Doe", "2.613.472-0");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
