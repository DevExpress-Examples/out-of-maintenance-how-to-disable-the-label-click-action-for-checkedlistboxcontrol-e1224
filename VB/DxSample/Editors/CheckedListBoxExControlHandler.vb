Imports DevExpress.XtraEditors
Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace DxSample.Editors
    Public Class CheckedListBoxExControlHandler
        Inherits CheckedListBoxControlHandler

        Public Sub New(ByVal control As CheckedListBoxExControl)
            MyBase.New(control)
        End Sub

        Public Shadows ReadOnly Property OwnerControl() As CheckedListBoxExControl
            Get
                Return CType(MyBase.OwnerControl, CheckedListBoxExControl)
            End Get
        End Property

        Protected Overrides Function CreateState(ByVal state As ListBoxControlHandler.HandlerState) As ListBoxControlHandler.ListBoxControlState
            If state = HandlerState.Default OrElse state = HandlerState.SingleSelect Then
                Return New CheckedListBoxExControlHandler.CheckedSingleSelectState(Me)
            End If
            Return MyBase.CreateState(state)
        End Function

        Private Shadows Class CheckedSingleSelectState
            Inherits CheckedListBoxControlHandler.CheckedSingleSelectState

            Public Sub New(ByVal handler As CheckedListBoxExControlHandler)
                MyBase.New(handler)
            End Sub

            Protected Shadows ReadOnly Property ListBox() As CheckedListBoxExControl
                Get
                    Return CType(MyBase.ListBox, CheckedListBoxExControl)
                End Get
            End Property

            Protected Overrides Function CanChangePressState(ByVal location As Point, ByVal selIndex As Integer, ByVal checkOnClick As Boolean) As Boolean

                Dim canChangePressState_Renamed As Boolean = True
                If Not Me.ListBox.UseWholeItemToChangeCheckedStateByMouse Then
                    Dim item As CheckedListBoxViewInfo.CheckedItemInfo = Me.ViewInfo.GetItemByIndex(Me.ViewInfo.HotItemIndex)
                    canChangePressState_Renamed = item.CheckArgs.Bounds.Contains(location)
                End If
                Return canChangePressState_Renamed AndAlso MyBase.CanChangePressState(location, selIndex, checkOnClick)
            End Function
        End Class
    End Class
End Namespace
