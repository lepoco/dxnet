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
using System.Runtime.InteropServices;

namespace DXNET.RawInput
{
    /// <summary>
    /// Functions
    /// </summary>
    static partial class RawInputFunctions
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "hRawInput">No documentation.</param>
        /// <param name = "uiCommand">No documentation.</param>
        /// <param name = "dataRef">No documentation.</param>
        /// <param name = "cbSizeRef">No documentation.</param>
        /// <param name = "cbSizeHeader">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>unsigned int GetRawInputData([In] HRAWINPUT hRawInput,[In] unsigned int uiCommand,[Out, Buffer, Optional] void* pData,[InOut] unsigned int* pcbSize,[In] unsigned int cbSizeHeader)</unmanaged>
        /// <unmanaged-short>GetRawInputData</unmanaged-short>
        public static unsafe int GetRawInputData(System.IntPtr hRawInput, DXNET.RawInput.RawInputDataType uiCommand, System.IntPtr dataRef, ref System.Int32 cbSizeRef, System.Int32 cbSizeHeader)
        {
            System.Int32 __result__;
            fixed (void* cbSizeRef_ = &cbSizeRef)
                __result__ = GetRawInputData_((void*)hRawInput, unchecked((System.Int32)uiCommand), (void*)dataRef, cbSizeRef_, cbSizeHeader);
            return __result__;
        }

        [DllImport("user32.dll", EntryPoint = "GetRawInputData", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern int GetRawInputData_(void* param0, int param1, void* param2, void* param3, int param4);
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "hDevice">No documentation.</param>
        /// <param name = "uiCommand">No documentation.</param>
        /// <param name = "dataRef">No documentation.</param>
        /// <param name = "cbSizeRef">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>unsigned int GetRawInputDeviceInfoW([In, Optional] void* hDevice,[In] unsigned int uiCommand,[Out, Buffer, Optional] void* pData,[InOut] unsigned int* pcbSize)</unmanaged>
        /// <unmanaged-short>GetRawInputDeviceInfoW</unmanaged-short>
        public static unsafe System.Int32 GetRawInputDeviceInfo(System.IntPtr hDevice, DXNET.RawInput.RawInputDeviceInfoType uiCommand, System.IntPtr dataRef, ref System.Int32 cbSizeRef)
        {
            System.Int32 __result__;
            fixed (void* cbSizeRef_ = &cbSizeRef)
                __result__ = GetRawInputDeviceInfoW_((void*)hDevice, unchecked((System.Int32)uiCommand), (void*)dataRef, cbSizeRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "GetRawInputDeviceInfoW", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int GetRawInputDeviceInfoW_(void* param0, int param1, void* param2, void* param3);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "dataRef">No documentation.</param>
        /// <param name = "cbSizeRef">No documentation.</param>
        /// <param name = "cbSizeHeader">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>unsigned int GetRawInputBuffer([Out, Buffer, Optional] RAWINPUT* pData,[InOut] unsigned int* pcbSize,[In] unsigned int cbSizeHeader)</unmanaged>
        /// <unmanaged-short>GetRawInputBuffer</unmanaged-short>
        public static unsafe int GetRawInputBuffer(DXNET.RawInput.RawInput[] dataRef, ref System.Int32 cbSizeRef, System.Int32 cbSizeHeader)
        {
            DXNET.RawInput.RawInput.__Native[] dataRef_ = dataRef == null ? null : new DXNET.RawInput.RawInput.__Native[dataRef.Length];
            System.Int32 __result__;
            fixed (void* cbSizeRef_ = &cbSizeRef)
            fixed (void* _dataRef = dataRef_)
                __result__ = GetRawInputBuffer_(_dataRef, cbSizeRef_, cbSizeHeader);
            if (dataRef != null)
                for (int i = 0; i < dataRef.Length; ++i)
                    if (dataRef != null)
                        dataRef[i].__MarshalFrom(ref (dataRef_)[i]);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "GetRawInputBuffer", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int GetRawInputBuffer_(void* param0, void* param1, int param2);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "rawInputDevicesRef">No documentation.</param>
        /// <param name = "uiNumDevices">No documentation.</param>
        /// <param name = "cbSize">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>BOOL RegisterRawInputDevices([In, Buffer] const RAWINPUTDEVICE* pRawInputDevices,[In] unsigned int uiNumDevices,[In] unsigned int cbSize)</unmanaged>
        /// <unmanaged-short>RegisterRawInputDevices</unmanaged-short>
        public static unsafe DXNET.Mathematics.Interop.RawBool RegisterRawInputDevices(DXNET.RawInput.RawInputDevice[] rawInputDevicesRef, System.Int32 uiNumDevices, System.Int32 cbSize)
        {
            DXNET.Mathematics.Interop.RawBool __result__;
            fixed (void* rawInputDevicesRef_ = rawInputDevicesRef)
                __result__ = RegisterRawInputDevices_(rawInputDevicesRef_, uiNumDevices, cbSize);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "RegisterRawInputDevices", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern DXNET.Mathematics.Interop.RawBool RegisterRawInputDevices_(void* param0, int param1, int param2);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "rawInputDevicesRef">No documentation.</param>
        /// <param name = "uiNumDevicesRef">No documentation.</param>
        /// <param name = "cbSize">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>unsigned int GetRegisteredRawInputDevices([Out, Buffer, Optional] RAWINPUTDEVICE* pRawInputDevices,[InOut] unsigned int* puiNumDevices,[In] unsigned int cbSize)</unmanaged>
        /// <unmanaged-short>GetRegisteredRawInputDevices</unmanaged-short>
        public static unsafe System.Int32 GetRegisteredRawInputDevices(DXNET.RawInput.RawInputDevice[] rawInputDevicesRef, ref System.Int32 uiNumDevicesRef, System.Int32 cbSize)
        {
            System.Int32 __result__;
            fixed (void* uiNumDevicesRef_ = &uiNumDevicesRef)
            fixed (void* rawInputDevicesRef_ = rawInputDevicesRef)
                __result__ = GetRegisteredRawInputDevices_(rawInputDevicesRef_, uiNumDevicesRef_, cbSize);
            return __result__;
        }

        [DllImport("user32.dll", EntryPoint = "GetRegisteredRawInputDevices", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern int GetRegisteredRawInputDevices_(void* param0, void* param1, int param2);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "rawInputDeviceListRef">No documentation.</param>
        /// <param name = "uiNumDevicesRef">No documentation.</param>
        /// <param name = "cbSize">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>unsigned int GetRawInputDeviceList([Out, Buffer, Optional] RAWINPUTDEVICELIST* pRawInputDeviceList,[InOut] unsigned int* puiNumDevices,[In] unsigned int cbSize)</unmanaged>
        /// <unmanaged-short>GetRawInputDeviceList</unmanaged-short>
        public static unsafe System.Int32 GetRawInputDeviceList(DXNET.RawInput.RawInputDevicelist[] rawInputDeviceListRef, ref System.Int32 uiNumDevicesRef, System.Int32 cbSize)
        {
            System.Int32 __result__;
            fixed (void* uiNumDevicesRef_ = &uiNumDevicesRef)
            fixed (void* rawInputDeviceListRef_ = rawInputDeviceListRef)
                __result__ = GetRawInputDeviceList_(rawInputDeviceListRef_, uiNumDevicesRef_, cbSize);
            return __result__;
        }

        [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceList", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern int GetRawInputDeviceList_(void* param0, void* param1, int param2);
    }
}
