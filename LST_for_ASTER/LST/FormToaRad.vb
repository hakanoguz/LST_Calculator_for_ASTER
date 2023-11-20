Imports System.IO
Public Class FormToaRad

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Or txtBoxGain.Text.Length = 0 Or txtBoxOffset.Text.Length = 0 Then
            MessageBox.Show("Oops, you must be forgetting something here :)  Before pressing OK button, make sure that you input Gain and Offset parameters, and Band 6. Then SELECT a directory where the output file will be saved to!!!", "Warning!")
            Me.btnBrowse.Focus()
        Else
            Dim s1 As FileStream 'Load file 1
            'Dim s2 As FileStream 'Load file 2
            Dim s3 As FileStream 'Save output

            If System.IO.File.Exists(TextBox2.Text) Then
                System.IO.File.Delete(TextBox2.Text)
            End If

            '---read from and write to a binary file
            s1 = New FileStream(TextBox1.Text, FileMode.Open, FileAccess.Read)
            's2 = New FileStream(TextBox2.Text, FileMode.Open, FileAccess.Read)
            s3 = New FileStream(TextBox2.Text, FileMode.CreateNew, FileAccess.Write)

            Dim br1 As BinaryReader
            'Dim br2 As BinaryReader
            Dim bw As BinaryWriter

            br1 = New BinaryReader(s1)
            'br2 = New BinaryReader(s2)
            bw = New BinaryWriter(s3)

            Dim fLen1 As Integer
            'Dim fLen2 As Integer
            Dim f1 As New System.IO.FileInfo(TextBox1.Text)
            'Dim f2 As New System.IO.FileInfo(TextBox2.Text)
            fLen1 = f1.Length

            'fLen2 = f2.Length

            'If fLen1 <> fLen2 Then
            '    MessageBox.Show("File lengths are different. File lengths MUST be equal!!!", "Warning!")
            '    Me.Button1.Focus()
            'Else

            Dim snglRead1(fLen1) As Single
            Dim snglOutput(fLen1) As Single 'wıll hold results from division

            'Dim snglRead2(fLen2) As Single
            Dim i As Integer
            'Dim j As Integer
            'Dim k As Integer
            Dim m As Integer

            'Read binary file1 and fill the array with pixel values 
            For i = 0 To fLen1 - 1
                'byteRead1(i) = br1.ReadByte
                'snglRead1(i) = byteRead1(i)
                snglRead1(i) = br1.ReadByte
            Next

            ''Read binary file2 and fill the array with pixel values
            'For j = 0 To fLen2 - 1
            '    snglRead2(j) = br2.ReadByte
            'Next

            'For m = 0 To fLen1 - 1
            '    'test1(m) = (dblRead2(m) - dblRead1(m))
            '    'test2(m) = (dblRead2(m) + dblRead1(m))
            '    If snglRead1(m) = 0 And snglRead2(m) = 0 Then
            '        snglOutput(m) = 0
            '    Else 'no division error, get the val to write
            '        snglOutput(m) = (snglRead2(m) - snglRead1(m)) / (snglRead2(m) + snglRead1(m))
            '    End If
            '    bw.Write(snglOutput(m))
            'Next
            Dim gain As Single
            Dim offset As Single
            gain = CSng(txtBoxGain.Text)
            offset = CSng(txtBoxOffset.Text)



            For m = 0 To fLen1 - 1
                snglOutput(m) = gain * snglRead1(m) + offset
                'test1(m) = (dblRead2(m) - dblRead1(m))
                'test2(m) = (dblRead2(m) + dblRead1(m))
                'If snglRead1(m) = 0 Then
                '    snglOutput(m) = 0
                'Else 'no division error, get the val to write
                '    snglOutput(m) = (snglRead1(m)) / (snglRead1(m))
                'End If
                bw.Write(snglOutput(m))
            Next
            MsgBox(gain)
            MsgBox(offset)
            MsgBox(snglRead1(0))
            MsgBox(snglOutput(0))

            s1.Close()
            's2.Close()
            s3.Close()

            MessageBox.Show("Original DN values of Band 6 have been successfully converted to TOA Radiance!", "Done")
            Me.Close()
        End If



    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub FormToaRad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        openFD.InitialDirectory = "C:\"
        openFD.Multiselect = False
        openFD.Title = "Select TM/ETM+ band 6 file"
        openFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (openFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox1.Text = ""
            Dim loadFileName1 As String = openFD.FileName

            'show the full path of selected file in TextBox1
            TextBox1.AppendText(loadFileName1)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveFD.InitialDirectory = "C:\"
        saveFD.Title = "Save Output File As..."
        saveFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (saveFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox2.Text = ""
            Dim saveFileName As String = saveFD.FileName
            'If System.IO.File.Exists(TextBox3.Text) Then
            'System.IO.File.Delete(TextBox3.Text)
            'MessageBox.Show("Filename already exists! Name the file something else!", "Warning!")
            'Me.Button3.Focus()
            'Else
            'show the full path of selected file
            TextBox2.AppendText(saveFileName)
        End If
    End Sub

    Private Sub txtBoxGain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxGain.KeyPress
        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    MessageBox.Show("Please Enter Numbers Only")
        '    e.Handled = True
        'End If
        'If IsNumeric(txtBoxGain.Text) = True Then

        'Else

        '    MsgBox("enter numbers only")
        'End If
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
            'If Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then
            '    e.Handled = False
            'ElseIf Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) < 58 Then
            '    e.Handled = False
            'ElseIf Asc(e.KeyChar) > 95 And Asc(e.KeyChar) < 97 Then
            '    e.Handled = True
            'ElseIf Asc(e.KeyChar) > 57 Then
            '    e.Handled = True
        End If
    End Sub

    Private Sub txtBoxOffset_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxOffset.KeyPress
        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    MessageBox.Show("Please Enter Numbers Only")
        '    e.Handled = True
        'End If
        'If IsNumeric(txtBoxOffset.Text) = True Then

        'Else
        '    MsgBox("enter numbers only")
        'End If
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
            'If Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then
            '    e.Handled = False
            'ElseIf Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) < 58 Then
            '    e.Handled = False
            'ElseIf Asc(e.KeyChar) > 95 And Asc(e.KeyChar) < 97 Then
            '    e.Handled = True
            'ElseIf Asc(e.KeyChar) > 57 Then
            '    e.Handled = True
        End If


    End Sub

    Private Sub txtBoxOffset_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBoxOffset.TextChanged
        'If Not IsNumeric(txtBoxOffset.Text) And (txtBoxOffset.Text <> " ") Then
        '    MsgBox("Not a Numeric Input! Try Again")
        '    txtBoxOffset.Focus()
        '    Exit Sub
        'End If

    End Sub

    Private Sub txtBoxGain_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBoxGain.TextChanged
        'If Not IsNumeric(txtBoxGain.Text) And (txtBoxGain.Text <> " ") Then
        '    MsgBox("Not a Numeric Input! Try Again")
        '    txtBoxGain.Focus()
        '    Exit Sub
        'End If
    End Sub
End Class