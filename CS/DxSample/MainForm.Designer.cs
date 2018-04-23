namespace DxSample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CheckedListBoxControl = new DxSample.Editors.CheckedListBoxExControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkUseWholeItemToChangeCheckStateByMouse = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkUseWholeItemToChangeCheckStateByMouse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckedListBoxControl
            // 
            this.CheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckedListBoxControl.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("January", "January"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("February", "February"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("March", "March"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("April", "April"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("May", "May"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("June", "June"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("July", "July"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("August", "August"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("September", "September"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("October", "October"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("November", "November"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("December", "December")});
            this.CheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.CheckedListBoxControl.Name = "CheckedListBoxControl";
            this.CheckedListBoxControl.Size = new System.Drawing.Size(482, 222);
            this.CheckedListBoxControl.TabIndex = 0;
            this.CheckedListBoxControl.UseWholeItemToChangeCheckedStateByMouse = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkUseWholeItemToChangeCheckStateByMouse);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 222);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(482, 31);
            this.panelControl1.TabIndex = 1;
            // 
            // chkUseWholeItemToChangeCheckStateByMouse
            // 
            this.chkUseWholeItemToChangeCheckStateByMouse.Location = new System.Drawing.Point(5, 5);
            this.chkUseWholeItemToChangeCheckStateByMouse.Name = "chkUseWholeItemToChangeCheckStateByMouse";
            this.chkUseWholeItemToChangeCheckStateByMouse.Properties.Caption = "Use Whole Item To Change Check State by Mouse";
            this.chkUseWholeItemToChangeCheckStateByMouse.Size = new System.Drawing.Size(313, 20);
            this.chkUseWholeItemToChangeCheckStateByMouse.TabIndex = 0;
            this.chkUseWholeItemToChangeCheckStateByMouse.CheckedChanged += new System.EventHandler(this.chkUseWholeItemToChangeCheckStateByMouse_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.CheckedListBoxControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "MainForm";
            this.Text = "Dx Sample";
            ((System.ComponentModel.ISupportInitialize)(this.CheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkUseWholeItemToChangeCheckStateByMouse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DxSample.Editors.CheckedListBoxExControl CheckedListBoxControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit chkUseWholeItemToChangeCheckStateByMouse;
    }
}

