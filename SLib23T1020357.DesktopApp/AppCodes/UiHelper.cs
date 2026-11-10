namespace SLib23T1020357.DesktopApp;

/// <summary>
/// Helper methods for UI controls.
/// </summary>
public static class UiHelper
{
    public static void ShowDateTimePickerValue(DateTimePicker dtp, DateTime? value)
    {
        if (value.HasValue)
        {
            dtp.Checked = true;
            dtp.Value = value.Value;
            dtp.CustomFormat = "dd/MM/yyyy";
        }
        else
        {
            dtp.Checked = false;
            dtp.CustomFormat = " ";
        }
    }
    public static void UpdateDateTimePickerFormat(DateTimePicker dtp)
    {
        if (dtp == null)
        {
            return;
        }

        dtp.CustomFormat = dtp.Checked ? "dd/MM/yyyy" : " ";
    }
    public static void RegisterDateTimePickerFormat(DateTimePicker dtp)
    {
        if (dtp == null)
        {
            return;
        }

        dtp.Format = DateTimePickerFormat.Custom;
        dtp.CustomFormat = dtp.Checked ? "dd/MM/yyyy" : " ";

        dtp.ValueChanged += (sender, e) =>
        {
            UpdateDateTimePickerFormat(sender as DateTimePicker);
        };
    }
}