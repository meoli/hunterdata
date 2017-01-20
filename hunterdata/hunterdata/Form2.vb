Public Class Form2

    Private Sub MobsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MobsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HunterstatsDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HunterstatsDataSet.mobs' table. You can move, or remove it, as needed.
        Me.MobsTableAdapter.Fill(Me.HunterstatsDataSet.mobs)

    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged

    End Sub
End Class