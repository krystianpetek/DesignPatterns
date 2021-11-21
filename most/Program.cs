using System;


public interface ITelewizor
{

	int Kanal { get; set; }
	//
	//
	void ZmienKanal(int kanal);

}



public class TvLg : ITelewizor
{

	public TvLg()
	{
		this.Kanal = 1;
	}

	public int Kanal { get; set; }

	public void Wlacz()
	{
		Console.WriteLine("Telewizor LG włączony.");
	}

	public void Wylacz()
	{
		Console.WriteLine("Telewizor LG wyłączony.");
	}

	public void ZmienKanal(int kanal)
	{
		Kanal = kanal;
        Console.WriteLine($"Telewizor LG, kanał {Kanal}");
	}
}



//public class TvXiaomi : ITelewizor
//{

//	//
//	//

//}



public abstract class PilotAbstrakcyjny
{

	private ITelewizor tv;

	public PilotAbstrakcyjny(ITelewizor tv)
	{
		//
		//
	}

	//
	//

	public void ZmienKanal(int kanal)
	{
		//
		//
	}

}



public class PilotHarmony : PilotAbstrakcyjny
{

	public PilotHarmony(ITelewizor tv) : base(tv) { }

	public void DoWlacz()
	{
		Console.WriteLine("Pilot Harmony włącza telewizor...");
		Wlacz();
	}

	//
	//

}

public class PilotPhilips : PilotAbstrakcyjny
{

	//
	//

	public void DoWylacz()
	{
		Console.WriteLine("Pilot Philips wyłącza telewizor...");
		Wylacz();
	}

}



class MainClass
{
	public static void Main(string[] args)
	{

		ITelewizor tv = new TvLg();
		//
		//
		PilotAbstrakcyjny pilotHarmony = new PilotHarmony(tv);
		PilotAbstrakcyjny pilotPhilips = new PilotHarmony(tv);
		
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