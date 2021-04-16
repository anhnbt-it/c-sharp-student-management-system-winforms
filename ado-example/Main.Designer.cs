namespace ado_example
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblAddNewClass = new System.Windows.Forms.Label();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.txtAddNewClass = new System.Windows.Forms.TextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(427, 291);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(186, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(168, 13);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "CLASS MANAGEMENT SYSTEM";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(36, 74);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(63, 13);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Class Name";
            this.lblClassName.Click += new System.EventHandler(this.lblClassName_Click);
            // 
            // lblAddNewClass
            // 
            this.lblAddNewClass.AutoSize = true;
            this.lblAddNewClass.Location = new System.Drawing.Point(20, 118);
            this.lblAddNewClass.Name = "lblAddNewClass";
            this.lblAddNewClass.Size = new System.Drawing.Size(79, 13);
            this.lblAddNewClass.TabIndex = 3;
            this.lblAddNewClass.Text = "Add New Class";
            // 
            // cboClassName
            // 
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(120, 71);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(121, 21);
            this.cboClassName.TabIndex = 4;
            this.cboClassName.SelectedIndexChanged += new System.EventHandler(this.cboClassName_SelectedIndexChanged);
            // 
            // txtAddNewClass
            // 
            this.txtAddNewClass.Location = new System.Drawing.Point(120, 115);
            this.txtAddNewClass.Name = "txtAddNewClass";
            this.txtAddNewClass.Size = new System.Drawing.Size(121, 20);
            this.txtAddNewClass.TabIndex = 5;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(85, 165);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 6;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(166, 165);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClass.TabIndex = 7;
            this.btnDeleteClass.Text = "Delete Class";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(361, 71);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(167, 212);
            this.lbStudents.TabIndex = 8;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Location = new System.Drawing.Point(334, 291);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(87, 23);
            this.btnViewStudent.TabIndex = 9;
            this.btnViewStudent.Text = "View Student";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 326);
            this.Controls.Add(this.btnViewStudent);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.txtAddNewClass);
            this.Controls.Add(this.cboClassName);
            this.Controls.Add(this.lblAddNewClass);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.Text = "Class Management System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblAddNewClass;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.TextBox txtAddNewClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnViewStudent;

    }
}

