using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace To_Do_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addtask_Click(object sender, EventArgs e)
        {
            string task__title = tasktitle.Text;
            string task__description = taskdiscription.Text;
            string task__type = "";
            if(radioButton1.Checked)
            {
                task__type = "Home task";
            }
            else
            {
                task__type = "University Task";
            }

            string task__deadline = deadline.Text;
            string task__level = "";
            if (radioButton3.Checked)
            {
                task__level = "Normal";
            }
            else
            {
                task__level = "Important";
            }


            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\To_Do_Application\To_Do_Application\Database1.mdf"";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "INSERT into todo(task_title, task_description, task_type, task_deadline,task_level) VALUES('" + task__title + "','" + task__description + "', '" + task__type + "', '" + task__deadline + "','" + task__level + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Data Inserted");
                
            }



            

        }

        private void alltask_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\To_Do_Application\To_Do_Application\Database1.mdf"";Integrated Security=True"); 
            SqlCommand cmd = new SqlCommand("Select * from todo", con); 
            con.Open(); 
            SqlDataAdapter sda = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable(); 
            sda.Fill(dt); con.Close(); 
            datagrid_show.DataSource = dt;
        }

        private void datagrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void unitask_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\To_Do_Application\To_Do_Application\Database1.mdf"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from todo where task_type = 'University Task' ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt); con.Close();
            datagrid_show.DataSource = dt;
        }

        private void delete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\To_Do_Application\To_Do_Application\Database1.mdf"";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete todo where id='" + id.Text + "'", con);
            cmd.ExecuteNonQuery();
            Status.Text = "Delete Entry Successfully";
            con.Close();

        }

        private void imptask_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\To_Do_Application\To_Do_Application\Database1.mdf"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from todo where task_level = 'Important' ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt); con.Close();
            datagrid_show.DataSource = dt;
        }

        private void hometask_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\To_Do_Application\To_Do_Application\Database1.mdf"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from todo where task_type = 'Home Task' ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt); con.Close();
            datagrid_show.DataSource = dt;
        }

        private void normaltask_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\To_Do_Application\To_Do_Application\Database1.mdf"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from todo where task_level = 'Normal' ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt); con.Close();
            datagrid_show.DataSource = dt;
        }
    }
}
