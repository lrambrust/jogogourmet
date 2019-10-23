using System;
using System.Collections.Generic;

namespace JogoGourmet
{
    class Prato
    {
        public string NomePrato { get; set; }
        public string TipoDoPrato { get; set; }
        public static List<Prato> ListaDePratos = new List<Prato>();

        public Prato()
        {

        }

        public Prato(string tipoDoPrato, string nomePrato)
        {
            NomePrato = nomePrato;
            TipoDoPrato = tipoDoPrato;
        }

        public void AdicionarPrato(string tipoDoPrato, string nomePrato)
        {
            ListaDePratos.Add(new Prato(tipoDoPrato, nomePrato));
        }

        public Prato NovaTentativa()
        {
            var random = new Random();
            int index = random.Next(ListaDePratos.Count);

            return ListaDePratos[index];
        }
    }
}