using System.IO;
using System.Xml.Serialization;

namespace FoodClass
{
    public class FoodDeliveryHelper
    {
        private static readonly XmlSerializer food = new XmlSerializer(typeof(Food));
        public static void WriteToFile(string fileName, Food data)
        {
            using (var fileStream = File.Create(fileName))
            {
                food.Serialize(fileStream, data);
            }
        }

        public static Food LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (Food)food.Deserialize(fileStream);
            }
        }
        public static Food LoadFromStream(Stream file)
        {
            return (Food)food.Deserialize(file);
        }
    }
}
