﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DwgChallengeConditionalRadiobutton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "You chose a Pencil!";
                resultImage.ImageUrl = "pencil.png";
            }

            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "You chose a Pen!";
                resultImage.ImageUrl = "pen.png";
            }

            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "You chose a Phone";
                resultImage.ImageUrl = "phone.png";
            }

            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "You chose a Tablet!";
                resultImage.ImageUrl = "tablet.png";
            }

            else
            {
                resultLabel.Text = "Please make a selection.";
            }


        }
    }
}