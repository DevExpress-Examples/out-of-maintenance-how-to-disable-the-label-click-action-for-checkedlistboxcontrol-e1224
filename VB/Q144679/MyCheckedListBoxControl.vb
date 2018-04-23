Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.XtraEditors.ViewInfo

Namespace DXSample
	Public Class MyCheckedListBoxControl
		Inherits CheckedListBoxControl
		Friend allowChangeCheck As Boolean
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function CreateHandler() As ListBoxControlHandler
			Return New MyCheckedListBoxControlHandler(Me)
		End Function

		Protected Overrides Sub OnChangeCheck(ByVal index As Integer)
			If (Not allowChangeCheck) Then
				Return
			End If
			MyBase.OnChangeCheck(index)
		End Sub
	End Class

	Public Class MyCheckedSingleSelectState
		Inherits CheckedListBoxControlHandler.CheckedSingleSelectState
		Public Sub New(ByVal handler As MyCheckedListBoxControlHandler)
			MyBase.New(handler)
		End Sub

		Public Overrides Sub MouseUp(ByVal e As MouseEventArgs)
			Dim fi As FieldInfo = GetType(BaseStyleControl).GetField("viewInfo", BindingFlags.Instance Or BindingFlags.NonPublic)
			Dim viewInfo As CheckedListBoxViewInfo = CType(fi.GetValue(ListBox), CheckedListBoxViewInfo)
			Dim itemInfo As CheckedListBoxViewInfo.CheckedItemInfo = CType(viewInfo.GetItemInfoByPoint(e.Location), CheckedListBoxViewInfo.CheckedItemInfo)
			If itemInfo IsNot Nothing AndAlso itemInfo.CheckArgs.GlyphRect.Contains(e.Location) Then
				CType(ListBox, MyCheckedListBoxControl).allowChangeCheck = True
			End If
			MyBase.MouseUp(e)
			CType(ListBox, MyCheckedListBoxControl).allowChangeCheck = False
		End Sub
	End Class

	Public Class MyCheckedListBoxControlHandler
		Inherits CheckedListBoxControlHandler
		Public Sub New(ByVal control As MyCheckedListBoxControl)
			MyBase.New(control)
		End Sub

		Protected Overrides Function CreateState(ByVal state As HandlerState) As ListBoxControlState
            If state = HandlerState.Unselectable Then
                Return MyBase.CreateState(state)
            End If
			Return New MyCheckedSingleSelectState(Me)
		End Function
	End Class
End Namespace