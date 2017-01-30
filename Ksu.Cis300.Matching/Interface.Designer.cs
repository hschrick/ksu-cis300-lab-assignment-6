namespace Ksu.Cis300.Matching
{
    partial class ParenthesisMatcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter String:";
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(91, 25);
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(181, 20);
            this.uxTextBox.TabIndex = 1;
            // 
            // uxCheck
            // 
            this.uxCheck.Location = new System.Drawing.Point(91, 51);
            this.uxCheck.Name = "uxCheck";
            this.uxCheck.Size = new System.Drawing.Size(93, 36);
            this.uxCheck.TabIndex = 2;
            this.uxCheck.Text = "Check";
            this.uxCheck.UseVisualStyleBackColor = true;
            this.uxCheck.Click += new System.EventHandler(this.uxCheck_Click);
            // 
            // ParenthesisMatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.uxCheck);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ParenthesisMatcher";
            this.Text = "Parenthesis Matcher";
            this.Load += new System.EventHandler(this.ParenthesisMatcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.Button uxCheck;
    }
}

