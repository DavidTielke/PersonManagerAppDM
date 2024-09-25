namespace MyLib;

public class MemoryConfigurator : IConfigurator
{
    private Dictionary<string, object> _items;

    public MemoryConfigurator()
    {
        _items = new Dictionary<string, object>();
    }

    public TItem GetValue<TItem>(string key)
    {
        var value = (TItem)_items[key];
        return value;
    }

    public void SetValue(string key, object value)
    {
        _items[key] = value;
    }
}