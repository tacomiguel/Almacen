Public Class grupo
    Public Shared Function dsGrupo() As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(crearTablaGrupo())
        Return ds
    End Function
    Private Shared Function crearTablaGrupo() As DataTable
        Dim dt As New DataTable("grupo")
        Dim dcCod_Grupo As New DataColumn("cod_grupo", GetType(String))
        dt.Columns.Add(dcCod_Grupo)
        dt.Columns.Add(New DataColumn("nom_grupo", GetType(String)))
        dt.Columns.Add(New DataColumn("activo", GetType(Boolean)))
        'establecemos la clave primaria
        dt.Constraints.Add("pkGrupo", dt.Columns("cod_grupo"), True)
        'establecemos la clave unique
        dt.Constraints.Add("uqGrupo", dt.Columns("nom_grupo"), False)
        Return dt
    End Function
    Public Shared Function dssubgrupo() As DataSet
        Dim ds As New DataSet
        Dim dtSG As New DataTable("sGrupo")
        Dim dtG As New DataTable("grupo")
        'añadimos columnas al dataset
        dtSG.Columns.Add("cod_sgrupo", GetType(String))
        dtSG.Columns.Add("nom_sgrupo", GetType(String))
        dtSG.Columns.Add("cod_grupo", GetType(String))
        dtSG.Columns.Add("activo", GetType(Boolean))
        'establecemos el indice principal
        dtSG.Constraints.Add("pksubgrupo", dtSG.Columns("cod_sgrupo"), True)
        'establecemos el indice unique
        dtSG.Constraints.Add("uqsubgrupo", dtSG.Columns("nom_sgrupo"), False)
        'establecemos el Foreign Key
        ds.Tables("sGrupo").Constraints.Add("fkGrupoSubSgrupo", _
        ds.Tables("grupo").Columns("cod_grupo"), _
        ds.Tables("sGrupo").Columns("cod_grupo"))
        'hacemos los campos No Nulos
        dtSG.Columns("nom_sgrupo").AllowDBNull = False
        dtSG.Columns("cod_grupo").AllowDBNull = False
        dtSG.Columns("activo").AllowDBNull = False
        Return ds
    End Function
End Class
