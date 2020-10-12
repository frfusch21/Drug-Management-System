Public Class ViewReturn_Form
    Private Sub frmview_return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT concat(`FIRSTNAME`, `LASTNAME`) as 'FULLNAME',`STOCKRETURNNUMBER` as 'TRANSACTION#',`NAME` as 'ITEMNAME', `RETURNDATE` FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ITEMID`=r.`ITEMID` and r.`OWNER_CUS_ID` =p.`SUPLIERCUSTOMERID` and p.TYPE not in ('Suplier')"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT concat(`FIRSTNAME`, `LASTNAME`) as 'FULLNAME',`STOCKRETURNNUMBER` as 'TRANSACTION#',`NAME` as 'ITEMNAME', `RETURNDATE` FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ITEMID`=r.`ITEMID` and r.`OWNER_CUS_ID` =p.`SUPLIERCUSTOMERID` and p.TYPE not in ('Suplier')" &
        " AND STOCKRETURNNUMBER LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub
End Class