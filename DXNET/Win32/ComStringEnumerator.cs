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
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DXNET.Win32
{
    /// <summary>
    /// An enumerator using internally a <see cref="IEnumString"/>.
    /// </summary>
    internal class ComStringEnumerator : IEnumerator<string>, IEnumerable<string>
    {
        private readonly IEnumString enumString;
        private string current;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComStringEnumerator"/> class.
        /// </summary>
        /// <param name="ptrToIEnumString">The PTR to I enum string.</param>
        public ComStringEnumerator(IntPtr ptrToIEnumString)
        {
            enumString = (IEnumString)Marshal.GetObjectForIUnknown(ptrToIEnumString);
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            unsafe
            {
                var output = new string[1];
                int count = 0;
                var hasNext = enumString.Next(1, output, new IntPtr(&count)) == Result.Ok.Code;
                current = hasNext ? output[0] : null;
                return hasNext;
            }
        }

        public void Reset()
        {
            enumString.Reset();
        }

        public string Current
        {
            get { return current; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}