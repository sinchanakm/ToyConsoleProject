using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations.Schema;

namespace Spring4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toy t = new Toy(1, "a", "t", 0, 40, 56.0, 5, 10000);
            //Console.WriteLine(t.ToString());
            CustomerService c1 = new CustomerServiceImpl();
            //c1.insert();

             CustomerServiceImpl c = new CustomerServiceImpl();
            c.display();

            // ToyService t = new ToyServiceImpl();
            // t.insert();
            // t.display();
            // Console.WriteLine("enter id u want to search");
            //  int id = int.Parse(Console.ReadLine());
            //Console.WriteLine( t.search(id));
            Console.ReadLine();

            //Customer c = new Customer(1, 1, "c$c", "p", "city", "state", "india");
            //Console.WriteLine(c.ToString());
            //Console.ReadLine();
        }
    }
    interface CustomerService
    {
        void insert();
        string search(int id,int n);
        void display(int n);
    }

    interface ToyService
    {
        void insert();
        string search(int id);
        void display();
    }
    public class Customer
    {
      //  [ForeignKey("Spring6ConsoleApp.Toy_Rental")]
        private int Customer_Id;
            private int Zip;



        private string Customer_Name, Password, City, State, Country;

        public int Customer_Id1 { get => Customer_Id; set => Customer_Id = value; }
        //public string Customer_Name1
        //{
        //    get
        //    {
        //        return Customer_Name;
        //    }
        //    set
        //    {
        //        bool chk = Check(value);



        //        if (chk)
        //        {
        //            try
        //            {
        //                if (value.Length < 6)
        //                {
        //                    throw new Exception("invalid name exception");
        //                    //throw new InvalidNameException("inavlid name");
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine(e.Message);
        //            }
        //        }
        //        else

        //            Customer_Name = value;
        //    }
        //}
        public string Customer_Name1
        {
            get => Customer_Name;
            set => Customer_Name = value;
        }
        //set
        //{
        //    var regexItem = new System.Text.RegularExpressions.Regex("^[a-zA-Z]$");
        //    try
        //    {
        //        if (Customer_Name1.Length >= 6 && regexItem.IsMatch(Customer_Name1))
        //        {
        //            Customer_Name = value;
        //        }
        //        else
        //        {
        //            throw new InvalidNameException();
        //        }
        //    }
        //    catch(InvalidNameException e1)
        //    {
        //        Console.WriteLine("Name should not contain less than 6 chars and special character");
        //    }
        //}
        //}
        public string Password1 { get => Password; set => Password = value; }
        public string City1 { get => City; set => City = value; }
        public string State1 { get => State; set => State = value; }
        public string Country1 { get => Country; set => Country = value; }
        public int Zip1 { get => Zip; set => Zip = value; }


        public Customer(int Customer_Id, int zip, string customer_Name, string password, string city, string state, string country)
        {
            bool chk = Check(customer_Name);
            try
            {



                if (chk)
                {
                    if (customer_Name.Length < 6)
                    {
                        throw new Exception("invalid name exception");
                        //throw new InvalidNameException("inavlid name");
                    }
                    else
                    {
                        Customer_Id1 = Customer_Id;
                        

                        Zip1 = zip;
                        Customer_Name1 = customer_Name;
                        Password1 = password;
                        City1 = city;
                        State1 = state;
                        Country1 = country;
                        Console.WriteLine("Customer Name is"+Customer_Name1);
        }
    }
}
            catch (Exception e)
            {
                Console.WriteLine("Invalid name");
            }



        }
        public override string ToString()
        {
            return Customer_Id1.ToString() + " " + Customer_Name1 + " " +
            Password1 + " " + City1 + " " + State1 + " " + Country1 + " " + Zip1.ToString();
        }



        public bool Check(string x)
        {
            char[] carray = x.ToCharArray();



            for (int i = 0; i < carray.Length; i++)
            {
                int c = carray[i];
                //if ((c > 47 & c < 58) | (c > 32 & c < 48))
                if((c>=97 && c<=122)|(c>=65 & c<=90))
                {
                    return true;
                }
            }



            return false;






        }

        class InvalidNameException : Exception
        {




        }






    }

    class Toy
    {
        public Toy()
        {

        }
        private int Toy_Id;
        private string Toy_Name, Toy_Type;
        private int Min_Age, Max_Age;
        private double Price, Quantity, Retail_Amount;

        public int Toy_Id1 { get => Toy_Id; set => Toy_Id = value; }
        public string Toy_Name1 { get => Toy_Name; set => Toy_Name = value; }
        public string Toy_Type1 { get => Toy_Type; set => Toy_Type = value; }
        //public int Min_Age1
        //{
        //    get { return Min_Age; }
        //    set
        //    {
        //        try
        //        {
        //            if (Min_Age1 <= 0)
        //            {
        //                throw new InvalidAgeException();
        //            }
        //            else
        //            {
        //                Min_Age = value;
        //            }
        //        }


        //        catch (InvalidAgeException a)
        //        {
        //            Console.WriteLine("age is not Valid");
        //        }
        //    }

        //}
        public int Min_Age1 { get =>Min_Age; set => Min_Age = value; }
        public int Max_Age1
        {
            get { return Max_Age; }
            set
            {
                try
                {
                    if (Max_Age1 >= 12)
                    {
                        throw new InvalidAgeException();
                    }
                    else
                    {
                        Max_Age = value;
                    }
                }


                catch (InvalidAgeException a)
                {
                    Console.WriteLine("age is not Valid");
                }
            }

        }
        //public int Max_Age1 { get => Max_Age; set => Max_Age = value; }
        public double Price1 { get => Price; set => Price = value; }
        public double Quantity1 { get => Quantity; set => Quantity = value; }
        public double Retail_Amount1 { get => Retail_Amount; set => Retail_Amount = value; }

       

        public Toy(int toy_Id, string toy_Name, string toy_Type, int min_Age, int max_Age, double price, double quantity, double retail_Amount) 
        {
            try
            {
                if (min_Age <= 0 || max_Age >= 12)
                {
                    throw new InvalidAgeException();
                }
                else
                {
                    Toy_Id1 = toy_Id;
                    Toy_Name1 = toy_Name;
                    Toy_Type1 = toy_Type;

                    Min_Age1 = min_Age;
                    Max_Age1 = max_Age;
                    Price1 = price;
                    Quantity1 = quantity;
                    Retail_Amount = retail_Amount;
                }
            }
            catch(InvalidAgeException a)
            {
                Console.WriteLine("age is not Valid");
            }
        }
        public override string ToString()
        {
            return Toy_Id1.ToString()+" "+Toy_Name1+" "+
                Toy_Type1+" "+Min_Age1.ToString()+" "+ Max_Age1.ToString() + " " + Price1.ToString()+" "+Quantity1.ToString() +" "+Retail_Amount1.ToString();
        }
    }
    public class InvalidAgeException : Exception
    {

    }
    class CustomerServiceImpl : CustomerService
    {
        static Customer[] CustomerArray = new Customer[5];
       
        public  void insert()
        {
            Console.WriteLine("Enter number customer u wnat to insert");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {


                Console.WriteLine("Enter Customer Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Zip");
                int zip = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Customer Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Customer Password");
                string p = Console.ReadLine();
                Console.WriteLine("Enter Customer City");
                string city = Console.ReadLine();
                Console.WriteLine("Enter Customer State");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Customer Country");
                string country = Console.ReadLine();

                CustomerArray[i] = new Customer(id, zip, name, p, city, state, country);
                FileStream fs = new FileStream(@"C:\Users\smohanraju\OneDrive - DXC Production\Documents\FileHandling\customer.csv", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                if (CustomerArray[i] != null)
                {
                    sw.WriteLine(CustomerArray[i].Customer_Id1+","+CustomerArray[i].Customer_Name1+","+CustomerArray[i].City1+","+CustomerArray[i].State1+","+CustomerArray[i].Country1+","+CustomerArray[i].Zip1);
                 }
                sw.Close();
                fs.Close();
            }
                display(n);
           
        }
        public  void display(int n)
        {
            Console.WriteLine("Customer Details are");
           // Console.WriteLine(CustomerArray[0].ToString());
            for (int i = 0; i < n; i++)
            {
                if (CustomerArray[i] != null)
                {
                    Console.WriteLine(CustomerArray[i].ToString());
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("enter id u want to search");
             int id = int.Parse(Console.ReadLine());

           Console.WriteLine( search( id,  n));
        }

        public void display()
        {
            FileStream fs = new FileStream(@"C:\Users\smohanraju\OneDrive - DXC Production\Documents\FileHandling\customer.csv", FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(fs);
            string data;
            while((data=r.ReadLine())!=null)
            {
                string[] line=data.Split(',');
                Console.WriteLine(line[0] + " " + line[1] + " " + line[2] + " " + line[3] + " " + line[4]);
            }
           


        }
        public string search(int id,int n)
        {

            for (int i = 0; i < n; i++)
            {
                if (CustomerArray[i] != null)
                {
                    if (CustomerArray[i].Customer_Id1 == id)
                    {
                        return CustomerArray[i].ToString();
                    }
                }
                else
                {
                    break;
                }
             
            }
            return "invalid input";
        }
        public string search(string name,int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (CustomerArray[i].Customer_Name1 == name)
                {
                    return CustomerArray[i].ToString();
                }


            }
            return "Invalid input";

        }


    }
    class ToyServiceImpl:ToyService
    {
        static Toy[] ToyArray = new Toy[5];
        public void insert()
        {
            Console.WriteLine("Enter number Toy u wnat to insert");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Toy Id");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Toy Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Toy Type");
                string type = Console.ReadLine();
                Console.WriteLine("Enter min age ");
                int minAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Max Age");
                int maxAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Price ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter qunatity of toy");
                double quantity = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Retail Amount");
                double retailAmount = double.Parse(Console.ReadLine());

                //ToyArray[i] = new Toy(id, name, type, minAge, maxAge, price,quantity,retailAmount);
                //FileStream fs = new FileStream(@"C:\Users\smohanraju\OneDrive - DXC Production\Documents\FileHandling\ToyDetails.csv", FileMode.Append, FileAccess.Write);
                //StreamWriter sw = new StreamWriter(fs);
                //if ([i] != null)
                //{
                //    sw.WriteLine(CustomerArray[i].Customer_Id1 + "," + CustomerArray[i].Customer_Name1 + "," + CustomerArray[i].City1 + "," + CustomerArray[i].State1 + "," + CustomerArray[i].Country1 + "," + CustomerArray[i].Zip1);
                //}
                //sw.Close();
                //fs.Close();

            }
        }
        public void display()
        {
            Console.WriteLine("Toy Deatils are");
            for (int i = 0; i < ToyArray.Length; i++)
            {
                if (ToyArray[i] != null)
                {
                    Console.WriteLine(ToyArray[i].ToString());
                }
                else
                {
                    break;
                }
                
            }

        }
        public string search(int id)
        {
            for (int i = 0; i < ToyArray.Length; i++)
            {
                if (ToyArray[i] != null)
                {
                    if (ToyArray[i].Toy_Id1 == id)
                    {
                        return ToyArray[i].ToString();
                    }
                }
                else
                {
                    break;
                }

            }
            return "invalid input";
        }
        public string search(string name)
        {
            for (int i = 0; i < ToyArray.Length; i++)
            {
                if (ToyArray[i] != null)
                {
                    if (ToyArray[i].Toy_Name1 == name)
                    {
                        return ToyArray[i].ToString();
                    }
                }
                else
                {
                    break;
                }

            }
            return "invalid input";

        }

    }


    class ElectronicToy:Toy
    {
        string numberofbatteries,
              operatingmode;

    }
    class MusicalToy
    {
        int noOfSpeakers;
    }
}

