Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public sqlnya As String
    Public y As Integer
    Public t As Integer
    Public ya As Integer = Form1.CheckedListBox1.CheckedItems.Count
    Public ta As Integer = Form1.CheckedListBox1.CheckedItems.Count
    Public yb As Integer = Form1.CheckedListBox2.CheckedItems.Count
    Public tb As Integer = Form1.CheckedListBox2.CheckedItems.Count
    Public yc As Integer = Form1.CheckedListBox3.CheckedItems.Count
    Public tc As Integer = Form1.CheckedListBox3.CheckedItems.Count
    Public hasil As String
    Public jk As String
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasidata As String
    Public Sub konek()
        lokasidata = "provider=microsoft.jet.oledb.4.0;data source=list.mdb"
        conn = New OleDbConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM list_covid", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "list_covid")
        Form3.DataGridView1.DataSource = DS.Tables("list_covid")
        Form3.DataGridView1.Enabled = True
    End Sub
    Public Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub
End Module

