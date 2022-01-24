﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_purchaseorder_view_ordered_items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_purchaseorder_view_ordered_items))
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.btn_active_orders = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_unfulfilled_orders = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_po = New DevExpress.XtraGrid.GridControl()
        Me.grid_po_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_received_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_poid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_win_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sup_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty_to_receive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.col_date_sent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.btn_active_orders)
        Me.GunaPanel4.Controls.Add(Me.btn_unfulfilled_orders)
        Me.GunaPanel4.Controls.Add(Me.btn_export)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1325, 89)
        Me.GunaPanel4.TabIndex = 9
        '
        'btn_active_orders
        '
        Me.btn_active_orders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_active_orders.ImageOptions.Image = CType(resources.GetObject("btn_active_orders.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_active_orders.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btn_active_orders.Location = New System.Drawing.Point(971, 12)
        Me.btn_active_orders.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_active_orders.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_active_orders.Name = "btn_active_orders"
        Me.btn_active_orders.Size = New System.Drawing.Size(110, 63)
        Me.btn_active_orders.TabIndex = 4
        Me.btn_active_orders.Text = "Active Orders"
        '
        'btn_unfulfilled_orders
        '
        Me.btn_unfulfilled_orders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_unfulfilled_orders.ImageOptions.Image = CType(resources.GetObject("btn_unfulfilled_orders.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_unfulfilled_orders.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btn_unfulfilled_orders.Location = New System.Drawing.Point(1087, 12)
        Me.btn_unfulfilled_orders.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_unfulfilled_orders.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_unfulfilled_orders.Name = "btn_unfulfilled_orders"
        Me.btn_unfulfilled_orders.Size = New System.Drawing.Size(110, 63)
        Me.btn_unfulfilled_orders.TabIndex = 3
        Me.btn_unfulfilled_orders.Text = "Unfulfilled Orders"
        '
        'btn_export
        '
        Me.btn_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_export.ImageOptions.Image = CType(resources.GetObject("btn_export.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_export.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btn_export.Location = New System.Drawing.Point(1203, 12)
        Me.btn_export.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_export.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(110, 63)
        Me.btn_export.TabIndex = 2
        Me.btn_export.Text = "Export to CSV"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 24)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(220, 37)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Ordered Items"
        '
        'grid_po
        '
        Me.grid_po.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_po.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_po.Location = New System.Drawing.Point(0, 89)
        Me.grid_po.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_po.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_po.MainView = Me.grid_po_view
        Me.grid_po.Name = "grid_po"
        Me.grid_po.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemDateEdit1})
        Me.grid_po.Size = New System.Drawing.Size(1325, 694)
        Me.grid_po.TabIndex = 10
        Me.grid_po.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_po_view})
        '
        'grid_po_view
        '
        Me.grid_po_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_po_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_po_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_po_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_po_view.Appearance.Row.Options.UseFont = True
        Me.grid_po_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_po_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_po_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_po_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_po_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_received_qty, Me.col_poid, Me.col_win_model, Me.col_sup_model, Me.col_description, Me.col_qty, Me.col_po_status, Me.col_supplier, Me.col_qty_to_receive, Me.col_date_sent})
        Me.grid_po_view.GridControl = Me.grid_po
        Me.grid_po_view.Name = "grid_po_view"
        Me.grid_po_view.OptionsBehavior.Editable = False
        Me.grid_po_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_received_qty
        '
        Me.col_received_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_received_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_received_qty.Caption = "Received QTY"
        Me.col_received_qty.FieldName = "qty_received"
        Me.col_received_qty.Name = "col_received_qty"
        Me.col_received_qty.Visible = True
        Me.col_received_qty.VisibleIndex = 1
        Me.col_received_qty.Width = 92
        '
        'col_poid
        '
        Me.col_poid.AppearanceCell.Options.UseTextOptions = True
        Me.col_poid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_poid.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_poid.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_poid.AppearanceHeader.Options.UseFont = True
        Me.col_poid.AppearanceHeader.Options.UseForeColor = True
        Me.col_poid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_poid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_poid.Caption = "Purchase ID"
        Me.col_poid.FieldName = "poid"
        Me.col_poid.MaxWidth = 100
        Me.col_poid.MinWidth = 50
        Me.col_poid.Name = "col_poid"
        Me.col_poid.Visible = True
        Me.col_poid.VisibleIndex = 6
        Me.col_poid.Width = 96
        '
        'col_win_model
        '
        Me.col_win_model.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_win_model.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_win_model.AppearanceHeader.Options.UseFont = True
        Me.col_win_model.AppearanceHeader.Options.UseForeColor = True
        Me.col_win_model.AppearanceHeader.Options.UseTextOptions = True
        Me.col_win_model.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_win_model.Caption = "Win. Model"
        Me.col_win_model.FieldName = "winmodel"
        Me.col_win_model.MaxWidth = 300
        Me.col_win_model.MinWidth = 50
        Me.col_win_model.Name = "col_win_model"
        Me.col_win_model.Visible = True
        Me.col_win_model.VisibleIndex = 3
        Me.col_win_model.Width = 117
        '
        'col_sup_model
        '
        Me.col_sup_model.Caption = "Sup. Model"
        Me.col_sup_model.FieldName = "supmodel"
        Me.col_sup_model.Name = "col_sup_model"
        Me.col_sup_model.Visible = True
        Me.col_sup_model.VisibleIndex = 4
        Me.col_sup_model.Width = 129
        '
        'col_description
        '
        Me.col_description.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_description.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_description.AppearanceHeader.Options.UseFont = True
        Me.col_description.AppearanceHeader.Options.UseForeColor = True
        Me.col_description.AppearanceHeader.Options.UseTextOptions = True
        Me.col_description.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 5
        Me.col_description.Width = 316
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_qty.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_qty.AppearanceHeader.Options.UseFont = True
        Me.col_qty.AppearanceHeader.Options.UseForeColor = True
        Me.col_qty.AppearanceHeader.Options.UseTextOptions = True
        Me.col_qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Order QTY"
        Me.col_qty.DisplayFormat.FormatString = "n2"
        Me.col_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_qty.FieldName = "qty"
        Me.col_qty.MaxWidth = 100
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 0
        Me.col_qty.Width = 81
        '
        'col_po_status
        '
        Me.col_po_status.Caption = "Status"
        Me.col_po_status.FieldName = "po_status"
        Me.col_po_status.Name = "col_po_status"
        Me.col_po_status.Visible = True
        Me.col_po_status.VisibleIndex = 7
        Me.col_po_status.Width = 95
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 8
        Me.col_supplier.Width = 207
        '
        'col_qty_to_receive
        '
        Me.col_qty_to_receive.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty_to_receive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty_to_receive.Caption = "To Receive"
        Me.col_qty_to_receive.FieldName = "qty_to_receive"
        Me.col_qty_to_receive.Name = "col_qty_to_receive"
        Me.col_qty_to_receive.Visible = True
        Me.col_qty_to_receive.VisibleIndex = 2
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'col_date_sent
        '
        Me.col_date_sent.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_sent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_sent.Caption = "Date Sent"
        Me.col_date_sent.FieldName = "date_sent"
        Me.col_date_sent.MaxWidth = 120
        Me.col_date_sent.MinWidth = 120
        Me.col_date_sent.Name = "col_date_sent"
        Me.col_date_sent.Visible = True
        Me.col_date_sent.VisibleIndex = 9
        Me.col_date_sent.Width = 120
        '
        'frm_purchaseorder_view_ordered_items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1325, 783)
        Me.Controls.Add(Me.grid_po)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_purchaseorder_view_ordered_items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordered Items"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_po As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_po_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_poid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_win_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents col_po_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sup_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_qty_to_receive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_unfulfilled_orders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_active_orders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_date_sent As DevExpress.XtraGrid.Columns.GridColumn
End Class
