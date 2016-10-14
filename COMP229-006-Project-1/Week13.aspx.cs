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
    public partial class Week13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getFootball();
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
    }
}