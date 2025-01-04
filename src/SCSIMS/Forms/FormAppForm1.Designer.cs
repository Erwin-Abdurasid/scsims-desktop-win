namespace SCSIMS.Forms;

partial class FormAppForm1
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
        checkPopulate = new CheckBox();
        numAge = new NumericUpDown();
        groupCAddress = new GroupBox();
        panel7 = new Panel();
        numCZip = new NumericUpDown();
        lblCZip = new Label();
        panel6 = new Panel();
        comboCBrgy = new ComboBox();
        lblCBrgy = new Label();
        panel5 = new Panel();
        comboCCity = new ComboBox();
        lblCMOCity = new Label();
        panel4 = new Panel();
        comboCProv = new ComboBox();
        lblCProv = new Label();
        panel3 = new Panel();
        comboCCountry = new ComboBox();
        lblCCountry = new Label();
        panel2 = new Panel();
        txtCStreet = new TextBox();
        lblCStreet = new Label();
        panel1 = new Panel();
        txtCHouseNo = new TextBox();
        lblCHouseNo = new Label();
        panelGender = new Panel();
        radioGenderM = new RadioButton();
        radioGenderF = new RadioButton();
        checkPAddress = new CheckBox();
        lblAge = new Label();
        panel17 = new Panel();
        picNext = new PictureBox();
        label1 = new Label();
        groupPAddress = new GroupBox();
        panel8 = new Panel();
        numPZip = new NumericUpDown();
        lblPZip = new Label();
        panel9 = new Panel();
        comboPBrgy = new ComboBox();
        lblPBrgy = new Label();
        panel10 = new Panel();
        comboPCity = new ComboBox();
        lblPMOCity = new Label();
        panel11 = new Panel();
        comboPProv = new ComboBox();
        lblPProv = new Label();
        panel12 = new Panel();
        comboPCountry = new ComboBox();
        lblPCountry = new Label();
        panel13 = new Panel();
        txtPStreet = new TextBox();
        lblPStreet = new Label();
        panel14 = new Panel();
        txtPHouseNo = new TextBox();
        lblPHouseNo = new Label();
        txtPBirth = new TextBox();
        lblPBirth = new Label();
        lblFName = new Label();
        dateBDate = new DateTimePicker();
        txtFName = new TextBox();
        lblBDate = new Label();
        lblMName = new Label();
        txtEName = new TextBox();
        txtMName = new TextBox();
        lblEName = new Label();
        lblLName = new Label();
        txtLName = new TextBox();
        errorProvider = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
        groupCAddress.SuspendLayout();
        panel7.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numCZip).BeginInit();
        panel6.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        panel3.SuspendLayout();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        panelGender.SuspendLayout();
        panel17.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picNext).BeginInit();
        groupPAddress.SuspendLayout();
        panel8.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numPZip).BeginInit();
        panel9.SuspendLayout();
        panel10.SuspendLayout();
        panel11.SuspendLayout();
        panel12.SuspendLayout();
        panel13.SuspendLayout();
        panel14.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // checkPopulate
        // 
        checkPopulate.AutoSize = true;
        checkPopulate.Location = new Point(3, 3);
        checkPopulate.Name = "checkPopulate";
        checkPopulate.Size = new Size(15, 14);
        checkPopulate.TabIndex = 37;
        checkPopulate.UseVisualStyleBackColor = true;
        checkPopulate.CheckedChanged += checkPopulate_CheckedChanged;
        // 
        // numAge
        // 
        numAge.Anchor = AnchorStyles.None;
        numAge.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        numAge.Location = new Point(854, 141);
        numAge.Margin = new Padding(3, 2, 3, 2);
        numAge.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numAge.Name = "numAge";
        numAge.Size = new Size(431, 29);
        numAge.TabIndex = 8;
        numAge.ValueChanged += Controls_ValueOrTextChanged;
        numAge.KeyDown += Controls_KeyDown;
        // 
        // groupCAddress
        // 
        groupCAddress.Anchor = AnchorStyles.None;
        groupCAddress.BackColor = Color.Transparent;
        groupCAddress.Controls.Add(panel7);
        groupCAddress.Controls.Add(panel6);
        groupCAddress.Controls.Add(panel5);
        groupCAddress.Controls.Add(panel4);
        groupCAddress.Controls.Add(panel3);
        groupCAddress.Controls.Add(panel2);
        groupCAddress.Controls.Add(panel1);
        groupCAddress.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        groupCAddress.Location = new Point(33, 208);
        groupCAddress.Margin = new Padding(3, 2, 3, 2);
        groupCAddress.Name = "groupCAddress";
        groupCAddress.Padding = new Padding(3, 2, 3, 2);
        groupCAddress.Size = new Size(1253, 175);
        groupCAddress.TabIndex = 34;
        groupCAddress.TabStop = false;
        groupCAddress.Text = "Current Address";
        // 
        // panel7
        // 
        panel7.Anchor = AnchorStyles.None;
        panel7.BorderStyle = BorderStyle.FixedSingle;
        panel7.Controls.Add(numCZip);
        panel7.Controls.Add(lblCZip);
        panel7.Location = new Point(982, 96);
        panel7.Margin = new Padding(3, 2, 3, 2);
        panel7.Name = "panel7";
        panel7.Size = new Size(265, 67);
        panel7.TabIndex = 15;
        // 
        // numCZip
        // 
        numCZip.Anchor = AnchorStyles.None;
        numCZip.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        numCZip.Location = new Point(3, 29);
        numCZip.Margin = new Padding(3, 2, 3, 2);
        numCZip.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        numCZip.Name = "numCZip";
        numCZip.Size = new Size(236, 29);
        numCZip.TabIndex = 15;
        numCZip.ValueChanged += Controls_ValueOrTextChanged;
        numCZip.KeyDown += Controls_KeyDown;
        // 
        // lblCZip
        // 
        lblCZip.Anchor = AnchorStyles.None;
        lblCZip.AutoSize = true;
        lblCZip.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblCZip.Location = new Point(3, 9);
        lblCZip.Name = "lblCZip";
        lblCZip.Size = new Size(64, 21);
        lblCZip.TabIndex = 30;
        lblCZip.Text = "Zip Code";
        // 
        // panel6
        // 
        panel6.Anchor = AnchorStyles.None;
        panel6.BorderStyle = BorderStyle.FixedSingle;
        panel6.Controls.Add(comboCBrgy);
        panel6.Controls.Add(lblCBrgy);
        panel6.Location = new Point(612, 96);
        panel6.Margin = new Padding(3, 2, 3, 2);
        panel6.Name = "panel6";
        panel6.Size = new Size(362, 67);
        panel6.TabIndex = 14;
        // 
        // comboCBrgy
        // 
        comboCBrgy.Anchor = AnchorStyles.None;
        comboCBrgy.DropDownHeight = 250;
        comboCBrgy.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        comboCBrgy.FormattingEnabled = true;
        comboCBrgy.IntegralHeight = false;
        comboCBrgy.Location = new Point(2, 27);
        comboCBrgy.MaxLength = 100;
        comboCBrgy.Name = "comboCBrgy";
        comboCBrgy.Size = new Size(334, 29);
        comboCBrgy.TabIndex = 14;
        comboCBrgy.TextChanged += Controls_ValueOrTextChanged;
        comboCBrgy.KeyDown += Controls_KeyDown;
        // 
        // lblCBrgy
        // 
        lblCBrgy.Anchor = AnchorStyles.None;
        lblCBrgy.AutoSize = true;
        lblCBrgy.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblCBrgy.Location = new Point(3, 9);
        lblCBrgy.Name = "lblCBrgy";
        lblCBrgy.Size = new Size(75, 21);
        lblCBrgy.TabIndex = 22;
        lblCBrgy.Text = "Baranggay";
        // 
        // panel5
        // 
        panel5.Anchor = AnchorStyles.None;
        panel5.BorderStyle = BorderStyle.FixedSingle;
        panel5.Controls.Add(comboCCity);
        panel5.Controls.Add(lblCMOCity);
        panel5.Location = new Point(272, 96);
        panel5.Margin = new Padding(3, 2, 3, 2);
        panel5.Name = "panel5";
        panel5.Size = new Size(334, 67);
        panel5.TabIndex = 13;
        // 
        // comboCCity
        // 
        comboCCity.Anchor = AnchorStyles.None;
        comboCCity.DropDownHeight = 250;
        comboCCity.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        comboCCity.FormattingEnabled = true;
        comboCCity.IntegralHeight = false;
        comboCCity.Location = new Point(3, 27);
        comboCCity.MaxLength = 100;
        comboCCity.Name = "comboCCity";
        comboCCity.Size = new Size(304, 29);
        comboCCity.TabIndex = 13;
        comboCCity.SelectedValueChanged += comboCity_SelectedValueChanged;
        comboCCity.TextChanged += Controls_ValueOrTextChanged;
        comboCCity.KeyDown += Controls_KeyDown;
        // 
        // lblCMOCity
        // 
        lblCMOCity.Anchor = AnchorStyles.None;
        lblCMOCity.AutoSize = true;
        lblCMOCity.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblCMOCity.Location = new Point(3, 9);
        lblCMOCity.Name = "lblCMOCity";
        lblCMOCity.Size = new Size(113, 21);
        lblCMOCity.TabIndex = 24;
        lblCMOCity.Text = "Municipality/City";
        // 
        // panel4
        // 
        panel4.Anchor = AnchorStyles.None;
        panel4.BorderStyle = BorderStyle.FixedSingle;
        panel4.Controls.Add(comboCProv);
        panel4.Controls.Add(lblCProv);
        panel4.Location = new Point(5, 96);
        panel4.Margin = new Padding(3, 2, 3, 2);
        panel4.Name = "panel4";
        panel4.Size = new Size(261, 67);
        panel4.TabIndex = 12;
        // 
        // comboCProv
        // 
        comboCProv.Anchor = AnchorStyles.None;
        comboCProv.DropDownHeight = 250;
        comboCProv.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        comboCProv.FormattingEnabled = true;
        comboCProv.IntegralHeight = false;
        comboCProv.Location = new Point(3, 27);
        comboCProv.MaxLength = 100;
        comboCProv.Name = "comboCProv";
        comboCProv.Size = new Size(231, 29);
        comboCProv.TabIndex = 12;
        comboCProv.SelectedValueChanged += comboProv_SelectedValueChanged;
        comboCProv.TextChanged += Controls_ValueOrTextChanged;
        comboCProv.KeyDown += Controls_KeyDown;
        // 
        // lblCProv
        // 
        lblCProv.Anchor = AnchorStyles.None;
        lblCProv.AutoSize = true;
        lblCProv.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblCProv.Location = new Point(3, 9);
        lblCProv.Name = "lblCProv";
        lblCProv.Size = new Size(61, 21);
        lblCProv.TabIndex = 26;
        lblCProv.Text = "Province";
        // 
        // panel3
        // 
        panel3.Anchor = AnchorStyles.None;
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Controls.Add(comboCCountry);
        panel3.Controls.Add(lblCCountry);
        panel3.Location = new Point(792, 25);
        panel3.Margin = new Padding(3, 2, 3, 2);
        panel3.Name = "panel3";
        panel3.Size = new Size(455, 67);
        panel3.TabIndex = 11;
        // 
        // comboCCountry
        // 
        comboCCountry.Anchor = AnchorStyles.None;
        comboCCountry.Enabled = false;
        comboCCountry.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        comboCCountry.FormattingEnabled = true;
        comboCCountry.Location = new Point(2, 25);
        comboCCountry.MaxLength = 100;
        comboCCountry.Name = "comboCCountry";
        comboCCountry.Size = new Size(426, 29);
        comboCCountry.TabIndex = 11;
        comboCCountry.Text = "Philippines";
        comboCCountry.TextChanged += Controls_ValueOrTextChanged;
        comboCCountry.KeyDown += Controls_KeyDown;
        // 
        // lblCCountry
        // 
        lblCCountry.Anchor = AnchorStyles.None;
        lblCCountry.AutoSize = true;
        lblCCountry.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblCCountry.Location = new Point(3, 7);
        lblCCountry.Name = "lblCCountry";
        lblCCountry.Size = new Size(59, 21);
        lblCCountry.TabIndex = 28;
        lblCCountry.Text = "Country";
        // 
        // panel2
        // 
        panel2.Anchor = AnchorStyles.None;
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(txtCStreet);
        panel2.Controls.Add(lblCStreet);
        panel2.Location = new Point(352, 25);
        panel2.Margin = new Padding(3, 2, 3, 2);
        panel2.Name = "panel2";
        panel2.Size = new Size(434, 67);
        panel2.TabIndex = 10;
        // 
        // txtCStreet
        // 
        txtCStreet.Anchor = AnchorStyles.None;
        txtCStreet.BackColor = Color.White;
        txtCStreet.BorderStyle = BorderStyle.None;
        txtCStreet.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtCStreet.Location = new Point(3, 28);
        txtCStreet.Margin = new Padding(3, 2, 3, 2);
        txtCStreet.MaxLength = 100;
        txtCStreet.Name = "txtCStreet";
        txtCStreet.Size = new Size(405, 22);
        txtCStreet.TabIndex = 10;
        txtCStreet.TextChanged += Controls_ValueOrTextChanged;
        txtCStreet.KeyDown += Controls_KeyDown;
        // 
        // lblCStreet
        // 
        lblCStreet.Anchor = AnchorStyles.None;
        lblCStreet.AutoSize = true;
        lblCStreet.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblCStreet.Location = new Point(3, 7);
        lblCStreet.Name = "lblCStreet";
        lblCStreet.Size = new Size(88, 21);
        lblCStreet.TabIndex = 22;
        lblCStreet.Text = "Street Name";
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.None;
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(txtCHouseNo);
        panel1.Controls.Add(lblCHouseNo);
        panel1.Location = new Point(5, 25);
        panel1.Margin = new Padding(3, 2, 3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(341, 67);
        panel1.TabIndex = 9;
        // 
        // txtCHouseNo
        // 
        txtCHouseNo.Anchor = AnchorStyles.None;
        txtCHouseNo.BackColor = Color.White;
        txtCHouseNo.BorderStyle = BorderStyle.None;
        txtCHouseNo.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtCHouseNo.Location = new Point(3, 28);
        txtCHouseNo.Margin = new Padding(3, 2, 3, 2);
        txtCHouseNo.MaxLength = 100;
        txtCHouseNo.Name = "txtCHouseNo";
        txtCHouseNo.Size = new Size(312, 22);
        txtCHouseNo.TabIndex = 9;
        txtCHouseNo.TextChanged += Controls_ValueOrTextChanged;
        txtCHouseNo.KeyDown += Controls_KeyDown;
        // 
        // lblCHouseNo
        // 
        lblCHouseNo.Anchor = AnchorStyles.None;
        lblCHouseNo.AutoSize = true;
        lblCHouseNo.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblCHouseNo.Location = new Point(3, 7);
        lblCHouseNo.Name = "lblCHouseNo";
        lblCHouseNo.Size = new Size(70, 21);
        lblCHouseNo.TabIndex = 20;
        lblCHouseNo.Text = "House No.";
        // 
        // panelGender
        // 
        panelGender.Anchor = AnchorStyles.None;
        panelGender.BorderStyle = BorderStyle.FixedSingle;
        panelGender.Controls.Add(radioGenderM);
        panelGender.Controls.Add(radioGenderF);
        panelGender.Location = new Point(854, 104);
        panelGender.Margin = new Padding(3, 2, 3, 2);
        panelGender.Name = "panelGender";
        panelGender.Size = new Size(431, 32);
        panelGender.TabIndex = 6;
        // 
        // radioGenderM
        // 
        radioGenderM.Anchor = AnchorStyles.None;
        radioGenderM.AutoSize = true;
        radioGenderM.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        radioGenderM.Location = new Point(4, 3);
        radioGenderM.Margin = new Padding(3, 2, 3, 2);
        radioGenderM.Name = "radioGenderM";
        radioGenderM.Size = new Size(55, 25);
        radioGenderM.TabIndex = 6;
        radioGenderM.TabStop = true;
        radioGenderM.Tag = "";
        radioGenderM.Text = "Male";
        radioGenderM.UseVisualStyleBackColor = true;
        radioGenderM.CheckedChanged += radioGender_CheckedChanged;
        radioGenderM.KeyDown += Controls_KeyDown;
        // 
        // radioGenderF
        // 
        radioGenderF.Anchor = AnchorStyles.None;
        radioGenderF.AutoSize = true;
        radioGenderF.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        radioGenderF.Location = new Point(192, 2);
        radioGenderF.Margin = new Padding(3, 2, 3, 2);
        radioGenderF.Name = "radioGenderF";
        radioGenderF.Size = new Size(69, 25);
        radioGenderF.TabIndex = 7;
        radioGenderF.TabStop = true;
        radioGenderF.Tag = "";
        radioGenderF.Text = "Female";
        radioGenderF.UseVisualStyleBackColor = true;
        radioGenderF.CheckedChanged += radioGender_CheckedChanged;
        radioGenderF.KeyDown += Controls_KeyDown;
        // 
        // checkPAddress
        // 
        checkPAddress.Anchor = AnchorStyles.None;
        checkPAddress.AutoSize = true;
        checkPAddress.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        checkPAddress.Location = new Point(32, 409);
        checkPAddress.Margin = new Padding(3, 2, 3, 2);
        checkPAddress.Name = "checkPAddress";
        checkPAddress.Size = new Size(427, 25);
        checkPAddress.TabIndex = 35;
        checkPAddress.Text = "Is your Permanent Address the same with your Current Address?";
        checkPAddress.UseVisualStyleBackColor = true;
        checkPAddress.CheckedChanged += checkPAddress_CheckedChanged;
        checkPAddress.KeyDown += Controls_KeyDown;
        // 
        // lblAge
        // 
        lblAge.Anchor = AnchorStyles.None;
        lblAge.AutoSize = true;
        lblAge.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblAge.Location = new Point(744, 144);
        lblAge.Name = "lblAge";
        lblAge.Size = new Size(32, 21);
        lblAge.TabIndex = 33;
        lblAge.Text = "Age";
        // 
        // panel17
        // 
        panel17.Controls.Add(picNext);
        panel17.Dock = DockStyle.Bottom;
        panel17.Location = new Point(0, 630);
        panel17.Margin = new Padding(3, 2, 3, 2);
        panel17.Name = "panel17";
        panel17.Size = new Size(1337, 86);
        panel17.TabIndex = 23;
        // 
        // picNext
        // 
        picNext.Anchor = AnchorStyles.None;
        picNext.Cursor = Cursors.Hand;
        picNext.Image = Resources.Next;
        picNext.ImageLocation = "";
        picNext.Location = new Point(695, 21);
        picNext.Margin = new Padding(3, 2, 3, 2);
        picNext.Name = "picNext";
        picNext.Size = new Size(50, 45);
        picNext.SizeMode = PictureBoxSizeMode.StretchImage;
        picNext.TabIndex = 22;
        picNext.TabStop = false;
        picNext.Click += picNext_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(741, 109);
        label1.Name = "label1";
        label1.Size = new Size(53, 21);
        label1.TabIndex = 32;
        label1.Text = "Gender";
        // 
        // groupPAddress
        // 
        groupPAddress.Anchor = AnchorStyles.None;
        groupPAddress.BackColor = Color.Transparent;
        groupPAddress.Controls.Add(panel8);
        groupPAddress.Controls.Add(panel9);
        groupPAddress.Controls.Add(panel10);
        groupPAddress.Controls.Add(panel11);
        groupPAddress.Controls.Add(panel12);
        groupPAddress.Controls.Add(panel13);
        groupPAddress.Controls.Add(panel14);
        groupPAddress.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        groupPAddress.Location = new Point(32, 438);
        groupPAddress.Margin = new Padding(3, 2, 3, 2);
        groupPAddress.Name = "groupPAddress";
        groupPAddress.Padding = new Padding(3, 2, 3, 2);
        groupPAddress.Size = new Size(1254, 176);
        groupPAddress.TabIndex = 36;
        groupPAddress.TabStop = false;
        groupPAddress.Text = "Permanent Address";
        // 
        // panel8
        // 
        panel8.Anchor = AnchorStyles.None;
        panel8.BorderStyle = BorderStyle.FixedSingle;
        panel8.Controls.Add(numPZip);
        panel8.Controls.Add(lblPZip);
        panel8.Location = new Point(982, 96);
        panel8.Margin = new Padding(3, 2, 3, 2);
        panel8.Name = "panel8";
        panel8.Size = new Size(265, 67);
        panel8.TabIndex = 23;
        // 
        // numPZip
        // 
        numPZip.Anchor = AnchorStyles.None;
        numPZip.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        numPZip.Location = new Point(3, 29);
        numPZip.Margin = new Padding(3, 2, 3, 2);
        numPZip.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        numPZip.Name = "numPZip";
        numPZip.Size = new Size(236, 29);
        numPZip.TabIndex = 23;
        numPZip.ValueChanged += Controls_ValueOrTextChanged;
        numPZip.KeyDown += Controls_KeyDown;
        // 
        // lblPZip
        // 
        lblPZip.Anchor = AnchorStyles.None;
        lblPZip.AutoSize = true;
        lblPZip.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblPZip.Location = new Point(3, 9);
        lblPZip.Name = "lblPZip";
        lblPZip.Size = new Size(64, 21);
        lblPZip.TabIndex = 30;
        lblPZip.Text = "Zip Code";
        // 
        // panel9
        // 
        panel9.Anchor = AnchorStyles.None;
        panel9.BorderStyle = BorderStyle.FixedSingle;
        panel9.Controls.Add(comboPBrgy);
        panel9.Controls.Add(lblPBrgy);
        panel9.Location = new Point(612, 96);
        panel9.Margin = new Padding(3, 2, 3, 2);
        panel9.Name = "panel9";
        panel9.Size = new Size(363, 67);
        panel9.TabIndex = 22;
        // 
        // comboPBrgy
        // 
        comboPBrgy.Anchor = AnchorStyles.None;
        comboPBrgy.DropDownHeight = 250;
        comboPBrgy.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        comboPBrgy.FormattingEnabled = true;
        comboPBrgy.IntegralHeight = false;
        comboPBrgy.Location = new Point(3, 29);
        comboPBrgy.MaxLength = 100;
        comboPBrgy.Name = "comboPBrgy";
        comboPBrgy.Size = new Size(334, 29);
        comboPBrgy.TabIndex = 22;
        comboPBrgy.TextChanged += Controls_ValueOrTextChanged;
        comboPBrgy.KeyDown += Controls_KeyDown;
        // 
        // lblPBrgy
        // 
        lblPBrgy.Anchor = AnchorStyles.None;
        lblPBrgy.AutoSize = true;
        lblPBrgy.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblPBrgy.Location = new Point(3, 9);
        lblPBrgy.Name = "lblPBrgy";
        lblPBrgy.Size = new Size(75, 21);
        lblPBrgy.TabIndex = 22;
        lblPBrgy.Text = "Baranggay";
        // 
        // panel10
        // 
        panel10.BorderStyle = BorderStyle.FixedSingle;
        panel10.Controls.Add(comboPCity);
        panel10.Controls.Add(lblPMOCity);
        panel10.Location = new Point(272, 96);
        panel10.Margin = new Padding(3, 2, 3, 2);
        panel10.Name = "panel10";
        panel10.Size = new Size(334, 67);
        panel10.TabIndex = 21;
        // 
        // comboPCity
        // 
        comboPCity.Anchor = AnchorStyles.None;
        comboPCity.DropDownHeight = 250;
        comboPCity.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        comboPCity.FormattingEnabled = true;
        comboPCity.IntegralHeight = false;
        comboPCity.Location = new Point(4, 28);
        comboPCity.MaxLength = 100;
        comboPCity.Name = "comboPCity";
        comboPCity.Size = new Size(304, 29);
        comboPCity.TabIndex = 21;
        comboPCity.SelectedValueChanged += comboCity_SelectedValueChanged;
        comboPCity.TextChanged += Controls_ValueOrTextChanged;
        comboPCity.KeyDown += Controls_KeyDown;
        // 
        // lblPMOCity
        // 
        lblPMOCity.Anchor = AnchorStyles.None;
        lblPMOCity.AutoSize = true;
        lblPMOCity.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblPMOCity.Location = new Point(3, 9);
        lblPMOCity.Name = "lblPMOCity";
        lblPMOCity.Size = new Size(113, 21);
        lblPMOCity.TabIndex = 24;
        lblPMOCity.Text = "Municipality/City";
        // 
        // panel11
        // 
        panel11.Anchor = AnchorStyles.None;
        panel11.BorderStyle = BorderStyle.FixedSingle;
        panel11.Controls.Add(comboPProv);
        panel11.Controls.Add(lblPProv);
        panel11.Location = new Point(5, 96);
        panel11.Margin = new Padding(3, 2, 3, 2);
        panel11.Name = "panel11";
        panel11.Size = new Size(261, 67);
        panel11.TabIndex = 20;
        // 
        // comboPProv
        // 
        comboPProv.Anchor = AnchorStyles.None;
        comboPProv.DropDownHeight = 250;
        comboPProv.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        comboPProv.FormattingEnabled = true;
        comboPProv.IntegralHeight = false;
        comboPProv.Location = new Point(4, 28);
        comboPProv.MaxLength = 100;
        comboPProv.Name = "comboPProv";
        comboPProv.Size = new Size(231, 29);
        comboPProv.TabIndex = 20;
        comboPProv.SelectedValueChanged += comboProv_SelectedValueChanged;
        comboPProv.TextChanged += Controls_ValueOrTextChanged;
        comboPProv.KeyDown += Controls_KeyDown;
        // 
        // lblPProv
        // 
        lblPProv.Anchor = AnchorStyles.None;
        lblPProv.AutoSize = true;
        lblPProv.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblPProv.Location = new Point(3, 9);
        lblPProv.Name = "lblPProv";
        lblPProv.Size = new Size(61, 21);
        lblPProv.TabIndex = 26;
        lblPProv.Text = "Province";
        // 
        // panel12
        // 
        panel12.Anchor = AnchorStyles.None;
        panel12.BorderStyle = BorderStyle.FixedSingle;
        panel12.Controls.Add(comboPCountry);
        panel12.Controls.Add(lblPCountry);
        panel12.Location = new Point(792, 25);
        panel12.Margin = new Padding(3, 2, 3, 2);
        panel12.Name = "panel12";
        panel12.Size = new Size(455, 67);
        panel12.TabIndex = 19;
        // 
        // comboPCountry
        // 
        comboPCountry.Anchor = AnchorStyles.None;
        comboPCountry.Enabled = false;
        comboPCountry.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        comboPCountry.FormattingEnabled = true;
        comboPCountry.Location = new Point(4, 25);
        comboPCountry.MaxLength = 100;
        comboPCountry.Name = "comboPCountry";
        comboPCountry.Size = new Size(426, 29);
        comboPCountry.TabIndex = 19;
        comboPCountry.Text = "Philippines";
        comboPCountry.TextChanged += Controls_ValueOrTextChanged;
        comboPCountry.KeyDown += Controls_KeyDown;
        // 
        // lblPCountry
        // 
        lblPCountry.Anchor = AnchorStyles.None;
        lblPCountry.AutoSize = true;
        lblPCountry.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblPCountry.Location = new Point(3, 6);
        lblPCountry.Name = "lblPCountry";
        lblPCountry.Size = new Size(59, 21);
        lblPCountry.TabIndex = 28;
        lblPCountry.Text = "Country";
        // 
        // panel13
        // 
        panel13.Anchor = AnchorStyles.None;
        panel13.BorderStyle = BorderStyle.FixedSingle;
        panel13.Controls.Add(txtPStreet);
        panel13.Controls.Add(lblPStreet);
        panel13.Location = new Point(352, 25);
        panel13.Margin = new Padding(3, 2, 3, 2);
        panel13.Name = "panel13";
        panel13.Size = new Size(434, 67);
        panel13.TabIndex = 18;
        // 
        // txtPStreet
        // 
        txtPStreet.Anchor = AnchorStyles.None;
        txtPStreet.BackColor = Color.White;
        txtPStreet.BorderStyle = BorderStyle.None;
        txtPStreet.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtPStreet.Location = new Point(3, 28);
        txtPStreet.Margin = new Padding(3, 2, 3, 2);
        txtPStreet.MaxLength = 100;
        txtPStreet.Name = "txtPStreet";
        txtPStreet.Size = new Size(405, 22);
        txtPStreet.TabIndex = 18;
        txtPStreet.TextChanged += Controls_ValueOrTextChanged;
        txtPStreet.KeyDown += Controls_KeyDown;
        // 
        // lblPStreet
        // 
        lblPStreet.Anchor = AnchorStyles.None;
        lblPStreet.AutoSize = true;
        lblPStreet.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblPStreet.Location = new Point(3, 7);
        lblPStreet.Name = "lblPStreet";
        lblPStreet.Size = new Size(88, 21);
        lblPStreet.TabIndex = 22;
        lblPStreet.Text = "Street Name";
        // 
        // panel14
        // 
        panel14.Anchor = AnchorStyles.None;
        panel14.BorderStyle = BorderStyle.FixedSingle;
        panel14.Controls.Add(txtPHouseNo);
        panel14.Controls.Add(lblPHouseNo);
        panel14.Location = new Point(5, 25);
        panel14.Margin = new Padding(3, 2, 3, 2);
        panel14.Name = "panel14";
        panel14.Size = new Size(341, 67);
        panel14.TabIndex = 17;
        // 
        // txtPHouseNo
        // 
        txtPHouseNo.Anchor = AnchorStyles.None;
        txtPHouseNo.BackColor = Color.White;
        txtPHouseNo.BorderStyle = BorderStyle.None;
        txtPHouseNo.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtPHouseNo.Location = new Point(3, 28);
        txtPHouseNo.Margin = new Padding(3, 2, 3, 2);
        txtPHouseNo.MaxLength = 100;
        txtPHouseNo.Name = "txtPHouseNo";
        txtPHouseNo.Size = new Size(312, 22);
        txtPHouseNo.TabIndex = 17;
        txtPHouseNo.TextChanged += Controls_ValueOrTextChanged;
        txtPHouseNo.KeyDown += Controls_KeyDown;
        // 
        // lblPHouseNo
        // 
        lblPHouseNo.Anchor = AnchorStyles.None;
        lblPHouseNo.AutoSize = true;
        lblPHouseNo.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblPHouseNo.Location = new Point(3, 7);
        lblPHouseNo.Name = "lblPHouseNo";
        lblPHouseNo.Size = new Size(70, 21);
        lblPHouseNo.TabIndex = 20;
        lblPHouseNo.Text = "House No.";
        // 
        // txtPBirth
        // 
        txtPBirth.Anchor = AnchorStyles.None;
        txtPBirth.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtPBirth.Location = new Point(854, 71);
        txtPBirth.Margin = new Padding(3, 2, 3, 2);
        txtPBirth.MaxLength = 100;
        txtPBirth.Name = "txtPBirth";
        txtPBirth.PlaceholderText = "(Municipality/City)";
        txtPBirth.Size = new Size(432, 29);
        txtPBirth.TabIndex = 5;
        txtPBirth.TextChanged += Controls_ValueOrTextChanged;
        txtPBirth.KeyDown += Controls_KeyDown;
        // 
        // lblPBirth
        // 
        lblPBirth.Anchor = AnchorStyles.None;
        lblPBirth.AutoSize = true;
        lblPBirth.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblPBirth.Location = new Point(741, 74);
        lblPBirth.Name = "lblPBirth";
        lblPBirth.Size = new Size(92, 21);
        lblPBirth.TabIndex = 31;
        lblPBirth.Text = "Place of Birth";
        // 
        // lblFName
        // 
        lblFName.Anchor = AnchorStyles.None;
        lblFName.AutoSize = true;
        lblFName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblFName.Location = new Point(32, 38);
        lblFName.Name = "lblFName";
        lblFName.Size = new Size(77, 21);
        lblFName.TabIndex = 19;
        lblFName.Text = "First Name";
        // 
        // dateBDate
        // 
        dateBDate.Anchor = AnchorStyles.None;
        dateBDate.CalendarMonthBackground = SystemColors.GradientInactiveCaption;
        dateBDate.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
        dateBDate.CalendarTitleForeColor = SystemColors.GrayText;
        dateBDate.CalendarTrailingForeColor = Color.DarkOrange;
        dateBDate.CustomFormat = " ";
        dateBDate.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        dateBDate.Format = DateTimePickerFormat.Custom;
        dateBDate.Location = new Point(854, 32);
        dateBDate.Margin = new Padding(3, 2, 3, 2);
        dateBDate.Name = "dateBDate";
        dateBDate.RightToLeft = RightToLeft.No;
        dateBDate.Size = new Size(431, 29);
        dateBDate.TabIndex = 4;
        dateBDate.ValueChanged += dateBDate_ValueChanged;
        dateBDate.KeyDown += Controls_KeyDown;
        // 
        // txtFName
        // 
        txtFName.Anchor = AnchorStyles.None;
        txtFName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtFName.Location = new Point(134, 36);
        txtFName.Margin = new Padding(3, 2, 3, 2);
        txtFName.MaxLength = 100;
        txtFName.Name = "txtFName";
        txtFName.Size = new Size(449, 29);
        txtFName.TabIndex = 0;
        txtFName.TextChanged += Controls_ValueOrTextChanged;
        txtFName.KeyDown += Controls_KeyDown;
        // 
        // lblBDate
        // 
        lblBDate.Anchor = AnchorStyles.None;
        lblBDate.AutoSize = true;
        lblBDate.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblBDate.Location = new Point(741, 38);
        lblBDate.Name = "lblBDate";
        lblBDate.Size = new Size(68, 21);
        lblBDate.TabIndex = 30;
        lblBDate.Text = "Birthdate";
        // 
        // lblMName
        // 
        lblMName.Anchor = AnchorStyles.None;
        lblMName.AutoSize = true;
        lblMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblMName.Location = new Point(32, 73);
        lblMName.Name = "lblMName";
        lblMName.Size = new Size(89, 21);
        lblMName.TabIndex = 22;
        lblMName.Text = "Middle Name";
        // 
        // txtEName
        // 
        txtEName.Anchor = AnchorStyles.None;
        txtEName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtEName.Location = new Point(134, 141);
        txtEName.Margin = new Padding(3, 2, 3, 2);
        txtEName.MaxLength = 10;
        txtEName.Name = "txtEName";
        txtEName.PlaceholderText = "(If Applicable)";
        txtEName.Size = new Size(449, 29);
        txtEName.TabIndex = 3;
        txtEName.TextChanged += Controls_ValueOrTextChanged;
        txtEName.KeyDown += Controls_KeyDown;
        // 
        // txtMName
        // 
        txtMName.Anchor = AnchorStyles.None;
        txtMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtMName.Location = new Point(134, 71);
        txtMName.Margin = new Padding(3, 2, 3, 2);
        txtMName.MaxLength = 100;
        txtMName.Name = "txtMName";
        txtMName.Size = new Size(449, 29);
        txtMName.TabIndex = 1;
        txtMName.TextChanged += Controls_ValueOrTextChanged;
        txtMName.KeyDown += Controls_KeyDown;
        // 
        // lblEName
        // 
        lblEName.Anchor = AnchorStyles.None;
        lblEName.AutoSize = true;
        lblEName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblEName.Location = new Point(33, 144);
        lblEName.Name = "lblEName";
        lblEName.Size = new Size(73, 21);
        lblEName.TabIndex = 28;
        lblEName.Text = "Ext. Name";
        // 
        // lblLName
        // 
        lblLName.Anchor = AnchorStyles.None;
        lblLName.AutoSize = true;
        lblLName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblLName.Location = new Point(32, 109);
        lblLName.Name = "lblLName";
        lblLName.Size = new Size(76, 21);
        lblLName.TabIndex = 25;
        lblLName.Text = "Last Name";
        // 
        // txtLName
        // 
        txtLName.Anchor = AnchorStyles.None;
        txtLName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtLName.Location = new Point(134, 106);
        txtLName.Margin = new Padding(3, 2, 3, 2);
        txtLName.MaxLength = 100;
        txtLName.Name = "txtLName";
        txtLName.Size = new Size(449, 29);
        txtLName.TabIndex = 2;
        txtLName.TextChanged += Controls_ValueOrTextChanged;
        txtLName.KeyDown += Controls_KeyDown;
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // FormAppForm1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = Color.Turquoise;
        ClientSize = new Size(1337, 716);
        ControlBox = false;
        Controls.Add(checkPopulate);
        Controls.Add(numAge);
        Controls.Add(groupCAddress);
        Controls.Add(panelGender);
        Controls.Add(checkPAddress);
        Controls.Add(lblAge);
        Controls.Add(panel17);
        Controls.Add(label1);
        Controls.Add(groupPAddress);
        Controls.Add(txtPBirth);
        Controls.Add(lblPBirth);
        Controls.Add(lblFName);
        Controls.Add(dateBDate);
        Controls.Add(txtFName);
        Controls.Add(lblBDate);
        Controls.Add(lblMName);
        Controls.Add(txtEName);
        Controls.Add(txtMName);
        Controls.Add(lblEName);
        Controls.Add(lblLName);
        Controls.Add(txtLName);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Margin = new Padding(3, 2, 3, 2);
        Name = "FormAppForm1";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        FormClosing += FormAppForm1_FormClosing;
        Load += FormAppForm1_Load;
        ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
        groupCAddress.ResumeLayout(false);
        panel7.ResumeLayout(false);
        panel7.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numCZip).EndInit();
        panel6.ResumeLayout(false);
        panel6.PerformLayout();
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panelGender.ResumeLayout(false);
        panelGender.PerformLayout();
        panel17.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picNext).EndInit();
        groupPAddress.ResumeLayout(false);
        panel8.ResumeLayout(false);
        panel8.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numPZip).EndInit();
        panel9.ResumeLayout(false);
        panel9.PerformLayout();
        panel10.ResumeLayout(false);
        panel10.PerformLayout();
        panel11.ResumeLayout(false);
        panel11.PerformLayout();
        panel12.ResumeLayout(false);
        panel12.PerformLayout();
        panel13.ResumeLayout(false);
        panel13.PerformLayout();
        panel14.ResumeLayout(false);
        panel14.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private PictureBox picNext;
    private GroupBox groupCAddress;
    private Panel panel7;
    private NumericUpDown numCZip;
    private Label lblCZip;
    private Panel panel6;
    private Label lblCCountry;
    private Panel panel5;
    private Label lblCProv;
    private Panel panel4;
    private Label lblCMOCity;
    private Panel panel3;
    private Label lblCBrgy;
    private Panel panel2;
    private TextBox txtCStreet;
    private Label lblCStreet;
    private NumericUpDown numAge;
    private Panel panelGender;
    private RadioButton radioGenderM;
    private RadioButton radioGenderF;
    private Label lblAge;
    private Label label1;
    private TextBox txtPBirth;
    private Label lblPBirth;
    private DateTimePicker dateBDate;
    private Label lblBDate;
    private TextBox txtEName;
    private Label lblEName;
    private TextBox txtLName;
    private Label lblLName;
    private TextBox txtMName;
    private Label lblMName;
    private TextBox txtFName;
    private Label lblFName;
    private CheckBox checkPAddress;
    private GroupBox groupPAddress;
    private Panel panel8;
    private NumericUpDown numPZip;
    private Label lblPZip;
    private Panel panel9;
    private Label lblPCountry;
    private Panel panel10;
    private Label lblPProv;
    private Panel panel11;
    private Label lblPMOCity;
    private Panel panel12;
    private Label lblPBrgy;
    private Panel panel13;
    private TextBox txtPStreet;
    private Label lblPStreet;
    private Panel panel14;
    private TextBox txtPHouseNo;
    private Label lblPHouseNo;
    private Panel panel17;
    private ComboBox comboCCountry;
    private ComboBox comboPCountry;
    private ComboBox comboCProv;
    private ComboBox comboCCity;
    private ComboBox comboCBrgy;
    private ComboBox comboPBrgy;
    private ComboBox comboPCity;
    private ComboBox comboPProv;
    private CheckBox checkPopulate;
    private ErrorProvider errorProvider;
    private Panel panel1;
    private TextBox txtCHouseNo;
    private Label lblCHouseNo;
}