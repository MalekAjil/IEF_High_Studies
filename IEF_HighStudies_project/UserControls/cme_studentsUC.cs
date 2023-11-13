using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEF_HighStudies_project
{
    public partial class cme_studentsUC : UserControl
    {
        bool isInsert = false;
       
        private void cme_studentsUC_Load(object sender, EventArgs e)
        {
            cmE_StudentTableAdapter1.Fill(Program.GetDataset.CME_Student);
            cME_StudentBindingSource.DataSource = Program.GetDataset;
            cMEStudentBindingSource.DataSource = Program.GetDataset;
            BrowseState();
        }
        public cme_studentsUC()
        {
            InitializeComponent();
        }

        

        private void cME_StudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cME_StudentBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.iEFHEDBDataSet);
        }

        private void rbCycleSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCycleSearch.Checked)
                cbCycleSearch.Enabled = true;
            else
                cbCycleSearch.Enabled = false;
        }

        private void rbExamNumSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExamNumSearch.Checked)
                nudExamNumS.Enabled = true;
            else
                nudExamNumS.Enabled = false;
        }

        private void rbNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNameSearch.Checked)
            {
                txtNameS.Enabled = true;
                txtSureNameS.Enabled = true;
                txtFatherS.Enabled = true;
            }
            else
            {
                txtNameS.Enabled = false;
                txtSureNameS.Enabled = false;
                txtFatherS.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isInsert = true;
            txtName.Text = "";            
            FunctionState();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            isInsert = false;
            FunctionState();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "هل أنت متأكد من الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MyDataset.IEFHSDBdataset.CME_StudentRow Row = (cME_StudentBindingSource.Current as DataRowView).Row as MyDataset.IEFHSDBdataset.CME_StudentRow;
                Row.cme_isDeleted = true;
                cmE_StudentTableAdapter1.Update(Row);
                cmE_StudentTableAdapter1.Fill(Program.GetDataset.CME_Student);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check())
            {
                //Insert
                if (isInsert)
                {
                    MyDataset.IEFHSDBdataset.CME_StudentRow Row = Program.GetDataset.CME_Student.NewCME_StudentRow();
                    Row.cme_examNum = (int)nudExamNum.Value;
                    Row.cme_name = txtName.Text;
                    Row.cme_lastName = txtSureName.Text;
                    Row.cme_father = txtFather.Text;
                    Row.cme_dept =(int) cbDept.SelectedValue;
                    Row.cme_cycle =Convert.ToDateTime(cbCycle.Text);
                    Row.cme_mark =(int) nudMark.Value;
                    Row.cme_isAccepted = cbAccepted.Checked;
                    
                    Row.cme_isDeleted = false;
                    Program.GetDataset.CME_Student.AddCME_StudentRow(Row);
                    cmE_StudentTableAdapter1.Update(Row);
                }
                else //Update
                {
                    MyDataset.IEFHSDBdataset.CME_StudentRow Row = (cME_StudentBindingSource.Current as DataRowView).Row as MyDataset.IEFHSDBdataset.CME_StudentRow;
                    
                    Row.cme_examNum = (int)nudExamNum.Value;
                    Row.cme_name = txtName.Text;
                    Row.cme_lastName = txtSureName.Text;
                    Row.cme_father = txtFather.Text;
                    Row.cme_dept = (int)cbDept.SelectedValue;
                    Row.cme_cycle = Convert.ToDateTime(cbCycle.Text);
                    Row.cme_mark = (int)nudMark.Value;
                    Row.cme_isAccepted = cbAccepted.Checked;
                    
                    cmE_StudentTableAdapter1.Update(Row);
                }
                BrowseState();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BrowseState();
        }
        void BrowseState()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            
            btnAdd.Enabled = true;
            btnModify.Enabled = true;
            btnDelete.Enabled = true;

            nudExamNum.ReadOnly = true;
            txtName.ReadOnly = true;
            txtSureName.ReadOnly = true;
            txtFather.ReadOnly = true;            
            nudMark.ReadOnly = true;            
            txtNotice.ReadOnly = true;
            cbCycle.Enabled = false;
            cbDept.Enabled = false;
            cbResult.Enabled = false;
            cbAccepted.Enabled = false;

            nudExamNum.DataBindings.Add("Value", cME_StudentBindingSource, "cme_examNum");
            txtName.DataBindings.Add("Text", cME_StudentBindingSource, "cme_name");
            txtSureName.DataBindings.Add("Text", cME_StudentBindingSource, "cme_lastName");
            txtFather.DataBindings.Add("Text", cME_StudentBindingSource, "cme_father");
            cbCycle.DataBindings.Add("Text", cME_StudentBindingSource, "cme_cycle");
            nudMark.DataBindings.Add("Value", cME_StudentBindingSource, "cme_mark");
            txtNotice.DataBindings.Add("Text", cME_StudentBindingSource, "cme_notice");
            cbDept.DataBindings.Add("SelectedValue", cME_StudentBindingSource, "cme_dept");
            cbResult.DataBindings.Add("Checked", cME_StudentBindingSource, "cme_result");
            cbAccepted.DataBindings.Add("Checked", cME_StudentBindingSource, "cme_isAccepted");
        }
        void FunctionState()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;

            nudExamNum.ReadOnly = false;
            txtName.ReadOnly = false;
            txtSureName.ReadOnly = false;
            txtFather.ReadOnly = false;
            nudMark.ReadOnly = false;            
            txtNotice.ReadOnly = false;
            cbCycle.Enabled = true;
            cbDept.Enabled = true;
            cbResult.Enabled = true;
            cbAccepted.Enabled = true;

            nudExamNum.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtSureName.DataBindings.Clear();
            txtFather.DataBindings.Clear();
            cbCycle.DataBindings.Clear();
            nudMark.DataBindings.Clear();
            txtNotice.DataBindings.Clear();
            cbDept.DataBindings.Clear();
            cbResult.DataBindings.Clear();
            cbAccepted.DataBindings.Clear();
        }
        bool check()
        {
            if (nudExamNum.Text.Length > 0)
            {
                validExamNum.Visible = false;
                validMsg.Visible = false;
            }
            else
            {
                validExamNum.Visible = true;
                validMsg.Visible = true;
                validMsg.Text = "الرجاء كتابة الرقم الامتحاني  ";
                return false;
            }
            if (txtName.Text.Length > 0)
            {
                validName.Visible = false;
                validMsg.Visible = false;
            }
            else
            {
                validName.Visible = true;
                validMsg.Visible = true;
                validMsg.Text = "الرجاء كتابة الاسم  ";
                return false;
            }
            if (txtSureName.Text.Length > 0)
            {
                validSureName.Visible = false;
                validMsg.Visible = false;
            }
            else
            {
                validSureName.Visible = true;
                validMsg.Visible = true;
                validMsg.Text = "الرجاء كتابة الكنية  ";
                return false;
            } 
            if (txtFather.Text.Length > 0)
            {
                validFather.Visible = false;
                validMsg.Visible = false;
            }
            else
            {
                validFather.Visible = true;
                validMsg.Visible = true;
                validMsg.Text = "الرجاء كتابة اسم الأب  ";
                return false;
            }
            if (cbCycle.Text.Length > 0)
            {
                validCycle.Visible = false;
                validMsg.Visible = false;
            }
            else
            {
                validCycle.Visible = true;
                validMsg.Visible = true;
                validMsg.Text = "الرجاء كتابة الدورة  ";
                return false;
            }
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(rbExamNumSearch.Checked)
            {
                cMEStudentBindingSource.Filter = "cme_examNum =" + nudExamNumS.Text;
            }
            else if(rbCycleSearch.Checked)
            {
                cMEStudentBindingSource.Filter = "cme_cycle ='" + cbCycleSearch.Text + "'";
            }
            else if(rbNameSearch.Checked)
            {
                if (txtNameS.TextLength > 0 && txtSureNameS.TextLength > 0 && txtFatherS.TextLength > 0)
                {
                    cMEStudentBindingSource.Filter = "cme_name like'%" + txtNameS.Text + "%' AND cme_lastName like '%" + txtSureNameS.Text + "%' AND cme_father like '%" + txtFatherS.Text + "%'";
                }
                else if(txtNameS.TextLength > 0 && txtSureNameS.TextLength > 0)
                {
                    cMEStudentBindingSource.Filter = "cme_name like'%" + txtNameS.Text + "%' AND cme_lastName like '%" + txtSureNameS.Text + "%' AND cme_father like '%" + txtFatherS.Text + "%'";
                }
                else if (txtNameS.TextLength > 0 && txtFatherS.TextLength > 0)
                {
                    cMEStudentBindingSource.Filter = "cme_name like'%" + txtNameS.Text + "%'  AND cme_father like '%" + txtFatherS.Text + "%'";
                }
                else if (txtSureNameS.TextLength > 0 && txtFatherS.TextLength > 0)
                {
                    cMEStudentBindingSource.Filter = "cme_lastName like '%" + txtSureNameS.Text + "%' AND cme_father like '%" + txtFatherS.Text + "%'";
                }
                else if (txtNameS.TextLength > 0)
                {
                    cMEStudentBindingSource.Filter = "cme_name like'%" + txtNameS.Text + "%'";
                }
                else if (txtSureNameS.TextLength > 0)
                {
                    cMEStudentBindingSource.Filter = " cme_lastName like '%" + txtSureNameS.Text + "%'";
                }
                else if (txtFatherS.TextLength > 0 )
                {
                    cMEStudentBindingSource.Filter = "cme_father like '%" + txtFatherS.Text + "%'";
                }
            }

        }
    }
}
