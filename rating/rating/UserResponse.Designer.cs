namespace rating
{
    partial class fUserResponse
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
            this.components = new System.ComponentModel.Container();
            this.lblquestion = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.lblsorry = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltime1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbltime2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(610, 240);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(573, 38);
            this.lblquestion.TabIndex = 0;
            this.lblquestion.Text = "Which reason do we need to improve?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(673, 330);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(276, 42);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "The toilet is dirty";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(673, 401);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(316, 42);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Problem with water";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(673, 473);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(524, 42);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Problem with hand dryer machine";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(673, 536);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(461, 42);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Problem with electric devices";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(829, 734);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(124, 59);
            this.btnsend.TabIndex = 5;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblsorry
            // 
            this.lblsorry.AutoSize = true;
            this.lblsorry.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsorry.Location = new System.Drawing.Point(403, 82);
            this.lblsorry.Name = "lblsorry";
            this.lblsorry.Size = new System.Drawing.Size(1066, 38);
            this.lblsorry.TabIndex = 6;
            this.lblsorry.Text = "We\'re so sorry to make you unhappy. We will improve our service better.";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltime1
            // 
            this.lbltime1.AutoSize = true;
            this.lbltime1.Location = new System.Drawing.Point(878, 811);
            this.lbltime1.Name = "lbltime1";
            this.lbltime1.Size = new System.Drawing.Size(24, 17);
            this.lbltime1.TabIndex = 7;
            this.lbltime1.Text = "20";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbltime2
            // 
            this.lbltime2.AutoSize = true;
            this.lbltime2.Location = new System.Drawing.Point(956, 582);
            this.lbltime2.Name = "lbltime2";
            this.lbltime2.Size = new System.Drawing.Size(24, 17);
            this.lbltime2.TabIndex = 8;
            this.lbltime2.Text = "10";
            // 
            // fUserResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 1057);
            this.Controls.Add(this.lbltime2);
            this.Controls.Add(this.lbltime1);
            this.Controls.Add(this.lblsorry);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblquestion);
            this.Name = "fUserResponse";
            this.Text = "Thank you for your time to feedback";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblsorry;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbltime2;
    }
}