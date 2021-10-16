
namespace BSUtils
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.priorityButton = new System.Windows.Forms.Button();
            this.AswButton = new System.Windows.Forms.Button();
            this.ReenableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priorityButton
            // 
            this.priorityButton.Location = new System.Drawing.Point(12, 12);
            this.priorityButton.Name = "priorityButton";
            this.priorityButton.Size = new System.Drawing.Size(114, 23);
            this.priorityButton.TabIndex = 0;
            this.priorityButton.Text = "Change BS Priority";
            this.priorityButton.UseVisualStyleBackColor = true;
            this.priorityButton.Click += new System.EventHandler(this.PriorityButton_Click);
            // 
            // AswButton
            // 
            this.AswButton.Location = new System.Drawing.Point(132, 12);
            this.AswButton.Name = "AswButton";
            this.AswButton.Size = new System.Drawing.Size(81, 23);
            this.AswButton.TabIndex = 1;
            this.AswButton.Text = "Disable ASW";
            this.AswButton.UseVisualStyleBackColor = true;
            this.AswButton.Click += new System.EventHandler(this.AswButton_Click);
            // 
            // ReenableButton
            // 
            this.ReenableButton.Location = new System.Drawing.Point(210, 226);
            this.ReenableButton.Name = "ReenableButton";
            this.ReenableButton.Size = new System.Drawing.Size(162, 23);
            this.ReenableButton.TabIndex = 2;
            this.ReenableButton.Text = "Re-Enable Disabled Buttons";
            this.ReenableButton.UseVisualStyleBackColor = true;
            this.ReenableButton.Click += new System.EventHandler(this.ReenableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ReenableButton);
            this.Controls.Add(this.AswButton);
            this.Controls.Add(this.priorityButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "BSUtils";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button priorityButton;
        private System.Windows.Forms.Button AswButton;
        private System.Windows.Forms.Button ReenableButton;
    }
}

