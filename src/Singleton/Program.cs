internal class Program
{
    private static void Main(string[] args)
    {
        var instance = Singleton.Instance;

        instance.ShowMessage();
    }
}