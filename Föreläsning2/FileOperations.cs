﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning2
{
    static class FileOperations
    {

        public static void Serialize(object objectToSerialize)
        {
            string  fileName = "bil.bin";

            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, objectToSerialize);
            }
        }
        public static object Deserialize()
        {
            string fileName = "bil.bin";

            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                return formatter.Deserialize(fStream);
            }
        }
    }
}
