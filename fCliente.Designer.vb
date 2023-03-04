<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fCliente
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
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.lBusque = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bCambio = New System.Windows.Forms.Button()
        Me.bCrear = New System.Windows.Forms.Button()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lEstado = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lFax = New System.Windows.Forms.Label()
        Me.lPais = New System.Windows.Forms.Label()
        Me.lcontacto = New System.Windows.Forms.Label()
        Me.lMail = New System.Windows.Forms.Label()
        Me.lDomi = New System.Windows.Forms.Label()
        Me.lCuit = New System.Windows.Forms.Label()
        Me.lAlias = New System.Windows.Forms.Label()
        Me.lEmpresa = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.bMenu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBotones.SuspendLayout()
        Me.pCampos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bSalir
        '
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(927, -4)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(39, 36)
        Me.bSalir.TabIndex = 1
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bMinimizar
        '
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(890, -4)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(39, 36)
        Me.bMinimizar.TabIndex = 2
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(126, 60)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(220, 20)
        Me.tBuscar.TabIndex = 3
        '
        'lBusque
        '
        Me.lBusque.AutoSize = True
        Me.lBusque.Location = New System.Drawing.Point(12, 63)
        Me.lBusque.Name = "lBusque"
        Me.lBusque.Size = New System.Drawing.Size(108, 13)
        Me.lBusque.TabIndex = 4
        Me.lBusque.Text = "Nombre De Empresa:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.Size = New System.Drawing.Size(503, 416)
        Me.DataGridView1.TabIndex = 5
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.bBuscar.Location = New System.Drawing.Point(352, 58)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 6
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bCambio)
        Me.pBotones.Location = New System.Drawing.Point(593, 450)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(329, 52)
        Me.pBotones.TabIndex = 7
        '
        'bEliminar
        '
        Me.bEliminar.Location = New System.Drawing.Point(227, 8)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(75, 37)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bCambio
        '
        Me.bCambio.Location = New System.Drawing.Point(26, 8)
        Me.bCambio.Name = "bCambio"
        Me.bCambio.Size = New System.Drawing.Size(75, 37)
        Me.bCambio.TabIndex = 0
        Me.bCambio.Text = "Aceptar Cambios"
        Me.bCambio.UseVisualStyleBackColor = True
        '
        'bCrear
        '
        Me.bCrear.Location = New System.Drawing.Point(724, 458)
        Me.bCrear.Name = "bCrear"
        Me.bCrear.Size = New System.Drawing.Size(75, 37)
        Me.bCrear.TabIndex = 1
        Me.bCrear.Text = "Crear Cliente"
        Me.bCrear.UseVisualStyleBackColor = True
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pCampos.Controls.Add(Me.DateTimePicker1)
        Me.pCampos.Controls.Add(Me.CheckBox1)
        Me.pCampos.Controls.Add(Me.TextBox1)
        Me.pCampos.Controls.Add(Me.lEstado)
        Me.pCampos.Controls.Add(Me.Label11)
        Me.pCampos.Controls.Add(Me.Label10)
        Me.pCampos.Controls.Add(Me.Label9)
        Me.pCampos.Controls.Add(Me.lFax)
        Me.pCampos.Controls.Add(Me.lPais)
        Me.pCampos.Controls.Add(Me.lcontacto)
        Me.pCampos.Controls.Add(Me.lMail)
        Me.pCampos.Controls.Add(Me.lDomi)
        Me.pCampos.Controls.Add(Me.lCuit)
        Me.pCampos.Controls.Add(Me.lAlias)
        Me.pCampos.Controls.Add(Me.lEmpresa)
        Me.pCampos.Controls.Add(Me.TextBox10)
        Me.pCampos.Controls.Add(Me.TextBox9)
        Me.pCampos.Controls.Add(Me.TextBox3)
        Me.pCampos.Controls.Add(Me.TextBox4)
        Me.pCampos.Controls.Add(Me.TextBox8)
        Me.pCampos.Controls.Add(Me.TextBox7)
        Me.pCampos.Controls.Add(Me.TextBox6)
        Me.pCampos.Controls.Add(Me.TextBox5)
        Me.pCampos.Controls.Add(Me.TextBox2)
        Me.pCampos.Location = New System.Drawing.Point(594, 86)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(329, 358)
        Me.pCampos.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(228, 232)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(227, 330)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "Activo"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(177, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 24
        '
        'lEstado
        '
        Me.lEstado.BackColor = System.Drawing.Color.Transparent
        Me.lEstado.Location = New System.Drawing.Point(175, 331)
        Me.lEstado.Name = "lEstado"
        Me.lEstado.Size = New System.Drawing.Size(46, 23)
        Me.lEstado.TabIndex = 23
        Me.lEstado.Text = "Estado:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(2, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Clave:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(1, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Usuario:"
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
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(177, 296)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(151, 20)
        Me.TextBox10.TabIndex = 10
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(177, 267)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(151, 20)
        Me.TextBox9.TabIndex = 9
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(177, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 0
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(908, 70)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(13, 13)
        Me.lLegajo.TabIndex = 9
        Me.lLegajo.Text = "0"
        '
        'bMenu
        '
        Me.bMenu.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMenu.Location = New System.Drawing.Point(443, 46)
        Me.bMenu.Name = "bMenu"
        Me.bMenu.Size = New System.Drawing.Size(75, 37)
        Me.bMenu.TabIndex = 43
        Me.bMenu.Text = "Volver Al Menu"
        Me.bMenu.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(969, 36)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'fCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(965, 514)
        Me.Controls.Add(Me.bMenu)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.bCrear)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lBusque)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fCliente"
        Me.Opacity = 0.97R
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fCliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBotones.ResumeLayout(False)
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bSalir As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents lBusque As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bBuscar As Button
    Friend WithEvents pBotones As Panel
    Friend WithEvents pCampos As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lEstado As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lFax As Label
    Friend WithEvents lPais As Label
    Friend WithEvents lcontacto As Label
    Friend WithEvents lMail As Label
    Friend WithEvents lDomi As Label
    Friend WithEvents lCuit As Label
    Friend WithEvents lAlias As Label
    Friend WithEvents lEmpresa As Label
    Friend WithEvents bEliminar As Button
    Friend WithEvents bCrear As Button
    Friend WithEvents bCambio As Button
    Friend WithEvents lLegajo As Label
    Friend WithEvents bMenu As Button
End Class
