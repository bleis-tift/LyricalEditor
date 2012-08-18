using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bleistift.LyricalEditor.Options.Ui
{
    public delegate object[] RichListAddHandler(RichListControl self);
    public delegate void RichListDeleteHandler(RichListControl self, int delIndex, object delItem);
    public delegate void RichListEventHandler(RichListControl self, object selected);
    public delegate object RichListDoubleClickHandler(RichListControl self, int selectedIndex, object selectedItem);
    public partial class RichListControl : UserControl
    {
        public event RichListAddHandler ItemAdding;
        public event RichListDeleteHandler ItemDeleted = delegate { };
        public event RichListEventHandler SelectedItemChanged = delegate { };
        public event RichListDoubleClickHandler ItemDoubleClick = (_, __, ___) => null;

        public RichListControl()
        {
            InitializeComponent();
        }

        public IEnumerable<object> Items { get { return lst_values.Items.Cast<object>(); } }

        public void Clear()
        {
            lst_values.Items.Clear();
            btn_del.Enabled = false;
            SetUpDownButtonsEnabled(false, false);
        }

        public void Add(object item)
        {
            lst_values.Items.Add(item);
            if (lst_values.Items.Count != 0)
                btn_del.Enabled = true;
            lst_values.SelectedIndex = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var items = ItemAdding(this);
            if (items == null || items.Length == 0)
                return;
            foreach (var item in items)
                Add(item);
            lst_values.SelectedIndex = lst_values.Items.Count - 1;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var item = lst_values.SelectedItem;
            var i = lst_values.SelectedIndex;
            lst_values.Items.RemoveAt(i);
            ItemDeleted(this, i, item);
            if (lst_values.Items.Count == 0)
            {
                btn_del.Enabled = false;
                SetUpDownButtonsEnabled(false, false);
            }
            else
            {
                lst_values.SelectedIndex = i == lst_values.Items.Count ? i - 1 : i;
            }
        }

        void MoveSelectedItemTo(int newIndex)
        {
            var i = lst_values.SelectedIndex;
            var selected = lst_values.Items[i];
            lst_values.Items.RemoveAt(i);
            lst_values.Items.Insert(newIndex, selected);
            lst_values.SelectedIndex = newIndex;
        }

        private void btn_topMost_Click(object sender, EventArgs e)
        {
            MoveSelectedItemTo(0);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            MoveSelectedItemTo(lst_values.SelectedIndex - 1);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            MoveSelectedItemTo(lst_values.SelectedIndex + 1);
        }

        private void btn_bottomMost_Click(object sender, EventArgs e)
        {
            MoveSelectedItemTo(lst_values.Items.Count - 1);
        }

        void SetUpButtonEnabled(bool enabled)
        {
            btn_topMost.Enabled = enabled;
            btn_up.Enabled = enabled;
        }

        void SetDownButtonEnabled(bool enabled)
        {
            btn_bottomMost.Enabled = enabled;
            btn_down.Enabled = enabled;
        }

        void SetUpDownButtonsEnabled(bool upButtonEnabled, bool downButtonEnabled)
        {
            SetUpButtonEnabled(upButtonEnabled);
            SetDownButtonEnabled(downButtonEnabled);
        }

        private void lst_values_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_values.Items.Count <= 1)
            {
                SetUpDownButtonsEnabled(false, false);
                if (lst_values.Items.Count == 1)
                    SelectedItemChanged(this, lst_values.SelectedItem);
                return;
            }
            var i = lst_values.SelectedIndex;
            if (i == 0)
                SetUpDownButtonsEnabled(false, true);
            else if (i == lst_values.Items.Count - 1)
                SetUpDownButtonsEnabled(true, false);
            else
                SetUpDownButtonsEnabled(true, true);

            SelectedItemChanged(this, lst_values.SelectedItem);
        }

        private void lst_values_DoubleClick(object sender, EventArgs e)
        {
            var res = ItemDoubleClick(this, lst_values.SelectedIndex, lst_values.SelectedItem);
            if (res != null)
                lst_values.Items[lst_values.SelectedIndex] = res;
        }
    }
}
