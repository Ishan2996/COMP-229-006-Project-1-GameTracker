﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using COMP229_006_Project_1.Models;
using System.Web.ModelBinding;

namespace COMP229_006_Project_1
{
    public partial class Week13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getFootball();
                this.getBasketball();
                this.Gethockey();
                this.getvolleyball();
            }
        }

        private void getFootball()
        {
            using (FootballWeek13Context db = new FootballWeek13Context())
            {
                var footballs = (from allFootball1 in db.Football2
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
                var footballs = (from allFootball1 in db.Basketball13
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
                var footballs = (from allFootball1 in db.Hockey13
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
                var footballs = (from allFootball1 in db.Volleyball13
                                 select allFootball1);

                // bind the result to the Students GridView
                volleyball.DataSource = footballs.ToList();
                volleyball.DataBind();
            }
        }
    }
}