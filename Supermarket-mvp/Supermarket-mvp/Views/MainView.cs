using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            btnCategory.Click += delegate { ShowCategoryView?.Invoke(this, EventArgs.Empty); };
            btnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            btnProvider.Click += delegate { ShowProviderView?.Invoke(this, EventArgs.Empty); };
            btnExit.Click += delegate { this.Close(); };
        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCategoryView;
        public event EventHandler ShowProviderView;
    }
}
