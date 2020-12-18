
namespace Student_Automation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentLogin = new System.Windows.Forms.Button();
            this.teacherLogin = new System.Windows.Forms.Button();
            this.studentNumber = new System.Windows.Forms.TextBox();
            this.studentPassword = new System.Windows.Forms.TextBox();
            this.teacherPassword = new System.Windows.Forms.TextBox();
            this.teacherNumber = new System.Windows.Forms.TextBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.studentNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // studentLabel
            // 
            this.studentLabel.AccessibleName = "";
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentLabel.ForeColor = System.Drawing.Color.Red;
            this.studentLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.studentLabel.Location = new System.Drawing.Point(134, 23);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(126, 24);
            this.studentLabel.TabIndex = 3;
            this.studentLabel.Text = "Student Login";
            this.studentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherLabel.ForeColor = System.Drawing.Color.Red;
            this.teacherLabel.Location = new System.Drawing.Point(452, 23);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(133, 24);
            this.teacherLabel.TabIndex = 4;
            this.teacherLabel.Text = "Teacher Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teacher Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // studentLogin
            // 
            this.studentLogin.Location = new System.Drawing.Point(131, 199);
            this.studentLogin.Name = "studentLogin";
            this.studentLogin.Size = new System.Drawing.Size(75, 23);
            this.studentLogin.TabIndex = 9;
            this.studentLogin.Text = "Login";
            this.studentLogin.UseVisualStyleBackColor = true;
            this.studentLogin.Click += new System.EventHandler(this.studentLogin_Click);
            // 
            // teacherLogin
            // 
            this.teacherLogin.Location = new System.Drawing.Point(456, 199);
            this.teacherLogin.Name = "teacherLogin";
            this.teacherLogin.Size = new System.Drawing.Size(77, 23);
            this.teacherLogin.TabIndex = 10;
            this.teacherLogin.Text = "Login";
            this.teacherLogin.UseVisualStyleBackColor = true;
            this.teacherLogin.Click += new System.EventHandler(this.teacherLogin_Click);
            // 
            // studentNumber
            // 
            this.studentNumber.Location = new System.Drawing.Point(131, 83);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(172, 20);
            this.studentNumber.TabIndex = 11;
            // 
            // studentPassword
            // 
            this.studentPassword.Location = new System.Drawing.Point(131, 139);
            this.studentPassword.Name = "studentPassword";
            this.studentPassword.PasswordChar = '*';
            this.studentPassword.Size = new System.Drawing.Size(172, 20);
            this.studentPassword.TabIndex = 12;
            // 
            // teacherPassword
            // 
            this.teacherPassword.Location = new System.Drawing.Point(456, 139);
            this.teacherPassword.Name = "teacherPassword";
            this.teacherPassword.PasswordChar = '*';
            this.teacherPassword.Size = new System.Drawing.Size(172, 20);
            this.teacherPassword.TabIndex = 13;
            // 
            // teacherNumber
            // 
            this.teacherNumber.Location = new System.Drawing.Point(456, 83);
            this.teacherNumber.Name = "teacherNumber";
            this.teacherNumber.Size = new System.Drawing.Size(172, 20);
            this.teacherNumber.TabIndex = 14;
            // 
            // mainTable
            // 
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNumber1,
            this.name,
            this.surname,
            this.department,
            this.password});
            this.mainTable.Location = new System.Drawing.Point(72, 247);
            this.mainTable.Name = "mainTable";
            this.mainTable.Size = new System.Drawing.Size(544, 250);
            this.mainTable.TabIndex = 15;
            this.mainTable.Visible = false;
            // 
            // studentNumber1
            // 
            this.studentNumber1.HeaderText = "Student Number";
            this.studentNumber1.Name = "studentNumber1";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 523);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.teacherNumber);
            this.Controls.Add(this.teacherPassword);
            this.Controls.Add(this.studentPassword);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.teacherLogin);
            this.Controls.Add(this.studentLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.studentLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button studentLogin;
        private System.Windows.Forms.Button teacherLogin;
        private System.Windows.Forms.TextBox studentNumber;
        private System.Windows.Forms.TextBox studentPassword;
        private System.Windows.Forms.TextBox teacherPassword;
        private System.Windows.Forms.TextBox teacherNumber;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}

