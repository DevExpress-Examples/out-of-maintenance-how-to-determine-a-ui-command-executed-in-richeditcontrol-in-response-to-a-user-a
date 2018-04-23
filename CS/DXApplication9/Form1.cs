using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Services;

namespace DXApplication9
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1()
        {
           InitializeComponent();
           CustomCommandExecutionListenerService service = new CustomCommandExecutionListenerService();
           service.RichEditControl = richEditControl;
           service.CommandExecutedEvent += service_CommandExecutedEvent;
           richEditControl.RemoveService(typeof(ICommandExecutionListenerService));
           richEditControl.AddService(typeof(ICommandExecutionListenerService), service);
        }

        void service_CommandExecutedEvent(object sender, CommandEventArgs e)
        {
            string text = String.Format("{0} Description: {1}{2}", e.CommandName, e.CommandDescription, Environment.NewLine);
            memoEdit1.Text += text;
        }


    }
}



    
