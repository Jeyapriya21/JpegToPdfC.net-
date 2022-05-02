namespace PDFTest
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
            this.JPGTOPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JPGTOPDF
            // 
            this.JPGTOPDF.Location = new System.Drawing.Point(123, 95);
            this.JPGTOPDF.Name = "JPGTOPDF";
            this.JPGTOPDF.Size = new System.Drawing.Size(75, 23);
            this.JPGTOPDF.TabIndex = 0;
            this.JPGTOPDF.Text = "JpgToPdf";
            this.JPGTOPDF.UseVisualStyleBackColor = true;
            this.JPGTOPDF.Click += new System.EventHandler(this.JPGTOPDF_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.JPGTOPDF);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JPGTOPDF;
    }
}