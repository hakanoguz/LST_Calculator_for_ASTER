<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLandsatTM
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
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.txtBoxGain = New System.Windows.Forms.TextBox
        Me.txtBoxBias = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(341, 147)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(341, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save As"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(132, 258)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(238, 258)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(15, 149)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 214)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(323, 20)
        Me.TextBox2.TabIndex = 5
        '
        'txtBoxGain
        '
        Me.txtBoxGain.Location = New System.Drawing.Point(90, 40)
        Me.txtBoxGain.Name = "txtBoxGain"
        Me.txtBoxGain.Size = New System.Drawing.Size(75, 20)
        Me.txtBoxGain.TabIndex = 6
        '
        'txtBoxBias
        '
        Me.txtBoxBias.Location = New System.Drawing.Point(271, 40)
        Me.txtBoxBias.Name = "txtBoxBias"
        Me.txtBoxBias.Size = New System.Drawing.Size(75, 20)
        Me.txtBoxBias.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gain:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bias:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = " Path to the input file (Landsat TM Band)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Path to the output file"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(407, 35)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "NOTE: Please use a decimal point, not a decimal comma when you want to ınput a de" & _
            "cimal number above..."
        '
        'FormLandsatTM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 308)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxBias)
        Me.Controls.Add(Me.txtBoxGain)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormLandsatTM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TOA Radiance Calculation using Landsat TM Image"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxGain As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxBias As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
