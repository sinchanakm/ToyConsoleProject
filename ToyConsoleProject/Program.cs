using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sprint3.Input();
            //Console.ReadKey();
            Sprint3 s = new Sprint3();
            s.p();
            Console.ReadKey();
        }
    }
    class Sprint3
    {
        //a program to accept the five toys name in an array and display the toys in an ascending order
        public static void Input()
        {
            Console.WriteLine("Enter 5 toy details");
            string[] s = new string[5];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " toy details");
                s[i] = Console.ReadLine();


            }
            Array.Sort(s);
            Console.WriteLine("Toy Details in Sorted Order");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);



            }


            //program to get the input as integer and pass as input to switch case to display the toys with respect to age.

            Console.WriteLine("Enter age");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 5:
                    Console.WriteLine(s[0]);
                    break;
                case 10:
                    Console.WriteLine(s[1]);
                    break;
                case 15:
                    Console.WriteLine(s[2]);
                    break;
                case 20:
                    Console.WriteLine(s[3]);
                    break;
                default:
                    Console.WriteLine("Invalid age");
                    break;

            }

        }





        public string name, address, cid;

        public void p()
        {
            string[,,] s = new string[3, 3, 3];
            Console.WriteLine("Enter customer id name and adreess");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        s[i, j, k] = Console.ReadLine();
                    }
                }

            }


        }
        bool Liner_search(string[,,] a)
        {
            Console.WriteLine("Enter the Customer Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        if (Equals(a[i, j, k], name) == true)
                            return true;

                    }
                }
            }
            return false;
        }

    }
}





//namespace Sprint3_CaseStudy1

//{

//    Create a program to accept the five toys name in an array and display the toys in an ascending order

//  class Sprint3

//    {

//        static void Main(string[] args)

//        {

//            int n = 5;

//            string[] toys = new string[n];

//            Console.WriteLine("Enter the toy names: ");

//            for (int i = 0; i < toys.Length; i++)

//            {

//                toys[i] = Console.ReadLine();

//            }

//            int l = toys.Length; for (int i = 0; i < l; i++)

//            {

//                for (int j = 0; j < l - 1; j++)

//                {

//                    if (toys[j].CompareTo(toys[j + 1]) > 0)

//                    {

//                        string temp = toys[j];

//                        toys[j] = toys[j + 1];

//                        toys[j + 1] = temp;

//                    }

//                }

//            }

//            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

//            Console.WriteLine("The names of toys in ascending order are: ");

//            for (int i = 0; i < l; i++)

//            {

//                Console.WriteLine(toys[i] + " ");

//            }

//            Sprint3 s1 = new Sprint3();

//            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

//            s1.Sort_Display_Asc(toys);

//            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

//            s1.Multi_DArray();

//            Console.ReadLine();

//        }

//        Write a program to get the input as integer and pass as input to switch case to display the toys with respect to age.

//        void Sort_Display_Asc(string[] toys)

//        {

//            Console.WriteLine("Enter the age :");

//            int age = Convert.ToInt32(Console.ReadLine());

//            int l = toys.Length; if (age < 10)

//            {

//                for (int i = 0; i <= l - 3; i++)

//                {

//                    Console.WriteLine(toys[i] + " ");

//                }

//            }

//            else if (age >= 10 & age <= 15)

//            {

//                for (int i = 2; i < l - 1; i++)

//                {

//                    Console.WriteLine(toys[i] + " ");

//                }

//            }

//            else

//            {

//                for (int i = 3; i < l; i++)

//                {

//                    Console.WriteLine(toys[i] + " ");

//                }

//            }

//        }          //3.    Create a program with multi-dimensional array to store customerDetails (customerId,name ,address) array. This program should sort the customer based on the customer id.

//        void Multi_DArray()

//        {

//            Console.WriteLine("Enter the three numbers to make 3-D array: ");

//            int n = int.Parse(Console.ReadLine());

//            int m = int.Parse(Console.ReadLine());

//            int l = int.Parse(Console.ReadLine());

//            string[,,] a = new string[n, m, l];

//            Console.WriteLine("Enter the values for Customer id, name & address respectively :");

//            for (int i = 0; i < n; i++)

//            {

//                for (int j = 0; j < m; j++)

//                {

//                    for (int k = 0; k < l; k++)

//                    {

//                        a[i, j, k] = Console.ReadLine();

//                    }

//                }

//            }

//            Sprint3 s2 = new Sprint3();

//            Console.WriteLine("Result of Linear Search is...................................");

//            bool flag = s2.Liner_search(a);

//            if (flag == true)

//            {

//                Console.WriteLine("Customer is present.");

//            }

//            else

//            {

//                Console.WriteLine("Customer is present.");

//            }

//            Console.WriteLine("Result of Binary Search is...................................");

//            bool flag1 = s2.Binary_search(a);

//            if (flag1 == true)

//            {

//                Console.WriteLine("Customer is present");

//            }

//            else

//            {

//                Console.WriteLine("Customer is not Present");

//            }

//            Console.ReadLine();

//        }          //4.    Create a program to search the customer based on the customer name using linear search algorithm,

//        bool Liner_search(string[,,] a)

//        {

//            Console.WriteLine("Enter the Customer Name: ");

//            string name = Console.ReadLine(); for (int i = 0; i < a.GetLength(0); i++)

//            {

//                for (int j = 0; j < a.GetLength(1); j++)

//                {

//                    for (int k = 0; k < a.GetLength(2); k++)

//                    {

//                        if (Equals(a[i, j, k], name) == true)

//                            return true;
//                    }

//                }

//            }

//            return false;

//        }          //5.    Create a program to search the customer based on the customer city using binary search algorithm

//        bool Binary_search(string[,,] a)

//        {

//            Console.WriteLine("Enter the Customer's City Name: ");

//            string city = Console.ReadLine();          //    int index = Array.BinarySearch(a, city);

//            if (index > 0)

//            {

//                return true;

//            }

//            else

//            {

//                return false;

//            }

//        }
//    }

//}



