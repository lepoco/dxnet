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
    /// Functions
    /// </summary>
    static partial class DXGI
    {
        ///<summary>Constant CreateFactoryDebug</summary>
        ///<unmanaged>DXGI_CREATE_FACTORY_DEBUG</unmanaged>
        public const int CreateFactoryDebug = 1;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "riid">No documentation.</param>
        /// <param name = "factoryOut">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT CreateDXGIFactory1([In] const GUID&amp; riid,[Out] void** ppFactory)</unmanaged>
        /// <unmanaged-short>CreateDXGIFactory1</unmanaged-short>
        public static unsafe void CreateDXGIFactory1(System.Guid riid, out System.IntPtr factoryOut)
        {
            DXNET.Result __result__;
            fixed (void* factoryOut_ = &factoryOut)
                __result__ = CreateDXGIFactory1_(&riid, factoryOut_);
            __result__.CheckError();
        }

        [System.Runtime.InteropServices.DllImportAttribute("dxgi.dll", EntryPoint = "CreateDXGIFactory1", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int CreateDXGIFactory1_(void* param0, void* param1);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "flags">No documentation.</param>
        /// <param name = "riid">No documentation.</param>
        /// <param name = "factoryOut">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT CreateDXGIFactory2([In] unsigned int Flags,[In] const GUID&amp; riid,[Out] void** ppFactory)</unmanaged>
        /// <unmanaged-short>CreateDXGIFactory2</unmanaged-short>
        public static unsafe void CreateDXGIFactory2(System.Int32 flags, System.Guid riid, out System.IntPtr factoryOut)
        {
            DXNET.Result __result__;
            fixed (void* factoryOut_ = &factoryOut)
                __result__ = CreateDXGIFactory2_(flags, &riid, factoryOut_);
            __result__.CheckError();
        }

        [System.Runtime.InteropServices.DllImportAttribute("dxgi.dll", EntryPoint = "CreateDXGIFactory2", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int CreateDXGIFactory2_(int param0, void* param1, void* param2);
    }
}