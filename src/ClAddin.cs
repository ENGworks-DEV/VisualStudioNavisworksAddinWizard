using System;
using System.Windows.Forms;
using ENGworks.Navis.Ctr;
using Autodesk.Navisworks.Api.Plugins;

namespace ENGworks.Navis
{

    /// <summary>
    /// Load Tab
    /// </summary>
    [Plugin("ENGworks.Navis", "ENG", DisplayName = "ENGworks.Navis")]
    [RibbonLayout("ENGworks.Navis.xaml")]
    [RibbonTab("ID_CustomTab_1", DisplayName = "ENGworks")]
    [Command("ID_Button_1", Icon = "1_16.png", LargeIcon = "1_32.png", ToolTip = "Tool tip of tool")]
    [Command("ID_Button_2", Icon = "1_16.png", LargeIcon = "1_32.png", ToolTip = "Tool tip of tool")]
    public class ClAddin : CommandHandlerPlugin
    {
        public override int ExecuteCommand(string name, params string[] parameters)
        {

            switch (name)
            {
                case "ID_Button_1":

                    if (!Autodesk.Navisworks.Api.Application.IsAutomated)
                    {
                        var pluginRecord = Autodesk.Navisworks.Api.Application.Plugins.FindPlugin("DockA.ENG");

                        if (pluginRecord is DockPanePluginRecord && pluginRecord.IsEnabled)
                        {
                            var docPanel = (DockPanePlugin)(pluginRecord.LoadedPlugin ?? pluginRecord.LoadPlugin());
                            docPanel.ActivatePane();
                        }
                    }

                    break;

                case "ID_Button_2":

                    if (!Autodesk.Navisworks.Api.Application.IsAutomated)
                    {
                        var pluginRecord = Autodesk.Navisworks.Api.Application.Plugins.FindPlugin("AddinA.ENG");



                            var docPanel = (AddInPlugin)(pluginRecord.LoadedPlugin ?? pluginRecord.LoadPlugin());
                            docPanel.Execute();

                    }

                    break;

            }

            return 0;
        }
    }

}


