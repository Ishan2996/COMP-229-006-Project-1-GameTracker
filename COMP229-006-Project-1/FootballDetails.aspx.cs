using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMP229_006_Project_1.Models;

namespace COMP229_006_Project_1
{
    public partial class FootballDetails12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetFootball();
            }
        }
        protected void GetFootball()
        {
            // populate the form with existing data from db
            int FootballID = Convert.ToInt32(Request.QueryString["FootballID"]);

            // connect to the EF DB
            using (GameTracker db = new GameTracker())
            {
                // populate game object instance with the FootballID from 
                // the URL parameter
                Football12 updatedStudent = (from student in db.Football12
                                          where student.Spectators1 == FootballID
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

                Football12 newFootball12 = new Football12();

                int FootballID = 0;

                if (Request.QueryString.Count > 0) // our URL has a STUDENTID in it
                {
                    // get the id from the URL
                    FootballID = Convert.ToInt32(Request.QueryString["StudentID"]);

                    // get the current student from EF db
                    newFootball12 = (from student in db.Football12
                                     where student.Spectators1 == FootballID
                                     select student).FirstOrDefault();
                }

                // add form data to the new student record
                newFootball12.TeamName1 = TeamaTextBox.Text;
                newFootball12.TeamScore1 = Convert.ToInt32(TeambTextBox.Text);
                newFootball12.Spectators1 = Convert.ToInt32(SpectatorsTextBox.Text);

                // use LINQ to ADO.NET to add / insert new student into the db

                if (FootballID == 0)
                {
                    db.Football12.Add(newFootball12);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated students page
                Response.Redirect("Default.aspx");
            }
        }
    }
    
}