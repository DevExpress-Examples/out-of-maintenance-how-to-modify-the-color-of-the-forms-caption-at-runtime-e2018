Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Shared Function GetImage(ByVal image As Image, ByVal color As Color) As Image
			Dim b As New Bitmap(image.Width, image.Height)
			Dim g As Graphics = Graphics.FromImage(b)
			g.FillRectangle(New SolidBrush(color), New Rectangle(New Point(0, 0), image.Size))
			g.Dispose()
			Return b
		End Function

		Private Sub SetElementColor(ByVal elementName As String, ByVal c As Color)
			Dim currentSkin As Skin = FormSkins.GetSkin(defaultLookAndFeel1.LookAndFeel)
			Dim element As SkinElement = currentSkin(elementName)
			element.Image.SetImage(GetImage(element.Image.Image, c), Color.Transparent)
		End Sub

		Private Sub ChangeFormElements(ByVal c As Color)
			SetElementColor(FormSkins.SkinFormCaption, c)
			SetElementColor(FormSkins.SkinFormFrameBottom, c)
			SetElementColor(FormSkins.SkinFormFrameLeft, c)
			SetElementColor(FormSkins.SkinFormFrameRight, c)
		End Sub

		Private Sub ChangeFormColor()
			ChangeFormElements(colorEdit1.Color)
			LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
		End Sub

		Private Sub colorEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorEdit1.EditValueChanged
			ChangeFormColor()
			ColorToValues(colorEdit1.Color)
		End Sub


		Private Function ValuesToColor() As Color
			Return Color.FromArgb(trackBarControl1.Value, trackBarControl2.Value, trackBarControl3.Value)
		End Function

		Private Sub ColorToValues(ByVal c As Color)
			trackBarControl1.Value = c.R
			trackBarControl2.Value = c.G
			trackBarControl3.Value = c.B
		End Sub

		Private Sub trackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl1.EditValueChanged, trackBarControl2.EditValueChanged, trackBarControl3.EditValueChanged
			Dim c As Color = ValuesToColor()
			colorEdit1.Color = c
		End Sub
	End Class
End Namespace