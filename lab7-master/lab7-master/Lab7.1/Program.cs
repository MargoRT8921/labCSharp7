using bib;
using System.Xml.Linq;
using System.Reflection;

XDocument xdoc = XDocument.Load("/Users/Маргарита/source/repos/lab7-master/lab7-master/lab7.1/diagram.xml");
XElement? root = xdoc.Element("diagram");

Type animal = typeof(Animal);
XElement abs_class = new XElement("abstract_class", new XAttribute("name", typeof(Animal).ToString()));
root.Add(abs_class);
foreach (MemberInfo member in animal.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    abs_class.Add(new XElement(member.MemberType.ToString(), member.Name));
}
object[] animal_attributes = animal.GetCustomAttributes(false);
foreach (var attr in animal_attributes)
{
    abs_class.Add(new XElement("CustomAttribute", attr.ToString()));
}

Type cow = typeof(Cow);
XElement child_class1 = new XElement("child_class", new XAttribute("name", typeof(Cow).ToString()));
root.Add(child_class1);
foreach (MemberInfo member in cow.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    child_class1.Add(new XElement(member.MemberType.ToString(), member.Name));
}
object[] cow_attributes = cow.GetCustomAttributes(false);
foreach (var attr in cow_attributes)
{
    child_class1.Add(new XElement("CustomAttribute", attr.ToString()));
}



Type lion = typeof(Lion);
XElement child_class2 = new XElement("child_class", new XAttribute("name", typeof(Lion).ToString()));
root.Add(child_class2);
foreach (MemberInfo member in lion.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    child_class2.Add(new XElement(member.MemberType.ToString(), member.Name));
}
object[] lion_attributes = lion.GetCustomAttributes(false);
foreach (var attr in lion_attributes)
{
    child_class2.Add(new XElement("CustomAttribute", attr.ToString()));
}



Type pig = typeof(Pig);
XElement child_class3 = new XElement("child_class", new XAttribute("name", pig.ToString()));
root.Add(child_class3);
foreach (MemberInfo member in pig.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    child_class3.Add(new XElement(member.MemberType.ToString(), member.Name));
}
object[] pig_attributes = pig.GetCustomAttributes(false);
foreach (var attr in pig_attributes)
{
    child_class3.Add(new XElement("CustomAttribute", attr.ToString()));
}







Type eClassificationAnimal = typeof(eClassificationAnimal);
XElement enum_1 = new XElement("enum", new XAttribute("name", eClassificationAnimal.ToString()));
root.Add(enum_1);
foreach (MemberInfo member in eClassificationAnimal.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    enum_1.Add(new XElement(member.MemberType.ToString(), member.Name));
}

Type eFavoriteFood = typeof(eFavoriteFood);
XElement enum_2 = new XElement("enum", new XAttribute("name", eFavoriteFood.ToString()));
root.Add(enum_2);
foreach (MemberInfo member in eFavoriteFood.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    enum_2.Add(new XElement(member.MemberType.ToString(), member.Name));
}

xdoc.Save("/Users/Маргарита/source/repos/lab7-master/lab7-master/lab7.1/diagram.xml");
