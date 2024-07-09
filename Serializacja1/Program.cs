using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serializacja1
{
    class BinarySerializer
    {
        // Serializacja do pliku binarnego
        public static void SerializeToBinary<T>(T obj, string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(fileStream, obj);
            }
        }
        // Deserializacja z pliku binarnego
        public static T DeserializeFromBinary<T>(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(fileStream);
            }
        }
    
    static void Main(string[] args)
        {
            ListaKsiążek listaKsiążek = new ListaKsiążek();
            listaKsiążek.Generate();

            //Serializacja do pliku binarnego
            string binFilePath = "C:\\Users\\yulia\\source\\repos\\Serializacja1\\Serializacja1\\bookbin.bin";
            SerializeToBinary(listaKsiążek, binFilePath);
            //Deserializacja z pliku binarnego
            ListaKsiążek deserializedBookFromBin = DeserializeFromBinary<ListaKsiążek>(binFilePath);


            ListaKsiążek.Print(listaKsiążek.ksiazki);
            Console.WriteLine();
            ListaKsiążek.Print(deserializedBookFromBin.ksiazki);


            System.Threading.Thread.Sleep(20000);
        }
    }
}
