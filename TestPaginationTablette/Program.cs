﻿using System;
using System.Collections.Generic;

namespace TestPaginationTablette
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> datas = new List<string>();
            for (int i = 0; i < 51; i++)
            {
                datas.Add(i.ToString());
            }

            int nbCaseDispo = 10;

            //new AffichageActuel(datas, nbArboresecences);
            //new TestNouveauAffichage(datas, nbArboresecences);
            new AffichageYoyo(new DataService(datas), nbCaseDispo);
        }
    }
}
