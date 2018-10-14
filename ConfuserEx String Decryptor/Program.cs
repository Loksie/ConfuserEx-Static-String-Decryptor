using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet;
using dnlib.DotNet.Writer;

namespace ConfuserEx_String_Decryptor
{
    class Program
    {
        public static ModuleDefMD Module { get; private set; }

        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            Module = ModuleDefMD.Load(path);
            StringDecryptor.Deobfuscate();
            ModuleWriterOptions modOpts = new ModuleWriterOptions(Module);
            modOpts.MetadataOptions.Flags = MetadataFlags.PreserveAll;
            Module.Write(path+"Cleaned.exe",modOpts);
        }
    }
}
