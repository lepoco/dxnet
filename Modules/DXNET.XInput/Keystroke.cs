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
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct Keystroke
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VirtualKey</unmanaged>
        /// <unmanaged-short>VirtualKey</unmanaged-short>
        public DXNET.XInput.GamepadKeyCode VirtualKey;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Unicode</unmanaged>
        /// <unmanaged-short>Unicode</unmanaged-short>
        public System.Char Unicode;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Flags</unmanaged>
        /// <unmanaged-short>Flags</unmanaged-short>
        public DXNET.XInput.KeyStrokeFlags Flags;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>UserIndex</unmanaged>
        /// <unmanaged-short>UserIndex</unmanaged-short>
        public DXNET.XInput.UserIndex UserIndex;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HidCode</unmanaged>
        /// <unmanaged-short>HidCode</unmanaged-short>
        public System.Byte HidCode;
    }
}
