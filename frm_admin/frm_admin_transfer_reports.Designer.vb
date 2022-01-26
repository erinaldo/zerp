<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_transfer_reports
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_transfer_reports))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_transfer_id = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_report = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_zero = New System.Windows.Forms.RadioButton()
        Me.rb_dest = New System.Windows.Forms.RadioButton()
        Me.rb_src = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_source = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_destination = New DevExpress.XtraEditors.TextEdit()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_apply = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_receiver = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriptiom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_missing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_transfer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_report.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_destination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_receiver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 64)
        Me.Panel1.TabIndex = 5
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(12, 16)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(281, 31)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Transfer Stock Report"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Transfer ID"
        '
        'txt_transfer_id
        '
        Me.txt_transfer_id.Enabled = False
        Me.txt_transfer_id.Location = New System.Drawing.Point(123, 93)
        Me.txt_transfer_id.Name = "txt_transfer_id"
        Me.txt_transfer_id.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_transfer_id.Properties.Appearance.Options.UseFont = True
        Me.txt_transfer_id.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_transfer_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_transfer_id.Size = New System.Drawing.Size(149, 22)
        Me.txt_transfer_id.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Incident Report"
        '
        'txt_report
        '
        Me.txt_report.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_report.Location = New System.Drawing.Point(123, 369)
        Me.txt_report.Name = "txt_report"
        Me.txt_report.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_report.Properties.Appearance.Options.UseFont = True
        Me.txt_report.Properties.ReadOnly = True
        Me.txt_report.Properties.UseReadOnlyAppearance = False
        Me.txt_report.Size = New System.Drawing.Size(653, 64)
        Me.txt_report.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rb_zero)
        Me.GroupBox1.Controls.Add(Me.rb_dest)
        Me.GroupBox1.Controls.Add(Me.rb_src)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 440)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 106)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action to Resolve"
        '
        'rb_zero
        '
        Me.rb_zero.AutoSize = True
        Me.rb_zero.Location = New System.Drawing.Point(24, 72)
        Me.rb_zero.Name = "rb_zero"
        Me.rb_zero.Size = New System.Drawing.Size(148, 19)
        Me.rb_zero.TabIndex = 2
        Me.rb_zero.TabStop = True
        Me.rb_zero.Text = "Remove from On-Hold"
        Me.rb_zero.UseVisualStyleBackColor = True
        '
        'rb_dest
        '
        Me.rb_dest.AutoSize = True
        Me.rb_dest.Location = New System.Drawing.Point(24, 49)
        Me.rb_dest.Name = "rb_dest"
        Me.rb_dest.Size = New System.Drawing.Size(93, 19)
        Me.rb_dest.TabIndex = 1
        Me.rb_dest.TabStop = True
        Me.rb_dest.Text = "Reconcile to"
        Me.rb_dest.UseVisualStyleBackColor = True
        '
        'rb_src
        '
        Me.rb_src.AutoSize = True
        Me.rb_src.Location = New System.Drawing.Point(24, 26)
        Me.rb_src.Name = "rb_src"
        Me.rb_src.Size = New System.Drawing.Size(122, 19)
        Me.rb_src.TabIndex = 0
        Me.rb_src.TabStop = True
        Me.rb_src.Text = "Reconcile back to"
        Me.rb_src.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Source Store"
        '
        'txt_source
        '
        Me.txt_source.Location = New System.Drawing.Point(123, 121)
        Me.txt_source.Name = "txt_source"
        Me.txt_source.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_source.Properties.Appearance.Options.UseFont = True
        Me.txt_source.Properties.ReadOnly = True
        Me.txt_source.Properties.UseReadOnlyAppearance = False
        Me.txt_source.Size = New System.Drawing.Size(239, 22)
        Me.txt_source.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(15, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Destination Store"
        '
        'txt_destination
        '
        Me.txt_destination.Location = New System.Drawing.Point(123, 149)
        Me.txt_destination.Name = "txt_destination"
        Me.txt_destination.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_destination.Properties.Appearance.Options.UseFont = True
        Me.txt_destination.Properties.ReadOnly = True
        Me.txt_destination.Properties.UseReadOnlyAppearance = False
        Me.txt_destination.Size = New System.Drawing.Size(239, 22)
        Me.txt_destination.TabIndex = 13
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Appearance.Options.UseTextOptions = True
        Me.btn_cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.ImageToTextIndent = 8
        Me.btn_cancel.Location = New System.Drawing.Point(510, 557)
        Me.btn_cancel.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(130, 41)
        Me.btn_cancel.TabIndex = 84
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_apply
        '
        Me.btn_apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_apply.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_apply.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_apply.Appearance.Options.UseBackColor = True
        Me.btn_apply.Appearance.Options.UseFont = True
        Me.btn_apply.Appearance.Options.UseTextOptions = True
        Me.btn_apply.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_apply.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_apply.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_apply.ImageOptions.ImageToTextIndent = 8
        Me.btn_apply.Location = New System.Drawing.Point(646, 557)
        Me.btn_apply.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_apply.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(130, 41)
        Me.btn_apply.TabIndex = 83
        Me.btn_apply.Text = "Apply"
        '
        'grid_receiver
        '
        Me.grid_receiver.AllowUserToAddRows = False
        Me.grid_receiver.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_receiver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_receiver.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_receiver.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_receiver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_receiver.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_receiver.ColumnHeadersHeight = 28
        Me.grid_receiver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_receiver.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.descriptiom, Me.DataGridViewTextBoxColumn2, Me.col_received, Me.col_missing})
        Me.grid_receiver.EnableHeadersVisualStyles = False
        Me.grid_receiver.Location = New System.Drawing.Point(18, 184)
        Me.grid_receiver.Margin = New System.Windows.Forms.Padding(0)
        Me.grid_receiver.MultiSelect = False
        Me.grid_receiver.Name = "grid_receiver"
        Me.grid_receiver.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Nunito", 9.749999!)
        Me.grid_receiver.Size = New System.Drawing.Size(758, 175)
        Me.grid_receiver.TabIndex = 85
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "PID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.FillWeight = 73.71088!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'descriptiom
        '
        Me.descriptiom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descriptiom.HeaderText = "Description"
        Me.descriptiom.Name = "descriptiom"
        Me.descriptiom.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "To Receive"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'col_received
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_received.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_received.HeaderText = "Received"
        Me.col_received.Name = "col_received"
        Me.col_received.ReadOnly = True
        Me.col_received.Width = 76
        '
        'col_missing
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_missing.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_missing.HeaderText = "Missing"
        Me.col_missing.Name = "col_missing"
        Me.col_missing.ReadOnly = True
        Me.col_missing.Width = 66
        '
        'frm_admin_transfer_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(792, 608)
        Me.Controls.Add(Me.grid_receiver)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_destination)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_source)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_report)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_transfer_id)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_admin_transfer_reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Stock Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_transfer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_report.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_destination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_receiver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_transfer_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_report As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_zero As RadioButton
    Friend WithEvents rb_dest As RadioButton
    Friend WithEvents rb_src As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_destination As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_apply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_receiver As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents descriptiom As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents col_received As DataGridViewTextBoxColumn
    Friend WithEvents col_missing As DataGridViewTextBoxColumn
End Class
