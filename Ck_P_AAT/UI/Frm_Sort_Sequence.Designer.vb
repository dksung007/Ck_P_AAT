<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Sort_Sequence
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_s_wire = New System.Windows.Forms.TextBox()
        Me.txt_cf_rack = New System.Windows.Forms.TextBox()
        Me.lbl_seq = New System.Windows.Forms.Label()
        Me.txt_cf_label = New System.Windows.Forms.TextBox()
        Me.txt_cf_part = New System.Windows.Forms.TextBox()
        Me.lbl_part = New System.Windows.Forms.Label()
        Me.Ck_SortDate = New System.Windows.Forms.CheckBox()
        Me.Ck_kanban = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic_AAT = New System.Windows.Forms.PictureBox()
        Me.pic_nhkant = New System.Windows.Forms.PictureBox()
        Me.lbl_ohc = New System.Windows.Forms.Label()
        Me.txt_s_ohc = New System.Windows.Forms.TextBox()
        Me.lbl_model = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_AAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_nhkant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1029, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_s_wire
        '
        Me.txt_s_wire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_s_wire.Location = New System.Drawing.Point(317, 105)
        Me.txt_s_wire.Name = "txt_s_wire"
        Me.txt_s_wire.Size = New System.Drawing.Size(299, 29)
        Me.txt_s_wire.TabIndex = 17
        '
        'txt_cf_rack
        '
        Me.txt_cf_rack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_cf_rack.Location = New System.Drawing.Point(12, 175)
        Me.txt_cf_rack.Name = "txt_cf_rack"
        Me.txt_cf_rack.Size = New System.Drawing.Size(299, 29)
        Me.txt_cf_rack.TabIndex = 16
        '
        'lbl_seq
        '
        Me.lbl_seq.AutoSize = True
        Me.lbl_seq.BackColor = System.Drawing.Color.White
        Me.lbl_seq.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_seq.ForeColor = System.Drawing.Color.Red
        Me.lbl_seq.Location = New System.Drawing.Point(317, 171)
        Me.lbl_seq.Name = "lbl_seq"
        Me.lbl_seq.Size = New System.Drawing.Size(153, 33)
        Me.lbl_seq.TabIndex = 15
        Me.lbl_seq.Text = "Sequence"
        '
        'txt_cf_label
        '
        Me.txt_cf_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_cf_label.Location = New System.Drawing.Point(12, 105)
        Me.txt_cf_label.Name = "txt_cf_label"
        Me.txt_cf_label.Size = New System.Drawing.Size(299, 29)
        Me.txt_cf_label.TabIndex = 14
        '
        'txt_cf_part
        '
        Me.txt_cf_part.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_cf_part.Location = New System.Drawing.Point(12, 70)
        Me.txt_cf_part.Name = "txt_cf_part"
        Me.txt_cf_part.Size = New System.Drawing.Size(299, 29)
        Me.txt_cf_part.TabIndex = 13
        '
        'lbl_part
        '
        Me.lbl_part.AutoSize = True
        Me.lbl_part.BackColor = System.Drawing.Color.Red
        Me.lbl_part.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_part.Location = New System.Drawing.Point(317, 72)
        Me.lbl_part.Name = "lbl_part"
        Me.lbl_part.Size = New System.Drawing.Size(98, 25)
        Me.lbl_part.TabIndex = 18
        Me.lbl_part.Text = "Part No."
        '
        'Ck_SortDate
        '
        Me.Ck_SortDate.AutoSize = True
        Me.Ck_SortDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Ck_SortDate.Location = New System.Drawing.Point(517, 32)
        Me.Ck_SortDate.Name = "Ck_SortDate"
        Me.Ck_SortDate.Size = New System.Drawing.Size(165, 37)
        Me.Ck_SortDate.TabIndex = 23
        Me.Ck_SortDate.Text = "Sort Date"
        Me.Ck_SortDate.UseVisualStyleBackColor = True
        '
        'Ck_kanban
        '
        Me.Ck_kanban.AutoSize = True
        Me.Ck_kanban.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Ck_kanban.Location = New System.Drawing.Point(372, 32)
        Me.Ck_kanban.Name = "Ck_kanban"
        Me.Ck_kanban.Size = New System.Drawing.Size(139, 37)
        Me.Ck_kanban.TabIndex = 22
        Me.Ck_kanban.Text = "Kanban"
        Me.Ck_kanban.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Ck_P_AAT.My.Resources.Resources.Normal
        Me.PictureBox1.Location = New System.Drawing.Point(317, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'pic_AAT
        '
        Me.pic_AAT.Image = Global.Ck_P_AAT.My.Resources.Resources.aat_logo
        Me.pic_AAT.Location = New System.Drawing.Point(211, 12)
        Me.pic_AAT.Name = "pic_AAT"
        Me.pic_AAT.Size = New System.Drawing.Size(100, 52)
        Me.pic_AAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_AAT.TabIndex = 20
        Me.pic_AAT.TabStop = False
        '
        'pic_nhkant
        '
        Me.pic_nhkant.Image = Global.Ck_P_AAT.My.Resources.Resources.NHKANT
        Me.pic_nhkant.Location = New System.Drawing.Point(12, 12)
        Me.pic_nhkant.Name = "pic_nhkant"
        Me.pic_nhkant.Size = New System.Drawing.Size(193, 52)
        Me.pic_nhkant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_nhkant.TabIndex = 19
        Me.pic_nhkant.TabStop = False
        '
        'lbl_ohc
        '
        Me.lbl_ohc.AutoSize = True
        Me.lbl_ohc.BackColor = System.Drawing.Color.White
        Me.lbl_ohc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_ohc.ForeColor = System.Drawing.Color.Red
        Me.lbl_ohc.Location = New System.Drawing.Point(318, 142)
        Me.lbl_ohc.Name = "lbl_ohc"
        Me.lbl_ohc.Size = New System.Drawing.Size(61, 25)
        Me.lbl_ohc.TabIndex = 25
        Me.lbl_ohc.Text = "OHC"
        '
        'txt_s_ohc
        '
        Me.txt_s_ohc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_s_ohc.Location = New System.Drawing.Point(12, 140)
        Me.txt_s_ohc.Name = "txt_s_ohc"
        Me.txt_s_ohc.Size = New System.Drawing.Size(299, 29)
        Me.txt_s_ohc.TabIndex = 24
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.BackColor = System.Drawing.Color.Red
        Me.lbl_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_model.Location = New System.Drawing.Point(621, 74)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(76, 25)
        Me.lbl_model.TabIndex = 26
        Me.lbl_model.Text = "Model"
        '
        'Frm_Sort_Sequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1053, 483)
        Me.Controls.Add(Me.lbl_model)
        Me.Controls.Add(Me.lbl_ohc)
        Me.Controls.Add(Me.txt_s_ohc)
        Me.Controls.Add(Me.Ck_SortDate)
        Me.Controls.Add(Me.Ck_kanban)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic_AAT)
        Me.Controls.Add(Me.pic_nhkant)
        Me.Controls.Add(Me.lbl_part)
        Me.Controls.Add(Me.txt_s_wire)
        Me.Controls.Add(Me.txt_cf_rack)
        Me.Controls.Add(Me.lbl_seq)
        Me.Controls.Add(Me.txt_cf_label)
        Me.Controls.Add(Me.txt_cf_part)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "Frm_Sort_Sequence"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sort Sequence"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_AAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_nhkant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_s_wire As System.Windows.Forms.TextBox
    Friend WithEvents txt_cf_rack As System.Windows.Forms.TextBox
    Friend WithEvents lbl_seq As System.Windows.Forms.Label
    Friend WithEvents txt_cf_label As System.Windows.Forms.TextBox
    Friend WithEvents txt_cf_part As System.Windows.Forms.TextBox
    Friend WithEvents lbl_part As System.Windows.Forms.Label
    Friend WithEvents Ck_SortDate As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_kanban As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_AAT As System.Windows.Forms.PictureBox
    Friend WithEvents pic_nhkant As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_ohc As System.Windows.Forms.Label
    Friend WithEvents txt_s_ohc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_model As System.Windows.Forms.Label
End Class
