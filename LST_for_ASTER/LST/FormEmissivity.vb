Imports System.IO
Public Class FormEmissivity

    Private Sub FormEmissivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        Me.Label3.Text = ""
        Me.Label3.Text = ""
        Me.btnOK.Enabled = True
        Me.PictureBox1.Visible = False
        Me.PictureBox2.Visible = False
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        openFD.InitialDirectory = "C:\"
        openFD.Multiselect = False
        OpenFD.Title = "Select NDVI File"
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Then
            MessageBox.Show("Please select the NDVI file and then the directory path to save in!", "Warning!")
            Me.btnBrowse.Focus()
        Else
            Me.Cursor = Cursors.WaitCursor
            Me.PictureBox1.Visible = True
            Me.PictureBox1.Update()
            Me.btnOK.Enabled = False
            Me.Label4.Visible = False
            Me.Label4.Update()
            Me.Label3.Text = "Processing... Please Wait!"
            Me.Label3.Update()

            Dim s1 As FileStream 'Load file 1           
            Dim s3 As FileStream 'Save output

            'Delete file If exists
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
            'Dim Pv(fLen1) As Single

            Dim snglRead1 As Single
            Dim Pv As Single
            Dim snglOutput As Single 'wıll hold result from division


            Dim i As Integer
            'Dim k As Integer
            'Dim m As Integer

            'read file and do math calc...
            For i = 0 To fLen1 - 1
                snglRead1 = br1.ReadSingle()
                Pv = ((snglRead1 - 0.2) / (0.5 - 0.2)) ^ 2
                If snglRead1 < 0.2 Then
                    snglOutput = 0.97
                ElseIf snglRead1 > 0.5 Then
                    snglOutput = 0.99
                Else
                    snglOutput = ((0.99 * Pv) + (0.97 * (1 - Pv)))
                End If
                bw.Write(snglOutput)
            Next


            'For k = 0 To fLen1 - 1
            '    Pv(k) = ((snglRead1(k) - 0.2) / (0.5 - 0.2)) ^ 2
            'Next


            'For m = 0 To fLen1 - 1
            '    If snglRead1(m) < 0.2 Then
            '        snglOutput(m) = 0.97
            '    ElseIf snglRead1(m) > 0.5 Then
            '        snglOutput(m) = 0.99
            '    Else
            '        snglOutput(m) = ((0.99 * Pv(m)) + (0.97 * (1 - Pv(m))))
            '    End If
            '    bw.Write(snglOutput(m))
            'Next

            s1.Close()
            s3.Close()

            Me.PictureBox1.Visible = False
            Me.PictureBox2.Visible = True

            Me.Label3.Visible = False
            Me.Label3.Update()
            Me.Label4.Visible = True
            Me.Label4.Text = "Process Completed!"
            Me.Label4.Update()
            btnCancel.Text = "Close"
            Me.Cursor = Cursors.Default
            MessageBox.Show("File created succesfully!", "Success!")
            'Me.Close()
        End If
    End Sub
End Class