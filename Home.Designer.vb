<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRents = New System.Windows.Forms.DataGridView()
        Me.ColumnProperty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRent = New System.Windows.Forms.Label()
        Me.btnAddRent = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.rtbResults = New System.Windows.Forms.RichTextBox()
        Me.txtRent = New System.Windows.Forms.TextBox()
        CType(Me.dgvRents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRents
        '
        Me.dgvRents.AllowUserToAddRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvRents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvRents.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvRents.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnProperty, Me.ColumnRent})
        Me.dgvRents.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRents.DefaultCellStyle = DataGridViewCellStyle27
        Me.dgvRents.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvRents.Location = New System.Drawing.Point(83, 59)
        Me.dgvRents.Name = "dgvRents"
        Me.dgvRents.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRents.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvRents.RowHeadersVisible = False
        Me.dgvRents.RowTemplate.ReadOnly = True
        Me.dgvRents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRents.Size = New System.Drawing.Size(133, 136)
        Me.dgvRents.TabIndex = 1
        '
        'ColumnProperty
        '
        Me.ColumnProperty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnProperty.HeaderText = "Ακίνητο"
        Me.ColumnProperty.Name = "ColumnProperty"
        Me.ColumnProperty.ReadOnly = True
        Me.ColumnProperty.Width = 65
        '
        'ColumnRent
        '
        Me.ColumnRent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnRent.HeaderText = "Ενοίκιο"
        Me.ColumnRent.Name = "ColumnRent"
        Me.ColumnRent.ReadOnly = True
        Me.ColumnRent.Width = 65
        '
        'lblRent
        '
        Me.lblRent.AutoSize = True
        Me.lblRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRent.ForeColor = System.Drawing.Color.White
        Me.lblRent.Location = New System.Drawing.Point(12, 9)
        Me.lblRent.Name = "lblRent"
        Me.lblRent.Size = New System.Drawing.Size(65, 20)
        Me.lblRent.TabIndex = 10
        Me.lblRent.Text = "Ενοίκιο:"
        '
        'btnAddRent
        '
        Me.btnAddRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnAddRent.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddRent.FlatAppearance.BorderSize = 0
        Me.btnAddRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRent.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddRent.ForeColor = System.Drawing.Color.White
        Me.btnAddRent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddRent.Location = New System.Drawing.Point(169, 6)
        Me.btnAddRent.Name = "btnAddRent"
        Me.btnAddRent.Size = New System.Drawing.Size(82, 29)
        Me.btnAddRent.TabIndex = 3
        Me.btnAddRent.Text = "Προσθήκη"
        Me.btnAddRent.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCalculate.FlatAppearance.BorderSize = 0
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(83, 201)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(133, 30)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Υπολογισμός"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(269, 243)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(99, 29)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Επαναφορά"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(653, 237)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 35)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Έξοδος"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(329, 32)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(244, 25)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Ανάλυση Αποτελεσμάτων"
        '
        'rtbResults
        '
        Me.rtbResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.rtbResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbResults.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rtbResults.ForeColor = System.Drawing.SystemColors.Window
        Me.rtbResults.Location = New System.Drawing.Point(269, 73)
        Me.rtbResults.Name = "rtbResults"
        Me.rtbResults.Size = New System.Drawing.Size(462, 158)
        Me.rtbResults.TabIndex = 9
        Me.rtbResults.Text = ""
        '
        'txtRent
        '
        Me.txtRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtRent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRent.ForeColor = System.Drawing.SystemColors.Window
        Me.txtRent.Location = New System.Drawing.Point(83, 13)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(71, 16)
        Me.txtRent.TabIndex = 0
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 292)
        Me.Controls.Add(Me.txtRent)
        Me.Controls.Add(Me.rtbResults)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAddRent)
        Me.Controls.Add(Me.lblRent)
        Me.Controls.Add(Me.dgvRents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Υπολογιστής Φόρου Εισοδήματος Ακινήτων"
        CType(Me.dgvRents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRents As DataGridView
    Friend WithEvents lblRent As Label
    Friend WithEvents btnAddRent As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents rtbResults As RichTextBox
    Friend WithEvents ColumnProperty As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRent As DataGridViewTextBoxColumn
    Friend WithEvents txtRent As TextBox
End Class
