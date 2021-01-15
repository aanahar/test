using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newNameSpaceDemo
{
    public partial class WebFormInNewSpace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
    }

    public class ClassInNewSpace
    {
        public void demoM()
        {
            Console.WriteLine("hellow from new space");
        }
    }
}