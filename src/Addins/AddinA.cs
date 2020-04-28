using Autodesk.Navisworks.Api.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENGworks.Navis.Addins
{
    [Plugin("AddinA", "ENG", ToolTip = "Multi purpose plugin, demonstrates various aspects of plugins",
                        DisplayName = "AddinSimpleA")]
    [AddInPlugin(AddInLocation.None)]//toggle to none to avoiud loading it twice
    public class AddinA : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            //Ensure if the plugin is loaded through Automation that parameters have been passed.
            if (Autodesk.Navisworks.Api.Application.IsAutomated &&
               parameters.Length == 0)
            {
                throw new InvalidOperationException("Running through Automation requires parameters to be set");
            }
            MessageBox.Show("run");

            return 0;
        }
    }
}
