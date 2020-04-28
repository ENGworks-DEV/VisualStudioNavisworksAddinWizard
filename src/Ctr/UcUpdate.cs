using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ENGworks.Navis.Ctr
{
    public partial class UcUpdate : UserControl
    {

        /// <summary>
        /// Aula/Lesson 5
        /// </summary>
        public Timer UpTimer = new Timer { Enabled = true, Interval = 1000 };

        /// <summary>
        /// Aula/Lesson 5
        /// </summary>
        public List<FileInfo> ListInfos = new List<FileInfo>();

        /// <summary>
        /// Aula/Lesson 5
        /// </summary>
        public UcUpdate()
        {
            InitializeComponent();
            btUpdate.Enabled = false;

            UpTimer.Tick += UpTimerOnTick;

            Autodesk.Navisworks.Api.Application.ActiveDocumentChanged += ApplicationOnActiveDocumentChanged;
        }

        /// <summary>
        /// Aula/Lesson 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void ApplicationOnActiveDocumentChanged(object sender, EventArgs eventArgs)
        {
            ListInfos.Clear();
        }

        /// <summary>
        /// Aula/Lesson 5
        /// </summary>
        private void UpTimerOnTick(object sender, EventArgs eventArgs)
        {
            if (cbPause.Checked) return;
            if (Autodesk.Navisworks.Api.Application.ActiveDocument == null) return;

            var activeDocument = Autodesk.Navisworks.Api.Application.ActiveDocument;

            foreach (var model in activeDocument.Models)
            {
                var currentInfo = new FileInfo(model.SourceFileName);

                var lastInfo = ListInfos.FirstOrDefault(i => i.FullName == currentInfo.FullName);

                if (lastInfo != null)
                {
                    var time = Math.Abs((lastInfo.LastWriteTime - currentInfo.LastWriteTime).TotalSeconds);

                    if (time > 1)
                    {
                        btUpdate.Enabled = true;

                        ListInfos.Remove(lastInfo);
                        ListInfos.Add(currentInfo);

                        tbLog.AppendText(string.Concat(currentInfo.Name, " was updated!", Environment.NewLine));

                        if (cbUpdate.Checked)
                        {
                            UpdateModel();
                        }
                    }

                }
                else
                {
                    ListInfos.Add(currentInfo);
                }
            }

        }

        /// <summary>
        /// Aula/Lesson 5
        /// </summary>
        private void UpdateModel()
        {
            Autodesk.Navisworks.Api.Application.ActiveDocument.UpdateFiles();
            tbLog.AppendText(string.Concat("The active document was updated!", Environment.NewLine));
            btUpdate.Enabled = false;
        }

        /// <summary>
        /// Aula/Lesson 3
        /// </summary>
        /// <param name="e"></param>
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Aula/Lesson 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateModel();
        }

        /// <summary>
        /// Aula/Lesson 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_MouseUp(object sender, MouseEventArgs e)
        {
            tbLog.Clear();
        }

    }
}