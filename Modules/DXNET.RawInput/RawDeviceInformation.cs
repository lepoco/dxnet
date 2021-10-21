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
    /// RID_DEVICE_INFO
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 0, CharSet = CharSet.Unicode)]
    internal partial struct RawDeviceInformation
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>cbSize</unmanaged>
        /// <unmanaged-short>cbSize</unmanaged-short>
        [System.Runtime.InteropServices.FieldOffset(0)]
        public System.Int32 Size;
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>dwType</unmanaged>
        /// <unmanaged-short>dwType</unmanaged-short>
        [System.Runtime.InteropServices.FieldOffset(4)]
        public DXNET.RawInput.DeviceType Type;
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>mouse</unmanaged>
        /// <unmanaged-short>mouse</unmanaged-short>
        [System.Runtime.InteropServices.FieldOffset(8)]
        public DXNET.RawInput.RawDeviceInformationMouse Mouse;
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>keyboard</unmanaged>
        /// <unmanaged-short>keyboard</unmanaged-short>
        [System.Runtime.InteropServices.FieldOffset(8)]
        public DXNET.RawInput.RawDeviceInformationKeyboard Keyboard;
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>hid</unmanaged>
        /// <unmanaged-short>hid</unmanaged-short>
        [System.Runtime.InteropServices.FieldOffset(8)]
        public DXNET.RawInput.RawDeviceInformationHid Hid;
    }
}
