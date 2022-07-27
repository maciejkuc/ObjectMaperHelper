namespace ObjectMappingHelper.Interfaces
{
    public interface IExpresion
    {
        string Expresion { get; set; }
        string ExpresionValue { get; set; }
        string Add(string s);
        string Prefix(string s);
        string Sufix(string s);
        string Trim(string s);
        string GetExpresionValue();
    }
}