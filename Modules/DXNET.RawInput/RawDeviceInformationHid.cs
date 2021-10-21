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
    /// RID_DEVICE_INFO_HID
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Sequential, Pack = 0, CharSet = CharSet.Unicode)]
    internal partial struct RawDeviceInformationHid
    {
        /// <summary>
        /// dwVendorId
        /// </summary>
        public System.Int32 VendorId;

        /// <summary>
        /// dwProductId
        /// </summary>
        public System.Int32 ProductId;

        /// <summary>
        /// dwVersionNumber
        /// </summary>
        public System.Int32 VersionNumber;

        /// <summary>
        /// usUsagePage
        /// </summary>
        public DXNET.Multimedia.UsagePage UsagePage;

        /// <summary>
        /// usUsage
        /// </summary>
        public DXNET.Multimedia.UsageId Usage;
    }
}
