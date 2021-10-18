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

namespace DXNET.XInput
{
    /// <summary>
    /// Functions
    /// </summary>
    static partial class XInput
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "dwUserIndex">No documentation.</param>
        /// <param name = "stateRef">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>DWORD XInputGetState([In] DWORD dwUserIndex,[Out] XINPUT_STATE* pState)</unmanaged>
        /// <unmanaged-short>XInputGetState</unmanaged-short>
        public static unsafe System.Int32 XInputGetState(System.Int32 dwUserIndex, out DXNET.XInput.State stateRef)
        {
            stateRef = default(DXNET.XInput.State);
            System.Int32 __result__;
            fixed (void* stateRef_ = &stateRef)
                __result__ = XInputGetState_(dwUserIndex, stateRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetState", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetState_(int param0, void* param1);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "dwUserIndex">No documentation.</param>
        /// <param name = "vibrationRef">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>DWORD XInputSetState([In] DWORD dwUserIndex,[In] XINPUT_VIBRATION* pVibration)</unmanaged>
        /// <unmanaged-short>XInputSetState</unmanaged-short>
        public static unsafe System.Int32 XInputSetState(System.Int32 dwUserIndex, ref DXNET.XInput.Vibration vibrationRef)
        {
            DXNET.XInput.Vibration.__Native vibrationRef_ = default(DXNET.XInput.Vibration.__Native);
            System.Int32 __result__;
            vibrationRef.__MarshalTo(ref vibrationRef_);
            __result__ = XInputSetState_(dwUserIndex, &vibrationRef_);
            vibrationRef.__MarshalFree(ref vibrationRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputSetState", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputSetState_(int param0, void* param1);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "dwUserIndex">No documentation.</param>
        /// <param name = "dwFlags">No documentation.</param>
        /// <param name = "capabilitiesRef">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>DWORD XInputGetCapabilities([In] DWORD dwUserIndex,[In] DWORD dwFlags,[Out] XINPUT_CAPABILITIES* pCapabilities)</unmanaged>
        /// <unmanaged-short>XInputGetCapabilities</unmanaged-short>
        public static unsafe System.Int32 XInputGetCapabilities(System.Int32 dwUserIndex, DXNET.XInput.DeviceQueryType dwFlags, out DXNET.XInput.Capabilities capabilitiesRef)
        {
            DXNET.XInput.Capabilities.__Native capabilitiesRef_ = default(DXNET.XInput.Capabilities.__Native);
            capabilitiesRef = default(DXNET.XInput.Capabilities);
            System.Int32 __result__;
            __result__ = XInputGetCapabilities_(dwUserIndex, unchecked((System.Int32)dwFlags), &capabilitiesRef_);
            capabilitiesRef.__MarshalFrom(ref capabilitiesRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetCapabilities", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetCapabilities_(int param0, int param1, void* param2);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "enable">No documentation.</param>
        /// <unmanaged>void XInputEnable([In] BOOL enable)</unmanaged>
        /// <unmanaged-short>XInputEnable</unmanaged-short>
        public static unsafe void XInputEnable(DXNET.Mathematics.Interop.RawBool enable)
        {
            XInputEnable_(enable);
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputEnable", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern void XInputEnable_(DXNET.Mathematics.Interop.RawBool param0);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "dwUserIndex">No documentation.</param>
        /// <param name = "renderDeviceIdRef">No documentation.</param>
        /// <param name = "renderCountRef">No documentation.</param>
        /// <param name = "captureDeviceIdRef">No documentation.</param>
        /// <param name = "captureCountRef">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>DWORD XInputGetAudioDeviceIds([In] DWORD dwUserIndex,[Out, Buffer, Optional] wchar_t* pRenderDeviceId,[InOut, Optional] unsigned int* pRenderCount,[Out, Buffer, Optional] wchar_t* pCaptureDeviceId,[InOut, Optional] unsigned int* pCaptureCount)</unmanaged>
        /// <unmanaged-short>XInputGetAudioDeviceIds</unmanaged-short>
        public static unsafe System.Int32 XInputGetAudioDeviceIds(System.Int32 dwUserIndex, System.IntPtr renderDeviceIdRef, System.IntPtr renderCountRef, System.IntPtr captureDeviceIdRef, System.IntPtr captureCountRef)
        {
            System.Int32 __result__;
            __result__ = XInputGetAudioDeviceIds_(dwUserIndex, (void*)renderDeviceIdRef, (void*)renderCountRef, (void*)captureDeviceIdRef, (void*)captureCountRef);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetAudioDeviceIds", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetAudioDeviceIds_(int param0, void* param1, void* param2, void* param3, void* param4);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "dwUserIndex">No documentation.</param>
        /// <param name = "devType">No documentation.</param>
        /// <param name = "batteryInformationRef">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>DWORD XInputGetBatteryInformation([In] DWORD dwUserIndex,[In] unsigned char devType,[Out] XINPUT_BATTERY_INFORMATION* pBatteryInformation)</unmanaged>
        /// <unmanaged-short>XInputGetBatteryInformation</unmanaged-short>
        public static unsafe System.Int32 XInputGetBatteryInformation(System.Int32 dwUserIndex, DXNET.XInput.BatteryDeviceType devType, out DXNET.XInput.BatteryInformation batteryInformationRef)
        {
            batteryInformationRef = default(DXNET.XInput.BatteryInformation);
            System.Int32 __result__;
            fixed (void* batteryInformationRef_ = &batteryInformationRef)
                __result__ = XInputGetBatteryInformation_(dwUserIndex, unchecked((System.Int32)devType), batteryInformationRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetBatteryInformation", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetBatteryInformation_(int param0, int param1, void* param2);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "dwUserIndex">No documentation.</param>
        /// <param name = "dwReserved">No documentation.</param>
        /// <param name = "keystrokeRef">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>DWORD XInputGetKeystroke([In] DWORD dwUserIndex,[In] DWORD dwReserved,[Out] XINPUT_KEYSTROKE* pKeystroke)</unmanaged>
        /// <unmanaged-short>XInputGetKeystroke</unmanaged-short>
        public static unsafe System.Int32 XInputGetKeystroke(System.Int32 dwUserIndex, System.Int32 dwReserved, out DXNET.XInput.Keystroke keystrokeRef)
        {
            keystrokeRef = default(DXNET.XInput.Keystroke);
            System.Int32 __result__;
            fixed (void* keystrokeRef_ = &keystrokeRef)
                __result__ = XInputGetKeystroke_(dwUserIndex, dwReserved, keystrokeRef_);
            return __result__;
        }

        [System.Runtime.InteropServices.DllImportAttribute("xinput1_4.dll", EntryPoint = "XInputGetKeystroke", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private unsafe static extern int XInputGetKeystroke_(int param0, int param1, void* param2);
    }
}
