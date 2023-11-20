<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormToaRad
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
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.openFD = New System.Windows.Forms.OpenFileDialog
        Me.saveFD = New System.Windows.Forms.SaveFileDialog
        Me.txtBoxGain = New System.Windows.Forms.TextBox
        Me.txtBoxOffset = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(113, 330)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(225, 330)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 201)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 20)
        Me.TextBox1.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(306, 199)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 282)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(288, 20)
        Me.TextBox2.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(306, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save As"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'txtBoxGain
        '
        Me.txtBoxGain.Location = New System.Drawing.Point(50, 95)
        Me.txtBoxGain.Name = "txtBoxGain"
        Me.txtBoxGain.Size = New System.Drawing.Size(75, 20)
        Me.txtBoxGain.TabIndex = 6
        '
        'txtBoxOffset
        '
        Me.txtBoxOffset.Location = New System.Drawing.Point(225, 95)
        Me.txtBoxOffset.Name = "txtBoxOffset"
        Me.txtBoxOffset.Size = New System.Drawing.Size(75, 20)
        Me.txtBoxOffset.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gain"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(167, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Offset"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = " Path to the input file (Landsat TM/ETM+ Band 6)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Path to the output file"
        '
        'FormToaRad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 365)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxOffset)
        Me.Controls.Add(Me.txtBoxGain)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "FormToaRad"
        Me.Text = "Top of Atmosphere Radiance Calculation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtBoxGain As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxOffset As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
