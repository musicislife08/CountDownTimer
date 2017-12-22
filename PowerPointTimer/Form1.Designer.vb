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
        Me.components = New System.ComponentModel.Container()
        Me.lblCountDown = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.CDTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMin = New System.Windows.Forms.TextBox()
        Me.TimerCheckHotkey = New System.Windows.Forms.Timer(Me.components)
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCountDown
        '
        Me.lblCountDown.AutoSize = True
        Me.lblCountDown.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountDown.Location = New System.Drawing.Point(93, 5)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(259, 78)
        Me.lblCountDown.TabIndex = 0
        Me.lblCountDown.Text = "00:00:00"
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(15, 5)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(81, 20)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'CDTimer
        '
        Me.CDTimer.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Min"
        '
        'tbMin
        '
        Me.tbMin.Location = New System.Drawing.Point(42, 54)
        Me.tbMin.Name = "tbMin"
        Me.tbMin.Size = New System.Drawing.Size(54, 20)
        Me.tbMin.TabIndex = 3
        Me.tbMin.Text = "5"
        '
        'TimerCheckHotkey
        '
        Me.TimerCheckHotkey.Interval = 1
        '
        'bw
        '
        Me.bw.WorkerReportsProgress = True
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(15, 27)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(81, 21)
        Me.BtnStop.TabIndex = 4
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 89)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.tbMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.lblCountDown)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(376, 128)
        Me.MinimumSize = New System.Drawing.Size(376, 128)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Count Down Timer"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCountDown As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents CDTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMin As TextBox
    Friend WithEvents TimerCheckHotkey As Timer
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnStop As Button
End Class
