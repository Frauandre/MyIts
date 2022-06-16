using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_AnagraficaStudenti
{
    public partial class Studenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            recuperare dopo il postback
            elemento selezionato dal ddlCerca e passarlo come filtro alla query
            */
            
            if (ddlCerca.SelectedIndex != 0)
                sdsStudenti.SelectCommand = sdsStudenti.SelectCommand + " where classe = '" + ddlCerca.SelectedValue + "'";
                       
            sdsStudenti.DataBind(); //ricarica l'oggetto
            gvStudenti.DataBind();

        }
    }
}