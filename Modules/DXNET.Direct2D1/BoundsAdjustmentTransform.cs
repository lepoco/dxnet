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
using DXNET.Mathematics.Interop;

namespace DXNET.Direct2D1
{
    public partial class BoundsAdjustmentTransform
    {
        /// <summary>
        /// Initializes a new instance of <see cref="BoundsAdjustmentTransform"/> class
        /// </summary>
        /// <param name="context">The effect context</param>
        /// <param name="outputRectangle">The output rectangle region used for this transformation</param>
        /// <unmanaged>HRESULT ID2D1EffectContext::CreateBoundsAdjustmentTransform([In] const RECT* outputRectangle,[Out, Fast] ID2D1BoundsAdjustmentTransform** transform)</unmanaged>	
        public BoundsAdjustmentTransform(EffectContext context, RawRectangle outputRectangle) : base(IntPtr.Zero)
        {
            context.CreateBoundsAdjustmentTransform(outputRectangle, this);
        }
    }
}