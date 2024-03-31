Public Class Form1
    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        Dim task As String = txtTask.Text.Trim()
        If Not String.IsNullOrEmpty(task) Then
            lstTasks.Items.Add(task)
            txtTask.Clear()
        Else
            MessageBox.Show("Please enter a task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveTask_Click(sender As Object, e As EventArgs) Handles btnRemoveTask.Click
        If lstTasks.SelectedIndex <> -1 Then
            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex)
        Else
            MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
