<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_unserved_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_unserved_dialog))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_unserved = New DevExpress.XtraGrid.GridControl()
        Me.grid_unserved_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_entry_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unserved_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_remarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.grid_unserved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_unserved_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(905, 64)
        Me.GunaPanel2.TabIndex = 13
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(205, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Unserved Items"
        '
        'grid_unserved
        '
        Me.grid_unserved.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_unserved.Location = New System.Drawing.Point(12, 85)
        Me.grid_unserved.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_unserved.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_unserved.MainView = Me.grid_unserved_view
        Me.grid_unserved.Name = "grid_unserved"
        Me.grid_unserved.Size = New System.Drawing.Size(881, 479)
        Me.grid_unserved.TabIndex = 14
        Me.grid_unserved.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_unserved_view})
        '
        'grid_unserved_view
        '
        Me.grid_unserved_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_unserved_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_unserved_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_unserved_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_unserved_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_unserved_view.Appearance.Row.Options.UseFont = True
        Me.grid_unserved_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_entry_date, Me.col_unserved_qty, Me.col_model, Me.col_description, Me.col_remarks})
        Me.grid_unserved_view.GridControl = Me.grid_unserved
        Me.grid_unserved_view.Name = "grid_unserved_view"
        Me.grid_unserved_view.OptionsBehavior.Editable = False
        '
        'col_entry_date
        '
        Me.col_entry_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_entry_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_entry_date.Caption = "Entry Date"
        Me.col_entry_date.DisplayFormat.FormatString = "d"
        Me.col_entry_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_entry_date.FieldName = "created_at"
        Me.col_entry_date.MaxWidth = 120
        Me.col_entry_date.Name = "col_entry_date"
        Me.col_entry_date.Visible = True
        Me.col_entry_date.VisibleIndex = 0
        '
        'col_unserved_qty
        '
        Me.col_unserved_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_unserved_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_unserved_qty.Caption = "Unserved Qty"
        Me.col_unserved_qty.FieldName = "qty"
        Me.col_unserved_qty.MaxWidth = 100
        Me.col_unserved_qty.Name = "col_unserved_qty"
        Me.col_unserved_qty.Visible = True
        Me.col_unserved_qty.VisibleIndex = 1
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.MaxWidth = 150
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 2
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 3
        '
        'col_remarks
        '
        Me.col_remarks.AppearanceCell.Options.UseTextOptions = True
        Me.col_remarks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_remarks.Caption = "Remarks"
        Me.col_remarks.FieldName = "item_status"
        Me.col_remarks.MaxWidth = 100
        Me.col_remarks.Name = "col_remarks"
        Me.col_remarks.Visible = True
        Me.col_remarks.VisibleIndex = 4
        '
        'frm_sales_unserved_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 576)
        Me.Controls.Add(Me.grid_unserved)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_unserved_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unserved Items"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.grid_unserved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_unserved_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_unserved As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_unserved_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_entry_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_unserved_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_remarks As DevExpress.XtraGrid.Columns.GridColumn
End Class
