<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tienda))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioSesionMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlquilerMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInstruccionuno = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.CatalogoMenu, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(921, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroMenu, Me.InicioSesionMenu, Me.CerrarSesiónToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.RegistrarToolStripMenuItem.Text = "Usuario"
        '
        'RegistroMenu
        '
        Me.RegistroMenu.Name = "RegistroMenu"
        Me.RegistroMenu.Size = New System.Drawing.Size(143, 22)
        Me.RegistroMenu.Text = "Registrar"
        '
        'InicioSesionMenu
        '
        Me.InicioSesionMenu.Name = "InicioSesionMenu"
        Me.InicioSesionMenu.Size = New System.Drawing.Size(143, 22)
        Me.InicioSesionMenu.Text = "Iniciar Sesión"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'CatalogoMenu
        '
        Me.CatalogoMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompraMenu, Me.AlquilerMenu, Me.AñadirMenu})
        Me.CatalogoMenu.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.CatalogoMenu.Name = "CatalogoMenu"
        Me.CatalogoMenu.Size = New System.Drawing.Size(67, 20)
        Me.CatalogoMenu.Text = "Catalogo"
        '
        'CompraMenu
        '
        Me.CompraMenu.Name = "CompraMenu"
        Me.CompraMenu.Size = New System.Drawing.Size(154, 22)
        Me.CompraMenu.Text = "Comprar"
        '
        'AlquilerMenu
        '
        Me.AlquilerMenu.Name = "AlquilerMenu"
        Me.AlquilerMenu.Size = New System.Drawing.Size(154, 22)
        Me.AlquilerMenu.Text = "Alquilar"
        '
        'AñadirMenu
        '
        Me.AñadirMenu.Name = "AñadirMenu"
        Me.AñadirMenu.Size = New System.Drawing.Size(154, 22)
        Me.AñadirMenu.Text = "Añadir a tienda"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblInstruccionuno
        '
        Me.lblInstruccionuno.AutoSize = True
        Me.lblInstruccionuno.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruccionuno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccionuno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInstruccionuno.Location = New System.Drawing.Point(12, 60)
        Me.lblInstruccionuno.Name = "lblInstruccionuno"
        Me.lblInstruccionuno.Size = New System.Drawing.Size(567, 25)
        Me.lblInstruccionuno.TabIndex = 2
        Me.lblInstruccionuno.Text = "Vaya al apartado usuario e inicie sesión o registrese"
        '
        'Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(921, 451)
        Me.Controls.Add(Me.lblInstruccionuno)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Tienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tienda"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlquilerMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InicioSesionMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblInstruccionuno As System.Windows.Forms.Label

End Class
