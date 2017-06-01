using Sitecore.Shell.Framework.Commands;
using Sitecore.Web.UI.Sheer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.Serialization.Commands
{
    public class FieldOptionsCommand : Command
    {
        private const string FieldOptionsApplication = "";
        public override void Execute(CommandContext context)
        {
            // Trigger Speak Dialog
            SheerResponse.ShowModalDialog(new ModalDialogOptions(FieldOptionsApplication)
            {
                Width = "100",
                Height = "200",
                Response = true,
                ForceDialogSize = true
            });
        }

        public override CommandState QueryState(CommandContext context)
        {
            return base.QueryState(context);
        }
    }
}