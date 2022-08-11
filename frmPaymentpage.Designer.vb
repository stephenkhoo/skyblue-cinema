<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpaymentpage
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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtpayment = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInput.Location = New System.Drawing.Point(12, 67)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(231, 20)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Please input your payment"
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtpayment
        '
        Me.txtpayment.Location = New System.Drawing.Point(61, 104)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.Size = New System.Drawing.Size(173, 22)
        Me.txtpayment.TabIndex = 1
        Me.txtpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(115, 146)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 37)
        Me.btnPay.TabIndex = 2
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'frmpaymentpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 237)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtpayment)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "frmpaymentpage"
        Me.Text = "Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtpayment As System.Windows.Forms.TextBox
    Friend WithEvents btnPay As System.Windows.Forms.Button
End Class
