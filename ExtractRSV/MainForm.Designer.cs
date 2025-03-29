namespace ExtractRSV
{
    partial class MainForm
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
            gbLogConfig = new GroupBox();
            btnBrowseLog = new Button();
            lblLogFile = new Label();
            tbLog = new TextBox();
            gbRSVViewer = new GroupBox();
            lvRSVPairs = new ListView();
            btnSave = new Button();
            ofdLog = new OpenFileDialog();
            sfdRSVs = new SaveFileDialog();
            Key = new ColumnHeader();
            Value = new ColumnHeader();
            gbLogConfig.SuspendLayout();
            gbRSVViewer.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogConfig
            // 
            gbLogConfig.Controls.Add(btnBrowseLog);
            gbLogConfig.Controls.Add(lblLogFile);
            gbLogConfig.Controls.Add(tbLog);
            gbLogConfig.Location = new Point(12, 12);
            gbLogConfig.Name = "gbLogConfig";
            gbLogConfig.Size = new Size(560, 61);
            gbLogConfig.TabIndex = 0;
            gbLogConfig.TabStop = false;
            gbLogConfig.Text = "Configuration";
            // 
            // btnBrowseLog
            // 
            btnBrowseLog.Location = new Point(479, 22);
            btnBrowseLog.Name = "btnBrowseLog";
            btnBrowseLog.Size = new Size(75, 23);
            btnBrowseLog.TabIndex = 2;
            btnBrowseLog.Text = "Browse";
            btnBrowseLog.UseVisualStyleBackColor = true;
            btnBrowseLog.Click += btnBrowseLog_Click;
            // 
            // lblLogFile
            // 
            lblLogFile.AutoSize = true;
            lblLogFile.Location = new Point(6, 26);
            lblLogFile.Name = "lblLogFile";
            lblLogFile.Size = new Size(30, 15);
            lblLogFile.TabIndex = 1;
            lblLogFile.Text = "Log:";
            // 
            // tbLog
            // 
            tbLog.Location = new Point(50, 22);
            tbLog.Name = "tbLog";
            tbLog.ReadOnly = true;
            tbLog.Size = new Size(423, 23);
            tbLog.TabIndex = 0;
            // 
            // gbRSVViewer
            // 
            gbRSVViewer.Controls.Add(lvRSVPairs);
            gbRSVViewer.Location = new Point(12, 79);
            gbRSVViewer.Name = "gbRSVViewer";
            gbRSVViewer.Size = new Size(560, 422);
            gbRSVViewer.TabIndex = 1;
            gbRSVViewer.TabStop = false;
            gbRSVViewer.Text = "RSV Viewer";
            // 
            // lvRSVPairs
            // 
            lvRSVPairs.Columns.AddRange(new ColumnHeader[] { Key, Value });
            lvRSVPairs.FullRowSelect = true;
            lvRSVPairs.Location = new Point(6, 22);
            lvRSVPairs.Name = "lvRSVPairs";
            lvRSVPairs.Size = new Size(548, 394);
            lvRSVPairs.TabIndex = 0;
            lvRSVPairs.UseCompatibleStateImageBehavior = false;
            lvRSVPairs.View = View.Details;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 507);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(560, 42);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ofdLog
            // 
            ofdLog.Filter = "ACT Network Logs|*.log|All files|*.*";
            // 
            // sfdRSVs
            // 
            sfdRSVs.Filter = "JSON files|*.json|All files|*.*";
            // 
            // Key
            // 
            Key.Text = "Key";
            Key.Width = 200;
            // 
            // Value
            // 
            Value.Text = "Value";
            Value.Width = 400;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(btnSave);
            Controls.Add(gbRSVViewer);
            Controls.Add(gbLogConfig);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Extract RSV";
            gbLogConfig.ResumeLayout(false);
            gbLogConfig.PerformLayout();
            gbRSVViewer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLogConfig;
        private Button btnBrowseLog;
        private Label lblLogFile;
        private TextBox tbLog;
        private GroupBox gbRSVViewer;
        private Button btnSave;
        private OpenFileDialog ofdLog;
        private SaveFileDialog sfdRSVs;
        private ListView lvRSVPairs;
        private ColumnHeader Key;
        private ColumnHeader Value;
    }
}
