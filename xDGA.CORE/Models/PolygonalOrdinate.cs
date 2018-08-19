﻿// The MIT License (MIT)
//
// Copyright (c) 2017-2018 Carlos Gamez
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using xDGA.CORE.Units;

namespace xDGA.CORE.Models
{
    public class PolygonalOrdinate
    {
        public PolygonalAxis Axis { get; set; }
        public double Value { get; set; } = 0.0;

        public PolygonalOrdinate(PolygonalAxis axis, double value)
        {
            Axis = axis;
            Value = value;
        }

        public CartesianCoordinate GetCartesianCoordinate()
        {
            var x = Value * Math.Cos(Axis.Angle.ConvertTo(new AngleUnits.Radians()));
            var y = Value * Math.Cos((Math.PI / 2) - Axis.Angle.ConvertTo(new AngleUnits.Radians()));
            return new CartesianCoordinate(x, y);
        }
    }
}
