using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace minterm
{
    public partial class Sample1Com : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String temp = "";
            temp += Request.Form.Get("tb_Acc")+"<br/>";
            temp += Request.Form.Get("tb_Pass")+"<br/>";
            if (Request.Form.Get("CheckBox1") == "on") {
                temp += "看書" + "<br/>";
            }
            if (Request.Form.Get("CheckBox2") == "on"){
                temp += "打電動" + "<br/>";
            }
            if (Request.Form.Get("CheckBox3") == "on"){
                temp += "其他" + "<br/>";
            }
            
            temp += Request.Form.Get("lb_1") + "<br/>";

            lb_Res.Text = temp;


        }
    }
}