namespace SCSIMS.FormComponents;

public partial class StudentData : UserControl
{
    // Dependencies
    private readonly IDbService _dbSrvc;

    // Fields
    private int _id = 0;
    private readonly string _resourceFolder = Path.Join("..", "..", "..", "Resources");

    public StudentData(StudentsDataViewModel student)
    {
        InitializeComponent();

        // Initializing Dependencies
        _dbSrvc = ServiceFactory.Get(nameof(IDbService));

        InitControls(student);
    }

    private void InitControls(StudentsDataViewModel s)
    {
        string file = Path.Join(_resourceFolder, "Uploads", s.Filename);
        byte? yrLvl = s.YrLvl;

        // Assign the Id of the current object.
        _id = s.Id ?? default;

        // When file is unavailable, use default image
        if (s.Filename == null || !File.Exists(file))
        {
            file = Path.Join(_resourceFolder, "Images", "Student.png");
        }

        // Set the image
        picProfile.Image = new Bitmap(Image.FromFile(file), 50, 50);

        // Set the name
        lblName.Text = $@"{s.LName}, {s.FName}{(s.EName == "N/A" ? "" : $" {s.EName}")} {s.MName}";

        // When the yrLvl is 6, it means the student is Graduated.
        if (yrLvl == 6)
        {
            comboYrLvl.Text = "Graduated";
        }
        else
        {
            comboYrLvl.Text = yrLvl?.ToString() ?? "Select Year Level";
        }

        // When Year Level hasn't given yet,
        // the edit button will become save.
        HasYrLvl(yrLvl);
    }

    private void picSave_Click(object? sender, EventArgs e)
    {
        if (comboYrLvl.Text != "Select Year Level")
        {
            string tempYrLvl = string.Empty;

            if (comboYrLvl.Text == "Graduated")
            {
                tempYrLvl = "6";
            }
            else
            {
                tempYrLvl = comboYrLvl.Text;
            }

            byte yrLvl = byte.Parse(tempYrLvl);

            AddYearLevel(yrLvl)
                .Await(() =>
                    {
                        // Indicate that change is inevitable
                        HasYrLvl(yrLvl);
                    }, (ex) =>
                    {
                        MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                );
        }
    }

    // When Year Level hasn't given yet
    private void HasYrLvl(byte? yrLvl)
    {
        if (yrLvl == null)
        {
            SetSaveOff(true);
        }
        else
        {
            SetSaveOff(false);
        }
    }

    // Setting save off
    private void SetSaveOff(bool off)
    {
        picSave.Enabled = off;
        picSave.Visible = off;
        comboYrLvl.Enabled = off;
    }

    private async ValueTask AddYearLevel(byte yrLvl)
    {
        await _dbSrvc.AddYrLvlAsync(_id, yrLvl);
    }

    private void picSave_MouseHover(object sender, EventArgs e)
    {
        picSave.BackColor = Color.Wheat;
        toolTipSave.SetToolTip(picSave, "Save");
    }

    private void picSave_MouseLeave(object sender, EventArgs e)
    {
        picSave.BackColor = Color.White;
    }
}
