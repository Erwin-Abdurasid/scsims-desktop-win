namespace SCSIMS.Forms;

public partial class FormAppForm2 : Form, IService
{
    // Forms
    private readonly FormAppForm1 _prevForm;
    private FormAppForm3? _nextForm;
    private readonly FormDashboard _parentForm;

    // Dependencies
    private readonly IInputDataService _inputSrvc;
    private readonly IValidationService _validateSrvc;
    private readonly IDbService _dbSrvc;

    // Fields
    private readonly string _resourceFolder = Path.Join("..", "..", "..", "Resources", "Uploads");
    private IEnumerable<Course>? _courses;

    public FormAppForm2()
    {
        InitializeComponent();

        // Initializing dependencies
        ServiceFactory.Add("Form 2", this);
        _parentForm = ServiceFactory.Get("Parent Form");
        _prevForm = ServiceFactory.Get("Form 1");
        _inputSrvc = ServiceFactory.Get(nameof(IInputDataService));
        _validateSrvc = ServiceFactory.Get(nameof(IValidationService));
        _dbSrvc = ServiceFactory.Get(nameof(IDbService));

        InitEvents();
        InitControls();
    }

    // Initializing events
    private void InitEvents()
    {
        _inputSrvc.ProcessToRun += DataSettingProcess;
        _inputSrvc.InputClear += ClearAllInputs;
        _inputSrvc.InputError += Inputs_Error;
    }

    // Initializing controls.
    private void InitControls()
    {
        fileDialogPicture.Title = "Load Image";
        numRTLastYearLvl.Text = string.Empty;
        numRTSchoolID.Text = string.Empty;
        btnRemoveFile.Enabled = false;
        btnRemoveFile.Visible = false;

        InitComboControlsAsync().Await(null,
            (ex) =>
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
    }

    private void picPrev_Click(object? sender, EventArgs e)
    {
        _prevForm.Activate();
    }

    private void picNext_Click(object? sender, EventArgs e)
    {
        if (_nextForm == null)
        {
            _nextForm = new FormAppForm3();
            _nextForm.MdiParent = _parentForm;
            _nextForm.FormClosed += _nextForm_FormClosed;
            _nextForm.Dock = DockStyle.Fill;
            _nextForm.Show();
        }
        else
        {
            _nextForm.Activate();
        }
    }

    private void _nextForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _nextForm?.Dispose();
        _nextForm = null;
    }

    private void Controls_KeyDown(object? sender, KeyEventArgs e)
    {
        if (sender != null)
        {
            method.GoToNextInputControl((Form)this, (Control)sender, e);
        }
    }

    private void btnPicture_Click(object? sender, EventArgs e)
    {
        (string filePath, string fileName, string newFilePath) = AssignFileNamePath();

        try
        {
            fileDialogPicture.Filter =
                "Image Files (*.jpg;*.jpeg;*.JPG;*.JPEG;*.png;*.PNG)|*.jpg;*.jpeg;*.JPG;*.JPEG;*.png;*.PNG";

            if (fileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                // When the user want to choose different image,
                // delete the old image.
                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    File.Delete(newFilePath);
                }

                (filePath, fileName, newFilePath) = AssignFileNamePath();
                ModifyImageRelatives(true, filePath, fileName);

                // Copy the image to our folder.
                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    File.Copy(filePath, newFilePath);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRemoveFile_Click(object? sender, EventArgs e)
    {
        try
        {
            // The filename of the image.
            string fileName = fileDialogPicture.SafeFileName;
            // The new file path where we stored our image.
            string newFilePath = Path.Join(_resourceFolder, fileName);

            if (!string.IsNullOrWhiteSpace(fileName))
            {
                File.Delete(newFilePath);

                fileDialogPicture.Reset();
                ModifyImageRelatives(false);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private (string, string, string) AssignFileNamePath()
    {
        // The file path where we get our image.
        string filePath = fileDialogPicture.FileName;

        // The filename of the image.
        string fileName = fileDialogPicture.SafeFileName;

        // The new file path where we stored our image.
        string newFilePath = Path.Join(_resourceFolder, fileName);

        return (filePath, fileName, newFilePath);
    }

    private void ModifyImageRelatives(bool got, string? filepath = null, string filename = " ")
    {
        bool labeled = !got;
        bool hasRemove = got;

        lblPicture.Enabled = labeled;
        lblPicture.Visible = labeled;
        lblPictureName.Text = filename;
        pictureBox.Image = filepath != null ? new Bitmap(Image.FromFile(filepath),
            new Size(pictureBox.Width, pictureBox.Height)) : null;
        btnRemoveFile.Enabled = hasRemove;
        btnRemoveFile.Visible = hasRemove;
    }

    private void DataSettingProcess(object? sender, EventArgs e)
    {
        // Email validation
        string email = txtEmail.Text;
        if (!string.IsNullOrWhiteSpace(email) && !_validateSrvc.ValidateEmail(txtEmail.Text))
        {
            email = "Invalid";
        }

        // Last School Year Validation
        string[] lastSchYrs = new string[] { "-1", "-1" };
        if (mTxtRTLastSchoolYear.Text == "-")
        {
            lastSchYrs[0] = "-2";
            lastSchYrs[1] = "-2";
        }
        else if (_validateSrvc.ValidateSchYr(mTxtRTLastSchoolYear.Text))
        {
            lastSchYrs = mTxtRTLastSchoolYear.Text.Split('-');
        }

        // Phone Number Validation
        string fNum = "Invalid";
        string mNum = "Invalid";
        string gNum = "Invalid";
        string num = "Invalid";
        if (string.IsNullOrWhiteSpace(mTxtNumFather.Text) || _validateSrvc.ValidatePhoneNum(mTxtNumFather.Text))
        {
            fNum = mTxtNumFather.Text;
        }
        if (string.IsNullOrWhiteSpace(mTxtNumMother.Text) || _validateSrvc.ValidatePhoneNum(mTxtNumMother.Text))
        {
            mNum = mTxtNumMother.Text;
        }
        if (string.IsNullOrWhiteSpace(mTxtNumGuard.Text) || _validateSrvc.ValidatePhoneNum(mTxtNumGuard.Text))
        {
            gNum = mTxtNumGuard.Text;
        }
        if (string.IsNullOrWhiteSpace(mTxtNum.Text) || _validateSrvc.ValidatePhoneNum(mTxtNum.Text))
        {
            num = mTxtNum.Text;
        }

        // Set the data
        _inputSrvc.SetFormAppForm2Data(
            txtFatherFName.Text, txtFatherMName.Text, txtFatherLName.Text, fNum,
            txtMotherFName.Text, txtMotherMName.Text, txtMotherLName.Text, mNum,
            txtGuardFName.Text, txtGuardMName.Text, txtGuardLName.Text, gNum,
            (byte)numRTLastYearLvl.Value, short.Parse(lastSchYrs[0]), short.Parse(lastSchYrs[1]),
            txtRTLastSchoolAtt.Text, numRTSchoolID.Text, comboCourse.Text, num,
            email, fileDialogPicture.SafeFileName
        );
    }

    private void ClearAllInputs(object? sender, EventArgs e)
    {
        txtFatherFName.Text = string.Empty;
        txtFatherMName.Text = string.Empty;
        txtFatherLName.Text = string.Empty;
        mTxtNumFather.Text = string.Empty;
        txtMotherFName.Text = string.Empty;
        txtMotherMName.Text = string.Empty;
        txtMotherLName.Text = string.Empty;
        mTxtNumMother.Text = string.Empty;
        txtGuardFName.Text = string.Empty;
        txtGuardMName.Text = string.Empty;
        txtGuardLName.Text = string.Empty;
        mTxtNumGuard.Text = string.Empty;
        checkRT.Checked = false;
        numRTLastYearLvl.Value = 0;
        numRTLastYearLvl.Text = string.Empty;
        mTxtRTLastSchoolYear.Text = string.Empty;
        txtRTLastSchoolAtt.Text = string.Empty;
        numRTSchoolID.Value = 0;
        numRTSchoolID.Text = string.Empty;
        comboCourse.Text = string.Empty;
        mTxtNum.Text = string.Empty;
        txtEmail.Text = string.Empty;
        fileDialogPicture.Reset();
        lblPicture.Enabled = true;
        lblPicture.Visible = true;
        lblPictureName.Text = " ";
        pictureBox.Image = null;
        btnRemoveFile.Enabled = false;
        btnRemoveFile.Visible = false;
    }

    private async ValueTask InitComboControlsAsync()
    {
        comboCourse.Items.Clear();

        _courses = await _dbSrvc.GetCoursesAsync();

        if (_courses != null)
        {
            foreach (Course course in _courses)
            {
                comboCourse.Items.Add($"{course.Name} ({course.Abbr})");
            }
        }
    }

    #region Test
    private void checkPopulate_CheckedChanged(object? sender, EventArgs e)
    {
        if (checkPopulate.CheckState == CheckState.Checked)
        {
            txtEmail.Text = "erwinhadjirul16@gmail.com";
            txtFatherFName.Text = "Julio";
            txtFatherMName.Text = "Abdurasid";
            txtFatherLName.Text = "Hadjirul";
            mTxtNumFather.Text = "9351232343";
            txtMotherFName.Text = "Lyn";
            txtMotherMName.Text = "Kandong";
            txtMotherLName.Text = "Sanaani";
            mTxtNumMother.Text = "9876543210";
            txtGuardFName.Text = "Akhmad";
            txtGuardMName.Text = "Abdurasid";
            txtGuardLName.Text = "Hadjirul";
            mTxtNumGuard.Text = "9758526778";
            numRTLastYearLvl.Value = 3;
            mTxtRTLastSchoolYear.Text = "2021-2022";
            txtRTLastSchoolAtt.Text = "Mindanao State University";
            numRTSchoolID.Value = 120073;
            comboCourse.Text = "Bachelor of Science in Computer Science (BSCS)";
            mTxtNum.Text = "9518168972";
        }
    }
    #endregion

    private void Inputs_Error(object? sender, EventArgs e)
    {
        // txtEmail
        if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !_validateSrvc.ValidateEmail(txtEmail.Text))
        {
            errorProvider.SetError(txtEmail, mess.InvalidInput);
        }

        // txtFatherFName
        if (string.IsNullOrWhiteSpace(txtFatherFName.Text))
        {
            errorProvider.SetError(txtFatherFName, mess.NullInputs);
        }

        // txtFatherMName
        if (string.IsNullOrWhiteSpace(txtFatherMName.Text))
        {
            errorProvider.SetError(txtFatherMName, mess.NullInputs);
        }

        // txtFatherLName
        if (string.IsNullOrWhiteSpace(txtFatherLName.Text))
        {
            errorProvider.SetError(txtFatherLName, mess.NullInputs);
        }

        // mTxtNumFather
        if (string.IsNullOrWhiteSpace(mTxtNumFather.Text))
        {
            errorProvider.SetError(mTxtNumFather, mess.NullInputs);
        }
        else if (!_validateSrvc.ValidatePhoneNum(mTxtNumFather.Text))
        {
            errorProvider.SetError(mTxtNumFather, mess.InvalidInput);
        }

        // txtMotherFName
        if (string.IsNullOrWhiteSpace(txtMotherFName.Text))
        {
            errorProvider.SetError(txtMotherFName, mess.NullInputs);
        }

        // txtMotherMName
        if (string.IsNullOrWhiteSpace(txtMotherMName.Text))
        {
            errorProvider.SetError(txtMotherMName, mess.NullInputs);
        }

        // txtMotherLName
        if (string.IsNullOrWhiteSpace(txtMotherLName.Text))
        {
            errorProvider.SetError(txtMotherLName, mess.NullInputs);
        }

        // mTxtNumMother
        if (string.IsNullOrWhiteSpace(mTxtNumMother.Text))
        {
            errorProvider.SetError(mTxtNumMother, mess.NullInputs);
        }
        else if (!_validateSrvc.ValidatePhoneNum(mTxtNumMother.Text))
        {
            errorProvider.SetError(mTxtNumMother, mess.InvalidInput);
        }

        // txtGuardFName
        if (string.IsNullOrWhiteSpace(txtGuardFName.Text))
        {
            errorProvider.SetError(txtGuardFName, mess.NullInputs);
        }

        // txtGuardMName
        if (string.IsNullOrWhiteSpace(txtGuardMName.Text))
        {
            errorProvider.SetError(txtGuardMName, mess.NullInputs);
        }

        // txtGuardLName
        if (string.IsNullOrWhiteSpace(txtGuardLName.Text))
        {
            errorProvider.SetError(txtGuardLName, mess.NullInputs);
        }

        // mTxtNumGuard
        if (string.IsNullOrWhiteSpace(mTxtNumGuard.Text))
        {
            errorProvider.SetError(mTxtNumGuard, mess.NullInputs);
        }
        else if (!_validateSrvc.ValidatePhoneNum(mTxtNumGuard.Text))
        {
            errorProvider.SetError(mTxtNumGuard, mess.InvalidInput);
        }

        // numRTLastYearLvl
        if (string.IsNullOrWhiteSpace(numRTLastYearLvl.Text))
        {
            errorProvider.SetError(numRTLastYearLvl, mess.NullInputs);
        }

        // mTxtRTLastSchoolYear
        if (mTxtRTLastSchoolYear.Text == "-")
        {
            errorProvider.SetError(mTxtRTLastSchoolYear, mess.NullInputs);
        }
        if (!_validateSrvc.ValidateSchYr(mTxtRTLastSchoolYear.Text))
        {
            errorProvider.SetError(mTxtRTLastSchoolYear, mess.InvalidInput);
        }

        // txtRTLastSchoolAtt
        if (string.IsNullOrWhiteSpace(txtRTLastSchoolAtt.Text))
        {
            errorProvider.SetError(txtRTLastSchoolAtt, mess.NullInputs);
        }

        // numRTSchoolID
        if (string.IsNullOrWhiteSpace(numRTSchoolID.Text))
        {
            errorProvider.SetError(numRTSchoolID, mess.NullInputs);
        }

        // comboCourse
        if (string.IsNullOrWhiteSpace(comboCourse.Text))
        {
            errorProvider.SetError(comboCourse, mess.NullInputs);
        }

        // mTxtNum
        if (string.IsNullOrWhiteSpace(mTxtNum.Text))
        {
            errorProvider.SetError(mTxtNum, mess.NullInputs);
        }
        else if (!_validateSrvc.ValidatePhoneNum(mTxtNum.Text))
        {
            errorProvider.SetError(mTxtNum, mess.InvalidInput);
        }

        // fileDialogPicture
        if (string.IsNullOrWhiteSpace(fileDialogPicture.FileName))
        {
            errorProvider.SetError(pictureBox, mess.NullInputs);
        }
    }

    private void Controls_ValueOrTextChanged(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            method.ClearErrorInputControl(errorProvider, (Control)sender);
        }
    }

    // For pictureBox and fileDialogPicture
    private void fileDialogPicture_OK(object? sender, System.ComponentModel.CancelEventArgs e)
    {
        method.ClearErrorInputControl(errorProvider, pictureBox);
    }

    private void mTxtRTLastSchoolYear_ValueChanged(object? sender, EventArgs e)
    {
        method.ClearErrorInputControl(errorProvider, mTxtRTLastSchoolYear);
    }

    // For returnee or Transferee, when checked.
    private void checkRT_CheckedChanged(object sender, EventArgs e)
    {
        if (checkRT.CheckState == CheckState.Checked)
        {
            int yearNow = DateTime.Now.Year;
            int lastYear = yearNow - 1;

            numRTLastYearLvl.Value = 0;
            numRTLastYearLvl.Text = "0";
            txtRTLastSchoolAtt.Text = "N/A";
            numRTSchoolID.Value = 0;
            numRTSchoolID.Text = "0";
            mTxtRTLastSchoolYear.Text = $"{lastYear}-{yearNow}";
        }
    }

    private void FormAppForm2_FormClosing(object sender, FormClosingEventArgs e)
    {
        _inputSrvc.ProcessToRun -= DataSettingProcess;
        _inputSrvc.InputClear -= ClearAllInputs;
        _inputSrvc.InputError -= Inputs_Error;
    }
}