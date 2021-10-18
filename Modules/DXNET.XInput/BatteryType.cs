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

namespace DXNET.XInput
{
    public enum BatteryType : System.Byte
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>BATTERY_TYPE_DISCONNECTED</unmanaged>
        /// <unmanaged-short>BATTERY_TYPE_DISCONNECTED</unmanaged-short>
        Disconnected = unchecked((System.Byte)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>BATTERY_TYPE_WIRED</unmanaged>
        /// <unmanaged-short>BATTERY_TYPE_WIRED</unmanaged-short>
        Wired = unchecked((System.Byte)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>BATTERY_TYPE_ALKALINE</unmanaged>
        /// <unmanaged-short>BATTERY_TYPE_ALKALINE</unmanaged-short>
        Alkaline = unchecked((System.Byte)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>BATTERY_TYPE_NIMH</unmanaged>
        /// <unmanaged-short>BATTERY_TYPE_NIMH</unmanaged-short>
        Nimh = unchecked((System.Byte)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>BATTERY_TYPE_UNKNOWN</unmanaged>
        /// <unmanaged-short>BATTERY_TYPE_UNKNOWN</unmanaged-short>
        Unknown = unchecked((System.Byte)(255))
    }
}
