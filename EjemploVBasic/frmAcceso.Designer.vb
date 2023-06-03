<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceso
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
        Me.lnkRestablecer = New System.Windows.Forms.LinkLabel()
        Me.lnkRegistrarse = New System.Windows.Forms.LinkLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.grbAcceso = New System.Windows.Forms.GroupBox()
        Me.lblNombreUser = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grbAcceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnkRestablecer
        '
        Me.lnkRestablecer.AutoSize = True
        Me.lnkRestablecer.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRestablecer.Location = New System.Drawing.Point(594, 437)
        Me.lnkRestablecer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkRestablecer.Name = "lnkRestablecer"
        Me.lnkRestablecer.Size = New System.Drawing.Size(179, 18)
        Me.lnkRestablecer.TabIndex = 15
        Me.lnkRestablecer.TabStop = True
        Me.lnkRestablecer.Text = "¿Olvidó su Contraseña?"
        '
        'lnkRegistrarse
        '
        Me.lnkRegistrarse.AutoSize = True
        Me.lnkRegistrarse.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRegistrarse.Location = New System.Drawing.Point(31, 437)
        Me.lnkRegistrarse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkRegistrarse.Name = "lnkRegistrarse"
        Me.lnkRegistrarse.Size = New System.Drawing.Size(90, 18)
        Me.lnkRegistrarse.TabIndex = 14
        Me.lnkRegistrarse.TabStop = True
        Me.lnkRegistrarse.Text = "Registrarse"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.Location = New System.Drawing.Point(423, 328)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 37)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAceptar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.Location = New System.Drawing.Point(271, 328)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(128, 37)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'grbAcceso
        '
        Me.grbAcceso.Controls.Add(Me.lblNombreUser)
        Me.grbAcceso.Controls.Add(Me.txtUsuario)
        Me.grbAcceso.Controls.Add(Me.lblPassword)
        Me.grbAcceso.Controls.Add(Me.txtContrasena)
        Me.grbAcceso.Cursor = System.Windows.Forms.Cursors.Default
        Me.grbAcceso.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAcceso.Location = New System.Drawing.Point(94, 127)
        Me.grbAcceso.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbAcceso.Name = "grbAcceso"
        Me.grbAcceso.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbAcceso.Size = New System.Drawing.Size(638, 154)
        Me.grbAcceso.TabIndex = 11
        Me.grbAcceso.TabStop = False
        Me.grbAcceso.Text = "Acceso"
        '
        'lblNombreUser
        '
        Me.lblNombreUser.AutoSize = True
        Me.lblNombreUser.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUser.Location = New System.Drawing.Point(24, 46)
        Me.lblNombreUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreUser.Name = "lblNombreUser"
        Me.lblNombreUser.Size = New System.Drawing.Size(224, 25)
        Me.lblNombreUser.TabIndex = 1
        Me.lblNombreUser.Text = "Nombre de Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(266, 46)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(341, 33)
        Me.txtUsuario.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(24, 98)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(134, 25)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(266, 98)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(341, 33)
        Me.txtContrasena.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(266, 49)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(321, 29)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Usuario de la Plataforma"
        '
        'frmAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 485)
        Me.Controls.Add(Me.lnkRestablecer)
        Me.Controls.Add(Me.lnkRegistrarse)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grbAcceso)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmAcceso"
        Me.Text = "Acceso"
        Me.grbAcceso.ResumeLayout(False)
        Me.grbAcceso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lnkRestablecer As LinkLabel
    Private WithEvents lnkRegistrarse As LinkLabel
    Private WithEvents btnCancelar As Button
    Private WithEvents btnAceptar As Button
    Private WithEvents grbAcceso As GroupBox
    Private WithEvents lblNombreUser As Label
    Private WithEvents txtUsuario As TextBox
    Private WithEvents lblPassword As Label
    Private WithEvents txtContrasena As TextBox
    Private WithEvents lblTitulo As Label
End Class
