namespace ncmdump.App {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bt_refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_ifDoDelete = new System.Windows.Forms.CheckBox();
            this.bt_conversion = new System.Windows.Forms.Button();
            this.lb_ncms = new System.Windows.Forms.ListBox();
            this.bt_refresh_advance = new System.Windows.Forms.Button();
            this.selectFolder_bt = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.label_text = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(458, 2);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(156, 22);
            this.bt_refresh.TabIndex = 4;
            this.bt_refresh.Text = "查找【仅当前文件夹】";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cb_ifDoDelete, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_conversion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_ncms, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 313);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cb_ifDoDelete
            // 
            this.cb_ifDoDelete.AutoSize = true;
            this.cb_ifDoDelete.Checked = true;
            this.cb_ifDoDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ifDoDelete.Location = new System.Drawing.Point(2, 263);
            this.cb_ifDoDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ifDoDelete.Name = "cb_ifDoDelete";
            this.cb_ifDoDelete.Size = new System.Drawing.Size(186, 16);
            this.cb_ifDoDelete.TabIndex = 6;
            this.cb_ifDoDelete.Text = "转换完成后删除原文件（NCM）";
            this.cb_ifDoDelete.UseVisualStyleBackColor = true;
            // 
            // bt_conversion
            // 
            this.bt_conversion.Location = new System.Drawing.Point(2, 283);
            this.bt_conversion.Margin = new System.Windows.Forms.Padding(2);
            this.bt_conversion.Name = "bt_conversion";
            this.bt_conversion.Size = new System.Drawing.Size(168, 21);
            this.bt_conversion.TabIndex = 7;
            this.bt_conversion.Text = "开始转换";
            this.bt_conversion.UseVisualStyleBackColor = true;
            this.bt_conversion.Click += new System.EventHandler(this.bt_conversion_Click_1);
            // 
            // lb_ncms
            // 
            this.lb_ncms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ncms.FormattingEnabled = true;
            this.lb_ncms.ItemHeight = 12;
            this.lb_ncms.Location = new System.Drawing.Point(2, 2);
            this.lb_ncms.Margin = new System.Windows.Forms.Padding(2);
            this.lb_ncms.Name = "lb_ncms";
            this.lb_ncms.Size = new System.Drawing.Size(621, 257);
            this.lb_ncms.TabIndex = 3;
            this.lb_ncms.SelectedIndexChanged += new System.EventHandler(this.lb_ncms_SelectedIndexChanged);
            // 
            // bt_refresh_advance
            // 
            this.bt_refresh_advance.Location = new System.Drawing.Point(458, 25);
            this.bt_refresh_advance.Margin = new System.Windows.Forms.Padding(2);
            this.bt_refresh_advance.Name = "bt_refresh_advance";
            this.bt_refresh_advance.Size = new System.Drawing.Size(156, 21);
            this.bt_refresh_advance.TabIndex = 4;
            this.bt_refresh_advance.Text = "查找【包含子文件夹】";
            this.bt_refresh_advance.UseVisualStyleBackColor = true;
            this.bt_refresh_advance.Click += new System.EventHandler(this.findAllNcmsInTheChildFoldersToolStripMenuItem_Click);
            // 
            // selectFolder_bt
            // 
            this.selectFolder_bt.Location = new System.Drawing.Point(6, 2);
            this.selectFolder_bt.Margin = new System.Windows.Forms.Padding(2);
            this.selectFolder_bt.Name = "selectFolder_bt";
            this.selectFolder_bt.Size = new System.Drawing.Size(83, 21);
            this.selectFolder_bt.TabIndex = 4;
            this.selectFolder_bt.Text = "选择文件夹";
            this.selectFolder_bt.UseVisualStyleBackColor = true;
            this.selectFolder_bt.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // tb_path
            // 
            this.tb_path.Enabled = false;
            this.tb_path.Location = new System.Drawing.Point(93, 2);
            this.tb_path.Margin = new System.Windows.Forms.Padding(2);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(361, 21);
            this.tb_path.TabIndex = 3;
            this.tb_path.Text = "%HOMEPATH%\\Music";
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(625, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(4, 29);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(35, 12);
            this.label_text.TabIndex = 9;
            this.label_text.Text = "label";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 363);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.selectFolder_bt);
            this.Controls.Add(this.bt_refresh_advance);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网易云音乐NCM格式转换器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lb_ncms;
        private System.Windows.Forms.CheckBox cb_ifDoDelete;
        private System.Windows.Forms.Button bt_conversion;
        private System.Windows.Forms.Button bt_refresh_advance;
        private System.Windows.Forms.Button selectFolder_bt;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Label label_text;
    }
}

