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
using System.Collections.Generic;

namespace DXNET.DXGI
{
    /// <summary>
    /// DXGI_ADAPTER_FLAG3
    /// </summary>
    public enum AdapterFlags3 : int
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_ADAPTER_FLAG3_NONE</unmanaged>
        /// <unmanaged-short>DXGI_ADAPTER_FLAG3_NONE</unmanaged-short>
        None = unchecked((System.Int32)(0)),
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_ADAPTER_FLAG3_REMOTE</unmanaged>
        /// <unmanaged-short>DXGI_ADAPTER_FLAG3_REMOTE</unmanaged-short>
        Remote = unchecked((System.Int32)(1)),
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_ADAPTER_FLAG3_SOFTWARE</unmanaged>
        /// <unmanaged-short>DXGI_ADAPTER_FLAG3_SOFTWARE</unmanaged-short>
        Software = unchecked((System.Int32)(2)),
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE</unmanaged>
        /// <unmanaged-short>DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE</unmanaged-short>
        AcgCompatible = unchecked((System.Int32)(4)),
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES</unmanaged>
        /// <unmanaged-short>DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES</unmanaged-short>
        SupportMonitoredFences = unchecked((System.Int32)(8)),
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES</unmanaged>
        /// <unmanaged-short>DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES</unmanaged-short>
        SupportNonMonitoredFences = unchecked((System.Int32)(16)),
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE</unmanaged>
        /// <unmanaged-short>DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE</unmanaged-short>
        KeyedMutexConformance = unchecked((System.Int32)(32))
    }
}