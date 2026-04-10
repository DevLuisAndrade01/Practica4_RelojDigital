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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.reset = New System.Windows.Forms.Button()
        Me.Button_start = New System.Windows.Forms.Button()
        Me.tiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.BackColor = System.Drawing.Color.Transparent
        Me.horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.Location = New System.Drawing.Point(315, 132)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(151, 108)
        Me.horas.TabIndex = 0
        Me.horas.Text = "00"
        '
        'minutes
        '
        Me.minutes.AutoSize = True
        Me.minutes.BackColor = System.Drawing.Color.Transparent
        Me.minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutes.Location = New System.Drawing.Point(524, 132)
        Me.minutes.Name = "minutes"
        Me.minutes.Size = New System.Drawing.Size(151, 108)
        Me.minutes.TabIndex = 1
        Me.minutes.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(459, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 108)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'dias
        '
        Me.dias.AutoSize = True
        Me.dias.BackColor = System.Drawing.Color.Transparent
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.Location = New System.Drawing.Point(422, 240)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(156, 55)
        Me.dias.TabIndex = 3
        Me.dias.Text = "Lunes"
        '
        'fechas
        '
        Me.fechas.AutoSize = True
        Me.fechas.BackColor = System.Drawing.Color.Transparent
        Me.fechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechas.Location = New System.Drawing.Point(341, 295)
        Me.fechas.Name = "fechas"
        Me.fechas.Size = New System.Drawing.Size(296, 33)
        Me.fechas.TabIndex = 4
        Me.fechas.Text = "09 de marzo del 2025"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(281, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 204)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"blanco", "rojo", "azul", "amarillo", "verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(151, 95)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuración"
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.Location = New System.Drawing.Point(595, 237)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(30, 24)
        Me.segundos.TabIndex = 8
        Me.segundos.Text = "00"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.reset)
        Me.Panel2.Controls.Add(Me.Button_start)
        Me.Panel2.Controls.Add(Me.tiempo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(407, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 204)
        Me.Panel2.TabIndex = 9
        Me.Panel2.Visible = False
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(122, 139)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(60, 33)
        Me.reset.TabIndex = 3
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Button_start
        '
        Me.Button_start.Location = New System.Drawing.Point(27, 138)
        Me.Button_start.Name = "Button_start"
        Me.Button_start.Size = New System.Drawing.Size(59, 32)
        Me.Button_start.TabIndex = 2
        Me.Button_start.Text = "start"
        Me.Button_start.UseVisualStyleBackColor = True
        '
        'tiempo
        '
        Me.tiempo.AutoSize = True
        Me.tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.Location = New System.Drawing.Point(11, 67)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(188, 37)
        Me.tiempo.TabIndex = 1
        Me.tiempo.Text = "00:00:00.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cronometro"
        '
        'Timer3
        '
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApp2.My.Resources.Resources._2reloj
        Me.PictureBox4.Location = New System.Drawing.Point(708, 139)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 46)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApp2.My.Resources.Resources.Sin_título
        Me.PictureBox3.Location = New System.Drawing.Point(717, 184)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.depositphotos_552238290_stock_video_white_picture_of_gear_on
        Me.PictureBox2.Location = New System.Drawing.Point(708, 250)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.reloj12
        Me.PictureBox1.Location = New System.Drawing.Point(-44, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1048, 440)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(347, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(304, 198)
        Me.Panel3.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "temporizador"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 37)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "00:00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(998, 433)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.fechas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.minutes)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.dias)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "RelojDigital"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents horas As Label
    Friend WithEvents minutes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dias As Label
    Friend WithEvents fechas As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents segundos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents reset As Button
    Friend WithEvents Button_start As Button
    Friend WithEvents tiempo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
