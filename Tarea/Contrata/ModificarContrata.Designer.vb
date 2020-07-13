<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarContrata
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
        Me.BtnDarAlta = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFechaFinContrato = New System.Windows.Forms.TextBox()
        Me.txtFechaContratacion = New System.Windows.Forms.TextBox()
        Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
        Me.txtIDServicio = New System.Windows.Forms.TextBox()
        Me.txtIDPersona = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnDarAlta
        '
        Me.BtnDarAlta.Location = New System.Drawing.Point(126, 213)
        Me.BtnDarAlta.Name = "BtnDarAlta"
        Me.BtnDarAlta.Size = New System.Drawing.Size(100, 23)
        Me.BtnDarAlta.TabIndex = 23
        Me.BtnDarAlta.Text = "Modificar"
        Me.BtnDarAlta.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 29)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Modificar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Fecha fin de contrato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fecha creacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fecha Contratacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "IDServicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "IDPersona"
        '
        'txtFechaFinContrato
        '
        Me.txtFechaFinContrato.Location = New System.Drawing.Point(126, 173)
        Me.txtFechaFinContrato.Name = "txtFechaFinContrato"
        Me.txtFechaFinContrato.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaFinContrato.TabIndex = 16
        '
        'txtFechaContratacion
        '
        Me.txtFechaContratacion.Location = New System.Drawing.Point(126, 147)
        Me.txtFechaContratacion.Name = "txtFechaContratacion"
        Me.txtFechaContratacion.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaContratacion.TabIndex = 15
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.Location = New System.Drawing.Point(126, 121)
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaCreacion.TabIndex = 14
        '
        'txtIDServicio
        '
        Me.txtIDServicio.Location = New System.Drawing.Point(126, 95)
        Me.txtIDServicio.Name = "txtIDServicio"
        Me.txtIDServicio.Size = New System.Drawing.Size(100, 20)
        Me.txtIDServicio.TabIndex = 13
        '
        'txtIDPersona
        '
        Me.txtIDPersona.Location = New System.Drawing.Point(126, 69)
        Me.txtIDPersona.Name = "txtIDPersona"
        Me.txtIDPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPersona.TabIndex = 12
        '
        'ModificarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 280)
        Me.Controls.Add(Me.BtnDarAlta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFechaFinContrato)
        Me.Controls.Add(Me.txtFechaContratacion)
        Me.Controls.Add(Me.txtFechaCreacion)
        Me.Controls.Add(Me.txtIDServicio)
        Me.Controls.Add(Me.txtIDPersona)
        Me.Name = "ModificarContrata"
        Me.Text = "ModificarContrata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDarAlta As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFechaFinContrato As TextBox
    Friend WithEvents txtFechaContratacion As TextBox
    Friend WithEvents txtFechaCreacion As TextBox
    Friend WithEvents txtIDServicio As TextBox
    Friend WithEvents txtIDPersona As TextBox
End Class
