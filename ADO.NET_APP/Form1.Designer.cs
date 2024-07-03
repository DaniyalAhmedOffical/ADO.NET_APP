namespace ADO.NET_APP
{
    partial class Form1
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
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Dlt_Btn = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CourseBox = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.Label();
            this.totalstd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(127, 41);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LastName";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(371, 40);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(127, 112);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(597, 41);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "ADD";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Dlt_Btn
            // 
            this.Dlt_Btn.Location = new System.Drawing.Point(597, 111);
            this.Dlt_Btn.Name = "Dlt_Btn";
            this.Dlt_Btn.Size = new System.Drawing.Size(75, 23);
            this.Dlt_Btn.TabIndex = 9;
            this.Dlt_Btn.Text = "DELETE";
            this.Dlt_Btn.UseVisualStyleBackColor = true;
            this.Dlt_Btn.Click += new System.EventHandler(this.Dlt_Btn_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(713, 112);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 23);
            this.Select.TabIndex = 10;
            this.Select.Text = "SELECT";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.Location = new System.Drawing.Point(371, 115);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(121, 21);
            this.CourseBox.TabIndex = 12;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(44, 180);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 13);
            this.count.TabIndex = 13;
            // 
            // totalstd
            // 
            this.totalstd.AutoSize = true;
            this.totalstd.Location = new System.Drawing.Point(50, 180);
            this.totalstd.Name = "totalstd";
            this.totalstd.Size = new System.Drawing.Size(21, 13);
            this.totalstd.TabIndex = 14;
            this.totalstd.Text = "std";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalstd);
            this.Controls.Add(this.count);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Dlt_Btn);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Dlt_Btn;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox CourseBox;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label totalstd;
    }
}

