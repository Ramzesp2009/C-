using InterfaceAsType;

class Gitara : IInstrument
{
    public void Play()
    {
        Console.WriteLine("Playing the guitar!");
    }
}

class Baraban : IInstrument
{
    public void Play()
    {
        Console.WriteLine("Playing the drum!");
    }
}

class Musicer
{
    private IInstrument instrument;

    public Musicer(IInstrument instrument)
    {
        this.instrument = instrument;
    }

    public void PlayInstrument()
    {
        instrument.Play();
    }
}
