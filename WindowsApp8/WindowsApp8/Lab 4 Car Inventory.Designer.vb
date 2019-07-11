<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lvwCarList = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(82, 149)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(62, 24)
        Me.chkNew.TabIndex = 10
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.chkNew, "Click if the vehicles new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(58, 90)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(66, 13)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "&Year: "
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(58, 62)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(66, 13)
        Me.lblModel.TabIndex = 8
        Me.lblModel.Text = "M&odel: "
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblModel.UseWaitCursor = True
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(58, 38)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(66, 13)
        Me.lblMake.TabIndex = 7
        Me.lblMake.Text = "&Make: "
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblMake, "Makes label")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(58, 126)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(66, 13)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.Text = "&Price: "
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(130, 123)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtPrice, "Choose a price for the car")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(130, 61)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtModel, "Choose the cars model ")
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006"})
        Me.cmbYear.Location = New System.Drawing.Point(130, 90)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.cmbYear, "Choose the year of the car")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Honda", "Ford", "Toyota", "Audi"})
        Me.cmbMake.Location = New System.Drawing.Point(130, 34)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.cmbMake, "Choose the cars make")
        '
        'lvwCarList
        '
        Me.lvwCarList.CheckBoxes = True
        Me.lvwCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colPrice, Me.colYear, Me.colModel, Me.colMake})
        Me.lvwCarList.FullRowSelect = True
        Me.lvwCarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarList.Location = New System.Drawing.Point(82, 179)
        Me.lvwCarList.MultiSelect = False
        Me.lvwCarList.Name = "lvwCarList"
        Me.lvwCarList.Size = New System.Drawing.Size(374, 210)
        Me.lvwCarList.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.lvwCarList, "Listing of vehicles ")
        Me.lvwCarList.UseCompatibleStateImageBehavior = False
        Me.lvwCarList.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 62
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(348, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(267, 415)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 20
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(186, 415)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 19
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(504, 179)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(153, 194)
        Me.lbResult.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.lbResult, "Results to show it worked")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lvwCarList)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lvwCarList As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbResult As Label
End Class
