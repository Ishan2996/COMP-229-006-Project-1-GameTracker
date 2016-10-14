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
    public partial class Week14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getFootball4();
            }
        }

        private void getFootball4()
        {
            using (FootballWeek14 db = new FootballWeek14())
            {
                var footballs = (from allFootball14 in db.Football14
                                 select allFootball14);
                // bind the result to the Students GridView
                football.DataSource = footballs.ToList();
                football.DataBind();

            }
        }
    }
}