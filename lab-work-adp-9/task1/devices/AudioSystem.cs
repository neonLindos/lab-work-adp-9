using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_adp_9.task1.devices
{
    public class AudioSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Audio system is now ON.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Audio system volume set to {level}.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Audio system is now OFF.");
        }
    }
}
