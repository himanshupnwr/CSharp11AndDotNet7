using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    internal class UnixFileModeExample
    {
        public void MethodForFileAccessinUnix()
        {
            _ = File.GetUnixFileMode(@"C:\temp\dotnet.png");

            using var fs = new FileStream("", new FileStreamOptions
            {
                UnixCreateMode = UnixFileMode.UserExecute
            });
        }
    }
}
