<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.pic_AAT = New System.Windows.Forms.PictureBox()
        Me.pic_nhkant = New System.Windows.Forms.PictureBox()
        Me.Ck_SortDate = New System.Windows.Forms.CheckBox()
        Me.lbl_amount = New System.Windows.Forms.Label()
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
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1041, 414)
        Me.DataGridView1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(853, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 40)
        Me.DateTimePicker1.TabIndex = 4
        '
        'pic_AAT
        '
        Me.pic_AAT.Image = Global.Ck_P_AAT.My.Resources.Resources.aat_logo
        Me.pic_AAT.Location = New System.Drawing.Point(184, 12)
        Me.pic_AAT.Name = "pic_AAT"
        Me.pic_AAT.Size = New System.Drawing.Size(100, 52)
        Me.pic_AAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_AAT.TabIndex = 3
        Me.pic_AAT.TabStop = False
        '
        'pic_nhkant
        '
        Me.pic_nhkant.Image = Global.Ck_P_AAT.My.Resources.Resources.NHKANT
        Me.pic_nhkant.Location = New System.Drawing.Point(12, 12)
        Me.pic_nhkant.Name = "pic_nhkant"
        Me.pic_nhkant.Size = New System.Drawing.Size(166, 52)
        Me.pic_nhkant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_nhkant.TabIndex = 2
        Me.pic_nhkant.TabStop = False
        '
        'Ck_SortDate
        '
        Me.Ck_SortDate.AutoSize = True
        Me.Ck_SortDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Ck_SortDate.Location = New System.Drawing.Point(290, 29)
        Me.Ck_SortDate.Name = "Ck_SortDate"
        Me.Ck_SortDate.Size = New System.Drawing.Size(165, 37)
        Me.Ck_SortDate.TabIndex = 11
        Me.Ck_SortDate.Text = "Sort Date"
        Me.Ck_SortDate.UseVisualStyleBackColor = True
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_amount.Location = New System.Drawing.Point(461, 37)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(105, 25)
        Me.lbl_amount.TabIndex = 12
        Me.lbl_amount.Text = "Amount :"
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1065, 496)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.Ck_SortDate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.pic_AAT)
        Me.Controls.Add(Me.pic_nhkant)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_AAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_nhkant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pic_AAT As System.Windows.Forms.PictureBox
    Friend WithEvents pic_nhkant As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ck_SortDate As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_amount As System.Windows.Forms.Label
End Class
