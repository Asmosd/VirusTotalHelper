namespace WinFormsApp1
{
    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            linkScanButton = new Button();
            menuStrip = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            foundAnIssueToolStripMenuItem = new ToolStripMenuItem();
            addNewAPIKeyToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            gitHubPageToolStripMenuItem = new ToolStripMenuItem();
            fileAnalyseButton = new Button();
            linkScanLabel = new Label();
            fileAnalyseLabel = new Label();
            linkAnalyseTextBox = new TextBox();
            linkPanel = new Panel();
            reportTextBox = new RichTextBox();
            backButtonLink = new Button();
            apiKeyPanel = new Panel();
            apiKeyPanelButton = new Button();
            apiPanelLabelKey = new Label();
            apiPanelLabel = new Label();
            apiPanelLabelLink = new LinkLabel();
            apiKeyPanelTextBox = new TextBox();
            selectFileDialog = new OpenFileDialog();
            menuStrip.SuspendLayout();
            linkPanel.SuspendLayout();
            apiKeyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // linkScanButton
            // 
            linkScanButton.Location = new Point(12, 80);
            linkScanButton.Name = "linkScanButton";
            linkScanButton.Size = new Size(156, 41);
            linkScanButton.TabIndex = 0;
            linkScanButton.Text = "Link Scanning";
            linkScanButton.UseVisualStyleBackColor = true;
            linkScanButton.Click += linkScanButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(794, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foundAnIssueToolStripMenuItem, addNewAPIKeyToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // foundAnIssueToolStripMenuItem
            // 
            foundAnIssueToolStripMenuItem.Name = "foundAnIssueToolStripMenuItem";
            foundAnIssueToolStripMenuItem.Size = new Size(180, 22);
            foundAnIssueToolStripMenuItem.Text = "Found an Issue?";
            foundAnIssueToolStripMenuItem.Click += foundAnIssueToolStripMenuItem_Click;
            // 
            // addNewAPIKeyToolStripMenuItem
            // 
            addNewAPIKeyToolStripMenuItem.Name = "addNewAPIKeyToolStripMenuItem";
            addNewAPIKeyToolStripMenuItem.Size = new Size(180, 22);
            addNewAPIKeyToolStripMenuItem.Text = "Add new API key";
            addNewAPIKeyToolStripMenuItem.Click += addNewAPIKeyToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gitHubPageToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // gitHubPageToolStripMenuItem
            // 
            gitHubPageToolStripMenuItem.Name = "gitHubPageToolStripMenuItem";
            gitHubPageToolStripMenuItem.Size = new Size(141, 22);
            gitHubPageToolStripMenuItem.Text = "GitHub Page";
            gitHubPageToolStripMenuItem.Click += gitHubPageToolStripMenuItem_Click;
            // 
            // fileAnalyseButton
            // 
            fileAnalyseButton.Location = new Point(12, 271);
            fileAnalyseButton.Name = "fileAnalyseButton";
            fileAnalyseButton.Size = new Size(156, 41);
            fileAnalyseButton.TabIndex = 3;
            fileAnalyseButton.Text = "Analyse File (hash)";
            fileAnalyseButton.UseVisualStyleBackColor = true;
            fileAnalyseButton.Click += fileAnalyseButton_Click;
            // 
            // linkScanLabel
            // 
            linkScanLabel.AutoSize = true;
            linkScanLabel.Location = new Point(12, 139);
            linkScanLabel.Name = "linkScanLabel";
            linkScanLabel.Size = new Size(435, 21);
            linkScanLabel.TabIndex = 4;
            linkScanLabel.Text = "This option allows you to manually input a link to be scanned.\r\n";
            // 
            // fileAnalyseLabel
            // 
            fileAnalyseLabel.AutoSize = true;
            fileAnalyseLabel.Location = new Point(12, 326);
            fileAnalyseLabel.Name = "fileAnalyseLabel";
            fileAnalyseLabel.Size = new Size(512, 21);
            fileAnalyseLabel.TabIndex = 5;
            fileAnalyseLabel.Text = "This option allows you to manually select a file to be scanned by its hash.\r\n";
            // 
            // linkAnalyseTextBox
            // 
            linkAnalyseTextBox.Location = new Point(174, 87);
            linkAnalyseTextBox.Name = "linkAnalyseTextBox";
            linkAnalyseTextBox.PlaceholderText = "Input link here...";
            linkAnalyseTextBox.Size = new Size(608, 29);
            linkAnalyseTextBox.TabIndex = 6;
            // 
            // linkPanel
            // 
            linkPanel.BorderStyle = BorderStyle.FixedSingle;
            linkPanel.Controls.Add(reportTextBox);
            linkPanel.Controls.Add(backButtonLink);
            linkPanel.Dock = DockStyle.Fill;
            linkPanel.Location = new Point(0, 24);
            linkPanel.Name = "linkPanel";
            linkPanel.Size = new Size(794, 445);
            linkPanel.TabIndex = 7;
            linkPanel.Visible = false;
            // 
            // reportTextBox
            // 
            reportTextBox.Location = new Point(11, 3);
            reportTextBox.Name = "reportTextBox";
            reportTextBox.ReadOnly = true;
            reportTextBox.Size = new Size(770, 378);
            reportTextBox.TabIndex = 1;
            reportTextBox.Text = "";
            // 
            // backButtonLink
            // 
            backButtonLink.Location = new Point(11, 394);
            backButtonLink.Name = "backButtonLink";
            backButtonLink.Size = new Size(66, 38);
            backButtonLink.TabIndex = 0;
            backButtonLink.Text = "« Back";
            backButtonLink.TextAlign = ContentAlignment.MiddleLeft;
            backButtonLink.UseVisualStyleBackColor = true;
            backButtonLink.Click += backButtonLink_Click;
            // 
            // apiKeyPanel
            // 
            apiKeyPanel.BorderStyle = BorderStyle.FixedSingle;
            apiKeyPanel.Controls.Add(apiKeyPanelButton);
            apiKeyPanel.Controls.Add(apiPanelLabelKey);
            apiKeyPanel.Controls.Add(apiPanelLabel);
            apiKeyPanel.Controls.Add(apiPanelLabelLink);
            apiKeyPanel.Controls.Add(apiKeyPanelTextBox);
            apiKeyPanel.Dock = DockStyle.Fill;
            apiKeyPanel.Location = new Point(0, 24);
            apiKeyPanel.Name = "apiKeyPanel";
            apiKeyPanel.Size = new Size(794, 445);
            apiKeyPanel.TabIndex = 2;
            apiKeyPanel.Visible = false;
            // 
            // apiKeyPanelButton
            // 
            apiKeyPanelButton.Location = new Point(154, 170);
            apiKeyPanelButton.Name = "apiKeyPanelButton";
            apiKeyPanelButton.Size = new Size(118, 37);
            apiKeyPanelButton.TabIndex = 4;
            apiKeyPanelButton.Text = "Continue";
            apiKeyPanelButton.UseVisualStyleBackColor = true;
            apiKeyPanelButton.Click += apiKeyPanelButton_Click;
            // 
            // apiPanelLabelKey
            // 
            apiPanelLabelKey.AutoSize = true;
            apiPanelLabelKey.Location = new Point(154, 339);
            apiPanelLabelKey.Name = "apiPanelLabelKey";
            apiPanelLabelKey.Size = new Size(168, 42);
            apiPanelLabelKey.TabIndex = 3;
            apiPanelLabelKey.Text = "Don't have an API key?\r\n\r\n";
            // 
            // apiPanelLabel
            // 
            apiPanelLabel.AutoSize = true;
            apiPanelLabel.Location = new Point(154, 111);
            apiPanelLabel.Name = "apiPanelLabel";
            apiPanelLabel.Size = new Size(172, 21);
            apiPanelLabel.TabIndex = 2;
            apiPanelLabel.Text = "Enter here your API key\r\n";
            // 
            // apiPanelLabelLink
            // 
            apiPanelLabelLink.AutoSize = true;
            apiPanelLabelLink.LinkBehavior = LinkBehavior.HoverUnderline;
            apiPanelLabelLink.Location = new Point(154, 381);
            apiPanelLabelLink.Name = "apiPanelLabelLink";
            apiPanelLabelLink.Size = new Size(303, 21);
            apiPanelLabelLink.TabIndex = 1;
            apiPanelLabelLink.TabStop = true;
            apiPanelLabelLink.Text = "Get an API key from the VirusTotal website\r\n";
            apiPanelLabelLink.LinkClicked += apiPanelLabelLink_LinkClicked;
            // 
            // apiKeyPanelTextBox
            // 
            apiKeyPanelTextBox.Location = new Point(154, 135);
            apiKeyPanelTextBox.Name = "apiKeyPanelTextBox";
            apiKeyPanelTextBox.Size = new Size(482, 29);
            apiKeyPanelTextBox.TabIndex = 0;
            // 
            // selectFileDialog
            // 
            selectFileDialog.FileName = "File To Analyse...";
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(794, 469);
            Controls.Add(linkPanel);
            Controls.Add(apiKeyPanel);
            Controls.Add(fileAnalyseLabel);
            Controls.Add(linkScanLabel);
            Controls.Add(fileAnalyseButton);
            Controls.Add(linkScanButton);
            Controls.Add(linkAnalyseTextBox);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Application";
            Text = "Virus Total Helper";
            Load += Application_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            linkPanel.ResumeLayout(false);
            apiKeyPanel.ResumeLayout(false);
            apiKeyPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button linkScanButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem gitHubPageToolStripMenuItem;
        private ToolStripMenuItem foundAnIssueToolStripMenuItem;
        private Button fileAnalyseButton;
        private Label linkScanLabel;
        private Label fileAnalyseLabel;
        private TextBox linkAnalyseTextBox;
        private Panel linkPanel;
        private Button backButtonLink;
        private OpenFileDialog selectFileDialog;
        private Panel apiKeyPanel;
        private TextBox apiKeyPanelTextBox;
        private Label apiPanelLabelKey;
        private Label apiPanelLabel;
        private LinkLabel apiPanelLabelLink;
        private Button apiKeyPanelButton;
        private ToolStripMenuItem addNewAPIKeyToolStripMenuItem;
        private RichTextBox reportTextBox;
    }
}
