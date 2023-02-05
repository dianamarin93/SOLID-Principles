using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Inversion_Principle
{
    class CatSpeak : ISpeakBehaviour
    {
        public string MakeSound()
            => "Meow!";
    }
}
