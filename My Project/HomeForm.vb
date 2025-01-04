Public Class HomeForm
    Private Sub HomeForm_Load(sender As Object, e As EventArgs)
        akustik_btn_Click(sender, e)
    End Sub


    Private Sub btnclose1_Click(sender As Object, e As EventArgs) Handles btnclose1.Click
        Application.Exit()
    End Sub
    Private Sub akustik_btn_Click(sender As Object, e As EventArgs) Handles akustik_btn.Click

        With akustikform
            .TopLevel = False
            show_panel.Controls.Add(akustikform)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub lespaul_btn_Click(sender As Object, e As EventArgs) Handles lespaul_btn.Click
        With lespaulform
            .TopLevel = False
            show_panel.Controls.Add(lespaulform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub sg_btn_Click(sender As Object, e As EventArgs) Handles sg_btn.Click
        With sgform
            .TopLevel = False
            show_panel.Controls.Add(sgform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub holobody_btn_Click(sender As Object, e As EventArgs) Handles holobody_btn.Click
        With holobodyform
            .TopLevel = False
            show_panel.Controls.Add(holobodyform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub amplifier_btn_Click(sender As Object, e As EventArgs) Handles amplifier_btn.Click
        With amplifierform
            .TopLevel = False
            show_panel.Controls.Add(amplifierform)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub show_panel_Scroll(sender As Object, e As ScrollEventArgs) Handles show_panel.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            show_panel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub effect_btn_Click(sender As Object, e As EventArgs) Handles effect_btn.Click
        With effectform
            .TopLevel = False
            show_panel.Controls.Add(effectform)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub show_panel_Paint(sender As Object, e As PaintEventArgs) Handles show_panel.Paint

    End Sub
End Class