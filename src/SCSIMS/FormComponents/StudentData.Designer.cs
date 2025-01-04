namespace SCSIMS.FormComponents;

partial class StudentData
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblName = new Label();
        picProfile = new PictureBox();
        comboYrLvl = new ComboBox();
        picSave = new PictureBox();
        toolTipSave = new ToolTip(components);
        ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picSave).BeginInit();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblName.AutoSize = true;
        lblName.Location = new Point(65, 15);
        lblName.Name = "lblName";
        lblName.Size = new Size(79, 21);
        lblName.TabIndex = 0;
        lblName.Text = "(Full Name)";
        // 
        // picProfile
        // 
        picProfile.BackColor = Color.White;
        picProfile.BorderStyle = BorderStyle.Fixed3D;
        picProfile.Location = new Point(0, 0);
        picProfile.Margin = new Padding(3, 4, 3, 4);
        picProfile.Name = "picProfile";
        picProfile.Size = new Size(50, 50);
        picProfile.SizeMode = PictureBoxSizeMode.Zoom;
        picProfile.TabIndex = 1;
        picProfile.TabStop = false;
        // 
        // comboYrLvl
        // 
        comboYrLvl.FormattingEnabled = true;
        comboYrLvl.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "Graduated" });
        comboYrLvl.Location = new Point(528, 12);
        comboYrLvl.Margin = new Padding(3, 4, 3, 4);
        comboYrLvl.Name = "comboYrLvl";
        comboYrLvl.Size = new Size(179, 29);
        comboYrLvl.TabIndex = 2;
        comboYrLvl.Text = "Select";
        // 
        // picSave
        // 
        picSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        picSave.BackColor = Color.White;
        picSave.BorderStyle = BorderStyle.Fixed3D;
        picSave.Cursor = Cursors.Hand;
        picSave.Image = Resources.Save;
        picSave.Location = new Point(1188, 5);
        picSave.Name = "picSave";
        picSave.Size = new Size(40, 40);
        picSave.SizeMode = PictureBoxSizeMode.Zoom;
        picSave.TabIndex = 1;
        picSave.TabStop = false;
        picSave.Tag = "";
        picSave.Click += picSave_Click;
        picSave.MouseLeave += picSave_MouseLeave;
        picSave.MouseHover += picSave_MouseHover;
        // 
        // toolTipSave
        // 
        toolTipSave.IsBalloon = true;
        // 
        // StudentData
        // 
        AutoScaleDimensions = new SizeF(8F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(0, 192, 192);
        Controls.Add(picSave);
        Controls.Add(comboYrLvl);
        Controls.Add(picProfile);
        Controls.Add(lblName);
        Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(0, 3, 0, 3);
        Name = "StudentData";
        Size = new Size(1234, 50);
        ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
        ((System.ComponentModel.ISupportInitialize)picSave).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblName;
    private PictureBox picProfile;
    private ComboBox comboYrLvl;
    private PictureBox picSave;
    private ToolTip toolTipSave;
}
