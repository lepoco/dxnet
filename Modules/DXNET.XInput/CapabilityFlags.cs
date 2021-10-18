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

namespace DXNET.XInput
{
    [Flags]
    public enum CapabilityFlags : System.Int16
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_VOICE_SUPPORTED</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_VOICE_SUPPORTED</unmanaged-short>
        VoiceSupported = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_FFB_SUPPORTED</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_FFB_SUPPORTED</unmanaged-short>
        FfbSupported = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_WIRELESS</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_WIRELESS</unmanaged-short>
        Wireless = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_PMD_SUPPORTED</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_PMD_SUPPORTED</unmanaged-short>
        PmdSupported = unchecked((System.Int16)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_NO_NAVIGATION</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_NO_NAVIGATION</unmanaged-short>
        NoNavigation = unchecked((System.Int16)(16)),
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = unchecked((System.Int16)(0))
    }
}
