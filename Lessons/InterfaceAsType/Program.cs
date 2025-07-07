namespace InterfaceAsType
{
    class Program
    {
        static void Main(string[] args)
        {
            Musicer musicer_1 = new Musicer(new Gitara());
            Musicer musicer_2 = new Musicer(new Baraban());
            musicer_1.PlayInstrument();
            musicer_2.PlayInstrument();
        }
    }
}