using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace UTQC
{
    public partial class ConnectionControlForm : Form
    {
        public ConnectionControlForm()
        {
            InitializeComponent();

            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(3000);
            th.Abort();
            Thread.Sleep(1000);
        }

        private void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            switch (comboBox_gameType.SelectedIndex)
            {
                case 0:
                    {
                        // Change out port for the desired computer station
                        // qUTe uses the following ports:
                        // Station A = 27100
                        // Station B = 27200
                        // Station C = 27300
                        connect_to_server(Properties.Settings.Default.SERVER_PORT_IND);
                        break;
                    }
                case 1:
                    {
                        connect_to_server(Properties.Settings.Default.SERVER_PORT_CMN);                        
                        break;
                    }
            }
        }

        private void connect_to_server(String port)
        {
            Process p = new Process();
            p.StartInfo.WorkingDirectory = System.IO.Path.Combine(Properties.Settings.Default.UT2004_HOME, "System");
            p.StartInfo.FileName = "UT2004.exe";
            p.StartInfo.Arguments = "ut2004://" + Properties.Settings.Default.SERVER_IP + ":" + port;
            p.Start();
        }

        private void comboBox_gameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // must define this method
        }
    }
}