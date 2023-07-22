using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Context
    {
        public Context(string input)
        {
            this.Input = input;
        }
        public string Input { get; set; }
        public int Output { get; set; }
    }

    abstract class Phrase
    {
        public void Interpreter(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Nine()))
            {
                context.Input = context.Input.Substring(2);
                context.Output += (Multiplier() * 9);
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Input = context.Input.Substring(2);
                context.Output += (Multiplier() * 4);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Input = context.Input.Substring(1);
                context.Output += (Multiplier() * 5);
            }
            while (context.Input.StartsWith(One()))
            {
                context.Input = context.Input.Substring(1);
                context.Output += (Multiplier() * 1);
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();
    }


    class PhraseThousands : Phrase
    {
        public override string One() { return "M"; }
        public override string Four() { return " "; }
        public override string Five() { return " "; }
        public override string Nine() { return " "; }
        public override int Multiplier() { return 1000; }
    }

    class PhraseHundreds : Phrase
    {
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier() { return 100; }
    }

    class PhraseTens : Phrase
    {
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10; }
    }

    class PhraseOnes : Phrase
    {
        public override string One() { return "I"; }
        public override string Four() { return "IV"; }
        public override string Five() { return "V"; }
        public override string Nine() { return "IX"; }
        public override int Multiplier() { return 1; }
    }

    class Apka
    {
        static void Main()
        {
            List<Phrase> tree = new List<Phrase>();
            tree.Add(new PhraseThousands());
            tree.Add(new PhraseHundreds());
            tree.Add(new PhraseTens());
            tree.Add(new PhraseOnes());

            string roman = "MDXLIII";
            Context context = new Context(roman);
            foreach (Phrase item in tree)
            {
                item.Interpreter(context);
            }
            Console.WriteLine(roman + " = " + context.Output);
            // MDXLIII = 1543

            roman = "CMXVII";
            context = new Context(roman);
            foreach (Phrase item in tree)
            {
                item.Interpreter(context);
            }
            Console.WriteLine(roman + " = " + context.Output);
            // CMXVII = 917

        }
    }
}










//using System;
//using System.Collections.Generic;
 
//namespace Interpreter
//{

//    class Context
//    {

//        private string input;
//        private int output;

//        public Context(string input)
//        {
//            this.input = input;
//        }

//        public string Input
//        {
//            get { return input; }
//            set { input = value; }
//        }

//        public int Output
//        {
//            get { return output; }
//            set { output = value; }
//        }

//    }


//    abstract class Phrase
//    {

//        public void Interpreter(Context context)
//        {

//            if (context.Input.Length == 0)
//                return;

//            /* UZUPEŁNIĆ kilka else a może while? */

//        }

//        public abstract string One();
//        //
//        public abstract int Multiplier();

//    }


//    class PhraseThousands : Phrase
//    {
//        public override string One() { return "M"; }
//        public override string Four() { return " "; }
//        public override string Five() { return " "; }
//        public override string Nine() { return " "; }
//        public override int Multiplier() { return 1000; }
//    }


//    //
//    //
//    //
//    //


//    class Apka
//    {
//        static void Main()
//        {

//            List<Phrase> tree = new List<Phrase>();
//            tree.Add(new PhraseThousands());
//            tree.Add(new PhraseHundreds());


//            //
//            //
//            foreach (Phrase item in tree)
//            {
//                item.Interpreter(context);
//            }
//            Console.WriteLine(roman + " = " + context.Output);
//            // MDXLIII = 1543


//            roman = "CMXVII";
//            context = new Context(roman);
//            //
//            //
//            // CMXVII = 917

//        }
//    }

//}