using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Project_Roulette.DataSets;
using Windows.ApplicationModel;
using Windows.Storage;

namespace Project_Roulette.Utilities
{
    class Core
    {
        private const string POKEMON_PATH= "Datasets\\Pokemon.xml";
        public static List<Pokemon> pokemon { get; set; } = new List<Pokemon>();
        public static List<Pokemon> roulette { get; set; } = new List<Pokemon>();

        public static void Initialize()
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                string XMLFilePath = Path.Combine(Package.Current.InstalledLocation.Path, POKEMON_PATH);
                doc.Load(XMLFilePath);

                XmlNode pokedex = doc.SelectSingleNode("/pokedex");
                XmlNodeList pokemonList = pokedex.SelectNodes("pokemon");

                foreach (XmlNode item in pokemonList)
                {
                    Pokemon aPokemon = new Pokemon();
                    XmlNodeList childItems = item.ChildNodes;
                    aPokemon.id = Convert.ToInt16(item.Attributes.GetNamedItem("id").Value);
                    aPokemon.nameEng = childItems[0].InnerText;
                    aPokemon.type1 = childItems[1].InnerText;
                    aPokemon.type2 = childItems[2].Name == "type" ? childItems[2].InnerText : null;

                    pokemon.Add(aPokemon);
                }
            }
            catch (Exception)
            {
                Debug.Print("sumting went wong");
            }

        }

        public static void Roll()
        {
            Random rdm = new Random();
            roulette = new List<Pokemon>();

            for (int i = 0; i < 6; i++)
            {
                int result = rdm.Next(1, 494);

                roulette.Add(pokemon[result]);
            }
        }
    }
}
