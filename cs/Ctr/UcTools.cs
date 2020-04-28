using System;
using System.Windows.Forms;
using System.Linq;
using Autodesk.Navisworks.Api;
using NavisworksApp = Autodesk.Navisworks.Api.Application;
using Autodesk.Navisworks.Api.Interop.ComApi;
using Autodesk.Navisworks.Api.ComApi;
using System.Collections.Generic;
using Autodesk.Navisworks.Api.Clash;

namespace ENGworks.Navis.Ctr
{
    public partial class UcTools : UserControl
    {

        /// <summary>
        /// Aula/Lesson 10
        /// </summary>
        public static Timer TranslateTime { get; } = new Timer() { Enabled = true, Interval = 50 };

        /// <summary>
        /// Aula/Lesson 10
        /// </summary>
        public static System.Drawing.Color FocusedColor { get; } = System.Drawing.Color.ForestGreen;

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        public static ModelItemCollection LastIsolated { get; private set; }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        public static string LastIsolatedName { get; private set; }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        public UcTools()
        {
            InitializeComponent();

            MapLabels();

            TranslateTime.Tick += Translate;
        }

        /// <summary>
        /// Aula/Lesson 10
        /// </summary>
        private void Translate(object sender, EventArgs e)
        {

            if (!MouseButtons.Equals(MouseButtons.Left)) return;

            MoveElements();

            RotateElements();

            if (lbReset.BackColor.Equals(FocusedColor))
            {
                try
                {
                    var acd = NavisworksApp.ActiveDocument;
                    var se = acd.CurrentSelection.SelectedItems;
                    acd.Models.ResetPermanentTransform(se);
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        /// <summary>
        /// Aula/Lesson 10
        /// </summary>
        private void RotateElements()
        {
            var acd = NavisworksApp.ActiveDocument;

            double a = 0;
            double inc = 3;

            if (LbTurnR.BackColor.Equals(FocusedColor))
            {
                a = inc * (Math.PI / 180.0);
            }
            if (lbTurnL.BackColor.Equals(FocusedColor))
            {
                a = -inc * (Math.PI / 180.0);
            }

            if (a == 0) return;

            try
            {
                var se = acd.CurrentSelection.SelectedItems;

                foreach (var item in se)
                {
                    var loc = item.BoundingBox().Center;

                    //Move to origin
                    var mb = new Vector3D(loc.X,
                                          loc.Y,
                                          loc.Z);

                    var mo = new Vector3D(-loc.X,
                                          -loc.Y,
                                          -loc.Z);

                    var transVec = Transform3D.CreateTranslation(mo);

                    acd.Models.OverridePermanentTransform(new List<ModelItem> { item }, transVec, true);

                    //Rotate                    
                    var rt = new Rotation3D(new UnitVector3D(0, 0, 1), a);

                    var tr = new Transform3D(rt, mb);

                    acd.Models.OverridePermanentTransform(new List<ModelItem> { item }, tr, true);

                }
            }
            catch (Exception)
            {
                //
            }
        }

        /// <summary>
        /// Aula/Lesson 10
        /// </summary>
        private void MoveElements()
        {
            var acd = NavisworksApp.ActiveDocument;

            var x = 0;
            var y = 0;
            var z = 0;
            var inc = 5;

            if (LbX.BackColor.Equals(FocusedColor))
            {
                x = inc;
            }
            if (LbXm.BackColor.Equals(FocusedColor))
            {
                x = -inc;
            }

            if (LbY.BackColor.Equals(FocusedColor))
            {
                y = inc;
            }
            if (LbYm.BackColor.Equals(FocusedColor))
            {
                y = -inc;
            }

            if (LbZ.BackColor.Equals(FocusedColor))
            {
                z = inc;
            }
            if (LbZm.BackColor.Equals(FocusedColor))
            {
                z = -inc;
            }

            if (x == 0 & y == 0 & z == 0) return;

            try
            {
                var se = acd.CurrentSelection.SelectedItems;

                foreach (var item in se)
                {

                    var im = item.AncestorsAndSelf.First(i => i.Model != null);

                    var sc = UnitConversion.ScaleFactor(Units.Millimeters, im.Model.Units);

                    var mv = new Vector3D(x * sc, y * sc, z * sc);

                    var transVec = Transform3D.CreateTranslation(mv);

                    acd.Models.OverridePermanentTransform(new List<ModelItem> { item }, transVec, true);
                }
            }
            catch (Exception)
            {
                //
            }
        }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        private void LbIsolateSelection_MouseUp(object sender, MouseEventArgs e)
        {
            IsolateSelection();
        }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        private void LbSaveVp_MouseUp(object sender, MouseEventArgs e)
        {
            SaveCurrentViewpoint();
        }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        private void LbIsolateAndSave_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                IsolateSelection();
                SaveCurrentViewpoint();
            }
            catch (Exception)
            {
                //
            }

        }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        private void SaveCurrentViewpoint()
        {
            var acd = NavisworksApp.ActiveDocument;

            try
            {
                acd.Models.OverridePermanentColor(LastIsolated, new Color(1, 0, 0));

                var state = ComApiBridge.State;

                var cv = state.CurrentView.Copy();

                var vp = state.ObjectFactory(nwEObjectType.eObjectType_nwOpView);

                var view = vp as InwOpView;

                if (view != null) view.ApplyHideAttribs = true;
                view.ApplyMaterialAttribs = true;

                vp.Name = LastIsolatedName;

                vp.anonview = cv;

                state.SavedViews().Add(vp);

            }
            catch (Exception)
            {
                //
            }

        }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        private static void IsolateSelection()
        {
            var acd = NavisworksApp.ActiveDocument;

            var se = acd.CurrentSelection.SelectedItems.First;
            if (se == null) return;

            var all = acd.Models.CreateCollectionFromRootItems().SelectMany(m => m.DescendantsAndSelf);

            try
            {

                acd.Models.SetHidden(all, false);

                var sel = new ModelItemCollection();
                sel.AddRange(se.DescendantsAndSelf);
                sel.AddRange(se.AncestorsAndSelf);
                acd.State.InvertSelection();

                acd.Models.SetHidden(acd.CurrentSelection.SelectedItems, true);
                acd.ActiveView.LookFromFrontRightTop();

                LastIsolated = sel;
                LastIsolatedName = se.DisplayName;

            }
            catch (Exception)
            {
                //
            }
        }

        /// <summary>
        /// Aula/Lesson 11
        /// </summary>
        private void lbCheck_MouseUp(object sender, MouseEventArgs e)
        {
            var acd = NavisworksApp.ActiveDocument;

            var allItens = new ModelItemCollection();

            allItens.AddRange(acd.CurrentSelection.SelectedItems);

            var cb = new ModelItemCollection();

            foreach (var modelIten in allItens)
            {
                cb.Clear();
                cb.AddRange(allItens);
                cb.Remove(modelIten);

                // Create the Clash Test
                var ct = new ClashTest { CustomTestName = modelIten.DisplayName };
                ct.DisplayName = ct.CustomTestName;

                ct.TestType = ClashTestType.Hard;

                //Scala de conversão
                var sc = UnitConversion.ScaleFactor(acd.Models.First.Units, Units.Millimeters);
                ct.Tolerance = Convert.ToDouble(1 / sc);

                ct.SelectionA.SelfIntersect = false;
                ct.SelectionA.PrimitiveTypes = PrimitiveTypes.Triangles;
                ct.SelectionB.SelfIntersect = false;
                ct.SelectionB.PrimitiveTypes = PrimitiveTypes.Triangles;

                ct.SelectionA.Selection.CopyFrom(new ModelItemCollection() { modelIten });
                ct.SelectionB.Selection.CopyFrom(cb);

                try
                {
                    var dc = acd.Clash as DocumentClash;
                    var tcopy = (ClashTest)ct.CreateCopy();
                    dc.TestsData.TestsAddCopy(tcopy);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        #region Styles

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        private void MapLabels()
        {
            var lbs = Controls.OfType<Label>();

            foreach (var l in lbs)
            {
                l.MouseLeave += labelUnFocused;
                l.MouseEnter += LabelFocused;
            }

        }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        private void LabelFocused(object sender, EventArgs e)
        {
            try
            {
                (sender as Label).BackColor = FocusedColor;
            }
            catch (Exception)
            {
                //
            }
        }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        /// <param name="e"></param>
        private void labelUnFocused(object sender, EventArgs e)
        {
            try
            {
                (sender as Label).BackColor = Label.DefaultBackColor;
            }
            catch (Exception)
            {
                //
            }
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

        #endregion



    }
}