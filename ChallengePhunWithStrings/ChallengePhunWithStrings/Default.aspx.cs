using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name

            string name = "Dan Gorton";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel1.Text += name[i];
            }

            // In my case, the result would be:
            // robaT boB
            

            // 2.  Reverse this sequence:

            string names = "Luke,Leia,Han,Chewbacca";

            string[] rebelScum = names.Split(',');
            string result2 = "";
            for (int i = rebelScum.Length - 1; i >= 0; i--)
            {
                result2 += rebelScum[i] + ",";
            }
            result2 = result2.Remove(result2.Length - 1, 1);
            resultLabel2.Text = result2;

            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke


            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string[] rebelScum2 = names.Split(',');
            string result3 = "";
            for (int i = 0; i < rebelScum.Length; i++)
            {
                int padLeft = (14 - rebelScum[i].Length) / 2;
                string temp = rebelScum[i].PadLeft(rebelScum[i].Length + padLeft, '*');
                result3 += temp.PadRight(14, '*');
                result3 += "<br />";
            }
            resultLabel3.Text = result3;


            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace("z", "t");
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");
            resultLabel4.Text = puzzle;

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
        }
    }
}