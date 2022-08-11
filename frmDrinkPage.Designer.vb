<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrinkPage
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
        Me.lblSelectYourDrinks = New System.Windows.Forms.Label()
        Me.chkbxcoke = New System.Windows.Forms.CheckBox()
        Me.chkbxlemonade = New System.Windows.Forms.CheckBox()
        Me.ChkBxMountainDew = New System.Windows.Forms.CheckBox()
        Me.ChkBxOrangeJuice = New System.Windows.Forms.CheckBox()
        Me.txtCoke = New System.Windows.Forms.TextBox()
        Me.txtLemonade = New System.Windows.Forms.TextBox()
        Me.txtMountainDew = New System.Windows.Forms.TextBox()
        Me.txtOrangeJuice = New System.Windows.Forms.TextBox()
        Me.lblpricecoke = New System.Windows.Forms.Label()
        Me.lblpricelemonade = New System.Windows.Forms.Label()
        Me.lblpricemountaindew = New System.Windows.Forms.Label()
        Me.lblPriceorangejuice = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectYourDrinks
        '
        Me.lblSelectYourDrinks.AutoSize = True
        Me.lblSelectYourDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectYourDrinks.Location = New System.Drawing.Point(165, 24)
        Me.lblSelectYourDrinks.Name = "lblSelectYourDrinks"
        Me.lblSelectYourDrinks.Size = New System.Drawing.Size(318, 29)
        Me.lblSelectYourDrinks.TabIndex = 0
        Me.lblSelectYourDrinks.Text = "Please Select Your Drinks"
        '
        'chkbxcoke
        '
        Me.chkbxcoke.AutoSize = True
        Me.chkbxcoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxcoke.Location = New System.Drawing.Point(12, 237)
        Me.chkbxcoke.Name = "chkbxcoke"
        Me.chkbxcoke.Size = New System.Drawing.Size(69, 24)
        Me.chkbxcoke.TabIndex = 1
        Me.chkbxcoke.Text = "Coke"
        Me.chkbxcoke.UseVisualStyleBackColor = True
        '
        'chkbxlemonade
        '
        Me.chkbxlemonade.AutoSize = True
        Me.chkbxlemonade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxlemonade.Location = New System.Drawing.Point(351, 237)
        Me.chkbxlemonade.Name = "chkbxlemonade"
        Me.chkbxlemonade.Size = New System.Drawing.Size(109, 24)
        Me.chkbxlemonade.TabIndex = 2
        Me.chkbxlemonade.Text = "Lemonade"
        Me.chkbxlemonade.UseVisualStyleBackColor = True
        '
        'ChkBxMountainDew
        '
        Me.ChkBxMountainDew.AutoSize = True
        Me.ChkBxMountainDew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxMountainDew.Location = New System.Drawing.Point(12, 455)
        Me.ChkBxMountainDew.Name = "ChkBxMountainDew"
        Me.ChkBxMountainDew.Size = New System.Drawing.Size(138, 24)
        Me.ChkBxMountainDew.TabIndex = 3
        Me.ChkBxMountainDew.Text = "Mountain Dew"
        Me.ChkBxMountainDew.UseVisualStyleBackColor = True
        '
        'ChkBxOrangeJuice
        '
        Me.ChkBxOrangeJuice.AutoSize = True
        Me.ChkBxOrangeJuice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBxOrangeJuice.Location = New System.Drawing.Point(351, 455)
        Me.ChkBxOrangeJuice.Name = "ChkBxOrangeJuice"
        Me.ChkBxOrangeJuice.Size = New System.Drawing.Size(131, 24)
        Me.ChkBxOrangeJuice.TabIndex = 4
        Me.ChkBxOrangeJuice.Text = "Orange Juice"
        Me.ChkBxOrangeJuice.UseVisualStyleBackColor = True
        '
        'txtCoke
        '
        Me.txtCoke.Enabled = False
        Me.txtCoke.Location = New System.Drawing.Point(233, 239)
        Me.txtCoke.Name = "txtCoke"
        Me.txtCoke.Size = New System.Drawing.Size(40, 22)
        Me.txtCoke.TabIndex = 5
        '
        'txtLemonade
        '
        Me.txtLemonade.Enabled = False
        Me.txtLemonade.Location = New System.Drawing.Point(576, 239)
        Me.txtLemonade.Name = "txtLemonade"
        Me.txtLemonade.Size = New System.Drawing.Size(40, 22)
        Me.txtLemonade.TabIndex = 6
        '
        'txtMountainDew
        '
        Me.txtMountainDew.Enabled = False
        Me.txtMountainDew.Location = New System.Drawing.Point(233, 457)
        Me.txtMountainDew.Name = "txtMountainDew"
        Me.txtMountainDew.Size = New System.Drawing.Size(40, 22)
        Me.txtMountainDew.TabIndex = 7
        '
        'txtOrangeJuice
        '
        Me.txtOrangeJuice.Enabled = False
        Me.txtOrangeJuice.Location = New System.Drawing.Point(576, 457)
        Me.txtOrangeJuice.Name = "txtOrangeJuice"
        Me.txtOrangeJuice.Size = New System.Drawing.Size(40, 22)
        Me.txtOrangeJuice.TabIndex = 8
        '
        'lblpricecoke
        '
        Me.lblpricecoke.AutoSize = True
        Me.lblpricecoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpricecoke.Location = New System.Drawing.Point(167, 239)
        Me.lblpricecoke.Name = "lblpricecoke"
        Me.lblpricecoke.Size = New System.Drawing.Size(49, 20)
        Me.lblpricecoke.TabIndex = 9
        Me.lblpricecoke.Text = "$2.99"
        '
        'lblpricelemonade
        '
        Me.lblpricelemonade.AutoSize = True
        Me.lblpricelemonade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpricelemonade.Location = New System.Drawing.Point(509, 239)
        Me.lblpricelemonade.Name = "lblpricelemonade"
        Me.lblpricelemonade.Size = New System.Drawing.Size(49, 20)
        Me.lblpricelemonade.TabIndex = 10
        Me.lblpricelemonade.Text = "$3.99"
        '
        'lblpricemountaindew
        '
        Me.lblpricemountaindew.AutoSize = True
        Me.lblpricemountaindew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpricemountaindew.Location = New System.Drawing.Point(166, 457)
        Me.lblpricemountaindew.Name = "lblpricemountaindew"
        Me.lblpricemountaindew.Size = New System.Drawing.Size(49, 20)
        Me.lblpricemountaindew.TabIndex = 11
        Me.lblpricemountaindew.Text = "$2.50"
        '
        'lblPriceorangejuice
        '
        Me.lblPriceorangejuice.AutoSize = True
        Me.lblPriceorangejuice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceorangejuice.Location = New System.Drawing.Point(509, 455)
        Me.lblPriceorangejuice.Name = "lblPriceorangejuice"
        Me.lblPriceorangejuice.Size = New System.Drawing.Size(49, 20)
        Me.lblPriceorangejuice.TabIndex = 12
        Me.lblPriceorangejuice.Text = "$4.99"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(245, 500)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(131, 38)
        Me.btnPlaceOrder.TabIndex = 13
        Me.btnPlaceOrder.Text = "Place order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WindowsApplication1.My.Resources.Resources.orangejuice
        Me.PictureBox5.Location = New System.Drawing.Point(410, 274)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 175)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.mountaindew
        Me.PictureBox4.Location = New System.Drawing.Point(83, 274)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 175)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.lemonade
        Me.PictureBox3.Location = New System.Drawing.Point(410, 56)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 175)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.coke
        Me.PictureBox2.Location = New System.Drawing.Point(47, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 175)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(106, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'frmDrinkPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(637, 543)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.lblPriceorangejuice)
        Me.Controls.Add(Me.lblpricemountaindew)
        Me.Controls.Add(Me.lblpricelemonade)
        Me.Controls.Add(Me.lblpricecoke)
        Me.Controls.Add(Me.txtOrangeJuice)
        Me.Controls.Add(Me.txtMountainDew)
        Me.Controls.Add(Me.txtLemonade)
        Me.Controls.Add(Me.txtCoke)
        Me.Controls.Add(Me.ChkBxOrangeJuice)
        Me.Controls.Add(Me.ChkBxMountainDew)
        Me.Controls.Add(Me.chkbxlemonade)
        Me.Controls.Add(Me.chkbxcoke)
        Me.Controls.Add(Me.lblSelectYourDrinks)
        Me.Name = "frmDrinkPage"
        Me.Text = "Cinema Ordering System"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectYourDrinks As System.Windows.Forms.Label
    Friend WithEvents chkbxcoke As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxlemonade As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBxMountainDew As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBxOrangeJuice As System.Windows.Forms.CheckBox
    Friend WithEvents txtCoke As System.Windows.Forms.TextBox
    Friend WithEvents txtLemonade As System.Windows.Forms.TextBox
    Friend WithEvents txtMountainDew As System.Windows.Forms.TextBox
    Friend WithEvents txtOrangeJuice As System.Windows.Forms.TextBox
    Friend WithEvents lblpricecoke As System.Windows.Forms.Label
    Friend WithEvents lblpricelemonade As System.Windows.Forms.Label
    Friend WithEvents lblpricemountaindew As System.Windows.Forms.Label
    Friend WithEvents lblPriceorangejuice As System.Windows.Forms.Label
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
