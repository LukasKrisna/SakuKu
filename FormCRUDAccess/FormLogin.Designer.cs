namespace FormCRUDAccess
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.button1 = new System.Windows.Forms.Button();
            this.text_Username = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_Username
            // 
            this.text_Username.Location = new System.Drawing.Point(217, 154);
            this.text_Username.Multiline = true;
            this.text_Username.Name = "text_Username";
            this.text_Username.Size = new System.Drawing.Size(209, 31);
            this.text_Username.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "SignUp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_Password
            // 
            this.text_Password.Location = new System.Drawing.Point(217, 191);
            this.text_Password.Multiline = true;
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(209, 31);
            this.text_Password.TabIndex = 4;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(541, 346);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_Username);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_Username;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_Password;
    }
}