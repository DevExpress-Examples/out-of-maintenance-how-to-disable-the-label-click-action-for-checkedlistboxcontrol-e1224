Imports System
Imports System.Linq
Imports DevExpress.XtraEditors
Imports System.Collections.Generic

Namespace DxSample
    Partial Public Class MainForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub chkUseWholeItemToChangeCheckStateByMouse_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkUseWholeItemToChangeCheckStateByMouse.CheckedChanged
            Me.CheckedListBoxControl.UseWholeItemToChangeCheckedStateByMouse = Me.chkUseWholeItemToChangeCheckStateByMouse.Checked
        End Sub
    End Class
End Namespace
