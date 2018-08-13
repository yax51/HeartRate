using System;
using System.Windows.Forms;

namespace ConsoleApp5

{

    class RateTest
    {
        static void Main(string[] args)
        {
            HeartRate me = new HeartRate();
            System.Windows.Forms.MessageBox.Show("Maximum Heart Rate is {0}. ", me.MaxRate());
            Console.WriteLine("Minimum Heart Rate is {0}. ", me.MinRate());
            Console.WriteLine("Your Name is: {0} ", me.FirstName + me.LastName);
            Console.WriteLine("You are {0} years old", me.GetAge());
                       

        }
    }

}