using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Inversion_Principle
{
    class Dog : Animal
    {
        public ISpeakBehaviour speakBehaviour;

        public Dog(ISpeakBehaviour speakBehaviour)
        {
            this.speakBehaviour = speakBehaviour;
        }

        public override string MakeSound()
            => speakBehaviour.MakeSound();
    }
}
