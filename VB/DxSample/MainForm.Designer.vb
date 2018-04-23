Namespace DxSample
    Partial Public Class MainForm
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
            Me.CheckedListBoxControl = New DxSample.Editors.CheckedListBoxExControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.chkUseWholeItemToChangeCheckStateByMouse = New DevExpress.XtraEditors.CheckEdit()
            DirectCast(Me.CheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.chkUseWholeItemToChangeCheckStateByMouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' CheckedListBoxControl
            ' 
            Me.CheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CheckedListBoxControl.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() { _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("January", "January"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("February", "February"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("March", "March"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("April", "April"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("May", "May"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("June", "June"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("July", "July"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("August", "August"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("September", "September"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("October", "October"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("November", "November"), _
                New DevExpress.XtraEditors.Controls.CheckedListBoxItem("December", "December") _
            })
            Me.CheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
            Me.CheckedListBoxControl.Name = "CheckedListBoxControl"
            Me.CheckedListBoxControl.Size = New System.Drawing.Size(482, 222)
            Me.CheckedListBoxControl.TabIndex = 0
            Me.CheckedListBoxControl.UseWholeItemToChangeCheckedStateByMouse = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.chkUseWholeItemToChangeCheckStateByMouse)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 222)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(482, 31)
            Me.panelControl1.TabIndex = 1
            ' 
            ' chkUseWholeItemToChangeCheckStateByMouse
            ' 
            Me.chkUseWholeItemToChangeCheckStateByMouse.Location = New System.Drawing.Point(5, 5)
            Me.chkUseWholeItemToChangeCheckStateByMouse.Name = "chkUseWholeItemToChangeCheckStateByMouse"
            Me.chkUseWholeItemToChangeCheckStateByMouse.Properties.Caption = "Use Whole Item To Change Check State by Mouse"
            Me.chkUseWholeItemToChangeCheckStateByMouse.Size = New System.Drawing.Size(313, 20)
            Me.chkUseWholeItemToChangeCheckStateByMouse.TabIndex = 0
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(482, 253)
            Me.Controls.Add(Me.CheckedListBoxControl)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "MainForm"
            Me.Text = "Dx Sample"
            DirectCast(Me.CheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.chkUseWholeItemToChangeCheckStateByMouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private CheckedListBoxControl As DxSample.Editors.CheckedListBoxExControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents chkUseWholeItemToChangeCheckStateByMouse As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace

