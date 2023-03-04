<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fLogin))
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bIniciar = New System.Windows.Forms.Button()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.tClave = New System.Windows.Forms.TextBox()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.lClave = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bSalir
        '
        resources.ApplyResources(Me.bSalir, "bSalir")
        Me.bSalir.Name = "bSalir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bMinimizar
        '
        resources.ApplyResources(Me.bMinimizar, "bMinimizar")
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'bIniciar
        '
        resources.ApplyResources(Me.bIniciar, "bIniciar")
        Me.bIniciar.Name = "bIniciar"
        Me.bIniciar.UseVisualStyleBackColor = True
        '
        'tUsuario
        '
        resources.ApplyResources(Me.tUsuario, "tUsuario")
        Me.tUsuario.Name = "tUsuario"
        '
        'tClave
        '
        resources.ApplyResources(Me.tClave, "tClave")
        Me.tClave.Name = "tClave"
        '
        'lUsuario
        '
        resources.ApplyResources(Me.lUsuario, "lUsuario")
        Me.lUsuario.Name = "lUsuario"
        '
        'lClave
        '
        resources.ApplyResources(Me.lClave, "lClave")
        Me.lClave.BackColor = System.Drawing.Color.Transparent
        Me.lClave.Name = "lClave"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemaP2VB.My.Resources.Resources.PlumaYTinta
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'fLogin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SistemaP2VB.My.Resources.Resources.Buona_Stampa_Blanco
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lClave)
        Me.Controls.Add(Me.lUsuario)
        Me.Controls.Add(Me.tClave)
        Me.Controls.Add(Me.tUsuario)
        Me.Controls.Add(Me.bIniciar)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "fLogin"
        Me.Opacity = 0.86R
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bSalir As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bIniciar As Button
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents tClave As TextBox
    Friend WithEvents lUsuario As Label
    Friend WithEvents lClave As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
