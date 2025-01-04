Imports System.Configuration

Public Class akustikform
    Private belanja_panel As Object

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub akustikform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_CursorChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ' Membuka form belanjaform
        Dim belanjaform As New belanjaform()

        ' Menutup form saat ini (adminform)
        Me.Hide()

        ' Menampilkan form baru
        belanjaform.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Membuka form belanjaform
        Dim belanjaform As New belanjaform()

        ' Menutup form saat ini (adminform)
        Me.Hide()

        ' Menampilkan form baru
        belanjaform.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Membuka form belanjaform
        Dim belanjaform As New belanjaform()

        ' Menutup form saat ini (adminform)
        Me.Hide()

        ' Menampilkan form baru
        belanjaform.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Membuka form belanjaform
        Dim belanjaform As New belanjaform()

        ' Menutup form saat ini (adminform)
        Me.Hide()

        ' Menampilkan form baru
        belanjaform.Show()
    End Sub
End Class