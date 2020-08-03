using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring6ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class ToyRental
    {
        int Rental_Id;
        int Customer_Id;
        int Toy_Id;
        DateTime Rental_Start_Date;
        DateTime Rental_End_Date;
        double Rental_Amount_Per_Day;
        double fine;
        string status;
    }


   interface ToyRentalService
    {

    }
   class ToyRentalServiceImpl:ToyRentalService
    {

    }
}
