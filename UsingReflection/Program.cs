using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UsingReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : review this path
            Assembly pluginAssembly = Assembly.LoadFile(@"C:\Users\Houssem\Documents\Visual Studio 2015\Projects\MCP-CSharp-483\ClassLibraryProject\bin\Debug\ClassLibraryProject.dll");

            var plugins = from type 
                          in pluginAssembly.GetTypes()
                          where !type.IsInterface
                          select type;

            object plugin = Activator.CreateInstance(plugins.First());

            PropertyInfo propertyInfo = plugin.GetType().GetProperty("Message");

            Console.WriteLine(propertyInfo.GetValue(plugin));

            MethodInfo methodInfo = plugin.GetType().GetMethod("Add");
            object r = methodInfo.Invoke(plugin, new object[] { 5, 8});
            Console.WriteLine("r : " + r);

            Console.ReadLine();
        }
    }
}
