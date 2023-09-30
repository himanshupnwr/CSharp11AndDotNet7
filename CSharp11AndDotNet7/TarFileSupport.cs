using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Formats.Tar;

namespace CSharp11AndDotNet7
{
    internal class TarFileSupport
    {
       async void Mehtods()
        {
            if(File.Exists(@"C:\temp\mytar.tar"))
            {
                File.Delete(@"C:\temp\mytar.tar"))
            }

            await TarFile.CreateFromDirectoryAsync(@"C:\temp\", @"C:\temp\mytar.tar", false);

            await TarFile.ExtractToDirectoryAsync(@"C:\temp2\mytar.tar", @"C:\temp3\", true);
        }
    }
}
