using System.ComponentModel;

namespace 观察者模式传值
{
    partial class ChildForm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtChild3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtChild3
            // 
            this.txtChild3.Location = new System.Drawing.Point(213, 204);
            this.txtChild3.Name = "txtChild3";
            this.txtChild3.Size = new System.Drawing.Size(100, 21);
            this.txtChild3.TabIndex = 0;
            // 
            // ChildForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtChild3);
            this.Name = "ChildForm3";
            this.Text = "ChildForm3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtChild3;

        #endregion
    }
}