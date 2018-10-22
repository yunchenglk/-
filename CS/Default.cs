using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS
{
    public partial class Default : Form
    {
        public Default()
        {
            var appName = Process.GetCurrentProcess().MainModule.ModuleName;
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", appName, 9999, RegistryValueKind.DWord);
            InitializeComponent();
            //this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
        }
    }
}
