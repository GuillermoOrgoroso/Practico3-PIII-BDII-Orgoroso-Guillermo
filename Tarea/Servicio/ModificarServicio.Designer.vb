<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarServicio
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFechoYhora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtCostoMensual = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIDServicio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.rdoInformatica = New System.Windows.Forms.RadioButton()
        Me.rdoTelecomunicaciones = New System.Windows.Forms.RadioButton()
        Me.rdoElectricidad = New System.Windows.Forms.RadioButton()
        Me.rdoMantenimiento = New System.Windows.Forms.RadioButton()
        Me.rdoLimpieza = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Activo/inactivo"
        '
        'txtFechoYhora
        '
        Me.txtFechoYhora.Location = New System.Drawing.Point(164, 150)
        Me.txtFechoYhora.Name = "txtFechoYhora"
        Me.txtFechoYhora.Size = New System.Drawing.Size(100, 20)
        Me.txtFechoYhora.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Fecha y hora de creacion"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(489, 291)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 29
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtCostoMensual
        '
        Me.txtCostoMensual.Location = New System.Drawing.Point(164, 120)
        Me.txtCostoMensual.Name = "txtCostoMensual"
        Me.txtCostoMensual.Size = New System.Drawing.Size(100, 20)
        Me.txtCostoMensual.TabIndex = 28
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(164, 94)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 27
        '
        'txtIDServicio
        '
        Me.txtIDServicio.Location = New System.Drawing.Point(164, 68)
        Me.txtIDServicio.Name = "txtIDServicio"
        Me.txtIDServicio.Size = New System.Drawing.Size(100, 20)
        Me.txtIDServicio.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Seleccione el tipo de servico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Costo mensual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "ID Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Modificar servicio"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(34, 308)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 40
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'rdoInformatica
        '
        Me.rdoInformatica.AutoSize = True
        Me.rdoInformatica.Location = New System.Drawing.Point(467, 242)
        Me.rdoInformatica.Name = "rdoInformatica"
        Me.rdoInformatica.Size = New System.Drawing.Size(77, 17)
        Me.rdoInformatica.TabIndex = 45
        Me.rdoInformatica.TabStop = True
        Me.rdoInformatica.Text = "Informatica"
        Me.rdoInformatica.UseVisualStyleBackColor = True
        '
        'rdoTelecomunicaciones
        '
        Me.rdoTelecomunicaciones.AutoSize = True
        Me.rdoTelecomunicaciones.Location = New System.Drawing.Point(338, 242)
        Me.rdoTelecomunicaciones.Name = "rdoTelecomunicaciones"
        Me.rdoTelecomunicaciones.Size = New System.Drawing.Size(123, 17)
        Me.rdoTelecomunicaciones.TabIndex = 44
        Me.rdoTelecomunicaciones.TabStop = True
        Me.rdoTelecomunicaciones.Text = "Telecomunicaciones"
        Me.rdoTelecomunicaciones.UseVisualStyleBackColor = True
        '
        'rdoElectricidad
        '
        Me.rdoElectricidad.AutoSize = True
        Me.rdoElectricidad.Location = New System.Drawing.Point(242, 242)
        Me.rdoElectricidad.Name = "rdoElectricidad"
        Me.rdoElectricidad.Size = New System.Drawing.Size(80, 17)
        Me.rdoElectricidad.TabIndex = 43
        Me.rdoElectricidad.TabStop = True
        Me.rdoElectricidad.Text = "Electricidad"
        Me.rdoElectricidad.UseVisualStyleBackColor = True
        '
        'rdoMantenimiento
        '
        Me.rdoMantenimiento.AutoSize = True
        Me.rdoMantenimiento.Location = New System.Drawing.Point(146, 242)
        Me.rdoMantenimiento.Name = "rdoMantenimiento"
        Me.rdoMantenimiento.Size = New System.Drawing.Size(94, 17)
        Me.rdoMantenimiento.TabIndex = 42
        Me.rdoMantenimiento.TabStop = True
        Me.rdoMantenimiento.Text = "Mantenimiento"
        Me.rdoMantenimiento.UseVisualStyleBackColor = True
        '
        'rdoLimpieza
        '
        Me.rdoLimpieza.AutoSize = True
        Me.rdoLimpieza.Location = New System.Drawing.Point(50, 242)
        Me.rdoLimpieza.Name = "rdoLimpieza"
        Me.rdoLimpieza.Size = New System.Drawing.Size(66, 17)
        Me.rdoLimpieza.TabIndex = 41
        Me.rdoLimpieza.TabStop = True
        Me.rdoLimpieza.Text = "Limpieza"
        Me.rdoLimpieza.UseVisualStyleBackColor = True
        '
        'ModificarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rdoInformatica)
        Me.Controls.Add(Me.rdoTelecomunicaciones)
        Me.Controls.Add(Me.rdoElectricidad)
        Me.Controls.Add(Me.rdoMantenimiento)
        Me.Controls.Add(Me.rdoLimpieza)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFechoYhora)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtCostoMensual)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIDServicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificarServicio"
        Me.Text = "ModificarServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFechoYhora As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtCostoMensual As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIDServicio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents rdoInformatica As RadioButton
    Friend WithEvents rdoTelecomunicaciones As RadioButton
    Friend WithEvents rdoElectricidad As RadioButton
    Friend WithEvents rdoMantenimiento As RadioButton
    Friend WithEvents rdoLimpieza As RadioButton
End Class
