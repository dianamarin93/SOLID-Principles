using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Inversion_Principle
{
    class Cat : Animal
    {
        public ISpeakBehaviour speakBehaviour;

        public Cat(ISpeakBehaviour speakBehaviour)
        {
            this.speakBehaviour = speakBehaviour;
        }

        public override string MakeSound()
            => speakBehaviour.MakeSound();
    }
}
