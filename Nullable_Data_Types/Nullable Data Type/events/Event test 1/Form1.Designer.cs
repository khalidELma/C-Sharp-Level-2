namespace Event_test_1
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
            this.caluclater1 = new Event_test_1.Caluclater();
            this.SuspendLayout();
            // 
            // caluclater1
            // 
            this.caluclater1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.caluclater1.Location = new System.Drawing.Point(12, 12);
            this.caluclater1.Name = "caluclater1";
            this.caluclater1.Size = new System.Drawing.Size(366, 304);
            this.caluclater1.TabIndex = 0;
            this.caluclater1.IsCalculationComplete += new System.EventHandler<Event_test_1.Caluclater.CalculateComplateEventArgs>(this.caluclater1_IsCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 484);
            this.Controls.Add(this.caluclater1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Caluclater caluclater1;
    }
}

