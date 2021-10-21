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
// -----------------------------------------------------------------------------
// Original code from NAudio project. http://naudio.codeplex.com/
// Greetings to Mark Heath.
// -----------------------------------------------------------------------------

namespace DXNET.Multimedia
{
    /// <summary>
    /// HID_USAGE_PAGE
    /// </summary>
    public enum UsagePage : short
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_UNDEFINED</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_UNDEFINED</unmanaged-short>
        Undefined = unchecked((System.Int16)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_GENERIC</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_GENERIC</unmanaged-short>
        Generic = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_SIMULATION</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_SIMULATION</unmanaged-short>
        Simulation = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_VR</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_VR</unmanaged-short>
        Vr = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_SPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_SPORT</unmanaged-short>
        Sport = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_GAME</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_GAME</unmanaged-short>
        Game = unchecked((System.Int16)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_GENERIC_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_GENERIC_DEVICE</unmanaged-short>
        GenericDevice = unchecked((System.Int16)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_KEYBOARD</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_KEYBOARD</unmanaged-short>
        Keyboard = unchecked((System.Int16)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_LED</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_LED</unmanaged-short>
        Led = unchecked((System.Int16)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_BUTTON</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_BUTTON</unmanaged-short>
        Button = unchecked((System.Int16)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_ORDINAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_ORDINAL</unmanaged-short>
        Ordinal = unchecked((System.Int16)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_TELEPHONY</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_TELEPHONY</unmanaged-short>
        Telephony = unchecked((System.Int16)(11)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_CONSUMER</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_CONSUMER</unmanaged-short>
        Consumer = unchecked((System.Int16)(12)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_DIGITIZER</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_DIGITIZER</unmanaged-short>
        Digitizer = unchecked((System.Int16)(13)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_HAPTICS</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_HAPTICS</unmanaged-short>
        Haptics = unchecked((System.Int16)(14)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_PID</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_PID</unmanaged-short>
        Pid = unchecked((System.Int16)(15)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_UNICODE</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_UNICODE</unmanaged-short>
        Unicode = unchecked((System.Int16)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_ALPHANUMERIC</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_ALPHANUMERIC</unmanaged-short>
        Alphanumeric = unchecked((System.Int16)(20)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_SENSOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_SENSOR</unmanaged-short>
        Sensor = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_BARCODE_SCANNER</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_BARCODE_SCANNER</unmanaged-short>
        BarcodeScanner = unchecked((System.Int16)(140)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_WEIGHING_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_WEIGHING_DEVICE</unmanaged-short>
        WeighingDevice = unchecked((System.Int16)(141)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_MAGNETIC_STRIPE_READER</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_MAGNETIC_STRIPE_READER</unmanaged-short>
        MagneticStripeReader = unchecked((System.Int16)(142)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_CAMERA_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_CAMERA_CONTROL</unmanaged-short>
        CameraControl = unchecked((System.Int16)(144)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_ARCADE</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_ARCADE</unmanaged-short>
        Arcade = unchecked((System.Int16)(145)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_MICROSOFT_BLUETOOTH_HANDSFREE</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_MICROSOFT_BLUETOOTH_HANDSFREE</unmanaged-short>
        MicrosoftBluetoothHandsfree = unchecked((System.Int16)(65523)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_VENDOR_DEFINED_BEGIN</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_VENDOR_DEFINED_BEGIN</unmanaged-short>
        VendorDefinedBegin = unchecked((System.Int16)(65280)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_VENDOR_DEFINED_END</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_VENDOR_DEFINED_END</unmanaged-short>
        VendorDefinedEnd = unchecked((System.Int16)(65535)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_LIGHTING_ILLUMINATION</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_LIGHTING_ILLUMINATION</unmanaged-short>
        LightingIllumination = unchecked((System.Int16)(89)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_MEDICAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_MEDICAL</unmanaged-short>
        Medical = unchecked((System.Int16)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_MONITOR_PAGE0</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_MONITOR_PAGE0</unmanaged-short>
        MonitorPage0 = unchecked((System.Int16)(128)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_MONITOR_PAGE1</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_MONITOR_PAGE1</unmanaged-short>
        MonitorPage1 = unchecked((System.Int16)(129)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_MONITOR_PAGE2</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_MONITOR_PAGE2</unmanaged-short>
        MonitorPage2 = unchecked((System.Int16)(130)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_MONITOR_PAGE3</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_MONITOR_PAGE3</unmanaged-short>
        MonitorPage3 = unchecked((System.Int16)(131)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_POWER_PAGE0</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_POWER_PAGE0</unmanaged-short>
        PowerPage0 = unchecked((System.Int16)(132)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_POWER_PAGE1</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_POWER_PAGE1</unmanaged-short>
        PowerPage1 = unchecked((System.Int16)(133)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_POWER_PAGE2</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_POWER_PAGE2</unmanaged-short>
        PowerPage2 = unchecked((System.Int16)(134)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_POWER_PAGE3</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_POWER_PAGE3</unmanaged-short>
        PowerPage3 = unchecked((System.Int16)(135)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_BARCODE</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_BARCODE</unmanaged-short>
        Barcode = unchecked((System.Int16)(140)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_SCALE</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_SCALE</unmanaged-short>
        Scale = unchecked((System.Int16)(141)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_PAGE_MSR</unmanaged>
        /// <unmanaged-short>HID_USAGE_PAGE_MSR</unmanaged-short>
        Msr = unchecked((System.Int16)(142))
    }
}
