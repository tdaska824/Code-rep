<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.SerialDataLabel = New System.Windows.Forms.Label()
        Me.ReceivedPacketLabel = New System.Windows.Forms.Label()
        Me.ShowPacketButton = New System.Windows.Forms.Button()
        Me.HidePacketButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialDataLabel
        '
        Me.SerialDataLabel.AutoSize = True
        Me.SerialDataLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.SerialDataLabel.Location = New System.Drawing.Point(0, 0)
        Me.SerialDataLabel.Name = "SerialDataLabel"
        Me.SerialDataLabel.Size = New System.Drawing.Size(61, 16)
        Me.SerialDataLabel.TabIndex = 0
        Me.SerialDataLabel.Text = "SerialData"
        '
        'ReceivedPacketLabel
        '
        Me.ReceivedPacketLabel.AutoSize = True
        Me.ReceivedPacketLabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ReceivedPacketLabel.Location = New System.Drawing.Point(172, 0)
        Me.ReceivedPacketLabel.Name = "ReceivedPacketLabel"
        Me.ReceivedPacketLabel.Size = New System.Drawing.Size(90, 16)
        Me.ReceivedPacketLabel.TabIndex = 1
        Me.ReceivedPacketLabel.Text = "ReceivedPacket"
        '
        'ShowPacketButton
        '
        Me.ShowPacketButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ShowPacketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowPacketButton.Image = CType(resources.GetObject("ShowPacketButton.Image"), System.Drawing.Image)
        Me.ShowPacketButton.Location = New System.Drawing.Point(134, 0)
        Me.ShowPacketButton.Name = "ShowPacketButton"
        Me.ShowPacketButton.Size = New System.Drawing.Size(32, 23)
        Me.ShowPacketButton.TabIndex = 2
        Me.ShowPacketButton.UseVisualStyleBackColor = True
        '
        'HidePacketButton
        '
        Me.HidePacketButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.HidePacketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HidePacketButton.Image = CType(resources.GetObject("HidePacketButton.Image"), System.Drawing.Image)
        Me.HidePacketButton.Location = New System.Drawing.Point(134, 0)
        Me.HidePacketButton.Name = "HidePacketButton"
        Me.HidePacketButton.Size = New System.Drawing.Size(32, 23)
        Me.HidePacketButton.TabIndex = 3
        Me.HidePacketButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(334, 165)
        Me.Controls.Add(Me.HidePacketButton)
        Me.Controls.Add(Me.ReceivedPacketLabel)
        Me.Controls.Add(Me.SerialDataLabel)
        Me.Controls.Add(Me.ShowPacketButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialDataLabel As Label
    Friend WithEvents ReceivedPacketLabel As Label
    Friend WithEvents ShowPacketButton As Button
    Friend WithEvents HidePacketButton As Button
End Class
