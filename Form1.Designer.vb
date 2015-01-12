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
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_acc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TLP1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.txt_d = New System.Windows.Forms.TextBox()
        Me.Scont_A = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Optimize = New System.Windows.Forms.Button()
        Me.tbpg_roots = New System.Windows.Forms.TabControl()
        Me.tbpg_solver = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_root2 = New System.Windows.Forms.TextBox()
        Me.txt_root1 = New System.Windows.Forms.TextBox()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_consta = New System.Windows.Forms.TextBox()
        Me.txt_constb = New System.Windows.Forms.TextBox()
        Me.txt_constc = New System.Windows.Forms.TextBox()
        Me.btn_Roots = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TLP1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.Scont_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_A.Panel1.SuspendLayout()
        Me.Scont_A.Panel2.SuspendLayout()
        Me.Scont_A.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tbpg_roots.SuspendLayout()
        Me.tbpg_solver.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Calculate.Location = New System.Drawing.Point(3, 3)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(162, 47)
        Me.btn_Calculate.TabIndex = 0
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'txt_c
        '
        Me.txt_c.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c.Location = New System.Drawing.Point(120, 0)
        Me.txt_c.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_c.Multiline = True
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(60, 28)
        Me.txt_c.TabIndex = 1
        Me.txt_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_result
        '
        Me.txt_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_result.Font = New System.Drawing.Font("Agency FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_result.Location = New System.Drawing.Point(85, 81)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.ReadOnly = True
        Me.txt_result.Size = New System.Drawing.Size(263, 21)
        Me.txt_result.TabIndex = 2
        Me.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 41)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Result :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_acc
        '
        Me.txt_acc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_acc.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acc.Location = New System.Drawing.Point(85, 42)
        Me.txt_acc.Name = "txt_acc"
        Me.txt_acc.Size = New System.Drawing.Size(263, 23)
        Me.txt_acc.TabIndex = 5
        Me.txt_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 39)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Accuracy:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TLP1
        '
        Me.TLP1.ColumnCount = 2
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP1.Controls.Add(Me.Label2, 0, 2)
        Me.TLP1.Controls.Add(Me.txt_result, 1, 2)
        Me.TLP1.Controls.Add(Me.txt_acc, 1, 1)
        Me.TLP1.Controls.Add(Me.Label4, 0, 1)
        Me.TLP1.Controls.Add(Me.Label5, 0, 0)
        Me.TLP1.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.TLP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP1.Location = New System.Drawing.Point(0, 0)
        Me.TLP1.Name = "TLP1"
        Me.TLP1.RowCount = 3
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP1.Size = New System.Drawing.Size(337, 119)
        Me.TLP1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 39)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "a ,b,c:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_a)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_b)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_c)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_d)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(85, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(263, 33)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'txt_a
        '
        Me.txt_a.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_a.Location = New System.Drawing.Point(0, 0)
        Me.txt_a.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_a.Multiline = True
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(60, 28)
        Me.txt_a.TabIndex = 11
        Me.txt_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_b
        '
        Me.txt_b.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_b.Location = New System.Drawing.Point(60, 0)
        Me.txt_b.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_b.Multiline = True
        Me.txt_b.Name = "txt_b"
        Me.txt_b.Size = New System.Drawing.Size(60, 28)
        Me.txt_b.TabIndex = 12
        Me.txt_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_d
        '
        Me.txt_d.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_d.Location = New System.Drawing.Point(180, 0)
        Me.txt_d.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_d.Multiline = True
        Me.txt_d.Name = "txt_d"
        Me.txt_d.Size = New System.Drawing.Size(60, 28)
        Me.txt_d.TabIndex = 13
        Me.txt_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Scont_A
        '
        Me.Scont_A.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scont_A.Location = New System.Drawing.Point(3, 3)
        Me.Scont_A.Name = "Scont_A"
        Me.Scont_A.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Scont_A.Panel1
        '
        Me.Scont_A.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'Scont_A.Panel2
        '
        Me.Scont_A.Panel2.Controls.Add(Me.TLP1)
        Me.Scont_A.Size = New System.Drawing.Size(337, 176)
        Me.Scont_A.SplitterDistance = 53
        Me.Scont_A.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Calculate, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Optimize, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(337, 53)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btn_Optimize
        '
        Me.btn_Optimize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Optimize.Location = New System.Drawing.Point(171, 3)
        Me.btn_Optimize.Name = "btn_Optimize"
        Me.btn_Optimize.Size = New System.Drawing.Size(163, 47)
        Me.btn_Optimize.TabIndex = 1
        Me.btn_Optimize.Text = "Load"
        Me.btn_Optimize.UseVisualStyleBackColor = True
        '
        'tbpg_roots
        '
        Me.tbpg_roots.Controls.Add(Me.tbpg_solver)
        Me.tbpg_roots.Controls.Add(Me.TabPage2)
        Me.tbpg_roots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbpg_roots.Location = New System.Drawing.Point(0, 0)
        Me.tbpg_roots.Name = "tbpg_roots"
        Me.tbpg_roots.SelectedIndex = 0
        Me.tbpg_roots.Size = New System.Drawing.Size(351, 208)
        Me.tbpg_roots.TabIndex = 11
        '
        'tbpg_solver
        '
        Me.tbpg_solver.Controls.Add(Me.Scont_A)
        Me.tbpg_solver.Location = New System.Drawing.Point(4, 22)
        Me.tbpg_solver.Name = "tbpg_solver"
        Me.tbpg_solver.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpg_solver.Size = New System.Drawing.Size(343, 182)
        Me.tbpg_solver.TabIndex = 0
        Me.tbpg_solver.Text = "Equation Solver"
        Me.tbpg_solver.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txt_root2)
        Me.TabPage2.Controls.Add(Me.txt_root1)
        Me.TabPage2.Controls.Add(Me.btn_Load)
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel2)
        Me.TabPage2.Controls.Add(Me.btn_Roots)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(343, 182)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Roots"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Root2 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Root1 :"
        '
        'txt_root2
        '
        Me.txt_root2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_root2.Location = New System.Drawing.Point(60, 140)
        Me.txt_root2.Name = "txt_root2"
        Me.txt_root2.ReadOnly = True
        Me.txt_root2.Size = New System.Drawing.Size(247, 22)
        Me.txt_root2.TabIndex = 14
        Me.txt_root2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_root1
        '
        Me.txt_root1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_root1.Location = New System.Drawing.Point(60, 118)
        Me.txt_root1.Name = "txt_root1"
        Me.txt_root1.ReadOnly = True
        Me.txt_root1.Size = New System.Drawing.Size(247, 22)
        Me.txt_root1.TabIndex = 13
        Me.txt_root1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Load
        '
        Me.btn_Load.Location = New System.Drawing.Point(169, 17)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(92, 52)
        Me.btn_Load.TabIndex = 12
        Me.btn_Load.Text = "Load"
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_consta)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_constb)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_constc)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(41, 84)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(266, 28)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'txt_consta
        '
        Me.txt_consta.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_consta.Location = New System.Drawing.Point(3, 3)
        Me.txt_consta.Name = "txt_consta"
        Me.txt_consta.Size = New System.Drawing.Size(80, 22)
        Me.txt_consta.TabIndex = 2
        Me.txt_consta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_constb
        '
        Me.txt_constb.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constb.Location = New System.Drawing.Point(89, 3)
        Me.txt_constb.Name = "txt_constb"
        Me.txt_constb.Size = New System.Drawing.Size(80, 22)
        Me.txt_constb.TabIndex = 3
        Me.txt_constb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_constc
        '
        Me.txt_constc.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constc.Location = New System.Drawing.Point(175, 3)
        Me.txt_constc.Name = "txt_constc"
        Me.txt_constc.Size = New System.Drawing.Size(80, 22)
        Me.txt_constc.TabIndex = 4
        Me.txt_constc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Roots
        '
        Me.btn_Roots.Location = New System.Drawing.Point(72, 17)
        Me.btn_Roots.Name = "btn_Roots"
        Me.btn_Roots.Size = New System.Drawing.Size(92, 52)
        Me.btn_Roots.TabIndex = 0
        Me.btn_Roots.Text = "Roots"
        Me.btn_Roots.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 52)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 208)
        Me.Controls.Add(Me.tbpg_roots)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TLP1.ResumeLayout(False)
        Me.TLP1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Scont_A.Panel1.ResumeLayout(False)
        Me.Scont_A.Panel2.ResumeLayout(False)
        CType(Me.Scont_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_A.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tbpg_roots.ResumeLayout(False)
        Me.tbpg_solver.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents txt_c As System.Windows.Forms.TextBox
    Friend WithEvents txt_result As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_acc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TLP1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Scont_A As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Optimize As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_a As System.Windows.Forms.TextBox
    Friend WithEvents txt_b As System.Windows.Forms.TextBox
    Friend WithEvents txt_d As System.Windows.Forms.TextBox
    Friend WithEvents tbpg_roots As System.Windows.Forms.TabControl
    Friend WithEvents tbpg_solver As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Roots As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_consta As System.Windows.Forms.TextBox
    Friend WithEvents txt_constb As System.Windows.Forms.TextBox
    Friend WithEvents txt_constc As System.Windows.Forms.TextBox
    Friend WithEvents btn_Load As System.Windows.Forms.Button
    Friend WithEvents txt_root1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_root2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
