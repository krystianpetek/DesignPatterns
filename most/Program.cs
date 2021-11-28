using System;
using System.Text;

public interface ITelewizor
{
    int Kanal { get; set; }
    void Wlacz();
    void Wylacz();
    void ZmienKanal(int kanal);
    bool Stan { get; set; }
}

public class TvLg : ITelewizor
{
    public TvLg()
    {
        this.Kanal = 1;
        this.Stan = false;
    }

    public int Kanal { get; set; }
    public bool Stan { get; set; }

    public void Wlacz()
    {
        Console.WriteLine("Telewizor LG włączony.");
        Stan = true;
    }

    public void Wylacz()
    {
        Console.WriteLine("Telewizor LG wyłączony.");
        Stan = false;
    }

    public void ZmienKanal(int kanal)
    {
        this.Kanal = kanal;
        Console.WriteLine($"Telewizor LG, kanał: {Kanal}");
    }
}

public class TvXiaomi : ITelewizor
{
    public TvXiaomi()
    {
        this.Kanal = 1;
    }

    public int Kanal { get; set; }
    public bool Stan { get; set; }

    public void Wlacz()
    {
        if(!Stan)
        Console.WriteLine("Telewizor Xiaomi włączony.");
        Stan = true;
    }

    public void Wylacz()
    {
        Console.WriteLine("Telewizor Xiaomi wyłączony.");
        Stan = false;
    }

    public void ZmienKanal(int kanal)
    {
        this.Kanal = kanal;
        Console.WriteLine($"Telewizor Xiaomi, kanał: {Kanal}");
    }
}

public abstract class PilotAbstrakcyjny
{
    public ITelewizor tv;
    public PilotAbstrakcyjny(ITelewizor tv)
    {
        this.tv = tv;
    }
    public abstract void DoWlacz();
    public abstract void DoWylacz();
    public abstract void DoZmienKanal(int v);
}

public class PilotHarmony : PilotAbstrakcyjny
{
    public PilotHarmony(ITelewizor tv) : base(tv) { }

    public override void DoWlacz()
    {
        if (!tv.Stan)
        {
            Console.WriteLine("Pilot Harmony włącza telewizor...");
            tv.Wlacz();
        }
        else
        {
            Console.WriteLine("Telewizor został już włączony");
        }
    }

    public override void DoWylacz()
    {
        if (tv.Stan)
        {
            Console.WriteLine("Pilot Harmony wyłącza telewizor...");
            tv.Wylacz();
        }
        else
        {
            Console.WriteLine("Telewizor został już wyłączony");
        }
    }

    public override void DoZmienKanal(int v)
    {
        if (tv.Stan)
        {
            Console.WriteLine("Pilot Philips zmienia kanał...");
            tv.ZmienKanal(v);
        }
        else
        {
            Console.WriteLine("Telewizor jest wyłączony");
        }
    }
}

public class PilotPhilips : PilotAbstrakcyjny
{
    public PilotPhilips(ITelewizor tv) : base(tv) { }

    public override void DoWylacz()
    {
        if (tv.Stan)
        {
            Console.WriteLine("Pilot Philips wyłącza telewizor...");
            tv.Wylacz();
        }
        else
        {
            Console.WriteLine("Telewizor został już wyłączony");
        }
    }

    public override void DoWlacz()
    {
        if (!tv.Stan)
        {
            tv.Wlacz();
            Console.WriteLine("Pilot Philips włącza telewizor...");
        }
        else
        {
            Console.WriteLine("Telewizor został już włączony");
        }
    }

    public override void DoZmienKanal(int v)
    {
        if (tv.Stan)
        {
            Console.WriteLine("Pilot Philips zmienia kanał...");
            tv.ZmienKanal(v);
        }
        else
        {
            Console.WriteLine("Telewizor jest wyłączony");
        }
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        ITelewizor tv = new TvLg();
        PilotAbstrakcyjny pilotHarmony = new PilotHarmony(tv);
        PilotAbstrakcyjny pilotPhilips = new PilotPhilips(tv);

        pilotHarmony.DoWlacz();
        Console.WriteLine("Kanał: " + tv.Kanal);
        pilotPhilips.DoZmienKanal(100);
        Console.WriteLine("Kanał: " + tv.Kanal);
        pilotHarmony.DoWylacz();
    }
}















//using System;


//public interface ITelewizor
//{

//	int Kanal { get; set; }
//	//
//	//
//	void ZmienKanal(int kanal);

//}



//public class TvLg : ITelewizor
//{

//	public TvLg()
//	{
//		this.Kanal = 1;
//	}

//	public int Kanal { get; set; }

//	public void Wlacz()
//	{
//		Console.WriteLine("Telewizor LG włączony.");
//	}

//	public void Wylacz()
//	{
//		//
//		//
//	}

//	public void ZmienKanal(int kanal)
//	{
//		//
//		//
//	}

//}



//public class TvXiaomi : ITelewizor
//{

//	//
//	//

//}



//public abstract class PilotAbstrakcyjny
//{

//	private ITelewizor tv;

//	public PilotAbstrakcyjny(ITelewizor tv)
//	{
//		//
//		//
//	}

//	//
//	//

//	public void ZmienKanal(int kanal)
//	{
//		//
//		//
//	}

//}



//public class PilotHarmony : PilotAbstrakcyjny
//{

//	public PilotHarmony(ITelewizor tv) : base(tv) { }

//	public void DoWlacz()
//	{
//		Console.WriteLine("Pilot Harmony włącza telewizor...");
//		Wlacz();
//	}

//	//
//	//

//}

//public class PilotPhilips : PilotAbstrakcyjny
//{

//	//
//	//

//	public void DoWylacz()
//	{
//		Console.WriteLine("Pilot Philips wyłącza telewizor...");
//		Wylacz();
//	}

//}



//class MainClass
//{
//	public static void Main(string[] args)
//	{

//		ITelewizor tv = new TvLg();
//		//
//		//

//		pilotHarmony.DoWlacz();
//		Console.WriteLine("Kanał: " + tv.Kanal);
//		pilotPhilips.DoZmienKanal(100);
//		Console.WriteLine("Kanał: " + tv.Kanal);
//		pilotHarmony.DoWylacz();

//	}
//}





















//using System;


//public interface ITelewizor
//{
//	int Kanal { get; set; }
//	void ZmienKanal(int kanal);
//}

//public class TvLg : ITelewizor
//{

//	public TvLg()
//	{
//		this.Kanal = 1;
//	}

//	public int Kanal { get; set; }

//	public void Wlacz()
//	{
//		Console.WriteLine("Telewizor LG włączony.");
//	}

//	public void Wylacz()
//	{
//		throw new NotImplementedException();
//	}

//	public void ZmienKanal(int kanal)
//	{
//		throw new NotImplementedException();
//	}

//}

//public abstract class PilotAbstrakcyjny
//{

//	private ITelewizor tv;

//	public PilotAbstrakcyjny(ITelewizor tv)
//	{
//		this.tv = tv;
//	}

//	public void ZmienKanal(int kanal)
//	{
//		tv.ZmienKanal(kanal);
//	}

//	public abstract void DoWlacz();

//}

//public class PilotHarmony : PilotAbstrakcyjny
//{

//	public PilotHarmony(ITelewizor tv) : base(tv) { }

//	public override void DoWlacz()
//	{
//		Console.WriteLine("Pilot Harmony włącza telewizor...");
//	}

//	public void DoWylacz()
//	{

//	}
//}



//class Program
//{
//	public static void Main(string[] args)
//	{

//		ITelewizor tv = new TvLg();
//		PilotAbstrakcyjny pilotHarmony = new PilotHarmony(tv);

//		pilotHarmony.DoWlacz();
//		pilotHarmony.DoWylacz();
//		Console.WriteLine("Kanał: " + tv.Kanal);

//	}
//}