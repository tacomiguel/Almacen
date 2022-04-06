Public Class Transporte
    Public Shared Function dsTransporte() As DataSet
        Dim ds As New DataSet
        Dim dtTransporte As New DataTable("emp_transporte")
        dtTransporte.Columns.Add(New DataColumn("cod_eTrans", GetType(String)))
        dtTransporte.Columns.Add(New DataColumn("nom_eTrans", GetType(String)))
        dtTransporte.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtTransporte.Constraints.Add("pkCod_chof", dtTransporte.Columns("cod_eTrans"), True)
        ds.Tables.Add(dttransporte)
        Return ds
    End Function
End Class
