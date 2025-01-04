namespace SCSIMS.Forms;

partial class FormAppForm3
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
        panel2 = new Panel();
        picPrev = new PictureBox();
        panel1 = new Panel();
        btnClear = new Button();
        lblReviewer = new Label();
        btnSubmit = new Button();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picPrev).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.Controls.Add(picPrev);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 630);
        panel2.Margin = new Padding(3, 2, 3, 2);
        panel2.Name = "panel2";
        panel2.Size = new Size(1337, 86);
        panel2.TabIndex = 29;
        // 
        // picPrev
        // 
        picPrev.Anchor = AnchorStyles.None;
        picPrev.Cursor = Cursors.Hand;
        picPrev.Image = Resources.Prev;
        picPrev.ImageLocation = "";
        picPrev.Location = new Point(592, 20);
        picPrev.Margin = new Padding(3, 2, 3, 2);
        picPrev.Name = "picPrev";
        picPrev.Size = new Size(50, 45);
        picPrev.SizeMode = PictureBoxSizeMode.StretchImage;
        picPrev.TabIndex = 27;
        picPrev.TabStop = false;
        picPrev.Click += picPrev_Click;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.None;
        panel1.BackColor = Color.Transparent;
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(btnClear);
        panel1.Controls.Add(lblReviewer);
        panel1.Controls.Add(btnSubmit);
        panel1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        panel1.Location = new Point(40, 45);
        panel1.Margin = new Padding(3, 2, 3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(1252, 544);
        panel1.TabIndex = 28;
        // 
        // btnClear
        // 
        btnClear.Anchor = AnchorStyles.None;
        btnClear.BackColor = Color.Transparent;
        btnClear.Cursor = Cursors.Hand;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
        btnClear.Location = new Point(628, 484);
        btnClear.Margin = new Padding(3, 2, 3, 2);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(199, 37);
        btnClear.TabIndex = 2;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // lblReviewer
        // 
        lblReviewer.Anchor = AnchorStyles.None;
        lblReviewer.AutoSize = true;
        lblReviewer.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
        lblReviewer.Location = new Point(48, 50);
        lblReviewer.Name = "lblReviewer";
        lblReviewer.Size = new Size(0, 28);
        lblReviewer.TabIndex = 1;
        lblReviewer.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnSubmit
        // 
        btnSubmit.Anchor = AnchorStyles.None;
        btnSubmit.BackColor = Color.Transparent;
        btnSubmit.Cursor = Cursors.Hand;
        btnSubmit.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
        btnSubmit.Location = new Point(423, 483);
        btnSubmit.Margin = new Padding(3, 2, 3, 2);
        btnSubmit.Name = "btnSubmit";
        btnSubmit.Size = new Size(199, 37);
        btnSubmit.TabIndex = 0;
        btnSubmit.Text = "Submit";
        btnSubmit.UseVisualStyleBackColor = false;
        btnSubmit.Click += btnSubmit_Click;
        // 
        // FormAppForm3
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = Color.Turquoise;
        ClientSize = new Size(1337, 716);
        ControlBox = false;
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        Name = "FormAppForm3";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        FormClosing += FormAppForm3_FormClosing;
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picPrev).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private PictureBox picPrev;
    private Panel panel1;
    private Button btnSubmit;
    private Label lblReviewer;
    private Button btnClear;
    private Panel panel2;
}