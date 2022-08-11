<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmamountpayablepage
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
        Me.lblYourpaymentis = New System.Windows.Forms.Label()
        Me.lblpayamount = New System.Windows.Forms.Label()
        Me.lblGstDescription = New System.Windows.Forms.Label()
        Me.lblGst = New System.Windows.Forms.Label()
        Me.btnmakepayment = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblYourpaymentis
        '
        Me.lblYourpaymentis.AutoSize = True
        Me.lblYourpaymentis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourpaymentis.Location = New System.Drawing.Point(27, 115)
        Me.lblYourpaymentis.Name = "lblYourpaymentis"
        Me.lblYourpaymentis.Size = New System.Drawing.Size(158, 25)
        Me.lblYourpaymentis.TabIndex = 0
        Me.lblYourpaymentis.Text = "Your payment is:"
        '
        'lblpayamount
        '
        Me.lblpayamount.AutoSize = True
        Me.lblpayamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpayamount.Location = New System.Drawing.Point(228, 115)
        Me.lblpayamount.Name = "lblpayamount"
        Me.lblpayamount.Size = New System.Drawing.Size(125, 38)
        Me.lblpayamount.TabIndex = 1
        Me.lblpayamount.Text = "amount"
        '
        'lblGstDescription
        '
        Me.lblGstDescription.AutoSize = True
        Me.lblGstDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGstDescription.Location = New System.Drawing.Point(27, 188)
        Me.lblGstDescription.Name = "lblGstDescription"
        Me.lblGstDescription.Size = New System.Drawing.Size(293, 25)
        Me.lblGstDescription.TabIndex = 2
        Me.lblGstDescription.Text = "Price shown include GST at 6%:"
        '
        'lblGst
        '
        Me.lblGst.AutoSize = True
        Me.lblGst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGst.Location = New System.Drawing.Point(340, 188)
        Me.lblGst.Name = "lblGst"
        Me.lblGst.Size = New System.Drawing.Size(38, 25)
        Me.lblGst.TabIndex = 3
        Me.lblGst.Text = "gst"
        '
        'btnmakepayment
        '
        Me.btnmakepayment.Location = New System.Drawing.Point(102, 280)
        Me.btnmakepayment.Name = "btnmakepayment"
        Me.btnmakepayment.Size = New System.Drawing.Size(251, 48)
        Me.btnmakepayment.TabIndex = 4
        Me.btnmakepayment.Text = "Make payment"
        Me.btnmakepayment.UseVisualStyleBackColor = True
        '
        'frmamountpayablepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 410)
        Me.Controls.Add(Me.btnmakepayment)
        Me.Controls.Add(Me.lblGst)
        Me.Controls.Add(Me.lblGstDescription)
        Me.Controls.Add(Me.lblpayamount)
        Me.Controls.Add(Me.lblYourpaymentis)
        Me.Name = "frmamountpayablepage"
        Me.Text = "Cinema Ordering System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblYourpaymentis As System.Windows.Forms.Label
    Friend WithEvents lblpayamount As System.Windows.Forms.Label
    Friend WithEvents lblGstDescription As System.Windows.Forms.Label
    Friend WithEvents lblGst As System.Windows.Forms.Label
    Friend WithEvents btnmakepayment As System.Windows.Forms.Button
End Class
