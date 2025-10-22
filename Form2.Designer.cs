namespace OkulSis
{
    partial class Form2
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
            dgw = new DataGridView();
            StudentNo = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            StudentSurname = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            studentNameLabel = new Label();
            StudentSurnameLabel = new Label();
            StudentNumLabel = new Label();
            stuNumberTb = new TextBox();
            stuNameTb = new TextBox();
            StudentClassLabel = new Label();
            stuSurnameTb = new TextBox();
            stuClassTb = new TextBox();
            searchBtn = new Button();
            addBtn = new Button();
            dltBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw).BeginInit();
            SuspendLayout();
            // 
            // dgw
            // 
            dgw.AllowUserToAddRows = false;
            dgw.AllowUserToDeleteRows = false;
            dgw.AllowUserToOrderColumns = true;
            dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw.Columns.AddRange(new DataGridViewColumn[] { StudentNo, StudentName, StudentSurname, Class });
            dgw.Location = new Point(24, 10);
            dgw.MultiSelect = false;
            dgw.Name = "dgw";
            dgw.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgw.Size = new Size(345, 295);
            dgw.TabIndex = 0;
            // 
            // StudentNo
            // 
            StudentNo.HeaderText = "StudentNo";
            StudentNo.Name = "StudentNo";
            StudentNo.Visible = false;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "StudentName";
            StudentName.Name = "StudentName";
            StudentName.Visible = false;
            // 
            // StudentSurname
            // 
            StudentSurname.HeaderText = "StudentSurname";
            StudentSurname.Name = "StudentSurname";
            StudentSurname.Visible = false;
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
            Class.Visible = false;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            studentNameLabel.Location = new Point(375, 58);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(115, 20);
            studentNameLabel.TabIndex = 1;
            studentNameLabel.Text = "Student Name : ";
            // 
            // StudentSurnameLabel
            // 
            StudentSurnameLabel.AutoSize = true;
            StudentSurnameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            StudentSurnameLabel.Location = new Point(375, 94);
            StudentSurnameLabel.Name = "StudentSurnameLabel";
            StudentSurnameLabel.Size = new Size(133, 20);
            StudentSurnameLabel.TabIndex = 2;
            StudentSurnameLabel.Text = "Student Surname : ";
            // 
            // StudentNumLabel
            // 
            StudentNumLabel.AutoSize = true;
            StudentNumLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            StudentNumLabel.Location = new Point(375, 22);
            StudentNumLabel.Name = "StudentNumLabel";
            StudentNumLabel.Size = new Size(129, 20);
            StudentNumLabel.TabIndex = 3;
            StudentNumLabel.Text = "Student Number : ";
            // 
            // stuNumberTb
            // 
            stuNumberTb.Location = new Point(510, 22);
            stuNumberTb.Name = "stuNumberTb";
            stuNumberTb.Size = new Size(188, 23);
            stuNumberTb.TabIndex = 4;
            // 
            // stuNameTb
            // 
            stuNameTb.Location = new Point(510, 59);
            stuNameTb.Name = "stuNameTb";
            stuNameTb.Size = new Size(188, 23);
            stuNameTb.TabIndex = 5;
            // 
            // StudentClassLabel
            // 
            StudentClassLabel.AutoSize = true;
            StudentClassLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            StudentClassLabel.Location = new Point(375, 130);
            StudentClassLabel.Name = "StudentClassLabel";
            StudentClassLabel.Size = new Size(104, 20);
            StudentClassLabel.TabIndex = 6;
            StudentClassLabel.Text = "Student Class :";
            // 
            // stuSurnameTb
            // 
            stuSurnameTb.Location = new Point(510, 96);
            stuSurnameTb.Name = "stuSurnameTb";
            stuSurnameTb.Size = new Size(188, 23);
            stuSurnameTb.TabIndex = 7;
            // 
            // stuClassTb
            // 
            stuClassTb.Location = new Point(510, 133);
            stuClassTb.Name = "stuClassTb";
            stuClassTb.Size = new Size(188, 23);
            stuClassTb.TabIndex = 8;
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            searchBtn.Location = new Point(380, 225);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(80, 37);
            searchBtn.TabIndex = 9;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addBtn.Location = new Point(499, 225);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(80, 37);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // dltBtn
            // 
            dltBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dltBtn.Location = new Point(618, 225);
            dltBtn.Name = "dltBtn";
            dltBtn.Size = new Size(80, 37);
            dltBtn.TabIndex = 11;
            dltBtn.Text = "Delete";
            dltBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 321);
            Controls.Add(dltBtn);
            Controls.Add(addBtn);
            Controls.Add(searchBtn);
            Controls.Add(stuClassTb);
            Controls.Add(stuSurnameTb);
            Controls.Add(StudentClassLabel);
            Controls.Add(stuNameTb);
            Controls.Add(stuNumberTb);
            Controls.Add(StudentNumLabel);
            Controls.Add(StudentSurnameLabel);
            Controls.Add(studentNameLabel);
            Controls.Add(dgw);
            Name = "Form2";
            Text = "Sinif Listeleri";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw;
        private DataGridViewTextBoxColumn StudentNo;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn StudentSurname;
        private DataGridViewTextBoxColumn Class;
        private Label studentNameLabel;
        private Label StudentSurnameLabel;
        private Label StudentNumLabel;
        private TextBox stuNumberTb;
        private TextBox stuNameTb;
        private Label StudentClassLabel;
        private TextBox stuSurnameTb;
        private TextBox stuClassTb;
        private Button searchBtn;
        private Button addBtn;
        private Button dltBtn;
    }
}