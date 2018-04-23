namespace Q144679 {
    partial class Form1 {
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
            this.myCheckedListBoxControl1 = new DXSample.MyCheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.myCheckedListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // myCheckedListBoxControl1
            // 
            this.myCheckedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null)});
            this.myCheckedListBoxControl1.Location = new System.Drawing.Point(46, 45);
            this.myCheckedListBoxControl1.Name = "myCheckedListBoxControl1";
            this.myCheckedListBoxControl1.Size = new System.Drawing.Size(310, 139);
            this.myCheckedListBoxControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 339);
            this.Controls.Add(this.myCheckedListBoxControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myCheckedListBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyCheckedListBoxControl myCheckedListBoxControl1;
    }
}

