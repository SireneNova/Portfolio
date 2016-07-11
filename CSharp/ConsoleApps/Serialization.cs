using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerializingDemo
{
    class SerializeData
    {
        Stream stream = null;
        BinaryFormatter bformatter = null;
        string txtFileName = "";
        public SerializeData(string filename)
        {
            txtFileName = filename;
            stream = File.Open(txtFileName, FileMode.Create);
            bformatter = new BinaryFormatter();
        }

        public void SerializeObject(object objectToSerialize)
        {
            bformatter.Serialize(stream, objectToSerialize);
        }

        public void DeserializeObjects()
        {
            object objectToDeserialize = null;
            stream = File.Open(txtFileName, FileMode.Open);
            try
            {
                while (stream.CanSeek)
                {
                    objectToDeserialize = (object)bformatter.
                        Deserialize(stream);

                    if (objectToDeserialize is ComputerObject)
                    {
                        ComputerObject co = (ComputerObject)objectToDeserialize;
                        Console.WriteLine(co.printContent());
                    }

                    else if (objectToDeserialize is HomeObject)
                    {
                        HomeObject home = (HomeObject)objectToDeserialize;
                        Console.WriteLine(home.printContent());
                    }
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("end of file");
            }

        }

        public void closeStream()
        {
            stream.Close();
        }
  
    }
}
// https://www.youtube.com/watch?v=6eyCjN16I-0