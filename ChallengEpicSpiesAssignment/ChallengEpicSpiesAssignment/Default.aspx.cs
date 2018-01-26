using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { 
            previousCalendar.SelectedDate = DateTime.Now.Date;
            startdatenewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
            endCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
            Page.MaintainScrollPositionOnPostBack = true; //stops page from going to the top every time.
        }

        protected void okButton_Click(object sender, EventArgs e)
        {


            //Spies cost $500 a day
            TimeSpan totalDurationOfAssignment = endCalendar.SelectedDate.Subtract(startdatenewCalendar.SelectedDate);
            double totalCost = totalDurationOfAssignment.TotalDays * 500.0;

            //Spies get $1000 for over 21 days work
            string bonusResult = "";
            if (totalDurationOfAssignment.TotalDays > 21)
            {
                totalCost += 1000.0;
                bonusResult = String.Format("Total duration of assignment {0} days. " +
                    " {1} received a bonus of $1000.00!",totalDurationOfAssignment.Days ,nameTextBox.Text);
            }
            else
            {
                bonusResult = String.Format("Total duration of assignment {0} days.  No Bonus approved.", totalDurationOfAssignment.Days);
            }

            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized.<br />  Budget total: {2:C}'" +
                "<br />{3}", nameTextBox.Text, assignmentTextBox.Text, totalCost, bonusResult);

            //Must be 14 days between work.  Error message if less than two weeks.
            TimeSpan timeBetweenAssignments = startdatenewCalendar.SelectedDate.Subtract(previousCalendar.SelectedDate);

            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment " +
                "and new assignment.";

                DateTime earliestAssignmentDate = previousCalendar.SelectedDate.AddDays(14);

                startdatenewCalendar.SelectedDate = earliestAssignmentDate;
                startdatenewCalendar.VisibleDate = earliestAssignmentDate;
            }
        }
    }
}