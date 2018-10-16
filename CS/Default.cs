using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            InitializeComponent();
            //this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
        }
    }
}
