using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_adp_9.task2
{
    public class DDirectory : FileSystemComponent
    {
        private List<FileSystemComponent> _children = new List<FileSystemComponent>();

        public DDirectory(string name) : base(name)
        {
        }

        public override void Add(FileSystemComponent component)
        {
            _children.Add(component);
        }

        public override void Remove(FileSystemComponent component)
        {
            _children.Remove(component);
        }

        public override FileSystemComponent GetChild(int index)
        {
            return _children[index];
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " Directory: " + _name);
            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
