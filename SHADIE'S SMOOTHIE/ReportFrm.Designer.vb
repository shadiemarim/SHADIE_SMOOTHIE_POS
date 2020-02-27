<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBoxRpt = New System.Windows.Forms.ComboBox()
        Me.DataGridRptView = New System.Windows.Forms.DataGridView()
        Me.RptCalender = New System.Windows.Forms.MonthCalendar()
        Me.NoSalesTxt = New System.Windows.Forms.TextBox()
        Me.ProfitTxt = New System.Windows.Forms.TextBox()
        Me.InnitInvestement = New System.Windows.Forms.TextBox()
        Me.BreakEvenDaysTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridRptView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxRpt
        '
        Me.ComboBoxRpt.FormattingEnabled = True
        Me.ComboBoxRpt.Items.AddRange(New Object() {"Daily", "Monthly"})
        Me.ComboBoxRpt.Location = New System.Drawing.Point(3, 26)
        Me.ComboBoxRpt.Name = "ComboBoxRpt"
        Me.ComboBoxRpt.Size = New System.Drawing.Size(277, 21)
        Me.ComboBoxRpt.TabIndex = 0
        '
        'DataGridRptView
        '
        Me.DataGridRptView.AllowUserToAddRows = False
        Me.DataGridRptView.AllowUserToDeleteRows = False
        Me.DataGridRptView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRptView.Location = New System.Drawing.Point(286, 12)
        Me.DataGridRptView.Name = "DataGridRptView"
        Me.DataGridRptView.ReadOnly = True
        Me.DataGridRptView.Size = New System.Drawing.Size(569, 472)
        Me.DataGridRptView.TabIndex = 1
        '
        'RptCalender
        '
        Me.RptCalender.Location = New System.Drawing.Point(18, 81)
        Me.RptCalender.Name = "RptCalender"
        Me.RptCalender.TabIndex = 3
        '
        'NoSalesTxt
        '
        Me.NoSalesTxt.Location = New System.Drawing.Point(145, 277)
        Me.NoSalesTxt.Name = "NoSalesTxt"
        Me.NoSalesTxt.Size = New System.Drawing.Size(100, 20)
        Me.NoSalesTxt.TabIndex = 4
        '
        'ProfitTxt
        '
        Me.ProfitTxt.Location = New System.Drawing.Point(145, 339)
        Me.ProfitTxt.Name = "ProfitTxt"
        Me.ProfitTxt.Size = New System.Drawing.Size(100, 20)
        Me.ProfitTxt.TabIndex = 5
        '
        'InnitInvestement
        '
        Me.InnitInvestement.Location = New System.Drawing.Point(3, 398)
        Me.InnitInvestement.Name = "InnitInvestement"
        Me.InnitInvestement.Size = New System.Drawing.Size(100, 20)
        Me.InnitInvestement.TabIndex = 6
        '
        'BreakEvenDaysTxt
        '
        Me.BreakEvenDaysTxt.Location = New System.Drawing.Point(145, 444)
        Me.BreakEvenDaysTxt.Name = "BreakEvenDaysTxt"
        Me.BreakEvenDaysTxt.Size = New System.Drawing.Size(100, 20)
        Me.BreakEvenDaysTxt.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "No_of_Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Profit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Enter Innitial Investment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 451)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Days to Break Even"
        '
        'ReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SHADIE_S_SMOOTHIE.My.Resources.Resources.bkgrndpic2
        Me.ClientSize = New System.Drawing.Size(867, 521)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BreakEvenDaysTxt)
        Me.Controls.Add(Me.InnitInvestement)
        Me.Controls.Add(Me.ProfitTxt)
        Me.Controls.Add(Me.NoSalesTxt)
        Me.Controls.Add(Me.RptCalender)
        Me.Controls.Add(Me.DataGridRptView)
        Me.Controls.Add(Me.ComboBoxRpt)
        Me.Name = "ReportFrm"
        Me.Text = "ReportFrm"
        CType(Me.DataGridRptView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxRpt As ComboBox
    Friend WithEvents DataGridRptView As DataGridView
    Friend WithEvents RptCalender As MonthCalendar
    Friend WithEvents NoSalesTxt As TextBox
    Friend WithEvents ProfitTxt As TextBox
    Friend WithEvents InnitInvestement As TextBox
    Friend WithEvents BreakEvenDaysTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
