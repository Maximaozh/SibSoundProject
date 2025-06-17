using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlugin
{
    public interface IPlugin
    {
        string Author();

        string Description();

        string Group();

        string GUID();

        string Name();
        string Released();

        void Run(ref AudioData.AudioData data, ref int begin, ref int end);

        string Version();
    }
}
