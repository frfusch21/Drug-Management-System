Public Class ViewCustomer_Form
    Private Sub frmview_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT  `SUPLIERCUSTOMERID` as 'CUSTOMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE  `TYPE` ='Customer'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `SUPLIERCUSTOMERID` as 'CUSTOMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE  `TYPE` ='Customer' AND  SUPLIERCUSTOMERID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub
    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            Transaction_Form.txt_cusid.Text = dtglist.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class