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
using System.Runtime.InteropServices;

namespace DXNET
{
    /// <summary>
    /// An Interface shadow callback
    /// </summary>
    public abstract class CppObjectShadow : CppObject
    {
        /// <summary>
        /// Gets the callback.
        /// </summary>
        public ICallbackable Callback { get; private set; }

        /// <summary>
        /// Gets the VTBL associated with this shadow instance.
        /// </summary>
        protected abstract CppObjectVtbl GetVtbl { get; }

        /// <summary>
        /// Initializes the specified shadow instance from a vtbl and a callback.
        /// </summary>
        /// <param name="callbackInstance">The callback.</param>
        public unsafe virtual void Initialize(ICallbackable callbackInstance)
        {
            this.Callback = callbackInstance;

            // Allocate ptr to vtbl + ptr to callback together
            NativePointer = Marshal.AllocHGlobal(IntPtr.Size * 2);

            var handle = GCHandle.Alloc(this);
            Marshal.WriteIntPtr(NativePointer, GetVtbl.Pointer);

            *((IntPtr*) NativePointer + 1) = GCHandle.ToIntPtr(handle);
        }

        protected unsafe override void Dispose(bool disposing)
        {
            if (NativePointer != IntPtr.Zero)
            {
                // Free the GCHandle
                GCHandle.FromIntPtr(*(((IntPtr*)NativePointer) + 1)).Free();

                // Free instance
                Marshal.FreeHGlobal(NativePointer);
                NativePointer = IntPtr.Zero;
            }
            Callback = null;
            base.Dispose(disposing);
        }

        /// <summary>
        /// ToShadow
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="thisPtr"></param>
        /// <returns></returns>
        public static T ToShadow<T>(IntPtr thisPtr) where T : CppObjectShadow
        {
            unsafe
            {
                return (T)GCHandle.FromIntPtr(*(((IntPtr*)thisPtr) + 1)).Target;
            }
        }
    }
}
