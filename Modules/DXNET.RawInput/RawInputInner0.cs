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
using System.Runtime.InteropServices;

namespace DXNET.RawInput
{
    /// <summary>
    /// RAWINPUT_INNER_0
    /// </summary>
    internal partial struct RawInputInner0
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>mouse</unmanaged>
        /// <unmanaged-short>mouse</unmanaged-short>
        public DXNET.RawInput.RawMouse Mouse;
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>keyboard</unmanaged>
        /// <unmanaged-short>keyboard</unmanaged-short>
        public DXNET.RawInput.RawKeyboard Keyboard;
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>hid</unmanaged>
        /// <unmanaged-short>hid</unmanaged-short>
        public DXNET.RawInput.RawHid Hid;
        
        [StructLayoutAttribute(LayoutKind.Explicit, Pack = 0, CharSet = CharSet.Unicode)]
        internal partial struct __Native
        {
            [FieldOffset(0)]
            public DXNET.RawInput.RawMouse Mouse;
            
            [FieldOffset(0)]
            public DXNET.RawInput.RawKeyboard Keyboard;
            
            [FieldOffset(0)]
            public DXNET.RawInput.RawHid.__Native Hid;
        }

        internal unsafe void __MarshalFree(ref __Native @ref)
        {
            Hid.__MarshalFree(ref @ref.Hid);
        }

        internal unsafe void __MarshalFrom(ref __Native @ref)
        {
            Mouse = @ref.Mouse;
            Keyboard = @ref.Keyboard;
            Hid.__MarshalFrom(ref @ref.Hid);
        }

        internal unsafe void __MarshalTo(ref __Native @ref)
        {
            @ref.Mouse = Mouse;
            @ref.Keyboard = Keyboard;
            Hid.__MarshalTo(ref @ref.Hid);
        }
    }
}
