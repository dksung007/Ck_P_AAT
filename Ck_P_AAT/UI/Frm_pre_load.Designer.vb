<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_pre_load
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
        Me.Ck_SortDate = New System.Windows.Forms.CheckBox()
        Me.pic_AAT = New System.Windows.Forms.PictureBox()
        Me.pic_nhkant = New System.Windows.Forms.PictureBox()
        Me.Chk_sort_trim = New System.Windows.Forms.CheckBox()
        Me.lbl_trim = New System.Windows.Forms.Label()
        Me.lbl_n_part = New System.Windows.Forms.Label()
        Me.lbl_f_part = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 296)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(847, 175)
        Me.DataGridView1.TabIndex = 0
        '
        'Ck_SortDate
        '
        Me.Ck_SortDate.AutoSize = True
        Me.Ck_SortDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Ck_SortDate.Location = New System.Drawing.Point(290, 27)
        Me.Ck_SortDate.Name = "Ck_SortDate"
        Me.Ck_SortDate.Size = New System.Drawing.Size(165, 37)
        Me.Ck_SortDate.TabIndex = 13
        Me.Ck_SortDate.Text = "Sort Date"
        Me.Ck_SortDate.UseVisualStyleBackColor = True
        '
        'pic_AAT
        '
        Me.pic_AAT.Image = Global.Ck_P_AAT.My.Resources.Resources.aat_logo
        Me.pic_AAT.Location = New System.Drawing.Point(184, 12)
        Me.pic_AAT.Name = "pic_AAT"
        Me.pic_AAT.Size = New System.Drawing.Size(100, 52)
        Me.pic_AAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_AAT.TabIndex = 12
        Me.pic_AAT.TabStop = False
        '
        'pic_nhkant
        '
        Me.pic_nhkant.Image = Global.Ck_P_AAT.My.Resources.Resources.NHKANT
        Me.pic_nhkant.Location = New System.Drawing.Point(12, 12)
        Me.pic_nhkant.Name = "pic_nhkant"
        Me.pic_nhkant.Size = New System.Drawing.Size(166, 52)
        Me.pic_nhkant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_nhkant.TabIndex = 11
        Me.pic_nhkant.TabStop = False
        '
        'Chk_sort_trim
        '
        Me.Chk_sort_trim.AutoSize = True
        Me.Chk_sort_trim.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Chk_sort_trim.Location = New System.Drawing.Point(461, 27)
        Me.Chk_sort_trim.Name = "Chk_sort_trim"
        Me.Chk_sort_trim.Size = New System.Drawing.Size(164, 37)
        Me.Chk_sort_trim.TabIndex = 14
        Me.Chk_sort_trim.Text = "Sort Trim"
        Me.Chk_sort_trim.UseVisualStyleBackColor = True
        '
        'lbl_trim
        '
        Me.lbl_trim.AutoSize = True
        Me.lbl_trim.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_trim.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_trim.Location = New System.Drawing.Point(12, 78)
        Me.lbl_trim.Name = "lbl_trim"
        Me.lbl_trim.Size = New System.Drawing.Size(429, 73)
        Me.lbl_trim.TabIndex = 15
        Me.lbl_trim.Text = "Trim Rotation"
        '
        'lbl_n_part
        '
        Me.lbl_n_part.AutoSize = True
        Me.lbl_n_part.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_n_part.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_n_part.Location = New System.Drawing.Point(12, 147)
        Me.lbl_n_part.Name = "lbl_n_part"
        Me.lbl_n_part.Size = New System.Drawing.Size(219, 73)
        Me.lbl_n_part.TabIndex = 16
        Me.lbl_n_part.Text = "N Part"
        '
        'lbl_f_part
        '
        Me.lbl_f_part.AutoSize = True
        Me.lbl_f_part.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_f_part.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_f_part.Location = New System.Drawing.Point(12, 220)
        Me.lbl_f_part.Name = "lbl_f_part"
        Me.lbl_f_part.Size = New System.Drawing.Size(212, 73)
        Me.lbl_f_part.TabIndex = 17
        Me.lbl_f_part.Text = "F Part"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(670, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 66)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Show Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_pre_load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(871, 483)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_f_part)
        Me.Controls.Add(Me.lbl_n_part)
        Me.Controls.Add(Me.lbl_trim)
        Me.Controls.Add(Me.Chk_sort_trim)
        Me.Controls.Add(Me.Ck_SortDate)
        Me.Controls.Add(Me.pic_AAT)
        Me.Controls.Add(Me.pic_nhkant)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Frm_pre_load"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre-Load"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_AAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_nhkant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Ck_SortDate As System.Windows.Forms.CheckBox
    Friend WithEvents pic_AAT As System.Windows.Forms.PictureBox
    Friend WithEvents pic_nhkant As System.Windows.Forms.PictureBox
    Friend WithEvents Chk_sort_trim As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_trim As System.Windows.Forms.Label
    Friend WithEvents lbl_n_part As System.Windows.Forms.Label
    Friend WithEvents lbl_f_part As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
