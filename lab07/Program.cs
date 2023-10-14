using AnimalClasses;
using AnimalClasses.Animals;
using System.Xml;
using System.Reflection;
using Attributes;

class Program
{
    static void Main()
    {
        XmlDocument xmlDoc = new XmlDocument();
        
        XmlElement rootElement = xmlDoc.CreateElement("ClassDiagram");
        xmlDoc.AppendChild(rootElement);

        // get all types
        Type[] types = Assembly.GetExecutingAssembly().GetTypes();
        
        foreach (Type type in types)
        {

            string t;
            if (type.IsClass)
            {
                t = "Class";
            }
            else
            {
                t = "Enum";
            }

            // take to xml classes and enums created in AnimalClasses
            if (type.AssemblyQualifiedName.Contains("AnimalClasses"))
            {
                XmlElement element = xmlDoc.CreateElement(t);
                rootElement.AppendChild(element);

                // add name attribute
                element.SetAttribute("name", type.Name);
                
                // get comment attribute
                CommentAttribute comment = (CommentAttribute)type.GetCustomAttribute(typeof(CommentAttribute));

                if (comment != null)
                {
                    // element for comment
                    XmlElement commentElement = xmlDoc.CreateElement("Comment");
                    commentElement.InnerText = comment.Comment;
                    element.AppendChild(commentElement);
                }

                // get all properties and put in xml
                object[] properties = type.GetProperties();

                foreach (var prop in properties)
                {
                    XmlElement propertyElement = xmlDoc.CreateElement("Property");
                    propertyElement.InnerText = prop.ToString();
                    element.AppendChild(propertyElement);
                }
                
                //get all methods ant put in xml
                object[] methods = type.GetMethods();
                
                foreach (var method in methods)
                {
                    if (method.ToString().Contains("AnimalClasses")){
                        XmlElement methodElement = xmlDoc.CreateElement("Method");
                        methodElement.InnerText = method.ToString();
                        element.AppendChild(methodElement);
                    }
                }
            }
            
        }

        // save xml-document
        xmlDoc.Save("/home/narek/Documents/C#/lab07/lab07/ClassDiagram.xml");

    }
}
