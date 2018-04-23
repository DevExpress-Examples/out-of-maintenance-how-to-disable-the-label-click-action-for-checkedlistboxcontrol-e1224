using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors.ViewInfo;

namespace DXSample {
    public class MyCheckedListBoxControl : CheckedListBoxControl {
        internal bool allowChangeCheck;
        public MyCheckedListBoxControl() : base() { }

        protected override ListBoxControlHandler CreateHandler() {
            return new MyCheckedListBoxControlHandler(this);
        }

        protected override void OnChangeCheck(int index) {
            if (!allowChangeCheck) return;
            base.OnChangeCheck(index);
        }
    }

    public class MyCheckedSingleSelectState : CheckedListBoxControlHandler.CheckedSingleSelectState {
        public MyCheckedSingleSelectState(MyCheckedListBoxControlHandler handler) : base(handler) { }

        public override void MouseUp(MouseEventArgs e) {
            FieldInfo fi = typeof(BaseStyleControl).GetField("viewInfo", 
                BindingFlags.Instance | BindingFlags.NonPublic);
            CheckedListBoxViewInfo viewInfo = (CheckedListBoxViewInfo)fi.GetValue(ListBox);
            CheckedListBoxViewInfo.CheckedItemInfo itemInfo = (CheckedListBoxViewInfo.CheckedItemInfo)viewInfo.GetItemInfoByPoint(e.Location);
            if (itemInfo != null && itemInfo.CheckArgs.GlyphRect.Contains(e.Location))
                ((MyCheckedListBoxControl)ListBox).allowChangeCheck = true;
            base.MouseUp(e);
            ((MyCheckedListBoxControl)ListBox).allowChangeCheck = false;
        }
    }

    public class MyCheckedListBoxControlHandler : CheckedListBoxControlHandler {
        public MyCheckedListBoxControlHandler(MyCheckedListBoxControl control) : base(control) { }

        protected override ListBoxControlState CreateState(HandlerState state) {
            if (state == HandlerState.Unselectable)
                return base.CreateState(state);
            return new MyCheckedSingleSelectState(this);
        }
    }
}