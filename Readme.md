<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1224)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q144679/Form1.cs) (VB: [Form1.vb](./VB/Q144679/Form1.vb))
* [MyCheckedListBoxControl.cs](./CS/Q144679/MyCheckedListBoxControl.cs) (VB: [MyCheckedListBoxControl.vb](./VB/Q144679/MyCheckedListBoxControl.vb))
* [Program.cs](./CS/Q144679/Program.cs) (VB: [Program.vb](./VB/Q144679/Program.vb))
<!-- default file list end -->
# How to disable the label-click action for CheckedListBoxControl


By default, the <a href="https://documentation.devexpress.com/#windowsforms/clsDevExpressXtraEditorsCheckedListBoxControltopic">CheckedListBoxControl</a> component allows changing an item's state by clicking any part of the item. In this example, we demonstrate how to create a custom control inherited from CheckedListBoxControl and add the <strong>UseWholeItemToChangeCheckedStateByMouse</strong> option, which specifies the desired behavior.<br /><br />Note: This example uses internal API and the provided approach is not a best practice. The implementation is provided only for the single selection mode.

<br/>


