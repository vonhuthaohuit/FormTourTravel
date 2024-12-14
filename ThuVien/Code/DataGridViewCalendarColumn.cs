using System.Windows.Forms;
using System;

public class DataGridViewCalendarColumn : DataGridViewColumn
{
    public DataGridViewCalendarColumn()
        : base(new DataGridViewCalendarCell())
    {
    }

    public override DataGridViewCell CellTemplate
    {
        get => base.CellTemplate;
        set
        {
            if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewCalendarCell)))
            {
                throw new InvalidCastException("Must be a DataGridViewCalendarCell");
            }
            base.CellTemplate = value;
        }
    }
}

public class DataGridViewCalendarCell : DataGridViewTextBoxCell
{
    public DataGridViewCalendarCell() : base()
    {
        this.Style.Format = "d"; // Format ngày
    }

    public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
    {
        base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
        var control = DataGridView.EditingControl as CalendarEditingControl;
        if (this.Value == null || this.Value == DBNull.Value)
        {
            control.Value = DateTime.Today;
        }
        else
        {
            control.Value = (DateTime)this.Value;
        }
    }

    public override Type EditType => typeof(CalendarEditingControl);

    public override Type ValueType => typeof(DateTime);

    public override object DefaultNewRowValue => DateTime.Today;
}

public class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
{
    DataGridView dataGridView;
    private bool valueChanged = false;
    private int rowIndex;

    public CalendarEditingControl()
    {
        this.Format = DateTimePickerFormat.Short; // Format ngắn gọn
    }

    public object EditingControlFormattedValue
    {
        get => this.Value.ToShortDateString();
        set
        {
            if (value is string dateValue)
            {
                this.Value = DateTime.TryParse(dateValue, out var result) ? result : DateTime.Today;
            }
        }
    }

    public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
    {
        return this.EditingControlFormattedValue;
    }

    public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
    {
        this.Font = dataGridViewCellStyle.Font;
        this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
        this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
    }

    public int EditingControlRowIndex
    {
        get => rowIndex;
        set => rowIndex = value;
    }

    public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
    {
        return (keyData & Keys.KeyCode) == Keys.Left ||
               (keyData & Keys.KeyCode) == Keys.Right ||
               (keyData & Keys.KeyCode) == Keys.Up ||
               (keyData & Keys.KeyCode) == Keys.Down ||
               (keyData & Keys.KeyCode) == Keys.Enter ||
               (keyData & Keys.KeyCode) == Keys.Escape;
    }

    public void PrepareEditingControlForEdit(bool selectAll)
    {
    }

    public bool RepositionEditingControlOnValueChange => false;

    public DataGridView EditingControlDataGridView
    {
        get => dataGridView;
        set => dataGridView = value;
    }

    public bool EditingControlValueChanged
    {
        get => valueChanged;
        set => valueChanged = value;
    }

    public Cursor EditingPanelCursor => Cursors.Default;

    protected override void OnValueChanged(EventArgs eventargs)
    {
        valueChanged = true;
        this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
        base.OnValueChanged(eventargs);
    }
}
