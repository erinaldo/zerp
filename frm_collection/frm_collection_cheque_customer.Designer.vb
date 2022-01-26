<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_cheque_customer
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
        Me.grid_customer = New DevExpress.XtraGrid.GridControl()
        Me.grid_customer_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_select = New System.Windows.Forms.Button()
        CType(Me.grid_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_customer_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_customer
        '
        Me.grid_customer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_customer.Location = New System.Drawing.Point(0, 0)
        Me.grid_customer.MainView = Me.grid_customer_view
        Me.grid_customer.Name = "grid_customer"
        Me.grid_customer.Size = New System.Drawing.Size(511, 345)
        Me.grid_customer.TabIndex = 0
        Me.grid_customer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_customer_view})
        '
        'grid_customer_view
        '
        Me.grid_customer_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_name})
        Me.grid_customer_view.GridControl = Me.grid_customer
        Me.grid_customer_view.Name = "grid_customer_view"
        Me.grid_customer_view.OptionsBehavior.Editable = False
        Me.grid_customer_view.OptionsBehavior.ReadOnly = True
        Me.grid_customer_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_customer_view.OptionsView.ShowIndicator = False
        Me.grid_customer_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_customer_view.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'col_id
        '
        Me.col_id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_id.AppearanceHeader.Options.UseFont = True
        Me.col_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "customer_id"
        Me.col_id.MaxWidth = 50
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 20
        '
        'col_name
        '
        Me.col_name.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_name.AppearanceHeader.Options.UseFont = True
        Me.col_name.AppearanceHeader.Options.UseTextOptions = True
        Me.col_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_name.Caption = "Name"
        Me.col_name.FieldName = "customer"
        Me.col_name.Name = "col_name"
        Me.col_name.Visible = True
        Me.col_name.VisibleIndex = 1
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.Location = New System.Drawing.Point(406, 351)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(93, 25)
        Me.btn_select.TabIndex = 1
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'frm_collection_cheque_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 387)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.grid_customer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_collection_cheque_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer List"
        CType(Me.grid_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_customer_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_customer As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_customer_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_select As Button
End Class
