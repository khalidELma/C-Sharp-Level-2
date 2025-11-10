namespace Event
{
    partial class UC_test
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindBu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 32);
            this.textBox1.TabIndex = 0;
            // 
            // FindBu
            // 
            this.FindBu.Location = new System.Drawing.Point(276, 54);
            this.FindBu.Name = "FindBu";
            this.FindBu.Size = new System.Drawing.Size(112, 32);
            this.FindBu.TabIndex = 1;
            this.FindBu.Text = "button1";
            this.FindBu.UseVisualStyleBackColor = true;
            this.FindBu.Click += new System.EventHandler(this.FindBu_Click);
            // 
            // UC_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.FindBu);
            this.Controls.Add(this.textBox1);
            this.Name = "UC_test";
            this.Size = new System.Drawing.Size(457, 121);
            this.Load += new System.EventHandler(this.UC_test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindBu;
    }
}
