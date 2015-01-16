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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TLP1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_arr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtxt_result = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Scont_A = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Optimize = New System.Windows.Forms.Button()
        Me.tbpg_roots = New System.Windows.Forms.TabControl()
        Me.tbpg_solver = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Roots = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_root1 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_consta = New System.Windows.Forms.TextBox()
        Me.txt_constb = New System.Windows.Forms.TextBox()
        Me.txt_constc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_root2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpg_polyval = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_polyvalarray = New System.Windows.Forms.TextBox()
        Me.txt_polyvalresult = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_polyvalvalue = New System.Windows.Forms.TextBox()
        Me.TLP1.SuspendLayout()
        CType(Me.Scont_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scont_A.Panel1.SuspendLayout()
        Me.Scont_A.Panel2.SuspendLayout()
        Me.Scont_A.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tbpg_roots.SuspendLayout()
        Me.tbpg_solver.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.tbpg_polyval.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Calculate.Location = New System.Drawing.Point(3, 3)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(148, 93)
        Me.btn_Calculate.TabIndex = 0
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 53)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Result :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TLP1
        '
        Me.TLP1.ColumnCount = 2
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.66667!))
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.33334!))
        Me.TLP1.Controls.Add(Me.txt_arr, 1, 0)
        Me.TLP1.Controls.Add(Me.Label2, 0, 1)
        Me.TLP1.Controls.Add(Me.Label5, 0, 0)
        Me.TLP1.Controls.Add(Me.rtxt_result, 1, 1)
        Me.TLP1.Controls.Add(Me.TextBox1, 1, 2)
        Me.TLP1.Controls.Add(Me.TextBox2, 0, 2)
        Me.TLP1.Controls.Add(Me.TextBox3, 0, 3)
        Me.TLP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP1.Location = New System.Drawing.Point(0, 0)
        Me.TLP1.Name = "TLP1"
        Me.TLP1.RowCount = 4
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.09091!))
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.90909!))
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP1.Size = New System.Drawing.Size(308, 123)
        Me.TLP1.TabIndex = 9
        '
        'txt_arr
        '
        Me.txt_arr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_arr.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_arr.Location = New System.Drawing.Point(88, 3)
        Me.txt_arr.Name = "txt_arr"
        Me.txt_arr.Size = New System.Drawing.Size(217, 22)
        Me.txt_arr.TabIndex = 12
        Me.txt_arr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_arr.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Array:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtxt_result
        '
        Me.rtxt_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxt_result.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxt_result.Location = New System.Drawing.Point(88, 24)
        Me.rtxt_result.Name = "rtxt_result"
        Me.rtxt_result.Size = New System.Drawing.Size(217, 47)
        Me.rtxt_result.TabIndex = 13
        Me.rtxt_result.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(3, 105)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(79, 20)
        Me.TextBox3.TabIndex = 16
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
        Me.Scont_A.Size = New System.Drawing.Size(308, 226)
        Me.Scont_A.SplitterDistance = 99
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(308, 99)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btn_Optimize
        '
        Me.btn_Optimize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Optimize.Location = New System.Drawing.Point(157, 3)
        Me.btn_Optimize.Name = "btn_Optimize"
        Me.btn_Optimize.Size = New System.Drawing.Size(148, 93)
        Me.btn_Optimize.TabIndex = 1
        Me.btn_Optimize.Text = "Load"
        Me.btn_Optimize.UseVisualStyleBackColor = True
        '
        'tbpg_roots
        '
        Me.tbpg_roots.Controls.Add(Me.tbpg_solver)
        Me.tbpg_roots.Controls.Add(Me.TabPage2)
        Me.tbpg_roots.Controls.Add(Me.tbpg_polyval)
        Me.tbpg_roots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbpg_roots.Location = New System.Drawing.Point(0, 0)
        Me.tbpg_roots.Name = "tbpg_roots"
        Me.tbpg_roots.SelectedIndex = 0
        Me.tbpg_roots.Size = New System.Drawing.Size(322, 258)
        Me.tbpg_roots.TabIndex = 11
        '
        'tbpg_solver
        '
        Me.tbpg_solver.Controls.Add(Me.Scont_A)
        Me.tbpg_solver.Location = New System.Drawing.Point(4, 22)
        Me.tbpg_solver.Name = "tbpg_solver"
        Me.tbpg_solver.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpg_solver.Size = New System.Drawing.Size(314, 232)
        Me.tbpg_solver.TabIndex = 0
        Me.tbpg_solver.Text = "Equation Solver"
        Me.tbpg_solver.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(314, 232)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Roots"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(308, 226)
        Me.SplitContainer1.SplitterDistance = 84
        Me.SplitContainer1.TabIndex = 18
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Roots, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Load, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(308, 84)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_Roots
        '
        Me.btn_Roots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Roots.Location = New System.Drawing.Point(3, 3)
        Me.btn_Roots.Name = "btn_Roots"
        Me.btn_Roots.Size = New System.Drawing.Size(96, 78)
        Me.btn_Roots.TabIndex = 0
        Me.btn_Roots.Text = "Roots"
        Me.btn_Roots.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(207, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 78)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Load
        '
        Me.btn_Load.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Load.Location = New System.Drawing.Point(105, 3)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(96, 78)
        Me.btn_Load.TabIndex = 12
        Me.btn_Load.Text = "Load"
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_root1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_root2, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(308, 138)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 46)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Equation :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_root1
        '
        Me.txt_root1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_root1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_root1.Location = New System.Drawing.Point(64, 49)
        Me.txt_root1.Multiline = True
        Me.txt_root1.Name = "txt_root1"
        Me.txt_root1.ReadOnly = True
        Me.txt_root1.Size = New System.Drawing.Size(241, 40)
        Me.txt_root1.TabIndex = 13
        Me.txt_root1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_consta)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_constb)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_constc)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(64, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(241, 40)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'txt_consta
        '
        Me.txt_consta.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_consta.Location = New System.Drawing.Point(3, 3)
        Me.txt_consta.Name = "txt_consta"
        Me.txt_consta.Size = New System.Drawing.Size(60, 22)
        Me.txt_consta.TabIndex = 2
        Me.txt_consta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_constb
        '
        Me.txt_constb.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constb.Location = New System.Drawing.Point(69, 3)
        Me.txt_constb.Name = "txt_constb"
        Me.txt_constb.Size = New System.Drawing.Size(60, 22)
        Me.txt_constb.TabIndex = 3
        Me.txt_constb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_constc
        '
        Me.txt_constc.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_constc.Location = New System.Drawing.Point(135, 3)
        Me.txt_constc.Name = "txt_constc"
        Me.txt_constc.Size = New System.Drawing.Size(60, 22)
        Me.txt_constc.TabIndex = 4
        Me.txt_constc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 46)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Root2 :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_root2
        '
        Me.txt_root2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_root2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_root2.Location = New System.Drawing.Point(64, 95)
        Me.txt_root2.Multiline = True
        Me.txt_root2.Name = "txt_root2"
        Me.txt_root2.ReadOnly = True
        Me.txt_root2.Size = New System.Drawing.Size(241, 40)
        Me.txt_root2.TabIndex = 14
        Me.txt_root2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 46)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Root1 :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbpg_polyval
        '
        Me.tbpg_polyval.Controls.Add(Me.TableLayoutPanel4)
        Me.tbpg_polyval.Location = New System.Drawing.Point(4, 22)
        Me.tbpg_polyval.Name = "tbpg_polyval"
        Me.tbpg_polyval.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpg_polyval.Size = New System.Drawing.Size(314, 232)
        Me.tbpg_polyval.TabIndex = 2
        Me.tbpg_polyval.Text = "PolyVal"
        Me.tbpg_polyval.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.06228!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.93772!))
        Me.TableLayoutPanel4.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_polyvalarray, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_polyvalresult, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(308, 226)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 69)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 75)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Equation :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 76)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Result"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_polyvalarray
        '
        Me.txt_polyvalarray.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_polyvalarray.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_polyvalarray.Location = New System.Drawing.Point(120, 78)
        Me.txt_polyvalarray.Multiline = True
        Me.txt_polyvalarray.Name = "txt_polyvalarray"
        Me.txt_polyvalarray.Size = New System.Drawing.Size(185, 69)
        Me.txt_polyvalarray.TabIndex = 3
        Me.txt_polyvalarray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_polyvalresult
        '
        Me.txt_polyvalresult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_polyvalresult.Location = New System.Drawing.Point(120, 153)
        Me.txt_polyvalresult.Multiline = True
        Me.txt_polyvalresult.Name = "txt_polyvalresult"
        Me.txt_polyvalresult.ReadOnly = True
        Me.txt_polyvalresult.Size = New System.Drawing.Size(185, 70)
        Me.txt_polyvalresult.TabIndex = 4
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.85714!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.14286!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_polyvalvalue, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(120, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(185, 69)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 69)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Value"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_polyvalvalue
        '
        Me.txt_polyvalvalue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_polyvalvalue.Location = New System.Drawing.Point(60, 3)
        Me.txt_polyvalvalue.Multiline = True
        Me.txt_polyvalvalue.Name = "txt_polyvalvalue"
        Me.txt_polyvalvalue.Size = New System.Drawing.Size(122, 63)
        Me.txt_polyvalvalue.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 258)
        Me.Controls.Add(Me.tbpg_roots)
        Me.Name = "Form1"
        Me.Text = "MathFunctions"
        Me.TLP1.ResumeLayout(False)
        Me.TLP1.PerformLayout()
        Me.Scont_A.Panel1.ResumeLayout(False)
        Me.Scont_A.Panel2.ResumeLayout(False)
        CType(Me.Scont_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scont_A.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tbpg_roots.ResumeLayout(False)
        Me.tbpg_solver.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.tbpg_polyval.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TLP1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Scont_A As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Optimize As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents txt_arr As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbpg_polyval As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_polyvalarray As System.Windows.Forms.TextBox
    Friend WithEvents txt_polyvalresult As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_polyvalvalue As System.Windows.Forms.TextBox
    Friend WithEvents rtxt_result As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
