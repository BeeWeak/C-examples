using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNatural
{
    class Storm
    {
        public Storm(string caster, bool isstrong, string essence)
        {
            Caster = caster;
            Essence = essence;
            if (IsStrong == true){
                string Temp = "strong";

            }
            else
            {
                string Temp = "weak";
            }

        }
        public string Essence
        {
            get; private set;
        }

        public bool IsStrong
        {
            get; private set;
        }

        public string Caster
        {
            get; private set;
        }

        public string Temp
        {
            get; private set;
        }

        public string Announce()
        {
            Console.WriteLine($"{Caster} casts a {Temp} {Essence}");
            return $"{Caster} casts a {Temp} {Essence}";
            
        }

    }
}
