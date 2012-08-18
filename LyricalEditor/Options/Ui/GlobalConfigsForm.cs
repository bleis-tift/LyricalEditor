using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace bleistift.LyricalEditor.Options.Ui
{
    public partial class GlobalConfigsForm : UserControl
    {
        GlobalConfigs config = null;

        public GlobalConfigsForm()
        {
            InitializeComponent();
        }

        List<Tuple<string, Detail>> details = new List<Tuple<string, Detail>>();

        void Notify()
        {
            config.DetailsStr = Detail.Str(details);
        }

        internal GlobalConfigsForm(GlobalConfigs config)
        {
            this.config = config;
            InitializeComponent();
            details = Detail.Details(config.DetailsStr ?? "");
            foreach (var kv in details)
            {
                lst_rules.Add(kv.Item1);
                group_details.Enabled = true;
            }
        }

        private void lst_rules_SelectedItemChanged(RichListControl self, object selected)
        {
            if (selected == null)
                return;
            selectedDetail = details.Find(k => k.Item1 == selected.ToString()).Item2;
            txt_ruleRegex.Text = selectedDetail.RuleRegex;
            track_opacity.Value = selectedDetail.Opacity;
            check_random.Checked = selectedDetail.IsRandom;
            check_slideShow.Checked = selectedDetail.IsSlideShow;
            num_slideShowTiming.Value = selectedDetail.SlideShowTiming;
            lst_images.Clear();
            foreach (var item in selectedDetail.Images)
                lst_images.Add(item);
            Notify();
        }

        Detail selectedDetail = null;

        private object[] lst_rules_ItemAdding(RichListControl self)
        {
            var res = Microsoft.VisualBasic.Interaction.InputBox("rule name:");
            if (string.IsNullOrEmpty(res))
                return null;
            group_details.Enabled = true;
            if (details.Any(kv => kv.Item1 == res))
                return null;
            details.Add(Tuple.Create(res, new Detail()));
            Notify();
            return new[] { res };
        }

        private void lst_rules_ItemDeleted(RichListControl self, int index, object selected)
        {
            if (!self.Items.Any())
                group_details.Enabled = false;
            details.RemoveAt(index);
            Notify();
        }

        private void check_slideShow_CheckedChanged(object sender, EventArgs e)
        {
            num_slideShowTiming.Enabled = check_slideShow.Checked;
            if (selectedDetail != null)
            {
                selectedDetail.IsSlideShow = check_slideShow.Checked;
                Notify();
            }
        }

        private void track_opacity_ValueChanged(object sender, EventArgs e)
        {
            lbl_opacityValue.Text = track_opacity.Value.ToString();
            if (selectedDetail != null)
            {
                selectedDetail.Opacity = track_opacity.Value;
                Notify();
            }
        }

        private void txt_ruleRegex_TextChanged(object sender, EventArgs e)
        {
            if (selectedDetail != null)
            {
                selectedDetail.RuleRegex = txt_ruleRegex.Text;
                Notify();
            }
        }

        private void check_random_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedDetail != null)
            {
                selectedDetail.IsRandom = check_random.Checked;
                Notify();
            }
        }

        private void num_slideShowTiming_ValueChanged(object sender, EventArgs e)
        {
            if (selectedDetail != null)
            {
                selectedDetail.SlideShowTiming = num_slideShowTiming.Value;
                Notify();
            }
        }

        private object[] lst_images_ItemAdding(RichListControl self)
        {
            if (dlg_image.ShowDialog() == DialogResult.OK)
            {
                var selecteds = dlg_image.FileNames;
                if (selectedDetail != null)
                    selectedDetail.Images.AddRange(selecteds);
                Notify();
                return selecteds;
            }
            return null;
        }

        private void lst_images_ItemDeleted(RichListControl self, int index, object selected)
        {
            if (selectedDetail != null)
            {
                selectedDetail.Images.RemoveAt(index);
                Notify();
            }
        }

        private object lst_images_ItemDoubleClick(RichListControl self, int selectedIndex, object selectedItem)
        {
            dlg_image.InitialDirectory = Path.GetDirectoryName(selectedItem.ToString());
            dlg_image.FileName = selectedItem.ToString();
            if (dlg_image.ShowDialog() == DialogResult.OK && selectedDetail != null)
            {
                selectedDetail.Images[selectedIndex] = dlg_image.FileName;
                Notify();
                return dlg_image.FileName;
            }
            return null;
        }

    }
}
