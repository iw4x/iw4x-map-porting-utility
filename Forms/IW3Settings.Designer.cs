namespace MapPortingUtility.Forms
{
    partial class IW3Settings
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
            this.includeGenericSoundsCheckbox = new System.Windows.Forms.CheckBox();
            this.addCarePackagesCheckbox = new System.Windows.Forms.CheckBox();
            this.correctSpecularsCheckbox = new System.Windows.Forms.CheckBox();
            this.convertGscsCheckbox = new System.Windows.Forms.CheckBox();
            this.smodelsFixComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.extendCullingDistanceCheckbox = new System.Windows.Forms.CheckBox();
            this.convertTurretsToMinigunsCheckbox = new System.Windows.Forms.CheckBox();
            this.raiseCeilingCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // includeGenericSoundsCheckbox
            // 
            this.includeGenericSoundsCheckbox.AutoSize = true;
            this.includeGenericSoundsCheckbox.Checked = true;
            this.includeGenericSoundsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeGenericSoundsCheckbox.Location = new System.Drawing.Point(12, 81);
            this.includeGenericSoundsCheckbox.Name = "includeGenericSoundsCheckbox";
            this.includeGenericSoundsCheckbox.Size = new System.Drawing.Size(136, 17);
            this.includeGenericSoundsCheckbox.TabIndex = 23;
            this.includeGenericSoundsCheckbox.Text = "Include generic sounds";
            this.includeGenericSoundsCheckbox.UseVisualStyleBackColor = true;
            // 
            // addCarePackagesCheckbox
            // 
            this.addCarePackagesCheckbox.AutoSize = true;
            this.addCarePackagesCheckbox.Checked = true;
            this.addCarePackagesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addCarePackagesCheckbox.Location = new System.Drawing.Point(12, 58);
            this.addCarePackagesCheckbox.Name = "addCarePackagesCheckbox";
            this.addCarePackagesCheckbox.Size = new System.Drawing.Size(119, 17);
            this.addCarePackagesCheckbox.TabIndex = 26;
            this.addCarePackagesCheckbox.Text = "Add care packages";
            this.addCarePackagesCheckbox.UseVisualStyleBackColor = true;
            // 
            // correctSpecularsCheckbox
            // 
            this.correctSpecularsCheckbox.AutoSize = true;
            this.correctSpecularsCheckbox.Checked = true;
            this.correctSpecularsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.correctSpecularsCheckbox.Location = new System.Drawing.Point(12, 35);
            this.correctSpecularsCheckbox.Name = "correctSpecularsCheckbox";
            this.correctSpecularsCheckbox.Size = new System.Drawing.Size(108, 17);
            this.correctSpecularsCheckbox.TabIndex = 21;
            this.correctSpecularsCheckbox.Text = "Correct speculars";
            this.correctSpecularsCheckbox.UseVisualStyleBackColor = true;
            // 
            // convertGscsCheckbox
            // 
            this.convertGscsCheckbox.AutoSize = true;
            this.convertGscsCheckbox.Checked = true;
            this.convertGscsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.convertGscsCheckbox.Location = new System.Drawing.Point(12, 12);
            this.convertGscsCheckbox.Name = "convertGscsCheckbox";
            this.convertGscsCheckbox.Size = new System.Drawing.Size(93, 17);
            this.convertGscsCheckbox.TabIndex = 20;
            this.convertGscsCheckbox.Text = "Convert GSCs";
            this.convertGscsCheckbox.UseVisualStyleBackColor = true;
            // 
            // smodelsFixComboBox
            // 
            this.smodelsFixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smodelsFixComboBox.FormattingEnabled = true;
            this.smodelsFixComboBox.Items.AddRange(new object[] {
            "Leave as-is",
            "Delete + move to entities",
            "Swap + move to entities"});
            this.smodelsFixComboBox.Location = new System.Drawing.Point(12, 219);
            this.smodelsFixComboBox.Name = "smodelsFixComboBox";
            this.smodelsFixComboBox.Size = new System.Drawing.Size(148, 21);
            this.smodelsFixComboBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Incompatible static models:";
            // 
            // extendCullingDistanceCheckbox
            // 
            this.extendCullingDistanceCheckbox.AutoSize = true;
            this.extendCullingDistanceCheckbox.Checked = true;
            this.extendCullingDistanceCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.extendCullingDistanceCheckbox.Location = new System.Drawing.Point(12, 104);
            this.extendCullingDistanceCheckbox.Name = "extendCullingDistanceCheckbox";
            this.extendCullingDistanceCheckbox.Size = new System.Drawing.Size(135, 17);
            this.extendCullingDistanceCheckbox.TabIndex = 27;
            this.extendCullingDistanceCheckbox.Text = "Extend culling distance";
            this.extendCullingDistanceCheckbox.UseVisualStyleBackColor = true;
            // 
            // convertTurretsToMinigunsCheckbox
            // 
            this.convertTurretsToMinigunsCheckbox.AutoSize = true;
            this.convertTurretsToMinigunsCheckbox.Location = new System.Drawing.Point(12, 127);
            this.convertTurretsToMinigunsCheckbox.Name = "convertTurretsToMinigunsCheckbox";
            this.convertTurretsToMinigunsCheckbox.Size = new System.Drawing.Size(164, 17);
            this.convertTurretsToMinigunsCheckbox.TabIndex = 28;
            this.convertTurretsToMinigunsCheckbox.Text = "Replace turrets with miniguns";
            this.convertTurretsToMinigunsCheckbox.UseVisualStyleBackColor = true;
            // 
            // raiseCeilingCheckbox
            // 
            this.raiseCeilingCheckbox.AutoSize = true;
            this.raiseCeilingCheckbox.Checked = true;
            this.raiseCeilingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.raiseCeilingCheckbox.Location = new System.Drawing.Point(12, 150);
            this.raiseCeilingCheckbox.Name = "raiseCeilingCheckbox";
            this.raiseCeilingCheckbox.Size = new System.Drawing.Size(86, 17);
            this.raiseCeilingCheckbox.TabIndex = 29;
            this.raiseCeilingCheckbox.Text = "Raise ceiling";
            this.raiseCeilingCheckbox.UseVisualStyleBackColor = true;
            // 
            // IW3Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(184, 252);
            this.Controls.Add(this.raiseCeilingCheckbox);
            this.Controls.Add(this.convertTurretsToMinigunsCheckbox);
            this.Controls.Add(this.extendCullingDistanceCheckbox);
            this.Controls.Add(this.addCarePackagesCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.includeGenericSoundsCheckbox);
            this.Controls.Add(this.smodelsFixComboBox);
            this.Controls.Add(this.correctSpecularsCheckbox);
            this.Controls.Add(this.convertGscsCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IW3Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox includeGenericSoundsCheckbox;
        private System.Windows.Forms.CheckBox addCarePackagesCheckbox;
        private System.Windows.Forms.CheckBox correctSpecularsCheckbox;
        private System.Windows.Forms.CheckBox convertGscsCheckbox;
        private System.Windows.Forms.ComboBox smodelsFixComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox extendCullingDistanceCheckbox;
        private System.Windows.Forms.CheckBox convertTurretsToMinigunsCheckbox;
        private System.Windows.Forms.CheckBox raiseCeilingCheckbox;
    }
}