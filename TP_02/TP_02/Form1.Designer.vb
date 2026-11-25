<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        b1 = New Button()
        b2 = New Button()
        b3 = New Button()
        t1 = New TextBox()
        t2 = New TextBox()
        t3 = New TextBox()
        t4 = New TextBox()
        l1 = New Label()
        l2 = New Label()
        l3 = New Label()
        b4 = New Button()
        SuspendLayout()
        ' 
        ' b1
        ' 
        b1.Location = New Point(310, 508)
        b1.Name = "b1"
        b1.Size = New Size(167, 89)
        b1.TabIndex = 0
        b1.Text = "Button1"
        b1.UseVisualStyleBackColor = True
        ' 
        ' b2
        ' 
        b2.Location = New Point(483, 508)
        b2.Name = "b2"
        b2.Size = New Size(182, 89)
        b2.TabIndex = 1
        b2.Text = "Button2"
        b2.UseVisualStyleBackColor = True
        ' 
        ' b3
        ' 
        b3.Location = New Point(682, 508)
        b3.Name = "b3"
        b3.Size = New Size(194, 89)
        b3.TabIndex = 2
        b3.Text = "Button3"
        b3.UseVisualStyleBackColor = True
        ' 
        ' t1
        ' 
        t1.Location = New Point(236, 312)
        t1.Name = "t1"
        t1.Size = New Size(191, 27)
        t1.TabIndex = 3
        ' 
        ' t2
        ' 
        t2.Location = New Point(236, 354)
        t2.Name = "t2"
        t2.Size = New Size(191, 27)
        t2.TabIndex = 4
        ' 
        ' t3
        ' 
        t3.Location = New Point(455, 312)
        t3.Name = "t3"
        t3.Size = New Size(191, 27)
        t3.TabIndex = 5
        ' 
        ' t4
        ' 
        t4.Location = New Point(455, 354)
        t4.Name = "t4"
        t4.Size = New Size(191, 27)
        t4.TabIndex = 6
        ' 
        ' l1
        ' 
        l1.AutoSize = True
        l1.Location = New Point(267, 146)
        l1.Name = "l1"
        l1.Size = New Size(53, 20)
        l1.TabIndex = 7
        l1.Text = "Label1"
        ' 
        ' l2
        ' 
        l2.AutoSize = True
        l2.Location = New Point(384, 146)
        l2.Name = "l2"
        l2.Size = New Size(53, 20)
        l2.TabIndex = 8
        l2.Text = "Label2"
        ' 
        ' l3
        ' 
        l3.AutoSize = True
        l3.Location = New Point(547, 150)
        l3.Name = "l3"
        l3.Size = New Size(53, 20)
        l3.TabIndex = 9
        l3.Text = "Label3"
        ' 
        ' b4
        ' 
        b4.Location = New Point(27, 245)
        b4.Name = "b4"
        b4.Size = New Size(125, 68)
        b4.TabIndex = 10
        b4.Text = "Button4"
        b4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(898, 623)
        Controls.Add(b4)
        Controls.Add(l3)
        Controls.Add(l2)
        Controls.Add(l1)
        Controls.Add(t4)
        Controls.Add(t3)
        Controls.Add(t2)
        Controls.Add(t1)
        Controls.Add(b3)
        Controls.Add(b2)
        Controls.Add(b1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents t1 As TextBox
    Friend WithEvents t2 As TextBox
    Friend WithEvents t3 As TextBox
    Friend WithEvents t4 As TextBox
    Friend WithEvents l1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents l3 As Label
    Friend WithEvents b4 As Button

End Class
