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
        components = New ComponentModel.Container()
        tmrLift = New Timer(components)
        Panel2 = New Panel()
        Label2 = New Label()
        lblPending = New Label()
        btnDoorClose = New Button()
        btnDoorOpen = New Button()
        btnFloor4 = New Button()
        btnFloor3 = New Button()
        btnFloor2 = New Button()
        btnFloor1 = New Button()
        Panel3 = New Panel()
        Panel8 = New Panel()
        lblCurrent = New Label()
        Label1 = New Label()
        lblDoorState = New Label()
        lblState = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel4 = New Panel()
        Panel11 = New Panel()
        Panel9 = New Panel()
        panelLift = New Panel()
        panelLeftDoor = New Panel()
        panelRightDoor = New Panel()
        btnCallUp1 = New Button()
        btnCallUp2 = New Button()
        btnCallUp3 = New Button()
        btnCallDown2 = New Button()
        btnCallDown3 = New Button()
        btnCallDown4 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel10 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        Panel4.SuspendLayout()
        panelLift.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tmrLift
        ' 
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lblPending)
        Panel2.Controls.Add(btnDoorClose)
        Panel2.Controls.Add(btnDoorOpen)
        Panel2.Controls.Add(btnFloor4)
        Panel2.Controls.Add(btnFloor3)
        Panel2.Controls.Add(btnFloor2)
        Panel2.Controls.Add(btnFloor1)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(685, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 469)
        Panel2.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(29, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 25)
        Label2.TabIndex = 7
        Label2.Text = "SELECT FLOOR"
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Segoe UI", 10.0F)
        lblPending.ForeColor = Color.Black
        lblPending.Location = New Point(203, 153)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(49, 19)
        lblPending.TabIndex = 3
        lblPending.Text = "Label1"
        ' 
        ' btnDoorClose
        ' 
        btnDoorClose.BackColor = Color.DarkRed
        btnDoorClose.Font = New Font("Segoe UI", 11.0F)
        btnDoorClose.ForeColor = Color.Transparent
        btnDoorClose.Location = New Point(102, 388)
        btnDoorClose.Name = "btnDoorClose"
        btnDoorClose.Size = New Size(85, 41)
        btnDoorClose.TabIndex = 6
        btnDoorClose.Text = "Close"
        btnDoorClose.UseVisualStyleBackColor = False
        ' 
        ' btnDoorOpen
        ' 
        btnDoorOpen.BackColor = Color.Lime
        btnDoorOpen.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnDoorOpen.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnDoorOpen.Location = New Point(14, 388)
        btnDoorOpen.Name = "btnDoorOpen"
        btnDoorOpen.Size = New Size(82, 41)
        btnDoorOpen.TabIndex = 5
        btnDoorOpen.Text = "Open"
        btnDoorOpen.UseVisualStyleBackColor = False
        ' 
        ' btnFloor4
        ' 
        btnFloor4.BackColor = Color.Gray
        btnFloor4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnFloor4.ForeColor = Color.White
        btnFloor4.Location = New Point(14, 263)
        btnFloor4.Name = "btnFloor4"
        btnFloor4.Size = New Size(82, 48)
        btnFloor4.TabIndex = 4
        btnFloor4.Text = "4"
        btnFloor4.UseVisualStyleBackColor = False
        ' 
        ' btnFloor3
        ' 
        btnFloor3.BackColor = Color.Gray
        btnFloor3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnFloor3.ForeColor = Color.White
        btnFloor3.Location = New Point(102, 263)
        btnFloor3.Name = "btnFloor3"
        btnFloor3.Size = New Size(85, 48)
        btnFloor3.TabIndex = 3
        btnFloor3.Text = "3"
        btnFloor3.UseVisualStyleBackColor = False
        ' 
        ' btnFloor2
        ' 
        btnFloor2.BackColor = Color.Gray
        btnFloor2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnFloor2.ForeColor = Color.White
        btnFloor2.Location = New Point(14, 317)
        btnFloor2.Name = "btnFloor2"
        btnFloor2.Size = New Size(85, 48)
        btnFloor2.TabIndex = 2
        btnFloor2.Text = "2"
        btnFloor2.UseVisualStyleBackColor = False
        ' 
        ' btnFloor1
        ' 
        btnFloor1.BackColor = Color.Gray
        btnFloor1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnFloor1.ForeColor = Color.White
        btnFloor1.Location = New Point(102, 317)
        btnFloor1.Name = "btnFloor1"
        btnFloor1.Size = New Size(85, 48)
        btnFloor1.TabIndex = 1
        btnFloor1.Text = "1"
        btnFloor1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Navy
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(lblDoorState)
        Panel3.Controls.Add(lblState)
        Panel3.ForeColor = Color.Transparent
        Panel3.Location = New Point(3, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(194, 185)
        Panel3.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Black
        Panel8.Controls.Add(lblCurrent)
        Panel8.Location = New Point(0, 56)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(194, 48)
        Panel8.TabIndex = 4
        ' 
        ' lblCurrent
        ' 
        lblCurrent.AutoSize = True
        lblCurrent.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblCurrent.ForeColor = Color.Lime
        lblCurrent.Location = New Point(58, 8)
        lblCurrent.Name = "lblCurrent"
        lblCurrent.Size = New Size(67, 25)
        lblCurrent.TabIndex = 0
        lblCurrent.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(11, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 25)
        Label1.TabIndex = 3
        Label1.Text = "SMART ELEVATOR"
        ' 
        ' lblDoorState
        ' 
        lblDoorState.AutoSize = True
        lblDoorState.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblDoorState.ForeColor = Color.White
        lblDoorState.Location = New Point(43, 151)
        lblDoorState.Name = "lblDoorState"
        lblDoorState.Size = New Size(53, 19)
        lblDoorState.TabIndex = 2
        lblDoorState.Text = "Label1"
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblState.ForeColor = Color.White
        lblState.Location = New Point(43, 118)
        lblState.Name = "lblState"
        lblState.Size = New Size(53, 19)
        lblState.TabIndex = 1
        lblState.Text = "Label1"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Location = New Point(0, 350)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(687, 10)
        Panel5.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Location = New Point(0, 241)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(687, 10)
        Panel6.TabIndex = 3
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Location = New Point(0, 119)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(687, 10)
        Panel7.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Controls.Add(Panel11)
        Panel4.Controls.Add(Panel9)
        Panel4.Controls.Add(panelLift)
        Panel4.Location = New Point(357, 8)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(234, 454)
        Panel4.TabIndex = 1
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Location = New Point(0, 0)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(247, 10)
        Panel11.TabIndex = 2
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(10, 461)
        Panel9.TabIndex = 1
        ' 
        ' panelLift
        ' 
        panelLift.BackColor = Color.MediumAquamarine
        panelLift.Controls.Add(panelLeftDoor)
        panelLift.Controls.Add(panelRightDoor)
        panelLift.Location = New Point(14, 351)
        panelLift.Name = "panelLift"
        panelLift.Size = New Size(200, 100)
        panelLift.TabIndex = 0
        ' 
        ' panelLeftDoor
        ' 
        panelLeftDoor.BackColor = Color.Turquoise
        panelLeftDoor.Location = New Point(0, 0)
        panelLeftDoor.Name = "panelLeftDoor"
        panelLeftDoor.Size = New Size(105, 100)
        panelLeftDoor.TabIndex = 1
        ' 
        ' panelRightDoor
        ' 
        panelRightDoor.BackColor = Color.LightSeaGreen
        panelRightDoor.Location = New Point(99, 0)
        panelRightDoor.Name = "panelRightDoor"
        panelRightDoor.Size = New Size(101, 103)
        panelRightDoor.TabIndex = 1
        ' 
        ' btnCallUp1
        ' 
        btnCallUp1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnCallUp1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnCallUp1.Location = New Point(639, 388)
        btnCallUp1.Name = "btnCallUp1"
        btnCallUp1.Size = New Size(28, 28)
        btnCallUp1.TabIndex = 5
        btnCallUp1.Text = "▲"
        btnCallUp1.UseVisualStyleBackColor = False
        ' 
        ' btnCallUp2
        ' 
        btnCallUp2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnCallUp2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnCallUp2.Location = New Point(639, 268)
        btnCallUp2.Name = "btnCallUp2"
        btnCallUp2.Size = New Size(28, 27)
        btnCallUp2.TabIndex = 6
        btnCallUp2.Text = "▲"
        btnCallUp2.UseVisualStyleBackColor = False
        ' 
        ' btnCallUp3
        ' 
        btnCallUp3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnCallUp3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnCallUp3.Location = New Point(639, 145)
        btnCallUp3.Name = "btnCallUp3"
        btnCallUp3.Size = New Size(28, 27)
        btnCallUp3.TabIndex = 7
        btnCallUp3.Text = "▲"
        btnCallUp3.UseVisualStyleBackColor = False
        ' 
        ' btnCallDown2
        ' 
        btnCallDown2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnCallDown2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnCallDown2.Location = New Point(639, 312)
        btnCallDown2.Name = "btnCallDown2"
        btnCallDown2.Size = New Size(28, 27)
        btnCallDown2.TabIndex = 8
        btnCallDown2.Text = "▼"
        btnCallDown2.UseVisualStyleBackColor = False
        ' 
        ' btnCallDown3
        ' 
        btnCallDown3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnCallDown3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnCallDown3.Location = New Point(639, 189)
        btnCallDown3.Name = "btnCallDown3"
        btnCallDown3.Size = New Size(28, 27)
        btnCallDown3.TabIndex = 9
        btnCallDown3.Text = "▼"
        btnCallDown3.UseVisualStyleBackColor = False
        ' 
        ' btnCallDown4
        ' 
        btnCallDown4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnCallDown4.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnCallDown4.Location = New Point(639, 77)
        btnCallDown4.Name = "btnCallDown4"
        btnCallDown4.Size = New Size(28, 28)
        btnCallDown4.TabIndex = 10
        btnCallDown4.Text = "▼"
        btnCallDown4.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(94, 384)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 54)
        Label3.TabIndex = 11
        Label3.Text = "1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(94, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 54)
        Label4.TabIndex = 12
        Label4.Text = "2"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnCallDown4)
        Panel1.Controls.Add(btnCallDown3)
        Panel1.Controls.Add(btnCallDown2)
        Panel1.Controls.Add(btnCallUp3)
        Panel1.Controls.Add(btnCallUp2)
        Panel1.Controls.Add(btnCallUp1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(888, 462)
        Panel1.TabIndex = 0
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Location = New Point(581, 8)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(10, 461)
        Panel10.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(94, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 54)
        Label6.TabIndex = 14
        Label6.Text = "4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(94, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 54)
        Label5.TabIndex = 13
        Label5.Text = "3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 461)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel4.ResumeLayout(False)
        panelLift.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents tmrLift As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents btnDoorClose As Button
    Friend WithEvents btnDoorOpen As Button
    Friend WithEvents btnFloor4 As Button
    Friend WithEvents btnFloor3 As Button
    Friend WithEvents btnFloor2 As Button
    Friend WithEvents btnFloor1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblCurrent As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDoorState As Label
    Friend WithEvents lblState As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents panelLift As Panel
    Friend WithEvents panelLeftDoor As Panel
    Friend WithEvents panelRightDoor As Panel
    Friend WithEvents btnCallUp1 As Button
    Friend WithEvents btnCallUp2 As Button
    Friend WithEvents btnCallUp3 As Button
    Friend WithEvents btnCallDown2 As Button
    Friend WithEvents btnCallDown3 As Button
    Friend WithEvents btnCallDown4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label

End Class
