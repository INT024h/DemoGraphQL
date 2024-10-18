public class Query
{
    public ClassEpta GetClassEpta() =>
        new ClassEpta
        {
            FieldEpta = "C# on FreeBSD ЁПТА",
            SubClassEpta = new SubClassEpta
            {
                FieldSubClassEpta = Environment.OSVersion.Platform + " " + Environment.OSVersion.VersionString
            }
        };
}
