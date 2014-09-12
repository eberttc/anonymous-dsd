<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        log4net.Config.XmlConfigurator.Configure();

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    {
        
        
        
        // Code that runs when an unhandled error occurs
        //try
        //{
        //    HttpContext ctx = HttpContext.Current;         
        //    ctx.Response.Redirect("~/ErrorPage.aspx");
        //}
        //catch
        //{
        //    HttpContext ctx = HttpContext.Current;
            
        //    ctx.Server.ClearError();
        //    ctx.Response.Redirect("~/ErrorPage.aspx");
        //}

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
