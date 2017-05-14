namespace Hoops_Chromium_Edition
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
            this.components = new System.ComponentModel.Container();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.BrowserTabHostPannel = new System.Windows.Forms.Panel();
            this.BrowserTabControl = new System.Windows.Forms.TabControl();
            this.ButtonHostPannel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.NewTabButton = new System.Windows.Forms.Button();
            this.RemoveTabButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.PageSourceEditorButton = new System.Windows.Forms.Button();
            this.URLHostPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.UrlGoButton = new System.Windows.Forms.Button();
            this.MediaSearchItButton = new System.Windows.Forms.Button();
            this.SearchItButton = new System.Windows.Forms.Button();
            this.MediaSearchItBox = new System.Windows.Forms.TextBox();
            this.SearchItBox = new System.Windows.Forms.TextBox();
            this.UpdateUrlBoxOnTabChange = new System.Windows.Forms.Timer(this.components);
            this.UpdateSearchButtonText = new System.Windows.Forms.Timer(this.components);
            this.UpdateMiscSettingsTimer = new System.Windows.Forms.Timer(this.components);
            this.UpdateSiteTitleTimer = new System.Windows.Forms.Timer(this.components);
            this.BackPanel.SuspendLayout();
            this.BrowserTabHostPannel.SuspendLayout();
            this.ButtonHostPannel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.URLHostPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.BrowserTabHostPannel);
            this.BackPanel.Controls.Add(this.ButtonHostPannel);
            this.BackPanel.Controls.Add(this.URLHostPanel);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1101, 541);
            this.BackPanel.TabIndex = 0;
            // 
            // BrowserTabHostPannel
            // 
            this.BrowserTabHostPannel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BrowserTabHostPannel.Controls.Add(this.BrowserTabControl);
            this.BrowserTabHostPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserTabHostPannel.Location = new System.Drawing.Point(0, 58);
            this.BrowserTabHostPannel.Name = "BrowserTabHostPannel";
            this.BrowserTabHostPannel.Size = new System.Drawing.Size(1026, 483);
            this.BrowserTabHostPannel.TabIndex = 2;
            // 
            // BrowserTabControl
            // 
            this.BrowserTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserTabControl.Location = new System.Drawing.Point(0, 0);
            this.BrowserTabControl.Name = "BrowserTabControl";
            this.BrowserTabControl.SelectedIndex = 0;
            this.BrowserTabControl.Size = new System.Drawing.Size(1026, 483);
            this.BrowserTabControl.TabIndex = 0;
            // 
            // ButtonHostPannel
            // 
            this.ButtonHostPannel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonHostPannel.Controls.Add(this.tableLayoutPanel1);
            this.ButtonHostPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonHostPannel.Location = new System.Drawing.Point(1026, 58);
            this.ButtonHostPannel.Name = "ButtonHostPannel";
            this.ButtonHostPannel.Size = new System.Drawing.Size(75, 483);
            this.ButtonHostPannel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.HomeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RefreshButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NewTabButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RemoveTabButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ForwardButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BackButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SettingsButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.PageSourceEditorButton, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(75, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeButton.Location = new System.Drawing.Point(3, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(69, 24);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshButton.Location = new System.Drawing.Point(3, 33);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(69, 24);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // NewTabButton
            // 
            this.NewTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewTabButton.Location = new System.Drawing.Point(3, 63);
            this.NewTabButton.Name = "NewTabButton";
            this.NewTabButton.Size = new System.Drawing.Size(69, 24);
            this.NewTabButton.TabIndex = 2;
            this.NewTabButton.Text = "New Tab";
            this.NewTabButton.UseVisualStyleBackColor = true;
            this.NewTabButton.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // RemoveTabButton
            // 
            this.RemoveTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveTabButton.Location = new System.Drawing.Point(3, 93);
            this.RemoveTabButton.Name = "RemoveTabButton";
            this.RemoveTabButton.Size = new System.Drawing.Size(69, 24);
            this.RemoveTabButton.TabIndex = 3;
            this.RemoveTabButton.Text = "Remove Tab";
            this.RemoveTabButton.UseVisualStyleBackColor = true;
            this.RemoveTabButton.Click += new System.EventHandler(this.RemoveTabButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForwardButton.Location = new System.Drawing.Point(3, 123);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(69, 24);
            this.ForwardButton.TabIndex = 4;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Location = new System.Drawing.Point(3, 153);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(69, 24);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Location = new System.Drawing.Point(3, 183);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(69, 24);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PageSourceEditorButton
            // 
            this.PageSourceEditorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageSourceEditorButton.Location = new System.Drawing.Point(3, 213);
            this.PageSourceEditorButton.Name = "PageSourceEditorButton";
            this.PageSourceEditorButton.Size = new System.Drawing.Size(69, 24);
            this.PageSourceEditorButton.TabIndex = 7;
            this.PageSourceEditorButton.Text = "Source";
            this.PageSourceEditorButton.UseVisualStyleBackColor = true;
            this.PageSourceEditorButton.Click += new System.EventHandler(this.PageSourceEditorButton_Click);
            // 
            // URLHostPanel
            // 
            this.URLHostPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.URLHostPanel.Controls.Add(this.tableLayoutPanel2);
            this.URLHostPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.URLHostPanel.Location = new System.Drawing.Point(0, 0);
            this.URLHostPanel.Name = "URLHostPanel";
            this.URLHostPanel.Size = new System.Drawing.Size(1101, 58);
            this.URLHostPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.UrlBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.UrlGoButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.MediaSearchItButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.SearchItButton, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.MediaSearchItBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.SearchItBox, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1101, 58);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // UrlBox
            // 
            this.UrlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlBox.Location = new System.Drawing.Point(3, 17);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(281, 20);
            this.UrlBox.TabIndex = 0;
            this.UrlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlBox_KeyDown);
            // 
            // UrlGoButton
            // 
            this.UrlGoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlGoButton.Location = new System.Drawing.Point(290, 17);
            this.UrlGoButton.Name = "UrlGoButton";
            this.UrlGoButton.Size = new System.Drawing.Size(74, 24);
            this.UrlGoButton.TabIndex = 1;
            this.UrlGoButton.Text = "Go to URL";
            this.UrlGoButton.UseVisualStyleBackColor = true;
            this.UrlGoButton.Click += new System.EventHandler(this.UrlGoButton_Click);
            // 
            // MediaSearchItButton
            // 
            this.MediaSearchItButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaSearchItButton.Location = new System.Drawing.Point(657, 17);
            this.MediaSearchItButton.Name = "MediaSearchItButton";
            this.MediaSearchItButton.Size = new System.Drawing.Size(74, 24);
            this.MediaSearchItButton.TabIndex = 2;
            this.MediaSearchItButton.Text = "button1";
            this.MediaSearchItButton.UseVisualStyleBackColor = true;
            this.MediaSearchItButton.Click += new System.EventHandler(this.MediaSearchItButton_Click);
            // 
            // SearchItButton
            // 
            this.SearchItButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchItButton.Location = new System.Drawing.Point(1024, 17);
            this.SearchItButton.Name = "SearchItButton";
            this.SearchItButton.Size = new System.Drawing.Size(74, 24);
            this.SearchItButton.TabIndex = 3;
            this.SearchItButton.Text = "button2";
            this.SearchItButton.UseVisualStyleBackColor = true;
            this.SearchItButton.Click += new System.EventHandler(this.SearchItButton_Click);
            // 
            // MediaSearchItBox
            // 
            this.MediaSearchItBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaSearchItBox.Location = new System.Drawing.Point(370, 17);
            this.MediaSearchItBox.Name = "MediaSearchItBox";
            this.MediaSearchItBox.Size = new System.Drawing.Size(281, 20);
            this.MediaSearchItBox.TabIndex = 4;
            this.MediaSearchItBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MediaSearchItBox_KeyDown);
            // 
            // SearchItBox
            // 
            this.SearchItBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchItBox.Location = new System.Drawing.Point(737, 17);
            this.SearchItBox.Name = "SearchItBox";
            this.SearchItBox.Size = new System.Drawing.Size(281, 20);
            this.SearchItBox.TabIndex = 5;
            this.SearchItBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchItBox_KeyDown);
            // 
            // UpdateUrlBoxOnTabChange
            // 
            this.UpdateUrlBoxOnTabChange.Enabled = true;
            this.UpdateUrlBoxOnTabChange.Interval = 1;
            this.UpdateUrlBoxOnTabChange.Tick += new System.EventHandler(this.UpdateUrlBoxOnTabChange_Tick);
            // 
            // UpdateSearchButtonText
            // 
            this.UpdateSearchButtonText.Enabled = true;
            this.UpdateSearchButtonText.Interval = 1;
            this.UpdateSearchButtonText.Tick += new System.EventHandler(this.UpdateSearchButtonText_Tick);
            // 
            // UpdateMiscSettingsTimer
            // 
            this.UpdateMiscSettingsTimer.Enabled = true;
            this.UpdateMiscSettingsTimer.Interval = 1;
            this.UpdateMiscSettingsTimer.Tick += new System.EventHandler(this.UpdateMiscSettingsTimer_Tick);
            // 
            // UpdateSiteTitleTimer
            // 
            this.UpdateSiteTitleTimer.Enabled = true;
            this.UpdateSiteTitleTimer.Interval = 1;
            this.UpdateSiteTitleTimer.Tick += new System.EventHandler(this.UpdateSiteTitleTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 541);
            this.Controls.Add(this.BackPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackPanel.ResumeLayout(false);
            this.BrowserTabHostPannel.ResumeLayout(false);
            this.ButtonHostPannel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.URLHostPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Panel BrowserTabHostPannel;
        private System.Windows.Forms.TabControl BrowserTabControl;
        private System.Windows.Forms.Panel ButtonHostPannel;
        private System.Windows.Forms.Panel URLHostPanel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Button UrlGoButton;
        private System.Windows.Forms.Button NewTabButton;
        private System.Windows.Forms.Button RemoveTabButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Timer UpdateUrlBoxOnTabChange;
        private System.Windows.Forms.Button MediaSearchItButton;
        private System.Windows.Forms.Button SearchItButton;
        private System.Windows.Forms.TextBox MediaSearchItBox;
        private System.Windows.Forms.TextBox SearchItBox;
        private System.Windows.Forms.Button PageSourceEditorButton;
        private System.Windows.Forms.Timer UpdateSearchButtonText;
        private System.Windows.Forms.Timer UpdateMiscSettingsTimer;
        private System.Windows.Forms.Timer UpdateSiteTitleTimer;
    }
}

