Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim BusNo As Integer = Val(TextBox1.Text)
        Dim Origin As String = Val(TextBox2.Text)
        Dim Destination As String = Val(TextBox4.Text)
        Dim Type As String = Val(ComboBox1.Text)
        Dim Distance As Double = Val(TextBox5.Text)
        If Distance >= 100 Then
            TextBox3.Text = 15 * Distance
            If Distance >= 200 Then
                TextBox3.Text = 20 * Distance
                If Distance >= 300 Then
                    TextBox3.Text = 24 * Distance
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("O")
        ComboBox1.Items.Add("E")
        ComboBox1.Items.Add("L")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        MsgBox("YOU HAVE SELECTED " + ComboBox1.SelectedItem.ToString)
    End Sub


