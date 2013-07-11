using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steve_Predicate
{
    public partial class Form1 : Form
    {
        int[] n;
        Random r;
        public Form1()
        {
            InitializeComponent();
            n = new int[100];
            r = new Random();

        }
        private void GenerateNumbers()
        {
            listBox1.Items.Clear();

            for (int currentNumber = 0; currentNumber < n.Length; currentNumber++)
            {
                
                n[currentNumber] = r.Next(n.Length);

                
                listBox1.Items.Add(n[currentNumber].ToString());//Add to listbox
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateNumbers();
            Predicate<int> numberFilter = null;
            numberFilter = new Predicate<int>(Worker.IsEven);
            ApplyFilter(numberFilter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateNumbers();
            Predicate<int> numberFilter = null;
            numberFilter = new Predicate<int>(Worker.IsLessThanTen);
            ApplyFilter(numberFilter);

        }

        private void ApplyFilter(Predicate<int> numberFilter)
        {
            listBox2.Items.Clear();

          
            for (int i = 0; i < n.Length; i++)
            {
               
                if (numberFilter(n[i]) == true)
                {  
                    listBox2.Items.Add(n[i].ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
