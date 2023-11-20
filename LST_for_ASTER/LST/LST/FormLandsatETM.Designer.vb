<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLandsatETM
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtBoxLmdMax = New System.Windows.Forms.TextBox
        Me.txtBoxQcalMax = New System.Windows.Forms.TextBox
        Me.txtBoxLmdMin = New System.Windows.Forms.TextBox
        Me.txtBoxQcalMin = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 212)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(359, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 273)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(359, 20)
        Me.TextBox2.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(377, 210)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(377, 271)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save As"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(135, 312)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(262, 312)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtBoxLmdMax
        '
        Me.txtBoxLmdMax.Location = New System.Drawing.Point(150, 18)
        Me.txtBoxLmdMax.Name = "txtBoxLmdMax"
        Me.txtBoxLmdMax.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxLmdMax.TabIndex = 6
        '
        'txtBoxQcalMax
        '
        Me.txtBoxQcalMax.Location = New System.Drawing.Point(353, 18)
        Me.txtBoxQcalMax.Name = "txtBoxQcalMax"
        Me.txtBoxQcalMax.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxQcalMax.TabIndex = 7
        '
        'txtBoxLmdMin
        '
        Me.txtBoxLmdMin.Location = New System.Drawing.Point(150, 44)
        Me.txtBoxLmdMin.Name = "txtBoxLmdMin"
        Me.txtBoxLmdMin.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxLmdMin.TabIndex = 8
        '
        'txtBoxQcalMin
        '
        Me.txtBoxQcalMin.Location = New System.Drawing.Point(353, 44)
        Me.txtBoxQcalMin.Name = "txtBoxQcalMin"
        Me.txtBoxQcalMin.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxQcalMin.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "LMax:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "LMin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "QCalMax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "QCalMin:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = " Path to the input file (Landsat ETM+ Band)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Path to the output file"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(444, 33)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "NOTE: Please use a decimal point, not a decimal comma when you want to ınput a de" & _
            "cimal number above..."
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 31)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Option1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 109)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Option2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(150, 108)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(353, 108)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Gain"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(320, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Bias"
        '
        'FormLandsatETM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 347)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxQcalMin)
        Me.Controls.Add(Me.txtBoxLmdMin)
        Me.Controls.Add(Me.txtBoxQcalMax)
        Me.Controls.Add(Me.txtBoxLmdMax)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormLandsatETM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TOA Radiance Calculation using Landsat ETM+ Image"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtBoxLmdMax As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxQcalMax As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxLmdMin As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxQcalMin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
