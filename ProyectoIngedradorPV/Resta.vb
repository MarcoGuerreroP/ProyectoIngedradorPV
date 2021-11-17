Public Class Resta

    'Resta de dos numeros'

    Private Sub Resta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label8.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Restar button'
        Dim numero1, numero2 As Double
        numero1 = Val(Me.TextBox1.Text)
        numero2 = Val(Me.TextBox2.Text)

        Me.Label8.Visible = False

        If numero1 <> 0 And numero2 <> 0 Then
            Me.Label5.Text = numero1 - numero2
        Else
            Me.Label8.Visible = True
        End If

    End Sub
End Class