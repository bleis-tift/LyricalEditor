using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using bleistift.LyricalEditor.Options.Ui;
using Microsoft.VisualStudio.Shell;

namespace bleistift.LyricalEditor.Options
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("13B2329A-8B73-480D-B134-A02C0D00101B")]
    public class GlobalConfigs : DialogPage
    {
        public string DetailsStr { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected override IWin32Window Window
        {
            get
            {
                var form = new GlobalConfigsForm(this);
                return form;
            }
        }
    }
}
