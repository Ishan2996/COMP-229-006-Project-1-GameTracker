using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMP229_006_Project_1.Models;

namespace COMP229_006_Project_1
{
    public partial class HockeyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.Gethockey();
            }
        }

        protected void Gethockey()
        {
            // populate the form with existing data from db
            int HockeyID = Convert.ToInt32(Request.QueryString[" HockeyID"]);

            // connect to the EF DB
            using (GameTracker db = new GameTracker())
            {
                // populate game object instance with the FootballID from 
                // the URL parameter
                Hockey12 updatedStudent = (from student in db.Hockey12
                                               where student.Spectators1 == HockeyID
                                               select student).FirstOrDefault();

                // map the game properties to the form control
                if (updatedStudent != null)
                {
                    TeamaTextBox.Text = updatedStudent.TeamName1;
                    TeambTextBox.Text = updatedStudent.TeamScore1.ToString();
                    SpectatorsTextBox.Text = updatedStudent.Spectators1.ToString();

                }
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to the Main Game page
            Response.Redirect("Default.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to conect to the server
            using (GameTracker db = new GameTracker())
            {
                // save a new record

                Hockey12 newHockey12 = new Hockey12();

                int HockeyID = 0;

                if (Request.QueryString.Count > 0) // our URL has a STUDENTID in it
                {
                    // get the id from the URL
                    HockeyID = Convert.ToInt32(Request.QueryString["HockeyID"]);

                    // get the current student from EF db
                    newHockey12 = (from student in db.Hockey12
                                   where student.Spectators1 == HockeyID
                                       select student).FirstOrDefault();
                }

                // add form data to the new student record
                newHockey12.TeamName1 = TeamaTextBox.Text;
                newHockey12.TeamScore1 = Convert.ToInt32(TeambTextBox.Text);
                newHockey12.Spectators1 = Convert.ToInt32(SpectatorsTextBox.Text);

                // use LINQ to ADO.NET to add / insert new student into the db

                if (HockeyID == 0)
                {
                    db.Hockey12.Add(newHockey12);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated students page
                Response.Redirect("Default.aspx");
            }
        }
    }
}