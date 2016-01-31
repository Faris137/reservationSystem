<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lecturer
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.App_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.App_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Stu_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Lec_NameTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.AppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        App_DateLabel = New System.Windows.Forms.Label()
        App_TimeLabel = New System.Windows.Forms.Label()
        Stu_nameLabel = New System.Windows.Forms.Label()
        Lec_NameLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.ConsultDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(650, 405)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkSalmon
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.AppointmentDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(642, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkSalmon
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(IDLabel)
        Me.TabPage2.Controls.Add(Me.IDTextBox)
        Me.TabPage2.Controls.Add(App_DateLabel)
        Me.TabPage2.Controls.Add(Me.App_DateDateTimePicker)
        Me.TabPage2.Controls.Add(App_TimeLabel)
        Me.TabPage2.Controls.Add(Me.App_TimeTextBox)
        Me.TabPage2.Controls.Add(Stu_nameLabel)
        Me.TabPage2.Controls.Add(Me.Stu_nameTextBox)
        Me.TabPage2.Controls.Add(Lec_NameLabel)
        Me.TabPage2.Controls.Add(Me.Lec_NameTextBox)
        Me.TabPage2.Controls.Add(StatusLabel)
        Me.TabPage2.Controls.Add(Me.StatusTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(642, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Requests"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(38, 44)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(103, 41)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'App_DateLabel
        '
        App_DateLabel.AutoSize = True
        App_DateLabel.Location = New System.Drawing.Point(38, 71)
        App_DateLabel.Name = "App_DateLabel"
        App_DateLabel.Size = New System.Drawing.Size(55, 13)
        App_DateLabel.TabIndex = 2
        App_DateLabel.Text = "App Date:"
        '
        'App_DateDateTimePicker
        '
        Me.App_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AppointmentBindingSource, "App_Date", True))
        Me.App_DateDateTimePicker.Location = New System.Drawing.Point(103, 67)
        Me.App_DateDateTimePicker.Name = "App_DateDateTimePicker"
        Me.App_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.App_DateDateTimePicker.TabIndex = 3
        '
        'App_TimeLabel
        '
        App_TimeLabel.AutoSize = True
        App_TimeLabel.Location = New System.Drawing.Point(38, 96)
        App_TimeLabel.Name = "App_TimeLabel"
        App_TimeLabel.Size = New System.Drawing.Size(55, 13)
        App_TimeLabel.TabIndex = 4
        App_TimeLabel.Text = "App Time:"
        '
        'App_TimeTextBox
        '
        Me.App_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "App_Time", True))
        Me.App_TimeTextBox.Location = New System.Drawing.Point(103, 93)
        Me.App_TimeTextBox.Name = "App_TimeTextBox"
        Me.App_TimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.App_TimeTextBox.TabIndex = 5
        '
        'Stu_nameLabel
        '
        Stu_nameLabel.AutoSize = True
        Stu_nameLabel.Location = New System.Drawing.Point(38, 122)
        Stu_nameLabel.Name = "Stu_nameLabel"
        Stu_nameLabel.Size = New System.Drawing.Size(55, 13)
        Stu_nameLabel.TabIndex = 6
        Stu_nameLabel.Text = "Stu name:"
        '
        'Stu_nameTextBox
        '
        Me.Stu_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Stu_name", True))
        Me.Stu_nameTextBox.Location = New System.Drawing.Point(103, 119)
        Me.Stu_nameTextBox.Name = "Stu_nameTextBox"
        Me.Stu_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Stu_nameTextBox.TabIndex = 7
        '
        'Lec_NameLabel
        '
        Lec_NameLabel.AutoSize = True
        Lec_NameLabel.Location = New System.Drawing.Point(38, 148)
        Lec_NameLabel.Name = "Lec_NameLabel"
        Lec_NameLabel.Size = New System.Drawing.Size(59, 13)
        Lec_NameLabel.TabIndex = 8
        Lec_NameLabel.Text = "Lec Name:"
        '
        'Lec_NameTextBox
        '
        Me.Lec_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Lec_Name", True))
        Me.Lec_NameTextBox.Location = New System.Drawing.Point(103, 145)
        Me.Lec_NameTextBox.Name = "Lec_NameTextBox"
        Me.Lec_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Lec_NameTextBox.TabIndex = 9
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(38, 174)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 10
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(103, 171)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 11
        '
        'AppointmentDataGridView
        '
        Me.AppointmentDataGridView.AutoGenerateColumns = False
        Me.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AppointmentDataGridView.DataSource = Me.AppointmentBindingSource
        Me.AppointmentDataGridView.Location = New System.Drawing.Point(-1, 94)
        Me.AppointmentDataGridView.Name = "AppointmentDataGridView"
        Me.AppointmentDataGridView.Size = New System.Drawing.Size(646, 220)
        Me.AppointmentDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "App_Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "App_Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "App_Time"
        Me.DataGridViewTextBoxColumn3.HeaderText = "App_Time"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Stu_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Stu_name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Lec_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lec_Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Requests summary :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Manage Request"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(483, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(349, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(159, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Lecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(649, 406)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Lecturer"
        Me.Text = "Lecturer"
        CType(Me.ConsultDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConsultDataSet As consultDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As consultDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents TableAdapterManager As consultDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents AppointmentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents App_DateDateTimePicker As DateTimePicker
    Friend WithEvents App_TimeTextBox As TextBox
    Friend WithEvents Stu_nameTextBox As TextBox
    Friend WithEvents Lec_NameTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
