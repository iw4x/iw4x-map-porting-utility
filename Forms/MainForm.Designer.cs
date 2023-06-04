namespace MapPortingUtility
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox zonebuilderGroupBox;
            System.Windows.Forms.GroupBox outputBoxGroup;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buildTeamsCheckbox = new System.Windows.Forms.CheckBox();
            this.regenerateZoneSourceButton = new System.Windows.Forms.Button();
            this.zbRefreshButton = new System.Windows.Forms.Button();
            this.openMapFolderButton = new System.Windows.Forms.Button();
            this.editCSVButton = new System.Windows.Forms.Button();
            this.editArenaFileButton = new System.Windows.Forms.Button();
            this.runMapButton = new System.Windows.Forms.Button();
            this.generateIWDButton = new System.Windows.Forms.Button();
            this.buildZoneButton = new System.Windows.Forms.Button();
            this.iw4ZoneListBox = new System.Windows.Forms.CheckedListBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.getHelpOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputTabs = new System.Windows.Forms.TabControl();
            this.iw3TabPage = new System.Windows.Forms.TabPage();
            this.addCarePackageCheckbox = new System.Windows.Forms.CheckBox();
            this.iw3RefreshButton = new System.Windows.Forms.Button();
            this.smodelsFixComboBox = new System.Windows.Forms.ComboBox();
            this.includeGenericSoundsCheckbox = new System.Windows.Forms.CheckBox();
            this.replaceExistingFilesCheckbox = new System.Windows.Forms.CheckBox();
            this.correctSpecularsCheckbox = new System.Windows.Forms.CheckBox();
            this.convertGscCheckbox = new System.Windows.Forms.CheckBox();
            this.generateArenaCheckbox = new System.Windows.Forms.CheckBox();
            this.generateSourceCheckbox = new System.Windows.Forms.CheckBox();
            this.iw3ExportButton = new System.Windows.Forms.Button();
            this.iw3MapListBox = new System.Windows.Forms.CheckedListBox();
            this.iw5TabPage = new System.Windows.Forms.TabPage();
            this.iw5RefreshButton = new System.Windows.Forms.Button();
            this.iw5GenerateArena = new System.Windows.Forms.CheckBox();
            this.iw5OverwriteSource = new System.Windows.Forms.CheckBox();
            this.iw5ExportButton = new System.Windows.Forms.Button();
            this.iw5MapListBox = new System.Windows.Forms.CheckedListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            zonebuilderGroupBox = new System.Windows.Forms.GroupBox();
            outputBoxGroup = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            zonebuilderGroupBox.SuspendLayout();
            outputBoxGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.inputTabs.SuspendLayout();
            this.iw3TabPage.SuspendLayout();
            this.iw5TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // zonebuilderGroupBox
            // 
            zonebuilderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            zonebuilderGroupBox.Controls.Add(this.buildTeamsCheckbox);
            zonebuilderGroupBox.Controls.Add(this.regenerateZoneSourceButton);
            zonebuilderGroupBox.Controls.Add(this.zbRefreshButton);
            zonebuilderGroupBox.Controls.Add(this.openMapFolderButton);
            zonebuilderGroupBox.Controls.Add(this.editCSVButton);
            zonebuilderGroupBox.Controls.Add(this.editArenaFileButton);
            zonebuilderGroupBox.Controls.Add(this.runMapButton);
            zonebuilderGroupBox.Controls.Add(this.generateIWDButton);
            zonebuilderGroupBox.Controls.Add(this.buildZoneButton);
            zonebuilderGroupBox.Controls.Add(this.iw4ZoneListBox);
            zonebuilderGroupBox.Location = new System.Drawing.Point(382, 27);
            zonebuilderGroupBox.Name = "zonebuilderGroupBox";
            zonebuilderGroupBox.Size = new System.Drawing.Size(360, 305);
            zonebuilderGroupBox.TabIndex = 3;
            zonebuilderGroupBox.TabStop = false;
            zonebuilderGroupBox.Text = "Zones ready to build";
            // 
            // buildTeamsCheckbox
            // 
            this.buildTeamsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buildTeamsCheckbox.AutoSize = true;
            this.buildTeamsCheckbox.Checked = true;
            this.buildTeamsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buildTeamsCheckbox.Location = new System.Drawing.Point(203, 78);
            this.buildTeamsCheckbox.Name = "buildTeamsCheckbox";
            this.buildTeamsCheckbox.Size = new System.Drawing.Size(123, 17);
            this.buildTeamsCheckbox.TabIndex = 12;
            this.buildTeamsCheckbox.Text = "Build teams into map";
            this.buildTeamsCheckbox.UseVisualStyleBackColor = true;
            // 
            // regenerateZoneSourceButton
            // 
            this.regenerateZoneSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regenerateZoneSourceButton.Location = new System.Drawing.Point(203, 180);
            this.regenerateZoneSourceButton.Name = "regenerateZoneSourceButton";
            this.regenerateZoneSourceButton.Size = new System.Drawing.Size(151, 23);
            this.regenerateZoneSourceButton.TabIndex = 9;
            this.regenerateZoneSourceButton.Text = "Regenerate zone source";
            this.regenerateZoneSourceButton.UseVisualStyleBackColor = true;
            this.regenerateZoneSourceButton.Click += new System.EventHandler(this.regenerateZoneSourceButton_Click);
            // 
            // zbRefreshButton
            // 
            this.zbRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zbRefreshButton.Location = new System.Drawing.Point(173, 16);
            this.zbRefreshButton.Name = "zbRefreshButton";
            this.zbRefreshButton.Size = new System.Drawing.Size(24, 24);
            this.zbRefreshButton.TabIndex = 8;
            this.zbRefreshButton.Text = "🔄";
            this.zbRefreshButton.UseVisualStyleBackColor = true;
            this.zbRefreshButton.Click += new System.EventHandler(this.zbRefreshButton_Click);
            // 
            // openMapFolderButton
            // 
            this.openMapFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openMapFolderButton.Location = new System.Drawing.Point(203, 209);
            this.openMapFolderButton.Name = "openMapFolderButton";
            this.openMapFolderButton.Size = new System.Drawing.Size(151, 23);
            this.openMapFolderButton.TabIndex = 6;
            this.openMapFolderButton.Text = "📁 Open map folders";
            this.openMapFolderButton.UseVisualStyleBackColor = true;
            this.openMapFolderButton.Click += new System.EventHandler(this.openMapFolderButton_Click);
            // 
            // editCSVButton
            // 
            this.editCSVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editCSVButton.Location = new System.Drawing.Point(203, 267);
            this.editCSVButton.Name = "editCSVButton";
            this.editCSVButton.Size = new System.Drawing.Size(151, 23);
            this.editCSVButton.TabIndex = 5;
            this.editCSVButton.Text = "📝 Edit zone source";
            this.editCSVButton.UseVisualStyleBackColor = true;
            this.editCSVButton.Click += new System.EventHandler(this.editCSVButton_Click);
            // 
            // editArenaFileButton
            // 
            this.editArenaFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editArenaFileButton.Location = new System.Drawing.Point(203, 238);
            this.editArenaFileButton.Name = "editArenaFileButton";
            this.editArenaFileButton.Size = new System.Drawing.Size(151, 23);
            this.editArenaFileButton.TabIndex = 4;
            this.editArenaFileButton.Text = "📝 Edit arena file";
            this.editArenaFileButton.UseVisualStyleBackColor = true;
            this.editArenaFileButton.Click += new System.EventHandler(this.editArenaFileButton_Click);
            // 
            // runMapButton
            // 
            this.runMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runMapButton.Location = new System.Drawing.Point(203, 122);
            this.runMapButton.Name = "runMapButton";
            this.runMapButton.Size = new System.Drawing.Size(151, 23);
            this.runMapButton.TabIndex = 3;
            this.runMapButton.Text = "▶ Run map";
            this.runMapButton.UseVisualStyleBackColor = true;
            this.runMapButton.Click += new System.EventHandler(this.runMapButton_Click);
            // 
            // generateIWDButton
            // 
            this.generateIWDButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateIWDButton.Location = new System.Drawing.Point(203, 151);
            this.generateIWDButton.Name = "generateIWDButton";
            this.generateIWDButton.Size = new System.Drawing.Size(151, 23);
            this.generateIWDButton.TabIndex = 2;
            this.generateIWDButton.Text = "Generate IWD";
            this.generateIWDButton.UseVisualStyleBackColor = true;
            this.generateIWDButton.Click += new System.EventHandler(this.generateIWDButton_Click);
            // 
            // buildZoneButton
            // 
            this.buildZoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buildZoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildZoneButton.Location = new System.Drawing.Point(203, 16);
            this.buildZoneButton.Name = "buildZoneButton";
            this.buildZoneButton.Size = new System.Drawing.Size(151, 53);
            this.buildZoneButton.TabIndex = 1;
            this.buildZoneButton.Text = "🧱 Build zone";
            this.buildZoneButton.UseVisualStyleBackColor = true;
            this.buildZoneButton.Click += new System.EventHandler(this.buildZoneButton_Click);
            // 
            // iw4ZoneListBox
            // 
            this.iw4ZoneListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iw4ZoneListBox.CheckOnClick = true;
            this.iw4ZoneListBox.FormattingEnabled = true;
            this.iw4ZoneListBox.Location = new System.Drawing.Point(3, 16);
            this.iw4ZoneListBox.Name = "iw4ZoneListBox";
            this.iw4ZoneListBox.Size = new System.Drawing.Size(194, 274);
            this.iw4ZoneListBox.TabIndex = 0;
            // 
            // outputBoxGroup
            // 
            outputBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            outputBoxGroup.Controls.Add(this.outputTextBox);
            outputBoxGroup.Location = new System.Drawing.Point(12, 338);
            outputBoxGroup.Name = "outputBoxGroup";
            outputBoxGroup.Size = new System.Drawing.Size(730, 181);
            outputBoxGroup.TabIndex = 5;
            outputBoxGroup.TabStop = false;
            outputBoxGroup.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.outputTextBox.Location = new System.Drawing.Point(3, 16);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(724, 162);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.Text = "Test text\r\nProgram terminated with output 0.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(205, 227);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 13);
            label1.TabIndex = 25;
            label1.Text = "Incompatible static models:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getHelpOnlineToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(24, 20);
            this.toolStrip.Text = "?";
            // 
            // getHelpOnlineToolStripMenuItem
            // 
            this.getHelpOnlineToolStripMenuItem.Name = "getHelpOnlineToolStripMenuItem";
            this.getHelpOnlineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.getHelpOnlineToolStripMenuItem.Text = "Get help online...";
            this.getHelpOnlineToolStripMenuItem.Click += new System.EventHandler(this.getHelpOnlineToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // inputTabs
            // 
            this.inputTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputTabs.Controls.Add(this.iw3TabPage);
            this.inputTabs.Controls.Add(this.iw5TabPage);
            this.inputTabs.ImageList = this.imageList1;
            this.inputTabs.Location = new System.Drawing.Point(12, 27);
            this.inputTabs.Name = "inputTabs";
            this.inputTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputTabs.SelectedIndex = 0;
            this.inputTabs.Size = new System.Drawing.Size(367, 305);
            this.inputTabs.TabIndex = 6;
            // 
            // iw3TabPage
            // 
            this.iw3TabPage.BackColor = System.Drawing.Color.Transparent;
            this.iw3TabPage.Controls.Add(this.addCarePackageCheckbox);
            this.iw3TabPage.Controls.Add(this.iw3RefreshButton);
            this.iw3TabPage.Controls.Add(label1);
            this.iw3TabPage.Controls.Add(this.smodelsFixComboBox);
            this.iw3TabPage.Controls.Add(this.includeGenericSoundsCheckbox);
            this.iw3TabPage.Controls.Add(this.replaceExistingFilesCheckbox);
            this.iw3TabPage.Controls.Add(this.correctSpecularsCheckbox);
            this.iw3TabPage.Controls.Add(this.convertGscCheckbox);
            this.iw3TabPage.Controls.Add(this.generateArenaCheckbox);
            this.iw3TabPage.Controls.Add(this.generateSourceCheckbox);
            this.iw3TabPage.Controls.Add(this.iw3ExportButton);
            this.iw3TabPage.Controls.Add(this.iw3MapListBox);
            this.iw3TabPage.ImageKey = "cod4_icon.png";
            this.iw3TabPage.Location = new System.Drawing.Point(4, 31);
            this.iw3TabPage.Name = "iw3TabPage";
            this.iw3TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.iw3TabPage.Size = new System.Drawing.Size(359, 270);
            this.iw3TabPage.TabIndex = 0;
            this.iw3TabPage.Text = "Call of Duty 4";
            this.iw3TabPage.UseVisualStyleBackColor = true;
            // 
            // addCarePackageCheckbox
            // 
            this.addCarePackageCheckbox.AutoSize = true;
            this.addCarePackageCheckbox.Checked = true;
            this.addCarePackageCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addCarePackageCheckbox.Location = new System.Drawing.Point(205, 154);
            this.addCarePackageCheckbox.Name = "addCarePackageCheckbox";
            this.addCarePackageCheckbox.Size = new System.Drawing.Size(119, 17);
            this.addCarePackageCheckbox.TabIndex = 26;
            this.addCarePackageCheckbox.Text = "Add care packages";
            this.addCarePackageCheckbox.UseVisualStyleBackColor = true;
            // 
            // iw3RefreshButton
            // 
            this.iw3RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iw3RefreshButton.Location = new System.Drawing.Point(176, 6);
            this.iw3RefreshButton.Name = "iw3RefreshButton";
            this.iw3RefreshButton.Size = new System.Drawing.Size(24, 24);
            this.iw3RefreshButton.TabIndex = 13;
            this.iw3RefreshButton.Text = "🔄";
            this.iw3RefreshButton.UseVisualStyleBackColor = true;
            this.iw3RefreshButton.Click += new System.EventHandler(this.iw3RefreshButton_Click);
            // 
            // smodelsFixComboBox
            // 
            this.smodelsFixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smodelsFixComboBox.FormattingEnabled = true;
            this.smodelsFixComboBox.Items.AddRange(new object[] {
            "Leave as-is",
            "Delete + move to entities",
            "Swap + move to entities"});
            this.smodelsFixComboBox.Location = new System.Drawing.Point(205, 243);
            this.smodelsFixComboBox.Name = "smodelsFixComboBox";
            this.smodelsFixComboBox.Size = new System.Drawing.Size(148, 21);
            this.smodelsFixComboBox.TabIndex = 24;
            // 
            // includeGenericSoundsCheckbox
            // 
            this.includeGenericSoundsCheckbox.AutoSize = true;
            this.includeGenericSoundsCheckbox.Checked = true;
            this.includeGenericSoundsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeGenericSoundsCheckbox.Location = new System.Drawing.Point(205, 200);
            this.includeGenericSoundsCheckbox.Name = "includeGenericSoundsCheckbox";
            this.includeGenericSoundsCheckbox.Size = new System.Drawing.Size(136, 17);
            this.includeGenericSoundsCheckbox.TabIndex = 23;
            this.includeGenericSoundsCheckbox.Text = "Include generic sounds";
            this.includeGenericSoundsCheckbox.UseVisualStyleBackColor = true;
            // 
            // replaceExistingFilesCheckbox
            // 
            this.replaceExistingFilesCheckbox.AutoSize = true;
            this.replaceExistingFilesCheckbox.Checked = true;
            this.replaceExistingFilesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.replaceExistingFilesCheckbox.Location = new System.Drawing.Point(205, 177);
            this.replaceExistingFilesCheckbox.Name = "replaceExistingFilesCheckbox";
            this.replaceExistingFilesCheckbox.Size = new System.Drawing.Size(134, 17);
            this.replaceExistingFilesCheckbox.TabIndex = 22;
            this.replaceExistingFilesCheckbox.Text = "Replace existing GSCs";
            this.replaceExistingFilesCheckbox.UseVisualStyleBackColor = true;
            // 
            // correctSpecularsCheckbox
            // 
            this.correctSpecularsCheckbox.AutoSize = true;
            this.correctSpecularsCheckbox.Checked = true;
            this.correctSpecularsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.correctSpecularsCheckbox.Location = new System.Drawing.Point(205, 131);
            this.correctSpecularsCheckbox.Name = "correctSpecularsCheckbox";
            this.correctSpecularsCheckbox.Size = new System.Drawing.Size(108, 17);
            this.correctSpecularsCheckbox.TabIndex = 21;
            this.correctSpecularsCheckbox.Text = "Correct speculars";
            this.correctSpecularsCheckbox.UseVisualStyleBackColor = true;
            // 
            // convertGscCheckbox
            // 
            this.convertGscCheckbox.AutoSize = true;
            this.convertGscCheckbox.Checked = true;
            this.convertGscCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.convertGscCheckbox.Location = new System.Drawing.Point(205, 108);
            this.convertGscCheckbox.Name = "convertGscCheckbox";
            this.convertGscCheckbox.Size = new System.Drawing.Size(93, 17);
            this.convertGscCheckbox.TabIndex = 20;
            this.convertGscCheckbox.Text = "Convert GSCs";
            this.convertGscCheckbox.UseVisualStyleBackColor = true;
            // 
            // generateArenaCheckbox
            // 
            this.generateArenaCheckbox.AutoSize = true;
            this.generateArenaCheckbox.Checked = true;
            this.generateArenaCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateArenaCheckbox.Location = new System.Drawing.Point(205, 85);
            this.generateArenaCheckbox.Name = "generateArenaCheckbox";
            this.generateArenaCheckbox.Size = new System.Drawing.Size(116, 17);
            this.generateArenaCheckbox.TabIndex = 19;
            this.generateArenaCheckbox.Text = "Generate arena file";
            this.generateArenaCheckbox.UseVisualStyleBackColor = true;
            // 
            // generateSourceCheckbox
            // 
            this.generateSourceCheckbox.AutoSize = true;
            this.generateSourceCheckbox.Checked = true;
            this.generateSourceCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateSourceCheckbox.Location = new System.Drawing.Point(205, 62);
            this.generateSourceCheckbox.Name = "generateSourceCheckbox";
            this.generateSourceCheckbox.Size = new System.Drawing.Size(131, 17);
            this.generateSourceCheckbox.TabIndex = 18;
            this.generateSourceCheckbox.Text = "Generate zone source";
            this.generateSourceCheckbox.UseVisualStyleBackColor = true;
            // 
            // iw3ExportButton
            // 
            this.iw3ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iw3ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw3ExportButton.Location = new System.Drawing.Point(205, 6);
            this.iw3ExportButton.Name = "iw3ExportButton";
            this.iw3ExportButton.Size = new System.Drawing.Size(148, 50);
            this.iw3ExportButton.TabIndex = 17;
            this.iw3ExportButton.Text = "Export and prepare >>";
            this.iw3ExportButton.UseVisualStyleBackColor = true;
            this.iw3ExportButton.Click += new System.EventHandler(this.iw3ExportButton_Click);
            // 
            // iw3MapListBox
            // 
            this.iw3MapListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iw3MapListBox.CheckOnClick = true;
            this.iw3MapListBox.FormattingEnabled = true;
            this.iw3MapListBox.Location = new System.Drawing.Point(6, 6);
            this.iw3MapListBox.Name = "iw3MapListBox";
            this.iw3MapListBox.Size = new System.Drawing.Size(194, 259);
            this.iw3MapListBox.TabIndex = 16;
            this.iw3MapListBox.ThreeDCheckBoxes = true;
            // 
            // iw5TabPage
            // 
            this.iw5TabPage.BackColor = System.Drawing.Color.Transparent;
            this.iw5TabPage.Controls.Add(this.iw5RefreshButton);
            this.iw5TabPage.Controls.Add(this.iw5GenerateArena);
            this.iw5TabPage.Controls.Add(this.iw5OverwriteSource);
            this.iw5TabPage.Controls.Add(this.iw5ExportButton);
            this.iw5TabPage.Controls.Add(this.iw5MapListBox);
            this.iw5TabPage.ImageKey = "mw3_icon.png";
            this.iw5TabPage.Location = new System.Drawing.Point(4, 31);
            this.iw5TabPage.Name = "iw5TabPage";
            this.iw5TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.iw5TabPage.Size = new System.Drawing.Size(359, 270);
            this.iw5TabPage.TabIndex = 1;
            this.iw5TabPage.Text = "Modern Warfare 3";
            this.iw5TabPage.UseVisualStyleBackColor = true;
            // 
            // iw5RefreshButton
            // 
            this.iw5RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iw5RefreshButton.Location = new System.Drawing.Point(176, 6);
            this.iw5RefreshButton.Name = "iw5RefreshButton";
            this.iw5RefreshButton.Size = new System.Drawing.Size(24, 24);
            this.iw5RefreshButton.TabIndex = 24;
            this.iw5RefreshButton.Text = "🔄";
            this.iw5RefreshButton.UseVisualStyleBackColor = true;
            this.iw5RefreshButton.Click += new System.EventHandler(this.iw5RefreshButton_Click);
            // 
            // iw5GenerateArena
            // 
            this.iw5GenerateArena.AutoSize = true;
            this.iw5GenerateArena.Checked = true;
            this.iw5GenerateArena.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iw5GenerateArena.Location = new System.Drawing.Point(205, 89);
            this.iw5GenerateArena.Name = "iw5GenerateArena";
            this.iw5GenerateArena.Size = new System.Drawing.Size(116, 17);
            this.iw5GenerateArena.TabIndex = 23;
            this.iw5GenerateArena.Text = "Generate arena file";
            this.iw5GenerateArena.UseVisualStyleBackColor = true;
            // 
            // iw5OverwriteSource
            // 
            this.iw5OverwriteSource.AutoSize = true;
            this.iw5OverwriteSource.Checked = true;
            this.iw5OverwriteSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iw5OverwriteSource.Location = new System.Drawing.Point(205, 66);
            this.iw5OverwriteSource.Name = "iw5OverwriteSource";
            this.iw5OverwriteSource.Size = new System.Drawing.Size(132, 17);
            this.iw5OverwriteSource.TabIndex = 22;
            this.iw5OverwriteSource.Text = "Overwrite zone source";
            this.iw5OverwriteSource.UseVisualStyleBackColor = true;
            // 
            // iw5ExportButton
            // 
            this.iw5ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iw5ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw5ExportButton.Location = new System.Drawing.Point(205, 6);
            this.iw5ExportButton.Name = "iw5ExportButton";
            this.iw5ExportButton.Size = new System.Drawing.Size(148, 50);
            this.iw5ExportButton.TabIndex = 21;
            this.iw5ExportButton.Text = "Export and prepare >>";
            this.iw5ExportButton.UseVisualStyleBackColor = true;
            this.iw5ExportButton.Click += new System.EventHandler(this.iw5ExportButton_Click);
            // 
            // iw5MapListBox
            // 
            this.iw5MapListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iw5MapListBox.CheckOnClick = true;
            this.iw5MapListBox.FormattingEnabled = true;
            this.iw5MapListBox.Location = new System.Drawing.Point(6, 6);
            this.iw5MapListBox.Name = "iw5MapListBox";
            this.iw5MapListBox.Size = new System.Drawing.Size(194, 259);
            this.iw5MapListBox.TabIndex = 20;
            this.iw5MapListBox.ThreeDCheckBoxes = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cod4_icon.png");
            this.imageList1.Images.SetKeyName(1, "mw3_icon.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 531);
            this.Controls.Add(this.inputTabs);
            this.Controls.Add(outputBoxGroup);
            this.Controls.Add(zonebuilderGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "IW4x Map Porting Utility";
            zonebuilderGroupBox.ResumeLayout(false);
            zonebuilderGroupBox.PerformLayout();
            outputBoxGroup.ResumeLayout(false);
            outputBoxGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inputTabs.ResumeLayout(false);
            this.iw3TabPage.ResumeLayout(false);
            this.iw3TabPage.PerformLayout();
            this.iw5TabPage.ResumeLayout(false);
            this.iw5TabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip;
        private System.Windows.Forms.ToolStripMenuItem getHelpOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox iw4ZoneListBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button buildZoneButton;
        private System.Windows.Forms.Button generateIWDButton;
        private System.Windows.Forms.Button runMapButton;
        private System.Windows.Forms.Button editCSVButton;
        private System.Windows.Forms.Button openMapFolderButton;
        private System.Windows.Forms.Button zbRefreshButton;
        private System.Windows.Forms.Button regenerateZoneSourceButton;
        private System.Windows.Forms.CheckBox buildTeamsCheckbox;
        private System.Windows.Forms.Button editArenaFileButton;
        private System.Windows.Forms.TabControl inputTabs;
        private System.Windows.Forms.TabPage iw3TabPage;
        private System.Windows.Forms.ComboBox smodelsFixComboBox;
        private System.Windows.Forms.CheckBox includeGenericSoundsCheckbox;
        private System.Windows.Forms.CheckBox replaceExistingFilesCheckbox;
        private System.Windows.Forms.CheckBox correctSpecularsCheckbox;
        private System.Windows.Forms.CheckBox convertGscCheckbox;
        private System.Windows.Forms.CheckBox generateArenaCheckbox;
        private System.Windows.Forms.CheckBox generateSourceCheckbox;
        private System.Windows.Forms.Button iw3ExportButton;
        private System.Windows.Forms.CheckedListBox iw3MapListBox;
        private System.Windows.Forms.TabPage iw5TabPage;
        private System.Windows.Forms.CheckBox iw5GenerateArena;
        private System.Windows.Forms.CheckBox iw5OverwriteSource;
        private System.Windows.Forms.Button iw5ExportButton;
        private System.Windows.Forms.CheckedListBox iw5MapListBox;
        private System.Windows.Forms.Button iw3RefreshButton;
        private System.Windows.Forms.Button iw5RefreshButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox addCarePackageCheckbox;
    }
}

