using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace altVStarter
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
            this.branchListBox = new System.Windows.Forms.ListBox();
            this.debugListBox = new System.Windows.Forms.ListBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // branchListBox
            // 
            this.branchListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.branchListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.branchListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.branchListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.branchListBox.FormattingEnabled = true;
            this.branchListBox.ItemHeight = 20;
            this.branchListBox.Items.AddRange(new object[] { "Release", "Release Candidate", "Development" });
            this.branchListBox.Location = new System.Drawing.Point(12, 42);
            this.branchListBox.Name = "branchListBox";
            this.branchListBox.Size = new System.Drawing.Size(291, 62);
            this.branchListBox.TabIndex = 0;
            // 
            // debugListBox
            // 
            this.debugListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.debugListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.debugListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.debugListBox.FormattingEnabled = true;
            this.debugListBox.ItemHeight = 20;
            this.debugListBox.Items.AddRange(new object[] { "False", "True" });
            this.debugListBox.Location = new System.Drawing.Point(12, 156);
            this.debugListBox.Name = "debugListBox";
            this.debugListBox.Size = new System.Drawing.Size(291, 62);
            this.debugListBox.TabIndex = 1;
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.branchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.branchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.branchLabel.Location = new System.Drawing.Point(119, 9);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(87, 26);
            this.branchLabel.TabIndex = 2;
            this.branchLabel.Text = "Branch";
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.debugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.debugLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.debugLabel.Location = new System.Drawing.Point(119, 123);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(81, 26);
            this.debugLabel.TabIndex = 3;
            this.debugLabel.Text = "Debug";
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.Location = new System.Drawing.Point(12, 251);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(291, 41);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(315, 310);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.branchLabel);
            this.Controls.Add(this.debugListBox);
            this.Controls.Add(this.branchListBox);
            this.Controls.Add(this.startButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alt:V Starter";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HelpButtonClicked += this.OnHelpButtonClicked;
            this.Icon = new Icon("./altVIcon.ico");
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox branchListBox;
        private System.Windows.Forms.ListBox debugListBox;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Button startButton;
    }
}

