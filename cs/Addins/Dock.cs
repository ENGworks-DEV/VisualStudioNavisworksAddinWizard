using Autodesk.Navisworks.Api.Plugins;
using ENGworks.Navis.Ctr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENGworks.Navis.Addins
{
    [Plugin("DockA", "ENG", DisplayName = "ENG Tools")]
    [DockPanePlugin(200, 400, AutoScroll = true, MinimumHeight = 100, MinimumWidth = 200)]
    public class ClDockPanelUpdate : DockPanePlugin
    {
        public override Control CreateControlPane()
        {
            //Create a tabControl to store more user controls (Aula/Lesson 6)
            var tc = new TabControl();
            tc.ParentChanged += SetDockStile;

            //Store UcUpdate in the TabControl (Aula/Lesson 6)
            var tp1 = new TabPage("Auto Update");
            tp1.Controls.Add(new UcUpdate());
            tc.TabPages.Add(tp1);

            //Store UcUpdate in the TabControl (Aula/Lesson 6)
            var tp2 = new TabPage("Out Properties");
            tp2.Controls.Add(new UcProperties());
            tc.TabPages.Add(tp2);

            //Store UcUpdate in the TabControl (Aula/Lesson 6)
            var tp3 = new TabPage("Tools");
            tp3.Controls.Add(new UcTools());
            tc.TabPages.Add(tp3);

            return tc;
        }

        /// <summary>
        /// Aula/Lesson 6
        /// </summary>
        private void SetDockStile(object sender, EventArgs e)
        {
            try
            {
                var tc = sender as TabControl;
                tc.Dock = DockStyle.Fill;
            }
            catch (Exception)
            {

            }
        }

        public override void DestroyControlPane(Control pane)
        {
            try
            {
                var ctr = (UcUpdate)pane;
                ctr?.Dispose();
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
