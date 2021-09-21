using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Npgsql;

namespace WebApplication3
{

    public partial class About : Page
    {
        public static Int32 course;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            var quizID = 0;
            var cs = "Host=localhost;Username=postgres;Password=smokey99;Database=Apps Project";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(cs);
            var con = npgsqlConnection;
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT quizid FROM quizzes WHERE courseid = ";
            cmd.CommandText += course + ";";
            cmd.CommandType = CommandType.Text;
            quizID = (int)cmd.ExecuteScalar();

            //Load Questions
            cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 1;";
            Question_1.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 2;";
            Question_2.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 3;";
            Question_3.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 4;";
            Question_4.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 5;";
            Question_5.Text = cmd.ExecuteScalar().ToString();

            //Question 1 Load Answers
            RadioButtonList1.Items.Clear();
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 1 and aid = 1";
            RadioButtonList1.Items.Insert(0, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 1 and aid = 2";
            RadioButtonList1.Items.Insert(1, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 1 and aid = 3";
            RadioButtonList1.Items.Insert(2, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 1 and aid = 4";
            RadioButtonList1.Items.Insert(3, cmd.ExecuteScalar().ToString());

            //Questions 2 Load Answers
            RadioButtonList2.Items.Clear();
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 2 and aid = 1";
            RadioButtonList1.Items.Insert(0, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 2 and aid = 2";
            RadioButtonList1.Items.Insert(1, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 2 and aid = 3";
            RadioButtonList1.Items.Insert(2, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 2 and aid = 4";
            RadioButtonList1.Items.Insert(3, cmd.ExecuteScalar().ToString());

            //Question 3 Load Answers
            RadioButtonList3.Items.Clear();
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 3 and aid = 1";
            RadioButtonList1.Items.Insert(0, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 3 and aid = 2";
            RadioButtonList1.Items.Insert(1, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 3 and aid = 3";
            RadioButtonList1.Items.Insert(2, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 3 and aid = 4";
            RadioButtonList1.Items.Insert(3, cmd.ExecuteScalar().ToString());

            //Question 4 Load Answers
            RadioButtonList4.Items.Clear();
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 4 and aid = 1";
            RadioButtonList1.Items.Insert(0, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 4 and aid = 2";
            RadioButtonList1.Items.Insert(1, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 4 and aid = 3";
            RadioButtonList1.Items.Insert(2, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 4 and aid = 4";
            RadioButtonList1.Items.Insert(3, cmd.ExecuteScalar().ToString());

            //Question 5 Load Answers
            RadioButtonList5.Items.Clear();
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 5 and aid = 1";
            RadioButtonList1.Items.Insert(0, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 5 and aid = 2";
            RadioButtonList1.Items.Insert(1, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 5 and aid = 3";
            RadioButtonList1.Items.Insert(2, cmd.ExecuteScalar().ToString());
            cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 5 and aid = 4";
            RadioButtonList1.Items.Insert(3, cmd.ExecuteScalar().ToString());
        }
    }
}