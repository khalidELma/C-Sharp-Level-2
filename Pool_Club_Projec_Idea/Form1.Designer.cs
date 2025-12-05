namespace Pool_Club_Project_Idea
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
            this.userControl23 = new Pool_Club_Project_Idea.UserControl2();
            this.userControl22 = new Pool_Club_Project_Idea.UserControl2();
            this.userControl21 = new Pool_Club_Project_Idea.UserControl2();
            this.SuspendLayout();
            // 
            // userControl23
            // 
            this.userControl23._hourlyRate = 0F;
            this.userControl23.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControl23.Location = new System.Drawing.Point(753, 31);
            this.userControl23.Name = "userControl23";
            this.userControl23.PlayerName = null;
            this.userControl23.Size = new System.Drawing.Size(359, 267);
            this.userControl23.TabIndex = 2;
            this.userControl23.TableName = "table3";
            // 
            // userControl22
            // 
            this.userControl22._hourlyRate = 0F;
            this.userControl22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControl22.Location = new System.Drawing.Point(388, 31);
            this.userControl22.Name = "userControl22";
            this.userControl22.PlayerName = null;
            this.userControl22.Size = new System.Drawing.Size(359, 267);
            this.userControl22.TabIndex = 1;
            this.userControl22.TableName = "table2";
            // 
            // userControl21
            // 
            this.userControl21._hourlyRate = 0F;
            this.userControl21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControl21.Location = new System.Drawing.Point(23, 31);
            this.userControl21.Name = "userControl21";
            this.userControl21.PlayerName = null;
            this.userControl21.Size = new System.Drawing.Size(359, 267);
            this.userControl21.TabIndex = 0;
            this.userControl21.TableName = "table1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1149, 324);
            this.Controls.Add(this.userControl23);
            this.Controls.Add(this.userControl22);
            this.Controls.Add(this.userControl21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl2 userControl21;
        private UserControl2 userControl22;
        private UserControl2 userControl23;
    }
}

