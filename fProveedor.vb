Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class fProveedor




    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=ABM; integrated security=true")

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click


        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub

    Private Sub fproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" Empresa like '" & tBuscar.Text & "%' ")
    End Sub

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

        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT ID,Empresa,NumeroDeContacto,Mail,Cuit from proveedor1 where " & condicion & " order by ID", con)
        Dim ds As New DataSet
        da.Fill(ds, "proveedor")
        If ds.Tables("proveedor").Rows.Count = 0 Then

            DataGridView1.Visible = False

            pBotones.Visible = False
            pCampos.Visible = False
            lLegajo.Visible = False
        Else

            DataGridView1.DataSource = ds.Tables("proveedor")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lLegajo.Visible = True
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub

    Sub CargarCamposproveedor()
        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(Empresa,'****')))) as Empresa, upper(ltrim(rtrim(isnull(Alias,'****')))) as Alias,isnull([Cuit],0) as Cuit, ltrim(rtrim(isnull(DomicilioFiscal,''))) as Domicilio_Fiscal,ltrim(rtrim(isnull(Mail,''))) as Mail, ltrim(rtrim(isnull(NumeroDeContacto,''))) as ncontacto,ltrim(rtrim(isnull(Pais,''))) as Pais,isnull([Fax],0) as Fax,FechaDeAlta as Alta,isnull(estado,0) as Estado from proveedor where ID=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "proveedor")
            TextBox1.Text = ds.Tables("proveedor").Rows(0)("Empresa")
            TextBox2.Text = ds.Tables("proveedor").Rows(0)("Alias")
            TextBox3.Text = ds.Tables("proveedor").Rows(0)("Cuit")
            TextBox4.Text = ds.Tables("proveedor").Rows(0)("Domicilio_Fiscal")
            TextBox5.Text = ds.Tables("proveedor").Rows(0)("Mail")
            TextBox6.Text = ds.Tables("proveedor").Rows(0)("ncontacto")
            TextBox7.Text = ds.Tables("proveedor").Rows(0)("Pais")
            TextBox8.Text = ds.Tables("proveedor").Rows(0)("Fax")
            CheckBox1.Checked = IIf(ds.Tables("proveedor").Rows(0)("estado") = 0, False, True)
            DateTimePicker1.Value = ds.Tables("proveedor").Rows(0)("Alta")
        End If
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
            CargarCamposproveedor()
        End If

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar(" empresa like '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al proveedor: " & TextBox1.Text.Trim.ToUpper & ", " & "Ayudo a que la empresa crezca por años..." & ". Es algo EXTREMO,Sus contribuciones le dieron de comer a miles de familias... Está SEGURO?", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from ABM.dbo.proveedor  where  ID =" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al proveedor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" ID =" & Val(lLegajo.Text))
            MsgBox("El proveedor fue ELIMINADO de la base de datos.")

        End If
    End Sub

    Private Sub bCambio_Click(sender As Object, e As EventArgs) Handles bCambio.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Nombre de la empresa." & en
        End If
        If TextBox7.Text.Trim.Length < 3 Then
            errores &= "Verifique por favor el Fax de la empresa. No es obligatorio, pero si lo escribe debe ser correcto." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If

        If SQL_Accion("update ABM.dbo.proveedor set Estado=" & IIf(CheckBox1.Checked, 1, 0) & ", Empresa= '" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', Alias='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', Cuit='" & TextBox3.Text.Trim.Replace("'", "´") & "', DomicilioFiscal='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', Mail='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', NumeroDeContacto='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', Pais='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', Fax='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', FechaDeAlta=" & FechaSQL(DateTimePicker1.Value) & " where ID=" & VNum(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar("ID= " & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos de la empresa, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub bCrear_Click(sender As Object, e As EventArgs) Handles bCrear.Click
        If SQL_Accion("insert into ABM.dbo.proveedor (Empresa, Alias, Cuit, DomicilioFiscal, Mail, NumeroDeContacto, Pais, FechaDeAlta,estado) values ('**',           '**',           '0',           '***',           '***',           '0',           '***',           getdate() ,  1 )  ") Then
            buscar(" Empresa like '**%' ")
            MsgBox("Se ha creado un nuevo registro para la empresa que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bMenu_Click(sender As Object, e As EventArgs) Handles bMenu.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir al Menu", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            My.Forms.fMenu.Visible = True
            Me.Visible = False
        End If

    End Sub


    Dim m As Integer = 0, mx As Integer,
              mi As Integer

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m = 1 Then

            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        m = 0
    End Sub

    Private Sub fProveedor_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub

    Private Sub tBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tBuscar.KeyPress
        If (e.KeyChar = Convert.ToChar((Keys.Enter))) Then
            'e.Handled = True
            bBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub pCampos_Paint(sender As Object, e As PaintEventArgs) Handles pCampos.Paint

    End Sub

    Private Sub fProveedor_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If m = 1 Then

            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub

    Private Sub fProveedor_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        m = 0
    End Sub
End Class
