using DevExpress.XtraEditors;
using System.ComponentModel;

namespace DxSample.Editors {
    public class CheckedListBoxExControl :CheckedListBoxControl {
        private bool fUseWholeItemToChangeCheckedStateByMouse = true;
        [DefaultValue(true)]
        public bool UseWholeItemToChangeCheckedStateByMouse {
            get { return this.fUseWholeItemToChangeCheckedStateByMouse; }
            set { this.fUseWholeItemToChangeCheckedStateByMouse = value; }
        }

        protected override ListBoxControlHandler CreateHandler() {
            return new CheckedListBoxExControlHandler(this);
        }
    }
}
