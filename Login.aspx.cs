using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // this login form take my three days approx. without image upload 
    }

    protected void Findbt_Click(object sender, EventArgs e)
    {

        //    DB_Class dbc = new DB_Class();
        //    DataTable DT;
        //    DT = dbc.ReadDataTable("select * from Emp_LoginForm where ID = " + IDtb.Text);

        //    // if i put Cleartxtbx method in start it set the value of IDtb.Text to ""(Empty) which give error in above ReadDataTable 
        //    Cleartxtbx();
        //    if (DT.Rows.Count > 0)
        //    {

        //        Emptb.Text = DT.Rows[0]["Emp_Name"].ToString().Trim();
        //        FNametb.Text = DT.Rows[0]["FName"].ToString().Trim();
        //        Contact_tb.Text = DT.Rows[0]["Contact_No"].ToString().Trim();
        //        CNICtb.Text = DT.Rows[0]["CNIC_No"].ToString().Trim();
        //        Addresstb.Text = DT.Rows[0]["Address"].ToString().Trim();
        //        BSalarytb.Text = DT.Rows[0]["Basic_Salary"].ToString().Trim();
        //        DOBtb.Text = DT.Rows[0]["DOB"].ToString().Trim();
        //        DOJtb.Text = DT.Rows[0]["DOJ"].ToString().Trim();
        //        DOLtb.Text = DT.Rows[0]["DOL"].ToString().Trim();

        //        //if (DesigList.SelectedValue !=  DT.Rows[0]["Desig_ID"].ToString())
        //        DesigList.SelectedValue = DT.Rows[0]["Desig_ID"].ToString();
        //        //if (DepartList.SelectedValue != DT.Rows[0]["Depart_ID"].ToString())
        //        DepartList.SelectedValue = DT.Rows[0]["Depart_ID"].ToString();
        //}
    }

    protected void Inserttb_Click(object sender, EventArgs e)
    {
        if (IDtb.Text == "")
        {
            if (BSalarytb.Text != "")
            {
                // Change Desig_ID from selectedValue to Selected index so if user not, gives any value there still 0 value goes in Query. 
                string SqlInsertQuery = "insert into Emp_LoginForm(ID,Emp_Name,FName,Contact_No,CNIC_No,Address,Basic_Salary,DOB,DOJ,DOL,Desig_ID,Depart_ID,Image)" +
                    " values ((select Max(ID) + 1 from Emp_LoginForm),'" + Emptb.Text + "','" + FNametb.Text + "','" + Contact_tb.Text + "','" +
                    CNICtb.Text + "','" + Addresstb.Text + "'," + BSalarytb.Text + ",'" + DOBtb.Text + "','" + DOJtb.Text + "','" + DOLtb.Text + "'," + DesigList.SelectedIndex + "," + DepartList.SelectedIndex + ",'" + ImageName.Text + "')";

                DB_Class dbc = new DB_Class();

                if (dbc.MyExecuteNonQuery(SqlInsertQuery))
                {
                    lblMsg.Text = "Successfully Execute";
                }
                else
                {
                    lblMsg.Text = "Error";
                }
                Cleartxtbx();
            }
            else
            {
                lblMsg.Text = "Salary Needed";
            }
        }
        else
        {
            lblMsg.Text = "ID Not Required";
        }
    }
    protected void Updatetb_Click(object sender, EventArgs e)
    {

        if (IDtb.Text == "")
        {
            lblMsg.Text = "ID Required";
        }
        else
        {
            //to get the already exist value in database so it will not remove by blank space in new update. 
            DB_Class dbc = new DB_Class();
            DataTable DT;
            DT = dbc.ReadDataTable("select * from Emp_LoginForm where ID = " + IDtb.Text);
            if (DT.Rows.Count > 0)
            {
                // if Emp textbox is empty put the value from database EmpName in it!!
                if (Emptb.Text == "")
                    Emptb.Text = DT.Rows[0]["Emp_Name"].ToString().Trim();
                if (FNametb.Text == "")
                    FNametb.Text = DT.Rows[0]["FName"].ToString().Trim();
                if (Contact_tb.Text == "")
                    Contact_tb.Text = DT.Rows[0]["Contact_No"].ToString().Trim();
                if (CNICtb.Text == "")
                    CNICtb.Text = DT.Rows[0]["CNIC_No"].ToString().Trim();
                if (Addresstb.Text == "")
                    Addresstb.Text = DT.Rows[0]["Address"].ToString().Trim();
                if (BSalarytb.Text == "")
                {
                    BSalarytb.Text = DT.Rows[0]["Basic_Salary"].ToString().Trim();
                    // if salary is till empty then we show msg to get salary by user
                    if (BSalarytb.Text == "")
                        lblMsg.Text = "Salary is Required";
                }
                if (DOBtb.Text == "")
                    DOBtb.Text = DT.Rows[0]["DOB"].ToString().Trim();
                if (DOJtb.Text == "")
                    DOJtb.Text = DT.Rows[0]["DOJ"].ToString().Trim();
                if (DOLtb.Text == "")
                    DOLtb.Text = DT.Rows[0]["DOL"].ToString().Trim();
                // if desig value is not value to the desig value of current id than change the desig value
                if (DesigList.SelectedValue != DT.Rows[0]["Desig_ID"].ToString())
                    DesigList.SelectedValue = DT.Rows[0]["Desig_ID"].ToString();
                if (DepartList.SelectedValue != DT.Rows[0]["Depart_ID"].ToString())
                    DepartList.SelectedValue = DT.Rows[0]["Depart_ID"].ToString();
                if (ImageName.Text == "")
                    ImageName.Text = DT.Rows[0]["Image"].ToString();
                // these value are not shown in form becoz they is ClearTb ethod called in the last of Form.

            }

            //Little bit complicated that why i break it in strings and concatenate in string variable

            //string SqlUpdateQuery = "update Emp_LoginForm set Emp_Name = '" + Emptb.Text + "',FName = '" + FNametb.Text + "',Contact_No = '" + Contact_tb.Text + "'" +
            //    ", CNIC_No = '" + CNICtb.Text + "', Address =  '" + Addresstb.Text + "', Basic_Salary = " + BSalarytb.Text +
            //    ", Desig_ID = '" + DesigList.SelectedValue + "', Depart_ID = '" + DepartList.SelectedValue + "' where ID = '" + IDtb.Text + "'";

            // Emp_Name and FName
            string Names = "Emp_Name = '" + Emptb.Text + "',FName = '" + FNametb.Text + "'";
            //Contact and Cnic Number
            string ConAndCnic = "Contact_No = '" + Contact_tb.Text + "', CNIC_No = '" + CNICtb.Text + "'";
            //Address and Salary
            string AddAndSal = "Address =  '" + Addresstb.Text + "', Basic_Salary = " + BSalarytb.Text;
            //Designation and Department list
            string Lists = "Desig_ID = '" + DesigList.SelectedValue + "', Depart_ID = '" + DepartList.SelectedValue + "'";
            //Date of Birth/Job/Leave
            string Dates = "DOB = '" + DOBtb.Text + "', DOJ = '" + DOJtb.Text + "', DOL = '" + DOLtb.Text + "'";
            //for Image
            string Image = "Image = '" + ImageName.Text + "'";

            // declare variable above to make the code clean
            string SqlUpdateQuery = "update Emp_LoginForm set " + Names + "," + ConAndCnic + "," + AddAndSal + "," + Lists + "," + Dates + "," + Image + " where ID = '" + IDtb.Text + "'";

            if (dbc.MyExecuteNonQuery(SqlUpdateQuery))
            {
                lblMsg.Text = "Successfully Execute";
            }
            else
            {
                lblMsg.Text = "Error";
            }
            // to clear the textboxes innthe form
            Cleartxtbx();
        }

    }

    //To Clear Every Textbox 
    protected void Cleartxtbx()
    {
        IDtb.Text = "";
        Emptb.Text = "";
        FNametb.Text = "";
        Contact_tb.Text = "";
        CNICtb.Text = "";
        Addresstb.Text = "";
        BSalarytb.Text = "";
        DOBtb.Text = "";
        DOJtb.Text = "";
        DOLtb.Text = "";
        Image1.ImageUrl = "";
    }
    protected void Deletebt_Click(object sender, EventArgs e)
    {
        if (IDtb.Text == "")
        {
            lblMsg.Text = "ID Required";
        }
        else
        {
            string SqlDelQuery = "Delete from Emp_LoginForm where ID = '" + IDtb.Text + "'";
            DB_Class dbc = new DB_Class();
            if (dbc.MyExecuteNonQuery(SqlDelQuery))
            {
                lblMsg.Text = "Successfully Execute";
            }
            else
            {
                lblMsg.Text = "Error";
            }
            Cleartxtbx();
        }
    }

    protected void Uploadbt_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string ext = Path.GetExtension(FileUpload1.FileName);
            if (ext == ".jpg" || ext == ".png")
            {
                //get the filename from the uploaded file
                string path = Path.GetFileName(FileUpload1.FileName);

                //replace blank spaces from the filename
                path = path.Replace(" ", "");

                //save selected image in the folder 'Images' right-top with path name 
                FileUpload1.SaveAs(Server.MapPath("~/Images/") + path);

                //Full Path of Image
                string imageName = "~/Images/" + path;
                Image1.ImageUrl = imageName;

                //Label name to save the 'Path' of image. put the image name in LabelText becoz 
                //it become easier to call 'Path' in other button located at left button after form 
                ImageName.Text = imageName;

                //Display For User
                Label1.Visible = true;
                Label1.Text = "Uploaded";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Upload Only png and jpg";
            }
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Please Upload File";
        }
    }
}