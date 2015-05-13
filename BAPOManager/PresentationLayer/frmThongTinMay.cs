using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace BAPOManager.PresentationLayer
{
    public partial class frmThongTinMay : Form
    {
        public frmThongTinMay()
        {
            InitializeComponent();
        }

        private void lbIPMang_Click(object sender, EventArgs e)
        {

        }

        private void frmThongTinMay_Load(object sender, EventArgs e)
        {
            get_TenMay();
            get_IPLocal();
            get_Internet();
            get_HeDieuHanh();
        }

        private void get_TenMay()
        {
            lbTenMay.Text = System.Environment.MachineName;
        }

        private void get_IPLocal()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            lbIPLocal.Text = localIP;
        }

        private void get_IPNet()
        {

        }

        private void get_HeDieuHanh()
        {
            //StringBuilder str = new StringBuilder();
            //OperatingSystem osObj = System.Environment.OSVersion;
            //str.AppendLine("Nen tang la: " + osObj.Platform);
            //str.AppendLine("Service Pack: " + osObj.ServicePack);
            //str.AppendLine("Phien ban: " + osObj.Version);
            //str.AppendLine("VersionString: " + osObj.VersionString);
            //str.AppendLine("CLR Version: " + System.Environment.Version);
            //MessageBox.Show(str.ToString());
            lbHeDieuHanh.Text = getOSInfo();
        }

        private void get_Internet()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                lbInternet.Text = "Sẵn sàng";
                lbInternet.ForeColor = Color.Green;
            }
            catch
            {
                lbInternet.Text = "Không";
                lbInternet.ForeColor = Color.Red;
            }
        }

        string getOSInfo()
        {
            //Get Operating system information.
            OperatingSystem os = Environment.OSVersion;
            //Get version information about the os.
            Version vs = os.Version;

            //Variable to hold our return value
            string operatingSystem = "";

            if (os.Platform == PlatformID.Win32Windows)
            {
                //This is a pre-NT version of Windows
                switch (vs.Minor)
                {
                    case 0:
                        operatingSystem = "95";
                        break;
                    case 10:
                        if (vs.Revision.ToString() == "2222A")
                            operatingSystem = "98SE";
                        else
                            operatingSystem = "98";
                        break;
                    case 90:
                        operatingSystem = "Me";
                        break;
                    default:
                        break;
                }
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        operatingSystem = "NT 3.51";
                        break;
                    case 4:
                        operatingSystem = "NT 4.0";
                        break;
                    case 5:
                        if (vs.Minor == 0)
                            operatingSystem = "2000";
                        else
                            operatingSystem = "XP";
                        break;
                    case 6:
                        if (vs.Minor == 0)
                            operatingSystem = "Vista";
                        else
                            operatingSystem = "7";
                        break;
                    default:
                        break;
                }
            }
            //Make sure we actually got something in our OS check
            //We don't want to just return " Service Pack 2" or " 32-bit"
            //That information is useless without the OS version.
            if (operatingSystem != "")
            {
                //Got something.  Let's prepend "Windows" and get more info.
                operatingSystem = "Windows " + operatingSystem;
                //See if there's a service pack installed.
                if (os.ServicePack != "")
                {
                    //Append it to the OS name.  i.e. "Windows XP Service Pack 3"
                    operatingSystem += " (" + os.ServicePack+")";
                }
                //Append the OS architecture.  i.e. "Windows XP Service Pack 3 32-bit"
                //operatingSystem += " " + getOSArchitecture().ToString() + "-bit";
                operatingSystem += ", Version " + os.Version.ToString();
            }
            //Return the information we've gathered.
            return operatingSystem;
        }

        private void chkIPMang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIPMang.Checked)
            {
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                String direction = "";
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                    {
                        direction = stream.ReadToEnd();
                    }
                }

                //Search for the ip in the html
                int first = direction.IndexOf("Address: ") + 9;
                int last = direction.LastIndexOf("</body>");
                direction = direction.Substring(first, last - first);

                lbIPMang.Text = direction;
            }
            catch
            {
                lbIPMang.Text = "null";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
