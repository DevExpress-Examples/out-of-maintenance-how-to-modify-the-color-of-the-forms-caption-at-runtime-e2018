namespace WindowsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.colorEdit1 = new DevExpress.XtraEditors.ColorEdit();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.trackBarControl2 = new DevExpress.XtraEditors.TrackBarControl();
            this.trackBarControl3 = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colorEdit1
            // 
            this.colorEdit1.EditValue = System.Drawing.Color.Empty;
            this.colorEdit1.Location = new System.Drawing.Point(66, 12);
            this.colorEdit1.Name = "colorEdit1";
            this.colorEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit1.Size = new System.Drawing.Size(535, 20);
            this.colorEdit1.TabIndex = 0;
            this.colorEdit1.EditValueChanged += new System.EventHandler(this.colorEdit1_EditValueChanged);
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.Location = new System.Drawing.Point(66, 49);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.Maximum = 255;
            this.trackBarControl1.Size = new System.Drawing.Size(535, 45);
            this.trackBarControl1.TabIndex = 1;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // trackBarControl2
            // 
            this.trackBarControl2.Location = new System.Drawing.Point(66, 100);
            this.trackBarControl2.Name = "trackBarControl2";
            this.trackBarControl2.Properties.Maximum = 255;
            this.trackBarControl2.Size = new System.Drawing.Size(535, 45);
            this.trackBarControl2.TabIndex = 2;
            this.trackBarControl2.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // trackBarControl3
            // 
            this.trackBarControl3.Location = new System.Drawing.Point(66, 151);
            this.trackBarControl3.Name = "trackBarControl3";
            this.trackBarControl3.Properties.Maximum = 255;
            this.trackBarControl3.Size = new System.Drawing.Size(535, 45);
            this.trackBarControl3.TabIndex = 3;
            this.trackBarControl3.EditValueChanged += new System.EventHandler(this.trackBarControl1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "R";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(16, 25);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "G";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 206);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.trackBarControl3);
            this.Controls.Add(this.trackBarControl2);
            this.Controls.Add(this.trackBarControl1);
            this.Controls.Add(this.colorEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.ColorEdit colorEdit1;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl2;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

