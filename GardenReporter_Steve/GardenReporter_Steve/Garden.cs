using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenReporter_Steve
{
    public class Garden
    {
        //====================================================
        // Private data fields
        //====================================================
        private double gardenWidth;
        private double gardenHeight;
        private string ownerName;
        List<double> currentCharges;

        //====================================================
        // Public data property
        //====================================================
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        //====================================================
        // Constructor
        //====================================================
        public Garden(double gardenWidth, double gardenHeight, string ownerName)
        {
            // Assign input argument variables to class data members
            this.gardenWidth = gardenWidth;
            this.gardenHeight = gardenHeight;
            this.ownerName = ownerName;

            // Allocate memory for list
            currentCharges = new List<double>();
        }

        //====================================================
        // Add a new charge to the list of charges using List<T>.Add
        //====================================================
        public void AddCharge(double newCharge)
        {
            currentCharges.Add(newCharge);
        }

        //====================================================
        // Compute and return the total charges. 
        // Iterate over the currentCharges list, accumulating 
        // into the variable balance. Return balance.
        //====================================================
        public double GetAccountBalance()
        {
            double balance = 0;

            foreach (double charge in currentCharges)
                balance += charge;

            return balance;
        }
        //====================================================
        // Compute and return the area, as height * width
        //====================================================
        public double GetArea()
        {
            //Rectangular gardens at the moment, but this method allows
            //for expansion to more complex shapes.
            return gardenHeight * gardenWidth;
        }

       
        public string AreaReporter()
        {
            return String.Format("{0,-14}:{1,8:f2}", ownerName, GetArea());
        }

        
        public string ChargesReporter()//Get a report on the current charges balance.
        {
            return String.Format("{0,-14}:{1,8:f2}", ownerName, "$" + GetAccountBalance());
        }

       
        public string MostRecentCharge()
        {
            return String.Format("{0,-14}:{1,8:f2}", ownerName, "$" + currentCharges[currentCharges.Count - 1]);
        }

    }
}