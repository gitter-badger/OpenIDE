namespace OpenIDE.Core.Dialogs
{
    partial class NewProjectDialog
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
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            this.radListView1.Location = new System.Drawing.Point(13, 13);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(670, 279);
            this.radListView1.TabIndex = 0;
            this.radListView1.Text = "radListView1";
            this.radListView1.ThemeName = "VisualStudio2012Dark";
            this.radListView1.SelectedItemChanged += new System.EventHandler(this.radListView1_SelectedItemChanged);
            // 
            // radButton1
            // 
            this.radButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.radButton1.Location = new System.Drawing.Point(589, 350);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(94, 24);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "OK";
            this.radButton1.ThemeName = "VisualStudio2012Dark";
            // 
            // radButton2
            // 
            this.radButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.radButton2.Location = new System.Drawing.Point(489, 350);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(94, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Cancel";
            this.radButton2.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 310);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(36, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Name";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(55, 309);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(628, 21);
            this.radTextBox1.TabIndex = 4;
            this.radTextBox1.ThemeName = "VisualStudio2012Dark";
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // NewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 386);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radListView1);
            this.Name = "NewProjectDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
    }
}