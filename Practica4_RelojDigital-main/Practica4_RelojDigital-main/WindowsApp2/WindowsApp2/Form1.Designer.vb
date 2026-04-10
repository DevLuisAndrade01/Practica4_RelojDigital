<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.horas = New System.Windows.Forms.Label()
        Me.minutes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.Label()
        Me.fechas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.Location = New System.Drawing.Point(45, 42)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(151, 108)
        Me.horas.TabIndex = 0
        Me.horas.Text = "00"
        '
        'minutes
        '
        Me.minutes.AutoSize = True
        Me.minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutes.Location = New System.Drawing.Point(236, 42)
        Me.minutes.Name = "minutes"
        Me.minutes.Size = New System.Drawing.Size(151, 108)
        Me.minutes.TabIndex = 1
        Me.minutes.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 108)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'dias
        '
        Me.dias.AutoSize = True
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.Location = New System.Drawing.Point(56, 183)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(156, 55)
        Me.dias.TabIndex = 3
        Me.dias.Text = "Lunes"
        '
        'fechas
        '
        Me.fechas.AutoSize = True
        Me.fechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechas.Location = New System.Drawing.Point(56, 256)
        Me.fechas.Name = "fechas"
        Me.fechas.Size = New System.Drawing.Size(296, 33)
        Me.fechas.TabIndex = 4
        Me.fechas.Text = "09 de marzo del 2025"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.Smiling_friendsa
        Me.PictureBox1.Location = New System.Drawing.Point(378, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(727, 339)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.fechas)
        Me.Controls.Add(Me.dias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.minutes)
        Me.Controls.Add(Me.horas)
        Me.Name = "Form1"
        Me.Text = "RelojDigital"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents horas As Label
    Friend WithEvents minutes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dias As Label
    Friend WithEvents fechas As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
