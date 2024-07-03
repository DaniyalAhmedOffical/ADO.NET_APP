using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_APP
{
    public partial class Form1 : Form
    {
        // connection string 
        // ye m ny app config ki file mai daal diya ha connectionn string
        //string ConStr = @" Data Source =DESKTOP-VU5MN9L; Initial Catalog =master;Integrated Security=SSPI ";
        string ConStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            AddCourse();
            CountStd();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CountStd()
        {
            SqlConnection con = new SqlConnection(ConStr);

            try
            {
                con.Open();

                string getCountSql = "SELECT COUNT (*) AS 'COUNTSTD' FROM [dbo].[Students] ";
                SqlCommand cmd = new SqlCommand(getCountSql, con);

                int StdCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (StdCount > 0)
                {
                    totalstd.Text = "TOTAL STUDENT IS" + StdCount;
                }
                else
                {
                    totalstd.Text = "NO STUDENT RECORD";

                }

            }
            catch (Exception)
            {
                throw;

            }


            finally
            {


            }

        }
        private void AddCourse()
        {
            try
            {
                List<string> listofCourse = new List<string>();
                SqlConnection con = new SqlConnection(ConStr);
                string getCourseSql = "SELECT * FROM [dbo].[Students] ";     
                SqlCommand cmd = new SqlCommand(getCourseSql,con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listofCourse.Add(reader.GetString(4));
                }
                CourseBox.DataSource = listofCourse;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            finally
            {
               // con.close();

            }
        }
        private void Select_Click(object sender, EventArgs e)
        {

            // CONNECTION 
            SqlConnection con = new SqlConnection(ConStr);
            try
            {
                string SqlQuery = $"SELECT * FROM [dbo].[Students] Where StudentID = {2}";

                //command
                SqlCommand cmd = new SqlCommand(SqlQuery, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textFirstName.Text = reader.GetString(1);
                    textLastName.Text = reader.GetString(2);
                    textAge.Text = reader.GetInt32(3).ToString();
                 //   CourseBox.Text = reader.GetString(4);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
            {
                con.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConStr);
            try
            {

                con.Open();

                var AddStd = @"INSERT INTO [dbo].[Students] (FirstName, LastName, Age, Course)
                    VALUES(@FirstName,@LastName,@Age,@Course)";

                //command
                SqlCommand cmd = new SqlCommand(AddStd, con);
                cmd.Parameters.AddWithValue("@FirstName", textFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", textLastName.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt16(textAge.Text));
                cmd.Parameters.AddWithValue("@Course", CourseBox.Text);



                int rowAffected = cmd.ExecuteNonQuery();

                if(rowAffected>0)
                {
                    MessageBox.Show("Record Insert Sucessfully");
                    CountStd();
                }
                else
                {
                    MessageBox.Show("Record Insert Fail");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
            {
                con.Close();
            }

        }

        private void Dlt_Btn_Click(object sender, EventArgs e)
        {

            // CONNECTION 
            SqlConnection con = new SqlConnection(ConStr);
            try
            {
                string DltSql = @"DELETE FROM [dbo].[Students] Where StudentID = 4";

                //command
                SqlCommand cmd = new SqlCommand(DltSql, con);
                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    MessageBox.Show("RECORD DELETE");
                }
                else
                {
                    MessageBox.Show("RECORD NOT DELETE");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
            {
                con.Close();
            }

        }
    }
}
