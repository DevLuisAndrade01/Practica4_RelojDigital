Public Class Form1
    Dim formato As Boolean = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""

        'Este es el formato 24h
        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        horas.Text = Time_mod(0)
        minutes.Text = Time_mod(1)
        segundos.Text = Time_mod(2)
        dias.Text = day_o
        fechas.Text = Date_o
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub fechas_Click(sender As Object, e As EventArgs) Handles fechas.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "blanco" Then
            horas.ForeColor = Color.White
            minutes.ForeColor = Color.White
            dias.ForeColor = Color.White
            Label1.ForeColor = Color.White
            fechas.ForeColor = Color.White
            segundos.ForeColor = Color.White
        ElseIf color_texto = "rojo" Then
            horas.ForeColor = Color.Red
            minutes.ForeColor = Color.Red
            dias.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            fechas.ForeColor = Color.Red
            segundos.ForeColor = Color.Red
        ElseIf color_texto = "azul" Then
            horas.ForeColor = Color.Blue
            minutes.ForeColor = Color.Blue
            dias.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            fechas.ForeColor = Color.Blue
            segundos.ForeColor = Color.Blue
        ElseIf color_texto = "amarillo" Then
            horas.ForeColor = Color.Yellow
            minutes.ForeColor = Color.Yellow
            dias.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            fechas.ForeColor = Color.Yellow
            segundos.ForeColor = Color.Yellow
        ElseIf color_texto = "verde" Then
            horas.ForeColor = Color.ForestGreen
            minutes.ForeColor = Color.ForestGreen
            dias.ForeColor = Color.ForestGreen
            Label1.ForeColor = Color.ForestGreen
            fechas.ForeColor = Color.ForestGreen
            segundos.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub
End Class