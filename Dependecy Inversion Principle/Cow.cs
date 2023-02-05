using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Inversion_Principle
{
    class Cow : Animal
    {
        public ISpeakBehaviour speakBehaviour;

        public Cow(ISpeakBehaviour speakBehaviour)
        {
           this.speakBehaviour = speakBehaviour;
        }

        public override string MakeSound()
            => speakBehaviour.MakeSound();
    }
}
