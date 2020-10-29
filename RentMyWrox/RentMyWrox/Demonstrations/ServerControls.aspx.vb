Public Class ServerControls
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Protected Sub submitButton_Click(sender As Object, e As EventArgs)

        displayLabel.Text = demoToolBox.Text

        demoToolBox.Text = String.Empty



    End Sub
End Class