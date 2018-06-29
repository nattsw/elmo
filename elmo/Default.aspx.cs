using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    string fileName = @"\\104.215.198.xxx\share\elmo.log";

    protected void Page_Load(object sender, EventArgs e)
    {
        new Executer().Execute();
    }
}
