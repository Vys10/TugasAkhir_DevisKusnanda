Public Class halamanform
    Private Sub halamanform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclosed_Click(sender As Object, e As EventArgs) Handles btnclosed.Click
        Application.Exit()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnakustik_Click(sender As Object, e As EventArgs) Handles btnakustik.Click
        With akustikform
            .TopLevel = False
            Panel2.Controls.Add(akustikform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnes_Click(sender As Object, e As EventArgs) Handles btnes.Click
        With holobodyform
            .TopLevel = False
            Panel2.Controls.Add(holobodyform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnsg_Click(sender As Object, e As EventArgs) Handles btnsg.Click
        With sgform
            .TopLevel = False
            Panel2.Controls.Add(sgform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnlespaul_Click(sender As Object, e As EventArgs) Handles btnlespaul.Click
        With lespaulform
            .TopLevel = False
            Panel2.Controls.Add(lespaulform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnamplifier_Click(sender As Object, e As EventArgs) Handles btnamplifier.Click
        With amplifierform
            .TopLevel = False
            Panel2.Controls.Add(amplifierform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btneffect_Click(sender As Object, e As EventArgs) Handles btneffect.Click
        With effectform
            .TopLevel = False
            Panel2.Controls.Add(effectform)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class