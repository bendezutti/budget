<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtHousing = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransportation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFood = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHousing
        '
        Me.txtHousing.Location = New System.Drawing.Point(172, 49)
        Me.txtHousing.Name = "txtHousing"
        Me.txtHousing.Size = New System.Drawing.Size(100, 26)
        Me.txtHousing.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Housing:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transportation:"
        '
        'txtTransportation
        '
        Me.txtTransportation.Location = New System.Drawing.Point(172, 99)
        Me.txtTransportation.Name = "txtTransportation"
        Me.txtTransportation.Size = New System.Drawing.Size(100, 26)
        Me.txtTransportation.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Food:"
        '
        'txtFood
        '
        Me.txtFood.Location = New System.Drawing.Point(475, 49)
        Me.txtFood.Name = "txtFood"
        Me.txtFood.Size = New System.Drawing.Size(100, 26)
        Me.txtFood.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(419, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Other:"
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(475, 102)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(100, 26)
        Me.txtOther.TabIndex = 7
        '
        'picBox
        '
        Me.picBox.Location = New System.Drawing.Point(70, 134)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(601, 292)
        Me.picBox.TabIndex = 8
        Me.picBox.TabStop = False
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(625, 52)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(105, 70)
        Me.btnDisplay.TabIndex = 9
        Me.btnDisplay.Text = "Display Chart"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.txtOther)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFood)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTransportation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHousing)
        Me.Name = "Form1"
        Me.Text = "Budget"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHousing As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTransportation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFood As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOther As TextBox
    Friend WithEvents picBox As PictureBox
    Friend WithEvents btnDisplay As Button
End Class
