using System.Reflection;
using Teleperformance._2.Attributes;

namespace Teleperformance._2.OgrencilerDB
{
    public class DataMapping
    {
        public string Validate(Ogrenciler ogrenciler)
        {
            Type type = typeof(Ogrenciler);

            PropertyInfo? pi = type.GetProperty(nameof(Ogrenciler));
            PropertyInfo? pi_name = type.GetProperty(nameof(Ogrenciler.name));
            PropertyInfo? pi_id = type.GetProperty(nameof(Ogrenciler.id));

            MemberInfo? mi = type;

            var memberAttr = mi?.GetCustomAttribute<TableAttribute>();
            //Turkish characters from attribute
            string[] unwantedChars = memberAttr?.UnwantedChars.Split(',');

            //Name of the table 
            string tableName = pi.GetValue(ogrenciler, null).ToString();

            //Foreach to loop through tableName characters
            foreach (char c in tableName)
            {
                //For loop to check if unwantedChars has a character that is equal to any tableName chars 
                for (int i = 0; i < unwantedChars.Length; i++)
                {
                    if (unwantedChars[i].Contains(c))
                    {
                        throw new InvalidOperationException("Table name cannot contain TR characters");
                    }
                }
            }

            string script = "Table name: " + tableName + "----";

            var propertyAttr = pi_id?.GetCustomAttribute<ColumnAttribute>();
            string name = propertyAttr?.Name;
            string propertyType = propertyAttr?.Type;
            bool required = (bool)propertyAttr?.Required;

            //if property id is not "id" or type is not int or it is not required throw err
            if (name != "id" || propertyType != "int" || required is false)
            {
                throw new InvalidOperationException("Could not validate ogrenci id");
            }

            script += " Column(s): " + name + propertyType + "required ";

            propertyAttr = pi_name.GetCustomAttribute<ColumnAttribute>();
            name = propertyAttr?.Name;
            propertyType = propertyAttr?.Type;
            required = (bool)propertyAttr?.Required;

            //if property name is not "name" or type is not string or it is not required throw err
            if (name != "name" || propertyType != "string" || required is false)
            {
                throw new InvalidOperationException("Could not validate ogrenci name");
            }

            script += " Column(s): " + name + propertyType + "required ";

            return script;
        }

        public string Map()
        {
            Ogrenciler ogrenciler = new Ogrenciler();

            return Validate(ogrenciler);
        }
    }
}
