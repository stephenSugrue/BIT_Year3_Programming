using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GardenReporter_Steve
{
    public partial class Form1 : Form
    {

        GardenManager gardenManager;

        GardenManager.Reporter reporter;

        public Form1()
        {
            InitializeComponent();

            gardenManager = new GardenManager();

            PopulateDummyData();

        }

        private void PopulateDummyData()
        {
            Garden garden1 = new Garden(10, 20, "Savitch");
            garden1.AddCharge(123.45);
            garden1.AddCharge(678.90);

            Garden garden2 = new Garden(8.5, 120, "Knuth");
            garden2.AddCharge(45.32);
            garden2.AddCharge(678.90);
            garden2.AddCharge(98.76);

            Garden garden3 = new Garden(54.25, 60, "Winograd");
            garden3.AddCharge(149.32);
            garden3.AddCharge(78.12);
            garden3.AddCharge(150.00);

            gardenManager.AddGarden(garden1);
            gardenManager.AddGarden(garden2);
            gardenManager.AddGarden(garden3);
        }

        private void GardenReport()
        {
            listBox1.Items.Clear();
            List<string> gardenReports = gardenManager.ProcessGardens(reporter);

            for (int currentGarden = 0; currentGarden < gardenReports.Count; currentGarden++)
            {
                listBox1.Items.Add(gardenReports[currentGarden]);
            }
        }


        private void btnArea_Click(object sender, EventArgs e)
        {
            reporter = new GardenManager.Reporter(gardenManager.AreaReporter);
            GardenReport();
        }

        private void btnCharges_Click(object sender, EventArgs e)
        {
            reporter = new GardenManager.Reporter(gardenManager.ChargesReporter);
            GardenReport();
        }




    }
}
