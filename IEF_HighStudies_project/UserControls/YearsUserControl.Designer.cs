namespace IEF_HighStudies_project.UserControls
{
    partial class YearsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.txtNotice = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.validEnd = new System.Windows.Forms.Label();
            this.validBegin = new System.Windows.Forms.Label();
            this.validName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.validMsg = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.yidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ybeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ynoticeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ydeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YearbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearTableAdapter1 = new MyDataset.IEFHSDBdatasetTableAdapters.YearTableAdapter();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 524);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 95);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(884, 300);
            this.panel7.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yidDataGridViewTextBoxColumn,
            this.ynameDataGridViewTextBoxColumn,
            this.ybeginDataGridViewTextBoxColumn,
            this.yendDataGridViewTextBoxColumn,
            this.ynoticeDataGridViewTextBoxColumn,
            this.ydeletedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.YearbindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 92);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(884, 3);
            this.panel10.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.txtNameSearch);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 46);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(884, 46);
            this.panel9.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ae_AlYermook", 12F);
            this.label2.Location = new System.Drawing.Point(753, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "بحث حسب السنة :";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNameSearch.Location = new System.Drawing.Point(32, 10);
            this.txtNameSearch.MaxLength = 50;
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(714, 27);
            this.txtNameSearch.TabIndex = 34;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(884, 3);
            this.panel6.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 3);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpEnd);
            this.panel5.Controls.Add(this.dtpBegin);
            this.panel5.Controls.Add(this.txtNotice);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.validEnd);
            this.panel5.Controls.Add(this.validBegin);
            this.panel5.Controls.Add(this.validName);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(884, 68);
            this.panel5.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(59, 9);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.RightToLeftLayout = true;
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 49;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(367, 9);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.RightToLeftLayout = true;
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 48;
            // 
            // txtNotice
            // 
            this.txtNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotice.Location = new System.Drawing.Point(39, 33);
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(743, 29);
            this.txtNotice.TabIndex = 47;
            this.txtNotice.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(819, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "ملاحظات :";
            // 
            // validEnd
            // 
            this.validEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validEnd.AutoSize = true;
            this.validEnd.ForeColor = System.Drawing.Color.Red;
            this.validEnd.Location = new System.Drawing.Point(32, 12);
            this.validEnd.Name = "validEnd";
            this.validEnd.Size = new System.Drawing.Size(21, 13);
            this.validEnd.TabIndex = 45;
            this.validEnd.Text = "(*)";
            this.validEnd.Visible = false;
            // 
            // validBegin
            // 
            this.validBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validBegin.AutoSize = true;
            this.validBegin.ForeColor = System.Drawing.Color.Red;
            this.validBegin.Location = new System.Drawing.Point(340, 12);
            this.validBegin.Name = "validBegin";
            this.validBegin.Size = new System.Drawing.Size(21, 13);
            this.validBegin.TabIndex = 44;
            this.validBegin.Text = "(*)";
            this.validBegin.Visible = false;
            // 
            // validName
            // 
            this.validName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validName.AutoSize = true;
            this.validName.ForeColor = System.Drawing.Color.Red;
            this.validName.Location = new System.Drawing.Point(632, 12);
            this.validName.Name = "validName";
            this.validName.Size = new System.Drawing.Size(21, 13);
            this.validName.TabIndex = 43;
            this.validName.Text = "(*)";
            this.validName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(659, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "تاريخ الانتهاء :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "تاريخ البدء : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(789, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "السنة الدراسية :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 3);
            this.panel4.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.validMsg);
            this.panel12.Controls.Add(this.btnSave);
            this.panel12.Controls.Add(this.btnPrint);
            this.panel12.Controls.Add(this.btnCancel);
            this.panel12.Controls.Add(this.btnDelete);
            this.panel12.Controls.Add(this.btnModify);
            this.panel12.Controls.Add(this.btnAdd);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 469);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(884, 55);
            this.panel12.TabIndex = 12;
            // 
            // validMsg
            // 
            this.validMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validMsg.AutoSize = true;
            this.validMsg.ForeColor = System.Drawing.Color.Red;
            this.validMsg.Location = new System.Drawing.Point(404, 21);
            this.validMsg.Name = "validMsg";
            this.validMsg.Size = new System.Drawing.Size(21, 13);
            this.validMsg.TabIndex = 35;
            this.validMsg.Text = "(*)";
            this.validMsg.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(101, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Location = new System.Drawing.Point(238, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 38);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(3, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(593, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(691, 6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(92, 38);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "تعديل";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(789, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(884, 43);
            this.panel11.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ae_AlYermook", 16F);
            this.label1.Location = new System.Drawing.Point(610, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "السنوات الدراسية";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yidDataGridViewTextBoxColumn
            // 
            this.yidDataGridViewTextBoxColumn.DataPropertyName = "y_id";
            this.yidDataGridViewTextBoxColumn.HeaderText = "y_id";
            this.yidDataGridViewTextBoxColumn.Name = "yidDataGridViewTextBoxColumn";
            this.yidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ynameDataGridViewTextBoxColumn
            // 
            this.ynameDataGridViewTextBoxColumn.DataPropertyName = "y_name";
            this.ynameDataGridViewTextBoxColumn.HeaderText = "y_name";
            this.ynameDataGridViewTextBoxColumn.Name = "ynameDataGridViewTextBoxColumn";
            this.ynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ybeginDataGridViewTextBoxColumn
            // 
            this.ybeginDataGridViewTextBoxColumn.DataPropertyName = "y_begin";
            this.ybeginDataGridViewTextBoxColumn.HeaderText = "y_begin";
            this.ybeginDataGridViewTextBoxColumn.Name = "ybeginDataGridViewTextBoxColumn";
            this.ybeginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yendDataGridViewTextBoxColumn
            // 
            this.yendDataGridViewTextBoxColumn.DataPropertyName = "y_end";
            this.yendDataGridViewTextBoxColumn.HeaderText = "y_end";
            this.yendDataGridViewTextBoxColumn.Name = "yendDataGridViewTextBoxColumn";
            this.yendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ynoticeDataGridViewTextBoxColumn
            // 
            this.ynoticeDataGridViewTextBoxColumn.DataPropertyName = "y_notice";
            this.ynoticeDataGridViewTextBoxColumn.HeaderText = "y_notice";
            this.ynoticeDataGridViewTextBoxColumn.Name = "ynoticeDataGridViewTextBoxColumn";
            this.ynoticeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ydeletedDataGridViewCheckBoxColumn
            // 
            this.ydeletedDataGridViewCheckBoxColumn.DataPropertyName = "y_deleted";
            this.ydeletedDataGridViewCheckBoxColumn.HeaderText = "y_deleted";
            this.ydeletedDataGridViewCheckBoxColumn.Name = "ydeletedDataGridViewCheckBoxColumn";
            this.ydeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // YearbindingSource
            // 
            this.YearbindingSource.DataMember = "Year";
            this.YearbindingSource.DataSource = typeof(MyDataset.IEFHSDBdataset);
            // 
            // yearTableAdapter1
            // 
            this.yearTableAdapter1.ClearBeforeFill = true;
            // 
            // YearsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "YearsUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(884, 524);
            this.Load += new System.EventHandler(this.YearsUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label validMsg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource YearbindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label validEnd;
        private System.Windows.Forms.Label validBegin;
        private System.Windows.Forms.Label validName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtNotice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn yidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ybeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ynoticeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ydeletedDataGridViewCheckBoxColumn;
        private MyDataset.IEFHSDBdatasetTableAdapters.YearTableAdapter yearTableAdapter1;
        
    }
}
