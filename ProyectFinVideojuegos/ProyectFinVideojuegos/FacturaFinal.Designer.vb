<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaFinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaFinal))
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lbsListaCompra = New System.Windows.Forms.ListBox()
        Me.pcbImagenFactura = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.pcbImagenFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCompra.Location = New System.Drawing.Point(12, 28)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(39, 13)
        Me.lblCompra.TabIndex = 2
        Me.lblCompra.Text = "Label3"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecio.Location = New System.Drawing.Point(12, 338)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(39, 13)
        Me.lblPrecio.TabIndex = 3
        Me.lblPrecio.Text = "Label1"
        '
        'lbsListaCompra
        '
        Me.lbsListaCompra.FormattingEnabled = True
        Me.lbsListaCompra.Location = New System.Drawing.Point(127, 12)
        Me.lbsListaCompra.Name = "lbsListaCompra"
        Me.lbsListaCompra.ScrollAlwaysVisible = True
        Me.lbsListaCompra.Size = New System.Drawing.Size(320, 95)
        Me.lbsListaCompra.TabIndex = 4
        '
        'pcbImagenFactura
        '
        Me.pcbImagenFactura.Location = New System.Drawing.Point(3, 113)
        Me.pcbImagenFactura.Name = "pcbImagenFactura"
        Me.pcbImagenFactura.Size = New System.Drawing.Size(572, 219)
        Me.pcbImagenFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagenFactura.TabIndex = 5
        Me.pcbImagenFactura.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(329, 338)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(201, 26)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir de la aplicación"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FacturaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(577, 376)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pcbImagenFactura)
        Me.Controls.Add(Me.lbsListaCompra)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCompra)
        Me.Name = "FacturaFinal"
        Me.Text = "FacturaFinal"
        CType(Me.pcbImagenFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lbsListaCompra As System.Windows.Forms.ListBox
    Friend WithEvents pcbImagenFactura As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
