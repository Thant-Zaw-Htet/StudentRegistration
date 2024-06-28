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

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radWeb.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radJava.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radPhp.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radPython.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radCsharp.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radAndroid.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radIos.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radReactiveNative.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                switch (radioButton.Name)
                {
                    case "radWeb":
                        txtFee.Text = "250000";
                        break;
                    case "radJava":
                        txtFee.Text = "300000";
                        break;
                    case "radPhp":
                        txtFee.Text = "220000";
                        break;
                    case "radPython":
                        txtFee.Text = "270000";
                        break;
                    case "radCsharp":
                        txtFee.Text = "250000";
                        break;
                    case "radAndroid":
                        txtFee.Text = "280000";
                        break;
                    case "radIos":
                        txtFee.Text = "290000";
                        break;
                    case "radReactiveNative":
                        txtFee.Text = "240000";
                        break;
                    default:
                        txtFee.Text = "";
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData() {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString.getConnection);
                conn.Open();
                string query = @"SELECT [StudentID]
      ,[StudentName]
      ,[Courses]
      ,[Fee]
  FROM [class].[dbo].[studentregistration_new]";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string courses = radWeb.Checked ? "Web Development" : radJava.Checked ? "Java/Spring" : radPhp.Checked ? "PHP/Laravel" : radPython.Checked ? "Python" : radCsharp.Checked ? "C#.net" : radAndroid.Checked ? "Android Development" : radIos.Checked ? "IOS Development" : radReactiveNative.Checked ? "React Native" : string.Empty;
                string fee = txtFee.Text.Trim();

                if (radWeb.Checked)
                {
                    
                }

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(courses) || string.IsNullOrEmpty(fee))
                {
                    MessageBox.Show("Please fill add fields!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection conn = new SqlConnection(ConnectionString.getConnection);
                conn.Open();
                string query = @"INSERT INTO studentregistration_new (StudentName,Courses,Fee) VALUES (@StudentName,@Courses,@Fee)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@Courses", courses);
                cmd.Parameters.AddWithValue("@Fee", fee);
                int result = cmd.ExecuteNonQuery();
                conn.Close();


                if (result > 0)
                {
                    MessageBox.Show("Create Student Successful!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Create student Fail", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           LoadStudentData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFee.Clear();
            radWeb.Checked = false;
            radJava.Checked = false;
            radPhp.Checked = false;
            radPython.Checked = false;
            radCsharp.Checked = false;
            radAndroid.Checked = false;
            radIos.Checked = false;
            radReactiveNative.Checked = false;
        }
    }
}
