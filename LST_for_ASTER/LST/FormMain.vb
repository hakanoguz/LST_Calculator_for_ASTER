﻿Imports System
Imports System.Globalization
Public Class FormMain

    Dim frmDNtoRadiance As New FormDNtoRadiance
    Dim frmNDVI As New FormNDVI
    Dim frmEmissivity As New FormEmissivity
    Dim frmReflectance As New FormReflectance
    Dim frmKineticTemp As New FormKineticTemp
    Dim frmSurfaceTemp As New FormSurfaceTemp
    'Dim frmUserManual As New FormUserManual
    Dim frmAbout As New FormAbout


    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        'en-US Regional formatting is enforced
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.PercentDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.PercentGroupSeparator = ","

    End Sub

    Private Sub MenuDNtoRadiance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDNtoRadiance.Click
        frmDNtoRadiance.ShowDialog()
    End Sub

    Private Sub MenuReflectance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReflectance.Click
        frmReflectance.ShowDialog()
    End Sub

    Private Sub MenuNDVI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNDVI.Click
        frmNDVI.ShowDialog()
    End Sub

    Private Sub MenuEmissivity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmissivity.Click
        frmEmissivity.ShowDialog()
    End Sub

    Private Sub MenuKineticTemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuKineticTemp.Click
        frmKineticTemp.ShowDialog()
    End Sub

    Private Sub MenuSurfaceTemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSurfaceTemp.Click
        frmSurfaceTemp.ShowDialog()
    End Sub

    Private Sub MenuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        Me.Close()
    End Sub

    
End Class
