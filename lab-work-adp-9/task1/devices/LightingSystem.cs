using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_adp_9.task1.devices
{
    public class LightingSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Lighting system is now ON.");
        }
        public void SetBrightness(int level)
        {
            Console.WriteLine($"Lighting system brightness set to {level}.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Lighting system is now OFF.");
        }
    }
}
