using System.Collections.Generic;

namespace PW_5
{
    class ObjectFactory
    {
        private static Dictionary<string, IDraw> objects = new Dictionary<string, IDraw>();

        public static IDraw GetObject(string objectType)
        {
            switch (objectType)
            {
                case "Rectangle":
                    if (!objects.ContainsKey("Rectangle"))
                        objects["Rectangle"] = new RectangleObject();
                    return objects["Rectangle"];
                case "Cicle":
                    if (!objects.ContainsKey("Cicle"))
                        objects["Cicle"] = new CicleObject();
                    return objects["Cicle"];
                default:
                    break;
            }
            return null;
        }
    }
}
