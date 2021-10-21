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

namespace DXNET.Direct2D1
{
    public partial class LinearGradientBrush
    {

        /// <summary>	
        /// Creates an <see cref="DXNET.Direct2D1.LinearGradientBrush"/> that contains the specified gradient stops and has the specified transform and base opacity. 	
        /// </summary>	
        /// <param name="renderTarget">an instance of <see cref = "DXNET.Direct2D1.RenderTarget" /></param>
        /// <param name="linearGradientBrushProperties">The start and end points of the gradient.</param>
        /// <param name="gradientStopCollection">A collection of <see cref="DXNET.Direct2D1.GradientStop"/> structures that describe the colors in the brush's gradient and their locations along the gradient line.</param>
        /// <unmanaged>HRESULT CreateLinearGradientBrush([In] const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties,[In, Optional] const D2D1_BRUSH_PROPERTIES* brushProperties,[In] ID2D1GradientStopCollection* gradientStopCollection,[Out] ID2D1LinearGradientBrush** linearGradientBrush)</unmanaged>
        public LinearGradientBrush(RenderTarget renderTarget, DXNET.Direct2D1.LinearGradientBrushProperties linearGradientBrushProperties, DXNET.Direct2D1.GradientStopCollection gradientStopCollection) : this(renderTarget, linearGradientBrushProperties, null, gradientStopCollection)
        {
        }

        /// <summary>	
        /// Creates an <see cref="DXNET.Direct2D1.LinearGradientBrush"/> that contains the specified gradient stops and has the specified transform and base opacity. 	
        /// </summary>	
        /// <param name="renderTarget">an instance of <see cref = "DXNET.Direct2D1.RenderTarget" /></param>
        /// <param name="linearGradientBrushProperties">The start and end points of the gradient.</param>
        /// <param name="brushProperties">The transform and base opacity of the new brush, or NULL. If this value is NULL, the brush defaults to a base opacity of 1.0f and the identity matrix as its transformation.</param>
        /// <param name="gradientStopCollection">A collection of <see cref="DXNET.Direct2D1.GradientStop"/> structures that describe the colors in the brush's gradient and their locations along the gradient line.</param>
        /// <unmanaged>HRESULT CreateLinearGradientBrush([In] const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties,[In, Optional] const D2D1_BRUSH_PROPERTIES* brushProperties,[In] ID2D1GradientStopCollection* gradientStopCollection,[Out] ID2D1LinearGradientBrush** linearGradientBrush)</unmanaged>
        public LinearGradientBrush(RenderTarget renderTarget, DXNET.Direct2D1.LinearGradientBrushProperties linearGradientBrushProperties, DXNET.Direct2D1.BrushProperties? brushProperties, DXNET.Direct2D1.GradientStopCollection gradientStopCollection) : base(IntPtr.Zero)
        {
            renderTarget.CreateLinearGradientBrush(linearGradientBrushProperties, brushProperties, gradientStopCollection, this);
        }

    }
}
