using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class house
    {
        public static int log { get; private set; }
        public static int steel { get; private set; }
        public static int bricks { get; private set; }
        public static double size { get; private set; }
        
        public house (int Log, int Steel, int Bricks, double Size)
        {
            log = Log;
            steel = Steel;
            bricks = Bricks;
            size = Size;

        }

        public override string ToString()
        {
            return string.Format("{0} logs, {1} bricks, {2} steel, {3}fm2",
                log, steel, bricks, size);
        }
    }
    
}
