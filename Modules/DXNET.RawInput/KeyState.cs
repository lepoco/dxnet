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
    /// RAW_KEY_STATE
    /// </summary>
    public enum KeyState : int
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_VKEYTOITEM</unmanaged>
        /// <unmanaged-short>WM_VKEYTOITEM</unmanaged-short>
        VirtualKeyToItem = unchecked((System.Int32)(46)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_SETHOTKEY</unmanaged>
        /// <unmanaged-short>WM_SETHOTKEY</unmanaged-short>
        SetHotKey = unchecked((System.Int32)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_GETHOTKEY</unmanaged>
        /// <unmanaged-short>WM_GETHOTKEY</unmanaged-short>
        GetHotKey = unchecked((System.Int32)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_KEYFIRST</unmanaged>
        /// <unmanaged-short>WM_KEYFIRST</unmanaged-short>
        KeyFirst = unchecked((System.Int32)(256)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_KEYDOWN</unmanaged>
        /// <unmanaged-short>WM_KEYDOWN</unmanaged-short>
        KeyDown = unchecked((System.Int32)(256)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_KEYUP</unmanaged>
        /// <unmanaged-short>WM_KEYUP</unmanaged-short>
        KeyUp = unchecked((System.Int32)(257)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_SYSKEYDOWN</unmanaged>
        /// <unmanaged-short>WM_SYSKEYDOWN</unmanaged-short>
        SystemKeyDown = unchecked((System.Int32)(260)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_SYSKEYUP</unmanaged>
        /// <unmanaged-short>WM_SYSKEYUP</unmanaged-short>
        SystemKeyUp = unchecked((System.Int32)(261)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_KEYLAST</unmanaged>
        /// <unmanaged-short>WM_KEYLAST</unmanaged-short>
        KeyLast = unchecked((System.Int32)(265)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_IME_KEYLAST</unmanaged>
        /// <unmanaged-short>WM_IME_KEYLAST</unmanaged-short>
        ImeKeyLast = unchecked((System.Int32)(271)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_IME_KEYDOWN</unmanaged>
        /// <unmanaged-short>WM_IME_KEYDOWN</unmanaged-short>
        ImeKeyDown = unchecked((System.Int32)(656)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_IME_KEYUP</unmanaged>
        /// <unmanaged-short>WM_IME_KEYUP</unmanaged-short>
        ImeKeyUp = unchecked((System.Int32)(657)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WM_HOTKEY</unmanaged>
        /// <unmanaged-short>WM_HOTKEY</unmanaged-short>
        HotKey = unchecked((System.Int32)(786))
    }
}
