using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace First_Web_App__.net_
{
    public partial class dataEntry : System.Web.UI.Page
    {
        private string name="";
        private string fatherName="";
        private string gender="";
        private string dateOfBirth="";
        private string maritalStatus="";
        private string religin="";
        private string qualification="";
        private string address="";
        private string phoneNo="";
        private string email;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RFMGIDP;Initial Catalog=QuizDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            TBAddress.Text = TBdateOfBirth.Text = TBemail.Text = tbFatherName.Text = tbName.Text = TBphoneNo.Text = "";
            rbMale.Checked = rbFemale.Checked = rbIslam.Checked = rbMale.Checked = rbMarried.Checked = rbother.Checked = rbSingle.Checked = CBBS_BSc.Checked = CBfsc.Checked = CBMatric.Checked = CBother.Checked = false;
        }
        public void disp()
        {
            
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(tbName.Text);
                tbName.Text = "must not be numaric";
                tbName.BackColor = System.Drawing.Color.Red;
            }
            catch
            {
                name = tbName.Text;//string name axcepted
                try
                {
                    Convert.ToInt32(tbFatherName.Text);
                    tbFatherName.Text = "must not be numaric";
                    tbFatherName.BackColor = System.Drawing.Color.Red;
                }
                catch
                {
                    fatherName = tbFatherName.Text;//string father name axcepted
                    if (rbMale.Checked)
                        gender = rbMale.Text;
                    else if (rbFemale.Checked)
                        gender = rbFemale.Text;
                    //^^^^^^^^^^^^^^^^^^^^^^^ gender accepted
                    dateOfBirth = TBdateOfBirth.Text;
                    //^^^^^^^^^^^^^^^^^^^^^^  date of birth accepted
                    if (rbSingle.Checked)
                        maritalStatus = rbSingle.Text;
                    else if (rbMarried.Checked)
                        maritalStatus = rbMarried.Text;
                    //^^^^^^^^^^^^^^^^^^^^^^^ marital status accepted
                    if (rbIslam.Checked)
                        religin = rbIslam.Text;
                    else if (rbother.Checked)
                        religin = rbother.Text;
                    //^^^^^^^^^^^^^^^^^^^^^^^ relign accepted
                    if (CBMatric.Checked)
                        qualification = qualification + CBMatric.Text + " , ";
                    if (CBfsc.Checked)
                        qualification = qualification + CBfsc.Text + " , ";
                    if (CBBS_BSc.Checked)
                        qualification = qualification + CBBS_BSc.Text + " , ";
                    if (CBother.Checked)
                        qualification = qualification + CBother.Text + " , ";
                    //^^^^^^^^^^^^^^^^^^^^^^^^^ qualification accepted
                    address = TBAddress.Text;

                    try
                    {
                        //Convert.ToInt64(TBphoneNo.Text);
                        phoneNo = TBphoneNo.Text;//valid numeric phone number accepted

                        email = TBemail.Text;//email accepted


                        if(tbID.Text.Trim()=="")
                        {
                            //insert
                            if (con.State == ConnectionState.Closed)
                                con.Close();
                            try
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand("Insert INTO [QuizDB].[dbo].[inputDataTable] ([name],[fatherName],[email],[phoneNo],[address],[gender],[religin],[dateOfBirth],[maritalStatus],[qualification]) VALUES ('" + name + "','" + fatherName + "','" + email + "','" + phoneNo + "','" + address + "','" + gender + "','" + religin + "','" + dateOfBirth + "','" + maritalStatus + "','" + qualification + "')", con);
                                //SqlCommand cmd = new SqlCommand("Insert INTO [QuizDB].[dbo].[inputDataTable] ([name]) VALUES ('"+name+"')", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch
                            {
                                lblOut.Text = "data is unable to insert an error ouccered";
                            }
                            //^^^^^^^^^^^^^^^^^ data enter in database

                        }
                        else
                        {
                            //update that id's record
                            if (con.State == ConnectionState.Open)
                                con.Close();
                            try
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand("UPDATE [QuizDB].[dbo].[inputDataTable] SET [name]='" + name + "',[fatherName]='" + fatherName + "',[email]='" + email + "',[phoneNo]='" + phoneNo + "',[address]='" + address + "',[gender]='" + gender + "',[religin]='" + religin + "',[dateOfBirth]='" + dateOfBirth + "',[maritalStatus]='" + maritalStatus + "',[qualification]='" + qualification + "' WHERE [id] = '" + tbID.Text.Trim() + "'", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch
                            {
                                lblOut.Text = "data is unable to update an error ouccered";
                            }
                        }


                        //show data on grid
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        try
                        {
                            con.Open();
                            SqlCommand cmdd = new SqlCommand("Select * FROM [QuizDB].[dbo].[inputDataTable]", con);
                            SqlDataReader dr = cmdd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();
                        }
                        catch
                        {
                            lblOut.Text = "No Record Found in database";
                        }

                    }
                    catch
                    {
                        TBphoneNo.Text = "phone number must be numaric";
                        TBphoneNo.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}