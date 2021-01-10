using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Web_Browser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRender(this);
        }

        
        
        public override TitleBarTab CreateTab()
        {
            throw new NotImplementedException();
            {
                return new TitleBarTab(this)
                {
                    //The content will be an instance of another Form
                    // In our example, we will create a new instanse of the Form1
                    Content = new frmBrowser
                    {
                        Text = "New Tab"
                    }
                };
            }
        }
    }
}
