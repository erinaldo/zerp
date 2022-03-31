
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_packing_list_view
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_packing_list_view))
        Me.txt_priv_comment = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_orderid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_customer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_agent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_packed = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.cbb_packer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_packed_by = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pub_comment = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_box_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_plastic_no = New DevExpress.XtraEditors.TextEdit()
        Me.txt_rolls_no = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txt_priv_comment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orderid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_agent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_packer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pub_comment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_box_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_plastic_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_rolls_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_priv_comment
        '
        Me.txt_priv_comment.Location = New System.Drawing.Point(12, 151)
        Me.txt_priv_comment.Name = "txt_priv_comment"
        Me.txt_priv_comment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.8!)
        Me.txt_priv_comment.Properties.Appearance.Options.UseFont = True
        Me.txt_priv_comment.Size = New System.Drawing.Size(403, 83)
        Me.txt_priv_comment.TabIndex = 0
        '
        'txt_orderid
        '
        Me.txt_orderid.Location = New System.Drawing.Point(101, 32)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_orderid.Properties.Appearance.Options.UseFont = True
        Me.txt_orderid.Properties.ReadOnly = True
        Me.txt_orderid.Properties.UseReadOnlyAppearance = False
        Me.txt_orderid.Size = New System.Drawing.Size(90, 22)
        Me.txt_orderid.TabIndex = 50
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl3.TabIndex = 49
        Me.LabelControl3.Text = "Order No."
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(101, 62)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_customer.Properties.Appearance.Options.UseFont = True
        Me.txt_customer.Properties.ReadOnly = True
        Me.txt_customer.Properties.UseReadOnlyAppearance = False
        Me.txt_customer.Size = New System.Drawing.Size(174, 22)
        Me.txt_customer.TabIndex = 52
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl2.TabIndex = 51
        Me.LabelControl2.Text = "Customer"
        '
        'txt_agent
        '
        Me.txt_agent.Location = New System.Drawing.Point(101, 92)
        Me.txt_agent.Name = "txt_agent"
        Me.txt_agent.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_agent.Properties.Appearance.Options.UseFont = True
        Me.txt_agent.Properties.ReadOnly = True
        Me.txt_agent.Properties.UseReadOnlyAppearance = False
        Me.txt_agent.Size = New System.Drawing.Size(174, 22)
        Me.txt_agent.TabIndex = 54
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 95)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Sales Agent"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 127)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 16)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Private Comment"
        '
        'btn_packed
        '
        Me.btn_packed.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_16x16
        Me.btn_packed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_packed.Location = New System.Drawing.Point(12, 445)
        Me.btn_packed.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_packed.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_packed.Name = "btn_packed"
        Me.btn_packed.Size = New System.Drawing.Size(403, 46)
        Me.btn_packed.TabIndex = 2
        Me.btn_packed.Text = "Mark as Packed"
        '
        'btn_print
        '
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x322
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.Location = New System.Drawing.Point(303, 25)
        Me.btn_print.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(112, 97)
        Me.btn_print.TabIndex = 1
        Me.btn_print.Text = "Print / View"
        '
        'cbb_packer
        '
        Me.cbb_packer.Location = New System.Drawing.Point(179, 381)
        Me.cbb_packer.Name = "cbb_packer"
        Me.cbb_packer.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_packer.Properties.Appearance.Options.UseFont = True
        Me.cbb_packer.Properties.AutoHeight = False
        Me.cbb_packer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_packer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_packer.Size = New System.Drawing.Size(232, 32)
        Me.cbb_packer.TabIndex = 56
        '
        'lbl_packed_by
        '
        Me.lbl_packed_by.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.lbl_packed_by.Appearance.Options.UseFont = True
        Me.lbl_packed_by.Location = New System.Drawing.Point(179, 359)
        Me.lbl_packed_by.Name = "lbl_packed_by"
        Me.lbl_packed_by.Size = New System.Drawing.Size(75, 16)
        Me.lbl_packed_by.TabIndex = 57
        Me.lbl_packed_by.Text = "Organized By"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 240)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl1.TabIndex = 59
        Me.LabelControl1.Text = "Public Comment"
        '
        'txt_pub_comment
        '
        Me.txt_pub_comment.Location = New System.Drawing.Point(12, 264)
        Me.txt_pub_comment.Name = "txt_pub_comment"
        Me.txt_pub_comment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.8!)
        Me.txt_pub_comment.Properties.Appearance.Options.UseFont = True
        Me.txt_pub_comment.Size = New System.Drawing.Size(403, 83)
        Me.txt_pub_comment.TabIndex = 58
        '
        'txt_box_no
        '
        Me.txt_box_no.Location = New System.Drawing.Point(101, 356)
        Me.txt_box_no.Name = "txt_box_no"
        Me.txt_box_no.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_box_no.Properties.Appearance.Options.UseFont = True
        Me.txt_box_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_box_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_box_no.Size = New System.Drawing.Size(62, 22)
        Me.txt_box_no.TabIndex = 60
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(12, 359)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl6.TabIndex = 61
        Me.LabelControl6.Text = "No. of Box"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(12, 387)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl7.TabIndex = 62
        Me.LabelControl7.Text = "No. of Plastic"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(12, 415)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(65, 16)
        Me.LabelControl8.TabIndex = 63
        Me.LabelControl8.Text = "No. of Rolls"
        '
        'txt_plastic_no
        '
        Me.txt_plastic_no.Location = New System.Drawing.Point(101, 384)
        Me.txt_plastic_no.Name = "txt_plastic_no"
        Me.txt_plastic_no.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_plastic_no.Properties.Appearance.Options.UseFont = True
        Me.txt_plastic_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_plastic_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_plastic_no.Size = New System.Drawing.Size(62, 22)
        Me.txt_plastic_no.TabIndex = 64
        '
        'txt_rolls_no
        '
        Me.txt_rolls_no.Location = New System.Drawing.Point(101, 412)
        Me.txt_rolls_no.Name = "txt_rolls_no"
        Me.txt_rolls_no.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_rolls_no.Properties.Appearance.Options.UseFont = True
        Me.txt_rolls_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_rolls_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_rolls_no.Size = New System.Drawing.Size(62, 22)
        Me.txt_rolls_no.TabIndex = 65
        '
        'frm_sales_packing_list_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(427, 502)
        Me.Controls.Add(Me.txt_rolls_no)
        Me.Controls.Add(Me.txt_plastic_no)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txt_box_no)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_pub_comment)
        Me.Controls.Add(Me.lbl_packed_by)
        Me.Controls.Add(Me.cbb_packer)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_agent)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_customer)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_packed)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.txt_priv_comment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_sales_packing_list_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Packing List"
        CType(Me.txt_priv_comment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orderid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_agent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_packer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pub_comment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_box_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_plastic_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_rolls_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_packed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_orderid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_customer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_agent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_packer As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents lbl_packed_by As DevExpress.XtraEditors.LabelControl
	Friend WithEvents txt_priv_comment As MemoEdit
	Friend WithEvents LabelControl1 As LabelControl
	Friend WithEvents txt_pub_comment As MemoEdit
	Friend WithEvents txt_box_no As TextEdit
	Friend WithEvents LabelControl6 As LabelControl
	Friend WithEvents LabelControl7 As LabelControl
	Friend WithEvents LabelControl8 As LabelControl
	Friend WithEvents txt_plastic_no As TextEdit
	Friend WithEvents txt_rolls_no As TextEdit
End Class
