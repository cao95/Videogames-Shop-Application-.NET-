<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Añadir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Añadir))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtValoracion = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreProductora = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtFundacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRegistrarVideojuego = New System.Windows.Forms.Button()
        Me.btnRegistrarProductora = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbIdProductora = New System.Windows.Forms.ComboBox()
        Me.pcbFotoAñade = New System.Windows.Forms.PictureBox()
        Me.btnAñadirFoto = New System.Windows.Forms.Button()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.pcbFotoAñade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titulo"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(59, 56)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTitulo.TabIndex = 2
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(59, 83)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(100, 20)
        Me.txtGenero.TabIndex = 3
        '
        'txtValoracion
        '
        Me.txtValoracion.Location = New System.Drawing.Point(120, 110)
        Me.txtValoracion.Name = "txtValoracion"
        Me.txtValoracion.Size = New System.Drawing.Size(100, 20)
        Me.txtValoracion.TabIndex = 4
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(120, 137)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(100, 20)
        Me.txtDuracion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Genero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(13, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Valoracion Personal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(13, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Duración media"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(16, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Datos del videojuego"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(16, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Año de publicacion"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(119, 160)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre de productora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(12, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Pais"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(12, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Año de fundacion"
        '
        'txtNombreProductora
        '
        Me.txtNombreProductora.Location = New System.Drawing.Point(132, 254)
        Me.txtNombreProductora.Name = "txtNombreProductora"
        Me.txtNombreProductora.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreProductora.TabIndex = 15
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(45, 277)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(100, 20)
        Me.txtPais.TabIndex = 16
        '
        'txtFundacion
        '
        Me.txtFundacion.Location = New System.Drawing.Point(109, 299)
        Me.txtFundacion.Name = "txtFundacion"
        Me.txtFundacion.Size = New System.Drawing.Size(100, 20)
        Me.txtFundacion.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(11, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Datos de la productora"
        '
        'btnRegistrarVideojuego
        '
        Me.btnRegistrarVideojuego.Location = New System.Drawing.Point(15, 205)
        Me.btnRegistrarVideojuego.Name = "btnRegistrarVideojuego"
        Me.btnRegistrarVideojuego.Size = New System.Drawing.Size(204, 23)
        Me.btnRegistrarVideojuego.TabIndex = 19
        Me.btnRegistrarVideojuego.Text = "Registrar Videojuego"
        Me.btnRegistrarVideojuego.UseVisualStyleBackColor = True
        '
        'btnRegistrarProductora
        '
        Me.btnRegistrarProductora.Location = New System.Drawing.Point(12, 323)
        Me.btnRegistrarProductora.Name = "btnRegistrarProductora"
        Me.btnRegistrarProductora.Size = New System.Drawing.Size(181, 23)
        Me.btnRegistrarProductora.TabIndex = 20
        Me.btnRegistrarProductora.Text = "Registrar Productora"
        Me.btnRegistrarProductora.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(227, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "ID Productora"
        '
        'cmbIdProductora
        '
        Me.cmbIdProductora.FormattingEnabled = True
        Me.cmbIdProductora.Location = New System.Drawing.Point(307, 54)
        Me.cmbIdProductora.Name = "cmbIdProductora"
        Me.cmbIdProductora.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdProductora.TabIndex = 22
        '
        'pcbFotoAñade
        '
        Me.pcbFotoAñade.Location = New System.Drawing.Point(524, 10)
        Me.pcbFotoAñade.Name = "pcbFotoAñade"
        Me.pcbFotoAñade.Size = New System.Drawing.Size(270, 241)
        Me.pcbFotoAñade.TabIndex = 23
        Me.pcbFotoAñade.TabStop = False
        '
        'btnAñadirFoto
        '
        Me.btnAñadirFoto.Location = New System.Drawing.Point(524, 272)
        Me.btnAñadirFoto.Name = "btnAñadirFoto"
        Me.btnAñadirFoto.Size = New System.Drawing.Size(270, 23)
        Me.btnAñadirFoto.TabIndex = 24
        Me.btnAñadirFoto.Text = "Añadir Foto"
        Me.btnAñadirFoto.UseVisualStyleBackColor = True
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "OpenFileDialog1"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(524, 323)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(270, 23)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir de Añadir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Añadir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(929, 358)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAñadirFoto)
        Me.Controls.Add(Me.pcbFotoAñade)
        Me.Controls.Add(Me.cmbIdProductora)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnRegistrarProductora)
        Me.Controls.Add(Me.btnRegistrarVideojuego)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFundacion)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtNombreProductora)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtValoracion)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Añadir"
        Me.Text = "Añadir"
        CType(Me.pcbFotoAñade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtValoracion As System.Windows.Forms.TextBox
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNombreProductora As System.Windows.Forms.TextBox
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents txtFundacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarVideojuego As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarProductora As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbIdProductora As System.Windows.Forms.ComboBox
    Friend WithEvents pcbFotoAñade As System.Windows.Forms.PictureBox
    Friend WithEvents btnAñadirFoto As System.Windows.Forms.Button
    Friend WithEvents ofdFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
