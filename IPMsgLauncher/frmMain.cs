using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPMsgLauncher
{
    public partial class frmMain : Form
    {
        public frmMain( List<NetWorkInfo> infos )
        {
            InitializeComponent();

            this.btn_ok.Click += new EventHandler( GoToStart );
            this.listView1.DoubleClick += new EventHandler( GoToStart );

            foreach ( NetWorkInfo ni in infos )
            {
                ListViewItem item = new ListViewItem();
                item.Text = ni.Name;
                item.SubItems.Add( ni.IP );
                item.SubItems.Add( ni.Desc );
                listView1.Items.Add( item );
            }
        }

        private void listView1_SelectedIndexChanged( object sender, EventArgs e )
        {
            btn_ok.Enabled = listView1.SelectedItems.Count > 0;
        }

        private void GoToStart( object sender, EventArgs e )
        {
            Tool.StartIpmsg( listView1.SelectedItems[0].SubItems[1].Text );
            this.Close();
        }
    }
}
