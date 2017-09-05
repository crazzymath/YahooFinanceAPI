<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YahooDataForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBoxRICs = New System.Windows.Forms.TextBox()
        Me.AskButton = New System.Windows.Forms.Button()
        Me.LabelBox = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Disc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxRICs
        '
        Me.TextBoxRICs.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRICs.Location = New System.Drawing.Point(415, 47)
        Me.TextBoxRICs.Multiline = True
        Me.TextBoxRICs.Name = "TextBoxRICs"
        Me.TextBoxRICs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxRICs.Size = New System.Drawing.Size(216, 393)
        Me.TextBoxRICs.TabIndex = 3
        '
        'AskButton
        '
        Me.AskButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AskButton.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AskButton.Location = New System.Drawing.Point(20, 47)
        Me.AskButton.Name = "AskButton"
        Me.AskButton.Size = New System.Drawing.Size(144, 90)
        Me.AskButton.TabIndex = 1
        Me.AskButton.Text = "Data Download"
        Me.AskButton.UseVisualStyleBackColor = False
        '
        'LabelBox
        '
        Me.LabelBox.AutoSize = True
        Me.LabelBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBox.Location = New System.Drawing.Point(411, 25)
        Me.LabelBox.Name = "LabelBox"
        Me.LabelBox.Size = New System.Drawing.Size(98, 19)
        Me.LabelBox.TabIndex = 2
        Me.LabelBox.Text = "Stock's Codes"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(218, 47)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(120, 27)
        Me.DateTimePicker.TabIndex = 2
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(214, 25)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(79, 19)
        Me.LabelDate.TabIndex = 4
        Me.LabelDate.Text = "Data Date:"
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ProgressBar.Location = New System.Drawing.Point(20, 416)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(318, 23)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 0
        Me.ProgressBar.Visible = False
        '
        'Disc
        '
        Me.Disc.AutoSize = True
        Me.Disc.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disc.Location = New System.Drawing.Point(416, 443)
        Me.Disc.Name = "Disc"
        Me.Disc.Size = New System.Drawing.Size(180, 13)
        Me.Disc.TabIndex = 4
        Me.Disc.Text = "Market data provided by Yahoo Finace"
        '
        'YahooDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 460)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Disc)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.LabelBox)
        Me.Controls.Add(Me.AskButton)
        Me.Controls.Add(Me.TextBoxRICs)
        Me.Name = "YahooDataForm"
        Me.Text = "Yahoo Data Demo App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxRICs As TextBox
    Friend WithEvents AskButton As Button
    Friend WithEvents LabelBox As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents LabelDate As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents Disc As Label
End Class
