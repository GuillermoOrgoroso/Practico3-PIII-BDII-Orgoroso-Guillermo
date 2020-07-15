<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaServicio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDServicio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCostoMensual = New System.Windows.Forms.TextBox()
        Me.btnDarAlta = New System.Windows.Forms.Button()
        Me.txtFechoYhora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rdoLimpieza = New System.Windows.Forms.RadioButton()
        Me.rdoMantenimiento = New System.Windows.Forms.RadioButton()
        Me.rdoElectricidad = New System.Windows.Forms.RadioButton()
        Me.rdoTelecomunicaciones = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdoInformatica = New System.Windows.Forms.RadioButton()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alta servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Servicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Costo mensual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Seleccione el tipo de servico"
        '
        'txtIDServicio
        '
        Me.txtIDServicio.Location = New System.Drawing.Point(180, 98)
        Me.txtIDServicio.Name = "txtIDServicio"
        Me.txtIDServicio.Size = New System.Drawing.Size(100, 20)
        Me.txtIDServicio.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(180, 124)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtCostoMensual
        '
        Me.txtCostoMensual.Location = New System.Drawing.Point(180, 150)
        Me.txtCostoMensual.Name = "txtCostoMensual"
        Me.txtCostoMensual.Size = New System.Drawing.Size(100, 20)
        Me.txtCostoMensual.TabIndex = 7
        '
        'btnDarAlta
        '
        Me.btnDarAlta.Location = New System.Drawing.Point(180, 347)
        Me.btnDarAlta.Name = "btnDarAlta"
        Me.btnDarAlta.Size = New System.Drawing.Size(388, 23)
        Me.btnDarAlta.TabIndex = 9
        Me.btnDarAlta.Text = "Dar alta"
        Me.btnDarAlta.UseVisualStyleBackColor = True
        '
        'txtFechoYhora
        '
        Me.txtFechoYhora.Location = New System.Drawing.Point(180, 180)
        Me.txtFechoYhora.Name = "txtFechoYhora"
        Me.txtFechoYhora.Size = New System.Drawing.Size(100, 20)
        Me.txtFechoYhora.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha y hora de creacion"
        '
        'rdoLimpieza
        '
        Me.rdoLimpieza.AutoSize = True
        Me.rdoLimpieza.Location = New System.Drawing.Point(50, 268)
        Me.rdoLimpieza.Name = "rdoLimpieza"
        Me.rdoLimpieza.Size = New System.Drawing.Size(66, 17)
        Me.rdoLimpieza.TabIndex = 14
        Me.rdoLimpieza.TabStop = True
        Me.rdoLimpieza.Text = "Limpieza"
        Me.rdoLimpieza.UseVisualStyleBackColor = True
        '
        'rdoMantenimiento
        '
        Me.rdoMantenimiento.AutoSize = True
        Me.rdoMantenimiento.Location = New System.Drawing.Point(146, 268)
        Me.rdoMantenimiento.Name = "rdoMantenimiento"
        Me.rdoMantenimiento.Size = New System.Drawing.Size(94, 17)
        Me.rdoMantenimiento.TabIndex = 15
        Me.rdoMantenimiento.TabStop = True
        Me.rdoMantenimiento.Text = "Mantenimiento"
        Me.rdoMantenimiento.UseVisualStyleBackColor = True
        '
        'rdoElectricidad
        '
        Me.rdoElectricidad.AutoSize = True
        Me.rdoElectricidad.Location = New System.Drawing.Point(242, 268)
        Me.rdoElectricidad.Name = "rdoElectricidad"
        Me.rdoElectricidad.Size = New System.Drawing.Size(80, 17)
        Me.rdoElectricidad.TabIndex = 16
        Me.rdoElectricidad.TabStop = True
        Me.rdoElectricidad.Text = "Electricidad"
        Me.rdoElectricidad.UseVisualStyleBackColor = True
        '
        'rdoTelecomunicaciones
        '
        Me.rdoTelecomunicaciones.AutoSize = True
        Me.rdoTelecomunicaciones.Location = New System.Drawing.Point(338, 268)
        Me.rdoTelecomunicaciones.Name = "rdoTelecomunicaciones"
        Me.rdoTelecomunicaciones.Size = New System.Drawing.Size(123, 17)
        Me.rdoTelecomunicaciones.TabIndex = 17
        Me.rdoTelecomunicaciones.TabStop = True
        Me.rdoTelecomunicaciones.Text = "Telecomunicaciones"
        Me.rdoTelecomunicaciones.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Activo/inactivo"
        '
        'rdoInformatica
        '
        Me.rdoInformatica.AutoSize = True
        Me.rdoInformatica.Location = New System.Drawing.Point(467, 268)
        Me.rdoInformatica.Name = "rdoInformatica"
        Me.rdoInformatica.Size = New System.Drawing.Size(77, 17)
        Me.rdoInformatica.TabIndex = 21
        Me.rdoInformatica.TabStop = True
        Me.rdoInformatica.Text = "Informatica"
        Me.rdoInformatica.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(50, 347)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 22
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'AltaServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 422)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.rdoInformatica)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rdoTelecomunicaciones)
        Me.Controls.Add(Me.rdoElectricidad)
        Me.Controls.Add(Me.rdoMantenimiento)
        Me.Controls.Add(Me.rdoLimpieza)
        Me.Controls.Add(Me.txtFechoYhora)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDarAlta)
        Me.Controls.Add(Me.txtCostoMensual)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIDServicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AltaServicio"
        Me.Text = "AltaServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIDServicio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCostoMensual As TextBox
    Friend WithEvents btnDarAlta As Button
    Friend WithEvents txtFechoYhora As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rdoLimpieza As RadioButton
    Friend WithEvents rdoMantenimiento As RadioButton
    Friend WithEvents rdoElectricidad As RadioButton
    Friend WithEvents rdoTelecomunicaciones As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents rdoInformatica As RadioButton
    Friend WithEvents chkActivo As CheckBox
End Class
