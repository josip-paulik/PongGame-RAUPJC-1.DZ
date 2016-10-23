﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Wall : IPhysicalObject2D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
