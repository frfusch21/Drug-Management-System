﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Form))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_saveuser = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtg_listUser = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtg_listUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_delete.Location = New System.Drawing.Point(396, 251)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(167, 32)
        Me.btn_delete.TabIndex = 25
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(324, 71)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(372, 26)
        Me.txt_name.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(411, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 37)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Add New User"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(343, 71)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(23, 22)
        Me.lbl_id.TabIndex = 9
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'cbo_type
        '
        Me.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_type.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.cbo_type.Location = New System.Drawing.Point(324, 182)
        Me.cbo_type.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(372, 28)
        Me.cbo_type.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(248, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name :"
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(324, 145)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(372, 26)
        Me.txt_pass.TabIndex = 3
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_id)
        Me.Panel1.Controls.Add(Me.cbo_type)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_pass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_username)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 244)
        Me.Panel1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(213, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(248, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Type :"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(324, 108)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(372, 26)
        Me.txt_username.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(217, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password :"
        '
        'btn_saveuser
        '
        Me.btn_saveuser.BackColor = System.Drawing.Color.Transparent
        Me.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_saveuser.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_saveuser.Location = New System.Drawing.Point(12, 254)
        Me.btn_saveuser.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_saveuser.Name = "btn_saveuser"
        Me.btn_saveuser.Size = New System.Drawing.Size(184, 32)
        Me.btn_saveuser.TabIndex = 22
        Me.btn_saveuser.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.btn_saveuser, "Save Data")
        Me.btn_saveuser.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.Enabled = False
        Me.btn_update.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_update.Location = New System.Drawing.Point(204, 252)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(184, 32)
        Me.btn_update.TabIndex = 23
        Me.btn_update.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.btn_update, "Update")
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_New
        '
        Me.btn_New.BackColor = System.Drawing.Color.Transparent
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_New.Location = New System.Drawing.Point(571, 251)
        Me.btn_New.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(176, 32)
        Me.btn_New.TabIndex = 24
        Me.btn_New.Text = "New"
        Me.ToolTip1.SetToolTip(Me.btn_New, "New")
        Me.btn_New.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(755, 252)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 32)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.Button1, "Close")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.dtg_listUser)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 293)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 321)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Of User"
        '
        'dtg_listUser
        '
        Me.dtg_listUser.AllowUserToAddRows = False
        Me.dtg_listUser.AllowUserToDeleteRows = False
        Me.dtg_listUser.AllowUserToResizeColumns = False
        Me.dtg_listUser.AllowUserToResizeRows = False
        Me.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_listUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_listUser.Location = New System.Drawing.Point(4, 19)
        Me.dtg_listUser.Margin = New System.Windows.Forms.Padding(4)
        Me.dtg_listUser.Name = "dtg_listUser"
        Me.dtg_listUser.RowHeadersVisible = False
        Me.dtg_listUser.RowHeadersWidth = 51
        Me.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_listUser.Size = New System.Drawing.Size(1000, 298)
        Me.dtg_listUser.TabIndex = 0
        '
        'User_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 614)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_saveuser)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "User_Form"
        Me.Text = "User Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtg_listUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents cbo_type As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_saveuser As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtg_listUser As DataGridView
End Class
