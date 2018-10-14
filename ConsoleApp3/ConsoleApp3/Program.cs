using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    public class Workflow
    {
        List<IActivities> ActivityList = new List<IActivities>();

        public void AddActivity(IActivities activity)
        {
            ActivityList.Add(activity);
        }

        public void RunActivities()
        {
            foreach (var activity in ActivityList)
            {
                activity.Execute();
            }
        }
    }

    public class SearchingCar : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Searching for a new car.");
            Console.WriteLine();
        }
    }
    public class BuyingCar : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Buying a new car.");
            Console.WriteLine();
        }
    }
    public class DrivingCar : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Driving the car for 5 years");
            Console.WriteLine();
        }
    }
    public class SellingCar : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Selling the car");
            Console.WriteLine();
        }
    }

    public interface IActivities
    {
        void Execute();
    }
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new SearchingCar());
            workflow.AddActivity(new BuyingCar());
            workflow.AddActivity(new DrivingCar());
            workflow.AddActivity(new SellingCar());

            workflow.RunActivities();
            Console.Read();
        }
    }
}