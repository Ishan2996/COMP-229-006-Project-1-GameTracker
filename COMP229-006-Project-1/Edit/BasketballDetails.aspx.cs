using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMP229_006_Project_1.Models;

namespace COMP229_006_Project_1
{
    public partial class BasketballDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.getBasketball();
            }
        }

        protected void getBasketball()
        {
            // populate the form with existing data from db
            int BasketballID = Convert.ToInt32(Request.QueryString[" BasketballID"]);

            // connect to the EF DB
            using (GameTracker db = new GameTracker())
            {
                // populate game object instance with the FootballID from 
                // the URL parameter
                Basketball12 updatedStudent = (from student in db.Basketball12
                                               where student.Spectators1 == BasketballID
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

                Basketball12 newBasketball12 = new Basketball12();

                int BasketballID = 0;

                if (Request.QueryString.Count > 0) // our URL has a FootballID in it
                {
                    // get the id from the URL
                    BasketballID = Convert.ToInt32(Request.QueryString["StudentID"]);

                    // get the current student from EF db
                    newBasketball12 = (from student in db.Basketball12
                                    where student.Spectators1 == BasketballID
                                     select student).FirstOrDefault();
                }

                // add form data to the new student record
                newBasketball12.TeamName1 = TeamaTextBox.Text;
                newBasketball12.TeamScore1 = Convert.ToInt32(TeambTextBox.Text);
                newBasketball12.Spectators1 = Convert.ToInt32(SpectatorsTextBox.Text);

                // use LINQ to ADO.NET to add / insert new data into the db

                if (BasketballID == 0)
                {
                    db.Basketball12.Add(newBasketball12);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated game page
                Response.Redirect("../Default.aspx");
            }
        }
    }
}
