Imports Microsoft.VisualBasic
Imports System
Namespace Q144679
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myCheckedListBoxControl1 = New DXSample.MyCheckedListBoxControl()
			CType(Me.myCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myCheckedListBoxControl1
			' 
			Me.myCheckedListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() { New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing)})
			Me.myCheckedListBoxControl1.Location = New System.Drawing.Point(46, 45)
			Me.myCheckedListBoxControl1.Name = "myCheckedListBoxControl1"
			Me.myCheckedListBoxControl1.Size = New System.Drawing.Size(310, 139)
			Me.myCheckedListBoxControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(427, 339)
			Me.Controls.Add(Me.myCheckedListBoxControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myCheckedListBoxControl1 As DXSample.MyCheckedListBoxControl
	End Class
End Namespace

