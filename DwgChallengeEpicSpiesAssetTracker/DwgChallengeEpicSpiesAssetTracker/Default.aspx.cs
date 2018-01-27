using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DwgChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetName = new string[0];
                int[] electionsRigged = new int[0];
                int[] subterfugePerformed = new int[0];

                ViewState.Add("Asset", assetName);
                ViewState.Add("Elections", electionsRigged);
                ViewState.Add("Subterfuge", subterfugePerformed);
            }
        }

        protected void assetButton_Click(object sender, EventArgs e)
        {
            string[] assetName = (string[])ViewState["Asset"];
            int[] electionsRigged = (int[])ViewState["Elections"];
            int[] subterfugePerformed = (int[])ViewState["Subterfuge"];

            int newLength = assetName.Length + 1;

            Array.Resize(ref assetName, newLength);
            Array.Resize(ref electionsRigged, newLength);
            Array.Resize(ref subterfugePerformed, newLength);

            int newIndex = assetName.GetUpperBound(0);

            assetName[newIndex] = assetNameTextBox.Text;
            electionsRigged[newIndex] = int.Parse(electionsRiggedTextBox.Text);
            subterfugePerformed[newIndex] = int.Parse(subterfugeTextBox.Text);

            ViewState["Asset"] = assetName;
            ViewState["Elections"] = electionsRigged;
            ViewState["Subterfuge"] = subterfugePerformed;

            resultLabel.Text = String.Format("Total Elections Rigged: {0} <br />" +
                "Average Acts of Subterfuge: {1:N2} <br />" +
                "Last asset you added: {2}",
                electionsRigged.Sum(),
                subterfugePerformed.Average(),
                assetName[newIndex]);

            assetNameTextBox.Text = "";
            electionsRiggedTextBox.Text = "";
            subterfugeTextBox.Text = "";
        }
    }
}