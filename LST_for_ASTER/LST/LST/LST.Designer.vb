<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LST
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HakanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HaticeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SerefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HakanToolStripMenuItem, Me.HaticeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HakanToolStripMenuItem
        '
        Me.HakanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EceToolStripMenuItem, Me.NurToolStripMenuItem})
        Me.HakanToolStripMenuItem.Name = "HakanToolStripMenuItem"
        Me.HakanToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.HakanToolStripMenuItem.Text = "Hakan"
        '
        'EceToolStripMenuItem
        '
        Me.EceToolStripMenuItem.Name = "EceToolStripMenuItem"
        Me.EceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EceToolStripMenuItem.Text = "Ece"
        '
        'NurToolStripMenuItem
        '
        Me.NurToolStripMenuItem.Name = "NurToolStripMenuItem"
        Me.NurToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NurToolStripMenuItem.Text = "Nur"
        '
        'HaticeToolStripMenuItem
        '
        Me.HaticeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerefToolStripMenuItem, Me.CanToolStripMenuItem})
        Me.HaticeToolStripMenuItem.Name = "HaticeToolStripMenuItem"
        Me.HaticeToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.HaticeToolStripMenuItem.Text = "Hatice"
        '
        'SerefToolStripMenuItem
        '
        Me.SerefToolStripMenuItem.Name = "SerefToolStripMenuItem"
        Me.SerefToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SerefToolStripMenuItem.Text = "Seref"
        '
        'CanToolStripMenuItem
        '
        Me.CanToolStripMenuItem.Name = "CanToolStripMenuItem"
        Me.CanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CanToolStripMenuItem.Text = "Can"
        '
        'LST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LST"
        Me.Text = "LST"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HakanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HaticeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
