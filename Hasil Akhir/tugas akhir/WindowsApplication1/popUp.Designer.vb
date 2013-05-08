<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popUp
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
        Me.labelSoal = New System.Windows.Forms.Label()
        Me.isian = New System.Windows.Forms.TextBox()
        Me.tombolIsian = New System.Windows.Forms.Button()
        Me.pilihanA = New System.Windows.Forms.Button()
        Me.pilihanB = New System.Windows.Forms.Button()
        Me.pilihanC = New System.Windows.Forms.Button()
        Me.pilihanD = New System.Windows.Forms.Button()
        Me.pilihanE = New System.Windows.Forms.Button()
        Me.pilihanBenar = New System.Windows.Forms.Button()
        Me.pilihanSalah = New System.Windows.Forms.Button()
        Me.angkaDadu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelSoal
        '
        Me.labelSoal.AutoSize = True
        Me.labelSoal.Location = New System.Drawing.Point(12, 40)
        Me.labelSoal.Name = "labelSoal"
        Me.labelSoal.Size = New System.Drawing.Size(43, 13)
        Me.labelSoal.TabIndex = 0
        Me.labelSoal.Text = "soalnya"
        '
        'isian
        '
        Me.isian.Location = New System.Drawing.Point(92, 175)
        Me.isian.Name = "isian"
        Me.isian.Size = New System.Drawing.Size(148, 20)
        Me.isian.TabIndex = 8
        '
        'tombolIsian
        '
        Me.tombolIsian.Location = New System.Drawing.Point(258, 173)
        Me.tombolIsian.Name = "tombolIsian"
        Me.tombolIsian.Size = New System.Drawing.Size(75, 23)
        Me.tombolIsian.TabIndex = 9
        Me.tombolIsian.Text = "cek"
        Me.tombolIsian.UseVisualStyleBackColor = True
        '
        'pilihanA
        '
        Me.pilihanA.Location = New System.Drawing.Point(12, 70)
        Me.pilihanA.Name = "pilihanA"
        Me.pilihanA.Size = New System.Drawing.Size(70, 23)
        Me.pilihanA.TabIndex = 10
        Me.pilihanA.Text = "Button1"
        Me.pilihanA.UseVisualStyleBackColor = True
        '
        'pilihanB
        '
        Me.pilihanB.Location = New System.Drawing.Point(92, 70)
        Me.pilihanB.Name = "pilihanB"
        Me.pilihanB.Size = New System.Drawing.Size(70, 23)
        Me.pilihanB.TabIndex = 11
        Me.pilihanB.Text = "Button2"
        Me.pilihanB.UseVisualStyleBackColor = True
        '
        'pilihanC
        '
        Me.pilihanC.Location = New System.Drawing.Point(170, 70)
        Me.pilihanC.Name = "pilihanC"
        Me.pilihanC.Size = New System.Drawing.Size(70, 23)
        Me.pilihanC.TabIndex = 12
        Me.pilihanC.Text = "Button3"
        Me.pilihanC.UseVisualStyleBackColor = True
        '
        'pilihanD
        '
        Me.pilihanD.Location = New System.Drawing.Point(246, 70)
        Me.pilihanD.Name = "pilihanD"
        Me.pilihanD.Size = New System.Drawing.Size(70, 23)
        Me.pilihanD.TabIndex = 13
        Me.pilihanD.Text = "Button4"
        Me.pilihanD.UseVisualStyleBackColor = True
        '
        'pilihanE
        '
        Me.pilihanE.Location = New System.Drawing.Point(322, 70)
        Me.pilihanE.Name = "pilihanE"
        Me.pilihanE.Size = New System.Drawing.Size(70, 23)
        Me.pilihanE.TabIndex = 14
        Me.pilihanE.Text = "Button5"
        Me.pilihanE.UseVisualStyleBackColor = True
        '
        'pilihanBenar
        '
        Me.pilihanBenar.Location = New System.Drawing.Point(92, 124)
        Me.pilihanBenar.Name = "pilihanBenar"
        Me.pilihanBenar.Size = New System.Drawing.Size(70, 23)
        Me.pilihanBenar.TabIndex = 15
        Me.pilihanBenar.Text = "benar"
        Me.pilihanBenar.UseVisualStyleBackColor = True
        '
        'pilihanSalah
        '
        Me.pilihanSalah.Location = New System.Drawing.Point(246, 124)
        Me.pilihanSalah.Name = "pilihanSalah"
        Me.pilihanSalah.Size = New System.Drawing.Size(70, 23)
        Me.pilihanSalah.TabIndex = 16
        Me.pilihanSalah.Text = "salah"
        Me.pilihanSalah.UseVisualStyleBackColor = True
        '
        'angkaDadu
        '
        Me.angkaDadu.AutoSize = True
        Me.angkaDadu.Location = New System.Drawing.Point(12, 9)
        Me.angkaDadu.Name = "angkaDadu"
        Me.angkaDadu.Size = New System.Drawing.Size(64, 13)
        Me.angkaDadu.TabIndex = 17
        Me.angkaDadu.Text = "angka dadu"
        '
        'popUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.angkaDadu)
        Me.Controls.Add(Me.pilihanSalah)
        Me.Controls.Add(Me.pilihanBenar)
        Me.Controls.Add(Me.pilihanE)
        Me.Controls.Add(Me.pilihanD)
        Me.Controls.Add(Me.pilihanC)
        Me.Controls.Add(Me.pilihanB)
        Me.Controls.Add(Me.pilihanA)
        Me.Controls.Add(Me.tombolIsian)
        Me.Controls.Add(Me.isian)
        Me.Controls.Add(Me.labelSoal)
        Me.Name = "popUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "popUp"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelSoal As System.Windows.Forms.Label
    Friend WithEvents isian As System.Windows.Forms.TextBox
    Friend WithEvents tombolIsian As System.Windows.Forms.Button
    Friend WithEvents pilihanA As System.Windows.Forms.Button
    Friend WithEvents pilihanB As System.Windows.Forms.Button
    Friend WithEvents pilihanC As System.Windows.Forms.Button
    Friend WithEvents pilihanD As System.Windows.Forms.Button
    Friend WithEvents pilihanE As System.Windows.Forms.Button
    Friend WithEvents pilihanBenar As System.Windows.Forms.Button
    Friend WithEvents pilihanSalah As System.Windows.Forms.Button
    Friend WithEvents angkaDadu As System.Windows.Forms.Label
End Class
