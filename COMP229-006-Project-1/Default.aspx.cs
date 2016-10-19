using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements that are required to connect to EF DB
using COMP229_006_Project_1.Models;
using System.Web.ModelBinding;

namespace COMP229_006_Project_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time
            // populate the student grid
            if (!IsPostBack)
            {
                // Get the student data
                this.GetFootball1();
                this.getBasketball();
                this.Gethockey();
                this.getvolleyball();
            }


        }



        /// <summary>
        /// This method gets the game data from the DB
        /// </summary>
        private void GetFootball1()
        {
            // connect to EF DB
            using (ModelConnection db = new ModelConnection())
            {
                // query the Student Table using EF and LINQ
                var footballs = (from allFootball1 in db.Football1
                                 select allFootball1);

                // bind the result to the Students GridView
                football.DataSource = footballs.ToList();
                football.DataBind();
            }
        }

        private void getBasketball()
        {
            using (basketball db = new basketball())
            {
                var footballs = (from allFootball1 in db.Basketball12
                                 select allFootball1);
                // bind the result to the Students GridView
                basketball.DataSource = footballs.ToList();
                basketball.DataBind();

            }




        }
        private void Gethockey()
        {
            // connect to EF DB
            using (Hockey db = new Hockey())
            {
                // query the Student Table using EF and LINQ
                var footballs = (from allFootball1 in db.Hockey12
                                 select allFootball1);

                // bind the result to the Students GridView
                hockey.DataSource = footballs.ToList();
                hockey.DataBind();
            }
        }
        private void getvolleyball()
        {
            // connect to EF DB
            using (Volleyball db = new Volleyball())
            {
                // query the Student Table using EF and LINQ
                var footballs = (from allFootball1 in db.Volleyball12
                                 select allFootball1);

                // bind the result to the Students GridView
                volleyball.DataSource = footballs.ToList();
                volleyball.DataBind();
            }
        }
    }
}