namespace SCSIMS.Statics;

// All methods that repeat itself in a file or number of files
// will be kept here.
public static class RepeatingMKeeper
{
    // Properties
    private static Control? Ctrl { get; set; }

    // Method used for user to be easily navigate from one control to the next control
    // when user clicked enter or down key, etc.
    public static void GoToNextInputControl(Form currentForm, Control sender, KeyEventArgs e)
    {
        try
        {
            Ctrl = sender;

            if (Ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {
                    currentForm.SelectNextControl(Ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    currentForm.SelectNextControl(Ctrl, false, true, true, true);
                }
            }
            else if (Ctrl is DateTimePicker)
            {
                if (e.KeyCode == Keys.Back)
                {
                    DateTimePicker date = (DateTimePicker)Ctrl;
                    date.Text = string.Empty;
                    date.CustomFormat = " ";
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    currentForm.SelectNextControl(Ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    currentForm.SelectNextControl(Ctrl, false, true, true, true);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    currentForm.SelectNextControl(Ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    currentForm.SelectNextControl(Ctrl, false, true, true, true);
                }
            }
        }
        finally
        {
            Ctrl = null;
        }
    }

    // Method used to clear the error provided by errorProvider
    public static void ClearErrorInputControl(ErrorProvider ep, Control sender)
    {
        try
        {
            Ctrl = sender;

            ep.SetError(Ctrl, null);
        }
        finally
        {
            Ctrl = null;
        }
    }
}
