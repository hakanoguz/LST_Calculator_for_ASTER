<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReflectance
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
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(306, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(324, 166)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 248)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(306, 20)
        Me.TextBox2.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(324, 246)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save As"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(101, 298)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(219, 298)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(218, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(218, 52)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(218, 78)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Earth-Sun distance in astronomical units:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mean solar exoatmospheric irradiances:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Solar zenith angle in degrees:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Path to the TOA Radiance file"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Path to the output file"
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(9, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(390, 40)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NOTE: Please use a decimal point, not a decimal comma when you want to ınput a de" & _
            "cimal number above..."
        '
        'FormReflectance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 348)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReflectance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reflectance Calculation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
