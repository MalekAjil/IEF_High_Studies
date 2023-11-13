using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEF_HighStudies_project.UserControls
{
    public partial class YearsUserControl : UserControl
    {
        bool isInsert = false;
       
        public YearsUserControl()
        {
            InitializeComponent();
        }

        private void YearsUserControl_Load(object sender, EventArgs e)
        {
            yearTableAdapter1.Fill(Program.GetDataset.Year);
            YearbindingSource.DataSource = Program.GetDataset;
            BrowseState();            
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
                MyDataset.IEFHSDBdataset.YearRow Row = (YearbindingSource.Current as DataRowView).Row as MyDataset.IEFHSDBdataset.YearRow;
                Row.y_deleted = true;
                yearTableAdapter1.Update(Row);
                yearTableAdapter1.Fill(Program.GetDataset.Year);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check())
            {
                //Insert
                if (isInsert)
                {
                    MyDataset.IEFHSDBdataset.YearRow Row = Program.GetDataset.Year.NewYearRow();
                    Row.y_name = txtName.Text;

                    Row.y_deleted = false;
                    Program.GetDataset.Year.AddYearRow(Row);
                    yearTableAdapter1.Update(Row);
                }
                else //Update
                {
                    MyDataset.IEFHSDBdataset.YearRow Row = (YearbindingSource.Current as DataRowView).Row as MyDataset.IEFHSDBdataset.YearRow;
                    Row.y_name = txtName.Text;
                    yearTableAdapter1.Update(Row);
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
                        
            txtName.ReadOnly = true;
            txtNotice.ReadOnly = true;

            txtName.DataBindings.Add("Text", YearbindingSource, "y_name");
            txtNotice.DataBindings.Add("Text", YearbindingSource, "y_notice");        
        }
        void FunctionState()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;

            txtName.ReadOnly = false;
            txtNotice.ReadOnly = false;
            
            txtName.DataBindings.Clear();
            txtNotice.DataBindings.Clear();           
        }
        bool check()
        {            
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
            if (dtpBegin.Text.Length > 0)
            {
                validBegin.Visible = false;
                validMsg.Visible = false;
            }
            else
            {
                validBegin.Visible = true;
                validMsg.Visible = true;
                validMsg.Text = "الرجاء كتابة تارخ البدء  ";
                return false;
            } 
            if (dtpEnd.Text.Length > 0)
            {
                validEnd.Visible = false;
                validMsg.Visible = false;
            }
            else
            {
                validEnd.Visible = true;
                validMsg.Visible = true;
                validMsg.Text = "الرجاء كتابة تاريخ النهاية ";
                return false;
            }
            
            return true;
        }        
        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            YearbindingSource.Filter = "y_name like'%" + txtNameSearch.Text + "%'";
        }
    }
}
