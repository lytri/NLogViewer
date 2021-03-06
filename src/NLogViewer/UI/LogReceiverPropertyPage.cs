using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NLogViewer.Receivers;
using NLogViewer.Configuration;

namespace NLogViewer.UI
{
    public partial class LogReceiverPropertyPage : WizardPage, IWizardPropertyPage<ILogEventReceiver>
    {
        public LogReceiverPropertyPage()
        {
            InitializeComponent();
        }

        public ILogEventReceiver TargetObject
        {
            get { return propertyGrid1.SelectedObject as ILogEventReceiver; }
            set { propertyGrid1.SelectedObject = value; }
        }

        private void LogReceiverPropertyPage_Load(object sender, EventArgs e)
        {
        }
    }
}
