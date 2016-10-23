﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            if (a.X == b.X || a.Y == b.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}