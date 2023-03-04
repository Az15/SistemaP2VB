<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fProveedor
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
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lFax = New System.Windows.Forms.Label()
        Me.lPais = New System.Windows.Forms.Label()
        Me.lcontacto = New System.Windows.Forms.Label()
        Me.lMail = New System.Windows.Forms.Label()
        Me.lDomi = New System.Windows.Forms.Label()
        Me.lCuit = New System.Windows.Forms.Label()
        Me.lAlias = New System.Windows.Forms.Label()
        Me.lEmpresa = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lBusque = New System.Windows.Forms.Label()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bCambio = New System.Windows.Forms.Button()
        Me.bCrear = New System.Windows.Forms.Button()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.bMenu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pCampos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBotones.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.Transparent
        Me.pCampos.Controls.Add(Me.DateTimePicker1)
        Me.pCampos.Controls.Add(Me.CheckBox1)
        Me.pCampos.Controls.Add(Me.TextBox2)
        Me.pCampos.Controls.Add(Me.Label1)
        Me.pCampos.Controls.Add(Me.Label9)
        Me.pCampos.Controls.Add(Me.lFax)
        Me.pCampos.Controls.Add(Me.lPais)
        Me.pCampos.Controls.Add(Me.lcontacto)
        Me.pCampos.Controls.Add(Me.lMail)
        Me.pCampos.Controls.Add(Me.lDomi)
        Me.pCampos.Controls.Add(Me.lCuit)
        Me.pCampos.Controls.Add(Me.lAlias)
        Me.pCampos.Controls.Add(Me.lEmpresa)
        Me.pCampos.Controls.Add(Me.TextBox3)
        Me.pCampos.Controls.Add(Me.TextBox4)
        Me.pCampos.Controls.Add(Me.TextBox8)
        Me.pCampos.Controls.Add(Me.TextBox7)
        Me.pCampos.Controls.Add(Me.TextBox6)
        Me.pCampos.Controls.Add(Me.TextBox5)
        Me.pCampos.Controls.Add(Me.TextBox1)
        Me.pCampos.Location = New System.Drawing.Point(529, 93)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(329, 284)
        Me.pCampos.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(227, 230)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(224, 254)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "Activo"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(178, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(175, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Estado:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(2, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fecha De Alta:"
        '
        'lFax
        '
        Me.lFax.Location = New System.Drawing.Point(2, 204)
        Me.lFax.Name = "lFax"
        Me.lFax.Size = New System.Drawing.Size(100, 23)
        Me.lFax.TabIndex = 19
        Me.lFax.Text = "Fax:"
        '
        'lPais
        '
        Me.lPais.Location = New System.Drawing.Point(2, 176)
        Me.lPais.Name = "lPais"
        Me.lPais.Size = New System.Drawing.Size(100, 23)
        Me.lPais.TabIndex = 18
        Me.lPais.Text = "Pais"
        '
        'lcontacto
        '
        Me.lcontacto.Location = New System.Drawing.Point(2, 148)
        Me.lcontacto.Name = "lcontacto"
        Me.lcontacto.Size = New System.Drawing.Size(118, 23)
        Me.lcontacto.TabIndex = 17
        Me.lcontacto.Text = "Numero De Contacto;"
        '
        'lMail
        '
        Me.lMail.Location = New System.Drawing.Point(3, 119)
        Me.lMail.Name = "lMail"
        Me.lMail.Size = New System.Drawing.Size(100, 23)
        Me.lMail.TabIndex = 16
        Me.lMail.Text = "eMail:"
        '
        'lDomi
        '
        Me.lDomi.Location = New System.Drawing.Point(2, 93)
        Me.lDomi.Name = "lDomi"
        Me.lDomi.Size = New System.Drawing.Size(100, 23)
        Me.lDomi.TabIndex = 15
        Me.lDomi.Text = "Domicilio Fiscal:"
        '
        'lCuit
        '
        Me.lCuit.Location = New System.Drawing.Point(3, 67)
        Me.lCuit.Name = "lCuit"
        Me.lCuit.Size = New System.Drawing.Size(100, 20)
        Me.lCuit.TabIndex = 14
        Me.lCuit.Text = "Cuit:"
        '
        'lAlias
        '
        Me.lAlias.Location = New System.Drawing.Point(2, 39)
        Me.lAlias.Name = "lAlias"
        Me.lAlias.Size = New System.Drawing.Size(100, 23)
        Me.lAlias.TabIndex = 13
        Me.lAlias.Text = "Alias:"
        '
        'lEmpresa
        '
        Me.lEmpresa.Location = New System.Drawing.Point(2, 11)
        Me.lEmpresa.Name = "lEmpresa"
        Me.lEmpresa.Size = New System.Drawing.Size(100, 23)
        Me.lEmpresa.TabIndex = 12
        Me.lEmpresa.Text = "Empresa:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(178, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(151, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(178, 89)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(151, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(178, 202)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(151, 20)
        Me.TextBox8.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(178, 173)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(151, 20)
        Me.TextBox7.TabIndex = 3
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(178, 146)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(151, 20)
        Me.TextBox6.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(178, 117)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(151, 20)
        Me.TextBox5.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(178, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 0
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.bBuscar.Location = New System.Drawing.Point(329, 60)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 12
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(12, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.Size = New System.Drawing.Size(471, 372)
        Me.DataGridView1.TabIndex = 11
        '
        'lBusque
        '
        Me.lBusque.AutoSize = True
        Me.lBusque.Location = New System.Drawing.Point(12, 65)
        Me.lBusque.Name = "lBusque"
        Me.lBusque.Size = New System.Drawing.Size(70, 13)
        Me.lBusque.TabIndex = 10
        Me.lBusque.Text = "Proveedores:"
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(103, 62)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(220, 20)
        Me.tBuscar.TabIndex = 9
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Location = New System.Drawing.Point(860, -2)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(40, 36)
        Me.bSalir.TabIndex = 16
        Me.bSalir.Text = "x"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(821, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 36)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.Transparent
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bCambio)
        Me.pBotones.Location = New System.Drawing.Point(529, 395)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(329, 52)
        Me.pBotones.TabIndex = 18
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.Location = New System.Drawing.Point(227, 8)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(75, 37)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bCambio
        '
        Me.bCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCambio.Location = New System.Drawing.Point(26, 8)
        Me.bCambio.Name = "bCambio"
        Me.bCambio.Size = New System.Drawing.Size(75, 37)
        Me.bCambio.TabIndex = 0
        Me.bCambio.Text = "Aceptar Cambios"
        Me.bCambio.UseVisualStyleBackColor = True
        '
        'bCrear
        '
        Me.bCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCrear.Location = New System.Drawing.Point(660, 404)
        Me.bCrear.Name = "bCrear"
        Me.bCrear.Size = New System.Drawing.Size(75, 37)
        Me.bCrear.TabIndex = 1
        Me.bCrear.Text = "Crear Cliente"
        Me.bCrear.UseVisualStyleBackColor = True
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(840, 69)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(13, 13)
        Me.lLegajo.TabIndex = 41
        Me.lLegajo.Text = "0"
        '
        'bMenu
        '
        Me.bMenu.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMenu.Location = New System.Drawing.Point(408, 53)
        Me.bMenu.Name = "bMenu"
        Me.bMenu.Size = New System.Drawing.Size(75, 37)
        Me.bMenu.TabIndex = 42
        Me.bMenu.Text = "Volver Al Menu"
        Me.bMenu.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(902, 36)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'fProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(897, 494)
        Me.Controls.Add(Me.bMenu)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.bCrear)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lBusque)
        Me.Controls.Add(Me.tBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fProveedor"
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBotones.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pCampos As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lFax As Label
    Friend WithEvents lPais As Label
    Friend WithEvents lcontacto As Label
    Friend WithEvents lMail As Label
    Friend WithEvents lDomi As Label
    Friend WithEvents lCuit As Label
    Friend WithEvents lAlias As Label
    Friend WithEvents lEmpresa As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lBusque As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bSalir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pBotones As Panel
    Friend WithEvents bEliminar As Button
    Friend WithEvents bCrear As Button
    Friend WithEvents bCambio As Button
    Friend WithEvents lLegajo As Label
    Friend WithEvents bMenu As Button
End Class
