Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Runtime.InteropServices


Public Class fUsuarios

    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=ABM; integrated security=true")
    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            MsgBox("Verifique Falta Archivo de Configuracion")
            Me.Close()
        End If
    End Function


    Sub buscar(ByVal condicion As String)

        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT ID,Usuario,Clave,Apellido,Nombre,Documento,Mail from VistaUsers where " & condicion & " order by ID", con)
        Dim ds As New DataSet
        da.Fill(ds, "Usuarios")
        If ds.Tables("Usuarios").Rows.Count = 0 Then

            DataGridView1.Visible = False

            pBotones.Visible = False
            pCampos.Visible = False
            lLegajo.Visible = False
        Else

            DataGridView1.DataSource = ds.Tables("Usuarios")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lLegajo.Visible = True
        End If

    End Sub

    Sub CargarCamposuser()

        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(Usuario,'****')))) as Usuario, upper(ltrim(rtrim(isnull(Clave,'****')))) as Clave,isnull(Apellido,'****') as Apellido, ltrim(rtrim(isnull(Nombre,'****'))) as Nombre,ltrim(rtrim(isnull(Documento,'0'))) as Documento,ltrim(rtrim(isnull(Mail,'****'))) as Mail from Usuarios where ID=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "Usuarios")
            TextBox1.Text = ds.Tables("Usuarios").Rows(0)("Usuario")
            TextBox2.Text = ds.Tables("Usuarios").Rows(0)("Clave")
            TextBox5.Text = ds.Tables("Usuarios").Rows(0)("Apellido")
            TextBox6.Text = ds.Tables("Usuarios").Rows(0)("Nombre")
            TextBox3.Text = ds.Tables("Usuarios").Rows(0)("Documento")
            TextBox4.Text = ds.Tables("Usuarios").Rows(0)("Mail")

        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lLegajo.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            CargarCamposuser()
        End If

    End Sub


    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al Usuario: " & TextBox1.Text.Trim.ToUpper & ", " & " SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from ABM.dbo.Usuarios  where  ID =" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" ID =" & Val(lLegajo.Text))
            MsgBox("El Cliente fue ELIMINADO de la base de datos.")

        End If
    End Sub

    Private Sub bCambio_Click(sender As Object, e As EventArgs) Handles bCambio.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Nombre del Usuario." & en
        End If
        If TextBox4.Text.Trim.Length < 3 Then
            errores &= "Verifique por favor el Email del Usuario. No es obligatorio, pero si lo escribe debe ser correcto." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If

        If SQL_Accion("update ABM.dbo.Usuarios set Usuario= '" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', Clave='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', Documento='" & TextBox3.Text.Trim.Replace("'", "´") & "',Mail='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', Apellido='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', Nombre= '" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "' where ID=" & VNum(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar("ID= " & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos de la empresa, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub bCrear_Click(sender As Object, e As EventArgs) Handles bCrear.Click
        If SQL_Accion("insert into ABM.dbo.Usuarios (Usuario, Clave, Documento, Mail, Apellido, Nombre) values ('**',           '****',           '0000',           '***',           '****',           '****') ") Then
            buscar(" Usuario like '**%' ")
            MsgBox("Se ha creado un nuevo registro para la empresa que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub























    Private Sub bMenu_Click(sender As Object, e As EventArgs) Handles bMenu.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir al Menu", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            My.Forms.fMenu.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click

        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub fUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" Usuario like '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar(" Usuario like '" & tBuscar.Text & "%' ")
    End Sub
End Class