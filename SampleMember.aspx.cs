using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace minterm{
    public partial class SampleMember : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            if(CheckBox1.Checked == true)
                Label1.Text = CheckBox1.Text;
        }
    }
}