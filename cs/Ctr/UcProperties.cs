using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Navisworks.Api;
using NavisworksApp = Autodesk.Navisworks.Api.Application;

namespace ENGworks.Navis.Ctr
{
    /// <summary>
    /// Aula/Lesson 6
    /// </summary>
    public partial class UcProperties : UserControl
    {

        /// <summary>
        /// Aula/Lesson 6
        /// </summary>
        public UcProperties()
        {
            InitializeComponent();

            ListenSelection(null, null);
            NavisworksApp.MainDocumentChanged += ListenSelection;
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
        /// Aula/Lesson 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListenSelection(object sender, EventArgs e)
        {
            try
            {
                NavisworksApp.ActiveDocument.CurrentSelection.Changed += GetProperties;
            }
            catch (Exception)
            {

            }

        }

        /// <summary>
        /// Aula/Lesson 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetProperties(object sender, EventArgs e)
        {

            if (cbPause.Checked) return;

            try
            {
                tbProp.Clear();

                var lines = new List<string>();

                foreach (var item in NavisworksApp.ActiveDocument.CurrentSelection.SelectedItems)
                {
                    lines.Add(item.DisplayName);

                    foreach (var cat in item.PropertyCategories)
                    {
                        lines.Add(string.Concat(".   ", cat.DisplayName));

                        foreach (var prop in cat.Properties)
                        {
                            lines.Add(string.Concat(".   .   ", prop.DisplayName, ": ", GetPropValue(prop)));
                        }
                    }

                    lines.Add(Environment.NewLine);
                }

                tbProp.Text = string.Join(Environment.NewLine, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Aula/Lesson 6
        /// </summary>
        private static string GetPropValue(DataProperty prop)
        {

            try
            {
                return prop.Value.IsDisplayString ? prop.Value.ToDisplayString() :
                                                            prop.Value.ToString().Split(':')[1];
            }
            catch (Exception)
            {
                return "Prop Error";
            }

        }

        /// <summary>
        /// Aula/Lesson 7
        /// </summary>
        private void btFind_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                var result = new List<ModelItem>();

                foreach (var item in NavisworksApp.ActiveDocument.CurrentSelection.SelectedItems)
                {
                    var cat = item.DescendantsAndSelf.Where(i => i.PropertyCategories.FindCategoryByDisplayName(tbCatName.Text) != null);

                    var prop = cat.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbCatName.Text).
                                            Properties.FindPropertyByDisplayName(tbPropName.Text) != null);

                    result.AddRange(prop.Where(m => GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbCatName.Text).
                                            Properties.FindPropertyByDisplayName(tbPropName.Text)) == tbValueName.Text));

                }

                NavisworksApp.ActiveDocument.CurrentSelection.Clear();
                NavisworksApp.ActiveDocument.CurrentSelection.AddRange(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Aula/Lesson 8
        /// </summary>
        private void btCreateSet_MouseUp(object sender, MouseEventArgs e)
        {
            var ac = NavisworksApp.ActiveDocument;
            var cs = ac.CurrentSelection;
            var ss = ac.SelectionSets;

            var fn = "Saved Sets";
            var sn = string.Concat(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff"));

            try
            {
                var set = new SelectionSet(cs.SelectedItems)
                {
                    DisplayName = sn
                };

                var fi = ss.Value.IndexOfDisplayName(fn);

                if (fi == -1)
                {
                    var sf = new FolderItem() { DisplayName = fn };
                    sf.Children.Add(set);
                    ss.AddCopy(sf);
                }
                else
                {
                    ss.AddCopy(set);

                    fi = ss.Value.IndexOfDisplayName(fn);
                    var fo = ss.Value[fi] as FolderItem;

                    var si = ss.Value.IndexOfDisplayName(set.DisplayName);
                    var se = ss.Value[si] as SavedItem;

                    ss.Move(se.Parent, si, fo, 0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Aula/Lesson 9
        /// </summary>
        private void btCreateSearch_MouseUp(object sender, MouseEventArgs e)
        {
            var ac = NavisworksApp.ActiveDocument;
            var cs = ac.CurrentSelection;
            var ss = ac.SelectionSets;

            var fn = "Saved Search";
            var sn = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");

            try
            {
                var s = new Search();
                s.Selection.SelectAll();
                s.Locations = SearchLocations.DescendantsAndSelf;

                var sc = SearchCondition.HasPropertyByDisplayName(tbCatName.Text, tbPropName.Text);
                s.SearchConditions.Add(sc.EqualValue(VariantData.FromDisplayString(tbValueName.Text)));

                var sSet = new SelectionSet(s)
                {
                    DisplayName = sn
                };
                ss.AddCopy(sSet);

                var fi = ss.Value.IndexOfDisplayName(fn);

                if (fi == -1)
                {
                    var sf = new FolderItem() { DisplayName = fn };
                    ss.AddCopy(sf);
                }

                fi = ss.Value.IndexOfDisplayName(fn);
                var fo = ss.Value[fi] as FolderItem;

                var si = ss.Value.IndexOfDisplayName(sn);
                var se = ss.Value[si] as SavedItem;

                ss.Move(se.Parent, si, fo, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}