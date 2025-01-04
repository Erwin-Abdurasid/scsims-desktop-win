namespace SCSIMS.Forms;

partial class FormDashboard
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
        btnAdd = new Button();
        btnView = new Button();
        panelSideBar = new Panel();
        panelHome = new Panel();
        btnHome = new Button();
        button1 = new Button();
        panelAdd = new Panel();
        panelView = new Panel();
        panelSBTop = new Panel();
        picLogo = new PictureBox();
        panelSBBottom = new Panel();
        lblCopyright = new Label();
        toolTipQ = new ToolTip(components);
        toolTipHome = new ToolTip(components);
        panelSideBar.SuspendLayout();
        panelHome.SuspendLayout();
        panelAdd.SuspendLayout();
        panelView.SuspendLayout();
        panelSBTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        panelSBBottom.SuspendLayout();
        SuspendLayout();
        // 
        // btnAdd
        // 
        btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnAdd.BackColor = Color.Gray;
        btnAdd.Cursor = Cursors.Hand;
        btnAdd.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        btnAdd.Location = new Point(0, 0);
        btnAdd.Margin = new Padding(3, 2, 3, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(214, 38);
        btnAdd.TabIndex = 1;
        btnAdd.Text = "Enroll";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnView
        // 
        btnView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnView.BackColor = Color.Gray;
        btnView.Cursor = Cursors.Hand;
        btnView.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        btnView.Location = new Point(0, 0);
        btnView.Margin = new Padding(3, 2, 3, 2);
        btnView.Name = "btnView";
        btnView.Size = new Size(214, 38);
        btnView.TabIndex = 2;
        btnView.Text = "Students Information";
        btnView.UseVisualStyleBackColor = false;
        btnView.Click += btnView_Click;
        // 
        // panelSideBar
        // 
        panelSideBar.BackColor = Color.FromArgb(0, 192, 192);
        panelSideBar.Controls.Add(panelHome);
        panelSideBar.Controls.Add(panelAdd);
        panelSideBar.Controls.Add(panelView);
        panelSideBar.Controls.Add(panelSBTop);
        panelSideBar.Controls.Add(panelSBBottom);
        panelSideBar.Dock = DockStyle.Left;
        panelSideBar.Location = new Point(0, 0);
        panelSideBar.Margin = new Padding(3, 2, 3, 2);
        panelSideBar.Name = "panelSideBar";
        panelSideBar.Size = new Size(219, 677);
        panelSideBar.TabIndex = 3;
        // 
        // panelHome
        // 
        panelHome.Controls.Add(btnHome);
        panelHome.Controls.Add(button1);
        panelHome.Location = new Point(2, 140);
        panelHome.Margin = new Padding(3, 2, 3, 2);
        panelHome.Name = "panelHome";
        panelHome.Size = new Size(214, 38);
        panelHome.TabIndex = 5;
        // 
        // btnHome
        // 
        btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnHome.BackColor = Color.Gray;
        btnHome.Cursor = Cursors.Hand;
        btnHome.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        btnHome.Location = new Point(0, -1);
        btnHome.Margin = new Padding(3, 2, 3, 2);
        btnHome.Name = "btnHome";
        btnHome.Size = new Size(214, 38);
        btnHome.TabIndex = 0;
        btnHome.Text = "Home";
        btnHome.UseVisualStyleBackColor = false;
        btnHome.Click += btnHome_Click;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        button1.BackColor = Color.Gray;
        button1.Cursor = Cursors.Hand;
        button1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(0, 0);
        button1.Margin = new Padding(3, 2, 3, 2);
        button1.Name = "button1";
        button1.Size = new Size(228, 0);
        button1.TabIndex = 1;
        button1.Text = "Enroll";
        button1.UseVisualStyleBackColor = false;
        // 
        // panelAdd
        // 
        panelAdd.Controls.Add(btnAdd);
        panelAdd.Location = new Point(3, 182);
        panelAdd.Margin = new Padding(3, 2, 3, 2);
        panelAdd.Name = "panelAdd";
        panelAdd.Size = new Size(214, 38);
        panelAdd.TabIndex = 4;
        // 
        // panelView
        // 
        panelView.Controls.Add(btnView);
        panelView.Location = new Point(3, 224);
        panelView.Margin = new Padding(3, 2, 3, 2);
        panelView.Name = "panelView";
        panelView.Size = new Size(214, 38);
        panelView.TabIndex = 5;
        // 
        // panelSBTop
        // 
        panelSBTop.Controls.Add(picLogo);
        panelSBTop.Dock = DockStyle.Top;
        panelSBTop.Location = new Point(0, 0);
        panelSBTop.Margin = new Padding(3, 2, 3, 2);
        panelSBTop.Name = "panelSBTop";
        panelSBTop.Size = new Size(219, 136);
        panelSBTop.TabIndex = 8;
        // 
        // picLogo
        // 
        picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        picLogo.BackColor = Color.Transparent;
        picLogo.BackgroundImage = Resources.Logo;
        picLogo.BackgroundImageLayout = ImageLayout.Stretch;
        picLogo.Cursor = Cursors.Hand;
        picLogo.Location = new Point(46, 14);
        picLogo.Margin = new Padding(3, 2, 3, 2);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(127, 109);
        picLogo.TabIndex = 4;
        picLogo.TabStop = false;
        picLogo.Click += picLogo_Click;
        picLogo.MouseHover += picLogo_MouseHover;
        // 
        // panelSBBottom
        // 
        panelSBBottom.Controls.Add(lblCopyright);
        panelSBBottom.Dock = DockStyle.Bottom;
        panelSBBottom.Location = new Point(0, 634);
        panelSBBottom.Margin = new Padding(3, 2, 3, 2);
        panelSBBottom.Name = "panelSBBottom";
        panelSBBottom.Size = new Size(219, 43);
        panelSBBottom.TabIndex = 7;
        // 
        // lblCopyright
        // 
        lblCopyright.AutoSize = true;
        lblCopyright.Cursor = Cursors.Hand;
        lblCopyright.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        lblCopyright.ForeColor = SystemColors.Control;
        lblCopyright.Location = new Point(83, 10);
        lblCopyright.Name = "lblCopyright";
        lblCopyright.Size = new Size(50, 24);
        lblCopyright.TabIndex = 6;
        lblCopyright.Text = "2024";
        lblCopyright.Click += lblCopyright_Click;
        lblCopyright.MouseHover += lblCopyright_MouseHover;
        // 
        // toolTipQ
        // 
        toolTipQ.IsBalloon = true;
        // 
        // toolTipHome
        // 
        toolTipHome.IsBalloon = true;
        // 
        // FormDashboard
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BackColor = SystemColors.Control;
        BackgroundImageLayout = ImageLayout.None;
        ClientSize = new Size(1540, 677);
        Controls.Add(panelSideBar);
        Icon = (Icon)resources.GetObject("$this.Icon");
        IsMdiContainer = true;
        Margin = new Padding(3, 2, 3, 2);
        MaximumSize = new Size(1920, 1080);
        MinimumSize = new Size(1224, 384);
        Name = "FormDashboard";
        WindowState = FormWindowState.Maximized;
        FormClosing += FormDashboard_FormClosing;
        Load += FormDashboard_Load;
        panelSideBar.ResumeLayout(false);
        panelHome.ResumeLayout(false);
        panelAdd.ResumeLayout(false);
        panelView.ResumeLayout(false);
        panelSBTop.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        panelSBBottom.ResumeLayout(false);
        panelSBBottom.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button btnAdd;
    private Button btnView;
    private Panel panelSideBar;
    private Panel panelAdd;
    private Panel panelView;
    private PictureBox picLogo;
    private Label lblCopyright;
    private Panel panelSBBottom;
    private Panel panelSBTop;
    private Button btnHome;
    private Panel panelHome;
    private Button button1;
    private ToolTip toolTipQ;
    private ToolTip toolTipHome;
}