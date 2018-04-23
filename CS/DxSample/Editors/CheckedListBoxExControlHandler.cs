using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace DxSample.Editors {
    public class CheckedListBoxExControlHandler : CheckedListBoxControlHandler {
        public CheckedListBoxExControlHandler(CheckedListBoxExControl control) : base(control) { }

        public new CheckedListBoxExControl OwnerControl {
            get { return (CheckedListBoxExControl)base.OwnerControl; }
        }

        protected override ListBoxControlHandler.ListBoxControlState CreateState(ListBoxControlHandler.HandlerState state) {
            if (state == HandlerState.Default || state == HandlerState.SingleSelect)
                return new CheckedListBoxExControlHandler.CheckedSingleSelectState(this);
            return base.CreateState(state);
        }

        private new class CheckedSingleSelectState : CheckedListBoxControlHandler.CheckedSingleSelectState {
            public CheckedSingleSelectState(CheckedListBoxExControlHandler handler) : base(handler) { }

            protected new CheckedListBoxExControl ListBox {
                get { return (CheckedListBoxExControl)base.ListBox; }
            }

            protected override bool CanChangePressState(Point location, int selIndex, bool checkOnClick) {
                bool canChangePressState = true;
                if (!this.ListBox.UseWholeItemToChangeCheckedStateByMouse) {
                    CheckedListBoxViewInfo.CheckedItemInfo item = this.ViewInfo.GetItemByIndex(this.ViewInfo.HotItemIndex);
                    canChangePressState = item.CheckArgs.Bounds.Contains(location);
                }
                return canChangePressState && base.CanChangePressState(location, selIndex, checkOnClick);
            }
        }
    }
}
