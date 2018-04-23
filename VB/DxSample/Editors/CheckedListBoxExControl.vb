Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace DxSample.Editors
    Public Class CheckedListBoxExControl
        Inherits CheckedListBoxControl

        Private fUseWholeItemToChangeCheckedStateByMouse As Boolean = True
        <DefaultValue(True)> _
        Public Property UseWholeItemToChangeCheckedStateByMouse() As Boolean
            Get
                Return Me.fUseWholeItemToChangeCheckedStateByMouse
            End Get
            Set(ByVal value As Boolean)
                Me.fUseWholeItemToChangeCheckedStateByMouse = value
            End Set
        End Property

        Protected Overrides Function CreateHandler() As ListBoxControlHandler
            Return New CheckedListBoxExControlHandler(Me)
        End Function
    End Class
End Namespace
