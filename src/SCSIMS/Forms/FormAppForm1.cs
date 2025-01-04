namespace SCSIMS.Forms;

public partial class FormAppForm1 : Form, IService
{
    // Forms
    private FormAppForm2? _nextForm;
    private readonly FormDashboard _parentForm;

    // Dependencies
    private readonly IInputDataService _inputSrvc;
    private readonly IDbService _dbSrvc;
    private readonly ILoadingService _loadSrvc;

    // Fields
    private Dictionary<string, Province>? _provinces;
    private Dictionary<string, City>? _cities;
    private IEnumerable<Brgy>? _brgies;

    public FormAppForm1()
    {
        InitializeComponent();

        // Initializing dependencies
        ServiceFactory.Add("Form 1", this);
        _parentForm = ServiceFactory.Get("Parent Form");
        _inputSrvc = ServiceFactory.Get(nameof(IInputDataService));
        _dbSrvc = ServiceFactory.Get(nameof(IDbService));
        _loadSrvc = ServiceFactory.Get(nameof(ILoadingService));

        InitEvents();
        InitControls();
    }

    private void FormAppForm1_Load(object? sender, EventArgs e)
    {
        // Events raised
        Thread newThread = new Thread(delegate ()
        {
            _loadSrvc.OnLoadingStarted(500);
        });
        newThread.Start();
    }

    // Initializing events
    private void InitEvents()
    {
        // _inputSrvc
        _inputSrvc.ProcessToRun += DataSettingProcess;
        _inputSrvc.InputClear += ClearAllInputs;
        _inputSrvc.InputError += Inputs_Error;
    }

    // Initializing controls
    private void InitControls()
    {
        numAge.Text = string.Empty;
        numCZip.Text = string.Empty;
        numPZip.Text = string.Empty;

        InitComboControlsAsync().Await(null,
            (ex) =>
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
    }

    private void picNext_Click(object? sender, EventArgs e)
    {
        if (_nextForm == null)
        {
            _nextForm = new FormAppForm2();
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

    private void checkPAddress_CheckedChanged(object? sender, EventArgs e)
    {
        bool state = false;

        if (checkPAddress.CheckState == CheckState.Checked)
        {
            txtPHouseNo.Text = txtCHouseNo.Text;
            txtPStreet.Text = txtCStreet.Text;
            //comboPCountry.Text = comboCCountry.Text;
            comboPProv.Text = comboCProv.Text;
            comboPCity.Text = comboCCity.Text;
            comboPBrgy.Text = comboCBrgy.Text;
            numPZip.Value = numCZip.Value;
        }
        else
        {
            state = true;
        }

        txtPHouseNo.Enabled = state;
        txtPStreet.Enabled = state;
        //comboPCountry.Enabled = state;
        comboPProv.Enabled = state;
        comboPCity.Enabled = state;
        comboPBrgy.Enabled = state;
        numPZip.Enabled = state;
    }

    private void DataSettingProcess(object? sender, EventArgs e)
    {
        // Gender
        string gender = "";
        if (radioGenderM.Checked)
        {
            gender = "Male";
        }
        else if (radioGenderF.Checked)
        {
            gender = "Female";
        }

        // Birth Date
        DateTime? bDate = null;
        if (!string.IsNullOrWhiteSpace(dateBDate.Text))
        {
            bDate = dateBDate.Value.Date;
        }

        // Set the data
        _inputSrvc.SetFormAppForm1Data(
            txtFName.Text, txtMName.Text, txtLName.Text, txtEName.Text, bDate,
            txtPBirth.Text, gender, (byte)numAge.Value, txtCHouseNo.Text, txtCStreet.Text,
            comboCCountry.Text, comboCProv.Text, comboCCity.Text, comboCBrgy.Text, (short)numCZip.Value,
            txtPHouseNo.Text, txtPStreet.Text, comboPCountry.Text, comboPProv.Text, comboPCity.Text,
            comboPBrgy.Text, (short)numPZip.Value
        );
    }

    private void ClearAllInputs(object? sender, EventArgs e)
    {
        int dropDownHeight = 25;

        txtFName.Text = string.Empty;
        txtMName.Text = string.Empty;
        txtLName.Text = string.Empty;
        txtEName.Text = string.Empty;
        dateBDate.Value = DateTime.Now;
        dateBDate.Text = string.Empty;
        dateBDate.CustomFormat = " ";
        txtPBirth.Text = string.Empty;
        radioGenderM.Checked = false;
        radioGenderF.Checked = false;
        numAge.Value = 0;
        numAge.Text = string.Empty;
        txtCHouseNo.Text = string.Empty;
        txtCStreet.Text = string.Empty;
        //comboCCountry.Text = string.Empty;
        comboCProv.Text = string.Empty;
        comboCCity.Text = string.Empty;
        comboCCity.Items.Clear();
        comboCCity.DropDownHeight = dropDownHeight;
        comboCBrgy.Text = string.Empty;
        comboCBrgy.Items.Clear();
        comboCBrgy.DropDownHeight = dropDownHeight;
        numCZip.Value = 0;
        numCZip.Text = string.Empty;
        checkPAddress.Checked = false;
        txtPHouseNo.Text = string.Empty;
        txtPStreet.Text = string.Empty;
        //comboPCountry.Text = string.Empty;
        comboPProv.Text = string.Empty;
        comboPCity.Text = string.Empty;
        comboPCity.Items.Clear();
        comboPCity.DropDownHeight = dropDownHeight;
        comboPBrgy.Text = string.Empty;
        comboPBrgy.Items.Clear();
        comboPBrgy.DropDownHeight = dropDownHeight;
        numCZip.Value = 0;
        numPZip.Text = string.Empty;
    }

    // Setting combo controls
    private async ValueTask InitComboControlsAsync()
    {
        // comboCProv & comboPProv
        comboCProv.Items.Clear();
        comboPProv.Items.Clear();

        _provinces = await _dbSrvc.GetProvincesAsync();

        if (_provinces != null)
        {
            foreach (string provName in _provinces.Keys)
            {
                comboCProv.Items.Add(provName);
                comboPProv.Items.Add(provName);
            }
        }

        // comboCCity & comboCBrgy & comboPCity & comboPBrgy
        int dropDownHeight = 25;
        comboCCity.DropDownHeight = dropDownHeight;
        comboCBrgy.DropDownHeight = dropDownHeight;
        comboPCity.DropDownHeight = dropDownHeight;
        comboPBrgy.DropDownHeight = dropDownHeight;
    }

    // Populate city combos from province combos
    private async ValueTask InitComboCityAsync(ComboBox prov, ComboBox city)
    {
        string selected = (string)prov.SelectedItem;
        Province? selectedProv = _provinces?.GetValueOrDefault(selected);

        if (selectedProv != null)
        {
            // comboCCity
            city.Items.Clear();
            city.DropDownHeight = 250;

            _cities = await _dbSrvc.GetCitiesAsync(selectedProv.Code!.Value);

            if (_cities != null)
            {
                foreach (string cityName in _cities.Keys)
                {
                    city.Items.Add(cityName);
                }
            }
        }
    }

    // Populate brgy combos from city combos
    private async ValueTask InitComboBrgyAsync(ComboBox city, ComboBox bbrgy)
    {
        string selected = (string)city.SelectedItem;
        City? selectedCity = _cities?.GetValueOrDefault(selected);

        if (selectedCity != null)
        {
            // comboCBrgy
            bbrgy.Items.Clear();
            bbrgy.DropDownHeight = 250;

            _brgies = await _dbSrvc.GetBrgiesAsync(selectedCity.Code!.Value);

            if (_brgies != null)
            {
                foreach (Brgy brgy in _brgies)
                {
                    bbrgy.Items.Add(brgy.Name);
                }
            }
        }
    }

    // When one of province combos have been inputted a value
    private void comboProv_SelectedValueChanged(object? sender, EventArgs e)
    {
        ComboBox? main = null;
        ComboBox? box = null;

        if (sender != null)
        {
            main = (ComboBox)sender;

            box = main.Name switch
            {
                nameof(comboCProv) => comboCCity,
                nameof(comboPProv) => comboPCity,
                _ => null
            };
        }

        if (main != null && box != null)
        {
            InitComboCityAsync(main, box).Await(null,
            (ex) =>
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }
    }

    // When one of city combos have been inputted a value
    private void comboCity_SelectedValueChanged(object? sender, EventArgs e)
    {
        ComboBox? main = null;
        ComboBox? box = null;

        if (sender != null)
        {
            main = (ComboBox)sender;

            box = main.Name switch
            {
                nameof(comboCCity) => comboCBrgy,
                nameof(comboPCity) => comboPBrgy,
                _ => null
            };
        }

        if (main != null && box != null)
        {
            InitComboBrgyAsync(main, box).Await(null,
            (ex) =>
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }
    }

    #region Test
    private void checkPopulate_CheckedChanged(object? sender, EventArgs e)
    {
        if (checkPopulate.CheckState == CheckState.Checked)
        {
            radioGenderM.Checked = true;
            dateBDate.Value = new DateTime(1999, 2, 15);
            txtFName.Text = "Erwin";
            txtMName.Text = "Sanaani";
            txtLName.Text = "Hadjirul";
            txtEName.Text = "N/A";
            txtPBirth.Text = "Takut-takut, Jolo, Sulu";
            numAge.Value = 25;
            txtCHouseNo.Text = "516";
            txtCStreet.Text = "Mabolo";
            comboCProv.Text = "Zamboanga Del Sur";
            comboCCity.Text = "Zamboanga City";
            comboCBrgy.Text = "Sinunuc";
            numCZip.Value = 7000;
            txtPHouseNo.Text = "615";
            txtPStreet.Text = "Zone 3";
            comboPProv.Text = "Sulu";
            comboPCity.Text = "Jolo";
            comboPBrgy.Text = "Takut-takut";
            numPZip.Value = 4700;
        }
    }
    #endregion

    // Event Subscriber that runs when error invokes.
    private void Inputs_Error(object? sender, EventArgs e)
    {
        // txtFName
        if (string.IsNullOrWhiteSpace(txtFName.Text))
        {
            errorProvider.SetError(txtFName, mess.NullInputs);
        }

        // txtMName
        if (string.IsNullOrWhiteSpace(txtMName.Text))
        {
            errorProvider.SetError(txtMName, mess.NullInputs);
        }

        // txtLName
        if (string.IsNullOrWhiteSpace(txtLName.Text))
        {
            errorProvider.SetError(txtLName, mess.NullInputs);
        }

        // txtPBirth
        if (string.IsNullOrWhiteSpace(txtPBirth.Text))
        {
            errorProvider.SetError(txtPBirth, mess.NullInputs);
        }

        // dateBDate
        if (dateBDate.CustomFormat == " ")
        {
            errorProvider.SetError(dateBDate, mess.NullInputs);
        }

        // radioGenderM & radioGenderF
        if (!radioGenderM.Checked && !radioGenderF.Checked)
        {
            errorProvider.SetError(panelGender, mess.NullInputs);
        }

        // numAge
        if (string.IsNullOrWhiteSpace(numAge.Text))
        {
            errorProvider.SetError(numAge, mess.NullInputs);
        }

        // txtCHouseNo
        if (string.IsNullOrWhiteSpace(txtCHouseNo.Text))
        {
            errorProvider.SetError(txtCHouseNo, mess.NullInputs);
        }

        // txtCStreet
        if (string.IsNullOrWhiteSpace(txtCStreet.Text))
        {
            errorProvider.SetError(txtCStreet, mess.NullInputs);
        }

        // comboCProv
        if (string.IsNullOrWhiteSpace(comboCProv.Text))
        {
            errorProvider.SetError(comboCProv, mess.NullInputs);
        }

        // comboCCity
        if (string.IsNullOrWhiteSpace(comboCCity.Text))
        {
            errorProvider.SetError(comboCCity, mess.NullInputs);
        }

        // comboCBrgy
        if (string.IsNullOrWhiteSpace(comboCBrgy.Text))
        {
            errorProvider.SetError(comboCBrgy, mess.NullInputs);
        }

        // numCZip
        if (string.IsNullOrWhiteSpace(numCZip.Text))
        {
            errorProvider.SetError(numCZip, mess.NullInputs);
        }

        // txtPHouseNo
        if (string.IsNullOrWhiteSpace(txtPHouseNo.Text))
        {
            errorProvider.SetError(txtPHouseNo, mess.NullInputs);
        }

        // txtPStreet
        if (string.IsNullOrWhiteSpace(txtPStreet.Text))
        {
            errorProvider.SetError(txtPStreet, mess.NullInputs);
        }

        // comboPProv
        if (string.IsNullOrWhiteSpace(comboPProv.Text))
        {
            errorProvider.SetError(comboPProv, mess.NullInputs);
        }

        // comboPCity
        if (string.IsNullOrWhiteSpace(comboPCity.Text))
        {
            errorProvider.SetError(comboPCity, mess.NullInputs);
        }

        // comboPBrgy
        if (string.IsNullOrWhiteSpace(comboPBrgy.Text))
        {
            errorProvider.SetError(comboPBrgy, mess.NullInputs);
        }

        // numPZip
        if (string.IsNullOrWhiteSpace(numPZip.Text))
        {
            errorProvider.SetError(numPZip, mess.NullInputs);
        }
    }

    private void dateBDate_ValueChanged(object? sender, EventArgs e)
    {
        dateBDate.CustomFormat = "MMMM  dd,  yyyy";
        method.ClearErrorInputControl(errorProvider, dateBDate);
    }

    private void Controls_ValueOrTextChanged(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            method.ClearErrorInputControl(errorProvider, (Control)sender);
        }
    }

    private void radioGender_CheckedChanged(object? sender, EventArgs e)
    {
        method.ClearErrorInputControl(errorProvider, radioGenderF);
    }

    private void FormAppForm1_FormClosing(object sender, FormClosingEventArgs e)
    {
        _inputSrvc.ProcessToRun -= DataSettingProcess;
        _inputSrvc.InputClear -= ClearAllInputs;
        _inputSrvc.InputError -= Inputs_Error;
    }
}