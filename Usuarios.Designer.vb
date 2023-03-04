<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fUsuarios
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bMenu = New System.Windows.Forms.Button()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.bCrear = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bCambio = New System.Windows.Forms.Button()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lApellido = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lMail = New System.Windows.Forms.Label()
        Me.ldni = New System.Windows.Forms.Label()
        Me.lClave = New System.Windows.Forms.Label()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lBusque = New System.Windows.Forms.Label()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBotones.SuspendLayout()
        Me.pCampos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(860, 38)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bSalir.Location = New System.Drawing.Point(819, 0)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(36, 38)
        Me.bSalir.TabIndex = 5
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bMinimizar
        '
        Me.bMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bMinimizar.Location = New System.Drawing.Point(783, 0)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(36, 38)
        Me.bMinimizar.TabIndex = 6
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = False
        '
        'bMenu
        '
        Me.bMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMenu.ForeColor = System.Drawing.Color.White
        Me.bMenu.Location = New System.Drawing.Point(406, 48)
        Me.bMenu.Name = "bMenu"
        Me.bMenu.Size = New System.Drawing.Size(75, 37)
        Me.bMenu.TabIndex = 43
        Me.bMenu.Text = "Volver Al Menu"
        Me.bMenu.UseVisualStyleBackColor = False
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(824, 67)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(13, 13)
        Me.lLegajo.TabIndex = 51
        Me.lLegajo.Text = "0"
        '
        'bCrear
        '
        Me.bCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCrear.ForeColor = System.Drawing.Color.White
        Me.bCrear.Location = New System.Drawing.Point(644, 306)
        Me.bCrear.Name = "bCrear"
        Me.bCrear.Size = New System.Drawing.Size(75, 37)
        Me.bCrear.TabIndex = 44
        Me.bCrear.Text = "Crear Cliente"
        Me.bCrear.UseVisualStyleBackColor = True
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.Transparent
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bCambio)
        Me.pBotones.Location = New System.Drawing.Point(513, 297)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(329, 52)
        Me.pBotones.TabIndex = 50
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.ForeColor = System.Drawing.Color.White
        Me.bEliminar.Location = New System.Drawing.Point(224, 8)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(75, 37)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bCambio
        '
        Me.bCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCambio.ForeColor = System.Drawing.Color.White
        Me.bCambio.Location = New System.Drawing.Point(26, 8)
        Me.bCambio.Name = "bCambio"
        Me.bCambio.Size = New System.Drawing.Size(75, 37)
        Me.bCambio.TabIndex = 0
        Me.bCambio.Text = "Aceptar Cambios"
        Me.bCambio.UseVisualStyleBackColor = True
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.Transparent
        Me.pCampos.Controls.Add(Me.lNombre)
        Me.pCampos.Controls.Add(Me.lApellido)
        Me.pCampos.Controls.Add(Me.TextBox4)
        Me.pCampos.Controls.Add(Me.TextBox2)
        Me.pCampos.Controls.Add(Me.lMail)
        Me.pCampos.Controls.Add(Me.ldni)
        Me.pCampos.Controls.Add(Me.lClave)
        Me.pCampos.Controls.Add(Me.lUsuario)
        Me.pCampos.Controls.Add(Me.TextBox3)
        Me.pCampos.Controls.Add(Me.TextBox6)
        Me.pCampos.Controls.Add(Me.TextBox5)
        Me.pCampos.Controls.Add(Me.TextBox1)
        Me.pCampos.Location = New System.Drawing.Point(513, 91)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(329, 179)
        Me.pCampos.TabIndex = 49
        '
        'lNombre
        '
        Me.lNombre.ForeColor = System.Drawing.Color.White
        Me.lNombre.Location = New System.Drawing.Point(1, 131)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(100, 23)
        Me.lNombre.TabIndex = 28
        Me.lNombre.Text = "Nombre:"
        '
        'lApellido
        '
        Me.lApellido.ForeColor = System.Drawing.Color.White
        Me.lApellido.Location = New System.Drawing.Point(2, 107)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(100, 23)
        Me.lApellido.TabIndex = 27
        Me.lApellido.Text = "Apellido:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(178, 82)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(151, 20)
        Me.TextBox4.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(178, 31)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 24
        '
        'lMail
        '
        Me.lMail.ForeColor = System.Drawing.Color.White
        Me.lMail.Location = New System.Drawing.Point(3, 84)
        Me.lMail.Name = "lMail"
        Me.lMail.Size = New System.Drawing.Size(100, 23)
        Me.lMail.TabIndex = 16
        Me.lMail.Text = "eMail:"
        '
        'ldni
        '
        Me.ldni.ForeColor = System.Drawing.Color.White
        Me.ldni.Location = New System.Drawing.Point(3, 60)
        Me.ldni.Name = "ldni"
        Me.ldni.Size = New System.Drawing.Size(100, 20)
        Me.ldni.TabIndex = 14
        Me.ldni.Text = "DNI:"
        '
        'lClave
        '
        Me.lClave.ForeColor = System.Drawing.Color.White
        Me.lClave.Location = New System.Drawing.Point(2, 39)
        Me.lClave.Name = "lClave"
        Me.lClave.Size = New System.Drawing.Size(100, 23)
        Me.lClave.TabIndex = 13
        Me.lClave.Text = "Contraseña: "
        '
        'lUsuario
        '
        Me.lUsuario.ForeColor = System.Drawing.Color.White
        Me.lUsuario.Location = New System.Drawing.Point(2, 11)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(118, 23)
        Me.lUsuario.TabIndex = 12
        Me.lUsuario.Text = "Nombre de Usuario:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(178, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(151, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(178, 131)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(151, 20)
        Me.TextBox6.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(178, 106)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(151, 20)
        Me.TextBox5.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(178, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 0
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.Black
        Me.bBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.ForeColor = System.Drawing.Color.White
        Me.bBuscar.Location = New System.Drawing.Point(313, 58)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 48
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.Size = New System.Drawing.Size(485, 258)
        Me.DataGridView1.TabIndex = 47
        '
        'lBusque
        '
        Me.lBusque.AutoSize = True
        Me.lBusque.BackColor = System.Drawing.Color.Black
        Me.lBusque.ForeColor = System.Drawing.Color.White
        Me.lBusque.Location = New System.Drawing.Point(11, 63)
        Me.lBusque.Name = "lBusque"
        Me.lBusque.Size = New System.Drawing.Size(51, 13)
        Me.lBusque.TabIndex = 46
        Me.lBusque.Text = "Usuarios:"
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(87, 60)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(220, 20)
        Me.tBuscar.TabIndex = 45
        '
        'fUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 388)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.bCrear)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lBusque)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.bMenu)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBotones.ResumeLayout(False)
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bSalir As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bMenu As Button
    Friend WithEvents lLegajo As Label
    Friend WithEvents bCrear As Button
    Friend WithEvents pBotones As Panel
    Friend WithEvents bEliminar As Button
    Friend WithEvents bCambio As Button
    Friend WithEvents pCampos As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lMail As Label
    Friend WithEvents ldni As Label
    Friend WithEvents lClave As Label
    Friend WithEvents lUsuario As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lBusque As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents lNombre As Label
    Friend WithEvents lApellido As Label
    Friend WithEvents TextBox4 As TextBox
End Class
