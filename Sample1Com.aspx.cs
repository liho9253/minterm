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
            for (int i = 1;i <= 3;i++) {
                if(CheckBox1)
                temp += Request.Form.Get("CheckBox[i]")+ "<br/>";
            }
            lb_Res.Text = temp;


        }
    }
}