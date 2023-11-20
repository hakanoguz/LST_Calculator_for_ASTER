Imports System.IO
Public Class FormKineticTemp

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

    Private Sub btnBrowse2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse2.Click
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Multiselect = False
        OpenFD.Title = "Select Emissivity File"
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

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Or TextBox3.Text.Length = 0 Then
            MessageBox.Show("Oops, you must be forgetting something here :)  Before pressing OK button, you MUST enter all parameters. Then SELECT a directory where the output file will be saved to!!!", "Warning!")
            Me.btnBrowse1.Focus()
        Else

            Dim s1 As FileStream 'Load file 1
            Dim s2 As FileStream 'Load file 2
            Dim s3 As FileStream 'Save output


            If System.IO.File.Exists(TextBox3.Text) Then
                System.IO.File.Delete(TextBox3.Text)
            End If

            '---read from and write to a binary file
            s1 = New FileStream(TextBox1.Text, FileMode.Open, FileAccess.Read)
            s2 = New FileStream(TextBox2.Text, FileMode.Open, FileAccess.Read)
            s3 = New FileStream(TextBox3.Text, FileMode.CreateNew, FileAccess.Write)

            Dim br1 As BinaryReader
            Dim br2 As BinaryReader
            Dim bw As BinaryWriter

            br1 = New BinaryReader(s1)
            br2 = New BinaryReader(s2)
            bw = New BinaryWriter(s3)

            Dim fLen1 As Integer
            Dim fLen2 As Integer
            Dim f1 As New System.IO.FileInfo(TextBox1.Text)
            Dim f2 As New System.IO.FileInfo(TextBox2.Text)
            fLen1 = f1.Length
            fLen2 = f2.Length

            If fLen1 <> fLen2 Then
                MessageBox.Show("File lengths are different. File lengths MUST be equal!!!", "Warning!")
                Me.btnBrowse1.Focus()
            Else

                Dim snglOutput(fLen1) As Single 'wıll hold results from division
                Dim snglRead1(fLen1) As Single
                Dim snglRead2(fLen2) As Single
                Dim i As Integer
                Dim j As Integer
                Dim m As Integer

                'Read binary file1  
                For i = 0 To fLen1 - 1
                    snglRead1(i) = br1.ReadSingle()
                Next


                'Read binary file2
                For j = 0 To fLen2 - 1
                    snglRead2(j) = br2.ReadSingle()
                Next


                For m = 0 To fLen1 - 1
                    If snglRead1(m) = 0 And snglRead2(m) = 0 Then
                        snglOutput(m) = 0
                    Else 'no division error, get the value to write
                        snglOutput(m) = (snglRead2(m) - snglRead1(m)) / (snglRead2(m) + snglRead1(m))
                    End If
                    bw.Write(snglOutput(m))
                Next

                s1.Close()
                s2.Close()
                s3.Close()

                MessageBox.Show("Kinetic temperature file has been created succesfully!", "Done")
                Me.Close()
            End If

        End If
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

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    Private Sub FormKineticTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class