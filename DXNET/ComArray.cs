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
using System.Collections;
using System.Collections.Generic;

namespace DXNET
{
    /// <summary>
    /// A fast method to pass array of <see cref="ComObject"/> to SharpDX methods.
    /// </summary>
    public class ComArray : DisposeBase, IEnumerable
    {
        /// <summary>
        /// values
        /// </summary>
        protected ComObject[] values;

        private IntPtr nativeBuffer;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComArray"/> class.
        /// </summary>
        /// <param name="array">The array.</param>
        public ComArray(params ComObject[] array)
        {
            values = array;
            nativeBuffer = IntPtr.Zero;
            if (values != null)
            {
                int length = array.Length;
                values = new ComObject[length];
                nativeBuffer = Utilities.AllocateMemory(length * Utilities.SizeOf<IntPtr>());
                for (int i = 0; i < length; i++)
                    Set(i, array[i]);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComArray"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public ComArray(int size)
        {
            values = new ComObject[size];
            nativeBuffer = Utilities.AllocateMemory(size * Utilities.SizeOf<IntPtr>());
        }

        /// <summary>
        /// Gets the pointer to the native array associated to this instance.
        /// </summary>
        public IntPtr NativePointer
        {
            get
            {
                return nativeBuffer;
            }
        }

        /// <summary>
        /// Gets the length.
        /// </summary>
        public int Length
        {
            get
            {
                return values == null ? 0 : values.Length;
            }
        }

        /// <summary>
        /// Gets an object at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>A <see cref="ComObject"/></returns>
        public ComObject Get(int index)
        {
            return values[index];
        }

        internal void SetFromNative(int index, ComObject value)
        {
            values[index] = value;
            unsafe
            {
                value.NativePointer = ((IntPtr*)nativeBuffer)[index];
            }
        }

        /// <summary>
        /// Sets an object at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="value">The value.</param>
        public void Set(int index, ComObject value)
        {
            values[index] = value;
            unsafe
            {
                ((IntPtr*)nativeBuffer)[index] = value.NativePointer;
            }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                values = null;
            }
            Utilities.FreeMemory(nativeBuffer);
            nativeBuffer = IntPtr.Zero;
        }

        /// <inheritdoc/>
        public IEnumerator GetEnumerator()
        {
            return values.GetEnumerator();
        }
    }

    /// <summary>
    /// A typed version of <see cref="ComArray"/>
    /// </summary>
    /// <typeparam name="T">Type of the <see cref="ComObject"/></typeparam>
    public class ComArray<T> : ComArray, IEnumerable<T> where T : ComObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComArray&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="array">The array.</param>
        public ComArray(params T[] array) : base(array)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComArray&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public ComArray(int size) : base(size)
        {
        }

        /// <summary>
        /// Gets or sets the <see langword="T"/> with the specified <see langword="i"/>.
        /// </summary>
        public T this[int i]
        {
            get
            {
                return (T)Get(i);
            }
            set
            {
                Set(i, value);
            }
        }

        /// <summary>
        /// GetEnumerator
        /// </summary>
        /// <returns></returns>
        public new IEnumerator<T> GetEnumerator()
        {
            return new ArrayEnumerator<T>(values.GetEnumerator());
        }

        private struct ArrayEnumerator<T1> : IEnumerator<T1> where T1 : ComObject
        {
            private readonly IEnumerator enumerator;

            /// <summary>
            /// ArrayEnumerator
            /// </summary>
            /// <param name="enumerator"></param>
            public ArrayEnumerator(IEnumerator enumerator)
            {
                this.enumerator = enumerator;
            }

            /// <summary>
            /// Dispose
            /// </summary>
            public void Dispose()
            {
            }

            /// <summary>
            /// MoveNext
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                return enumerator.MoveNext();
            }

            /// <summary>
            /// Reset
            /// </summary>
            public void Reset()
            {
                enumerator.Reset();
            }

            /// <summary>
            /// Current
            /// </summary>
            public T1 Current
            {
                get
                {
                    return (T1)enumerator.Current;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
        }
    }
}