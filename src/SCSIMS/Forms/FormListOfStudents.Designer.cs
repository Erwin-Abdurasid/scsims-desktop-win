namespace SCSIMS.Forms;

partial class FormListOfStudents
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        splitMain = new SplitContainer();
        panelFilter = new Panel();
        panelFilterBody = new Panel();
        comboCourse = new ComboBox();
        label1 = new Label();
        dateBDate = new DateTimePicker();
        lblCourse = new Label();
        lblFName = new Label();
        comboYrLvl = new ComboBox();
        lblLName = new Label();
        txtEName = new TextBox();
        lblYrLvl = new Label();
        txtLName = new TextBox();
        txtFName = new TextBox();
        lblEName = new Label();
        comboGender = new ComboBox();
        lblMName = new Label();
        txtMName = new TextBox();
        lblGender = new Label();
        panelFilterBottom = new Panel();
        btnSubmit = new Button();
        panelFilterTop = new Panel();
        lblFilterBox = new Label();
        lblFilterExit = new Label();
        flowData = new FlowLayoutPanel();
        panel3 = new Panel();
        checkForce = new CheckBox();
        btnRefresh = new Button();
        panel1 = new Panel();
        checkSelectAll = new CheckBox();
        btnOpt = new Button();
        checkSelect = new CheckBox();
        panelSITop = new Panel();
        label2 = new Label();
        menuListOfStudents = new MenuStrip();
        viewToolStripMenuItem = new ToolStripMenuItem();
        filterToolStripMenuItem = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        panelFilter.SuspendLayout();
        panelFilterBody.SuspendLayout();
        panelFilterBottom.SuspendLayout();
        panelFilterTop.SuspendLayout();
        panel3.SuspendLayout();
        panel1.SuspendLayout();
        panelSITop.SuspendLayout();
        menuListOfStudents.SuspendLayout();
        SuspendLayout();
        // 
        // splitMain
        // 
        splitMain.BackColor = Color.Transparent;
        splitMain.Dock = DockStyle.Fill;
        splitMain.ForeColor = SystemColors.ActiveCaptionText;
        splitMain.Location = new Point(0, 29);
        splitMain.Name = "splitMain";
        // 
        // splitMain.Panel1
        // 
        splitMain.Panel1.Controls.Add(panelFilter);
        splitMain.Panel1MinSize = 20;
        // 
        // splitMain.Panel2
        // 
        splitMain.Panel2.Controls.Add(flowData);
        splitMain.Panel2.Controls.Add(panel3);
        splitMain.Panel2.Controls.Add(panel1);
        splitMain.Panel2.Controls.Add(panelSITop);
        splitMain.Panel2MinSize = 20;
        splitMain.Size = new Size(1337, 687);
        splitMain.SplitterDistance = 250;
        splitMain.SplitterWidth = 1;
        splitMain.TabIndex = 1;
        // 
        // panelFilter
        // 
        panelFilter.BackColor = Color.FromArgb(192, 255, 255);
        panelFilter.BorderStyle = BorderStyle.FixedSingle;
        panelFilter.Controls.Add(panelFilterBody);
        panelFilter.Controls.Add(panelFilterBottom);
        panelFilter.Controls.Add(panelFilterTop);
        panelFilter.Dock = DockStyle.Fill;
        panelFilter.Enabled = false;
        panelFilter.Location = new Point(0, 0);
        panelFilter.Name = "panelFilter";
        panelFilter.Size = new Size(250, 687);
        panelFilter.TabIndex = 0;
        panelFilter.Visible = false;
        // 
        // panelFilterBody
        // 
        panelFilterBody.Controls.Add(comboCourse);
        panelFilterBody.Controls.Add(label1);
        panelFilterBody.Controls.Add(dateBDate);
        panelFilterBody.Controls.Add(lblCourse);
        panelFilterBody.Controls.Add(lblFName);
        panelFilterBody.Controls.Add(comboYrLvl);
        panelFilterBody.Controls.Add(lblLName);
        panelFilterBody.Controls.Add(txtEName);
        panelFilterBody.Controls.Add(lblYrLvl);
        panelFilterBody.Controls.Add(txtLName);
        panelFilterBody.Controls.Add(txtFName);
        panelFilterBody.Controls.Add(lblEName);
        panelFilterBody.Controls.Add(comboGender);
        panelFilterBody.Controls.Add(lblMName);
        panelFilterBody.Controls.Add(txtMName);
        panelFilterBody.Controls.Add(lblGender);
        panelFilterBody.Dock = DockStyle.Fill;
        panelFilterBody.Location = new Point(0, 20);
        panelFilterBody.Name = "panelFilterBody";
        panelFilterBody.Size = new Size(248, 605);
        panelFilterBody.TabIndex = 14;
        // 
        // comboCourse
        // 
        comboCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboCourse.DropDownHeight = 250;
        comboCourse.DropDownWidth = 400;
        comboCourse.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        comboCourse.FormattingEnabled = true;
        comboCourse.IntegralHeight = false;
        comboCourse.Location = new Point(11, 283);
        comboCourse.MaxLength = 100;
        comboCourse.Name = "comboCourse";
        comboCourse.Size = new Size(221, 25);
        comboCourse.TabIndex = 4;
        comboCourse.KeyDown += Controls_KeyDown;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(11, 444);
        label1.Name = "label1";
        label1.Size = new Size(85, 19);
        label1.TabIndex = 6;
        label1.Text = "Date Enrolled";
        // 
        // dateBDate
        // 
        dateBDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dateBDate.CustomFormat = " ";
        dateBDate.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        dateBDate.Format = DateTimePickerFormat.Custom;
        dateBDate.Location = new Point(11, 465);
        dateBDate.Margin = new Padding(3, 2, 3, 2);
        dateBDate.Name = "dateBDate";
        dateBDate.Size = new Size(221, 26);
        dateBDate.TabIndex = 7;
        dateBDate.ValueChanged += dateBDate_ValueChanged;
        dateBDate.KeyDown += Controls_KeyDown;
        // 
        // lblCourse
        // 
        lblCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblCourse.AutoSize = true;
        lblCourse.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        lblCourse.Location = new Point(11, 261);
        lblCourse.Name = "lblCourse";
        lblCourse.Size = new Size(47, 19);
        lblCourse.TabIndex = 8;
        lblCourse.Text = "Course";
        // 
        // lblFName
        // 
        lblFName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblFName.AutoSize = true;
        lblFName.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        lblFName.Location = new Point(11, 11);
        lblFName.Name = "lblFName";
        lblFName.Size = new Size(71, 19);
        lblFName.TabIndex = 0;
        lblFName.Text = "First Name";
        // 
        // comboYrLvl
        // 
        comboYrLvl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboYrLvl.DropDownHeight = 250;
        comboYrLvl.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        comboYrLvl.FormattingEnabled = true;
        comboYrLvl.IntegralHeight = false;
        comboYrLvl.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "Graduated" });
        comboYrLvl.Location = new Point(11, 405);
        comboYrLvl.MaxLength = 100;
        comboYrLvl.Name = "comboYrLvl";
        comboYrLvl.Size = new Size(221, 25);
        comboYrLvl.TabIndex = 6;
        comboYrLvl.KeyDown += Controls_KeyDown;
        // 
        // lblLName
        // 
        lblLName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblLName.AutoSize = true;
        lblLName.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        lblLName.Location = new Point(11, 131);
        lblLName.Name = "lblLName";
        lblLName.Size = new Size(68, 19);
        lblLName.TabIndex = 2;
        lblLName.Text = "Last Name";
        // 
        // txtEName
        // 
        txtEName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtEName.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        txtEName.Location = new Point(11, 217);
        txtEName.Margin = new Padding(3, 2, 3, 2);
        txtEName.MaxLength = 100;
        txtEName.Name = "txtEName";
        txtEName.Size = new Size(221, 26);
        txtEName.TabIndex = 3;
        txtEName.KeyDown += Controls_KeyDown;
        // 
        // lblYrLvl
        // 
        lblYrLvl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblYrLvl.AutoSize = true;
        lblYrLvl.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        lblYrLvl.Location = new Point(11, 383);
        lblYrLvl.Name = "lblYrLvl";
        lblYrLvl.Size = new Size(66, 19);
        lblYrLvl.TabIndex = 5;
        lblYrLvl.Text = "Year Level";
        // 
        // txtLName
        // 
        txtLName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtLName.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        txtLName.Location = new Point(11, 154);
        txtLName.Margin = new Padding(3, 2, 3, 2);
        txtLName.MaxLength = 100;
        txtLName.Name = "txtLName";
        txtLName.Size = new Size(221, 26);
        txtLName.TabIndex = 2;
        txtLName.KeyDown += Controls_KeyDown;
        // 
        // txtFName
        // 
        txtFName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtFName.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        txtFName.Location = new Point(11, 34);
        txtFName.Margin = new Padding(3, 2, 3, 2);
        txtFName.MaxLength = 100;
        txtFName.Name = "txtFName";
        txtFName.Size = new Size(221, 26);
        txtFName.TabIndex = 0;
        txtFName.KeyDown += Controls_KeyDown;
        // 
        // lblEName
        // 
        lblEName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblEName.AutoSize = true;
        lblEName.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        lblEName.Location = new Point(11, 194);
        lblEName.Name = "lblEName";
        lblEName.Size = new Size(67, 19);
        lblEName.TabIndex = 3;
        lblEName.Text = "Ext. Name";
        // 
        // comboGender
        // 
        comboGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        comboGender.DropDownHeight = 250;
        comboGender.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        comboGender.FormattingEnabled = true;
        comboGender.IntegralHeight = false;
        comboGender.Items.AddRange(new object[] { "Male", "Female" });
        comboGender.Location = new Point(11, 344);
        comboGender.MaxLength = 100;
        comboGender.Name = "comboGender";
        comboGender.Size = new Size(221, 25);
        comboGender.TabIndex = 5;
        comboGender.KeyDown += Controls_KeyDown;
        // 
        // lblMName
        // 
        lblMName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblMName.AutoSize = true;
        lblMName.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        lblMName.Location = new Point(11, 70);
        lblMName.Name = "lblMName";
        lblMName.Size = new Size(81, 19);
        lblMName.TabIndex = 1;
        lblMName.Text = "Middle Name";
        // 
        // txtMName
        // 
        txtMName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtMName.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        txtMName.Location = new Point(11, 93);
        txtMName.Margin = new Padding(3, 2, 3, 2);
        txtMName.MaxLength = 100;
        txtMName.Name = "txtMName";
        txtMName.Size = new Size(221, 26);
        txtMName.TabIndex = 1;
        txtMName.KeyDown += Controls_KeyDown;
        // 
        // lblGender
        // 
        lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblGender.AutoSize = true;
        lblGender.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        lblGender.Location = new Point(11, 322);
        lblGender.Name = "lblGender";
        lblGender.Size = new Size(50, 19);
        lblGender.TabIndex = 4;
        lblGender.Text = "Gender";
        // 
        // panelFilterBottom
        // 
        panelFilterBottom.Controls.Add(btnSubmit);
        panelFilterBottom.Dock = DockStyle.Bottom;
        panelFilterBottom.Location = new Point(0, 625);
        panelFilterBottom.Name = "panelFilterBottom";
        panelFilterBottom.Size = new Size(248, 60);
        panelFilterBottom.TabIndex = 15;
        // 
        // btnSubmit
        // 
        btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnSubmit.BackColor = Color.Lime;
        btnSubmit.Cursor = Cursors.Hand;
        btnSubmit.FlatStyle = FlatStyle.Flat;
        btnSubmit.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        btnSubmit.ForeColor = Color.White;
        btnSubmit.Location = new Point(24, 15);
        btnSubmit.Margin = new Padding(3, 2, 3, 2);
        btnSubmit.Name = "btnSubmit";
        btnSubmit.Size = new Size(200, 30);
        btnSubmit.TabIndex = 10;
        btnSubmit.Text = " Apply";
        btnSubmit.UseVisualStyleBackColor = false;
        btnSubmit.Click += btnSubmit_Click;
        // 
        // panelFilterTop
        // 
        panelFilterTop.BackColor = Color.Teal;
        panelFilterTop.Controls.Add(lblFilterBox);
        panelFilterTop.Controls.Add(lblFilterExit);
        panelFilterTop.Dock = DockStyle.Top;
        panelFilterTop.Location = new Point(0, 0);
        panelFilterTop.Name = "panelFilterTop";
        panelFilterTop.Size = new Size(248, 20);
        panelFilterTop.TabIndex = 0;
        // 
        // lblFilterBox
        // 
        lblFilterBox.AutoSize = true;
        lblFilterBox.Dock = DockStyle.Left;
        lblFilterBox.Font = new Font("Segoe Print", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
        lblFilterBox.ForeColor = Color.White;
        lblFilterBox.Location = new Point(0, 0);
        lblFilterBox.Name = "lblFilterBox";
        lblFilterBox.Size = new Size(63, 19);
        lblFilterBox.TabIndex = 17;
        lblFilterBox.Text = "Filter Box";
        // 
        // lblFilterExit
        // 
        lblFilterExit.AutoSize = true;
        lblFilterExit.BackColor = Color.Transparent;
        lblFilterExit.Cursor = Cursors.Hand;
        lblFilterExit.Dock = DockStyle.Right;
        lblFilterExit.Font = new Font("Segoe Print", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
        lblFilterExit.ForeColor = Color.White;
        lblFilterExit.Location = new Point(231, 0);
        lblFilterExit.Name = "lblFilterExit";
        lblFilterExit.Size = new Size(17, 19);
        lblFilterExit.TabIndex = 0;
        lblFilterExit.Text = "X";
        lblFilterExit.Click += lblFilterExit_Click;
        lblFilterExit.MouseLeave += lblFilterExit_MouseLeave;
        lblFilterExit.MouseHover += lblFilterExit_MouseHover;
        // 
        // flowData
        // 
        flowData.AutoScroll = true;
        flowData.AutoScrollMargin = new Size(10, 0);
        flowData.AutoSize = true;
        flowData.BorderStyle = BorderStyle.FixedSingle;
        flowData.Dock = DockStyle.Fill;
        flowData.Location = new Point(0, 70);
        flowData.Margin = new Padding(0);
        flowData.Name = "flowData";
        flowData.Padding = new Padding(10, 0, 10, 0);
        flowData.Size = new Size(1086, 567);
        flowData.TabIndex = 7;
        // 
        // panel3
        // 
        panel3.Controls.Add(checkForce);
        panel3.Controls.Add(btnRefresh);
        panel3.Dock = DockStyle.Bottom;
        panel3.Location = new Point(0, 637);
        panel3.Name = "panel3";
        panel3.Size = new Size(1086, 50);
        panel3.TabIndex = 5;
        // 
        // checkForce
        // 
        checkForce.Anchor = AnchorStyles.Left;
        checkForce.AutoSize = true;
        checkForce.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        checkForce.Location = new Point(29, 11);
        checkForce.Name = "checkForce";
        checkForce.Size = new Size(67, 25);
        checkForce.TabIndex = 12;
        checkForce.Text = "Force?";
        checkForce.UseVisualStyleBackColor = true;
        checkForce.CheckedChanged += checkForce_CheckedChanged;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.Yellow;
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnRefresh.ForeColor = Color.Black;
        btnRefresh.Location = new Point(109, 7);
        btnRefresh.Margin = new Padding(3, 2, 3, 2);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(120, 30);
        btnRefresh.TabIndex = 11;
        btnRefresh.Text = "↺ Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(checkSelectAll);
        panel1.Controls.Add(btnOpt);
        panel1.Controls.Add(checkSelect);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 20);
        panel1.Name = "panel1";
        panel1.Size = new Size(1086, 50);
        panel1.TabIndex = 3;
        // 
        // checkSelectAll
        // 
        checkSelectAll.Anchor = AnchorStyles.Left;
        checkSelectAll.AutoSize = true;
        checkSelectAll.Enabled = false;
        checkSelectAll.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        checkSelectAll.Location = new Point(109, 14);
        checkSelectAll.Name = "checkSelectAll";
        checkSelectAll.Size = new Size(84, 25);
        checkSelectAll.TabIndex = 19;
        checkSelectAll.Text = "Select All";
        checkSelectAll.UseVisualStyleBackColor = true;
        checkSelectAll.Visible = false;
        // 
        // btnOpt
        // 
        btnOpt.BackColor = Color.Yellow;
        btnOpt.Cursor = Cursors.Hand;
        btnOpt.Enabled = false;
        btnOpt.FlatStyle = FlatStyle.Flat;
        btnOpt.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnOpt.ForeColor = Color.Black;
        btnOpt.Location = new Point(209, 10);
        btnOpt.Margin = new Padding(3, 2, 3, 2);
        btnOpt.Name = "btnOpt";
        btnOpt.Size = new Size(120, 30);
        btnOpt.TabIndex = 17;
        btnOpt.Text = "≡ Options";
        btnOpt.UseVisualStyleBackColor = false;
        btnOpt.Visible = false;
        // 
        // checkSelect
        // 
        checkSelect.Anchor = AnchorStyles.Left;
        checkSelect.AutoSize = true;
        checkSelect.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        checkSelect.Location = new Point(29, 14);
        checkSelect.Name = "checkSelect";
        checkSelect.Size = new Size(64, 25);
        checkSelect.TabIndex = 16;
        checkSelect.Text = "Select";
        checkSelect.UseVisualStyleBackColor = true;
        checkSelect.CheckedChanged += checkSelect_CheckedChanged;
        // 
        // panelSITop
        // 
        panelSITop.BackColor = Color.Teal;
        panelSITop.Controls.Add(label2);
        panelSITop.Dock = DockStyle.Top;
        panelSITop.Location = new Point(0, 0);
        panelSITop.Name = "panelSITop";
        panelSITop.Size = new Size(1086, 20);
        panelSITop.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Left;
        label2.Font = new Font("Segoe Print", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.White;
        label2.Location = new Point(0, 0);
        label2.Name = "label2";
        label2.Size = new Size(97, 19);
        label2.TabIndex = 18;
        label2.Text = "Information Box";
        // 
        // menuListOfStudents
        // 
        menuListOfStudents.BackColor = Color.Transparent;
        menuListOfStudents.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        menuListOfStudents.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
        menuListOfStudents.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
        menuListOfStudents.Location = new Point(0, 0);
        menuListOfStudents.Name = "menuListOfStudents";
        menuListOfStudents.RenderMode = ToolStripRenderMode.Professional;
        menuListOfStudents.Size = new Size(1337, 29);
        menuListOfStudents.TabIndex = 0;
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.BackColor = Color.Transparent;
        viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filterToolStripMenuItem });
        viewToolStripMenuItem.ForeColor = Color.Black;
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.ShowShortcutKeys = false;
        viewToolStripMenuItem.Size = new Size(51, 25);
        viewToolStripMenuItem.Text = "&View";
        viewToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // filterToolStripMenuItem
        // 
        filterToolStripMenuItem.BackColor = Color.White;
        filterToolStripMenuItem.ForeColor = Color.Black;
        filterToolStripMenuItem.Image = Resources.Filter;
        filterToolStripMenuItem.Name = "filterToolStripMenuItem";
        filterToolStripMenuItem.Size = new Size(138, 26);
        filterToolStripMenuItem.Text = "Filter Box";
        filterToolStripMenuItem.Click += filterToolStripMenuItem_Click;
        // 
        // FormListOfStudents
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Turquoise;
        ClientSize = new Size(1337, 716);
        ControlBox = false;
        Controls.Add(splitMain);
        Controls.Add(menuListOfStudents);
        FormBorderStyle = FormBorderStyle.None;
        MainMenuStrip = menuListOfStudents;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        Name = "FormListOfStudents";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Load += FormListOfStudents_Load;
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        splitMain.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        panelFilter.ResumeLayout(false);
        panelFilterBody.ResumeLayout(false);
        panelFilterBody.PerformLayout();
        panelFilterBottom.ResumeLayout(false);
        panelFilterTop.ResumeLayout(false);
        panelFilterTop.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panelSITop.ResumeLayout(false);
        panelSITop.PerformLayout();
        menuListOfStudents.ResumeLayout(false);
        menuListOfStudents.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuListOfStudents;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem filterToolStripMenuItem;
    private SplitContainer splitMain;
    private Panel panelFilter;
    private Panel panelFilterTop;
    private Label lblFilterExit;
    private Panel panelSITop;
    private Label lblFName;
    private TextBox txtFName;
    private Label lblEName;
    private TextBox txtEName;
    private Label lblLName;
    private TextBox txtLName;
    private Label lblMName;
    private TextBox txtMName;
    private Label lblGender;
    private ComboBox comboGender;
    private ComboBox comboYrLvl;
    private Label lblYrLvl;
    private Button btnSubmit;
    private Panel panelFilterBottom;
    private Panel panelFilterBody;
    private Label label1;
    private DateTimePicker dateBDate;
    private Label lblFilterBox;
    private Panel panel1;
    private Panel panel3;
    private ComboBox comboCourse;
    private Label lblCourse;
    private FlowLayoutPanel flowData;
    private Button btnRefresh;
    private CheckBox checkForce;
    private CheckBox checkSelect;
    private Button btnOpt;
    private CheckBox checkSelectAll;
    private Label label2;
}