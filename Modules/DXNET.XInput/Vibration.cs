// Copyright (c) 2021 DXNET - Pomianowski Leszek & Contributors
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXNET.XInput
{
    public partial struct Vibration
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>wLeftMotorSpeed</unmanaged>
        /// <unmanaged-short>wLeftMotorSpeed</unmanaged-short>
        public System.UInt16 LeftMotorSpeed;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>wRightMotorSpeed</unmanaged>
        /// <unmanaged-short>wRightMotorSpeed</unmanaged-short>
        public System.UInt16 RightMotorSpeed;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
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
            LeftMotorSpeed = (System.UInt16)@ref.LeftMotorSpeed;
            RightMotorSpeed = (System.UInt16)@ref.RightMotorSpeed;
        }

        internal unsafe void __MarshalTo(ref __Native @ref)
        {
            @ref.LeftMotorSpeed = (System.Int16)LeftMotorSpeed;
            @ref.RightMotorSpeed = (System.Int16)RightMotorSpeed;
        }
    }
}
