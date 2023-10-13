Imports System.Net.Mime.MediaTypeNames
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim op1 As Double
    Dim op2 As Double
    Dim op As Char
    Dim resultado As Double

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        txtpantalla.Text &= 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtpantalla.Text &= 2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtpantalla.Text &= 3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtpantalla.Text &= 4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtpantalla.Text &= 5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtpantalla.Text &= 6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtpantalla.Text &= 7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtpantalla.Text &= 8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtpantalla.Text &= 9
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtpantalla.Text &= 0
    End Sub

    Private Sub RealizaroOperacion(operador As String)
        'realiza la operacion [por medio del operador





    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        Dim cadena = txtpantalla.Text.Trim()
        Dim Elementosdecadena() As String = cadena.Split(op)
        If (Elementosdecadena.Length > 1 And Elementosdecadena(1) <> "") Then
            Dim valorOperacion As String = Elementosdecadena(1).Trim
            op2 = valorOperacion
            RealizaroOperacion(op)
        Else ' No hacer nada 
        End If

        Select Case (op)
            Case "+"
                resultado = op1 + op2

            Case "-"
                resultado = op1 - op2

            Case "*"
                resultado = op1 * op2

            Case "/"
                resultado = op1 / op2

            Case "^"
                resultado = op1 ^ 2


        End Select
        txtpantalla.Text = resultado
        MsgBox("El resultado de la operacion: " + txtpantalla.Text + " Es de: " + CStr(resultado))

    End Sub

    Private Sub btnsumar_Click(sender As Object, e As EventArgs) Handles btnsumar.Click
        op1 = txtpantalla.Text
        txtpantalla.Text &= "+"
        op = "+"
    End Sub

    Private Sub btnrestar_Click(sender As Object, e As EventArgs) Handles btnrestar.Click
        op1 = txtpantalla.Text
        txtpantalla.Text &= "-"
        op = "-"
    End Sub

    Private Sub btnmultiplicar_Click(sender As Object, e As EventArgs) Handles btnmultiplicar.Click
        op1 = txtpantalla.Text
        txtpantalla.Text &= " * "
        op = "*"
    End Sub
    Private Sub btndividir_Click(sender As Object, e As EventArgs) Handles btndividir.Click
        op1 = txtpantalla.Text
        txtpantalla.Text &= " / "
        op = "/"
    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtpantalla.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim texto As String = txtpantalla.Text

        txtpantalla.Text = txtpantalla.Text & ","

    End Sub

    Private Sub btnalcuadrado_Click(sender As Object, e As EventArgs) Handles btnalcuadrado.Click
        op1 = txtpantalla.Text
        txtpantalla.Text &= "^2"
        op = "^2"
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If (txtpantalla.Text.Length > 0) Then

            txtpantalla.Text = txtpantalla.Text.Substring(0, txtpantalla.Text.Length - 1)
        End If

    End Sub
End Class
