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
        t1 = New TextBox()
        t3 = New TextBox()
        t2 = New TextBox()
        l1 = New Label()
        l2 = New Label()
        b3 = New Button()
        b2 = New Button()
        b1 = New Button()
        SuspendLayout()
        ' 
        ' t1
        ' 
        t1.Font = New Font("Segoe UI", 14F)
        t1.Location = New Point(359, 100)
        t1.Name = "t1"
        t1.Size = New Size(216, 39)
        t1.TabIndex = 0
        t1.TextAlign = HorizontalAlignment.Center
        ' 
        ' t3
        ' 
        t3.Font = New Font("Segoe UI", 14F)
        t3.Location = New Point(359, 222)
        t3.Name = "t3"
        t3.Size = New Size(216, 39)
        t3.TabIndex = 2
        t3.TextAlign = HorizontalAlignment.Center
        ' 
        ' t2
        ' 
        t2.Font = New Font("Segoe UI", 14F)
        t2.Location = New Point(359, 160)
        t2.Name = "t2"
        t2.Size = New Size(216, 39)
        t2.TabIndex = 3
        t2.TextAlign = HorizontalAlignment.Center
        ' 
        ' l1
        ' 
        l1.Location = New Point(353, 308)
        l1.Name = "l1"
        l1.Size = New Size(222, 50)
        l1.TabIndex = 5
        l1.Text = "Label1"
        l1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' l2
        ' 
        l2.Location = New Point(353, 367)
        l2.Name = "l2"
        l2.Size = New Size(222, 50)
        l2.TabIndex = 6
        l2.Text = "Label1"
        l2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' b3
        ' 
        b3.Font = New Font("Segoe UI", 14F)
        b3.Location = New Point(105, 495)
        b3.Name = "b3"
        b3.Size = New Size(182, 60)
        b3.TabIndex = 7
        b3.Text = "Recommencer"
        b3.UseVisualStyleBackColor = True
        ' 
        ' b2
        ' 
        b2.Font = New Font("Segoe UI", 14F)
        b2.Location = New Point(600, 495)
        b2.Name = "b2"
        b2.Size = New Size(182, 60)
        b2.TabIndex = 8
        b2.Text = "Button1"
        b2.UseVisualStyleBackColor = True
        ' 
        ' b1
        ' 
        b1.Font = New Font("Segoe UI", 14F)
        b1.Location = New Point(359, 495)
        b1.Name = "b1"
        b1.Size = New Size(182, 60)
        b1.TabIndex = 9
        b1.Text = "VALIDER"
        b1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(979, 591)
        Controls.Add(b1)
        Controls.Add(b2)
        Controls.Add(b3)
        Controls.Add(l2)
        Controls.Add(l1)
        Controls.Add(t2)
        Controls.Add(t3)
        Controls.Add(t1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents t1 As TextBox
    Friend WithEvents t3 As TextBox
    Friend WithEvents t2 As TextBox
    Friend WithEvents L2 As Label
    Friend WithEvents l1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents b3 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button

End Class
