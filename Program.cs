using System;

namespace source
{
    class Program
    {
        public struct NComplejo
        {
            public int real;
            public int imaginario;
        }

        NComplejo sumaComplejos(NComplejo a, NComplejo b)
        {
            NComplejo resultado;
            resultado.real = a.real + b.real;
            resultado.imaginario = a.imaginario + b.imaginario;

            return resultado;
        }

        string ComplejoToString(NComplejo a)
        {
            string s;
            s = a.real.ToString();
            s += (a.imaginario >= 0 ? " + " : "");
            s += a.imaginario.ToString()+"i";

            return s;
        }

        void OperacionesConComplejos()
        {
            var a = new NComplejo {real = 4, imaginario = 10};
            var b = new NComplejo {real = 4, imaginario = 10};

            var resul = sumaComplejos(a, b);

            Console.WriteLine(" ( " + ComplejoToString(a) + " ) " + " +" +" ( " + ComplejoToString(b) + " ) " + " = " + ComplejoToString(resul));
        }

        static void Main(string[] args)
        {
            var prog = new Program();
            prog.OperacionesConComplejos();
        }
    }
}