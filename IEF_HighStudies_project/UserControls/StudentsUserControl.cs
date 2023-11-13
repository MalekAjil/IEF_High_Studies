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
    public partial class StudentsUserControl : UserControl
    {
        public StudentsUserControl()
        {
            InitializeComponent();
        }

        private void StudentsUserControl_Load(object sender, EventArgs e)
        {
            //IEF_HighStudies_project.IEFHEDBDataSet.StudentRow Row = Program.GetDataset.Student.NewStudentRow();
            //Row.cme_name = txtName.Text;

            //Row.cme_isDeleted = false;
            //Program.GetDataset.CME_Student.AddCME_StudentRow(Row);
            //cME_StudentTableAdapter.Update(Row);
        }
    }
}
