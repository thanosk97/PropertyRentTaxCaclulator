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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnProperty, Me.ColumnRent})
        Me.dgvRents.Location = New System.Drawing.Point(83, 59)
        Me.dgvRents.Name = "dgvRents"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRents.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
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
        Me.lblRent.Location = New System.Drawing.Point(12, 9)
        Me.lblRent.Name = "lblRent"
        Me.lblRent.Size = New System.Drawing.Size(65, 20)
        Me.lblRent.TabIndex = 10
        Me.lblRent.Text = "Ενοίκιο:"
        '
        'btnAddRent
        '
        Me.btnAddRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAddRent.Location = New System.Drawing.Point(170, 5)
        Me.btnAddRent.Name = "btnAddRent"
        Me.btnAddRent.Size = New System.Drawing.Size(89, 29)
        Me.btnAddRent.TabIndex = 3
        Me.btnAddRent.Text = "Προσθήκη"
        Me.btnAddRent.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCalculate.Location = New System.Drawing.Point(93, 201)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(110, 30)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Υπολογισμός"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnReset.Location = New System.Drawing.Point(104, 280)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 29)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Επαναφορά"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(429, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 35)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Έξοδος"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblResult.Location = New System.Drawing.Point(342, 31)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(244, 25)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Ανάλυση Αποτελεσμάτων"
        '
        'rtbResults
        '
        Me.rtbResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rtbResults.Location = New System.Drawing.Point(269, 59)
        Me.rtbResults.Name = "rtbResults"
        Me.rtbResults.Size = New System.Drawing.Size(393, 250)
        Me.rtbResults.TabIndex = 9
        Me.rtbResults.Text = ""
        '
        'txtRent
        '
        Me.txtRent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRent.Location = New System.Drawing.Point(83, 9)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(71, 23)
        Me.txtRent.TabIndex = 0
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 365)
        Me.Controls.Add(Me.txtRent)
        Me.Controls.Add(Me.rtbResults)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAddRent)
        Me.Controls.Add(Me.lblRent)
        Me.Controls.Add(Me.dgvRents)
        Me.Name = "Home"
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
