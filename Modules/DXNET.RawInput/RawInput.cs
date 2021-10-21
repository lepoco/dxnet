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
    /// RAWINPUT
    /// </summary>
    internal partial struct RawInput
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>header</unmanaged>
        /// <unmanaged-short>header</unmanaged-short>
        public DXNET.RawInput.RawInputHeader Header;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>data</unmanaged>
        /// <unmanaged-short>data</unmanaged-short>
        public DXNET.RawInput.RawInputInner0 Data;
        
        [StructLayout(LayoutKind.Sequential, Pack = 0, CharSet = CharSet.Unicode)]
        internal partial struct __Native
        {
            public DXNET.RawInput.RawInputHeader Header;
            public DXNET.RawInput.RawInputInner0.__Native Data;
        }

        internal unsafe void __MarshalFree(ref __Native @ref)
        {
            Data.__MarshalFree(ref @ref.Data);
        }

        internal unsafe void __MarshalFrom(ref __Native @ref)
        {
            Header = @ref.Header;
            Data.__MarshalFrom(ref @ref.Data);
        }

        internal unsafe void __MarshalTo(ref __Native @ref)
        {
            @ref.Header = Header;
            Data.__MarshalTo(ref @ref.Data);
        }
    }
}
