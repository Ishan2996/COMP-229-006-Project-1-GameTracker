using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMP229_006_Project_1.Models;

namespace COMP229_006_Project_1
{
    public partial class VolleyballDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.getVolleyball();
            }
        }

        protected void getVolleyball()
        {
            // populate the form with existing data from db
            int VolleyballID = Convert.ToInt32(Request.QueryString[" VolleyballID"]);

            // connect to the EF DB
            using (GameTracker db = new GameTracker())
            {
                // populate game object instance with the FootballID from 
                // the URL parameter
                Volleyball12 updatedStudent = (from student in db.Volleyball12
                                                 where student.Spectators1 == VolleyballID
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
            Response.Redirect("../Default.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to conect to the server
            using (GameTracker db = new GameTracker())
            {
                // save a new record

                Volleyball12 newVolleyball12 = new Volleyball12();

                int VolleyballID = 0;

                if (Request.QueryString.Count > 0) // our URL has a STUDENTID in it
                {
                    // get the id from the URL
                    VolleyballID = Convert.ToInt32(Request.QueryString["StudentID"]);

                    // get the current student from EF db
                    newVolleyball12 = (from student in db.Volleyball12
                                       where student.Spectators1 == VolleyballID
                                       select student).FirstOrDefault();
                }

                // add form data to the new student record
                newVolleyball12.TeamName1 = TeamaTextBox.Text;
                newVolleyball12.TeamScore1 = Convert.ToInt32(TeambTextBox.Text);
                newVolleyball12.Spectators1 = Convert.ToInt32(SpectatorsTextBox.Text);

                // use LINQ to ADO.NET to add / insert new student into the db

                if (VolleyballID == 0)
                {
                    db.Volleyball12.Add(newVolleyball12);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated students page
                Response.Redirect("../Default.aspx");
            }
        }
    }
}