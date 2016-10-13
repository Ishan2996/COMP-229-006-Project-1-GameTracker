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
            }


        }

        /// <summary>
        /// This method gets the student data from the DB
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
    }
}