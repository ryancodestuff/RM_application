
namespace RM_application.Front_End.View
{
    partial class Login_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Location = new System.Drawing.Point(145, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox1.Location = new System.Drawing.Point(55, 141);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(150, 31);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(361, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 340);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(179, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(179, 252);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(90, 30);
            this.login.TabIndex = 5;
            this.login.Text = "Sign In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login_page";
            this.Load += new System.EventHandler(this.Login_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button login;
    }
}
