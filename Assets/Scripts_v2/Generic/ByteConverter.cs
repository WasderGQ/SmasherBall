using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace YusufISIK.AmericanoOnline.Generic
{
    public class ByteConverter
    {
        // Serialize collection of any type to a byte stream
        public byte[] Serialize<T>(T obj)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter binSerializer = new BinaryFormatter();
                binSerializer.Serialize(memStream, obj);
                
                return memStream.ToArray();
            }
        }
        
        // DSerialize collection of any type to a byte stream
        public T Deserialize<T>(byte[] serializedObj)
        {
            using (MemoryStream memStream = new MemoryStream(serializedObj))
            {
                BinaryFormatter binSerializer = new BinaryFormatter();
                T obj = (T)binSerializer.Deserialize(memStream);
                
                return obj;
            }
        }
    }
}