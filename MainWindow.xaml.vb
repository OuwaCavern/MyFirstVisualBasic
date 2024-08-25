Imports System.Data.SqlClient
Imports System.Data

Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim connectionString As String = "Data Source=\DESENERP;Initial Catalog=DesenPOS; Persist Security Info=False; TrustServerCertificate=True; uid=sa; password=DesenErp.12345"
        Dim query As String = "SELECT * FROM POSSiparis"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Siparisler.ItemsSource = dataTable.DefaultView()
        End Using
    End Sub
End Class
