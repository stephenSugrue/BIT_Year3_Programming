using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenReporter_Steve
{
    class GardenManager
    {
        public delegate string Reporter(Garden g);

        List<Garden> gardens;


        public GardenManager()
        {
            gardens = new List<Garden>();
        }

        public void AddGarden(Garden NG)
        {
            gardens.Add(NG);
        }

        
        public string AreaReporter(Garden CG)//Get the area report for a single garden.
        {
            return CG.AreaReporter();
        }

        
        public string ChargesReporter(Garden CG)//Get the charges report for a single garden.
        {
            return CG.ChargesReporter();
        }

        
        public string MostRecentChargeReporter(Garden CG)//Get the most recent charge report
        {
            return CG.MostRecentCharge();
        }

       
   
        public List<string> ProcessGardens(Reporter r) //Produce a report for all gardens.
        {
            List<string> gardenReports = new List<string>();

            for (int i = 0; i < gardens.Count; i++)
            {
                gardenReports.Add(r(gardens[i]));
            }

            return gardenReports;
        }
    }
}
