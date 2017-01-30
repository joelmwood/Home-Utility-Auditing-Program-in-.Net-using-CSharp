<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.lblHoursUsed = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cboAppliance = New System.Windows.Forms.ComboBox()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGalHr = New System.Windows.Forms.TextBox()
        Me.txtWaterCost = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtList1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ckPower = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAppliance.Location = New System.Drawing.Point(12, 9)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(92, 15)
        Me.lblAppliance.TabIndex = 0
        Me.lblAppliance.Text = "Select Appliance:"
        '
        'lblHoursUsed
        '
        Me.lblHoursUsed.AutoSize = True
        Me.lblHoursUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHoursUsed.Location = New System.Drawing.Point(12, 78)
        Me.lblHoursUsed.Name = "lblHoursUsed"
        Me.lblHoursUsed.Size = New System.Drawing.Size(207, 15)
        Me.lblHoursUsed.TabIndex = 1
        Me.lblHoursUsed.Text = "Enter the power needed per kilowatt-hour:"
        '
        'cboAppliance
        '
        Me.cboAppliance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppliance.FormattingEnabled = True
        Me.cboAppliance.Items.AddRange(New Object() {"Refrigerator", "TV", "Space Heater", "Fan", "Dryer", "Oven", "Washer"})
        Me.cboAppliance.Location = New System.Drawing.Point(230, 8)
        Me.cboAppliance.Name = "cboAppliance"
        Me.cboAppliance.Size = New System.Drawing.Size(101, 21)
        Me.cboAppliance.TabIndex = 2
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(231, 78)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(100, 20)
        Me.txtPower.TabIndex = 3
        Me.txtPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBill
        '
        Me.txtBill.BackColor = System.Drawing.SystemColors.Window
        Me.txtBill.Location = New System.Drawing.Point(202, 196)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.ReadOnly = True
        Me.txtBill.Size = New System.Drawing.Size(100, 20)
        Me.txtBill.TabIndex = 5
        Me.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(231, 103)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 7
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter the number of hours used:"
        '
        'txtCost
        '
        Me.txtCost.Enabled = False
        Me.txtCost.Location = New System.Drawing.Point(230, 35)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 9
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(11, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter the cost per kilowatt-hour:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(125, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Amount Due:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(15, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Water Cost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(15, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Gal Water/Hr"
        '
        'txtGalHr
        '
        Me.txtGalHr.Enabled = False
        Me.txtGalHr.Location = New System.Drawing.Point(231, 129)
        Me.txtGalHr.Name = "txtGalHr"
        Me.txtGalHr.Size = New System.Drawing.Size(100, 20)
        Me.txtGalHr.TabIndex = 13
        Me.txtGalHr.Text = "0"
        Me.txtGalHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWaterCost
        '
        Me.txtWaterCost.Enabled = False
        Me.txtWaterCost.Location = New System.Drawing.Point(231, 154)
        Me.txtWaterCost.Name = "txtWaterCost"
        Me.txtWaterCost.Size = New System.Drawing.Size(100, 20)
        Me.txtWaterCost.TabIndex = 14
        Me.txtWaterCost.Text = "0"
        Me.txtWaterCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(44, 194)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 17
        Me.btnCalc.Text = "Calculate Bill"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtList1)
        Me.GroupBox1.Location = New System.Drawing.Point(87, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 153)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appliance Totals"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Appliance-Hours-Cost"
        '
        'txtList1
        '
        Me.txtList1.Location = New System.Drawing.Point(24, 32)
        Me.txtList1.Multiline = True
        Me.txtList1.Name = "txtList1"
        Me.txtList1.Size = New System.Drawing.Size(101, 115)
        Me.txtList1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(230, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Default Power"
        '
        'ckPower
        '
        Me.ckPower.AutoSize = True
        Me.ckPower.Checked = True
        Me.ckPower.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckPower.Location = New System.Drawing.Point(312, 59)
        Me.ckPower.Name = "ckPower"
        Me.ckPower.Size = New System.Drawing.Size(15, 14)
        Me.ckPower.TabIndex = 20
        Me.ckPower.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(121, 382)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save Totals"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(364, 420)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ckPower)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtWaterCost)
        Me.Controls.Add(Me.txtGalHr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.txtPower)
        Me.Controls.Add(Me.cboAppliance)
        Me.Controls.Add(Me.lblHoursUsed)
        Me.Controls.Add(Me.lblAppliance)
        Me.Name = "Form1"
        Me.Text = "Home Utility Auditing App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAppliance As System.Windows.Forms.Label
    Friend WithEvents lblHoursUsed As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cboAppliance As System.Windows.Forms.ComboBox
    Friend WithEvents txtPower As System.Windows.Forms.TextBox
    Friend WithEvents txtBill As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGalHr As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterCost As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtList1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ckPower As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
