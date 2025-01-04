namespace SCSIMS.Forms;

partial class FormAppForm2
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
        numRTSchoolID = new NumericUpDown();
        checkPopulate = new CheckBox();
        panel1 = new Panel();
        picPrev = new PictureBox();
        picNext = new PictureBox();
        groupBox5 = new GroupBox();
        mTxtNum = new MaskedTextBox();
        btnRemoveFile = new Button();
        lblPictureName = new Label();
        lblPicture = new Label();
        btnPicture = new Button();
        pictureBox = new PictureBox();
        txtEmail = new TextBox();
        lblEmail = new Label();
        lblNo = new Label();
        comboCourse = new ComboBox();
        lblCourse = new Label();
        groupBox4 = new GroupBox();
        mTxtRTLastSchoolYear = new MaskedTextBox();
        checkRT = new CheckBox();
        numRTLastYearLvl = new NumericUpDown();
        lblRTSchoolID = new Label();
        lblRTLastSchoolYear = new Label();
        txtRTLastSchoolAtt = new TextBox();
        lblRTLastSchoolAtt = new Label();
        lblRTLastYearLvl = new Label();
        groupCAddress = new GroupBox();
        groupBox3 = new GroupBox();
        mTxtNumGuard = new MaskedTextBox();
        lblGuardNo = new Label();
        txtGuardLName = new TextBox();
        lblGuardLName = new Label();
        txtGuardMName = new TextBox();
        lblGuardMName = new Label();
        txtGuardFName = new TextBox();
        lblGuardFName = new Label();
        groupBox2 = new GroupBox();
        mTxtNumMother = new MaskedTextBox();
        lblMotherNo = new Label();
        txtMotherLName = new TextBox();
        lblMotherLName = new Label();
        txtMotherMName = new TextBox();
        lblMotherMName = new Label();
        txtMotherFName = new TextBox();
        lblMotherFName = new Label();
        groupBox1 = new GroupBox();
        mTxtNumFather = new MaskedTextBox();
        lblFatherNo = new Label();
        txtFatherLName = new TextBox();
        lblFatherLName = new Label();
        txtFatherMName = new TextBox();
        lblFatherMName = new Label();
        txtFatherFName = new TextBox();
        lblFatherFName = new Label();
        fileDialogPicture = new OpenFileDialog();
        errorProvider = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)numRTSchoolID).BeginInit();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picPrev).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picNext).BeginInit();
        groupBox5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
        groupBox4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numRTLastYearLvl).BeginInit();
        groupCAddress.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // numRTSchoolID
        // 
        numRTSchoolID.Anchor = AnchorStyles.None;
        numRTSchoolID.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        numRTSchoolID.Location = new Point(933, 69);
        numRTSchoolID.Margin = new Padding(3, 2, 3, 2);
        numRTSchoolID.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
        numRTSchoolID.Name = "numRTSchoolID";
        numRTSchoolID.Size = new Size(299, 29);
        numRTSchoolID.TabIndex = 16;
        numRTSchoolID.ValueChanged += Controls_ValueOrTextChanged;
        numRTSchoolID.KeyDown += Controls_KeyDown;
        // 
        // checkPopulate
        // 
        checkPopulate.AutoSize = true;
        checkPopulate.Location = new Point(3, 3);
        checkPopulate.Name = "checkPopulate";
        checkPopulate.Size = new Size(15, 14);
        checkPopulate.TabIndex = 28;
        checkPopulate.UseVisualStyleBackColor = true;
        checkPopulate.CheckedChanged += checkPopulate_CheckedChanged;
        // 
        // panel1
        // 
        panel1.Controls.Add(picPrev);
        panel1.Controls.Add(picNext);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 630);
        panel1.Margin = new Padding(3, 2, 3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(1337, 86);
        panel1.TabIndex = 27;
        // 
        // picPrev
        // 
        picPrev.Anchor = AnchorStyles.None;
        picPrev.Cursor = Cursors.Hand;
        picPrev.Image = Resources.Prev;
        picPrev.ImageLocation = "";
        picPrev.Location = new Point(592, 21);
        picPrev.Margin = new Padding(3, 2, 3, 2);
        picPrev.Name = "picPrev";
        picPrev.Size = new Size(50, 45);
        picPrev.SizeMode = PictureBoxSizeMode.StretchImage;
        picPrev.TabIndex = 25;
        picPrev.TabStop = false;
        picPrev.Click += picPrev_Click;
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
        picNext.TabIndex = 26;
        picNext.TabStop = false;
        picNext.Click += picNext_Click;
        // 
        // groupBox5
        // 
        groupBox5.Anchor = AnchorStyles.None;
        groupBox5.Controls.Add(mTxtNum);
        groupBox5.Controls.Add(btnRemoveFile);
        groupBox5.Controls.Add(lblPictureName);
        groupBox5.Controls.Add(lblPicture);
        groupBox5.Controls.Add(btnPicture);
        groupBox5.Controls.Add(pictureBox);
        groupBox5.Controls.Add(txtEmail);
        groupBox5.Controls.Add(lblEmail);
        groupBox5.Controls.Add(lblNo);
        groupBox5.Controls.Add(comboCourse);
        groupBox5.Controls.Add(lblCourse);
        groupBox5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox5.Location = new Point(40, 437);
        groupBox5.Margin = new Padding(3, 2, 3, 2);
        groupBox5.Name = "groupBox5";
        groupBox5.Padding = new Padding(3, 2, 3, 2);
        groupBox5.Size = new Size(1251, 172);
        groupBox5.TabIndex = 17;
        groupBox5.TabStop = false;
        // 
        // mTxtNum
        // 
        mTxtNum.Anchor = AnchorStyles.None;
        mTxtNum.Location = new Point(146, 63);
        mTxtNum.Mask = "+63-999-000-0000";
        mTxtNum.Name = "mTxtNum";
        mTxtNum.Size = new Size(490, 29);
        mTxtNum.TabIndex = 18;
        mTxtNum.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        mTxtNum.TextChanged += Controls_ValueOrTextChanged;
        mTxtNum.KeyDown += Controls_KeyDown;
        // 
        // btnRemoveFile
        // 
        btnRemoveFile.BackColor = Color.Transparent;
        btnRemoveFile.Cursor = Cursors.Hand;
        btnRemoveFile.ForeColor = Color.Red;
        btnRemoveFile.Location = new Point(919, 23);
        btnRemoveFile.Margin = new Padding(3, 2, 3, 2);
        btnRemoveFile.Name = "btnRemoveFile";
        btnRemoveFile.Size = new Size(33, 32);
        btnRemoveFile.TabIndex = 21;
        btnRemoveFile.Text = "x";
        btnRemoveFile.UseVisualStyleBackColor = false;
        btnRemoveFile.Click += btnRemoveFile_Click;
        // 
        // lblPictureName
        // 
        lblPictureName.AutoSize = true;
        lblPictureName.Location = new Point(974, 104);
        lblPictureName.Name = "lblPictureName";
        lblPictureName.Size = new Size(15, 21);
        lblPictureName.TabIndex = 41;
        lblPictureName.Text = " ";
        lblPictureName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblPicture
        // 
        lblPicture.AutoSize = true;
        lblPicture.Location = new Point(842, 65);
        lblPicture.Name = "lblPicture";
        lblPicture.Size = new Size(84, 42);
        lblPicture.TabIndex = 40;
        lblPicture.Text = "Upload your\r\nImage";
        lblPicture.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnPicture
        // 
        btnPicture.Anchor = AnchorStyles.None;
        btnPicture.BackColor = SystemColors.ActiveBorder;
        btnPicture.Cursor = Cursors.Hand;
        btnPicture.Location = new Point(978, 131);
        btnPicture.Margin = new Padding(3, 2, 3, 2);
        btnPicture.Name = "btnPicture";
        btnPicture.Size = new Size(232, 28);
        btnPicture.TabIndex = 20;
        btnPicture.Text = "Choose File";
        btnPicture.UseVisualStyleBackColor = false;
        btnPicture.Click += btnPicture_Click;
        btnPicture.KeyDown += Controls_KeyDown;
        // 
        // pictureBox
        // 
        pictureBox.Anchor = AnchorStyles.None;
        pictureBox.BackColor = Color.Transparent;
        pictureBox.BorderStyle = BorderStyle.FixedSingle;
        pictureBox.Location = new Point(812, 24);
        pictureBox.Margin = new Padding(0);
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new Size(144, 135);
        pictureBox.TabIndex = 39;
        pictureBox.TabStop = false;
        // 
        // txtEmail
        // 
        txtEmail.Anchor = AnchorStyles.None;
        txtEmail.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtEmail.Location = new Point(146, 104);
        txtEmail.Margin = new Padding(3, 2, 3, 2);
        txtEmail.MaxLength = 100;
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "(If Applicable)";
        txtEmail.Size = new Size(490, 29);
        txtEmail.TabIndex = 19;
        txtEmail.TextChanged += Controls_ValueOrTextChanged;
        txtEmail.KeyDown += Controls_KeyDown;
        // 
        // lblEmail
        // 
        lblEmail.Anchor = AnchorStyles.None;
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblEmail.Location = new Point(21, 107);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(43, 21);
        lblEmail.TabIndex = 38;
        lblEmail.Text = "Email";
        // 
        // lblNo
        // 
        lblNo.Anchor = AnchorStyles.None;
        lblNo.AutoSize = true;
        lblNo.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblNo.Location = new Point(21, 66);
        lblNo.Name = "lblNo";
        lblNo.Size = new Size(111, 21);
        lblNo.TabIndex = 37;
        lblNo.Text = "Contact Number";
        // 
        // comboCourse
        // 
        comboCourse.Anchor = AnchorStyles.None;
        comboCourse.FormattingEnabled = true;
        comboCourse.Location = new Point(146, 26);
        comboCourse.Margin = new Padding(3, 2, 3, 2);
        comboCourse.MaxLength = 100;
        comboCourse.Name = "comboCourse";
        comboCourse.Size = new Size(490, 29);
        comboCourse.TabIndex = 17;
        comboCourse.TextChanged += Controls_ValueOrTextChanged;
        comboCourse.KeyDown += Controls_KeyDown;
        // 
        // lblCourse
        // 
        lblCourse.Anchor = AnchorStyles.None;
        lblCourse.AutoSize = true;
        lblCourse.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblCourse.Location = new Point(21, 33);
        lblCourse.Name = "lblCourse";
        lblCourse.Size = new Size(49, 21);
        lblCourse.TabIndex = 36;
        lblCourse.Text = "Course";
        // 
        // groupBox4
        // 
        groupBox4.Anchor = AnchorStyles.None;
        groupBox4.Controls.Add(mTxtRTLastSchoolYear);
        groupBox4.Controls.Add(checkRT);
        groupBox4.Controls.Add(numRTSchoolID);
        groupBox4.Controls.Add(numRTLastYearLvl);
        groupBox4.Controls.Add(lblRTSchoolID);
        groupBox4.Controls.Add(lblRTLastSchoolYear);
        groupBox4.Controls.Add(txtRTLastSchoolAtt);
        groupBox4.Controls.Add(lblRTLastSchoolAtt);
        groupBox4.Controls.Add(lblRTLastYearLvl);
        groupBox4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox4.Location = new Point(40, 310);
        groupBox4.Margin = new Padding(3, 2, 3, 2);
        groupBox4.Name = "groupBox4";
        groupBox4.Padding = new Padding(3, 2, 3, 2);
        groupBox4.Size = new Size(1251, 114);
        groupBox4.TabIndex = 12;
        groupBox4.TabStop = false;
        groupBox4.Text = "FOR RETURNING AND THOSE WHO WILL TRANSFER IN";
        // 
        // mTxtRTLastSchoolYear
        // 
        mTxtRTLastSchoolYear.Anchor = AnchorStyles.None;
        mTxtRTLastSchoolYear.Location = new Point(933, 26);
        mTxtRTLastSchoolYear.Mask = "0000-0000";
        mTxtRTLastSchoolYear.Name = "mTxtRTLastSchoolYear";
        mTxtRTLastSchoolYear.Size = new Size(299, 29);
        mTxtRTLastSchoolYear.TabIndex = 13;
        mTxtRTLastSchoolYear.TextChanged += mTxtRTLastSchoolYear_ValueChanged;
        mTxtRTLastSchoolYear.KeyDown += Controls_KeyDown;
        // 
        // checkRT
        // 
        checkRT.Anchor = AnchorStyles.None;
        checkRT.AutoSize = true;
        checkRT.Location = new Point(21, 31);
        checkRT.Name = "checkRT";
        checkRT.Size = new Size(55, 25);
        checkRT.TabIndex = 17;
        checkRT.Text = "N/A";
        checkRT.UseVisualStyleBackColor = true;
        checkRT.CheckedChanged += checkRT_CheckedChanged;
        // 
        // numRTLastYearLvl
        // 
        numRTLastYearLvl.Anchor = AnchorStyles.None;
        numRTLastYearLvl.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        numRTLastYearLvl.Location = new Point(311, 27);
        numRTLastYearLvl.Margin = new Padding(3, 2, 3, 2);
        numRTLastYearLvl.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
        numRTLastYearLvl.Name = "numRTLastYearLvl";
        numRTLastYearLvl.Size = new Size(299, 29);
        numRTLastYearLvl.TabIndex = 12;
        numRTLastYearLvl.ValueChanged += Controls_ValueOrTextChanged;
        numRTLastYearLvl.KeyDown += Controls_KeyDown;
        // 
        // lblRTSchoolID
        // 
        lblRTSchoolID.Anchor = AnchorStyles.None;
        lblRTSchoolID.AutoSize = true;
        lblRTSchoolID.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblRTSchoolID.Location = new Point(717, 71);
        lblRTSchoolID.Name = "lblRTSchoolID";
        lblRTSchoolID.Size = new Size(67, 21);
        lblRTSchoolID.TabIndex = 8;
        lblRTSchoolID.Text = "School ID";
        // 
        // lblRTLastSchoolYear
        // 
        lblRTLastSchoolYear.Anchor = AnchorStyles.None;
        lblRTLastSchoolYear.AutoSize = true;
        lblRTLastSchoolYear.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblRTLastSchoolYear.Location = new Point(717, 32);
        lblRTLastSchoolYear.Name = "lblRTLastSchoolYear";
        lblRTLastSchoolYear.Size = new Size(180, 21);
        lblRTLastSchoolYear.TabIndex = 6;
        lblRTLastSchoolYear.Text = "Last School Year Completed";
        // 
        // txtRTLastSchoolAtt
        // 
        txtRTLastSchoolAtt.Anchor = AnchorStyles.None;
        txtRTLastSchoolAtt.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtRTLastSchoolAtt.Location = new Point(311, 65);
        txtRTLastSchoolAtt.Margin = new Padding(3, 2, 3, 2);
        txtRTLastSchoolAtt.MaxLength = 100;
        txtRTLastSchoolAtt.Name = "txtRTLastSchoolAtt";
        txtRTLastSchoolAtt.Size = new Size(299, 29);
        txtRTLastSchoolAtt.TabIndex = 15;
        txtRTLastSchoolAtt.TextChanged += Controls_ValueOrTextChanged;
        txtRTLastSchoolAtt.KeyDown += Controls_KeyDown;
        // 
        // lblRTLastSchoolAtt
        // 
        lblRTLastSchoolAtt.Anchor = AnchorStyles.None;
        lblRTLastSchoolAtt.AutoSize = true;
        lblRTLastSchoolAtt.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblRTLastSchoolAtt.Location = new Point(96, 71);
        lblRTLastSchoolAtt.Name = "lblRTLastSchoolAtt";
        lblRTLastSchoolAtt.Size = new Size(141, 21);
        lblRTLastSchoolAtt.TabIndex = 4;
        lblRTLastSchoolAtt.Text = "Last School Attended";
        // 
        // lblRTLastYearLvl
        // 
        lblRTLastYearLvl.Anchor = AnchorStyles.None;
        lblRTLastYearLvl.AutoSize = true;
        lblRTLastYearLvl.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblRTLastYearLvl.Location = new Point(96, 34);
        lblRTLastYearLvl.Name = "lblRTLastYearLvl";
        lblRTLastYearLvl.Size = new Size(172, 21);
        lblRTLastYearLvl.TabIndex = 2;
        lblRTLastYearLvl.Text = "Last Year Level Completed";
        // 
        // groupCAddress
        // 
        groupCAddress.Anchor = AnchorStyles.None;
        groupCAddress.BackColor = Color.Transparent;
        groupCAddress.Controls.Add(groupBox3);
        groupCAddress.Controls.Add(groupBox2);
        groupCAddress.Controls.Add(groupBox1);
        groupCAddress.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        groupCAddress.Location = new Point(40, 32);
        groupCAddress.Margin = new Padding(3, 2, 3, 2);
        groupCAddress.Name = "groupCAddress";
        groupCAddress.Padding = new Padding(3, 2, 3, 2);
        groupCAddress.Size = new Size(1251, 274);
        groupCAddress.TabIndex = 0;
        groupCAddress.TabStop = false;
        groupCAddress.Text = "PARENT'S/GUARDIAN'S INFORMATION";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(mTxtNumGuard);
        groupBox3.Controls.Add(lblGuardNo);
        groupBox3.Controls.Add(txtGuardLName);
        groupBox3.Controls.Add(lblGuardLName);
        groupBox3.Controls.Add(txtGuardMName);
        groupBox3.Controls.Add(lblGuardMName);
        groupBox3.Controls.Add(txtGuardFName);
        groupBox3.Controls.Add(lblGuardFName);
        groupBox3.Location = new Point(21, 185);
        groupBox3.Margin = new Padding(3, 2, 3, 2);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(3, 2, 3, 2);
        groupBox3.Size = new Size(1222, 74);
        groupBox3.TabIndex = 8;
        groupBox3.TabStop = false;
        groupBox3.Text = "Legal Guardian's Name";
        // 
        // mTxtNumGuard
        // 
        mTxtNumGuard.Anchor = AnchorStyles.None;
        mTxtNumGuard.Location = new Point(911, 40);
        mTxtNumGuard.Mask = "+63-999-000-0000";
        mTxtNumGuard.Name = "mTxtNumGuard";
        mTxtNumGuard.Size = new Size(300, 29);
        mTxtNumGuard.TabIndex = 11;
        mTxtNumGuard.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        mTxtNumGuard.TextChanged += Controls_ValueOrTextChanged;
        mTxtNumGuard.KeyDown += Controls_KeyDown;
        // 
        // lblGuardNo
        // 
        lblGuardNo.Anchor = AnchorStyles.None;
        lblGuardNo.AutoSize = true;
        lblGuardNo.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblGuardNo.Location = new Point(880, 17);
        lblGuardNo.Name = "lblGuardNo";
        lblGuardNo.Size = new Size(111, 21);
        lblGuardNo.TabIndex = 30;
        lblGuardNo.Text = "Contact Number";
        // 
        // txtGuardLName
        // 
        txtGuardLName.Anchor = AnchorStyles.None;
        txtGuardLName.BackColor = Color.White;
        txtGuardLName.BorderStyle = BorderStyle.None;
        txtGuardLName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtGuardLName.Location = new Point(587, 40);
        txtGuardLName.Margin = new Padding(3, 2, 3, 2);
        txtGuardLName.MaxLength = 100;
        txtGuardLName.Name = "txtGuardLName";
        txtGuardLName.Size = new Size(260, 22);
        txtGuardLName.TabIndex = 10;
        txtGuardLName.TextChanged += Controls_ValueOrTextChanged;
        txtGuardLName.KeyDown += Controls_KeyDown;
        // 
        // lblGuardLName
        // 
        lblGuardLName.Anchor = AnchorStyles.None;
        lblGuardLName.AutoSize = true;
        lblGuardLName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblGuardLName.Location = new Point(587, 17);
        lblGuardLName.Name = "lblGuardLName";
        lblGuardLName.Size = new Size(76, 21);
        lblGuardLName.TabIndex = 28;
        lblGuardLName.Text = "Last Name";
        // 
        // txtGuardMName
        // 
        txtGuardMName.Anchor = AnchorStyles.None;
        txtGuardMName.BackColor = Color.White;
        txtGuardMName.BorderStyle = BorderStyle.None;
        txtGuardMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtGuardMName.Location = new Point(307, 40);
        txtGuardMName.Margin = new Padding(3, 2, 3, 2);
        txtGuardMName.MaxLength = 100;
        txtGuardMName.Name = "txtGuardMName";
        txtGuardMName.Size = new Size(260, 22);
        txtGuardMName.TabIndex = 9;
        txtGuardMName.TextChanged += Controls_ValueOrTextChanged;
        txtGuardMName.KeyDown += Controls_KeyDown;
        // 
        // lblGuardMName
        // 
        lblGuardMName.Anchor = AnchorStyles.None;
        lblGuardMName.AutoSize = true;
        lblGuardMName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblGuardMName.Location = new Point(307, 17);
        lblGuardMName.Name = "lblGuardMName";
        lblGuardMName.Size = new Size(89, 21);
        lblGuardMName.TabIndex = 26;
        lblGuardMName.Text = "Middle Name";
        // 
        // txtGuardFName
        // 
        txtGuardFName.Anchor = AnchorStyles.None;
        txtGuardFName.BackColor = Color.White;
        txtGuardFName.BorderStyle = BorderStyle.None;
        txtGuardFName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtGuardFName.Location = new Point(27, 40);
        txtGuardFName.Margin = new Padding(3, 2, 3, 2);
        txtGuardFName.MaxLength = 100;
        txtGuardFName.Name = "txtGuardFName";
        txtGuardFName.Size = new Size(260, 22);
        txtGuardFName.TabIndex = 8;
        txtGuardFName.TextChanged += Controls_ValueOrTextChanged;
        txtGuardFName.KeyDown += Controls_KeyDown;
        // 
        // lblGuardFName
        // 
        lblGuardFName.Anchor = AnchorStyles.None;
        lblGuardFName.AutoSize = true;
        lblGuardFName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblGuardFName.Location = new Point(27, 17);
        lblGuardFName.Name = "lblGuardFName";
        lblGuardFName.Size = new Size(77, 21);
        lblGuardFName.TabIndex = 24;
        lblGuardFName.Text = "First Name";
        // 
        // groupBox2
        // 
        groupBox2.Anchor = AnchorStyles.None;
        groupBox2.Controls.Add(mTxtNumMother);
        groupBox2.Controls.Add(lblMotherNo);
        groupBox2.Controls.Add(txtMotherLName);
        groupBox2.Controls.Add(lblMotherLName);
        groupBox2.Controls.Add(txtMotherMName);
        groupBox2.Controls.Add(lblMotherMName);
        groupBox2.Controls.Add(txtMotherFName);
        groupBox2.Controls.Add(lblMotherFName);
        groupBox2.Location = new Point(21, 107);
        groupBox2.Margin = new Padding(3, 2, 3, 2);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(3, 2, 3, 2);
        groupBox2.Size = new Size(1222, 74);
        groupBox2.TabIndex = 4;
        groupBox2.TabStop = false;
        groupBox2.Text = "Mother's Maiden Name";
        // 
        // mTxtNumMother
        // 
        mTxtNumMother.Anchor = AnchorStyles.None;
        mTxtNumMother.Location = new Point(911, 37);
        mTxtNumMother.Mask = "+63-999-000-0000";
        mTxtNumMother.Name = "mTxtNumMother";
        mTxtNumMother.Size = new Size(300, 29);
        mTxtNumMother.TabIndex = 7;
        mTxtNumMother.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        mTxtNumMother.TextChanged += Controls_ValueOrTextChanged;
        mTxtNumMother.KeyDown += Controls_KeyDown;
        // 
        // lblMotherNo
        // 
        lblMotherNo.Anchor = AnchorStyles.None;
        lblMotherNo.AutoSize = true;
        lblMotherNo.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblMotherNo.Location = new Point(880, 17);
        lblMotherNo.Name = "lblMotherNo";
        lblMotherNo.Size = new Size(111, 21);
        lblMotherNo.TabIndex = 30;
        lblMotherNo.Text = "Contact Number";
        // 
        // txtMotherLName
        // 
        txtMotherLName.Anchor = AnchorStyles.None;
        txtMotherLName.BackColor = Color.White;
        txtMotherLName.BorderStyle = BorderStyle.None;
        txtMotherLName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtMotherLName.Location = new Point(587, 40);
        txtMotherLName.Margin = new Padding(3, 2, 3, 2);
        txtMotherLName.MaxLength = 100;
        txtMotherLName.Name = "txtMotherLName";
        txtMotherLName.Size = new Size(260, 22);
        txtMotherLName.TabIndex = 6;
        txtMotherLName.TextChanged += Controls_ValueOrTextChanged;
        txtMotherLName.KeyDown += Controls_KeyDown;
        // 
        // lblMotherLName
        // 
        lblMotherLName.Anchor = AnchorStyles.None;
        lblMotherLName.AutoSize = true;
        lblMotherLName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblMotherLName.Location = new Point(587, 17);
        lblMotherLName.Name = "lblMotherLName";
        lblMotherLName.Size = new Size(76, 21);
        lblMotherLName.TabIndex = 28;
        lblMotherLName.Text = "Last Name";
        // 
        // txtMotherMName
        // 
        txtMotherMName.Anchor = AnchorStyles.None;
        txtMotherMName.BackColor = Color.White;
        txtMotherMName.BorderStyle = BorderStyle.None;
        txtMotherMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtMotherMName.Location = new Point(307, 40);
        txtMotherMName.Margin = new Padding(3, 2, 3, 2);
        txtMotherMName.MaxLength = 100;
        txtMotherMName.Name = "txtMotherMName";
        txtMotherMName.Size = new Size(260, 22);
        txtMotherMName.TabIndex = 5;
        txtMotherMName.TextChanged += Controls_ValueOrTextChanged;
        txtMotherMName.KeyDown += Controls_KeyDown;
        // 
        // lblMotherMName
        // 
        lblMotherMName.Anchor = AnchorStyles.None;
        lblMotherMName.AutoSize = true;
        lblMotherMName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblMotherMName.Location = new Point(307, 17);
        lblMotherMName.Name = "lblMotherMName";
        lblMotherMName.Size = new Size(89, 21);
        lblMotherMName.TabIndex = 26;
        lblMotherMName.Text = "Middle Name";
        // 
        // txtMotherFName
        // 
        txtMotherFName.Anchor = AnchorStyles.None;
        txtMotherFName.BackColor = Color.White;
        txtMotherFName.BorderStyle = BorderStyle.None;
        txtMotherFName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtMotherFName.Location = new Point(27, 40);
        txtMotherFName.Margin = new Padding(3, 2, 3, 2);
        txtMotherFName.MaxLength = 100;
        txtMotherFName.Name = "txtMotherFName";
        txtMotherFName.Size = new Size(260, 22);
        txtMotherFName.TabIndex = 4;
        txtMotherFName.TextChanged += Controls_ValueOrTextChanged;
        txtMotherFName.KeyDown += Controls_KeyDown;
        // 
        // lblMotherFName
        // 
        lblMotherFName.Anchor = AnchorStyles.None;
        lblMotherFName.AutoSize = true;
        lblMotherFName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblMotherFName.Location = new Point(27, 17);
        lblMotherFName.Name = "lblMotherFName";
        lblMotherFName.Size = new Size(77, 21);
        lblMotherFName.TabIndex = 24;
        lblMotherFName.Text = "First Name";
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.None;
        groupBox1.Controls.Add(mTxtNumFather);
        groupBox1.Controls.Add(lblFatherNo);
        groupBox1.Controls.Add(txtFatherLName);
        groupBox1.Controls.Add(lblFatherLName);
        groupBox1.Controls.Add(txtFatherMName);
        groupBox1.Controls.Add(lblFatherMName);
        groupBox1.Controls.Add(txtFatherFName);
        groupBox1.Controls.Add(lblFatherFName);
        groupBox1.Location = new Point(21, 29);
        groupBox1.Margin = new Padding(3, 2, 3, 2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 2, 3, 2);
        groupBox1.Size = new Size(1222, 74);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Father's Name";
        // 
        // mTxtNumFather
        // 
        mTxtNumFather.Anchor = AnchorStyles.None;
        mTxtNumFather.Location = new Point(912, 39);
        mTxtNumFather.Mask = "+63-999-000-0000";
        mTxtNumFather.Name = "mTxtNumFather";
        mTxtNumFather.Size = new Size(299, 29);
        mTxtNumFather.TabIndex = 3;
        mTxtNumFather.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        mTxtNumFather.TextChanged += Controls_ValueOrTextChanged;
        mTxtNumFather.KeyDown += Controls_KeyDown;
        // 
        // lblFatherNo
        // 
        lblFatherNo.Anchor = AnchorStyles.None;
        lblFatherNo.AutoSize = true;
        lblFatherNo.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblFatherNo.Location = new Point(880, 19);
        lblFatherNo.Name = "lblFatherNo";
        lblFatherNo.Size = new Size(111, 21);
        lblFatherNo.TabIndex = 30;
        lblFatherNo.Text = "Contact Number";
        // 
        // txtFatherLName
        // 
        txtFatherLName.Anchor = AnchorStyles.None;
        txtFatherLName.BackColor = Color.White;
        txtFatherLName.BorderStyle = BorderStyle.None;
        txtFatherLName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtFatherLName.Location = new Point(587, 42);
        txtFatherLName.Margin = new Padding(3, 2, 3, 2);
        txtFatherLName.MaxLength = 100;
        txtFatherLName.Name = "txtFatherLName";
        txtFatherLName.Size = new Size(260, 22);
        txtFatherLName.TabIndex = 2;
        txtFatherLName.TextChanged += Controls_ValueOrTextChanged;
        txtFatherLName.KeyDown += Controls_KeyDown;
        // 
        // lblFatherLName
        // 
        lblFatherLName.Anchor = AnchorStyles.None;
        lblFatherLName.AutoSize = true;
        lblFatherLName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblFatherLName.Location = new Point(587, 19);
        lblFatherLName.Name = "lblFatherLName";
        lblFatherLName.Size = new Size(76, 21);
        lblFatherLName.TabIndex = 28;
        lblFatherLName.Text = "Last Name";
        // 
        // txtFatherMName
        // 
        txtFatherMName.Anchor = AnchorStyles.None;
        txtFatherMName.BackColor = Color.White;
        txtFatherMName.BorderStyle = BorderStyle.None;
        txtFatherMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtFatherMName.Location = new Point(307, 42);
        txtFatherMName.Margin = new Padding(3, 2, 3, 2);
        txtFatherMName.MaxLength = 100;
        txtFatherMName.Name = "txtFatherMName";
        txtFatherMName.Size = new Size(260, 22);
        txtFatherMName.TabIndex = 1;
        txtFatherMName.TextChanged += Controls_ValueOrTextChanged;
        txtFatherMName.KeyDown += Controls_KeyDown;
        // 
        // lblFatherMName
        // 
        lblFatherMName.Anchor = AnchorStyles.None;
        lblFatherMName.AutoSize = true;
        lblFatherMName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblFatherMName.Location = new Point(307, 19);
        lblFatherMName.Name = "lblFatherMName";
        lblFatherMName.Size = new Size(89, 21);
        lblFatherMName.TabIndex = 26;
        lblFatherMName.Text = "Middle Name";
        // 
        // txtFatherFName
        // 
        txtFatherFName.Anchor = AnchorStyles.None;
        txtFatherFName.BackColor = Color.White;
        txtFatherFName.BorderStyle = BorderStyle.None;
        txtFatherFName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
        txtFatherFName.Location = new Point(27, 42);
        txtFatherFName.Margin = new Padding(3, 2, 3, 2);
        txtFatherFName.MaxLength = 100;
        txtFatherFName.Name = "txtFatherFName";
        txtFatherFName.Size = new Size(260, 22);
        txtFatherFName.TabIndex = 0;
        txtFatherFName.TextChanged += Controls_ValueOrTextChanged;
        txtFatherFName.KeyDown += Controls_KeyDown;
        // 
        // lblFatherFName
        // 
        lblFatherFName.Anchor = AnchorStyles.None;
        lblFatherFName.AutoSize = true;
        lblFatherFName.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblFatherFName.Location = new Point(27, 19);
        lblFatherFName.Name = "lblFatherFName";
        lblFatherFName.Size = new Size(77, 21);
        lblFatherFName.TabIndex = 24;
        lblFatherFName.Text = "First Name";
        // 
        // fileDialogPicture
        // 
        fileDialogPicture.InitialDirectory = " Pictures";
        fileDialogPicture.FileOk += fileDialogPicture_OK;
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // FormAppForm2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = Color.Turquoise;
        ClientSize = new Size(1337, 716);
        ControlBox = false;
        Controls.Add(checkPopulate);
        Controls.Add(panel1);
        Controls.Add(groupBox5);
        Controls.Add(groupBox4);
        Controls.Add(groupCAddress);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        Name = "FormAppForm2";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        FormClosing += FormAppForm2_FormClosing;
        ((System.ComponentModel.ISupportInitialize)numRTSchoolID).EndInit();
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picPrev).EndInit();
        ((System.ComponentModel.ISupportInitialize)picNext).EndInit();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numRTLastYearLvl).EndInit();
        groupCAddress.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private GroupBox groupCAddress;
    private GroupBox groupBox1;
    private Label lblFatherNo;
    private TextBox txtFatherLName;
    private Label lblFatherLName;
    private TextBox txtFatherMName;
    private Label lblFatherMName;
    private TextBox txtFatherFName;
    private Label lblFatherFName;
    private GroupBox groupBox2;
    private Label lblMotherNo;
    private TextBox txtMotherLName;
    private Label lblMotherLName;
    private TextBox txtMotherMName;
    private Label lblMotherMName;
    private TextBox txtMotherFName;
    private Label lblMotherFName;
    private GroupBox groupBox3;
    private Label lblGuardNo;
    private TextBox txtGuardLName;
    private Label lblGuardLName;
    private TextBox txtGuardMName;
    private Label lblGuardMName;
    private TextBox txtGuardFName;
    private Label lblGuardFName;
    private GroupBox groupBox4;
    private Label lblRTLastYearLvl;
    private Label lblRTLastSchoolYear;
    private TextBox txtRTLastSchoolAtt;
    private Label lblRTLastSchoolAtt;
    private Label lblRTSchoolID;
    private PictureBox picPrev;
    private PictureBox picNext;
    private NumericUpDown numRTLastYearLvl;
    private NumericUpDown numRTSchoolID;
    private GroupBox groupBox5;
    private TextBox txtEmail;
    private Label lblEmail;
    private Label lblNo;
    private ComboBox comboCourse;
    private Label lblCourse;
    private PictureBox pictureBox;
    private Button btnPicture;
    private Label lblPicture;
    private OpenFileDialog fileDialogPicture;
    private Panel panel1;
    private Label lblPictureName;
    private Button btnRemoveFile;
    private CheckBox checkPopulate;
    private ErrorProvider errorProvider;
    private CheckBox checkRT;
    private MaskedTextBox mTxtRTLastSchoolYear;
    private MaskedTextBox mTxtNumFather;
    private MaskedTextBox mTxtNumGuard;
    private MaskedTextBox mTxtNumMother;
    private MaskedTextBox mTxtNum;
}