Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        ShowPacketButton.BringToFront()
    End Sub

    Private Sub ShowPacketButton_Click(sender As Object, e As EventArgs) Handles ShowPacketButton.Click
        Me.Focus()
        Me.Width = 265
        ShowPacketButton.SendToBack()
        HidePacketButton.BringToFront()
    End Sub

    Private Sub HidePacketButton_Click(sender As Object, e As EventArgs) Handles HidePacketButton.Click
        Me.Focus()
        Me.Width = 184
        HidePacketButton.SendToBack()
        ShowPacketButton.BringToFront()
    End Sub
End Class