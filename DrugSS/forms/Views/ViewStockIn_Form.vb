Public Class ViewStockIn_Form
    Private Sub frmview_stockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT  `TRANSACTIONNUMBER`,concat(`FIRSTNAME`, `LASTNAME`) as 'SUPLIER',`NAME` as 'ITEMNAME', `DESCRIPTION`, `PRICE` `TRANSACTIONDATE`, i.`QTY`, `TOTALPRICE` FROM  `tblsuplier` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`SUPLIERID`=o.`SUPLIERID` and p.TYPE = 'Suplier'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `TRANSACTIONNUMBER`,concat(`FIRSTNAME`, `LASTNAME`) as 'SUPLIER',`NAME` as 'ITEMNAME', `DESCRIPTION`, `PRICE` `TRANSACTIONDATE`, i.`QTY`, `TOTALPRICE` FROM  `tblsuplier` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`SUPLIERID`=o.`SUPLIERID` and p.TYPE = 'Suplier'" &
        " AND (NAME like '%" & txtsearch.Text & "%' OR  TRANSACTIONNUMBER like '%" & txtsearch.Text & "%')"
        reloadDtg(sql, dtglist)
    End Sub
End Class