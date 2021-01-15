using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using newNameSpaceDemo;


namespace simpleAspApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

    }
    
    public class newDemo
    {

        demo obj = new demo();

        

        WebFormInNewSpace w1 = new WebFormInNewSpace();

        public void demoM2()
        {
            ClassInNewSpace obj2 = new ClassInNewSpace();
            Console.WriteLine("hellow from new space");

            obj2.demoM();
        }


    }
    
}

namespace newAspapp
{

    public class sample
    {

        simpleAspApp.newDemo obj1 = new simpleAspApp.newDemo();

        public void method1()
        {
            obj1.demoM2();
        }

    

        
    }
}

