<!-- default file list -->
*Files to look at*:

* [CheckedListBoxExControl.cs](./CS/DxSample/Editors/CheckedListBoxExControl.cs) (VB: [CheckedListBoxExControl.vb](./VB/DxSample/Editors/CheckedListBoxExControl.vb))
* [CheckedListBoxExControlHandler.cs](./CS/DxSample/Editors/CheckedListBoxExControlHandler.cs) (VB: [CheckedListBoxExControlHandler.vb](./VB/DxSample/Editors/CheckedListBoxExControlHandler.vb))
* **[MainForm.cs](./CS/DxSample/MainForm.cs) (VB: [MainForm.vb](./VB/DxSample/MainForm.vb))**
<!-- default file list end -->
# How to disable the label-click action for CheckedListBoxControl


By default, the <a href="https://documentation.devexpress.com/#windowsforms/clsDevExpressXtraEditorsCheckedListBoxControltopic">CheckedListBoxControl</a> component allows changing an item's state by clicking any part of the item. In this example, we demonstrate how to create a custom control inherited from CheckedListBoxControl and add the <strong>UseWholeItemToChangeCheckedStateByMouse</strong> option, which specifies the desired behavior.<br /><br />Note: This example uses internal API and the provided approach is not a best practice. The implementation is provided only for the single selection mode.

<br/>


