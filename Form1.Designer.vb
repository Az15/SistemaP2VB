<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bCliente = New System.Windows.Forms.Button()
        Me.bProveedor = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.bLogout = New System.Windows.Forms.Button()
        Me.bUsuarios = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lBienvenido = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bCliente
        '
        Me.bCliente.BackColor = System.Drawing.Color.Transparent
        Me.bCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bCliente.Location = New System.Drawing.Point(318, 211)
        Me.bCliente.Name = "bCliente"
        Me.bCliente.Size = New System.Drawing.Size(167, 39)
        Me.bCliente.TabIndex = 0
        Me.bCliente.Text = "Clientes"
        Me.bCliente.UseVisualStyleBackColor = False
        '
        'bProveedor
        '
        Me.bProveedor.BackColor = System.Drawing.Color.Transparent
        Me.bProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bProveedor.ForeColor = System.Drawing.Color.Transparent
        Me.bProveedor.Location = New System.Drawing.Point(318, 148)
        Me.bProveedor.Name = "bProveedor"
        Me.bProveedor.Size = New System.Drawing.Size(167, 39)
        Me.bProveedor.TabIndex = 1
        Me.bProveedor.Text = "Proveedores"
        Me.bProveedor.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bSalir.Location = New System.Drawing.Point(477, -6)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(36, 38)
        Me.bSalir.TabIndex = 4
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bMinimizar
        '
        Me.bMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bMinimizar.Location = New System.Drawing.Point(442, -6)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(36, 38)
        Me.bMinimizar.TabIndex = 5
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = False
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("MV Boli", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.White
        Me.lbluser.Location = New System.Drawing.Point(76, 126)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(22, 11)
        Me.lbluser.TabIndex = 8
        Me.lbluser.Text = "user"
        '
        'lblMail
        '
        Me.lblMail.BackColor = System.Drawing.Color.Transparent
        Me.lblMail.Font = New System.Drawing.Font("Gabriola", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(75, 145)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(134, 39)
        Me.lblMail.TabIndex = 9
        Me.lblMail.Text = "mail"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(5, 100)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(10, 9)
        Me.lblID.TabIndex = 10
        Me.lblID.Text = "0"
        '
        'bLogout
        '
        Me.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLogout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bLogout.Location = New System.Drawing.Point(6, 221)
        Me.bLogout.Name = "bLogout"
        Me.bLogout.Size = New System.Drawing.Size(106, 29)
        Me.bLogout.TabIndex = 11
        Me.bLogout.Text = "Cerrar Sesion"
        Me.bLogout.UseVisualStyleBackColor = True
        '
        'bUsuarios
        '
        Me.bUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.bUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bUsuarios.Location = New System.Drawing.Point(318, 48)
        Me.bUsuarios.Name = "bUsuarios"
        Me.bUsuarios.Size = New System.Drawing.Size(167, 39)
        Me.bUsuarios.TabIndex = 12
        Me.bUsuarios.Text = "Usuarios"
        Me.bUsuarios.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.PictureBox3.BackgroundImage = Global.SistemaP2VB.My.Resources.Resources.UsuarioIco
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(1, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 61)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-93, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(609, 38)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lBienvenido
        '
        Me.lBienvenido.AutoSize = True
        Me.lBienvenido.Font = New System.Drawing.Font("Palace Script MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBienvenido.ForeColor = System.Drawing.Color.White
        Me.lBienvenido.Location = New System.Drawing.Point(-6, 121)
        Me.lBienvenido.Name = "lBienvenido"
        Me.lBienvenido.Size = New System.Drawing.Size(80, 19)
        Me.lBienvenido.TabIndex = 13
        Me.lBienvenido.Text = "Bienvenido:"
        '
        'fMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BackgroundImage = Global.SistemaP2VB.My.Resources.Resources.Buona_Stampa_gris
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 262)
        Me.Controls.Add(Me.lBienvenido)
        Me.Controls.Add(Me.bUsuarios)
        Me.Controls.Add(Me.bLogout)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bProveedor)
        Me.Controls.Add(Me.bCliente)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fMenu"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bCliente As Button
    Friend WithEvents bProveedor As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bSalir As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbluser As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblID As Label
    Friend WithEvents bLogout As Button
    Friend WithEvents bUsuarios As Button
    Friend WithEvents lBienvenido As Label
End Class
