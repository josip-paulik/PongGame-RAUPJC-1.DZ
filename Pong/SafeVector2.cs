﻿using System;

namespace Pong
{
    public class SafeVector2 
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        

        /// <summary>
        /// Constructor for this type.
        /// </summary>
        /// <param name="x">Defines horizontal component, must be -1 or 1.</param>
        /// <param name="y">Defines vertical component, must be -1 or 1.</param>
        public SafeVector2(float x, float y)
        {
            //if (( (x != -1 && x != 1) || (y != -1 && y != 1) ) && !isAlreadyDefined)
            //{
            //    throw new ArgumentException("Arguments must be -1 or 1.");
            //}
                X = x;
                Y = y;
                
            
        }

        /// <summary>
        /// This method overrides the multiplication operator so that it always returns SafeVector2 type
        /// </summary>
        /// <param name="v1">First vector.</param>
        /// <param name="v2">Second vector.</param>
        /// <returns>New SafeVector2 which is result of multipliaction(by mathematical definition)</returns>
        public static SafeVector2 operator *(SafeVector2 v1, float scalar)
        {
            return new SafeVector2(v1.X * scalar, v1.Y * scalar);
        }
    }
}
