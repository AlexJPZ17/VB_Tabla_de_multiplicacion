Public Class Form1
    Public Sub TablaMultiplicar()
        Dim tabla As Integer

        If Trim(TextBox_tabla.Text) = "" Then
            MessageBox.Show(" Iserte el valor de la tabla a Multiplicar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListBox_mostrar.Items.Clear()
            TextBox_tabla.Focus()
        Else
            tabla = Integer.Parse(TextBox_tabla.Text)
            ListBox_mostrar.Items.Clear()
            For contador = 1 To 10
                ListBox_mostrar.Items.Add(tabla & " X " & contador & " = " & tabla * contador)
            Next

        End If

    End Sub

    Private Sub Button_run_Click(sender As Object, e As EventArgs) Handles Button_run.Click
        TablaMultiplicar()
        TextBox_tabla.Text = ""
    End Sub

    Private Sub Button_clean_Click(sender As Object, e As EventArgs) Handles Button_clean.Click
        ListBox_mostrar.Items.Clear()
        TextBox_tabla.Text = ""
    End Sub
End Class
