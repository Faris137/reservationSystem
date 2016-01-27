<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Request
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Request))
        Dim IDLabel As System.Windows.Forms.Label
        Dim App_DateLabel As System.Windows.Forms.Label
        Dim App_TimeLabel As System.Windows.Forms.Label
        Dim Stu_nameLabel As System.Windows.Forms.Label
        Dim Lec_NameLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.ConsultDataSet = New WindowsApplication1.consultDataSet()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentTableAdapter = New WindowsApplication1.consultDataSetTableAdapters.AppointmentTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.consultDataSetTableAdapters.TableAdapterManager()
        Me.AppointmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AppointmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.App_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.App_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Stu_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Lec_NameTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        App_DateLabel = New System.Windows.Forms.Label()
        App_TimeLabel = New System.Windows.Forms.Label()
        Stu_nameLabel = New System.Windows.Forms.Label()
        Lec_NameLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.ConsultDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppointmentBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConsultDataSet
        '
        Me.ConsultDataSet.DataSetName = "consultDataSet"
        Me.ConsultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "Appointment"
        Me.AppointmentBindingSource.DataSource = Me.ConsultDataSet
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Me.AppointmentTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LecturerTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.consultDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'AppointmentBindingNavigator
        '
        Me.AppointmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AppointmentBindingNavigator.BindingSource = Me.AppointmentBindingSource
        Me.AppointmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AppointmentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AppointmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AppointmentBindingNavigatorSaveItem})
        Me.AppointmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AppointmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AppointmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AppointmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AppointmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AppointmentBindingNavigator.Name = "AppointmentBindingNavigator"
        Me.AppointmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AppointmentBindingNavigator.Size = New System.Drawing.Size(395, 25)
        Me.AppointmentBindingNavigator.TabIndex = 0
        Me.AppointmentBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AppointmentBindingNavigatorSaveItem
        '
        Me.AppointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AppointmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("AppointmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AppointmentBindingNavigatorSaveItem.Name = "AppointmentBindingNavigatorSaveItem"
        Me.AppointmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AppointmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(64, 96)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(129, 93)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'App_DateLabel
        '
        App_DateLabel.AutoSize = True
        App_DateLabel.Location = New System.Drawing.Point(64, 123)
        App_DateLabel.Name = "App_DateLabel"
        App_DateLabel.Size = New System.Drawing.Size(55, 13)
        App_DateLabel.TabIndex = 3
        App_DateLabel.Text = "App Date:"
        '
        'App_DateDateTimePicker
        '
        Me.App_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AppointmentBindingSource, "App_Date", True))
        Me.App_DateDateTimePicker.Location = New System.Drawing.Point(129, 119)
        Me.App_DateDateTimePicker.Name = "App_DateDateTimePicker"
        Me.App_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.App_DateDateTimePicker.TabIndex = 4
        '
        'App_TimeLabel
        '
        App_TimeLabel.AutoSize = True
        App_TimeLabel.Location = New System.Drawing.Point(64, 149)
        App_TimeLabel.Name = "App_TimeLabel"
        App_TimeLabel.Size = New System.Drawing.Size(55, 13)
        App_TimeLabel.TabIndex = 5
        App_TimeLabel.Text = "App Time:"
        '
        'App_TimeDateTimePicker
        '
        Me.App_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AppointmentBindingSource, "App_Time", True))
        Me.App_TimeDateTimePicker.Location = New System.Drawing.Point(129, 145)
        Me.App_TimeDateTimePicker.Name = "App_TimeDateTimePicker"
        Me.App_TimeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.App_TimeDateTimePicker.TabIndex = 6
        '
        'Stu_nameLabel
        '
        Stu_nameLabel.AutoSize = True
        Stu_nameLabel.Location = New System.Drawing.Point(64, 174)
        Stu_nameLabel.Name = "Stu_nameLabel"
        Stu_nameLabel.Size = New System.Drawing.Size(55, 13)
        Stu_nameLabel.TabIndex = 7
        Stu_nameLabel.Text = "Stu name:"
        '
        'Stu_nameTextBox
        '
        Me.Stu_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Stu_name", True))
        Me.Stu_nameTextBox.Location = New System.Drawing.Point(129, 171)
        Me.Stu_nameTextBox.Name = "Stu_nameTextBox"
        Me.Stu_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Stu_nameTextBox.TabIndex = 8
        '
        'Lec_NameLabel
        '
        Lec_NameLabel.AutoSize = True
        Lec_NameLabel.Location = New System.Drawing.Point(64, 200)
        Lec_NameLabel.Name = "Lec_NameLabel"
        Lec_NameLabel.Size = New System.Drawing.Size(59, 13)
        Lec_NameLabel.TabIndex = 9
        Lec_NameLabel.Text = "Lec Name:"
        '
        'Lec_NameTextBox
        '
        Me.Lec_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Lec_Name", True))
        Me.Lec_NameTextBox.Location = New System.Drawing.Point(129, 197)
        Me.Lec_NameTextBox.Name = "Lec_NameTextBox"
        Me.Lec_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Lec_NameTextBox.TabIndex = 10
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(64, 226)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 11
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(129, 223)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(11, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Create Appointment Request :"
        '
        'Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(395, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(App_DateLabel)
        Me.Controls.Add(Me.App_DateDateTimePicker)
        Me.Controls.Add(App_TimeLabel)
        Me.Controls.Add(Me.App_TimeDateTimePicker)
        Me.Controls.Add(Stu_nameLabel)
        Me.Controls.Add(Me.Stu_nameTextBox)
        Me.Controls.Add(Lec_NameLabel)
        Me.Controls.Add(Me.Lec_NameTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.AppointmentBindingNavigator)
        Me.Name = "Request"
        Me.Text = "Request"
        CType(Me.ConsultDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppointmentBindingNavigator.ResumeLayout(False)
        Me.AppointmentBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsultDataSet As consultDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As consultDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents TableAdapterManager As consultDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppointmentBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AppointmentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents App_DateDateTimePicker As DateTimePicker
    Friend WithEvents App_TimeDateTimePicker As DateTimePicker
    Friend WithEvents Stu_nameTextBox As TextBox
    Friend WithEvents Lec_NameTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
