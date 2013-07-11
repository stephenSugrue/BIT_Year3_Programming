using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizNightScorer
{
   static class Scorer
    {
     
      
        // static methods so we can use them without creating a object for that class 
        public static int AdultScore(int x, int y)//pass in number correct and number incorrect 
        {
            

          int  A_Score = ((x*10)-(y*1));//For adults number correct * 10 points
                                     // and number incorrect * 1 point
           
            return A_Score;//returns the adult score 

        }

        public static int ChildScore(int x, int y)//pass in number correct and number incorrect 
        {
           

          int  C_Score = (x * 15);//For children just multiply number correct by 15 

            return C_Score;// returns the child score 

        }
    }

}
