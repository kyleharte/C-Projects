
namespace Numbers
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
            this.inte = new System.Windows.Forms.Button();
            this.flt = new System.Windows.Forms.Button();
            this.dbl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inte
            // 
            this.inte.Location = new System.Drawing.Point(12, 50);
            this.inte.Name = "inte";
            this.inte.Size = new System.Drawing.Size(331, 76);
            this.inte.TabIndex = 0;
            this.inte.Text = "Integer";
            this.inte.UseVisualStyleBackColor = true;
            this.inte.Click += new System.EventHandler(this.inte_Click);
            // 
            // flt
            // 
            this.flt.Location = new System.Drawing.Point(12, 154);
            this.flt.Name = "flt";
            this.flt.Size = new System.Drawing.Size(331, 76);
            this.flt.TabIndex = 1;
            this.flt.Text = "Float";
            this.flt.UseVisualStyleBackColor = true;
            this.flt.Click += new System.EventHandler(this.flt_Click_1);
            // 
            // dbl
            // 
            this.dbl.Location = new System.Drawing.Point(12, 261);
            this.dbl.Name = "dbl";
            this.dbl.Size = new System.Drawing.Size(331, 76);
            this.dbl.TabIndex = 2;
            this.dbl.Text = "Double";
            this.dbl.UseVisualStyleBackColor = true;
            this.dbl.Click += new System.EventHandler(this.dbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 447);
            this.Controls.Add(this.dbl);
            this.Controls.Add(this.flt);
            this.Controls.Add(this.inte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inte;
        private System.Windows.Forms.Button flt;
        private System.Windows.Forms.Button dbl;
    }
}

