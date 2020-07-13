<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaContrata
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
        Me.txtIDPersona = New System.Windows.Forms.TextBox()
        Me.txtIDServicio = New System.Windows.Forms.TextBox()
        Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
        Me.txtFechaContratacion = New System.Windows.Forms.TextBox()
        Me.txtFechaFinContrato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnDarAlta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIDPersona
        '
        Me.txtIDPersona.Location = New System.Drawing.Point(130, 86)
        Me.txtIDPersona.Name = "txtIDPersona"
        Me.txtIDPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPersona.TabIndex = 0
        '
        'txtIDServicio
        '
        Me.txtIDServicio.Location = New System.Drawing.Point(130, 112)
        Me.txtIDServicio.Name = "txtIDServicio"
        Me.txtIDServicio.Size = New System.Drawing.Size(100, 20)
        Me.txtIDServicio.TabIndex = 1
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.Location = New System.Drawing.Point(130, 138)
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaCreacion.TabIndex = 2
        '
        'txtFechaContratacion
        '
        Me.txtFechaContratacion.Location = New System.Drawing.Point(130, 164)
        Me.txtFechaContratacion.Name = "txtFechaContratacion"
        Me.txtFechaContratacion.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaContratacion.TabIndex = 3
        '
        'txtFechaFinContrato
        '
        Me.txtFechaFinContrato.Location = New System.Drawing.Point(130, 190)
        Me.txtFechaFinContrato.Name = "txtFechaFinContrato"
        Me.txtFechaFinContrato.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaFinContrato.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IDPersona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "IDServicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha Contratacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha creacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha fin de contrato"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(86, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Alta contrata"
        '
        'BtnDarAlta
        '
        Me.BtnDarAlta.Location = New System.Drawing.Point(130, 230)
        Me.BtnDarAlta.Name = "BtnDarAlta"
        Me.BtnDarAlta.Size = New System.Drawing.Size(100, 23)
        Me.BtnDarAlta.TabIndex = 11
        Me.BtnDarAlta.Text = "Dar alta"
        Me.BtnDarAlta.UseVisualStyleBackColor = True
        '
        'AltaContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 287)
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
        Me.Name = "AltaContrata"
        Me.Text = "AltaContrata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIDPersona As TextBox
    Friend WithEvents txtIDServicio As TextBox
    Friend WithEvents txtFechaCreacion As TextBox
    Friend WithEvents txtFechaContratacion As TextBox
    Friend WithEvents txtFechaFinContrato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnDarAlta As Button
End Class
