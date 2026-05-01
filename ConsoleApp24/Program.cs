using demo;
using Microsoft.Win32.SafeHandles;
using System.Reflection;

/*
Console.WriteLine("assembleis");

var type = typeof(Employee);
Console.WriteLine(type);
var ass = type.Assembly;
Console.WriteLine(ass.FullName);

// or with easy way we use methods of assembly
Console.WriteLine("===============");
var assembly = Assembly.GetExecutingAssembly();
Console.WriteLine(assembly.FullName);

Console.WriteLine( typeof(DateTime).Assembly.FullName);
*/


//class Employee
//{

//}

Ass_Calling_entry_excuting.a_c_e_e();

var type = typeof(Program);
var assembly = type.Assembly;
//Console.WriteLine($"assembly name : {assembly.FullName}");
//Console.WriteLine($"Location : {assembly.Location}");
//var assemblyname = assembly.GetName();
//Console.WriteLine($"Name : {assemblyname.Name}");
//Console.WriteLine($"Version : {assemblyname.Version}");
//Console.WriteLine($"Total ket token length : {assemblyname.GetPublicKeyToken().Length}");
//Console.WriteLine($"Code : {assemblyname.CodeBase}");
//Console.WriteLine($"Date Time Name : {typeof(DateTime).Assembly.GetName().Name}");





//string loca = "data.countries.json";
var stream = assembly.GetManifestResourceStream("ConsoleApp24.data.countries.json");
//var stream = assembly.GetManifestResourceStream(type,loca);

using var reader = new BinaryReader(stream!);
var data = reader.ReadBytes((int)stream.Length);

for (int i = 0; i < data.Length; i++)
{
    Console.Write((char)data[i]);
    System.Threading.Thread.Sleep(1);
}
stream.Close();
Console.ReadKey();
























