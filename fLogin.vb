Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports SistemaP2VB.Cacheuser

Public Class fLogin


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



    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click


        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub fLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        tUsuario.Text = tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "")
        tClave.Text = tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "")

    End Sub


    Private Sub bIniciar_Click(sender As Object, e As EventArgs) Handles bIniciar.Click
        Try
            If usuarioRegistrado(tUsuario.Text) = True Then
                Dim contra As String = valClav(tUsuario.Text)
                If contra.Equals(tClave.Text) = True Then

                    MessageBox.Show("Bienvenido " & CacheUser.User & " " & CacheUser.apellido & " Que tenga un buen dia", "                                 WELCOME BUONA")
                    'MsgBox("Bienvenido " & CacheUser.User & " " & CacheUser.apellido & " Que tenga un buen dia")
                    My.Forms.fMenu.Visible = True
                    Me.Visible = False
                    Me.Refresh()
                    tUsuario.Clear()
                    tClave.Clear()
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + tUsuario.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            Refresh()
            enunciado = New SqlCommand("Select * from Usuarios where Usuario='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
                CacheUser.user = respuesta.GetString(3)
                CacheUser.apellido = respuesta.GetString(4)
                CacheUser.mail = respuesta.GetString(7)
                CacheUser.ID = respuesta.GetInt32(0)

            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function


    Function valClav(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Clave from Usuarios where Usuario='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader


            If respuesta.Read Then
                resultado = respuesta.Item("Clave")



            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function



    Dim m As Integer = 0, mx As Integer,
              mi As Integer

    Private Sub fLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub

    Private Sub tClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tClave.KeyPress
        If (e.KeyChar = Convert.ToChar((Keys.Enter))) Then
            'e.Handled = True
            bIniciar_Click(sender, e)
        End If
    End Sub

    Private Sub fLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If m = 1 Then

            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub

    Private Sub fLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        m = 0
    End Sub

End Class