Imports System.ComponentModel
Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Dim strBus(100, 100) As String
    Dim strDrivers(100, 100) As String
    Dim strRoutes(100, 100) As String

    Dim dID(6) As String
    Dim Names() As String = {"Aaron", "Chaz", "Dan", "Jordan", "lkj", "Arnold"}
    Dim phone(6) As String

    Dim strListPop As String
    Dim inFile As IO.StreamReader
    Dim outFile As IO.StreamWriter
    Dim strinfo As String

    Dim connectionString As String = "Password=son;User ID=DrN;" + "Initial Catalog=pubs;" + "Data Source=(local"
    Dim objConn As New SqlConnection(connectionString)


    Dim dSet As DataSet
    Dim tblBusses As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database11DataSet.Busses' table. You can move, or remove it, as needed.
        Me.BussesTableAdapter.Fill(Me.Database11DataSet.Busses)

        For x As Integer = 12 To 32
            seatsAddcmb.Items.Add(x.ToString)
        Next x

        objConn.Open()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        outFile = IO.File.CreateText("D:\Aaron's Folder\WindowsApplication1\WindowsApplication1\bin\Debug\drivers1.txt")

        For intIndex As Integer = 0 To lstListBox.Items.Count - 1
            outFile.WriteLine(lstListBox.Items(intIndex))
        Next intIndex

        ' close the file
        objConn.Close()
        outFile.Close()
        Me.Close()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnBuses.Visible = True
        btnDrivers.Visible = True
        btnRoutes.Visible = True
        lstListBox.Visible = False
        btnHome.Visible = False
        lblTitle.Text = "Welcome to Dr. N and Sons Bus Rentals"
    End Sub

    Private Sub btnBuses_Click(sender As Object, e As EventArgs) Handles btnBuses.Click
        lstListBox.Items.Clear()
        btnRoutes.Visible = False
        btnDrivers.Visible = False
        btnRoutes.Visible = False
        btnHome.Visible = True
        btnBuses.Visible = False
        lstListBox.Visible = True
        btnAddBus.Visible = True
        btnDeleteBus.Visible = True
        bussAddgbx.Visible = True
        For z As Integer = 0 To Database11DataSet.Busses.Rows.Count - 1

            lstListBox.Items.Add(Database11DataSet.Busses.Rows(z).ItemArray(0).ToString + Space(12) + Database11DataSet.Busses.Rows(z).ItemArray(1).ToString + Space(12) + Database11DataSet.Busses.Rows(z).ItemArray(2).ToString + Space(12) + Database11DataSet.Busses.Rows(z).ItemArray(3).ToString + Space(12) + Database11DataSet.Busses.Rows(z).ItemArray(4).ToString)

        Next z
        ' lstListBox.Items.Add(Database11DataSet.Busses.Rows(0).ItemArray(0).ToString + Space(12) + Database11DataSet.Busses.Rows(0).ItemArray(1).ToString + Space(12) + Database11DataSet.Busses.Rows(0).ItemArray(2).ToString + Space(12) + Database11DataSet.Busses.Rows(0).ItemArray(3).ToString + Space(12) + Database11DataSet.Busses.Rows(0).ItemArray(4).ToString)

        lblTitle.Text = "Please Select A Bus To Begin"


    End Sub

    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        btnHome.Visible = True
        btnDrivers.Visible = False
        btnBuses.Visible = False
        btnRoutes.Visible = False
        lstListBox.Visible = True
        lblTitle.Text = "Please Select A Driver To Begin"
        btnAddDriver.Visible = True
        btnDeleteDriver.Visible = True

        lstListBox.Items.Clear()

        If IO.File.Exists("D: \Aaron's Folder\WindowsApplication1\WindowsApplication1\bin\Debug\drivers1.txt") Then
            inFile = IO.File.OpenText("D:\Aaron's Folder\WindowsApplication1\WindowsApplication1\bin\Debug\drivers1.txt")
            Do Until inFile.Peek = -1
                strinfo = inFile.ReadLine
                lstListBox.Items.Add(strinfo)
            Loop
            inFile.Close()

        Else
            outFile = IO.File.CreateText("D:\Aaron's Folder\WindowsApplication1\WindowsApplication1\bin\Debug\drivers1.txt")
            MessageBox.Show("NOPE")

        End If


    End Sub

    Private Sub btnRoutes_Click(sender As Object, e As EventArgs) Handles btnRoutes.Click
        btnRoutes.Visible = False
        btnDrivers.Visible = False
        btnBuses.Visible = False
        btnHome.Visible = True
        lstListBox.Visible = True
        lblTitle.Text = "Please Select a Route to Begin"
        btnAddRoute.Visible = True
        btnDeleteRoute.Visible = True

        lstListBox.Items.Clear()
        lstListBox.Items.Add("Northfield Middle School A")
        lstListBox.Items.Add("Northfield Middle School B")
        lstListBox.Items.Add("Northfield Middle School C")
    End Sub

    Private Sub btnDeleteDriver_Click(sender As Object, e As EventArgs) Handles btnDeleteDriver.Click
        If lstListBox.SelectedIndex <> -1 Then
            lstListBox.Items.RemoveAt(lstListBox.SelectedIndex)
        End If
    End Sub

    Private Sub lstListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListBox.SelectedIndexChanged

    End Sub

    Private Sub btnAddDriver_Click(sender As Object, e As EventArgs) Handles btnAddDriver.Click
        Dim driverInput As String = InputBox("Please Enter Driver Info")
        MessageBox.Show(driverInput)
    End Sub

    Private Sub BussesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BussesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BussesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database11DataSet)

    End Sub

    Private Sub btnAddRoute_Click(sender As Object, e As EventArgs) Handles btnAddRoute.Click



    End Sub

    Private Sub btnAddBus_Click(sender As Object, e As EventArgs) Handles btnAddBus.Click

        Dim dt As Date = dateServiceAdd.Text
        Dim newRow As DataRow
        Dim bID As Integer = CInt(tbxBusIDAdd.Text)
        newRow = Database11DataSet.Busses.Rows.Add(bID, tbxMakeAdd.Text, tbxModelAdd.Text, 10, dt)

        Try
            dSet = Database11DataSet.GetChanges()
            BussesTableAdapter.Update(Database11DataSet.Tables("Busses"))
            'Database11DataSet.Merge(dSet)

        Catch ex As Exception
            MessageBox.Show("didnt work")
        End Try

    End Sub

    Private Sub tbxBusIDAdd_TextChanged(sender As Object, e As EventArgs) Handles tbxBusIDAdd.TextChanged
    End Sub

    Private Sub tbxBusIDAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxBusIDAdd.KeyDown
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            MessageBox.Show("Buss ID must be numeric")
            tbxBusIDAdd.Clear()
        End If
    End Sub

    Private Sub btnConfirmBussAdd_Click(sender As Object, e As EventArgs) Handles btnConfirmBussAdd.Click

    End Sub

    Private Sub btnDeleteBus_Click(sender As Object, e As EventArgs) Handles btnDeleteBus.Click

        Try
            Dim index As Integer = CInt(lstListBox.SelectedIndex)
            'MessageBox.Show(lstListBox.SelectedIndex.ToString)
            Database11DataSet.Busses.RemoveBussesRow(Database11DataSet.Busses.Rows(index))
            BussesTableAdapter.Update(Database11DataSet.Tables("Busses"))
        Catch ex As Exception
            MessageBox.Show("did not delete")
        End Try

    End Sub
End Class
