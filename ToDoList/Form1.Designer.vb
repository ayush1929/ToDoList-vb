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
        Me.lstTasks = New System.Windows.Forms.ListBox()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.btnRemoveTask = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstTasks
        '
        Me.lstTasks.FormattingEnabled = True
        Me.lstTasks.Location = New System.Drawing.Point(206, 21)
        Me.lstTasks.Name = "lstTasks"
        Me.lstTasks.Size = New System.Drawing.Size(285, 121)
        Me.lstTasks.TabIndex = 0
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(206, 157)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(285, 20)
        Me.txtTask.TabIndex = 1
        '
        'btnAddTask
        '
        Me.btnAddTask.Location = New System.Drawing.Point(354, 193)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(137, 23)
        Me.btnAddTask.TabIndex = 2
        Me.btnAddTask.Text = "Add Task"
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'btnRemoveTask
        '
        Me.btnRemoveTask.Location = New System.Drawing.Point(206, 193)
        Me.btnRemoveTask.Name = "btnRemoveTask"
        Me.btnRemoveTask.Size = New System.Drawing.Size(108, 23)
        Me.btnRemoveTask.TabIndex = 3
        Me.btnRemoveTask.Text = "Remove Task"
        Me.btnRemoveTask.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRemoveTask)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.lstTasks)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTasks As ListBox
    Friend WithEvents txtTask As TextBox
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnRemoveTask As Button
End Class
