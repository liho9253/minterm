using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace minterm{
    public partial class Sample2 : System.Web.UI.Page{
        String[,] sa_Place = 
            new string[2, 3] { { "基隆","台北","新北"}, { "苗栗","台中","南投"} };
        protected void Page_Load(object sender, EventArgs e){
            if(IsPostBack == false) { 
                ListItem o_li = new ListItem("北區", "北區");
                ddl_Area.Items.Add(o_li);
                o_li = new ListItem("中區", "中區");
                ddl_Area.Items.Add(o_li);

                for (int i = 0; i <= 2;i++) {
                    ListItem o_li2 = new ListItem(sa_Place[0, i], sa_Place[0, i]);
                    ddl_Place.Items.Add(o_li2);
                }
            }
            if (rbl_Res.Text == "Rad_Yes") 
                tb_Des.Visible = true;
            else
                tb_Des.Visible = false;
        }

        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e){
            ddl_Place.Items.Clear();
            ListItem o_li2;
            if (ddl_Area.SelectedValue == "北區") { 
                for (int i = 0; i <= 2;i++) {
                    o_li2 = new ListItem(sa_Place[0, i], sa_Place[0, i]);
                    ddl_Place.Items.Add(o_li2);
                }
            }else{
                for (int i = 0; i <= 2;i++) {
                    o_li2 = new ListItem(sa_Place[1, i], sa_Place[1, i]);
                    ddl_Place.Items.Add(o_li2);
                }
            }
        }

        protected void btn_Sub_Click(object sender, EventArgs e){
                String temp = "";
                temp += ddl_Area.Text+ "<br/>";
                temp += ddl_Place.Text + "<br/>";
                temp += tb_Name.Text + "<br/>";
                temp += tb_Des.Text + "<br/>";
            lb_Msg.Text = temp;
        }
    }
}