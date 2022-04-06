Public Class Movimientos
    Public Shared Function dsMovimientos() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaMovimientos())
        Return ds
    End Function
    Private Shared Function crearTablaMovimientos() As DataTable
        Dim dt As New DataTable("movimientos")
        dt.Columns.Add(New DataColumn("cod_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_art", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_uni", GetType(String)))
        dt.Columns.Add(New DataColumn("inicial", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("ingresos", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("mermas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("salidas", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("saldo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("cod_alma", GetType(String)))
        dt.Columns.Add(New DataColumn("cod_sgrupo", GetType(String)))
        Return dt
    End Function
End Class
