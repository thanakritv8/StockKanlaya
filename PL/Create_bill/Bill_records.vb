Public Class Bill_records
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        If MessageBox.Show("คุณต้องการยกเลิกรายการ หรือไม่", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class