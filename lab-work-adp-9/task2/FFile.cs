using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_adp_9.task2
{
    public class FFile : FileSystemComponent
    {
        public FFile(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " File: " + _name);
        }
    }

}
