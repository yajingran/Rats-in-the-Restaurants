﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.grpTool = New System.Windows.Forms.GroupBox()
        Me.txtFileData = New System.Windows.Forms.TextBox()
        Me.lblValues = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboColumnValue = New System.Windows.Forms.ComboBox()
        Me.cboColumnName = New System.Windows.Forms.ComboBox()
        Me.cmdReadData = New System.Windows.Forms.Button()
        Me.chtChart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtChart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lstDataView = New System.Windows.Forms.ListView()
        Me.cmdWriteData = New System.Windows.Forms.Button()
        Me.lstSummaryView = New System.Windows.Forms.ListView()
        Me.grpTool.SuspendLayout()
        CType(Me.chtChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtChart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTool
        '
        Me.grpTool.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpTool.Controls.Add(Me.cmdWriteData)
        Me.grpTool.Controls.Add(Me.txtFileData)
        Me.grpTool.Controls.Add(Me.lblValues)
        Me.grpTool.Controls.Add(Me.Label1)
        Me.grpTool.Controls.Add(Me.cboColumnValue)
        Me.grpTool.Controls.Add(Me.cboColumnName)
        Me.grpTool.Controls.Add(Me.cmdReadData)
        Me.grpTool.Location = New System.Drawing.Point(12, 9)
        Me.grpTool.Name = "grpTool"
        Me.grpTool.Size = New System.Drawing.Size(179, 522)
        Me.grpTool.TabIndex = 1
        Me.grpTool.TabStop = False
        Me.grpTool.Text = "Filter Tools"
        '
        'txtFileData
        '
        Me.txtFileData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileData.Location = New System.Drawing.Point(15, 34)
        Me.txtFileData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFileData.Name = "txtFileData"
        Me.txtFileData.Size = New System.Drawing.Size(144, 20)
        Me.txtFileData.TabIndex = 3
        '
        'lblValues
        '
        Me.lblValues.AutoSize = True
        Me.lblValues.Location = New System.Drawing.Point(13, 157)
        Me.lblValues.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblValues.Name = "lblValues"
        Me.lblValues.Size = New System.Drawing.Size(75, 13)
        Me.lblValues.TabIndex = 2
        Me.lblValues.Text = "Column Value:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Column Name:"
        '
        'cboColumnValue
        '
        Me.cboColumnValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumnValue.FormattingEnabled = True
        Me.cboColumnValue.Location = New System.Drawing.Point(15, 179)
        Me.cboColumnValue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboColumnValue.Name = "cboColumnValue"
        Me.cboColumnValue.Size = New System.Drawing.Size(144, 21)
        Me.cboColumnValue.TabIndex = 1
        '
        'cboColumnName
        '
        Me.cboColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumnName.FormattingEnabled = True
        Me.cboColumnName.Location = New System.Drawing.Point(15, 130)
        Me.cboColumnName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboColumnName.Name = "cboColumnName"
        Me.cboColumnName.Size = New System.Drawing.Size(144, 21)
        Me.cboColumnName.TabIndex = 1
        '
        'cmdReadData
        '
        Me.cmdReadData.Location = New System.Drawing.Point(15, 64)
        Me.cmdReadData.Name = "cmdReadData"
        Me.cmdReadData.Size = New System.Drawing.Size(143, 21)
        Me.cmdReadData.TabIndex = 0
        Me.cmdReadData.Text = "Read Data"
        Me.cmdReadData.UseVisualStyleBackColor = True
        '
        'chtChart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtChart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtChart1.Legends.Add(Legend1)
        Me.chtChart1.Location = New System.Drawing.Point(212, 9)
        Me.chtChart1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chtChart1.Name = "chtChart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtChart1.Series.Add(Series1)
        Me.chtChart1.Size = New System.Drawing.Size(461, 231)
        Me.chtChart1.TabIndex = 2
        Me.chtChart1.Text = "Chart1"
        Me.chtChart1.Visible = False
        '
        'chtChart2
        '
        Me.chtChart2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.chtChart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chtChart2.Legends.Add(Legend2)
        Me.chtChart2.Location = New System.Drawing.Point(677, 9)
        Me.chtChart2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chtChart2.Name = "chtChart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chtChart2.Series.Add(Series2)
        Me.chtChart2.Size = New System.Drawing.Size(643, 231)
        Me.chtChart2.TabIndex = 2
        Me.chtChart2.Text = "Chart1"
        Me.chtChart2.Visible = False
        '
        'lstDataView
        '
        Me.lstDataView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstDataView.BackgroundImageTiled = True
        Me.lstDataView.Location = New System.Drawing.Point(212, 250)
        Me.lstDataView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstDataView.Name = "lstDataView"
        Me.lstDataView.Size = New System.Drawing.Size(544, 282)
        Me.lstDataView.TabIndex = 3
        Me.lstDataView.UseCompatibleStateImageBehavior = False
        Me.lstDataView.View = System.Windows.Forms.View.Details
        '
        'cmdWriteData
        '
        Me.cmdWriteData.Location = New System.Drawing.Point(15, 229)
        Me.cmdWriteData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdWriteData.Name = "cmdWriteData"
        Me.cmdWriteData.Size = New System.Drawing.Size(143, 23)
        Me.cmdWriteData.TabIndex = 4
        Me.cmdWriteData.Text = "Write Summary"
        Me.cmdWriteData.UseVisualStyleBackColor = True
        '
        'lstSummaryView
        '
        Me.lstSummaryView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSummaryView.BackgroundImageTiled = True
        Me.lstSummaryView.Location = New System.Drawing.Point(776, 250)
        Me.lstSummaryView.Margin = New System.Windows.Forms.Padding(2)
        Me.lstSummaryView.Name = "lstSummaryView"
        Me.lstSummaryView.Size = New System.Drawing.Size(544, 282)
        Me.lstSummaryView.TabIndex = 3
        Me.lstSummaryView.UseCompatibleStateImageBehavior = False
        Me.lstSummaryView.View = System.Windows.Forms.View.Details
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 541)
        Me.Controls.Add(Me.lstSummaryView)
        Me.Controls.Add(Me.lstDataView)
        Me.Controls.Add(Me.chtChart2)
        Me.Controls.Add(Me.chtChart1)
        Me.Controls.Add(Me.grpTool)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Team 5 Tool"
        Me.grpTool.ResumeLayout(False)
        Me.grpTool.PerformLayout()
        CType(Me.chtChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtChart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTool As GroupBox
    Friend WithEvents cmdReadData As Button
    Friend WithEvents txtFileData As TextBox
    Friend WithEvents lblValues As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboColumnValue As ComboBox
    Friend WithEvents cboColumnName As ComboBox
    Friend WithEvents chtChart1 As DataVisualization.Charting.Chart
    Friend WithEvents chtChart2 As DataVisualization.Charting.Chart
    Friend WithEvents lstDataView As ListView
    Friend WithEvents cmdWriteData As Button
    Friend WithEvents lstSummaryView As ListView
End Class
