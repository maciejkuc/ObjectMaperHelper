namespace ObjectMaper.Interfaces
{
    internal interface IMapping
    {
        string ColumnName { get; set; }
        int Index { get; set; }
        string HeaderName { get; set; }
        IExpresion Expresion { get; set; }
        

    }
}