Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ListBox1.Items.Add("Redmi")


        Dim myitem
        myitem = InputBox("enter your favourite phone")
        ListBox1.Items.Add(myitem)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove("iPhone")

        Dim myitems2 = InputBox("enter the name of the phone you want to remove")
        myitems2.Remove(myitems2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub
End Class
