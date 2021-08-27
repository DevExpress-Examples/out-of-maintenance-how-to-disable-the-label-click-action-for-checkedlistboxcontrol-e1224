<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620524/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1224)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CheckedListBoxExControl.cs](./CS/DxSample/Editors/CheckedListBoxExControl.cs) (VB: [CheckedListBoxExControl.vb](./VB/DxSample/Editors/CheckedListBoxExControl.vb))
* [CheckedListBoxExControlHandler.cs](./CS/DxSample/Editors/CheckedListBoxExControlHandler.cs) (VB: [CheckedListBoxExControlHandler.vb](./VB/DxSample/Editors/CheckedListBoxExControlHandler.vb))
* **[MainForm.cs](./CS/DxSample/MainForm.cs) (VB: [MainForm.vb](./VB/DxSample/MainForm.vb))**
<!-- default file list end -->
# How to disable the label-click action for CheckedListBoxControl


By default, the <a href="https://documentation.devexpress.com/#windowsforms/clsDevExpressXtraEditorsCheckedListBoxControltopic">CheckedListBoxControl</a> component allows changing an item's state by clicking any part of the item. In this example, we demonstrate how to create a custom control inherited from CheckedListBoxControl and add the <strong>UseWholeItemToChangeCheckedStateByMouse</strong> option, which specifies the desired behavior.<br /><br />Note: This example uses internal API and the provided approach is not a best practice. The implementation is provided only for the single selection mode.

<br/>


