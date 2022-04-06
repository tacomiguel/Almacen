Public Class Documento
    Public Shared Function dsDocumento() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaDocumento_s())
        Return ds
    End Function
    Private Shared Function crearTablaDocumento_s() As DataTable
        Dim dt As New DataTable("documento_s")
        dt.Columns.Add(New DataColumn("cod_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("nom_doc", GetType(String)))
        dt.Columns.Add(New DataColumn("nro_filas", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        'establecemos la clave primaria
        dt.Constraints.Add("pkGrupo", dt.Columns("cod_doc"), True)
        'establecemos la clave unique
        dt.Constraints.Add("uqGrupo", dt.Columns("nom_doc"), False)
        Return dt
    End Function

End Class
