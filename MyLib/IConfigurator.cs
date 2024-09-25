namespace MyLib
{
    public interface IConfigurator
    {
        public TType GetValue<TType>(string key);
        public void SetValue(string key, object value);
    }
}
