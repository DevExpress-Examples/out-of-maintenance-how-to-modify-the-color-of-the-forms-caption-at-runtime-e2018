Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.colorEdit1 = New DevExpress.XtraEditors.ColorEdit()
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			Me.trackBarControl2 = New DevExpress.XtraEditors.TrackBarControl()
			Me.trackBarControl3 = New DevExpress.XtraEditors.TrackBarControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' colorEdit1
			' 
			Me.colorEdit1.EditValue = System.Drawing.Color.Empty
			Me.colorEdit1.Location = New System.Drawing.Point(66, 12)
			Me.colorEdit1.Name = "colorEdit1"
			Me.colorEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEdit1.Size = New System.Drawing.Size(535, 20)
			Me.colorEdit1.TabIndex = 0
'			Me.colorEdit1.EditValueChanged += New System.EventHandler(Me.colorEdit1_EditValueChanged);
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.Location = New System.Drawing.Point(66, 49)
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Properties.Maximum = 255
			Me.trackBarControl1.Size = New System.Drawing.Size(535, 45)
			Me.trackBarControl1.TabIndex = 1
'			Me.trackBarControl1.EditValueChanged += New System.EventHandler(Me.trackBarControl1_EditValueChanged);
			' 
			' trackBarControl2
			' 
			Me.trackBarControl2.Location = New System.Drawing.Point(66, 100)
			Me.trackBarControl2.Name = "trackBarControl2"
			Me.trackBarControl2.Properties.Maximum = 255
			Me.trackBarControl2.Size = New System.Drawing.Size(535, 45)
			Me.trackBarControl2.TabIndex = 2
'			Me.trackBarControl2.EditValueChanged += New System.EventHandler(Me.trackBarControl1_EditValueChanged);
			' 
			' trackBarControl3
			' 
			Me.trackBarControl3.Location = New System.Drawing.Point(66, 151)
			Me.trackBarControl3.Name = "trackBarControl3"
			Me.trackBarControl3.Properties.Maximum = 255
			Me.trackBarControl3.Size = New System.Drawing.Size(535, 45)
			Me.trackBarControl3.TabIndex = 3
'			Me.trackBarControl3.EditValueChanged += New System.EventHandler(Me.trackBarControl1_EditValueChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl1.Appearance.Options.UseFont = True
			Me.labelControl1.Location = New System.Drawing.Point(12, 49)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(15, 25)
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "R"
			' 
			' labelControl2
			' 
			Me.labelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl2.Appearance.Options.UseFont = True
			Me.labelControl2.Location = New System.Drawing.Point(12, 100)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(16, 25)
			Me.labelControl2.TabIndex = 5
			Me.labelControl2.Text = "G"
			' 
			' labelControl3
			' 
			Me.labelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl3.Appearance.Options.UseFont = True
			Me.labelControl3.Location = New System.Drawing.Point(12, 151)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(14, 25)
			Me.labelControl3.TabIndex = 6
			Me.labelControl3.Text = "B"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(634, 206)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.trackBarControl3)
			Me.Controls.Add(Me.trackBarControl2)
			Me.Controls.Add(Me.trackBarControl1)
			Me.Controls.Add(Me.colorEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private WithEvents colorEdit1 As DevExpress.XtraEditors.ColorEdit
		Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
		Private WithEvents trackBarControl2 As DevExpress.XtraEditors.TrackBarControl
		Private WithEvents trackBarControl3 As DevExpress.XtraEditors.TrackBarControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

