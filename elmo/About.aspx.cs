using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string fileName = @"\\104.215.198.xxx\share\elmo.log";
        string text = System.IO.File.ReadAllText(fileName);
        _myLabel.Text = text;
    }
}
