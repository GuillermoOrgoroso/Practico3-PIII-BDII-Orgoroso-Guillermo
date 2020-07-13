<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaPersona
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
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDPersona = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDarBaja
        '
        Me.btnDarBaja.Location = New System.Drawing.Point(71, 107)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(100, 21)
        Me.btnDarBaja.TabIndex = 7
        Me.btnDarBaja.Text = "Dar baja"
        Me.btnDarBaja.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "IDPersona"
        '
        'txtIDPersona
        '
        Me.txtIDPersona.Location = New System.Drawing.Point(71, 79)
        Me.txtIDPersona.Name = "txtIDPersona"
        Me.txtIDPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPersona.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dar baja"
        '
        'BajaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 151)
        Me.Controls.Add(Me.btnDarBaja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIDPersona)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BajaPersona"
        Me.Text = "BajaPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDarBaja As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDPersona As TextBox
    Friend WithEvents Label1 As Label
End Class
