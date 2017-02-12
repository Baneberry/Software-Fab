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
        Dim BussIDLabel As System.Windows.Forms.Label
        Dim MakeLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim SeatsLabel As System.Windows.Forms.Label
        Dim ServicedateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBuses = New System.Windows.Forms.Button()
        Me.btnDrivers = New System.Windows.Forms.Button()
        Me.btnRoutes = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lstListBox = New System.Windows.Forms.ListBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnAddDriver = New System.Windows.Forms.Button()
        Me.btnDeleteDriver = New System.Windows.Forms.Button()
        Me.btnAddBus = New System.Windows.Forms.Button()
        Me.btnDeleteBus = New System.Windows.Forms.Button()
        Me.btnAddRoute = New System.Windows.Forms.Button()
        Me.btnDeleteRoute = New System.Windows.Forms.Button()
        Me.Database11DataSet = New WindowsApplication1.Database11DataSet()
        Me.BussesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BussesTableAdapter = New WindowsApplication1.Database11DataSetTableAdapters.BussesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database11DataSetTableAdapters.TableAdapterManager()
        Me.BussesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BussesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BussIDTextBox = New System.Windows.Forms.TextBox()
        Me.MakeTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.SeatsTextBox = New System.Windows.Forms.TextBox()
        Me.ServicedateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.bussIDAddlbl = New System.Windows.Forms.Label()
        Me.makeAddlbl = New System.Windows.Forms.Label()
        Me.seatsAddlbl = New System.Windows.Forms.Label()
        Me.modelAddlbl = New System.Windows.Forms.Label()
        Me.serviceDateAddlbl = New System.Windows.Forms.Label()
        Me.bussAddgbx = New System.Windows.Forms.GroupBox()
        Me.seatsAddcmb = New System.Windows.Forms.ComboBox()
        Me.tbxBusIDAdd = New System.Windows.Forms.TextBox()
        Me.dateServiceAdd = New System.Windows.Forms.DateTimePicker()
        Me.tbxModelAdd = New System.Windows.Forms.TextBox()
        Me.tbxMakeAdd = New System.Windows.Forms.TextBox()
        Me.btnConfirmBussAdd = New System.Windows.Forms.Button()
        BussIDLabel = New System.Windows.Forms.Label()
        MakeLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        SeatsLabel = New System.Windows.Forms.Label()
        ServicedateLabel = New System.Windows.Forms.Label()
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BussesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BussesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BussesBindingNavigator.SuspendLayout()
        Me.bussAddgbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'BussIDLabel
        '
        BussIDLabel.AutoSize = True
        BussIDLabel.Location = New System.Drawing.Point(663, 239)
        BussIDLabel.Name = "BussIDLabel"
        BussIDLabel.Size = New System.Drawing.Size(46, 13)
        BussIDLabel.TabIndex = 15
        BussIDLabel.Text = "buss ID:"
        '
        'MakeLabel
        '
        MakeLabel.AutoSize = True
        MakeLabel.Location = New System.Drawing.Point(663, 265)
        MakeLabel.Name = "MakeLabel"
        MakeLabel.Size = New System.Drawing.Size(36, 13)
        MakeLabel.TabIndex = 17
        MakeLabel.Text = "make:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(663, 291)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(38, 13)
        ModelLabel.TabIndex = 19
        ModelLabel.Text = "model:"
        '
        'SeatsLabel
        '
        SeatsLabel.AutoSize = True
        SeatsLabel.Location = New System.Drawing.Point(663, 317)
        SeatsLabel.Name = "SeatsLabel"
        SeatsLabel.Size = New System.Drawing.Size(35, 13)
        SeatsLabel.TabIndex = 21
        SeatsLabel.Text = "seats:"
        '
        'ServicedateLabel
        '
        ServicedateLabel.AutoSize = True
        ServicedateLabel.Location = New System.Drawing.Point(663, 344)
        ServicedateLabel.Name = "ServicedateLabel"
        ServicedateLabel.Size = New System.Drawing.Size(65, 13)
        ServicedateLabel.TabIndex = 23
        ServicedateLabel.Text = "servicedate:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(161, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(443, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Welcome to Dr. N and Sons Bus Rentals"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuses
        '
        Me.btnBuses.Location = New System.Drawing.Point(146, 387)
        Me.btnBuses.Name = "btnBuses"
        Me.btnBuses.Size = New System.Drawing.Size(118, 66)
        Me.btnBuses.TabIndex = 1
        Me.btnBuses.Text = "Buses"
        Me.btnBuses.UseVisualStyleBackColor = True
        '
        'btnDrivers
        '
        Me.btnDrivers.Location = New System.Drawing.Point(282, 387)
        Me.btnDrivers.Name = "btnDrivers"
        Me.btnDrivers.Size = New System.Drawing.Size(105, 66)
        Me.btnDrivers.TabIndex = 2
        Me.btnDrivers.Text = "Drivers"
        Me.btnDrivers.UseVisualStyleBackColor = True
        '
        'btnRoutes
        '
        Me.btnRoutes.Location = New System.Drawing.Point(407, 387)
        Me.btnRoutes.Name = "btnRoutes"
        Me.btnRoutes.Size = New System.Drawing.Size(118, 66)
        Me.btnRoutes.TabIndex = 3
        Me.btnRoutes.Text = "Routes"
        Me.btnRoutes.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(542, 415)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(106, 38)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(31, 415)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(100, 38)
        Me.btnHome.TabIndex = 5
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        Me.btnHome.Visible = False
        '
        'lstListBox
        '
        Me.lstListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lstListBox.FormattingEnabled = True
        Me.lstListBox.ItemHeight = 24
        Me.lstListBox.Location = New System.Drawing.Point(31, 63)
        Me.lstListBox.Name = "lstListBox"
        Me.lstListBox.Size = New System.Drawing.Size(617, 292)
        Me.lstListBox.TabIndex = 6
        Me.lstListBox.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(191, 47)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(52, 13)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = "Move Me"
        '
        'btnAddDriver
        '
        Me.btnAddDriver.Location = New System.Drawing.Point(654, 63)
        Me.btnAddDriver.Name = "btnAddDriver"
        Me.btnAddDriver.Size = New System.Drawing.Size(93, 30)
        Me.btnAddDriver.TabIndex = 8
        Me.btnAddDriver.Text = "Add New"
        Me.btnAddDriver.UseVisualStyleBackColor = True
        Me.btnAddDriver.Visible = False
        '
        'btnDeleteDriver
        '
        Me.btnDeleteDriver.Location = New System.Drawing.Point(654, 99)
        Me.btnDeleteDriver.Name = "btnDeleteDriver"
        Me.btnDeleteDriver.Size = New System.Drawing.Size(93, 30)
        Me.btnDeleteDriver.TabIndex = 9
        Me.btnDeleteDriver.Text = "Remove"
        Me.btnDeleteDriver.UseVisualStyleBackColor = True
        Me.btnDeleteDriver.Visible = False
        '
        'btnAddBus
        '
        Me.btnAddBus.Location = New System.Drawing.Point(654, 63)
        Me.btnAddBus.Name = "btnAddBus"
        Me.btnAddBus.Size = New System.Drawing.Size(93, 30)
        Me.btnAddBus.TabIndex = 10
        Me.btnAddBus.Text = "Add New"
        Me.btnAddBus.UseVisualStyleBackColor = True
        Me.btnAddBus.Visible = False
        '
        'btnDeleteBus
        '
        Me.btnDeleteBus.Location = New System.Drawing.Point(654, 27)
        Me.btnDeleteBus.Name = "btnDeleteBus"
        Me.btnDeleteBus.Size = New System.Drawing.Size(93, 30)
        Me.btnDeleteBus.TabIndex = 11
        Me.btnDeleteBus.Text = "Remove"
        Me.btnDeleteBus.UseVisualStyleBackColor = True
        Me.btnDeleteBus.Visible = False
        '
        'btnAddRoute
        '
        Me.btnAddRoute.Location = New System.Drawing.Point(654, 63)
        Me.btnAddRoute.Name = "btnAddRoute"
        Me.btnAddRoute.Size = New System.Drawing.Size(93, 30)
        Me.btnAddRoute.TabIndex = 12
        Me.btnAddRoute.Text = "Add New"
        Me.btnAddRoute.UseVisualStyleBackColor = True
        Me.btnAddRoute.Visible = False
        '
        'btnDeleteRoute
        '
        Me.btnDeleteRoute.Location = New System.Drawing.Point(654, 98)
        Me.btnDeleteRoute.Name = "btnDeleteRoute"
        Me.btnDeleteRoute.Size = New System.Drawing.Size(93, 30)
        Me.btnDeleteRoute.TabIndex = 13
        Me.btnDeleteRoute.Text = "Remove"
        Me.btnDeleteRoute.UseVisualStyleBackColor = True
        Me.btnDeleteRoute.Visible = False
        '
        'Database11DataSet
        '
        Me.Database11DataSet.DataSetName = "Database11DataSet"
        Me.Database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BussesBindingSource
        '
        Me.BussesBindingSource.DataMember = "Busses"
        Me.BussesBindingSource.DataSource = Me.Database11DataSet
        '
        'BussesTableAdapter
        '
        Me.BussesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BussesTableAdapter = Me.BussesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BussesBindingNavigator
        '
        Me.BussesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BussesBindingNavigator.BindingSource = Me.BussesBindingSource
        Me.BussesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BussesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BussesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BussesBindingNavigatorSaveItem})
        Me.BussesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BussesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BussesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BussesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BussesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BussesBindingNavigator.Name = "BussesBindingNavigator"
        Me.BussesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BussesBindingNavigator.Size = New System.Drawing.Size(973, 25)
        Me.BussesBindingNavigator.TabIndex = 14
        Me.BussesBindingNavigator.Text = "BindingNavigator1"
        Me.BussesBindingNavigator.Visible = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BussesBindingNavigatorSaveItem
        '
        Me.BussesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BussesBindingNavigatorSaveItem.Image = CType(resources.GetObject("BussesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BussesBindingNavigatorSaveItem.Name = "BussesBindingNavigatorSaveItem"
        Me.BussesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BussesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BussIDTextBox
        '
        Me.BussIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BussesBindingSource, "bussID", True))
        Me.BussIDTextBox.Location = New System.Drawing.Point(734, 236)
        Me.BussIDTextBox.Name = "BussIDTextBox"
        Me.BussIDTextBox.Size = New System.Drawing.Size(82, 20)
        Me.BussIDTextBox.TabIndex = 16
        '
        'MakeTextBox
        '
        Me.MakeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BussesBindingSource, "make", True))
        Me.MakeTextBox.Location = New System.Drawing.Point(734, 262)
        Me.MakeTextBox.Name = "MakeTextBox"
        Me.MakeTextBox.Size = New System.Drawing.Size(82, 20)
        Me.MakeTextBox.TabIndex = 18
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BussesBindingSource, "model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(734, 288)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(82, 20)
        Me.ModelTextBox.TabIndex = 20
        '
        'SeatsTextBox
        '
        Me.SeatsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BussesBindingSource, "seats", True))
        Me.SeatsTextBox.Location = New System.Drawing.Point(734, 314)
        Me.SeatsTextBox.Name = "SeatsTextBox"
        Me.SeatsTextBox.Size = New System.Drawing.Size(82, 20)
        Me.SeatsTextBox.TabIndex = 22
        '
        'ServicedateDateTimePicker
        '
        Me.ServicedateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BussesBindingSource, "servicedate", True))
        Me.ServicedateDateTimePicker.Location = New System.Drawing.Point(734, 340)
        Me.ServicedateDateTimePicker.MinDate = New Date(2017, 2, 10, 0, 0, 0, 0)
        Me.ServicedateDateTimePicker.Name = "ServicedateDateTimePicker"
        Me.ServicedateDateTimePicker.Size = New System.Drawing.Size(82, 20)
        Me.ServicedateDateTimePicker.TabIndex = 24
        '
        'bussIDAddlbl
        '
        Me.bussIDAddlbl.AutoSize = True
        Me.bussIDAddlbl.Location = New System.Drawing.Point(6, 16)
        Me.bussIDAddlbl.Name = "bussIDAddlbl"
        Me.bussIDAddlbl.Size = New System.Drawing.Size(41, 13)
        Me.bussIDAddlbl.TabIndex = 35
        Me.bussIDAddlbl.Text = "BussID"
        '
        'makeAddlbl
        '
        Me.makeAddlbl.AutoSize = True
        Me.makeAddlbl.Location = New System.Drawing.Point(6, 43)
        Me.makeAddlbl.Name = "makeAddlbl"
        Me.makeAddlbl.Size = New System.Drawing.Size(34, 13)
        Me.makeAddlbl.TabIndex = 36
        Me.makeAddlbl.Text = "Make"
        '
        'seatsAddlbl
        '
        Me.seatsAddlbl.AutoSize = True
        Me.seatsAddlbl.Location = New System.Drawing.Point(6, 96)
        Me.seatsAddlbl.Name = "seatsAddlbl"
        Me.seatsAddlbl.Size = New System.Drawing.Size(34, 13)
        Me.seatsAddlbl.TabIndex = 38
        Me.seatsAddlbl.Text = "Seats"
        '
        'modelAddlbl
        '
        Me.modelAddlbl.AutoSize = True
        Me.modelAddlbl.Location = New System.Drawing.Point(6, 69)
        Me.modelAddlbl.Name = "modelAddlbl"
        Me.modelAddlbl.Size = New System.Drawing.Size(36, 13)
        Me.modelAddlbl.TabIndex = 37
        Me.modelAddlbl.Text = "Model"
        '
        'serviceDateAddlbl
        '
        Me.serviceDateAddlbl.AutoSize = True
        Me.serviceDateAddlbl.Location = New System.Drawing.Point(6, 121)
        Me.serviceDateAddlbl.Name = "serviceDateAddlbl"
        Me.serviceDateAddlbl.Size = New System.Drawing.Size(69, 13)
        Me.serviceDateAddlbl.TabIndex = 39
        Me.serviceDateAddlbl.Text = "Service Date"
        '
        'bussAddgbx
        '
        Me.bussAddgbx.Controls.Add(Me.seatsAddcmb)
        Me.bussAddgbx.Controls.Add(Me.tbxBusIDAdd)
        Me.bussAddgbx.Controls.Add(Me.dateServiceAdd)
        Me.bussAddgbx.Controls.Add(Me.serviceDateAddlbl)
        Me.bussAddgbx.Controls.Add(Me.bussIDAddlbl)
        Me.bussAddgbx.Controls.Add(Me.seatsAddlbl)
        Me.bussAddgbx.Controls.Add(Me.tbxModelAdd)
        Me.bussAddgbx.Controls.Add(Me.modelAddlbl)
        Me.bussAddgbx.Controls.Add(Me.tbxMakeAdd)
        Me.bussAddgbx.Controls.Add(Me.makeAddlbl)
        Me.bussAddgbx.Location = New System.Drawing.Point(783, 56)
        Me.bussAddgbx.Name = "bussAddgbx"
        Me.bussAddgbx.Size = New System.Drawing.Size(174, 142)
        Me.bussAddgbx.TabIndex = 40
        Me.bussAddgbx.TabStop = False
        Me.bussAddgbx.Visible = False
        '
        'seatsAddcmb
        '
        Me.seatsAddcmb.FormattingEnabled = True
        Me.seatsAddcmb.Location = New System.Drawing.Point(78, 90)
        Me.seatsAddcmb.Name = "seatsAddcmb"
        Me.seatsAddcmb.Size = New System.Drawing.Size(82, 21)
        Me.seatsAddcmb.TabIndex = 48
        '
        'tbxBusIDAdd
        '
        Me.tbxBusIDAdd.Location = New System.Drawing.Point(78, 13)
        Me.tbxBusIDAdd.Name = "tbxBusIDAdd"
        Me.tbxBusIDAdd.Size = New System.Drawing.Size(82, 20)
        Me.tbxBusIDAdd.TabIndex = 47
        '
        'dateServiceAdd
        '
        Me.dateServiceAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateServiceAdd.Location = New System.Drawing.Point(78, 117)
        Me.dateServiceAdd.Name = "dateServiceAdd"
        Me.dateServiceAdd.Size = New System.Drawing.Size(82, 20)
        Me.dateServiceAdd.TabIndex = 46
        '
        'tbxModelAdd
        '
        Me.tbxModelAdd.Location = New System.Drawing.Point(78, 68)
        Me.tbxModelAdd.Name = "tbxModelAdd"
        Me.tbxModelAdd.Size = New System.Drawing.Size(82, 20)
        Me.tbxModelAdd.TabIndex = 43
        '
        'tbxMakeAdd
        '
        Me.tbxMakeAdd.Location = New System.Drawing.Point(78, 42)
        Me.tbxMakeAdd.Name = "tbxMakeAdd"
        Me.tbxMakeAdd.Size = New System.Drawing.Size(82, 20)
        Me.tbxMakeAdd.TabIndex = 42
        '
        'btnConfirmBussAdd
        '
        Me.btnConfirmBussAdd.Location = New System.Drawing.Point(654, 135)
        Me.btnConfirmBussAdd.Name = "btnConfirmBussAdd"
        Me.btnConfirmBussAdd.Size = New System.Drawing.Size(93, 30)
        Me.btnConfirmBussAdd.TabIndex = 41
        Me.btnConfirmBussAdd.Text = "Comfirm"
        Me.btnConfirmBussAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 477)
        Me.Controls.Add(Me.btnConfirmBussAdd)
        Me.Controls.Add(Me.bussAddgbx)
        Me.Controls.Add(BussIDLabel)
        Me.Controls.Add(Me.BussIDTextBox)
        Me.Controls.Add(MakeLabel)
        Me.Controls.Add(Me.MakeTextBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(SeatsLabel)
        Me.Controls.Add(Me.SeatsTextBox)
        Me.Controls.Add(ServicedateLabel)
        Me.Controls.Add(Me.ServicedateDateTimePicker)
        Me.Controls.Add(Me.BussesBindingNavigator)
        Me.Controls.Add(Me.btnDeleteRoute)
        Me.Controls.Add(Me.btnAddRoute)
        Me.Controls.Add(Me.btnDeleteBus)
        Me.Controls.Add(Me.btnAddBus)
        Me.Controls.Add(Me.btnDeleteDriver)
        Me.Controls.Add(Me.btnAddDriver)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lstListBox)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRoutes)
        Me.Controls.Add(Me.btnDrivers)
        Me.Controls.Add(Me.btnBuses)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BussesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BussesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BussesBindingNavigator.ResumeLayout(False)
        Me.BussesBindingNavigator.PerformLayout()
        Me.bussAddgbx.ResumeLayout(False)
        Me.bussAddgbx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBuses As Button
    Friend WithEvents btnDrivers As Button
    Friend WithEvents btnRoutes As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lstListBox As ListBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnAddDriver As Button
    Friend WithEvents btnDeleteDriver As Button
    Friend WithEvents btnAddBus As Button
    Friend WithEvents btnDeleteBus As Button
    Friend WithEvents btnAddRoute As Button
    Friend WithEvents btnDeleteRoute As Button
    Friend WithEvents Database11DataSet As Database11DataSet
    Friend WithEvents BussesBindingSource As BindingSource
    Friend WithEvents BussesTableAdapter As Database11DataSetTableAdapters.BussesTableAdapter
    Friend WithEvents TableAdapterManager As Database11DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BussesBindingNavigator As BindingNavigator
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
    Friend WithEvents BussesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BussIDTextBox As TextBox
    Friend WithEvents MakeTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents SeatsTextBox As TextBox
    Friend WithEvents ServicedateDateTimePicker As DateTimePicker
    Friend WithEvents bussIDAddlbl As Label
    Friend WithEvents makeAddlbl As Label
    Friend WithEvents seatsAddlbl As Label
    Friend WithEvents modelAddlbl As Label
    Friend WithEvents serviceDateAddlbl As Label
    Friend WithEvents bussAddgbx As GroupBox
    Friend WithEvents tbxMakeAdd As TextBox
    Friend WithEvents tbxModelAdd As TextBox
    Friend WithEvents dateServiceAdd As DateTimePicker
    Friend WithEvents tbxBusIDAdd As TextBox
    Friend WithEvents seatsAddcmb As ComboBox
    Friend WithEvents btnConfirmBussAdd As Button
End Class
