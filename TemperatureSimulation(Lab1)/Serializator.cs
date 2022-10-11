﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TemperatureSimulation_Lab1_
{
    public class Serializator
    {
        //private static BinaryFormatter _bin = new BinaryFormatter();

        public IList<double?> Deserialize(string a_fileName)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<double?>));
            object obj = null;
            try
            {
                TextReader reader = new StreamReader(a_fileName);

               obj= deserializer.Deserialize(reader);

                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("File read process - fail!");
            }

            return (List<double?>)obj;
        }

        public void Serialization(string a_fileName, IList<double?> a_stations)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<double?>));

            using (var stream = File.OpenWrite(a_fileName))
            {
                serializer.Serialize(stream, a_stations);
            }
        }
    }
}
