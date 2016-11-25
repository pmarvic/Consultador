<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblDate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.btnTecladoVirtual = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Consultador.My.Resources.Resources.barra
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 39)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFecha.Image = Global.Consultador.My.Resources.Resources.barra
        Me.lblFecha.Location = New System.Drawing.Point(392, 7)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(15, 24)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "."
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Yellow
        Me.lblHora.Image = Global.Consultador.My.Resources.Resources.barra
        Me.lblHora.Location = New System.Drawing.Point(669, 3)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(18, 29)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "."
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(306, 471)
        Me.txtCodigo.MaxLength = 14
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCodigo.Size = New System.Drawing.Size(181, 32)
        Me.txtCodigo.TabIndex = 3
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerDate
        '
        Me.TimerDate.Enabled = True
        Me.TimerDate.Interval = 1000
        '
        'btnTecladoVirtual
        '
        Me.btnTecladoVirtual.BackColor = System.Drawing.Color.White
        Me.btnTecladoVirtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTecladoVirtual.ForeColor = System.Drawing.Color.DimGray
        Me.btnTecladoVirtual.Image = Global.Consultador.My.Resources.Resources.keyboard
        Me.btnTecladoVirtual.Location = New System.Drawing.Point(353, 400)
        Me.btnTecladoVirtual.Name = "btnTecladoVirtual"
        Me.btnTecladoVirtual.Size = New System.Drawing.Size(77, 65)
        Me.btnTecladoVirtual.TabIndex = 4
        Me.btnTecladoVirtual.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.Consultador.My.Resources.Resources.pagina_web
        Me.PictureBox2.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'lblDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Consultador.My.Resources.Resources._800_535
        Me.ClientSize = New System.Drawing.Size(798, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnTecladoVirtual)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "lblDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents TimerDate As Timer
    Friend WithEvents btnTecladoVirtual As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
