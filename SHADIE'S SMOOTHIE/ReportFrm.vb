Imports MySql.Data.MySqlClient

Public Class ReportFrm
    Private Sub ReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load







    End Sub

    Private Sub ComboBoxRpt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRpt.SelectedIndexChanged
        Dim con As MySqlConnection = New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT SUM(`Profit`), COUNT(*) FROM `vbnet_mysql_sale_table` WHERE YEAR(`Date_Time`)='2000'", con)
        Dim cmd2 As MySqlCommand = New MySqlCommand("SELECT * FROM `vbnet_mysql_sale_table` WHERE YEAR(`Date_Time`)='2000'", con)

        If ComboBoxRpt.Text = "Monthly" Then
            cmd = New MySqlCommand("SELECT SUM(`Profit`), COUNT(*) FROM `vbnet_mysql_sale_table` WHERE MONTH(`Date_Time`)=MONTH(@selectedstart) ", con)
            cmd.Parameters.Add("@selectedstart", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().Start
            cmd2 = New MySqlCommand("SELECT * FROM `vbnet_mysql_sale_table` WHERE MONTH(`Date_Time`)=MONTH(@selectedstart) ", con)
            cmd2.Parameters.Add("@selectedstart", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().Start


        ElseIf ComboBoxRpt.Text = "Daily" Then
            cmd = New MySqlCommand("SELECT SUM(`Profit`), COUNT(*) FROM `vbnet_mysql_sale_table` WHERE DAY(`Date_Time`) BETWEEN DAY(@selectedstart) AND DAY(@selectedend) ", con)
            cmd.Parameters.Add("@selectedstart", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().Start
            cmd.Parameters.Add("@selectedend", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().End
            cmd2 = New MySqlCommand("SELECT * FROM `vbnet_mysql_sale_table` WHERE DAY(`Date_Time`) BETWEEN DAY(@selectedstart) AND DAY(@selectedend) ", con)
            cmd2.Parameters.Add("@selectedstart", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().Start
            cmd2.Parameters.Add("@selectedend", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().End

        End If


        con.Open()
        Dim read As MySqlDataReader = cmd.ExecuteReader
        read.Read()
        Try

            ProfitTxt.Text = read.GetString(0)
            NoSalesTxt.Text = read.GetString(1)

        Catch
            ProfitTxt.Text = 0
            NoSalesTxt.Text = 0
        End Try
        con.Close()
        con.Open()
        Dim DT As New DataTable
        DT.Load(cmd2.ExecuteReader)

        DataGridRptView.DataSource = DT
        con.Close()

    End Sub

    Private Sub RptCalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles RptCalender.DateChanged
        Dim con As MySqlConnection = New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT SUM(`Profit`), COUNT(*) FROM `vbnet_mysql_sale_table` WHERE YEAR(`Date_Time`)='2000'", con)
        Dim cmd2 As MySqlCommand = New MySqlCommand("SELECT * FROM `vbnet_mysql_sale_table` WHERE YEAR(`Date_Time`)='2000'", con)

        If ComboBoxRpt.Text = "Monthly" Then
            cmd = New MySqlCommand("SELECT SUM(`Profit`), COUNT(*) FROM `vbnet_mysql_sale_table` WHERE MONTH(`Date_Time`)=MONTH(@selectedstart) ", con)
            cmd.Parameters.Add("@selectedstart", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().Start
            cmd2 = New MySqlCommand("SELECT * FROM `vbnet_mysql_sale_table` WHERE MONTH(`Date_Time`)=MONTH(@selectedstart) ", con)
            cmd2.Parameters.Add("@selectedstart", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().Start


        ElseIf ComboBoxRpt.Text = "Daily" Then
            cmd = New MySqlCommand("SELECT SUM(`Profit`), COUNT(*) FROM `vbnet_mysql_sale_table` WHERE DAY(`Date_Time`) BETWEEN DAY(@selectedstart) AND DAY(@selectedend) ", con)
            cmd.Parameters.Add("@selectedstart", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().Start
            cmd.Parameters.Add("@selectedend", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().End
            cmd2 = New MySqlCommand("SELECT * FROM `vbnet_mysql_sale_table` WHERE DAY(`Date_Time`) BETWEEN DAY(@selectedstart) AND DAY(@selectedend) ", con)
            cmd2.Parameters.Add("@selectedstart", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().Start
            cmd2.Parameters.Add("@selectedend", MySqlDbType.DateTime).Value = RptCalender.SelectionRange().End

        End If


        con.Open()
        Dim read As MySqlDataReader = cmd.ExecuteReader
        read.Read()
        Try

            ProfitTxt.Text = read.GetString(0)
            NoSalesTxt.Text = read.GetString(1)

        Catch
            ProfitTxt.Text = 0
            NoSalesTxt.Text = 0
        End Try
        con.Close()
        con.Open()
        Dim DT As New DataTable
        DT.Load(cmd2.ExecuteReader)

        DataGridRptView.DataSource = DT
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRptView.CellContentClick

    End Sub

    Private Sub InnitInvestement_TextChanged(sender As Object, e As EventArgs) Handles InnitInvestement.TextChanged
        Dim con As MySqlConnection = New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT SUM(`Profit`), MAX(`Date_Time`), MIN(`Date_Time`) FROM `vbnet_mysql_sale_table` WHERE 1 ", con)
        con.Open()
        Dim read As MySqlDataReader = cmd.ExecuteReader
        Dim BREAKEVENAMOUNT As Integer
        Try
            BREAKEVENAMOUNT = InnitInvestement.Text
        Catch
            Return
        End Try

        read.Read()
        Dim Totalearned As Integer = Totalearned + CInt(read.GetString(0))

        Dim BsnDays As String = DateDiff(DateInterval.Day, CDate(read.GetString(2)), CDate(read.GetString(1)))
        Dim BreakevenDays As String = (BREAKEVENAMOUNT * BsnDays / Totalearned - BsnDays)
        If Not Int(BreakevenDays) = BreakevenDays Then
            BreakevenDays = Int(BreakevenDays) + 1
        End If
        'MessageBox.Show("Your Business has run for" + BsnDays)
        'MessageBox.Show("You will BREAK EVEN in " + BreakevenDays + "More days!")
        BreakEvenDaysTxt.Text = BreakevenDays
    End Sub


End Class