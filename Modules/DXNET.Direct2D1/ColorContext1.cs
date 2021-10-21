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
using System.Collections.Generic;
using System.Text;

namespace DXNET.Direct2D1
{
    public partial class ColorContext1
    {
        /// <summary>	
        /// Initializes a new instance of <see cref="ColorContext1"/> class from ColorSpaceType.
        /// </summary>	
        /// <param name="context">No documentation.</param>	
        /// <param name="wicColorContext">No documentation.</param>	
        /// <unmanaged>HRESULT ID2D1DeviceContext5::CreateColorContextFromDxgiColorSpace([In] DXGI_COLOR_SPACE_TYPE colorSpace,[Out, Fast] ID2D1ColorContext1** colorContext)</unmanaged>	
        public ColorContext1(DeviceContext5 context, DXNET.DXGI.ColorSpaceType colorSpace)
            : base(IntPtr.Zero)
        {
            context.CreateColorContextFromDxgiColorSpace(colorSpace, this);
        }

        /// <summary>	
        /// Initializes a new instance of <see cref="ColorContext1"/> class from SimpleColorProfile.
        /// </summary>	
        /// <param name="context">No documentation.</param>	
        /// <param name="wicColorContext">No documentation.</param>	
        /// <unmanaged>HRESULT ID2D1DeviceContext5::CreateColorContextFromDxgiColorSpace([In] DXGI_COLOR_SPACE_TYPE colorSpace,[Out, Fast] ID2D1ColorContext1** colorContext)</unmanaged>	
        public ColorContext1(DeviceContext5 context, ref DXNET.Direct2D1.SimpleColorProfile simpleProfile)
            : base(IntPtr.Zero)
        {
            context.CreateColorContextFromSimpleColorProfile(ref simpleProfile, this);
        }

        /// <summary>	
        /// Initializes a new instance of <see cref="ColorContext1"/> class from ColorSpaceType.
        /// </summary>	
        /// <param name="context">No documentation.</param>	
        /// <param name="wicColorContext">No documentation.</param>	
        /// <unmanaged>HRESULT ID2D1DeviceContext5::CreateColorContextFromDxgiColorSpace([In] DXGI_COLOR_SPACE_TYPE colorSpace,[Out, Fast] ID2D1ColorContext1** colorContext)</unmanaged>	
        public ColorContext1(EffectContext2 context, DXNET.DXGI.ColorSpaceType colorSpace)
            : base(IntPtr.Zero)
        {
            context.CreateColorContextFromDxgiColorSpace(colorSpace, this);
        }

        /// <summary>	
        /// Initializes a new instance of <see cref="ColorContext1"/> class from SimpleColorProfile.
        /// </summary>	
        /// <param name="context">No documentation.</param>	
        /// <param name="wicColorContext">No documentation.</param>	
        /// <unmanaged>HRESULT ID2D1DeviceContext5::CreateColorContextFromDxgiColorSpace([In] DXGI_COLOR_SPACE_TYPE colorSpace,[Out, Fast] ID2D1ColorContext1** colorContext)</unmanaged>	
        public ColorContext1(EffectContext2 context, ref DXNET.Direct2D1.SimpleColorProfile simpleProfile)
            : base(IntPtr.Zero)
        {
            context.CreateColorContextFromSimpleColorProfile(ref simpleProfile, this);
        }
    }
}