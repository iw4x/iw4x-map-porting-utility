﻿namespace MapPortingUtility
{
    partial class SetPathsForm
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
            if (disposing && (components != null)) {
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPathsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseIW3Button = new System.Windows.Forms.Button();
            this.iw3PathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.browseIW4Button = new System.Windows.Forms.Button();
            this.iw4PathTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.browseIW5Button = new System.Windows.Forms.Button();
            this.iw5PathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.browseT5Button = new System.Windows.Forms.Button();
            this.t5PathTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(83, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(389, 70);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browseIW3Button);
            this.groupBox1.Controls.Add(this.iw3PathTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Call Of Duty 4 installation folder";
            // 
            // browseIW3Button
            // 
            this.browseIW3Button.Location = new System.Drawing.Point(388, 19);
            this.browseIW3Button.Name = "browseIW3Button";
            this.browseIW3Button.Size = new System.Drawing.Size(75, 23);
            this.browseIW3Button.TabIndex = 1;
            this.browseIW3Button.Text = "Browse...";
            this.browseIW3Button.UseVisualStyleBackColor = true;
            this.browseIW3Button.Click += new System.EventHandler(this.browseIW3Button_Click);
            // 
            // iw3PathTextBox
            // 
            this.iw3PathTextBox.Location = new System.Drawing.Point(6, 19);
            this.iw3PathTextBox.Name = "iw3PathTextBox";
            this.iw3PathTextBox.Size = new System.Drawing.Size(376, 20);
            this.iw3PathTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.browseIW4Button);
            this.groupBox2.Controls.Add(this.iw4PathTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Call Of Duty: Modern Warfare 2 installation folder";
            // 
            // browseIW4Button
            // 
            this.browseIW4Button.Location = new System.Drawing.Point(388, 19);
            this.browseIW4Button.Name = "browseIW4Button";
            this.browseIW4Button.Size = new System.Drawing.Size(75, 23);
            this.browseIW4Button.TabIndex = 1;
            this.browseIW4Button.Text = "Browse...";
            this.browseIW4Button.UseVisualStyleBackColor = true;
            this.browseIW4Button.Click += new System.EventHandler(this.browseIW4Button_Click);
            // 
            // iw4PathTextBox
            // 
            this.iw4PathTextBox.Location = new System.Drawing.Point(6, 19);
            this.iw4PathTextBox.Name = "iw4PathTextBox";
            this.iw4PathTextBox.Size = new System.Drawing.Size(376, 20);
            this.iw4PathTextBox.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(80, 299);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(386, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(3, 299);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(71, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MapPortingUtility.Properties.Resources.cardicon_porterjustice;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.browseIW5Button);
            this.groupBox3.Controls.Add(this.iw5PathTextBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modern Warfare 3 installation folder";
            // 
            // browseIW5Button
            // 
            this.browseIW5Button.Location = new System.Drawing.Point(388, 19);
            this.browseIW5Button.Name = "browseIW5Button";
            this.browseIW5Button.Size = new System.Drawing.Size(75, 23);
            this.browseIW5Button.TabIndex = 1;
            this.browseIW5Button.Text = "Browse...";
            this.browseIW5Button.UseVisualStyleBackColor = true;
            this.browseIW5Button.Click += new System.EventHandler(this.browseIW5Button_Click);
            // 
            // iw5PathTextBox
            // 
            this.iw5PathTextBox.Location = new System.Drawing.Point(6, 19);
            this.iw5PathTextBox.Name = "iw5PathTextBox";
            this.iw5PathTextBox.Size = new System.Drawing.Size(376, 20);
            this.iw5PathTextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.browseT5Button);
            this.groupBox4.Controls.Add(this.t5PathTextBox);
            this.groupBox4.Location = new System.Drawing.Point(3, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(469, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Black Ops installation folder";
            // 
            // browseT5Button
            // 
            this.browseT5Button.Location = new System.Drawing.Point(388, 19);
            this.browseT5Button.Name = "browseT5Button";
            this.browseT5Button.Size = new System.Drawing.Size(75, 23);
            this.browseT5Button.TabIndex = 1;
            this.browseT5Button.Text = "Browse...";
            this.browseT5Button.UseVisualStyleBackColor = true;
            this.browseT5Button.Click += new System.EventHandler(this.browseT5Button_Click);
            // 
            // t5PathTextBox
            // 
            this.t5PathTextBox.Location = new System.Drawing.Point(6, 19);
            this.t5PathTextBox.Name = "t5PathTextBox";
            this.t5PathTextBox.Size = new System.Drawing.Size(376, 20);
            this.t5PathTextBox.TabIndex = 0;
            // 
            // SetPathsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 329);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SetPathsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button browseIW3Button;
        private System.Windows.Forms.TextBox iw3PathTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browseIW4Button;
        private System.Windows.Forms.TextBox iw4PathTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button browseIW5Button;
        private System.Windows.Forms.TextBox iw5PathTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button browseT5Button;
        private System.Windows.Forms.TextBox t5PathTextBox;
    }
}
