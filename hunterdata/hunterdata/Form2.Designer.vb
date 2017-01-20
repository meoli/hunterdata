<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim HealthLabel As System.Windows.Forms.Label
        Dim ExpLabel As System.Windows.Forms.Label
        Dim JobLabel As System.Windows.Forms.Label
        Me.HunterstatsDataSet = New hunterdata.hunterstatsDataSet()
        Me.MobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobsTableAdapter = New hunterdata.hunterstatsDataSetTableAdapters.mobsTableAdapter()
        Me.TableAdapterManager = New hunterdata.hunterstatsDataSetTableAdapters.TableAdapterManager()
        Me.MobsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        HealthLabel = New System.Windows.Forms.Label()
        ExpLabel = New System.Windows.Forms.Label()
        JobLabel = New System.Windows.Forms.Label()
        CType(Me.HunterstatsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MobsBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HunterstatsDataSet
        '
        Me.HunterstatsDataSet.DataSetName = "hunterstatsDataSet"
        Me.HunterstatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MobsBindingSource
        '
        Me.MobsBindingSource.DataMember = "mobs"
        Me.MobsBindingSource.DataSource = Me.HunterstatsDataSet
        '
        'MobsTableAdapter
        '
        Me.MobsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mobsTableAdapter = Me.MobsTableAdapter
        Me.TableAdapterManager.UpdateOrder = hunterdata.hunterstatsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MobsBindingNavigator
        '
        Me.MobsBindingNavigator.AddNewItem = Nothing
        Me.MobsBindingNavigator.BindingSource = Me.MobsBindingSource
        Me.MobsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MobsBindingNavigator.DeleteItem = Nothing
        Me.MobsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.MobsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MobsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MobsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MobsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MobsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MobsBindingNavigator.Name = "MobsBindingNavigator"
        Me.MobsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MobsBindingNavigator.Size = New System.Drawing.Size(404, 25)
        Me.MobsBindingNavigator.TabIndex = 0
        Me.MobsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 24)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.AliceBlue
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobsBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Book Antiqua", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NameTextBox.Location = New System.Drawing.Point(12, 29)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(119, 29)
        Me.NameTextBox.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.Color.AliceBlue
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(15, 64)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 15)
        Me.IDTextBox.TabIndex = 4
        '
        'HealthLabel
        '
        HealthLabel.AutoSize = True
        HealthLabel.Location = New System.Drawing.Point(4, 62)
        HealthLabel.Name = "HealthLabel"
        HealthLabel.Size = New System.Drawing.Size(53, 17)
        HealthLabel.TabIndex = 4
        HealthLabel.Text = "Health:"
        '
        'ExpLabel
        '
        ExpLabel.AutoSize = True
        ExpLabel.Location = New System.Drawing.Point(4, 1)
        ExpLabel.Name = "ExpLabel"
        ExpLabel.Size = New System.Drawing.Size(35, 17)
        ExpLabel.TabIndex = 5
        ExpLabel.Text = "Exp:"
        '
        'JobLabel
        '
        JobLabel.AutoSize = True
        JobLabel.Location = New System.Drawing.Point(4, 32)
        JobLabel.Name = "JobLabel"
        JobLabel.Size = New System.Drawing.Size(35, 17)
        JobLabel.TabIndex = 7
        JobLabel.Text = "Job:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(HealthLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(JobLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(ExpLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 131)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 91)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobsBindingSource, "Exp", True))
        Me.Label1.Location = New System.Drawing.Point(64, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobsBindingSource, "Job", True))
        Me.Label2.Location = New System.Drawing.Point(64, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobsBindingSource, "Health", True))
        Me.Label3.Location = New System.Drawing.Point(64, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Label3"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(404, 366)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.MobsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Monster Stats"
        CType(Me.HunterstatsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MobsBindingNavigator.ResumeLayout(False)
        Me.MobsBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HunterstatsDataSet As hunterdata.hunterstatsDataSet
    Friend WithEvents MobsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobsTableAdapter As hunterdata.hunterstatsDataSetTableAdapters.mobsTableAdapter
    Friend WithEvents TableAdapterManager As hunterdata.hunterstatsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MobsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
