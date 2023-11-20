Imports System.IO
Public Class FormReflectance

    Private Sub FormReflectance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        Me.TextBox3.Clear() 'julian day
        Me.TextBox4.Clear()
        Me.TextBox5.Clear()
        Me.TextBox6.Clear() 'Dark object value
        Me.Label7.Text = ""
        Me.btnOK.Enabled = True
        Me.PictureBox1.Visible = False
        Me.PictureBox2.Visible = False
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Multiselect = False
        OpenFD.Title = "Select TOA Radiance File"
        OpenFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (OpenFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox1.Text = ""
            Dim loadFileName1 As String = OpenFD.FileName
            'show the full path of selected file in TextBox1
            TextBox1.AppendText(loadFileName1)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFD.InitialDirectory = "C:\"
        SaveFD.Title = "Save Output File As..."
        SaveFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (SaveFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox2.Text = ""
            Dim saveFileName As String = SaveFD.FileName
            'show the full path of selected file
            TextBox2.AppendText(saveFileName)
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Or TextBox3.Text.Length = 0 Or TextBox4.Text.Length = 0 Or TextBox5.Text.Length = 0 Then
            MessageBox.Show("Please input all parameters first and then select the directory path to save in!", "Warning!")
            Me.btnBrowse.Focus()
        Else
            Me.Cursor = Cursors.WaitCursor
            Me.PictureBox1.Visible = True
            Me.PictureBox1.Update()
            Me.btnOK.Enabled = False
            'Me.Label7.Text = "Processing... Please Wait!"
            'Me.Label7.Update()

            Me.Label8.Visible = False
            Me.Label8.Update()
            Me.Label7.Text = "Processing... Please Wait!"
            Me.Label7.Update()

            Dim s1 As FileStream 'Load file 1
            Dim s3 As FileStream 'Save output

            If System.IO.File.Exists(TextBox2.Text) Then
                System.IO.File.Delete(TextBox2.Text)
            End If

            '---read from and write to a binary file
            s1 = New FileStream(TextBox1.Text, FileMode.Open, FileAccess.Read)
            s3 = New FileStream(TextBox2.Text, FileMode.CreateNew, FileAccess.Write)

            Dim br1 As BinaryReader
            Dim bw As BinaryWriter

            br1 = New BinaryReader(s1)
            bw = New BinaryWriter(s3)

            Dim fLen1 As Integer
            Dim f1 As New System.IO.FileInfo(TextBox1.Text)

            fLen1 = Int(f1.Length / 4)


            'Dim snglRead1(fLen1) As Single
            'Dim snglOutput(fLen1) As Single 'wıll hold results from division

            Dim snglRead1 As Single
            Dim snglOutput As Single 'wıll hold results from division

            Dim i As Integer
            'Dim m As Integer

            Dim julian As Single
            Dim d As Single
            Dim esun As Single
            Dim zenith As Single
            Dim dark As Single
            julian = CSng(TextBox3.Text)
            esun = CSng(TextBox4.Text)
            zenith = CSng(TextBox5.Text)
            dark = CSng(TextBox6.Text)

            d = (1 - 0.01674 * Math.Cos(0.9856 * (julian - 4) * 0.01745329252))

            For i = 0 To fLen1 - 1
                snglRead1 = br1.ReadSingle()
                snglOutput = ((3.14159265 * (snglRead1 - dark) * d ^ 2) / (esun * Math.Cos(zenith * 0.01745329252)))

                bw.Write(snglOutput)
            Next

            'For m = 0 To fLen1 - 1
            '    snglOutput(m) = ((3.14159265 * snglRead1(m) * distance * distance) / (esun * zenith))

            '    bw.Write(snglOutput(m))
            'Next

            s1.Close()
            s3.Close()

            Me.PictureBox1.Visible = False
            Me.PictureBox2.Visible = True

            Me.Label7.Visible = False
            Me.Label7.Update()
            Me.Label8.Visible = True
            Me.Label8.Text = "Process Completed!"
            Me.Label8.Update()

            'Me.Label7.Text = "Process Completed!"
            'Me.Label7.Update()
            btnCancel.Text = "Close"
            Me.Cursor = Cursors.Default
            MessageBox.Show("File created succesfully!", "Success!")
            'Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

End Class