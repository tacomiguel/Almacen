Public Class MotivoTraslado
    Public Shared Function dsMotivo() As DataSet
        Dim ds As New DataSet
        Dim dtMotivo As New DataTable("motivo")
        dtMotivo.Columns.Add(New DataColumn("cod_mot", GetType(String)))
        dtMotivo.Columns.Add(New DataColumn("nom_mot", GetType(String)))
        dtMotivo.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        dtMotivo.Constraints.Add("pkCod_mot", dtMotivo.Columns("cod_mot"), True)
        ds.Tables.Add(dtMotivo)
        Return ds
    End Function
End Class
