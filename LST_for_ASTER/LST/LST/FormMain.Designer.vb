<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Radiance = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuToaRadiance = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuLandsatTM = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuLandsatETM = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReflectance = New System.Windows.Forms.ToolStripMenuItem
        Me.NDVI = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuNDVI = New System.Windows.Forms.ToolStripMenuItem
        Me.Emissivity = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEmissivity = New System.Windows.Forms.ToolStripMenuItem
        Me.TemperatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuKineticTemp = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSurfaceTemp = New System.Windows.Forms.ToolStripMenuItem
        Me.Help = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuUserManual = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Radiance, Me.NDVI, Me.Emissivity, Me.TemperatureToolStripMenuItem, Me.Help})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Radiance
        '
        Me.Radiance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToaRadiance, Me.MenuReflectance})
        Me.Radiance.Name = "Radiance"
        Me.Radiance.Size = New System.Drawing.Size(63, 20)
        Me.Radiance.Text = "Radiance"
        '
        'MenuToaRadiance
        '
        Me.MenuToaRadiance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuLandsatTM, Me.MenuLandsatETM})
        Me.MenuToaRadiance.Name = "MenuToaRadiance"
        Me.MenuToaRadiance.Size = New System.Drawing.Size(200, 22)
        Me.MenuToaRadiance.Text = "Calculate TOA Radiance"
        '
        'MenuLandsatTM
        '
        Me.MenuLandsatTM.Name = "MenuLandsatTM"
        Me.MenuLandsatTM.Size = New System.Drawing.Size(181, 22)
        Me.MenuLandsatTM.Text = "From Landsat TM"
        '
        'MenuLandsatETM
        '
        Me.MenuLandsatETM.Name = "MenuLandsatETM"
        Me.MenuLandsatETM.Size = New System.Drawing.Size(181, 22)
        Me.MenuLandsatETM.Text = "From Landsat ETM+"
        '
        'MenuReflectance
        '
        Me.MenuReflectance.Name = "MenuReflectance"
        Me.MenuReflectance.Size = New System.Drawing.Size(200, 22)
        Me.MenuReflectance.Text = "Calculate Reflectance"
        '
        'NDVI
        '
        Me.NDVI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNDVI})
        Me.NDVI.Name = "NDVI"
        Me.NDVI.Size = New System.Drawing.Size(43, 20)
        Me.NDVI.Text = "NDVI"
        '
        'MenuNDVI
        '
        Me.MenuNDVI.Name = "MenuNDVI"
        Me.MenuNDVI.Size = New System.Drawing.Size(156, 22)
        Me.MenuNDVI.Text = "Calculate NDVI"
        '
        'Emissivity
        '
        Me.Emissivity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuEmissivity})
        Me.Emissivity.Name = "Emissivity"
        Me.Emissivity.Size = New System.Drawing.Size(65, 20)
        Me.Emissivity.Text = "Emissivity"
        '
        'MenuEmissivity
        '
        Me.MenuEmissivity.Name = "MenuEmissivity"
        Me.MenuEmissivity.Size = New System.Drawing.Size(178, 22)
        Me.MenuEmissivity.Text = "Calculate Emissivity"
        '
        'TemperatureToolStripMenuItem
        '
        Me.TemperatureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuKineticTemp, Me.MenuSurfaceTemp})
        Me.TemperatureToolStripMenuItem.Name = "TemperatureToolStripMenuItem"
        Me.TemperatureToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.TemperatureToolStripMenuItem.Text = "Temperature"
        '
        'MenuKineticTemp
        '
        Me.MenuKineticTemp.Name = "MenuKineticTemp"
        Me.MenuKineticTemp.Size = New System.Drawing.Size(234, 22)
        Me.MenuKineticTemp.Text = "Calculate Kinetic Temperature"
        '
        'MenuSurfaceTemp
        '
        Me.MenuSurfaceTemp.Name = "MenuSurfaceTemp"
        Me.MenuSurfaceTemp.Size = New System.Drawing.Size(234, 22)
        Me.MenuSurfaceTemp.Text = "Calculate Surface Temperature"
        '
        'Help
        '
        Me.Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUserManual, Me.MenuAbout})
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(40, 20)
        Me.Help.Text = "Help"
        '
        'MenuUserManual
        '
        Me.MenuUserManual.Name = "MenuUserManual"
        Me.MenuUserManual.Size = New System.Drawing.Size(144, 22)
        Me.MenuUserManual.Text = "User Manual"
        '
        'MenuAbout
        '
        Me.MenuAbout.Name = "MenuAbout"
        Me.MenuAbout.Size = New System.Drawing.Size(144, 22)
        Me.MenuAbout.Text = "About"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 495)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "Land Surface Temperature Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Radiance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToaRadiance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuLandsatTM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuLandsatETM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NDVI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNDVI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Emissivity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmissivity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReflectance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemperatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuKineticTemp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSurfaceTemp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUserManual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAbout As System.Windows.Forms.ToolStripMenuItem

End Class
