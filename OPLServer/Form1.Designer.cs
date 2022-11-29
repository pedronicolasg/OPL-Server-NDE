namespace OPLServer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstvwLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbToTray = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEnableLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLogFilter = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbLogInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogWarn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogError = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogCritical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogTrace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogVerbose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAutoScroll = new System.Windows.Forms.ToolStripButton();
            this.tsbServerState = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClearLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSelectFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbPort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.trv_files = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvwLog
            // 
            this.lstvwLog.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstvwLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvwLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.lstvwLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstvwLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvwLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstvwLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvwLog.HideSelection = false;
            this.lstvwLog.Location = new System.Drawing.Point(222, 24);
            this.lstvwLog.Name = "lstvwLog";
            this.lstvwLog.Size = new System.Drawing.Size(815, 314);
            this.lstvwLog.TabIndex = 2;
            this.lstvwLog.UseCompatibleStateImageBehavior = false;
            this.lstvwLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tempo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Evento";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fonte";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mensagem";
            this.columnHeader4.Width = 66;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbToTray,
            this.toolStripSeparator6,
            this.tsbEnableLog,
            this.toolStripSeparator2,
            this.tsbLogFilter,
            this.toolStripSeparator1,
            this.tsbAutoScroll,
            this.tsbServerState,
            this.toolStripSeparator3,
            this.tsbClearLog,
            this.toolStripSeparator4,
            this.tsbSelectFolder,
            this.toolStripSeparator7,
            this.tsbAbout,
            this.toolStripSeparator5,
            this.tstbPort,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbToTray
            // 
            this.tsbToTray.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbToTray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbToTray.Image = ((System.Drawing.Image)(resources.GetObject("tsbToTray.Image")));
            this.tsbToTray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToTray.Name = "tsbToTray";
            this.tsbToTray.Size = new System.Drawing.Size(23, 22);
            this.tsbToTray.Text = "Minimize to System Tray";
            this.tsbToTray.ToolTipText = "Minimize to System Tray";
            this.tsbToTray.Click += new System.EventHandler(this.tsbToTray_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEnableLog
            // 
            this.tsbEnableLog.Checked = true;
            this.tsbEnableLog.CheckOnClick = true;
            this.tsbEnableLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbEnableLog.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbEnableLog.Image = global::OPLServer.Properties.Resources.logicon;
            this.tsbEnableLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEnableLog.Name = "tsbEnableLog";
            this.tsbEnableLog.Size = new System.Drawing.Size(81, 22);
            this.tsbEnableLog.Text = "Ativar Log";
            this.tsbEnableLog.CheckedChanged += new System.EventHandler(this.tsbEnableLog_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLogFilter
            // 
            this.tsbLogFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogInfo,
            this.tsbLogWarn,
            this.tsbLogError,
            this.tsbLogCritical,
            this.tsbLogTrace,
            this.tsbLogDebug,
            this.tsbLogVerbose});
            this.tsbLogFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbLogFilter.Image = global::OPLServer.Properties.Resources.filter;
            this.tsbLogFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogFilter.Name = "tsbLogFilter";
            this.tsbLogFilter.Size = new System.Drawing.Size(106, 22);
            this.tsbLogFilter.Text = "Filtro do Log";
            // 
            // tsbLogInfo
            // 
            this.tsbLogInfo.Checked = true;
            this.tsbLogInfo.CheckOnClick = true;
            this.tsbLogInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbLogInfo.Name = "tsbLogInfo";
            this.tsbLogInfo.Size = new System.Drawing.Size(135, 22);
            this.tsbLogInfo.Text = "Informação";
            this.tsbLogInfo.CheckedChanged += new System.EventHandler(this.tsbLogInfo_CheckedChanged);
            // 
            // tsbLogWarn
            // 
            this.tsbLogWarn.Checked = true;
            this.tsbLogWarn.CheckOnClick = true;
            this.tsbLogWarn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbLogWarn.Name = "tsbLogWarn";
            this.tsbLogWarn.Size = new System.Drawing.Size(135, 22);
            this.tsbLogWarn.Text = "Aviso";
            this.tsbLogWarn.CheckedChanged += new System.EventHandler(this.tsbLogWarn_CheckedChanged);
            // 
            // tsbLogError
            // 
            this.tsbLogError.Checked = true;
            this.tsbLogError.CheckOnClick = true;
            this.tsbLogError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbLogError.Name = "tsbLogError";
            this.tsbLogError.Size = new System.Drawing.Size(135, 22);
            this.tsbLogError.Text = "Erro";
            this.tsbLogError.CheckedChanged += new System.EventHandler(this.tsbLogError_CheckedChanged);
            // 
            // tsbLogCritical
            // 
            this.tsbLogCritical.Checked = true;
            this.tsbLogCritical.CheckOnClick = true;
            this.tsbLogCritical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbLogCritical.Name = "tsbLogCritical";
            this.tsbLogCritical.Size = new System.Drawing.Size(135, 22);
            this.tsbLogCritical.Text = "Crítico";
            this.tsbLogCritical.CheckedChanged += new System.EventHandler(this.tsbLogCritical_CheckedChanged);
            // 
            // tsbLogTrace
            // 
            this.tsbLogTrace.Checked = true;
            this.tsbLogTrace.CheckOnClick = true;
            this.tsbLogTrace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbLogTrace.Name = "tsbLogTrace";
            this.tsbLogTrace.Size = new System.Drawing.Size(135, 22);
            this.tsbLogTrace.Text = "Rastro";
            this.tsbLogTrace.CheckedChanged += new System.EventHandler(this.tsbLogTrace_CheckedChanged);
            // 
            // tsbLogDebug
            // 
            this.tsbLogDebug.CheckOnClick = true;
            this.tsbLogDebug.Name = "tsbLogDebug";
            this.tsbLogDebug.Size = new System.Drawing.Size(135, 22);
            this.tsbLogDebug.Text = "Debug";
            this.tsbLogDebug.CheckedChanged += new System.EventHandler(this.tsbLogDebug_CheckedChanged);
            // 
            // tsbLogVerbose
            // 
            this.tsbLogVerbose.CheckOnClick = true;
            this.tsbLogVerbose.Name = "tsbLogVerbose";
            this.tsbLogVerbose.Size = new System.Drawing.Size(135, 22);
            this.tsbLogVerbose.Text = "Detalhado";
            this.tsbLogVerbose.CheckedChanged += new System.EventHandler(this.tsbLogVerbose_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAutoScroll
            // 
            this.tsbAutoScroll.CheckOnClick = true;
            this.tsbAutoScroll.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbAutoScroll.Image = global::OPLServer.Properties.Resources.scrolldown;
            this.tsbAutoScroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAutoScroll.Name = "tsbAutoScroll";
            this.tsbAutoScroll.Size = new System.Drawing.Size(110, 22);
            this.tsbAutoScroll.Text = "Log Auto-Scroll";
            this.tsbAutoScroll.CheckStateChanged += new System.EventHandler(this.tsbAutoScroll_CheckStateChanged);
            // 
            // tsbServerState
            // 
            this.tsbServerState.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbServerState.CheckOnClick = true;
            this.tsbServerState.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbServerState.Image = global::OPLServer.Properties.Resources.start;
            this.tsbServerState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServerState.Name = "tsbServerState";
            this.tsbServerState.Size = new System.Drawing.Size(267, 22);
            this.tsbServerState.Text = "O servidor está parado (pressione para iniciar)";
            this.tsbServerState.CheckedChanged += new System.EventHandler(this.tsbServerState_CheckedChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClearLog
            // 
            this.tsbClearLog.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbClearLog.Image = global::OPLServer.Properties.Resources.clear;
            this.tsbClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearLog.Name = "tsbClearLog";
            this.tsbClearLog.Size = new System.Drawing.Size(87, 22);
            this.tsbClearLog.Text = "Limpar Log";
            this.tsbClearLog.Click += new System.EventHandler(this.tsbClearLog_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSelectFolder
            // 
            this.tsbSelectFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbSelectFolder.Image = global::OPLServer.Properties.Resources.folder;
            this.tsbSelectFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectFolder.Name = "tsbSelectFolder";
            this.tsbSelectFolder.Size = new System.Drawing.Size(112, 22);
            this.tsbSelectFolder.Text = "Selecionar pasta";
            this.tsbSelectFolder.Click += new System.EventHandler(this.tsbSelectFolder_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(41, 22);
            this.tsbAbout.Text = "Sobre";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tstbPort
            // 
            this.tstbPort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.tstbPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstbPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbPort.ForeColor = System.Drawing.SystemColors.Window;
            this.tstbPort.Name = "tstbPort";
            this.tstbPort.Size = new System.Drawing.Size(40, 25);
            this.tstbPort.Text = "1024";
            this.tstbPort.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstbPort.ToolTipText = "Server Port";
            this.tstbPort.Leave += new System.EventHandler(this.tstbPort_Leave);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "Porta:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipTitle = "OPL Server NDE";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "OPL Server NDE";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(989, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // trv_files
            // 
            this.trv_files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trv_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.trv_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trv_files.ForeColor = System.Drawing.SystemColors.Window;
            this.trv_files.LineColor = System.Drawing.Color.White;
            this.trv_files.Location = new System.Drawing.Point(1, 24);
            this.trv_files.Name = "trv_files";
            this.trv_files.Size = new System.Drawing.Size(221, 314);
            this.trv_files.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(989, 361);
            this.Controls.Add(this.trv_files);
            this.Controls.Add(this.lstvwLog);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1005, 400);
            this.Name = "Form1";
            this.Text = "OPL Server (Nícolas DEV Edition)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAutoScroll;
        private System.Windows.Forms.ToolStripSplitButton tsbLogFilter;
        private System.Windows.Forms.ToolStripMenuItem tsbLogInfo;
        private System.Windows.Forms.ToolStripMenuItem tsbLogWarn;
        private System.Windows.Forms.ToolStripMenuItem tsbLogError;
        private System.Windows.Forms.ToolStripMenuItem tsbLogCritical;
        private System.Windows.Forms.ToolStripMenuItem tsbLogTrace;
        private System.Windows.Forms.ToolStripMenuItem tsbLogDebug;
        private System.Windows.Forms.ToolStripMenuItem tsbLogVerbose;
        private System.Windows.Forms.ToolStripButton tsbServerState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEnableLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbClearLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tstbPort;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton tsbToTray;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbSelectFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.TreeView trv_files;
    }
}

