<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Request
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim App_DateLabel As System.Windows.Forms.Label
        Dim Stu_nameLabel As System.Windows.Forms.Label
        Dim Lec_NameLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim App_TimeLabel1 As System.Windows.Forms.Label
        Me.ConsultDataSet = New WindowsApplication1.consultDataSet()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentTableAdapter = New WindowsApplication1.consultDataSetTableAdapters.AppointmentTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.consultDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.App_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Stu_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Lec_NameTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.App_TimeComboBox = New System.Windows.Forms.ComboBox()
        Me.AppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        App_DateLabel = New System.Windows.Forms.Label()
        Stu_nameLabel = New System.Windows.Forms.Label()
        Lec_NameLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        App_TimeLabel1 = New System.Windows.Forms.Label()
        CType(Me.ConsultDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(23, 73)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'App_DateLabel
        '
        App_DateLabel.AutoSize = True
        App_DateLabel.Location = New System.Drawing.Point(23, 100)
        App_DateLabel.Name = "App_DateLabel"
        App_DateLabel.Size = New System.Drawing.Size(33, 13)
        App_DateLabel.TabIndex = 3
        App_DateLabel.Text = "Date:"
        '
        'Stu_nameLabel
        '
        Stu_nameLabel.AutoSize = True
        Stu_nameLabel.Location = New System.Drawing.Point(23, 151)
        Stu_nameLabel.Name = "Stu_nameLabel"
        Stu_nameLabel.Size = New System.Drawing.Size(76, 13)
        Stu_nameLabel.TabIndex = 7
        Stu_nameLabel.Text = "Student name:"
        '
        'Lec_NameLabel
        '
        Lec_NameLabel.AutoSize = True
        Lec_NameLabel.Location = New System.Drawing.Point(23, 177)
        Lec_NameLabel.Name = "Lec_NameLabel"
        Lec_NameLabel.Size = New System.Drawing.Size(80, 13)
        Lec_NameLabel.TabIndex = 9
        Lec_NameLabel.Text = "Lecturer Name:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(23, 203)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 11
        StatusLabel.Text = "Status:"
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(105, 70)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'App_DateDateTimePicker
        '
        Me.App_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AppointmentBindingSource, "App_Date", True))
        Me.App_DateDateTimePicker.Location = New System.Drawing.Point(105, 96)
        Me.App_DateDateTimePicker.Name = "App_DateDateTimePicker"
        Me.App_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.App_DateDateTimePicker.TabIndex = 4
        '
        'Stu_nameTextBox
        '
        Me.Stu_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Stu_name", True))
        Me.Stu_nameTextBox.Location = New System.Drawing.Point(105, 148)
        Me.Stu_nameTextBox.Name = "Stu_nameTextBox"
        Me.Stu_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Stu_nameTextBox.TabIndex = 8
        '
        'Lec_NameTextBox
        '
        Me.Lec_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Lec_Name", True))
        Me.Lec_NameTextBox.Location = New System.Drawing.Point(105, 174)
        Me.Lec_NameTextBox.Name = "Lec_NameTextBox"
        Me.Lec_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Lec_NameTextBox.TabIndex = 10
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(105, 200)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Create Appointment Request :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(567, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(567, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Log out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(460, 73)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'App_TimeLabel1
        '
        App_TimeLabel1.AutoSize = True
        App_TimeLabel1.Location = New System.Drawing.Point(23, 126)
        App_TimeLabel1.Name = "App_TimeLabel1"
        App_TimeLabel1.Size = New System.Drawing.Size(47, 13)
        App_TimeLabel1.TabIndex = 16
        App_TimeLabel1.Text = "Session:"
        '
        'App_TimeComboBox
        '
        Me.App_TimeComboBox.AllowDrop = True
        Me.App_TimeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "App_Time", True))
        Me.App_TimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.App_TimeComboBox.FormattingEnabled = True
        Me.App_TimeComboBox.Items.AddRange(New Object() {"10 am -11 am", "11 am - 12 am", "12 am -1 pm", "1 pm - 2 pm", "3 pm - 4 pm", "4 pm - 5 pm"})
        Me.App_TimeComboBox.Location = New System.Drawing.Point(105, 123)
        Me.App_TimeComboBox.Name = "App_TimeComboBox"
        Me.App_TimeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.App_TimeComboBox.TabIndex = 17
        '
        'AppointmentDataGridView
        '
        Me.AppointmentDataGridView.AutoGenerateColumns = False
        Me.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AppointmentDataGridView.DataSource = Me.AppointmentBindingSource
        Me.AppointmentDataGridView.Location = New System.Drawing.Point(1, 277)
        Me.AppointmentDataGridView.Name = "AppointmentDataGridView"
        Me.AppointmentDataGridView.Size = New System.Drawing.Size(641, 169)
        Me.AppointmentDataGridView.TabIndex = 17
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(460, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(642, 448)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.AppointmentDataGridView)
        Me.Controls.Add(App_TimeLabel1)
        Me.Controls.Add(Me.App_TimeComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(App_DateLabel)
        Me.Controls.Add(Me.App_DateDateTimePicker)
        Me.Controls.Add(Stu_nameLabel)
        Me.Controls.Add(Me.Stu_nameTextBox)
        Me.Controls.Add(Lec_NameLabel)
        Me.Controls.Add(Me.Lec_NameTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Name = "Request"
        Me.Text = "Request"
        CType(Me.ConsultDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConsultDataSet As consultDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As consultDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents TableAdapterManager As consultDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents App_DateDateTimePicker As DateTimePicker
    Friend WithEvents Stu_nameTextBox As TextBox
    Friend WithEvents Lec_NameTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents App_TimeComboBox As ComboBox
    Friend WithEvents AppointmentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
End Class
