Imports System.IO

Public Class Form1

    Dim blnCost As Boolean = False
    Dim blnPower As Boolean = False
    Dim blnHours As Boolean = False
    Dim blnGalHr As Boolean = False
    Dim blnWaterCost As Boolean = False

    Dim blnSecondEntry As Boolean = False

    Dim total As Double = 0
    Dim bill As Double = 0

    Dim blnCkPower As Boolean = True

    Private Sub cboAppliance_ItemChanged(sender As Object, _
    e As EventArgs) Handles cboAppliance.TextChanged
        If blnCkPower = True Then
            Dim filePath As String = "appliance.txt" ''* file coming from control
            Dim fileContents As String = System.IO.File.ReadAllText(filePath)
            Dim contentArray() As String = fileContents.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)


            If cboAppliance.SelectedIndex = 0 Then
                txtCost.Text = contentArray(0)
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
                txtGalHr.Enabled = False
                txtWaterCost.Enabled = False
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
            ElseIf cboAppliance.SelectedIndex = 1 Then
                txtCost.Text = contentArray(1)
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
                txtGalHr.Enabled = False
                txtWaterCost.Enabled = False
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
            ElseIf cboAppliance.SelectedIndex = 2 Then
                txtCost.Text = contentArray(2)
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
                txtGalHr.Enabled = False
                txtWaterCost.Enabled = False
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
            ElseIf cboAppliance.SelectedIndex = 3 Then
                txtCost.Text = contentArray(3)
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
                txtGalHr.Enabled = False
                txtWaterCost.Enabled = False
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
            ElseIf cboAppliance.SelectedIndex = 4 Then
                txtCost.Text = contentArray(4)
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
                txtGalHr.Enabled = False
                txtWaterCost.Enabled = False
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
            ElseIf cboAppliance.SelectedIndex = 5 Then
                txtCost.Text = contentArray(5)
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
                txtGalHr.Enabled = False
                txtWaterCost.Enabled = False
                txtGalHr.Text = CStr(0)
                txtWaterCost.Text = CStr(0)
            ElseIf cboAppliance.SelectedIndex = 6 Then
                txtCost.Text = contentArray(6)
                txtPower.Text = ""
                txtHours.Text = ""
                txtGalHr.Text = ""
                txtWaterCost.Text = ""
                txtGalHr.Enabled = True
                txtWaterCost.Enabled = True
            End If
        End If
    End Sub



    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If txtCost.TextLength > 0 And txtHours.TextLength > 0 And
        txtPower.TextLength > 0 And txtGalHr.TextLength > 0 And txtWaterCost.TextLength > 0 Then
            If IsNumeric(txtCost.Text) = False Then
                MessageBox.Show("The quantity entered is not numeric.")
                txtCost.Text = ""
            Else
                blnCost = True
            End If
            If IsNumeric(txtPower.Text) = False Then
                MessageBox.Show("The quantity entered is not numeric.")
                txtPower.Text = ""
            Else
                blnPower = True
            End If
            If IsNumeric(txtHours.Text) = False Then
                MessageBox.Show("The quantity entered is not numeric.")
                txtHours.Text = ""
            Else
                blnHours = True
            End If
            If IsNumeric(txtGalHr.Text) = False Then
                MessageBox.Show("The quantity entered is not numeric.")
                txtGalHr.Text = ""
            Else
                blnGalHr = True
            End If
            If IsNumeric(txtWaterCost.Text) = False Then
                MessageBox.Show("The quantity entered is not numeric.")
                txtWaterCost.Text = ""
            Else
                blnWaterCost = True
            End If
        End If
        If cboAppliance.SelectedIndex = 6 Then
            If blnCost And blnHours And blnPower And blnGalHr And blnWaterCost And
            blnGalHr And blnWaterCost = True Then
                calculateBill1()
            End If
        Else
            If blnCost And blnHours And blnPower And blnGalHr And blnWaterCost = True Then
                calculateBill2()
            End If
        End If

    End Sub
    Private Sub calculateBill1()
        Dim cost, power, hours, galHr, waterCost As Double
        cost = Double.Parse(txtCost.Text)
        power = Double.Parse(txtPower.Text)
        hours = Double.Parse(txtHours.Text)
        galHr = Double.Parse(txtGalHr.Text)
        waterCost = Double.Parse(txtWaterCost.Text)
        total = (cost * power * hours + (galHr * waterCost))
        bill = bill + total
        txtBill.Text = CStr(FormatCurrency(total))

        sendToList()
    End Sub
    Private Sub calculateBill2()
        Dim cost, power, hours As Double
        cost = Double.Parse(txtCost.Text)
        power = Double.Parse(txtPower.Text)
        hours = Double.Parse(txtHours.Text)
        total = cost * power * hours
        bill = bill + total
        txtBill.Text = CStr(FormatCurrency(total))

        sendToList()
    End Sub

    Private Sub sendToList()
        'Dim newEntry1 As String = cboAppliance.Text
        'Dim newEntry2 As String = txtHours.Text
        'Dim newEntry3 As String = CStr(total)
        'If blnSecondEntry = True Then
        '    txtList1.Text &= Environment.NewLine & newEntry1
        '    txtList2.Text &= Environment.NewLine & newEntry2
        '    txtList3.Text &= Environment.NewLine & newEntry3
        'Else
        '    txtList1.Text = newEntry1
        '    txtList2.Text = newEntry2
        '    txtList3.Text = newEntry3
        '    blnSecondEntry = True
        'End If

        Dim newEntry As String = (cboAppliance.Text & " " & txtHours.Text & " " & CStr(total))
        If blnSecondEntry = True Then
            txtList1.Text &= Environment.NewLine & newEntry
        Else
            txtList1.Text = newEntry
            blnSecondEntry = True
        End If
    End Sub

    Private Sub ckPower_CheckedChanged(sender As Object, e As EventArgs) Handles ckPower.CheckedChanged
        If ckPower.Checked = False Then
            txtCost.Enabled = True
            blnCkPower = False
        ElseIf ckPower.Checked = True Then
            txtCost.Enabled = False
            blnCkPower = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objWriter As New StreamWriter("applianceCost.txt", False)
        Dim tmpList As String = (txtList1.Text)
        objWriter.WriteLine(tmpList)
        objWriter.Close()
        MsgBox("List Saved to File")
    End Sub
End Class


'Private Sub cboAppliance_ItemChanged(sender As Object, _
'e As EventArgs) Handles cboAppliance.TextChanged
'    If cboAppliance.SelectedIndex = 6 Then
'        blnGalHr = True
'        blnWaterCost = True
'        txtCost.Text = CStr(0)
'        txtPower.Text = CStr(0)
'        txtHours.Text = CStr(0)
'        txtGalHr.Text = CStr(0)
'        txtWaterCost.Text = CStr(0)
'        txtGalHr.Enabled = True
'        txtWaterCost.Enabled = True
'    Else
'        txtCost.Text = CStr(0)
'        txtPower.Text = CStr(0)
'        txtHours.Text = CStr(0)
'        txtGalHr.Text = CStr(0)
'        txtWaterCost.Text = CStr(0)
'        txtGalHr.Enabled = False
'        txtWaterCost.Enabled = False
'    End If
'End Sub

' Private Sub txtCost_TextChanged(sender As Object, _
' e As EventArgs) Handles txtCost.TextChanged
'     checkNumeric()
'     If txtCost.TextLength = 0 Then
'         'Do Nothing
'     Else
'         If blnCost And blnHours And blnPower And blnGalHr And blnWaterCost = True Then
'             calculateBill()
'         End If
'     End If

' End Sub
' Private Sub txtPower_TextChanged(sender As Object, _
'e As EventArgs) Handles txtPower.TextChanged
'     checkNumeric()
'     If txtPower.TextLength = 0 Then
'         'Do Nothing
'     Else
'         If blnCost And blnHours And blnPower And blnGalHr And blnWaterCost = True Then
'             calculateBill()
'         End If
'     End If

' End Sub
' Private Sub txtHours_TextChanged(sender As Object, _
' e As EventArgs) Handles txtHours.TextChanged
'     checkNumeric()
'     If txtHours.TextLength = 0 Then
'         'Do nothing
'     Else
'         If blnCost And blnHours And blnPower And blnGalHr And blnWaterCost = True Then
'             calculateBill()
'         End If
'     End If

' End Sub
' Private Sub txtGalHr_TextChanged(sender As Object, _
' e As EventArgs) Handles txtGalHr.TextChanged
'     checkNumeric()
'     If txtGalHr.TextLength = 0 Then
'         'Do nothing
'     Else
'         If blnCost And blnHours And blnPower And blnGalHr And blnWaterCost = True Then
'             calculateBill()
'         End If
'     End If

' End Sub
' Private Sub txtWaterCost_TextChanged(sender As Object, _
' e As EventArgs) Handles txtWaterCost.TextChanged
'     checkNumeric()
'     If txtWaterCost.TextLength = 0 Then
'         'Do nothing
'     Else
'         If blnCost And blnHours And blnPower And blnGalHr And blnWaterCost = True Then
'             calculateBill()
'         End If
'     End If

' End Sub
'Private Sub checkNumeric()
'    If txtCost.TextLength > 4 Then
'        blnCost = False
'        MessageBox.Show("The quantity entered is too large.")
'        txtCost.Text = ""
'    End If

'    If txtHours.TextLength > 4 Then
'        blnHours = False
'        MessageBox.Show("The quantity entered is too large.")
'        txtHours.Text = ""
'    End If

'    If txtPower.TextLength > 4 Then
'        blnPower = False
'        MessageBox.Show("The quantity entered is too large.")
'        txtPower.Text = ""
'    End If

'    If txtGalHr.TextLength > 4 Then
'        blnGalHr = False
'        MessageBox.Show("The quantity entered is too large.")
'        txtGalHr.Text = ""
'    End If

'    If txtWaterCost.TextLength > 4 Then
'        blnWaterCost = False
'        MessageBox.Show("The quantity entered is too large.")
'        txtWaterCost.Text = ""
'    End If
