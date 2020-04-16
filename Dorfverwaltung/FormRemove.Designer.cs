namespace Dorfverwaltung
{
    partial class FormRemove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemove));
            this.checkedListBoxControlRemove = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.simpleButtonRemove = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxControlRemove
            // 
            this.checkedListBoxControlRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxControlRemove.Location = new System.Drawing.Point(-1, 0);
            this.checkedListBoxControlRemove.Name = "checkedListBoxControlRemove";
            this.checkedListBoxControlRemove.Size = new System.Drawing.Size(255, 361);
            this.checkedListBoxControlRemove.TabIndex = 0;
            // 
            // simpleButtonRemove
            // 
            this.simpleButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButtonRemove.Location = new System.Drawing.Point(49, 394);
            this.simpleButtonRemove.Name = "simpleButtonRemove";
            this.simpleButtonRemove.Size = new System.Drawing.Size(157, 49);
            this.simpleButtonRemove.TabIndex = 1;
            this.simpleButtonRemove.Text = "Entfernen";
            this.simpleButtonRemove.Click += new System.EventHandler(this.simpleButtonRemove_Click);
            // 
            // FormRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 473);
            this.Controls.Add(this.simpleButtonRemove);
            this.Controls.Add(this.checkedListBoxControlRemove);
            this.Name = "FormRemove";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControlRemove;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemove;
    }
}