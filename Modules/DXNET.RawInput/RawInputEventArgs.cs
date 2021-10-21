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

namespace DXNET.RawInput
{
    /// <summary>
    /// RawInput event arguments base.
    /// </summary>
    public abstract class RawInputEventArgs : EventArgs
    {
        protected RawInputEventArgs()
        {
        }

        internal RawInputEventArgs(ref RawInput rawInput, IntPtr hwnd)
        {
            Device = rawInput.Header.Device;
	        WindowHandle = hwnd;
        }

        /// <summary>
        /// Gets or sets the RawInput device.
        /// </summary>
        /// <value>
        /// The device.
        /// </value>
        public IntPtr Device { get; set; }

        /// <summary>
        /// Gets or sets the handle of the window that received the RawInput mesage.
        /// </summary>
        /// <value>
        /// The window handle.
        /// </value>
        public IntPtr WindowHandle { get; set; }
    }
}