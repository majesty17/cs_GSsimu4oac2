using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSSimu4oac2
{
    class MyItem
    {
        public MyItem(string[] data)
        {
            if (data.Length == 4) {
                Name = data[0] + "(" + data[1] + ")";
                Score = data[1];
                Color = data[2];
                Image = data[3];
            }
        }
        public string Name { get; private set; }
        public string Score { get; private set; }
        public string Color { get; private set; }
        public string Image { get; private set; }

    }
}
