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

namespace DXNET.RawInput
{
    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>RAW_DEVICE_FLAGS</unmanaged>
    /// <unmanaged-short>RAW_DEVICE_FLAGS</unmanaged-short>
    [Flags]
    public enum DeviceFlags : int
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_REMOVE</unmanaged>
        /// <unmanaged-short>RIDEV_REMOVE</unmanaged-short>
        Remove = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_EXCLUDE</unmanaged>
        /// <unmanaged-short>RIDEV_EXCLUDE</unmanaged-short>
        Exclude = unchecked((System.Int32)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_PAGEONLY</unmanaged>
        /// <unmanaged-short>RIDEV_PAGEONLY</unmanaged-short>
        PageOnly = unchecked((System.Int32)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_NOLEGACY</unmanaged>
        /// <unmanaged-short>RIDEV_NOLEGACY</unmanaged-short>
        NoLegacy = unchecked((System.Int32)(48)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_INPUTSINK</unmanaged>
        /// <unmanaged-short>RIDEV_INPUTSINK</unmanaged-short>
        InputSink = unchecked((System.Int32)(256)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_CAPTUREMOUSE</unmanaged>
        /// <unmanaged-short>RIDEV_CAPTUREMOUSE</unmanaged-short>
        CaptureMouse = unchecked((System.Int32)(512)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_NOHOTKEYS</unmanaged>
        /// <unmanaged-short>RIDEV_NOHOTKEYS</unmanaged-short>
        NoHotKeys = unchecked((System.Int32)(512)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_APPKEYS</unmanaged>
        /// <unmanaged-short>RIDEV_APPKEYS</unmanaged-short>
        AppKeys = unchecked((System.Int32)(1024)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_EXINPUTSINK</unmanaged>
        /// <unmanaged-short>RIDEV_EXINPUTSINK</unmanaged-short>
        ExclusiveInputSink = unchecked((System.Int32)(4096)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RIDEV_DEVNOTIFY</unmanaged>
        /// <unmanaged-short>RIDEV_DEVNOTIFY</unmanaged-short>
        DeviceNotify = unchecked((System.Int32)(8192)),
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = unchecked((System.Int32)(0))
    }
}
