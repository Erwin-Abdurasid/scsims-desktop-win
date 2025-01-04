namespace SCSIMS.FormComponents;

partial class AboutBox : Form
{
    public AboutBox()
    {
        InitializeComponent();

        InitControls();
    }

    // Properties
    public string Version
    {
        get => System.Reflection.Assembly.
            GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0.0";
    }

    public string Description
    {
        get => "It is a simple-to-use computer studentinformation management system. Designed for simple use.";
    }

    private void InitControls()
    {
        this.Text = "About: Simple Computer Student Information Management System";
        this.labelProductName.Text = "Simple Computer Student Information Management System";
        this.labelVersion.Text = String.Format("Version {0}", Version);
        this.labelCopyright.Text = "©2024 All Rights Reserved";
        this.labelCompanyName.Text = "Tech Wannabe";
        this.textBoxDescription.Text = Description;
    }

    private void okButton_Click(object? sender, EventArgs e)
    {
        this.Close();
    }
}
