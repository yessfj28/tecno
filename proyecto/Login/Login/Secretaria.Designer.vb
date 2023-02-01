<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Secretaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Secretaria))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_roll = New System.Windows.Forms.ComboBox()
        Me.txt_contra = New System.Windows.Forms.TextBox()
        Me.txt2_usuario = New System.Windows.Forms.TextBox()
        Me.btn2_buscar = New System.Windows.Forms.Button()
        Me.btn2_mostrar = New System.Windows.Forms.Button()
        Me.dgv_usuario = New System.Windows.Forms.DataGridView()
        Me.btn2_insertar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cb_roll)
        Me.GroupBox2.Controls.Add(Me.txt_contra)
        Me.GroupBox2.Controls.Add(Me.txt2_usuario)
        Me.GroupBox2.Controls.Add(Me.btn2_buscar)
        Me.GroupBox2.Controls.Add(Me.btn2_mostrar)
        Me.GroupBox2.Controls.Add(Me.dgv_usuario)
        Me.GroupBox2.Controls.Add(Me.btn2_insertar)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 324)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SECRETARI@"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 22)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Roll"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 22)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Usuario"
        '
        'cb_roll
        '
        Me.cb_roll.FormattingEnabled = True
        Me.cb_roll.Items.AddRange(New Object() {"Administrador", "Cliente", "Secretaria"})
        Me.cb_roll.Location = New System.Drawing.Point(120, 146)
        Me.cb_roll.Name = "cb_roll"
        Me.cb_roll.Size = New System.Drawing.Size(100, 21)
        Me.cb_roll.TabIndex = 21
        '
        'txt_contra
        '
        Me.txt_contra.Location = New System.Drawing.Point(120, 106)
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.Size = New System.Drawing.Size(100, 20)
        Me.txt_contra.TabIndex = 20
        '
        'txt2_usuario
        '
        Me.txt2_usuario.Location = New System.Drawing.Point(120, 60)
        Me.txt2_usuario.Name = "txt2_usuario"
        Me.txt2_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt2_usuario.TabIndex = 16
        '
        'btn2_buscar
        '
        Me.btn2_buscar.Location = New System.Drawing.Point(236, 129)
        Me.btn2_buscar.Name = "btn2_buscar"
        Me.btn2_buscar.Size = New System.Drawing.Size(170, 23)
        Me.btn2_buscar.TabIndex = 16
        Me.btn2_buscar.Text = "Buscar Según Usuario"
        Me.btn2_buscar.UseVisualStyleBackColor = True
        '
        'btn2_mostrar
        '
        Me.btn2_mostrar.Location = New System.Drawing.Point(331, 59)
        Me.btn2_mostrar.Name = "btn2_mostrar"
        Me.btn2_mostrar.Size = New System.Drawing.Size(75, 50)
        Me.btn2_mostrar.TabIndex = 19
        Me.btn2_mostrar.Text = "Mostrar"
        Me.btn2_mostrar.UseVisualStyleBackColor = True
        '
        'dgv_usuario
        '
        Me.dgv_usuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuario.Location = New System.Drawing.Point(19, 190)
        Me.dgv_usuario.Name = "dgv_usuario"
        Me.dgv_usuario.Size = New System.Drawing.Size(476, 108)
        Me.dgv_usuario.TabIndex = 0
        '
        'btn2_insertar
        '
        Me.btn2_insertar.Location = New System.Drawing.Point(236, 60)
        Me.btn2_insertar.Name = "btn2_insertar"
        Me.btn2_insertar.Size = New System.Drawing.Size(75, 50)
        Me.btn2_insertar.TabIndex = 16
        Me.btn2_insertar.Text = "Insertar"
        Me.btn2_insertar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(545, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Secretaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(586, 349)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Secretaria"
        Me.Text = "Secretaria"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_roll As ComboBox
    Friend WithEvents txt_contra As TextBox
    Friend WithEvents txt2_usuario As TextBox
    Friend WithEvents btn2_buscar As Button
    Friend WithEvents btn2_mostrar As Button
    Friend WithEvents dgv_usuario As DataGridView
    Friend WithEvents btn2_insertar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
