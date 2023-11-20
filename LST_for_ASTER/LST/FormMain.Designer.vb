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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Radiance = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuDNtoRadiance = New System.Windows.Forms.ToolStripMenuItem
        Me.Reflectance = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuReflectance = New System.Windows.Forms.ToolStripMenuItem
        Me.NDVI = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuNDVI = New System.Windows.Forms.ToolStripMenuItem
        Me.Emissivity = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuEmissivity = New System.Windows.Forms.ToolStripMenuItem
        Me.Temperature = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuKineticTemp = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuSurfaceTemp = New System.Windows.Forms.ToolStripMenuItem
        Me.Help = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Radiance, Me.Reflectance, Me.NDVI, Me.Emissivity, Me.Temperature, Me.Help})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(489, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Radiance
        '
        Me.Radiance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuDNtoRadiance})
        Me.Radiance.Name = "Radiance"
        Me.Radiance.Size = New System.Drawing.Size(63, 20)
        Me.Radiance.Text = "Radiance"
        '
        'MenuDNtoRadiance
        '
        Me.MenuDNtoRadiance.Name = "MenuDNtoRadiance"
        Me.MenuDNtoRadiance.Size = New System.Drawing.Size(227, 22)
        Me.MenuDNtoRadiance.Text = "Calculate At-Sensor Radiance"
        '
        'Reflectance
        '
        Me.Reflectance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuReflectance})
        Me.Reflectance.Name = "Reflectance"
        Me.Reflectance.Size = New System.Drawing.Size(76, 20)
        Me.Reflectance.Text = "Reflectance"
        '
        'MenuReflectance
        '
        Me.MenuReflectance.Name = "MenuReflectance"
        Me.MenuReflectance.Size = New System.Drawing.Size(213, 22)
        Me.MenuReflectance.Text = "Calculate TOA Reflectance"
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
        'Temperature
        '
        Me.Temperature.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuKineticTemp, Me.MenuSurfaceTemp})
        Me.Temperature.Name = "Temperature"
        Me.Temperature.Size = New System.Drawing.Size(81, 20)
        Me.Temperature.Text = "Temperature"
        '
        'MenuKineticTemp
        '
        Me.MenuKineticTemp.Name = "MenuKineticTemp"
        Me.MenuKineticTemp.Size = New System.Drawing.Size(260, 22)
        Me.MenuKineticTemp.Text = "Calculate Brightness Temperature"
        '
        'MenuSurfaceTemp
        '
        Me.MenuSurfaceTemp.Name = "MenuSurfaceTemp"
        Me.MenuSurfaceTemp.Size = New System.Drawing.Size(260, 22)
        Me.MenuSurfaceTemp.Text = "Calculate Land Surface Temperature"
        '
        'Help
        '
        Me.Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAbout, Me.MenuExit})
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(40, 20)
        Me.Help.Text = "Help"
        '
        'MenuAbout
        '
        Me.MenuAbout.Name = "MenuAbout"
        Me.MenuAbout.Size = New System.Drawing.Size(114, 22)
        Me.MenuAbout.Text = "About"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(114, 22)
        Me.MenuExit.Text = "Exit"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(489, 23)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Land Surface Temperature Calculator Using ASTER Imagery"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Radiance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDNtoRadiance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NDVI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNDVI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Emissivity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmissivity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Temperature As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuKineticTemp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSurfaceTemp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Reflectance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuReflectance As System.Windows.Forms.ToolStripMenuItem

End Class
