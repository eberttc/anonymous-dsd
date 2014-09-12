using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

public partial class ErrorPage : System.Web.UI.Page
{
    private readonly ILog logger = LogManager.GetLogger(typeof(ErrorPage));

    protected void Page_Load(object sender, EventArgs e)
    {
        //Hashtable hashtable = ASP.global_asax.table;

        //string VALOR1 = hashtable[1].ToString();
        //string VALOR2 = hashtable[2].ToString();
        //string VALOR3 = hashtable[3].ToString();
        //string VALOR4 = hashtable[4].ToString();

        //string msm = "PaginaError_ErrorPage >> Error : " + VALOR1 + "|" + VALOR2 + "|" + VALOR3 + "|" + VALOR4;
        //logger.Error(msm);
    }
}