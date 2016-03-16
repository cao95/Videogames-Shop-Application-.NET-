<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compra))
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.lsbVideojuegos = New System.Windows.Forms.ListBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.lsbListaCompra = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreProductora = New System.Windows.Forms.TextBox()
        Me.txtPaisProductora = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGeneroVideojuego = New System.Windows.Forms.TextBox()
        Me.txtValoracionVideojuego = New System.Windows.Forms.TextBox()
        Me.txtDuracionVideojuego = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAñoVideojuego = New System.Windows.Forms.TextBox()
        Me.pcbVideojuegos = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPreciojuego = New System.Windows.Forms.TextBox()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pcbVideojuegos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(628, 312)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(165, 75)
        Me.btnComprar.TabIndex = 0
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'lsbVideojuegos
        '
        Me.lsbVideojuegos.FormattingEnabled = True
        Me.lsbVideojuegos.Location = New System.Drawing.Point(13, 39)
        Me.lsbVideojuegos.Name = "lsbVideojuegos"
        Me.lsbVideojuegos.Size = New System.Drawing.Size(144, 134)
        Me.lsbVideojuegos.TabIndex = 1
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(82, 176)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 146)
        Me.btnAñadir.TabIndex = 3
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.btnDeshacer.Location = New System.Drawing.Point(12, 176)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(64, 146)
        Me.btnDeshacer.TabIndex = 4
        Me.btnDeshacer.Text = "Deshacer"
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'lsbListaCompra
        '
        Me.lsbListaCompra.FormattingEnabled = True
        Me.lsbListaCompra.Location = New System.Drawing.Point(628, 38)
        Me.lsbListaCompra.Name = "lsbListaCompra"
        Me.lsbListaCompra.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lsbListaCompra.Size = New System.Drawing.Size(165, 264)
        Me.lsbListaCompra.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(797, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Datos de la Productora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(797, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(799, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Pais"
        '
        'txtNombreProductora
        '
        Me.txtNombreProductora.Location = New System.Drawing.Point(851, 40)
        Me.txtNombreProductora.Name = "txtNombreProductora"
        Me.txtNombreProductora.ReadOnly = True
        Me.txtNombreProductora.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreProductora.TabIndex = 10
        '
        'txtPaisProductora
        '
        Me.txtPaisProductora.Location = New System.Drawing.Point(851, 67)
        Me.txtPaisProductora.Name = "txtPaisProductora"
        Me.txtPaisProductora.ReadOnly = True
        Me.txtPaisProductora.Size = New System.Drawing.Size(100, 20)
        Me.txtPaisProductora.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(797, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Datos del Videojuego"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(799, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Genero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(799, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Valoración"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(799, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Duración"
        '
        'txtGeneroVideojuego
        '
        Me.txtGeneroVideojuego.Location = New System.Drawing.Point(859, 139)
        Me.txtGeneroVideojuego.Name = "txtGeneroVideojuego"
        Me.txtGeneroVideojuego.ReadOnly = True
        Me.txtGeneroVideojuego.Size = New System.Drawing.Size(89, 20)
        Me.txtGeneroVideojuego.TabIndex = 17
        '
        'txtValoracionVideojuego
        '
        Me.txtValoracionVideojuego.Location = New System.Drawing.Point(859, 176)
        Me.txtValoracionVideojuego.Name = "txtValoracionVideojuego"
        Me.txtValoracionVideojuego.ReadOnly = True
        Me.txtValoracionVideojuego.Size = New System.Drawing.Size(89, 20)
        Me.txtValoracionVideojuego.TabIndex = 18
        '
        'txtDuracionVideojuego
        '
        Me.txtDuracionVideojuego.Location = New System.Drawing.Point(859, 207)
        Me.txtDuracionVideojuego.Name = "txtDuracionVideojuego"
        Me.txtDuracionVideojuego.ReadOnly = True
        Me.txtDuracionVideojuego.Size = New System.Drawing.Size(89, 20)
        Me.txtDuracionVideojuego.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(799, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Año"
        '
        'txtAñoVideojuego
        '
        Me.txtAñoVideojuego.Location = New System.Drawing.Point(859, 241)
        Me.txtAñoVideojuego.Name = "txtAñoVideojuego"
        Me.txtAñoVideojuego.ReadOnly = True
        Me.txtAñoVideojuego.Size = New System.Drawing.Size(87, 20)
        Me.txtAñoVideojuego.TabIndex = 21
        '
        'pcbVideojuegos
        '
        Me.pcbVideojuegos.BackColor = System.Drawing.Color.Transparent
        Me.pcbVideojuegos.Location = New System.Drawing.Point(163, 13)
        Me.pcbVideojuegos.Name = "pcbVideojuegos"
        Me.pcbVideojuegos.Size = New System.Drawing.Size(459, 403)
        Me.pcbVideojuegos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbVideojuegos.TabIndex = 22
        Me.pcbVideojuegos.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 329)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(145, 58)
        Me.btnLimpiar.TabIndex = 23
        Me.btnLimpiar.Text = "Limpiar Lista de la compra"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Catalogo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(629, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Lista de la compra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(826, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Precio del juego"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(826, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Precio total"
        '
        'txtPreciojuego
        '
        Me.txtPreciojuego.Location = New System.Drawing.Point(829, 306)
        Me.txtPreciojuego.Name = "txtPreciojuego"
        Me.txtPreciojuego.ReadOnly = True
        Me.txtPreciojuego.Size = New System.Drawing.Size(100, 20)
        Me.txtPreciojuego.TabIndex = 28
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Location = New System.Drawing.Point(829, 358)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.ReadOnly = True
        Me.txtPrecioTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioTotal.TabIndex = 29
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 393)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(145, 23)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "Salir de Compra"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(628, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(962, 419)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtPrecioTotal)
        Me.Controls.Add(Me.txtPreciojuego)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.pcbVideojuegos)
        Me.Controls.Add(Me.txtAñoVideojuego)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDuracionVideojuego)
        Me.Controls.Add(Me.txtValoracionVideojuego)
        Me.Controls.Add(Me.txtGeneroVideojuego)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPaisProductora)
        Me.Controls.Add(Me.txtNombreProductora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsbListaCompra)
        Me.Controls.Add(Me.btnDeshacer)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lsbVideojuegos)
        Me.Controls.Add(Me.btnComprar)
        Me.Name = "Compra"
        Me.Text = "Compra"
        CType(Me.pcbVideojuegos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnComprar As System.Windows.Forms.Button
    Friend WithEvents lsbVideojuegos As System.Windows.Forms.ListBox
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents btnDeshacer As System.Windows.Forms.Button
    Friend WithEvents lsbListaCompra As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombreProductora As System.Windows.Forms.TextBox
    Friend WithEvents txtPaisProductora As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGeneroVideojuego As System.Windows.Forms.TextBox
    Friend WithEvents txtValoracionVideojuego As System.Windows.Forms.TextBox
    Friend WithEvents txtDuracionVideojuego As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAñoVideojuego As System.Windows.Forms.TextBox
    Friend WithEvents pcbVideojuegos As System.Windows.Forms.PictureBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPreciojuego As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
