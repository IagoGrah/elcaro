using System;

namespace elcaro
{
    public enum Language
    {
        EN,
        PT
    }

    public class Strings
    {
        public const int GREETING = 0;
        public const int LERO = 1;
        public const int INVALID = 2;

        private string[] stringsEN = new string[]
        {
            "I AM EL CARO. STATE YOUR INQUIRY.",
            "Hello great oracle I am here to ask you for information about",
            "DO NOT WASTE MY TIME"
        };
        private string[] stringsPT = new string[]
        {
            "EU SOU EL CARO. DECLARE SEU INQUÉRITO.",
            "Olá grande oráculo eu estou aqui para lhe pedir informações sobre",
            "NÃO DESPERDIÇE MEU TEMPO"
        };

        private Language language;
        public Strings(Language language)
        {
            this.language = language;
        }

        public string this[int index]
        {
            get
            {
                switch (language)
                {
                    case Language.EN:
                        return stringsEN[index];

                    case Language.PT:
                        return stringsPT[index];

                    default:
                        return null;
                }
            }
        }
    }
}