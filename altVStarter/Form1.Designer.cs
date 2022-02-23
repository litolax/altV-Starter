using System.Diagnostics;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.branchListBox = new System.Windows.Forms.ListBox();
            this.debugListBox = new System.Windows.Forms.ListBox();
            this.noUpdateListBox = new System.Windows.Forms.ListBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.branchListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.branchListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.branchListBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.branchListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.branchListBox.FormattingEnabled = true;
            this.branchListBox.ItemHeight = 21;
            this.branchListBox.Location = new System.Drawing.Point(12, 43);
            this.branchListBox.Name = "branchListBox";
            this.branchListBox.Size = new System.Drawing.Size(291, 65);
            this.branchListBox.TabIndex = 0;
            // 
            // listBox2
            // 
            this.debugListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.debugListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugListBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.debugListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.debugListBox.FormattingEnabled = true;
            this.debugListBox.ItemHeight = 21;
            this.debugListBox.Location = new System.Drawing.Point(12, 182);
            this.debugListBox.Name = "debugListBox";
            this.debugListBox.Size = new System.Drawing.Size(291, 65);
            this.debugListBox.TabIndex = 1;
            // 
            // listBox3
            // 
            this.noUpdateListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.noUpdateListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noUpdateListBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.noUpdateListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.noUpdateListBox.FormattingEnabled = true;
            this.noUpdateListBox.ItemHeight = 21;
            this.noUpdateListBox.Location = new System.Drawing.Point(12, 322);
            this.noUpdateListBox.Name = "noUpdateListBox";
            this.noUpdateListBox.Size = new System.Drawing.Size(291, 65);
            this.noUpdateListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.branchLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold);
            this.branchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.branchLabel.Location = new System.Drawing.Point(115, 9);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(89, 30);
            this.branchLabel.TabIndex = 2;
            this.branchLabel.Text = "Branch";
            // 
            // label2
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.debugLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold);
            this.debugLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.debugLabel.Location = new System.Drawing.Point(119, 140);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(80, 30);
            this.debugLabel.TabIndex = 3;
            this.debugLabel.Text = "Debug";
            // 
            // label3
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.updateLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold);
            this.updateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.updateLabel.Location = new System.Drawing.Point(102, 279);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(85, 30);
            this.updateLabel.TabIndex = 4;
            this.updateLabel.Text = "NoUpdate";
            // 
            // label4
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold);
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startLabel.Location = new System.Drawing.Point(128, 406);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(62, 30);
            this.startLabel.TabIndex = 5;
            this.startLabel.Text = "Start";
            this.startLabel.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(315, 445);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.branchLabel);
            this.Controls.Add(this.noUpdateListBox);
            this.Controls.Add(this.debugListBox);
            this.Controls.Add(this.branchListBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "alt:V Starter";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox branchListBox;
        private System.Windows.Forms.ListBox debugListBox;
        private System.Windows.Forms.ListBox noUpdateListBox;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label startLabel;
    }
}

