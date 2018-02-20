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
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btn20Random = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstResults
        '
        Me.lstResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(0, 0)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(158, 433)
        Me.lstResults.TabIndex = 0
        '
        'btn20Random
        '
        Me.btn20Random.Location = New System.Drawing.Point(388, 68)
        Me.btn20Random.Name = "btn20Random"
        Me.btn20Random.Size = New System.Drawing.Size(75, 23)
        Me.btn20Random.TabIndex = 1
        Me.btn20Random.Text = "20 Random"
        Me.btn20Random.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 434)
        Me.Controls.Add(Me.btn20Random)
        Me.Controls.Add(Me.lstResults)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstResults As ListBox
    Friend WithEvents btn20Random As Button
End Class
