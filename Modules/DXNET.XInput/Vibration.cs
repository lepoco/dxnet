﻿// Copyright (c) 2021 DXNET - Pomianowski Leszek & Contributors
// Copyright (c) 2010-2019 SharpDX - Alexandre Mutel & SharpDX Contributors
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Runtime.InteropServices;

namespace DXNET.XInput
{
    public partial struct Vibration
    {
        /// <summary>
        /// wLeftMotorSpeed
        /// </summary>
        public ushort LeftMotorSpeed;

        /// <summary>
        /// wRightMotorSpeed
        /// </summary>
        public ushort RightMotorSpeed;
        
        [StructLayout(LayoutKind.Sequential, Pack = 0, CharSet = CharSet.Unicode)]
        internal partial struct __Native
        {
            public System.Int16 LeftMotorSpeed;
            public System.Int16 RightMotorSpeed;
        }

        internal unsafe void __MarshalFree(ref __Native @ref)
        {
        }

        internal unsafe void __MarshalFrom(ref __Native @ref)
        {
            LeftMotorSpeed = (ushort)@ref.LeftMotorSpeed;
            RightMotorSpeed = (ushort)@ref.RightMotorSpeed;
        }

        internal unsafe void __MarshalTo(ref __Native @ref)
        {
            @ref.LeftMotorSpeed = (short)LeftMotorSpeed;
            @ref.RightMotorSpeed = (short)RightMotorSpeed;
        }
    }
}
