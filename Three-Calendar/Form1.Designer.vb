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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar3 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(10, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(236, 18)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 1
        '
        'MonthCalendar3
        '
        Me.MonthCalendar3.Location = New System.Drawing.Point(462, 18)
        Me.MonthCalendar3.Name = "MonthCalendar3"
        Me.MonthCalendar3.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(714, 197)
        Me.Controls.Add(Me.MonthCalendar3)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Three Month Calendar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents MonthCalendar3 As MonthCalendar
End Class
