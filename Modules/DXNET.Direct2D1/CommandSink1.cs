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

namespace DXNET.Direct2D1
{
    public partial interface CommandSink1
    {
        /// <summary>	
        /// <p>Enables access to the new primitive blend modes, MIN and ADD.</p>	
        /// </summary>	
        /// <param name="value">No documentation.</param>	
        /// <returns>No documentation.</returns>	
        /// <include file='.\Documentation\CodeComments.xml' path="/comments/comment[@id='ID2D1CommandSink1::SetPrimitiveBlend1']/*"/>	
        /// <msdn-id>dn280436</msdn-id>	
        /// <unmanaged>HRESULT ID2D1CommandSink1::SetPrimitiveBlend1([In] D2D1_PRIMITIVE_BLEND primitiveBlend)</unmanaged>	
        /// <unmanaged-short>ID2D1CommandSink1::SetPrimitiveBlend1</unmanaged-short>	
        PrimitiveBlend PrimitiveBlend1 { set; }
    }
}
