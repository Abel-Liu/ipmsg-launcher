using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace IPMsgLauncher
{
    public static class Tool
    {
        public static void StartIpmsg( string ip )
        {
            string path = GetFilePath();
            if ( string.IsNullOrEmpty( path ) )
                return;
            Process.Start( path, "/NIC " + ip );
        }

        public static string GetFilePath()
        {
            string defaultPath = Path.Combine( Application.StartupPath, "IPMSG2007.exe" );
            if ( File.Exists( defaultPath ) )
            {
                return defaultPath;
            }
            else
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "可执行文件|*.exe";
                of.Title = "选择飞鸽";
                of.Multiselect = false;
                if ( of.ShowDialog() == DialogResult.OK )
                {
                    return of.FileName;
                }
                else
                    return string.Empty;
            }
        }
    }
}
