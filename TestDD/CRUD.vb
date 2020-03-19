Public Class CRUD
    Dim conn As Conn = New Conn
    Dim TableCar As BindingSource = New BindingSource()

    Private Sub LoadItem()
        TableCar.DataSource = conn.GetDataTable("select * from car")
        TCar.DataSource = TableCar
        TCar.AutoResizeColumns()
    End Sub

    Private Sub CRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadItem()
    End Sub

    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click
        Dim TableQuery As String
        Dim xxxx As BindingSource = New BindingSource()
        TableQuery = "Delete from car where carname='" + TCar.CurrentRow.Cells(0).Value + "'"
        xxxx.DataSource = conn.Proses(TableQuery)
        LoadItem()
    End Sub

    Private Sub BAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAdd.Click
        Dim TableQuery As String
        Dim xxxx As BindingSource = New BindingSource()
        TableQuery = "insert into car (carname, caryear, carprice)values ("
        TableQuery = TableQuery + "'" + TName.Text + "',"
        TableQuery = TableQuery + "'" + TYear.Text + "',"
        TableQuery = TableQuery + "'" + TPrice.Text + "')"
        xxxx.DataSource = conn.Proses(TableQuery)

        LoadItem()
    End Sub

    Private Sub BEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEdit.Click
        Dim xxxx As BindingSource = New BindingSource()
        Dim TableQuery As String

        TableQuery = "update car set "
        TableQuery = TableQuery + "carname='" + TName.Text + "',"
        TableQuery = TableQuery + "caryear='" + TYear.Text + "',"
        TableQuery = TableQuery + "carprice='" + TPrice.Text + "' where "
        TableQuery = TableQuery + "carname='" + TCar.CurrentRow.Cells(0).Value + "'"
        xxxx.DataSource = conn.Proses(TableQuery)
        LoadItem()
    End Sub

    Private Sub BCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCalculate.Click
        Dim subtotal As Decimal
        subtotal = TRent.Text * TCar.CurrentRow.Cells(2).Value

        ' Diskon 5% sewa 3 hari
        If TDay.Text = 3 Then
            subtotal = subtotal - (subtotal * 0.05)
        End If

        'Diskon 10% sewa 2 mobil atau lebih
        If TRent.Text >= 2 Then
            subtotal = subtotal - (subtotal * 0.1)
        End If

        'Diskon 7% sewa 2 mobil atau lebih
        If TCar.CurrentRow.Cells(1).Value < 2010 Then
            subtotal = subtotal - (subtotal * 0.07)
        End If

        TTotal.Text = subtotal
    End Sub
End Class
