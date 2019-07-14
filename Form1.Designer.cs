namespace talkwith_spulpa
{
    partial class Form_Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_load = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_export = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_talk = new System.Windows.Forms.DataGridView();
            this.button_nameAdd = new System.Windows.Forms.Button();
            this.comboBox_talkingName = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip_name = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_name_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Talk = new System.Windows.Forms.TextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_talk)).BeginInit();
            this.contextMenuStrip_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.talkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ツールTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_save,
            this.toolStripMenuItem_load,
            this.toolStripMenuItem_export});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // toolStripMenuItem_save
            // 
            this.toolStripMenuItem_save.Name = "toolStripMenuItem_save";
            this.toolStripMenuItem_save.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_save.Text = "保存(&S)";
            this.toolStripMenuItem_save.Click += new System.EventHandler(this.ToolStripMenuItem_save_Click);
            // 
            // toolStripMenuItem_load
            // 
            this.toolStripMenuItem_load.Name = "toolStripMenuItem_load";
            this.toolStripMenuItem_load.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_load.Text = "読みこみ";
            this.toolStripMenuItem_load.Click += new System.EventHandler(this.ToolStripMenuItem_load_Click);
            // 
            // toolStripMenuItem_export
            // 
            this.toolStripMenuItem_export.Name = "toolStripMenuItem_export";
            this.toolStripMenuItem_export.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_export.Text = "エクスポート";
            this.toolStripMenuItem_export.Click += new System.EventHandler(this.ToolStripMenuItem_export_Click);
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_setting});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ツールTToolStripMenuItem.Text = "ツール(T)";
            // 
            // toolStripMenuItem_setting
            // 
            this.toolStripMenuItem_setting.Name = "toolStripMenuItem_setting";
            this.toolStripMenuItem_setting.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem_setting.Text = "設定";
            this.toolStripMenuItem_setting.Click += new System.EventHandler(this.ToolStripMenuItem_setting_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_talk);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_nameAdd);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_talkingName);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_Talk);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView_talk
            // 
            this.dataGridView_talk.AllowUserToAddRows = false;
            this.dataGridView_talk.AllowUserToDeleteRows = false;
            this.dataGridView_talk.AllowUserToOrderColumns = true;
            this.dataGridView_talk.AutoGenerateColumns = false;
            this.dataGridView_talk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_talk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.talkDataGridViewTextBoxColumn});
            this.dataGridView_talk.DataSource = this.talkingBindingSource;
            this.dataGridView_talk.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_talk.Name = "dataGridView_talk";
            this.dataGridView_talk.ReadOnly = true;
            this.dataGridView_talk.RowHeadersVisible = false;
            this.dataGridView_talk.RowTemplate.Height = 21;
            this.dataGridView_talk.Size = new System.Drawing.Size(794, 308);
            this.dataGridView_talk.TabIndex = 0;
            // 
            // button_nameAdd
            // 
            this.button_nameAdd.Location = new System.Drawing.Point(4, 3);
            this.button_nameAdd.Name = "button_nameAdd";
            this.button_nameAdd.Size = new System.Drawing.Size(102, 23);
            this.button_nameAdd.TabIndex = 3;
            this.button_nameAdd.Text = "名前追加";
            this.button_nameAdd.UseVisualStyleBackColor = true;
            this.button_nameAdd.Click += new System.EventHandler(this.Button_nameAdd_Click);
            // 
            // comboBox_talkingName
            // 
            this.comboBox_talkingName.ContextMenuStrip = this.contextMenuStrip_name;
            this.comboBox_talkingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_talkingName.FormattingEnabled = true;
            this.comboBox_talkingName.Location = new System.Drawing.Point(3, 27);
            this.comboBox_talkingName.Name = "comboBox_talkingName";
            this.comboBox_talkingName.Size = new System.Drawing.Size(103, 78);
            this.comboBox_talkingName.TabIndex = 2;
            this.comboBox_talkingName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBox_talkingName_KeyUp);
            // 
            // contextMenuStrip_name
            // 
            this.contextMenuStrip_name.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_name_delete});
            this.contextMenuStrip_name.Name = "contextMenuStrip_name";
            this.contextMenuStrip_name.Size = new System.Drawing.Size(99, 26);
            // 
            // ToolStripMenuItem_name_delete
            // 
            this.ToolStripMenuItem_name_delete.Name = "ToolStripMenuItem_name_delete";
            this.ToolStripMenuItem_name_delete.Size = new System.Drawing.Size(98, 22);
            this.ToolStripMenuItem_name_delete.Text = "削除";
            this.ToolStripMenuItem_name_delete.Click += new System.EventHandler(this.toolStripMenuItem_name_delete_Click);
            // 
            // textBox_Talk
            // 
            this.textBox_Talk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Talk.Location = new System.Drawing.Point(112, 3);
            this.textBox_Talk.Multiline = true;
            this.textBox_Talk.Name = "textBox_Talk";
            this.textBox_Talk.Size = new System.Drawing.Size(685, 102);
            this.textBox_Talk.TabIndex = 1;
            this.textBox_Talk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Talk_KeyDown);
            this.textBox_Talk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Talk_KeyPress);
            this.textBox_Talk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_Talk_KeyUp);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // talkDataGridViewTextBoxColumn
            // 
            this.talkDataGridViewTextBoxColumn.DataPropertyName = "talk";
            this.talkDataGridViewTextBoxColumn.HeaderText = "talk";
            this.talkDataGridViewTextBoxColumn.Name = "talkDataGridViewTextBoxColumn";
            this.talkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // talkingBindingSource
            // 
            this.talkingBindingSource.DataSource = typeof(talkwith_spulpa.Talking);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "簡易台本作成";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_talk)).EndInit();
            this.contextMenuStrip_name.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.talkingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_save;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_load;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_setting;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox_talkingName;
        private System.Windows.Forms.TextBox textBox_Talk;
        private System.Windows.Forms.DataGridView dataGridView_talk;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_export;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_name;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_name_delete;
        private System.Windows.Forms.Button button_nameAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource talkingBindingSource;
    }
}

