/* Park.cs
 * Author: Krista Smith
 * Date: 9/20/23
 * Description: The file contains the definition of the Park class.
 * */

namespace ParkApp
{
    public class Park
    {
        // properties
        public string ParkName { get; }
        public string Location { get; }
        public string ParkType { get; }
        public string? Facilities { get; set; }
        public decimal Fees { get; set; }
        public decimal NumEmployees { get; set; }
        public decimal NumVisitors { get; set; }
        public decimal Budget  { get; set; }

        public decimal Cost { get; set;  }

        public decimal Revenue { get; set;  }

        // constructors

        public Park(string name, string location, string type)
        {
            ParkName = name;
            Location = location;
            ParkType = type;
        }

        public Park(string name, string location, string type, string facilities)
        {
            ParkName = name;
            Location = location;
            ParkType = type;
            Facilities = facilities;
        }

        public Park(string name, string location, string type, string facilities, decimal fees, decimal visitors, decimal employees)
        {
            ParkName = name;
            Location = location;
            ParkType = type;
            Facilities = facilities;
            Fees = fees;
            NumVisitors = visitors;
            NumEmployees = employees;
        }
        public decimal CalculateCost(decimal NumVisitors, decimal Budget)
        {
            /* calculate cost per visitor based on annual budget and number
             * of visitors */
            decimal budget = Budget;
            decimal visitors = NumVisitors;
            return budget / visitors;
        }

        public decimal CalculateRevenue(decimal NumVisitors, decimal Fees)
        {
            /* calculate revenue based on fees per visitor multiplied by 
             * number of visitors
             */
            decimal fees = Fees;
            decimal visitors = NumVisitors;
            return fees * visitors;
        }



        public string threeVariables(string name, string location, string type)
        {
            /* method that returns a string representing the name of the park,
            / the location, type of park
            */

            string ParkName = name;
            string Location = location;
            string ParkType = type;

            return "\nPark name: " + ParkName + "\nLocation: " +
                 Location + "\nType of Park: " + ParkType;

        }
        public string fourVariables(string name, string location, string type, string facilities)
        {
            /* method that returns a string representing the name of the park,
            / the location, type of park, and facilities available
            */

            string ParkName = name;
            string Location = location;
            string ParkType = type;
            string Facilities = facilities;
            return "\nPark name: " + ParkName + "\nLocation: " +
                 Location + "\nType of Park: " + ParkType + "\nFacilities: "
                 + Facilities;
        }

        // Output
        public override string ToString()
        {
            // this will return all data members with labels
            return "\nPark Name: " + ParkName + "\nLocation: " + Location +
                "\nPark Type: " + ParkType + "\nAvailable facilities: " +
                Facilities + "\nFees: " + Fees.ToString("C") + "\nNumber of " +
                "employees: " + NumEmployees.ToString("N") + "\nVisitors: " 
                + NumVisitors.ToString("N") + "\nAnnual Budget: " + 
                Budget.ToString("C") + "\nCost per visitor: " + 
                Cost.ToString("C") + "\nRevenue: " + Revenue.ToString("C");
        }
    }
}
