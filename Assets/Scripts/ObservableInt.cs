public class ObservableInt
{
    int _value;
    public event System.Action<int> OnValueChanged;

    public int Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
            OnValueChanged?.Invoke(value);
        }
    }
    public ObservableInt()
    {
        _value = 0;
    }
}
