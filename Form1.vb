Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Windows.Forms
Imports System.Data


Public Class fMenu


    Private Sub bCliente_Click(sender As Object, e As EventArgs) Handles bCliente.Click
        my.forms.fCliente.Visible = True
        Me.Visible = False
    End Sub

    Private Sub bProveedor_Click(sender As Object, e As EventArgs) Handles bProveedor.Click
        My.Forms.fProveedor.Visible = True
        Me.Visible = False
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

    Dim m As Integer = 0, mx As Integer,
               mi As Integer

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub

    Private Sub fMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblID.Text = CacheUser.ID
        lbluser.Text = CacheUser.User & " " & CacheUser.apellido
        lblMail.Text = CacheUser.mail

    End Sub


    '/Sub cache(ByRef name As String, ByRef mail As String, ByRef leg As Integer)
    '   Dim con As New SqlConnection("data source=DRAGONRACE\SQLEXPRESS; initial catalog=ABM; integrated security=True")
    '    con.Open()
    '    Dim coma As New SqlCommand
    '   coma.CommandText = "Select * from Cliente"
    '    coma.Parameters.AddWithValue("@Empresa", name)
    '    coma.Parameters.AddWithValue("@Mail", mail)
    '   coma.Parameters.AddWithValue("@ID", leg)

    '  Dim dt As New DataTable()
    '  Dim da As New SqlDataAdapter(coma)
    'da.Fill(dt)
    ' End Sub






    Private Sub fMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub

    Private Sub fMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If m = 1 Then

            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub

    Private Sub fMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        m = 0
    End Sub

    Private Sub bLogout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bLogout_Click_1(sender As Object, e As EventArgs) Handles bLogout.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea Cerrar Sesion", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then

            My.Forms.fLogin.Visible = True
            Me.Close()
            'Me.Visible = False
            'Me.Refresh()
        End If
    End Sub

    Private Sub bUsuarios_Click(sender As Object, e As EventArgs) Handles bUsuarios.Click
        My.Forms.fUsuarios.Visible = True
        Me.Visible = False
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m = 1 Then

            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp

        m = 0

    End Sub
End Class

