using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMT
{
    public class Item
    {
        public string Text { get; set; }
        public int Value { get; set; }
        // public int _Value;
        public Item(string description, int value)
        {
            Text = description;
            Value = value;
        }
        public override string ToString()
        {
            // Generates the text shown in the combo box
            return Text;
        }
        //public int getValue(string name)
        //{ if(}
    }
}
