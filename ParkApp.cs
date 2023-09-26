/* ParkApp.cs
 * Author: Krista Smith
 * Date: 9/20/23
 * Description: This class constructs an object of the Park class. The file includes test cases for the class.
 *  */

using static System.Console;

namespace ParkApp
{
    public class ParkApp
    {
        static void Main()
        {
            WriteLine("Information about parks that have already been entered: ");
            // (1) testing with only name, location, type of park given
            Park Yulie = new Park("Yulie", "Wyoming", "National");
            WriteLine(Yulie.threeVariables(Yulie.ParkName, Yulie.Location, Yulie.ParkType));

            // (2) testing with name, location, type of park and facilities given
            Park Heugonot = new Park("Heugonot", "Kerry GA", "State", "Hiking, Biking, Camping");
            WriteLine(Heugonot.fourVariables(Heugonot.ParkName, Heugonot.Location, Heugonot.ParkType, Heugonot.Facilities));

            // (test case 5: another example of computing cost and revenue)
            Park Yulie2 = new Park("Yulie", "Wyoming", "National", "Camping", 5, 100000, 500);
            Yulie2.Budget = 750000;
            WriteLine(Yulie2);
            WriteLine("Cost per visitor: {0:C}", Yulie2.CalculateCost(Yulie2.NumVisitors, Yulie2.Budget));
            WriteLine("Revenue: {0:C}", Yulie2.CalculateRevenue(Yulie2.NumVisitors, Yulie2.Fees));

            // second test case to only print name, location, type of park
            Park Arches = new Park("Arches", "Utah", "National");
            WriteLine(Arches.threeVariables(Arches.ParkName, Arches.Location, Arches.ParkType));

            // third test case to only print name, location, type of park
            Park Bryce = new Park("Bryce Canyon", "Moab, UT", "National");
            WriteLine(Bryce.threeVariables(Bryce.ParkName, Bryce.Location, Bryce.ParkType));

            // second case to test 4 variables - name, location, park type, and facilities
            Park Albion = new Park("Albion", "Northern Utah", "State", "Hiking, Camping");
            WriteLine(Albion.fourVariables(Albion.ParkName, Albion.Location, Albion.ParkType, Albion.Facilities));

            // third case to test 4 variables - name, location, park type, and facilities
            Park Yellowstone = new Park("Yellowstone", "WY", "National", "Hiking, Camping");
            WriteLine(Yellowstone.fourVariables(Yellowstone.ParkName, Yellowstone.Location, Yellowstone.ParkType, Yellowstone.Facilities));

            // clear screen
            WriteLine();
            WriteLine("Press any key to continue.");
            ReadKey();
            Clear();

            // (3) testing with only name, location, type of park and facilities to start
            Park Hayworth = new Park("Hayworth", "Nebraska", "Local", "No facilities");
            WriteLine("Input information for Hayworth park: ");
            try
            {
                Hayworth.NumVisitors = GetVisitors();
                Hayworth.NumEmployees = GetEmployees();
                Hayworth.Budget = GetBudget();
                Hayworth.Cost = Hayworth.CalculateCost(Hayworth.NumVisitors, Hayworth.Budget);
                Hayworth.Fees = GetFees();
                Hayworth.Revenue = Hayworth.CalculateRevenue(Hayworth.NumVisitors, Hayworth.Fees);
                WriteLine(Hayworth);

                // clear screen
                WriteLine("Press any key to continue.");
                ReadKey();
                Clear();

                // test case for accepting visitors, employees, budget from user
                WriteLine("Input the requested information for Central Park: ");
                Park Central = new Park("Central", "New York", "Local");
                Central.NumVisitors = GetVisitors();
                Central.NumEmployees = GetEmployees();
                Central.Budget = GetBudget();
                Central.Fees = GetFees();
                Central.Cost = Central.CalculateCost(Central.NumVisitors, Central.Budget);
                Central.Revenue = Central.CalculateRevenue(Central.NumVisitors, Central.Fees);

                // clear screen
                WriteLine("Press any key to continue.");
                ReadKey();
                Clear();


                // display information for park object
                WriteLine(Central);
            }
            catch (Exception)
            {
                WriteLine("Error: Cannot parse input.");
            }
        }

        static decimal GetVisitors()
        {
            // method that asks for amount of visitors
            WriteLine("Number of visitors last year: ");
            string inVal = ReadLine();
            decimal NumVisitors = decimal.Parse(inVal);
            return NumVisitors;
        }

        static decimal GetEmployees()
        {
            // method that asks for number of employees
            WriteLine("Number of employees: ");
            string inVal = ReadLine();
            decimal NumEmployees = decimal.Parse(inVal);
            return NumEmployees;
        }

        static decimal GetBudget()
        {
            // method that asks for annual budget

            Write("Annual budget: ");
            string inVal = ReadLine();
            decimal Budget = decimal.Parse(inVal);
            return Budget;

        }

        static decimal GetFees()
        {
            // method that asks for fees
            WriteLine("Required fees: ");
            string inVal = ReadLine();
            decimal fees = decimal.Parse(inVal);
            return fees;
        }



    }
}