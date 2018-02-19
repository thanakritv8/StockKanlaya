Imports BLL
Public Class frm_lesson
    Dim IdOrder As String
    Dim PriceTotal As Double
    Public Property IdBill As String
        Get
            Return IdOrder
        End Get
        Set(value As String)
            IdOrder = value
        End Set
    End Property
    Public Property Price As Double
        Get
            Return PriceTotal
        End Get
        Set(value As Double)
            PriceTotal = value
        End Set
    End Property

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()
    End Sub

    Private Sub frm_lesson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbIdOrder.Text = "บิลสั่งซื้อเลขที่ " & IdOrder
        lbTotal.Text = PriceTotal
    End Sub

    Private Sub ConfigDGV(ByVal Start As Integer)
        If DGV.ColumnCount > 0 Then
            If Start > CInt(numLesson.Text - 1) Then
                For i As Integer = Start To CInt(numLesson.Text + 1) Step -1
                    DGV.Rows.RemoveAt(i - 1)
                Next

            Else
                For i As Integer = Start To CInt(numLesson.Text - 1)
                    DGV.Rows.Add("แบ่งจ่ายครั้งที่ " & i + 1, "ปี-เดือน-วัน", "")
                Next
            End If
        End If
    End Sub

    Private Sub numLesson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numLesson.SelectedIndexChanged
        Select Case Asc(numLesson.Text)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
            Case Else
                MessageBox.Show("สามารถกดได้แค่ตัวเลข")
                numLesson.Text = 2
        End Select
        Dim Start As Integer = DGV.Rows.Count
        ConfigDGV(Start)
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim BLL_Bill As BLL_Create_Bill = New BLL_Create_Bill
        BLL_Bill.SetDGVLesson(DGV)
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class