using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace IPMsgLauncher
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            try
            {
                List<NetWorkInfo> allInfoList = new List<NetWorkInfo>();
                List<NetWorkInfo> readyInfoList = new List<NetWorkInfo>();
                NetworkInterface[] netWorks = NetworkInterface.GetAllNetworkInterfaces();
                foreach ( NetworkInterface netWork in netWorks )
                {
                    if ( netWork.OperationalStatus == OperationalStatus.Up )
                    {
                        IPInterfaceProperties ipProp = netWork.GetIPProperties();
                        UnicastIPAddressInformationCollection ipInfos = ipProp.UnicastAddresses;
                        foreach ( UnicastIPAddressInformation ipInfo in ipInfos )
                        {
                            if ( ipInfo.Address.AddressFamily == AddressFamily.InterNetwork )
                            {
                                NetWorkInfo myInfo = new NetWorkInfo();
                                myInfo.IP = ipInfo.Address.ToString();
                                myInfo.Desc = netWork.Description;
                                myInfo.Name = netWork.Name;
                                allInfoList.Add( myInfo );
                                if ( netWork.Name == "本地连接" || netWork.Name == "无线网络连接" || netWork.Name == "Local Area Connection" || netWork.Name == "Wireless Network Connection" )
                                    readyInfoList.Add( myInfo );
                            }
                        }
                    }
                }

                if ( readyInfoList.Count == 1 )
                    Tool.StartIpmsg( readyInfoList[0].IP );
                else
                    Application.Run( new frmMain( allInfoList ) );
            }
            catch { MessageBox.Show( "error!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning ); }
        }
    }
}
