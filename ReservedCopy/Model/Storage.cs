using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservedCopy.Model
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public Storage(string name, string model)
        {
            this.Name = name;
            this.Model = model;
        }
        public abstract double GetMemory();
        public abstract void CopyInfo();
        public abstract void GetFreeMemory();
        public abstract void GetInfo();
    }
}
