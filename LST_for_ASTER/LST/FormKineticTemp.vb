Imports System.IO
Public Class FormKineticTemp

    Private Sub FormKineticTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TextBox1.Clear()
        'Me.TextBox2.Clear()
        Me.TextBox3.Clear()
        Me.TextBox4.Clear()
        'Me.TextBox5.Clear()
        Me.TextBox6.Clear()
        Me.Label8.Text = ""
        Me.btnOK.Enabled = True
        Me.PictureBox1.Visible = False
        Me.PictureBox2.Visible = False

    End Sub

    Private Sub btnBrowse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse1.Click
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

    'Private Sub btnBrowse2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    OpenFD.InitialDirectory = "C:\"
    '    OpenFD.Multiselect = False
    '    OpenFD.Title = "Select Emissivity File"
    '    OpenFD.Filter = "All Files [*.*]| *.*"
    '    ' Make sure the User clicked OK and not Cancel
    '    If (OpenFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
    '        TextBox2.Text = ""
    '        Dim loadFileName2 As String = OpenFD.FileName

    '        'show the full path of selected file in TextBox2
    '        TextBox2.AppendText(loadFileName2)
    '    End If
    'End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFD.InitialDirectory = "C:\"
        SaveFD.Title = "Save Output File As..."
        SaveFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (SaveFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox3.Text = ""
            Dim saveFileName As String = SaveFD.FileName

            'show the full path of selected file
            TextBox3.AppendText(saveFileName)
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If TextBox1.Text.Length = 0 Or TextBox3.Text.Length = 0 Then
            MessageBox.Show("Please input all parameters and then select the directory path to save in!", "Warning!")
            Me.btnBrowse1.Focus()
        Else

            Dim s1 As FileStream 'Load file 1
            'Dim s2 As FileStream 'Load file 2



            '---read from and write to a binary file
            s1 = New FileStream(TextBox1.Text, FileMode.Open, FileAccess.Read)
            's2 = New FileStream(TextBox2.Text, FileMode.Open, FileAccess.Read)

            Dim br1 As BinaryReader
            'Dim br2 As BinaryReader


            br1 = New BinaryReader(s1)
            'br2 = New BinaryReader(s2)


            Dim fLen1 As Integer
            'Dim fLen2 As Integer

            Dim f1 As New System.IO.FileInfo(TextBox1.Text)
            'Dim f2 As New System.IO.FileInfo(TextBox2.Text)


            fLen1 = Int(f1.Length / 4)
            'fLen2 = Int(f2.Length / 4)


            'If fLen1 <> fLen1 Then
            '    MessageBox.Show("File lengths are different. File lengths MUST be equal!!!", "Warning!")
            '    Me.btnBrowse1.Focus()
            'Else
            If System.IO.File.Exists(TextBox3.Text) Then
                System.IO.File.Delete(TextBox3.Text)
            End If

            Dim s3 As FileStream 'Save output
            s3 = New FileStream(TextBox3.Text, FileMode.CreateNew, FileAccess.Write)
            Dim bw As BinaryWriter
            bw = New BinaryWriter(s3)

            Me.Cursor = Cursors.WaitCursor
            Me.PictureBox1.Visible = True
            Me.PictureBox1.Update()
            Me.btnOK.Enabled = False
            Me.Label9.Visible = False
            Me.Label9.Update()
            Me.Label8.Text = "Processing... Please Wait!"
            Me.Label8.Update()
            'Dim snglOutput(fLen1) As Single 'wıll hold results from division
            'Dim snglRead1(fLen1) As Single
            'Dim snglRead2(fLen2) As Single

            Dim snglRead1 As Single
            'Dim snglRead2 As Single
            Dim snglOutput As Single 'wıll hold result from division

            Dim i As Integer
            'Dim j As Integer
            'Dim m As Integer

            Dim K1 As Single
            Dim K2 As Single
            'Dim atmospheric As Single

            K1 = CSng(TextBox4.Text)
            'downwelling = CSng(TextBox5.Text)
            K2 = CSng(TextBox6.Text)

            'Read binary files and do math calc... 
            For i = 0 To fLen1 - 1
                snglRead1 = br1.ReadSingle()
                'snglRead2 = br2.ReadSingle()
                snglOutput = (K2 / Math.Log((K1 / snglRead1) + 1))
                bw.Write(snglOutput)
            Next



            ''Read binary file2
            'For j = 0 To fLen2 - 1
            '    snglRead2(j) = br2.ReadSingle()
            'Next


            'For m = 0 To fLen1 - 1
            '    If snglRead1(m) = 0 And snglRead2(m) = 0 Then
            '        snglOutput(m) = 0
            '    Else 'no division error, get the value to write
            '        snglOutput(m) = (snglRead2(m) - snglRead1(m)) / (snglRead2(m) + snglRead1(m))
            '    End If
            '    bw.Write(snglOutput(m))
            'Next

            s1.Close()
            's2.Close()
            s3.Close()

            Me.PictureBox1.Visible = False
            Me.PictureBox2.Visible = True

            Me.Label8.Visible = False
            Me.Label8.Update()
            Me.Label9.Visible = True
            Me.Label9.Text = "Process Completed!"
            Me.Label9.Update()

            btnCancel.Text = "Close"
            Me.Cursor = Cursors.Default
            MessageBox.Show("File created succesfully!", "Success!")
            'Me.Close()
        End If

        'End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    'Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
    '        e.Handled = False
    '    Else
    '        MessageBox.Show("Please Enter Numbers Only!")
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class