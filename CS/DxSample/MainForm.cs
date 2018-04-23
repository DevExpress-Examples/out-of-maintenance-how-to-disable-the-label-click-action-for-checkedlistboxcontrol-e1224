using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace DxSample {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void chkUseWholeItemToChangeCheckStateByMouse_CheckedChanged(object sender, EventArgs e) {
            this.CheckedListBoxControl.UseWholeItemToChangeCheckedStateByMouse = this.chkUseWholeItemToChangeCheckStateByMouse.Checked;
        }
    }
}
