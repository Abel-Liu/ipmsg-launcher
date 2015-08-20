namespace IPMsgLauncher
{
    partial class frmMain
    {
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
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.cName = ( (System.Windows.Forms.ColumnHeader)( new System.Windows.Forms.ColumnHeader() ) );
            this.cIP = ( (System.Windows.Forms.ColumnHeader)( new System.Windows.Forms.ColumnHeader() ) );
            this.cDesc = ( (System.Windows.Forms.ColumnHeader)( new System.Windows.Forms.ColumnHeader() ) );
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.listView1.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cIP,
            this.cDesc} );
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point( 6, 7 );
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size( 504, 144 );
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler( this.listView1_SelectedIndexChanged );
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 150;
            // 
            // cIP
            // 
            this.cIP.Text = "IP";
            this.cIP.Width = 100;
            // 
            // cDesc
            // 
            this.cDesc.Text = "Desc";
            this.cDesc.Width = 250;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point( 431, 171 );
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size( 73, 25 );
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 516, 209 );
            this.Controls.Add( this.btn_ok );
            this.Controls.Add( this.listView1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择要绑定的IP";
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cIP;
        private System.Windows.Forms.ColumnHeader cDesc;
    }
}


