Public Class frm_report
    Private Sub btnListStockin_Click(sender As Object, e As EventArgs) Handles btnListStockin.Click
        If cbooption.Text = "Daily Report" Then
            sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`,TRANSACTIONDATE FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn' AND DATE(`TRANSACTIONDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`,TRANSACTIONDATE FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn' AND WEEKDAY(`TRANSACTIONDATE`) >=0 AND WEEKDAY(`TRANSACTIONDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`,TRANSACTIONDATE FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn' AND MONTH(`TRANSACTIONDATE`)=MONTH(CURDATE())"
        ElseIf cbooption.Text = "Annual Report" Then
            sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTy`, `UNIT`,TRANSACTIONDATE FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn' AND YEAR(`TRANSACTIONDATE`)=YEAR(NOW())"
        End If

        reports(sql, "itemlist", CrystalReportViewer1)
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        If cbooption.Text = "Daily Report" Then
            sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " &
                          " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" &
                          " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND DATE(`TRANSACTIONDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " &
                " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" &
                " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND WEEKDAY(`TRANSACTIONDATE`) >=0 AND WEEKDAY(`TRANSACTIONDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " &
                " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" &
                " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND MONTH(`TRANSACTIONDATE`)=MONTH(CURDATE())"
        End If
        reports(sql, "soldList", CrystalReportViewer1)
    End Sub

    Private Sub btnStockReturn_Click(sender As Object, e As EventArgs) Handles btnStockReturn.Click
        If cbooption.Text = "Daily Report" Then
            sql = "SELECT `STOCKRETURNNUMBER`,`NAME` AS 'Item', `RETURNDATE`, r.`QTY` as 'Quantity' FROM `tblstock_return` r,`tblitems` i WHERE r.`ITEMID`=i.`ITEMID` AND DATE(`RETURNDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT `STOCKRETURNNUMBER`,`NAME` AS 'Item', `RETURNDATE`, r.`QTY` as 'Quantity' FROM `tblstock_return` r,`tblitems` i WHERE r.`ITEMID`=i.`ITEMID` AND WEEKDAY(`RETURNDATE`) >=0 AND WEEKDAY(`RETURNDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT `STOCKRETURNNUMBER`,`NAME` AS 'Item', `RETURNDATE`, r.`QTY` as 'Quantity' FROM `tblstock_return` r,`tblitems` i WHERE r.`ITEMID`=i.`ITEMID` AND MONTH(`RETURNDATE`)=MONTH(CURDATE())"
        End If
        reports(sql, "returnList", CrystalReportViewer1)
    End Sub

    Private Sub dptfrom_ValueChanged(sender As Object, e As EventArgs) Handles dptfrom.ValueChanged
        sql = "SELECT  `NAME` ,  `DESCRIPTION` ,  `TYPE` , i.`QTY` AS  'Stock-In',  `UNIT` , o.`QTY` AS  'Stock-Out',  `TRANSACTIONDATE` ,  `REMARKS` " &
               "FROM  `tblitems` i" &
               " LEFT JOIN  `tblstock_in_out` o ON i.`ITEMID` = o.`ITEMID` " &
               " AND REMARKS =  'StockOut' and TRANSACTIONDATE between '" & Format(dptfrom.Value, "yyyy-MM-dd") & "' and '" & Format(dtpto.Value, "yyyy-MM-dd") & "'"
        reports(sql, "inventory", CrystalReportViewer1)
    End Sub

    Private Sub btnitemlisat_Click(sender As Object, e As EventArgs) Handles btnitemlisat.Click
        sql = "SELECT * FROM `tblitems`"
        reports(sql, "allitems", CrystalReportViewer1)
    End Sub

    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class