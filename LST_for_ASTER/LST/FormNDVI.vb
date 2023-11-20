Imports System.IO
Public Class FormNDVI

    Private Sub FormNDVI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        Me.TextBox3.Clear()
        Me.Label4.Text = ""
        Me.btnOK.Enabled = True
        Me.PictureBox1.Visible = False
        Me.PictureBox2.Visible = False
    End Sub

    
    Private Sub btnBrowse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse1.Click
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Multiselect = False
        OpenFD.Title = "Select TM/ETM+ Band 3 Reflectance File"
        OpenFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (OpenFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox1.Text = ""
            Dim loadFileName1 As String = OpenFD.FileName

            'show the full path of selected file in TextBox1
            TextBox1.AppendText(loadFileName1)
        End If
    End Sub

    Private Sub btnBrowse2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse2.Click
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Multiselect = False
        OpenFD.Title = "Select TM/ETM+ Band 4 Reflectance File"
        OpenFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (OpenFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox2.Text = ""
            Dim loadFileName2 As String = OpenFD.FileName

            'show the full path of selected file in TextBox2
            TextBox2.AppendText(loadFileName2)
        End If
    End Sub

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Or TextBox3.Text.Length = 0 Then
            MessageBox.Show("Please input Band 3 and Band 4 files first and then select the directory path to save in!", "Warning!")
            Me.btnBrowse1.Focus()
        Else
            Dim s1 As FileStream 'Load file 1
            Dim s2 As FileStream 'Load file 2

            '---read from and write to a binary file
            s1 = New FileStream(TextBox1.Text, FileMode.Open, FileAccess.Read)
            s2 = New FileStream(TextBox2.Text, FileMode.Open, FileAccess.Read)
            
            Dim br1 As BinaryReader
            Dim br2 As BinaryReader

            br1 = New BinaryReader(s1)
            br2 = New BinaryReader(s2)

            Dim fLen1 As Integer = 0
            Dim fLen2 As Integer = 0
            Dim f1 As New System.IO.FileInfo(TextBox1.Text)
            Dim f2 As New System.IO.FileInfo(TextBox2.Text)

            'fLen1 = f1.Length
            'fLen2 = f2.Length
            'MessageBox.Show("f1.Length= " & f1.Length)
            'MessageBox.Show("f2.Length= " & f2.Length)
            fLen1 = f1.Length / 4
            fLen2 = f2.Length / 4
            'MessageBox.Show("fLen1= " & fLen1)
            'MessageBox.Show("fLen2= " & fLen2)

            If fLen1 <> fLen2 Then
                MessageBox.Show("File lengths are different. File lengths MUST be equal!!!", "Warning!")
                Me.btnBrowse1.Focus()
            Else
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
                Me.Label4.Text = "Processing... Please Wait!"
                Me.Label4.Update()

                Me.Label5.Visible = False
                Me.Label5.Update()
                Me.Label4.Text = "Processing... Please Wait!"
                Me.Label4.Update()

                'Dim snglRead1(fLen1) As Single
                'Dim snglRead2(fLen2) As Single
                'Dim snglOutput(fLen1) As Single 'wıll hold results from division

                Dim snglRead1 As Single
                Dim snglRead2 As Single
                Dim snglOutput As Single

                'Dim i As Integer
                'Dim j As Integer
                Dim m As Integer

                'For i = 0 To fLen1 - 1
                '    snglRead1(i) = br1.ReadSingle()
                '    snglRead2(i) = br2.ReadSingle()
                'Next

                'For j = 0 To fLen1 - 1

                '    snglRead2(j) = br2.ReadSingle()

                'Next

                'Read binary file1  
                For m = 0 To fLen1 - 1
                    snglRead1 = br1.ReadSingle()
                    snglRead2 = br2.ReadSingle()
                    If snglRead1 = 0 And snglRead2 = 0 Then
                        snglOutput = 0
                    Else 'no division error, get the value to write
                        snglOutput = (snglRead2 - snglRead1) / (snglRead2 + snglRead1)
                    End If
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
                s2.Close()
                s3.Close()

                Me.PictureBox1.Visible = False
                Me.PictureBox2.Visible = True

                Me.Label4.Visible = False
                Me.Label4.Update()
                Me.Label5.Visible = True
                Me.Label5.Text = "Process Completed!"
                Me.Label5.Update()

                'Me.Label4.Text = "Process Completed!"
                'Me.Label4.Update()
                btnCancel.Text = "Close"
                Me.Cursor = Cursors.Default
                MessageBox.Show("File created succesfully!", "Success!")
                'Me.Close()
            End If

        End If
    End Sub
End Class