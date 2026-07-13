namespace MyFirstWinFormsProject
{
    partial class LinkedLabel
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
            this.lbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(275, 123);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(192, 23);
            this.lbl.TabIndex = 0;
            this.lbl.TabStop = true;
            this.lbl.Text = "ProgrammingAdvices";
            this.lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_LinkClicked);
            // 
            // LinkedLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Name = "LinkedLabel";
            this.Text = "LinkedLabel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl;
    }
}