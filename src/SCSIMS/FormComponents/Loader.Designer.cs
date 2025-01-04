namespace SCSIMS.FormComponents;

partial class Loader
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pictureLoading = new PictureBox();
        lblCancel = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureLoading).BeginInit();
        SuspendLayout();
        // 
        // pictureLoading
        // 
        pictureLoading.BackColor = Color.White;
        pictureLoading.BackgroundImageLayout = ImageLayout.Stretch;
        pictureLoading.Cursor = Cursors.AppStarting;
        pictureLoading.Dock = DockStyle.Left;
        pictureLoading.Image = Resources.Loading;
        pictureLoading.InitialImage = null;
        pictureLoading.Location = new Point(0, 0);
        pictureLoading.Name = "pictureLoading";
        pictureLoading.Size = new Size(139, 33);
        pictureLoading.SizeMode = PictureBoxSizeMode.Zoom;
        pictureLoading.TabIndex = 6;
        pictureLoading.TabStop = false;
        // 
        // lblCancel
        // 
        lblCancel.AutoSize = true;
        lblCancel.BackColor = Color.White;
        lblCancel.Cursor = Cursors.Hand;
        lblCancel.Dock = DockStyle.Right;
        lblCancel.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        lblCancel.ForeColor = Color.Crimson;
        lblCancel.Location = new Point(145, 0);
        lblCancel.Name = "lblCancel";
        lblCancel.Size = new Size(29, 33);
        lblCancel.TabIndex = 7;
        lblCancel.Text = "X";
        lblCancel.Click += lblCancel_Click;
        // 
        // Loader
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(174, 33);
        ControlBox = false;
        Controls.Add(pictureLoading);
        Controls.Add(lblCancel);
        Cursor = Cursors.AppStarting;
        FormBorderStyle = FormBorderStyle.None;
        Name = "Loader";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)pictureLoading).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureLoading;
    private Label lblCancel;
}