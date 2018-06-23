using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMT
{
    public class Item
    {
        public string Name;
        public int _Value;
        public Item(string description, int value)
        {
            Name = description;
            _Value = value;
        }
        public override string ToString()
        {
            // Generates the text shown in the combo box
            return Name;
        }
        public int Value
        { get; set; }
    }
}
