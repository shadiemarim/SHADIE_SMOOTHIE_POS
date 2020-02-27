Imports MySql.Data.MySqlClient


Public Class saleform
    'user=your mysql user name; password=your password; database=your database name
    Dim Connection As New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable

    Dim Table_Name As String = "vbnet_mysql_sale_table" 'your table name
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim NameRam, S_PriceRam, AmountRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String
    Dim Col0Ram As Integer = 0

    Private Sub TxtBoxQty_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxQty.TextChanged
        Try
            TxtBoxTotal.Text = (TxtBoxS_Price.Text * TxtBoxQty.Text)
        Catch ex As Exception
            TxtBoxTotal.Text = 0

        End Try



    End Sub

    Private Sub MakeSale_Click(sender As Object, e As EventArgs) Handles MakeSale.Click
        If CInt(TxtBoxQty.Text) > CInt(TxtQtyRem.Text) Then
            MsgBox("You do not have entities to sell!", MsgBoxStyle.Critical, "sell Denied")
        Else
            Dim con As MySqlConnection = New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
            Dim cmd As MySqlCommand = New MySqlCommand("UPDATE `vbnet_mysql_item_table` SET `Amount`=@newAmount WHERE `Name`=@item_name ", con)
            cmd.Parameters.Add("@newAmount", MySqlDbType.Int32).Value = (TxtQtyRem.Text - TxtBoxQty.Text)
            cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = ComboBox1.Text
            con.Open()

            Dim read As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            con = New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
            Dim cmd2 As MySqlCommand = New MySqlCommand("INSERT INTO `vbnet_mysql_sale_table` (`Name`, `S_Price`, `Amount`, `Profit`, `F_Name`, `Contacts`) VALUES (@name, @s_price, @amount, @profit, @f_name, @contacts )", con)
            cmd2.Parameters.Add("@name", MySqlDbType.VarChar).Value = ComboBox1.Text
            cmd2.Parameters.Add("@s_price", MySqlDbType.VarChar).Value = TxtBoxS_Price.Text
            cmd2.Parameters.Add("@amount", MySqlDbType.VarChar).Value = TxtBoxQty.Text
            cmd2.Parameters.Add("@profit", MySqlDbType.VarChar).Value = (TxtBoxS_Price.Text - TxtBxPrice.Text)
            cmd2.Parameters.Add("@f_name", MySqlDbType.VarChar).Value = TxtBox_name.Text
            cmd2.Parameters.Add("@contacts", MySqlDbType.Int16).Value = TxtBox_contacts.Text

            con.Open()
            read = cmd2.ExecuteReader(CommandBehavior.CloseConnection)


            MsgBox("sell successful!", MsgBoxStyle.Information, "sell made")

            FrmMain.Focus()



        End If





    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim con As MySqlConnection = New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT `Price`,`Amount` FROM `vbnet_mysql_item_table` WHERE `Name`=@item_name ", con)
        cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = ComboBox1.Text
        con.Open()

        Dim read As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        If read.HasRows() Then
            read.Read()

            TxtBxPrice.Focus()
            TxtBxPrice.Text = read.GetString(0)
            TxtQtyRem.Focus()
            TxtQtyRem.Text = read.GetString(1)

        End If
        con.Close()

    End Sub

    Private Sub Saleform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As MySqlConnection = New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
        con.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT `Name` FROM `vbnet_mysql_item_table` WHERE 1 ", con)

        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read()
            ComboBox1.Items.Add(read.GetString(0))
        End While
        con.Close()
    End Sub

End Class