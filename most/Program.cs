using System;

namespace most
{ 
	public interface ITelewizor
	{
		int Kanal { get; set; }
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
			throw new NotImplementedException();
		}

		public void ZmienKanal(int kanal)
		{
			throw new NotImplementedException();
		}

	}

	public abstract class PilotAbstrakcyjny
	{

		private ITelewizor tv;

		public PilotAbstrakcyjny(ITelewizor tv)
		{
			this.tv = tv;
		}

		public void ZmienKanal(int kanal)
		{
			tv.ZmienKanal(kanal);
		}

		public abstract void DoWlacz();

	}

	public class PilotHarmony : PilotAbstrakcyjny
	{

		public PilotHarmony(ITelewizor tv) : base(tv) { }

		public override void DoWlacz()
		{
			Console.WriteLine("Pilot Harmony włącza telewizor...");
		}

		public void DoWylacz()
		{

		}
	}



	class Program
	{
		public static void Main(string[] args)
		{

			ITelewizor tv = new TvLg();
			PilotAbstrakcyjny pilotHarmony = new PilotHarmony(tv);

			pilotHarmony.DoWlacz();
			pilotHarmony.DoWylacz();
			Console.WriteLine("Kanał: " + tv.Kanal);

		}
	}
}

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