using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class About : Page
    {
    
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {

                Question_1A.Text = "Correct";
                Question_1A.Visible = true;
            }
            else
            {
                Question_1A.Text = "Incorrect";
                Question_1A.Visible = true;
            }
            if (RadioButtonList2.SelectedIndex == 1)
            {

                Question_2A.Text = "Correct";
                Question_2A.Visible = true;
            }
            else
            {
                Question_2A.Text = "Incorrect";
                Question_2A.Visible = true;
            }
            if (RadioButtonList3.SelectedIndex == 2)
            {

                Question_3A.Text = "Correct";
                Question_3A.Visible = true;
            }
            else
            {
                Question_3A.Text = "Incorrect";
                Question_3A.Visible = true;
            }
            if (RadioButtonList4.SelectedIndex == 3)
            {

                Question_4A.Text = "Correct";
                Question_4A.Visible = true;
            }
            else
            {
                Question_4A.Text = "Incorrect";
                Question_4A.Visible = true;
            }
            if (RadioButtonList5.SelectedIndex == 0)
            {

                Question_5A.Text = "Correct";
                Question_5A.Visible = true;
            }
            else
            {
                Question_5A.Text = "Incorrect";
                Question_5A.Visible = true;
            }

        }
    }
}