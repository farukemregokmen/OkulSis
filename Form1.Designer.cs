namespace OkulSis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNoBox = new TextBox();
            passBox = new TextBox();
            userNoLabel = new Label();
            passLabel = new Label();
            girisBut = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // userNoBox
            // 
            userNoBox.Location = new Point(253, 106);
            userNoBox.Name = "userNoBox";
            userNoBox.Size = new Size(111, 23);
            userNoBox.TabIndex = 0;
            // 
            // passBox
            // 
            passBox.Location = new Point(253, 173);
            passBox.Name = "passBox";
            passBox.Size = new Size(111, 23);
            passBox.TabIndex = 1;
            // 
            // userNoLabel
            // 
            userNoLabel.AutoSize = true;
            userNoLabel.Font = new Font("Segoe UI", 12F);
            userNoLabel.Location = new Point(113, 104);
            userNoLabel.Name = "userNoLabel";
            userNoLabel.Size = new Size(104, 21);
            userNoLabel.TabIndex = 2;
            userNoLabel.Text = "Kullanıcı No : ";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Segoe UI", 12F);
            passLabel.Location = new Point(113, 175);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(115, 21);
            passLabel.TabIndex = 3;
            passLabel.Text = "Kullanıcı Sifre : ";
            // 
            // girisBut
            // 
            girisBut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            girisBut.Location = new Point(195, 239);
            girisBut.Name = "girisBut";
            girisBut.Size = new Size(96, 31);
            girisBut.TabIndex = 4;
            girisBut.Text = "Giris";
            girisBut.UseVisualStyleBackColor = true;
            girisBut.Click += girisBut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 307);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "false";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 369);
            Controls.Add(label1);
            Controls.Add(girisBut);
            Controls.Add(passLabel);
            Controls.Add(userNoLabel);
            Controls.Add(passBox);
            Controls.Add(userNoBox);
            Name = "Form1";
            Text = "Giris";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNoBox;
        private TextBox passBox;
        private Label userNoLabel;
        private Label passLabel;
        private Button girisBut;
        private Label label1;
    }
}
