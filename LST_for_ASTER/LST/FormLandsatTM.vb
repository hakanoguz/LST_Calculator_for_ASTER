Imports System.IO
Public Class FormLandsatTM

    Private Sub FormLandsatTM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Or txtBoxGain.Text.Length = 0 Or txtBoxBias.Text.Length = 0 Then
            MessageBox.Show("Oops, you must be forgetting something here :)  Before pressing OK button, make sure that you input Gain, Bias parameters, and Landsat TM Band 6 file. Then SELECT a directory where the output file will be saved to!!!", "Warning!")
            Me.txtBoxGain.Focus()
        Else
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
            fLen1 = f1.Length


            Dim snglRead1(fLen1) As Single
            Dim snglOutput(fLen1) As Single 'wıll hold results from division

            Dim i As Integer
            Dim m As Integer

            'Read binary file1 and fill the array with pixel values 
            For i = 0 To fLen1 - 1
                snglRead1(i) = br1.ReadByte
            Next


            Dim gain As Single
            Dim bias As Single 'bias and offset are the same thing...
            gain = CSng(txtBoxGain.Text)
            bias = CSng(txtBoxBias.Text)


            For m = 0 To fLen1 - 1
                snglOutput(m) = gain * snglRead1(m) + bias

                bw.Write(snglOutput(m))
            Next

            'following 4 msgboxes are used for testing purposes
            'MsgBox("gain= " & gain)
            'MsgBox("bias= " & bias)
            'MsgBox("snglRead1(0)= " & snglRead1(0))
            'MsgBox("snglOutput(0)= " & snglOutput(0))

            s1.Close()
            s3.Close()

            MessageBox.Show("Original DN values of Landsat TM band have been successfully converted to TOA Radiance!", "Done")
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Multiselect = False
        OpenFD.Title = "Select a Landsat TM Band"
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

    Private Sub txtBoxGain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxGain.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    Private Sub txtBoxBias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoxBias.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub
End Class