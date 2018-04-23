using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraRichEdit;
using DevExpress.Services.Implementation;
using DevExpress.Services;

namespace DXApplication9
{
    public class CustomCommandExecutionListenerService : CommandExecutionListenerService
    {
        public RichEditControl RichEditControl
        {
            get;
            set;
        }
        public delegate void CommandExecutedEventHandler(object sender, CommandEventArgs e);
        public event CommandExecutedEventHandler CommandExecutedEvent;

        protected virtual void RaiseCommandExecutedEvent(CommandEventArgs e)
        {
            if (CommandExecutedEvent != null)
                CommandExecutedEvent(this, e);
        }

        public override void EndCommandExecution(DevExpress.Utils.Commands.Command command, DevExpress.Utils.Commands.ICommandUIState state)
        {
            base.EndCommandExecution(command, state);
            if (!RichEditControl.IsUpdateLocked)
            {
                RaiseCommandExecutedEvent(new CommandEventArgs(command.ToString(), command.Description));
            }
        }
    }
    public class CommandEventArgs
    {
        public CommandEventArgs(string name, string description)
        {
            CommandName = name;
            CommandDescription = description;
        }
        public string CommandName { get; private set; }
        public string CommandDescription { get; private set; }
    }
}
