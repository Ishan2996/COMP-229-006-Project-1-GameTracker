using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using COMP229_006_Project_1.Models;
using System.Web.ModelBinding;

namespace COMP229_006_Project_1
{
    public partial class Week15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time
            // populate the gametracker grid
            if (!IsPostBack)
            {
                // Get the student data
                this.GetFootball();
                this.getBasketball();
                this.Gethockey();
                this.getvolleyball();
            }


        }



        /// <summary>
        /// This method gets the game data from the DB
        /// </summary>
        private void GetFootball()
        {
            // connect to EF DB
            using (GameTracker db = new GameTracker())
            {
                // query the football Table using EF and LINQ
                var footballs = (from allFootball15 in db.Football15
                                 select allFootball15);

                // bind the result to the football GridView
                football.DataSource = footballs.ToList();
                football.DataBind();
            }
        }

        private void getBasketball()
        {
            using (GameTracker db = new GameTracker())
            {
                var basketetballs = (from allBasketball15 in db.Basketball15
                                     select allBasketball15);
                // bind the result to the basketball GridView
                basketball.DataSource = basketetballs.ToList();
                basketball.DataBind();
            }




        }
        private void Gethockey()
        {
            // connect to EF DB
            using (GameTracker db = new GameTracker())
            {
                // query the hockey Table using EF and LINQ
                var hockeys = (from allHockey15 in db.Hockey15
                               select allHockey15);

                // bind the result to the hockey GridView
                hockey.DataSource = hockeys.ToList();
                hockey.DataBind();
            }
        }
        private void getvolleyball()
        {
            // connect to EF DB
            using (GameTracker db = new GameTracker())
            {
                // query the volleyball Table using EF and LINQ
                var volleyballs = (from allVolleyball15 in db.Volleyball15
                                   select allVolleyball15);

                // bind the result to the volleyball GridView
                volleyball.DataSource = volleyballs.ToList();
                volleyball.DataBind();
            }
        }
    }
}