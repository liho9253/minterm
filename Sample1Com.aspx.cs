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
            temp += Request.Form.Get("lb_1") + "<br/>";

            for (int i = 1;i <= 3;i++) {
                temp += Request.QueryString.Get("CheckBox1") + "<br/>";
            }
            lb_Res.Text = temp;


        }
    }
}