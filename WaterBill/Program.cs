using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
    class Program
    {
        const double VAT_RATE = 0.01;
        const double ENVIRONMENT_RATE = 0.01;
        const double HOUSEHOLD_PRICE_1 = 5.973;
        const double HOUSEHOLD_PRICE_2 = 7.052;
        const double HOUSEHOLD_PRICE_3 = 8.699;
        const double HOUSEHOLD_PRICE_4 = 15.929;
        const double AGENCY_PRICE = 9.955;
        const double PRODUCTION_PRICE = 11.615;
        const double BUSINESS_PRICE = 22.068;

        // Define constants and arrays to store customer data
        const int MAX_CUSTOMERS = 100;
        static string[] customerNames = new string[MAX_CUSTOMERS];
        static double[] billTotals = new double[MAX_CUSTOMERS];
        static int customerCount = 0;

        static int TypeOfCustomer()
        {
            Console.WriteLine("Type a customer: \n\t1. Household customer" +
                    "                               \n\t2. Administrative agency, public services" +
                    "                               \n\t3. Production units" +
                    "                               \n\t4. Business services");
            int type;
            while (true)
            {
                Console.Write("Enter your type (1-4): ");
                type = int.Parse(Console.ReadLine());
                if (type >= 1 && type <= 4)
                    break;
                Console.Write("Invalid customer type. Please enter a number from 1 to 4.");
            }
            return type;
        }

        // Calculate consumption
        static double AmountOfConsumption()
        {
            Console.Write("Enter last month’s water meter readings: ");
            double lastWaterMeter = double.Parse(Console.ReadLine());
            //Check if thisWaterMeter < lastWaterMeter
            double thisWaterMeter;
            do
            {
                Console.Write("Enter this month’s water meter readings: ");
                thisWaterMeter = double.Parse(Console.ReadLine());
                if (thisWaterMeter < lastWaterMeter)
                    Console.WriteLine("This month's water meter reading should be greater than last month's. Please re-enter.");
            }

            while (thisWaterMeter < lastWaterMeter);

            double consumption = thisWaterMeter - lastWaterMeter;

            return consumption;
        }

        // Calculate prices based on customer type
        static double Price(int type, double consumption)
        {
            double price = default;

            switch (type)
            {
                case 1:
                    if (consumption > 0 && consumption <= 10)
                    {
                        price = consumption * HOUSEHOLD_PRICE_1;
             
                    }
                    else if (consumption > 10 && consumption <= 20)
                    {
                        price =  consumption * HOUSEHOLD_PRICE_2;
                    }
                    else if (consumption > 20 && consumption <= 30)
                        price = consumption * HOUSEHOLD_PRICE_3;
                    else
                        price = consumption * HOUSEHOLD_PRICE_4;
                    break;
                case 2:
                    price = consumption * AGENCY_PRICE;
                    break;

                case 3:
                    price = consumption * PRODUCTION_PRICE;
                    break;
                case 4:
                    price = consumption * BUSINESS_PRICE;
                    break;
                default:
                    return 0;
            }
            return price;
        }
        // Calculate totalBill based on price, VAT and ENVIROMENT fee
        //********************  Total Bill  ********************
        static double CalculatWaterBill(double price)
         {
            double environmentFees = price * ENVIRONMENT_RATE;

            double fee = price * VAT_RATE;

            double totalBill = price + environmentFees + fee;

            Console.WriteLine($"Total water bill: {totalBill} VND");

            return totalBill;
         }

        //****************  Add customer  ********************
        static void AddCustomerAndBill()
        {
            
            // Check if arrays are full
            if (customerCount >= MAX_CUSTOMERS)
            {
                Console.WriteLine("Customer database is full. Cannot add more customers.");
            }

            bool add = true;
            while (add)
            {
                Console.Write("Enter customer name: ");
                string customerName = Console.ReadLine().ToLower();

                Console.Write("Enter customer's bill: ");
                double totalBill = double.Parse(Console.ReadLine());

                // Add customer and bill to arrays
                customerNames[customerCount] = customerName;
                billTotals[customerCount] = totalBill;
                customerCount++;

                Console.Write("Do you want to continue adding users?? (yes/no): ");
                string choose = Console.ReadLine().ToLower();
                if (choose == "no")
                {
                    add = false;
                }
            }
            Console.WriteLine("List of customers: ");
            for (int i = 0; i < customerCount; i++)
            {
                Console.WriteLine($"{ customerNames[i]}: { billTotals[i]}");
            }
        }
        //********************  Find customer by name  ********************
        static void FindCustomer()
        {
            bool find = true;

            while (find)
            {
                Console.WriteLine("Enter the user name you want to search: ");
                string findName = Console.ReadLine().ToLower();
                bool found = false;
                for (int i = 0; i < customerCount; i++)
                {
                    if (findName == customerNames[i])
                    {
                        Console.WriteLine($"User {findName} found at index {i + 1}.");
                        found = true;
                        break; // Once found, exit the loop
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"User {findName} not found.");
                }
                Console.Write("Do you want to continue finding users? (yes/no): ");
                string choose = Console.ReadLine().ToLower();
                if (choose != "yes")
                {
                    find = false;
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("================= WATER BILLING PROGRAM =================\n");
            Console.Write("Enter your name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine($"\nWelcome {customerName} to the water billing program!!\n");
            Console.WriteLine("=========================================================");

            bool flag = true;
            // Enter the option you want:
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("\t1. Calculate water bill");
            Console.WriteLine("\t2. Add customer");
            Console.WriteLine("\t3. Find customer by name");
            Console.WriteLine("\t4. Sort customers by name");
            Console.WriteLine("\t5. Exit");
            while (flag)
            {
                Console.Write("Enter your choice (1-5): ");
                int choice = int.Parse(Console.ReadLine());
                while (choice < 1 || choice > 5)
                {
                    Console.Write("Please enter a number from 1 to 5: ");
                    choice = int.Parse(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("*********************************************************");
                        Console.WriteLine("CALCULATE WATER BILL");
                        int type = TypeOfCustomer();
                        double consumption = AmountOfConsumption();
                        double price = Price(type, consumption);
                        CalculatWaterBill(price);
                        break;
                    case 2:
                        Console.WriteLine("*********************************************************");
                        Console.WriteLine("ADD CUSTOMER AND BILL");
                        AddCustomerAndBill();
                        break;
                    case 3:
                        Console.WriteLine("*********************************************************");
                        Console.WriteLine("FIND CUSTOMER BY NAME");
                        FindCustomer();
                        break;
                    case 4:
                        // Implement SortCustomers method
                        break;
                    case 5:
                        Console.WriteLine("Exiting program.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice...");
                        break;
                }
                Console.WriteLine("=========================================================");
                Console.Write("\nDo you want to continute WATER BILLING PROGRAM? (yes/no): ");
                string continuer = Console.ReadLine().ToLower();
                if (continuer != "yes")
                {
                    flag = false;
                }
            }
            
        }
    }
}
