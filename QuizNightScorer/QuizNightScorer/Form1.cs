using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizNightScorer
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();

        }

        public delegate int ScoreDelegate(int correct, int incorrect);

       

        private void button1_Click(object sender, EventArgs e)
        {
               //Instantiate the delegate.
                ScoreDelegate scoreDelegate = null;
              
                    String Scorrect = textBox1.Text;// get number correct 
                    String SIncorrect = textBox2.Text;//get number incorrect 
                    //convert to ints 
                    int x = Convert.ToInt16(Scorrect);
                    int y = Convert.ToInt16(SIncorrect);


                    if (radioButton1.Checked)// if adult button is checked 
                        scoreDelegate = new ScoreDelegate(Scorer.AdultScore);


                    if (radioButton2.Checked)// if child button is checked 
                        scoreDelegate = new ScoreDelegate(Scorer.ChildScore);


                    int score = scoreDelegate(x, y); //Calculate the score using the delegate.

               
               label3.Text = score.ToString(); //print the score to the label
          
    
        }

      
    }
}

