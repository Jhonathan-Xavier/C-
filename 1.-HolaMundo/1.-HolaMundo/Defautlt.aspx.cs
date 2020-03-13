using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1._CrearProyecto
{
    public partial class Defautlt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString();
        }
    }
}