<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCk_Part
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCk_Part))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_part = New System.Windows.Forms.Label()
        Me.lbl_EcssDate = New System.Windows.Forms.Label()
        Me.Ck_kanban = New System.Windows.Forms.CheckBox()
        Me.Ck_SortDate = New System.Windows.Forms.CheckBox()
        Me.Btn_Report = New System.Windows.Forms.Button()
        Me.Btn_Sort_data = New System.Windows.Forms.Button()
        Me.Btn_show = New System.Windows.Forms.Button()
        Me.Btn_pre = New System.Windows.Forms.Button()
        Me.lbl_trim = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ts_last_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_ohc = New System.Windows.Forms.Label()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.btn_log = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic_AAT = New System.Windows.Forms.PictureBox()
        Me.pic_nhkant = New System.Windows.Forms.PictureBox()
        Me.Btn_Wire = New System.Windows.Forms.Button()
        Me.WM_lbl_Ohc1 = New Ck_P_AAT.WM_lbl_Ohc()
        Me.WM_bc_Wire1 = New Ck_P_AAT.WM_bc_Wire()
        Me.WM_lbl_Trim1 = New Ck_P_AAT.WM_lbl_Trim()
        Me.WM_lbl_Production1 = New Ck_P_AAT.WM_lbl_Production()
        Me.WM_bc_Rack1 = New Ck_P_AAT.WM_bc_Rack()
        Me.lbl_amount = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_AAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_nhkant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(941, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 40)
        Me.DateTimePicker1.TabIndex = 2
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
        Me.DataGridView1.Size = New System.Drawing.Size(1129, 232)
        Me.DataGridView1.TabIndex = 3
        '
        'lbl_part
        '
        Me.lbl_part.AutoSize = True
        Me.lbl_part.BackColor = System.Drawing.Color.Red
        Me.lbl_part.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_part.Location = New System.Drawing.Point(318, 72)
        Me.lbl_part.Name = "lbl_part"
        Me.lbl_part.Size = New System.Drawing.Size(98, 25)
        Me.lbl_part.TabIndex = 4
        Me.lbl_part.Text = "Part No."
        '
        'lbl_EcssDate
        '
        Me.lbl_EcssDate.AutoSize = True
        Me.lbl_EcssDate.BackColor = System.Drawing.Color.White
        Me.lbl_EcssDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_EcssDate.ForeColor = System.Drawing.Color.Red
        Me.lbl_EcssDate.Location = New System.Drawing.Point(317, 171)
        Me.lbl_EcssDate.Name = "lbl_EcssDate"
        Me.lbl_EcssDate.Size = New System.Drawing.Size(153, 33)
        Me.lbl_EcssDate.TabIndex = 6
        Me.lbl_EcssDate.Text = "Sequence"
        '
        'Ck_kanban
        '
        Me.Ck_kanban.AutoSize = True
        Me.Ck_kanban.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Ck_kanban.Location = New System.Drawing.Point(372, 27)
        Me.Ck_kanban.Name = "Ck_kanban"
        Me.Ck_kanban.Size = New System.Drawing.Size(139, 37)
        Me.Ck_kanban.TabIndex = 9
        Me.Ck_kanban.Text = "Kanban"
        Me.Ck_kanban.UseVisualStyleBackColor = True
        '
        'Ck_SortDate
        '
        Me.Ck_SortDate.AutoSize = True
        Me.Ck_SortDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Ck_SortDate.Location = New System.Drawing.Point(517, 27)
        Me.Ck_SortDate.Name = "Ck_SortDate"
        Me.Ck_SortDate.Size = New System.Drawing.Size(165, 37)
        Me.Ck_SortDate.TabIndex = 10
        Me.Ck_SortDate.Text = "Sort Date"
        Me.Ck_SortDate.UseVisualStyleBackColor = True
        '
        'Btn_Report
        '
        Me.Btn_Report.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Report.Location = New System.Drawing.Point(1066, 58)
        Me.Btn_Report.Name = "Btn_Report"
        Me.Btn_Report.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Report.TabIndex = 11
        Me.Btn_Report.Text = "Report"
        Me.Btn_Report.UseVisualStyleBackColor = True
        '
        'Btn_Sort_data
        '
        Me.Btn_Sort_data.Location = New System.Drawing.Point(628, 105)
        Me.Btn_Sort_data.Name = "Btn_Sort_data"
        Me.Btn_Sort_data.Size = New System.Drawing.Size(75, 29)
        Me.Btn_Sort_data.TabIndex = 13
        Me.Btn_Sort_data.Text = "Sort Data"
        Me.Btn_Sort_data.UseVisualStyleBackColor = True
        '
        'Btn_show
        '
        Me.Btn_show.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_show.Location = New System.Drawing.Point(985, 58)
        Me.Btn_show.Name = "Btn_show"
        Me.Btn_show.Size = New System.Drawing.Size(75, 23)
        Me.Btn_show.TabIndex = 14
        Me.Btn_show.Text = "Show Data"
        Me.Btn_show.UseVisualStyleBackColor = True
        '
        'Btn_pre
        '
        Me.Btn_pre.Location = New System.Drawing.Point(628, 140)
        Me.Btn_pre.Name = "Btn_pre"
        Me.Btn_pre.Size = New System.Drawing.Size(75, 29)
        Me.Btn_pre.TabIndex = 15
        Me.Btn_pre.Text = "Pre-Load"
        Me.Btn_pre.UseVisualStyleBackColor = True
        '
        'lbl_trim
        '
        Me.lbl_trim.AutoSize = True
        Me.lbl_trim.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_trim.Location = New System.Drawing.Point(709, 118)
        Me.lbl_trim.Name = "lbl_trim"
        Me.lbl_trim.Size = New System.Drawing.Size(324, 55)
        Me.lbl_trim.TabIndex = 16
        Me.lbl_trim.Text = "Trim Rotation"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_last_time})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 445)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1153, 35)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ts_last_time
        '
        Me.ts_last_time.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts_last_time.Name = "ts_last_time"
        Me.ts_last_time.Size = New System.Drawing.Size(118, 30)
        Me.ts_last_time.Text = "Last Time :"
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
        Me.lbl_ohc.TabIndex = 19
        Me.lbl_ohc.Text = "OHC"
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.BackColor = System.Drawing.Color.Red
        Me.lbl_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_model.Location = New System.Drawing.Point(627, 74)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(76, 25)
        Me.lbl_model.TabIndex = 20
        Me.lbl_model.Text = "Model"
        '
        'btn_log
        '
        Me.btn_log.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_log.Location = New System.Drawing.Point(1066, 87)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(75, 23)
        Me.btn_log.TabIndex = 21
        Me.btn_log.Text = "Log"
        Me.btn_log.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Ck_P_AAT.My.Resources.Resources.Normal
        Me.PictureBox1.Location = New System.Drawing.Point(317, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'pic_AAT
        '
        Me.pic_AAT.Image = Global.Ck_P_AAT.My.Resources.Resources.aat_logo
        Me.pic_AAT.Location = New System.Drawing.Point(211, 12)
        Me.pic_AAT.Name = "pic_AAT"
        Me.pic_AAT.Size = New System.Drawing.Size(100, 52)
        Me.pic_AAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_AAT.TabIndex = 1
        Me.pic_AAT.TabStop = False
        '
        'pic_nhkant
        '
        Me.pic_nhkant.Image = Global.Ck_P_AAT.My.Resources.Resources.NHKANT
        Me.pic_nhkant.Location = New System.Drawing.Point(12, 12)
        Me.pic_nhkant.Name = "pic_nhkant"
        Me.pic_nhkant.Size = New System.Drawing.Size(193, 52)
        Me.pic_nhkant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_nhkant.TabIndex = 0
        Me.pic_nhkant.TabStop = False
        '
        'Btn_Wire
        '
        Me.Btn_Wire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Wire.Location = New System.Drawing.Point(985, 87)
        Me.Btn_Wire.Name = "Btn_Wire"
        Me.Btn_Wire.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Wire.TabIndex = 22
        Me.Btn_Wire.Text = "Wire"
        Me.Btn_Wire.UseVisualStyleBackColor = True
        '
        'WM_lbl_Ohc1
        '
        Me.WM_lbl_Ohc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.WM_lbl_Ohc1.Location = New System.Drawing.Point(12, 140)
        Me.WM_lbl_Ohc1.Name = "WM_lbl_Ohc1"
        Me.WM_lbl_Ohc1.Size = New System.Drawing.Size(299, 29)
        Me.WM_lbl_Ohc1.TabIndex = 26
        Me.WM_lbl_Ohc1.waterMarkColor = System.Drawing.Color.Gray
        Me.WM_lbl_Ohc1.waterMarkText = "OHC"
        '
        'WM_bc_Wire1
        '
        Me.WM_bc_Wire1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.WM_bc_Wire1.Location = New System.Drawing.Point(317, 105)
        Me.WM_bc_Wire1.Name = "WM_bc_Wire1"
        Me.WM_bc_Wire1.Size = New System.Drawing.Size(305, 29)
        Me.WM_bc_Wire1.TabIndex = 25
        Me.WM_bc_Wire1.waterMarkColor = System.Drawing.Color.Gray
        Me.WM_bc_Wire1.waterMarkText = "Wire"
        '
        'WM_lbl_Trim1
        '
        Me.WM_lbl_Trim1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.WM_lbl_Trim1.Location = New System.Drawing.Point(12, 105)
        Me.WM_lbl_Trim1.Name = "WM_lbl_Trim1"
        Me.WM_lbl_Trim1.Size = New System.Drawing.Size(299, 29)
        Me.WM_lbl_Trim1.TabIndex = 24
        Me.WM_lbl_Trim1.waterMarkColor = System.Drawing.Color.Gray
        Me.WM_lbl_Trim1.waterMarkText = "Label Trim Rotation"
        '
        'WM_lbl_Production1
        '
        Me.WM_lbl_Production1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.WM_lbl_Production1.Location = New System.Drawing.Point(12, 70)
        Me.WM_lbl_Production1.Name = "WM_lbl_Production1"
        Me.WM_lbl_Production1.Size = New System.Drawing.Size(299, 29)
        Me.WM_lbl_Production1.TabIndex = 23
        Me.WM_lbl_Production1.waterMarkColor = System.Drawing.Color.Gray
        Me.WM_lbl_Production1.waterMarkText = "Label Production"
        '
        'WM_bc_Rack1
        '
        Me.WM_bc_Rack1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.WM_bc_Rack1.Location = New System.Drawing.Point(12, 175)
        Me.WM_bc_Rack1.Name = "WM_bc_Rack1"
        Me.WM_bc_Rack1.Size = New System.Drawing.Size(299, 29)
        Me.WM_bc_Rack1.TabIndex = 27
        Me.WM_bc_Rack1.waterMarkColor = System.Drawing.Color.Gray
        Me.WM_bc_Rack1.waterMarkText = "Barcode Rack Summary"
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_amount.Location = New System.Drawing.Point(713, 176)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(217, 31)
        Me.lbl_amount.TabIndex = 28
        Me.lbl_amount.Text = "Amount 0 Items"
        '
        'FrmCk_Part
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1153, 480)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.WM_bc_Rack1)
        Me.Controls.Add(Me.WM_lbl_Ohc1)
        Me.Controls.Add(Me.WM_bc_Wire1)
        Me.Controls.Add(Me.WM_lbl_Trim1)
        Me.Controls.Add(Me.WM_lbl_Production1)
        Me.Controls.Add(Me.Btn_Wire)
        Me.Controls.Add(Me.btn_log)
        Me.Controls.Add(Me.lbl_model)
        Me.Controls.Add(Me.lbl_ohc)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbl_trim)
        Me.Controls.Add(Me.Btn_pre)
        Me.Controls.Add(Me.Btn_show)
        Me.Controls.Add(Me.Btn_Sort_data)
        Me.Controls.Add(Me.Btn_Report)
        Me.Controls.Add(Me.Ck_SortDate)
        Me.Controls.Add(Me.Ck_kanban)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_EcssDate)
        Me.Controls.Add(Me.lbl_part)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.pic_AAT)
        Me.Controls.Add(Me.pic_nhkant)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCk_Part"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Part"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_AAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_nhkant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_nhkant As System.Windows.Forms.PictureBox
    Friend WithEvents pic_AAT As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_part As System.Windows.Forms.Label
    Friend WithEvents lbl_EcssDate As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Ck_kanban As System.Windows.Forms.CheckBox
    Friend WithEvents Ck_SortDate As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Report As System.Windows.Forms.Button
    Friend WithEvents Btn_Sort_data As System.Windows.Forms.Button
    Friend WithEvents Btn_show As System.Windows.Forms.Button
    Friend WithEvents Btn_pre As System.Windows.Forms.Button
    Friend WithEvents lbl_trim As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ts_last_time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_ohc As System.Windows.Forms.Label
    Friend WithEvents lbl_model As System.Windows.Forms.Label
    Friend WithEvents btn_log As System.Windows.Forms.Button
    Friend WithEvents Btn_Wire As System.Windows.Forms.Button
    Friend WithEvents WM_lbl_Production1 As Ck_P_AAT.WM_lbl_Production
    Friend WithEvents WM_lbl_Trim1 As Ck_P_AAT.WM_lbl_Trim
    Friend WithEvents WM_bc_Wire1 As Ck_P_AAT.WM_bc_Wire
    Friend WithEvents WM_lbl_Ohc1 As Ck_P_AAT.WM_lbl_Ohc
    Friend WithEvents WM_bc_Rack1 As Ck_P_AAT.WM_bc_Rack
    Friend WithEvents lbl_amount As System.Windows.Forms.Label
End Class
