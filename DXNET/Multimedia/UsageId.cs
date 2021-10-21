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
    /// HID_USAGE_ID
    /// </summary>
    public enum UsageId : short
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_POINTER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_POINTER</unmanaged-short>
        GenericPointer = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_MOUSE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_MOUSE</unmanaged-short>
        GenericMouse = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_JOYSTICK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_JOYSTICK</unmanaged-short>
        GenericJoystick = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_GAMEPAD</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_GAMEPAD</unmanaged-short>
        GenericGamepad = unchecked((System.Int16)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_KEYBOARD</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_KEYBOARD</unmanaged-short>
        GenericKeyboard = unchecked((System.Int16)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_KEYPAD</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_KEYPAD</unmanaged-short>
        GenericKeypad = unchecked((System.Int16)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_MULTI_AXIS_CONTROLLER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_MULTI_AXIS_CONTROLLER</unmanaged-short>
        GenericMultiAxisController = unchecked((System.Int16)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_TABLET_PC_SYSTEM_CTL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_TABLET_PC_SYSTEM_CTL</unmanaged-short>
        GenericTabletPcSystemCtl = unchecked((System.Int16)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_PORTABLE_DEVICE_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_PORTABLE_DEVICE_CONTROL</unmanaged-short>
        GenericPortableDeviceControl = unchecked((System.Int16)(13)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_INTERACTIVE_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_INTERACTIVE_CONTROL</unmanaged-short>
        GenericInteractiveControl = unchecked((System.Int16)(14)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_COUNTED_BUFFER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_COUNTED_BUFFER</unmanaged-short>
        GenericCountedBuffer = unchecked((System.Int16)(58)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSTEM_CTL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSTEM_CTL</unmanaged-short>
        GenericSystemCtl = unchecked((System.Int16)(128)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_X</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_X</unmanaged-short>
        GenericX = unchecked((System.Int16)(48)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_Y</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_Y</unmanaged-short>
        GenericY = unchecked((System.Int16)(49)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_Z</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_Z</unmanaged-short>
        GenericZ = unchecked((System.Int16)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_RX</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_RX</unmanaged-short>
        GenericRx = unchecked((System.Int16)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_RY</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_RY</unmanaged-short>
        GenericRy = unchecked((System.Int16)(52)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_RZ</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_RZ</unmanaged-short>
        GenericRz = unchecked((System.Int16)(53)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SLIDER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SLIDER</unmanaged-short>
        GenericSlider = unchecked((System.Int16)(54)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DIAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DIAL</unmanaged-short>
        GenericDial = unchecked((System.Int16)(55)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_WHEEL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_WHEEL</unmanaged-short>
        GenericWheel = unchecked((System.Int16)(56)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_HATSWITCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_HATSWITCH</unmanaged-short>
        GenericHatswitch = unchecked((System.Int16)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_BYTE_COUNT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_BYTE_COUNT</unmanaged-short>
        GenericByteCount = unchecked((System.Int16)(59)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_MOTION_WAKEUP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_MOTION_WAKEUP</unmanaged-short>
        GenericMotionWakeup = unchecked((System.Int16)(60)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_START</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_START</unmanaged-short>
        GenericStart = unchecked((System.Int16)(61)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SELECT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SELECT</unmanaged-short>
        GenericSelect = unchecked((System.Int16)(62)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_VX</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_VX</unmanaged-short>
        GenericVx = unchecked((System.Int16)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_VY</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_VY</unmanaged-short>
        GenericVy = unchecked((System.Int16)(65)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_VZ</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_VZ</unmanaged-short>
        GenericVz = unchecked((System.Int16)(66)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_VBRX</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_VBRX</unmanaged-short>
        GenericVbrx = unchecked((System.Int16)(67)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_VBRY</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_VBRY</unmanaged-short>
        GenericVbry = unchecked((System.Int16)(68)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_VBRZ</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_VBRZ</unmanaged-short>
        GenericVbrz = unchecked((System.Int16)(69)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_VNO</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_VNO</unmanaged-short>
        GenericVno = unchecked((System.Int16)(70)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_FEATURE_NOTIFICATION</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_FEATURE_NOTIFICATION</unmanaged-short>
        GenericFeatureNotification = unchecked((System.Int16)(71)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_RESOLUTION_MULTIPLIER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_RESOLUTION_MULTIPLIER</unmanaged-short>
        GenericResolutionMultiplier = unchecked((System.Int16)(72)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_POWER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_POWER</unmanaged-short>
        GenericSysctlPower = unchecked((System.Int16)(129)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_SLEEP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_SLEEP</unmanaged-short>
        GenericSysctlSleep = unchecked((System.Int16)(130)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_WAKE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_WAKE</unmanaged-short>
        GenericSysctlWake = unchecked((System.Int16)(131)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_CONTEXT_MENU</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_CONTEXT_MENU</unmanaged-short>
        GenericSysctlContextMenu = unchecked((System.Int16)(132)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_MAIN_MENU</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_MAIN_MENU</unmanaged-short>
        GenericSysctlMainMenu = unchecked((System.Int16)(133)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_APP_MENU</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_APP_MENU</unmanaged-short>
        GenericSysctlAppMenu = unchecked((System.Int16)(134)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_HELP_MENU</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_HELP_MENU</unmanaged-short>
        GenericSysctlHelpMenu = unchecked((System.Int16)(135)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_MENU_EXIT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_MENU_EXIT</unmanaged-short>
        GenericSysctlMenuExit = unchecked((System.Int16)(136)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_MENU_SELECT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_MENU_SELECT</unmanaged-short>
        GenericSysctlMenuSelect = unchecked((System.Int16)(137)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_MENU_RIGHT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_MENU_RIGHT</unmanaged-short>
        GenericSysctlMenuRight = unchecked((System.Int16)(138)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_MENU_LEFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_MENU_LEFT</unmanaged-short>
        GenericSysctlMenuLeft = unchecked((System.Int16)(139)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_MENU_UP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_MENU_UP</unmanaged-short>
        GenericSysctlMenuUp = unchecked((System.Int16)(140)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_MENU_DOWN</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_MENU_DOWN</unmanaged-short>
        GenericSysctlMenuDown = unchecked((System.Int16)(141)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_COLD_RESTART</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_COLD_RESTART</unmanaged-short>
        GenericSysctlColdRestart = unchecked((System.Int16)(142)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_WARM_RESTART</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_WARM_RESTART</unmanaged-short>
        GenericSysctlWarmRestart = unchecked((System.Int16)(143)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DPAD_UP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DPAD_UP</unmanaged-short>
        GenericDpadUp = unchecked((System.Int16)(144)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DPAD_DOWN</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DPAD_DOWN</unmanaged-short>
        GenericDpadDown = unchecked((System.Int16)(145)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DPAD_RIGHT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DPAD_RIGHT</unmanaged-short>
        GenericDpadRight = unchecked((System.Int16)(146)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DPAD_LEFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DPAD_LEFT</unmanaged-short>
        GenericDpadLeft = unchecked((System.Int16)(147)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISMISS_NOTIFICATION</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISMISS_NOTIFICATION</unmanaged-short>
        GenericSysctlDismissNotification = unchecked((System.Int16)(154)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DOCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DOCK</unmanaged-short>
        GenericSysctlDock = unchecked((System.Int16)(160)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_UNDOCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_UNDOCK</unmanaged-short>
        GenericSysctlUndock = unchecked((System.Int16)(161)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_SETUP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_SETUP</unmanaged-short>
        GenericSysctlSetup = unchecked((System.Int16)(162)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_SYS_BREAK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_SYS_BREAK</unmanaged-short>
        GenericSysctlSysBreak = unchecked((System.Int16)(163)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_SYS_DBG_BREAK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_SYS_DBG_BREAK</unmanaged-short>
        GenericSysctlSysDbgBreak = unchecked((System.Int16)(164)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_APP_BREAK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_APP_BREAK</unmanaged-short>
        GenericSysctlAppBreak = unchecked((System.Int16)(165)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_APP_DBG_BREAK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_APP_DBG_BREAK</unmanaged-short>
        GenericSysctlAppDbgBreak = unchecked((System.Int16)(166)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_MUTE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_MUTE</unmanaged-short>
        GenericSysctlMute = unchecked((System.Int16)(167)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_HIBERNATE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_HIBERNATE</unmanaged-short>
        GenericSysctlHibernate = unchecked((System.Int16)(168)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISP_INVERT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISP_INVERT</unmanaged-short>
        GenericSysctlDispInvert = unchecked((System.Int16)(176)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISP_INTERNAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISP_INTERNAL</unmanaged-short>
        GenericSysctlDispInternal = unchecked((System.Int16)(177)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISP_EXTERNAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISP_EXTERNAL</unmanaged-short>
        GenericSysctlDispExternal = unchecked((System.Int16)(178)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISP_BOTH</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISP_BOTH</unmanaged-short>
        GenericSysctlDispBoth = unchecked((System.Int16)(179)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISP_DUAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISP_DUAL</unmanaged-short>
        GenericSysctlDispDual = unchecked((System.Int16)(180)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISP_TOGGLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISP_TOGGLE</unmanaged-short>
        GenericSysctlDispToggle = unchecked((System.Int16)(181)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISP_SWAP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISP_SWAP</unmanaged-short>
        GenericSysctlDispSwap = unchecked((System.Int16)(182)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSCTL_DISP_AUTOSCALE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSCTL_DISP_AUTOSCALE</unmanaged-short>
        GenericSysctlDispAutoscale = unchecked((System.Int16)(183)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_BUTTON</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_BUTTON</unmanaged-short>
        GenericSystemDisplayRotationLockButton = unchecked((System.Int16)(201)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_SLIDER_SWITCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_SYSTEM_DISPLAY_ROTATION_LOCK_SLIDER_SWITCH</unmanaged-short>
        GenericSystemDisplayRotationLockSliderSwitch = unchecked((System.Int16)(202)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_CONTROL_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_CONTROL_ENABLE</unmanaged-short>
        GenericControlEnable = unchecked((System.Int16)(203)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_FLIGHT_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_FLIGHT_SIMULATION_DEVICE</unmanaged-short>
        SimulationFlightSimulationDevice = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_AUTOMOBILE_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_AUTOMOBILE_SIMULATION_DEVICE</unmanaged-short>
        SimulationAutomobileSimulationDevice = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_TANK_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_TANK_SIMULATION_DEVICE</unmanaged-short>
        SimulationTankSimulationDevice = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_SPACESHIP_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_SPACESHIP_SIMULATION_DEVICE</unmanaged-short>
        SimulationSpaceshipSimulationDevice = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_SUBMARINE_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_SUBMARINE_SIMULATION_DEVICE</unmanaged-short>
        SimulationSubmarineSimulationDevice = unchecked((System.Int16)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_SAILING_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_SAILING_SIMULATION_DEVICE</unmanaged-short>
        SimulationSailingSimulationDevice = unchecked((System.Int16)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_MOTORCYCLE_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_MOTORCYCLE_SIMULATION_DEVICE</unmanaged-short>
        SimulationMotorcycleSimulationDevice = unchecked((System.Int16)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_SPORTS_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_SPORTS_SIMULATION_DEVICE</unmanaged-short>
        SimulationSportsSimulationDevice = unchecked((System.Int16)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_AIRPLANE_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_AIRPLANE_SIMULATION_DEVICE</unmanaged-short>
        SimulationAirplaneSimulationDevice = unchecked((System.Int16)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_HELICOPTER_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_HELICOPTER_SIMULATION_DEVICE</unmanaged-short>
        SimulationHelicopterSimulationDevice = unchecked((System.Int16)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_MAGIC_CARPET_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_MAGIC_CARPET_SIMULATION_DEVICE</unmanaged-short>
        SimulationMagicCarpetSimulationDevice = unchecked((System.Int16)(11)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_BICYCLE_SIMULATION_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_BICYCLE_SIMULATION_DEVICE</unmanaged-short>
        SimulationBicycleSimulationDevice = unchecked((System.Int16)(12)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_FLIGHT_CONTROL_STICK</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_FLIGHT_CONTROL_STICK</unmanaged-short>
        SimulationFlightControlStick = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_FLIGHT_STICK</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_FLIGHT_STICK</unmanaged-short>
        SimulationFlightStick = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_CYCLIC_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_CYCLIC_CONTROL</unmanaged-short>
        SimulationCyclicControl = unchecked((System.Int16)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_CYCLIC_TRIM</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_CYCLIC_TRIM</unmanaged-short>
        SimulationCyclicTrim = unchecked((System.Int16)(35)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_FLIGHT_YOKE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_FLIGHT_YOKE</unmanaged-short>
        SimulationFlightYoke = unchecked((System.Int16)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_TRACK_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_TRACK_CONTROL</unmanaged-short>
        SimulationTrackControl = unchecked((System.Int16)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_AILERON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_AILERON</unmanaged-short>
        SimulationAileron = unchecked((System.Int16)(176)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_AILERON_TRIM</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_AILERON_TRIM</unmanaged-short>
        SimulationAileronTrim = unchecked((System.Int16)(177)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_ANTI_TORQUE_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_ANTI_TORQUE_CONTROL</unmanaged-short>
        SimulationAntiTorqueControl = unchecked((System.Int16)(178)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_AUTOPIOLOT_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_AUTOPIOLOT_ENABLE</unmanaged-short>
        SimulationAutopiolotEnable = unchecked((System.Int16)(179)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_CHAFF_RELEASE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_CHAFF_RELEASE</unmanaged-short>
        SimulationChaffRelease = unchecked((System.Int16)(180)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_COLLECTIVE_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_COLLECTIVE_CONTROL</unmanaged-short>
        SimulationCollectiveControl = unchecked((System.Int16)(181)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_DIVE_BRAKE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_DIVE_BRAKE</unmanaged-short>
        SimulationDiveBrake = unchecked((System.Int16)(182)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_ELECTRONIC_COUNTERMEASURES</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_ELECTRONIC_COUNTERMEASURES</unmanaged-short>
        SimulationElectronicCountermeasures = unchecked((System.Int16)(183)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_ELEVATOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_ELEVATOR</unmanaged-short>
        SimulationElevator = unchecked((System.Int16)(184)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_ELEVATOR_TRIM</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_ELEVATOR_TRIM</unmanaged-short>
        SimulationElevatorTrim = unchecked((System.Int16)(185)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_RUDDER</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_RUDDER</unmanaged-short>
        SimulationRudder = unchecked((System.Int16)(186)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_THROTTLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_THROTTLE</unmanaged-short>
        SimulationThrottle = unchecked((System.Int16)(187)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_FLIGHT_COMMUNICATIONS</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_FLIGHT_COMMUNICATIONS</unmanaged-short>
        SimulationFlightCommunications = unchecked((System.Int16)(188)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_FLARE_RELEASE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_FLARE_RELEASE</unmanaged-short>
        SimulationFlareRelease = unchecked((System.Int16)(189)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_LANDING_GEAR</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_LANDING_GEAR</unmanaged-short>
        SimulationLandingGear = unchecked((System.Int16)(190)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_TOE_BRAKE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_TOE_BRAKE</unmanaged-short>
        SimulationToeBrake = unchecked((System.Int16)(191)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_TRIGGER</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_TRIGGER</unmanaged-short>
        SimulationTrigger = unchecked((System.Int16)(192)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_WEAPONS_ARM</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_WEAPONS_ARM</unmanaged-short>
        SimulationWeaponsArm = unchecked((System.Int16)(193)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_WEAPONS_SELECT</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_WEAPONS_SELECT</unmanaged-short>
        SimulationWeaponsSelect = unchecked((System.Int16)(194)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_WING_FLAPS</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_WING_FLAPS</unmanaged-short>
        SimulationWingFlaps = unchecked((System.Int16)(195)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_ACCELLERATOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_ACCELLERATOR</unmanaged-short>
        SimulationAccellerator = unchecked((System.Int16)(196)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_BRAKE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_BRAKE</unmanaged-short>
        SimulationBrake = unchecked((System.Int16)(197)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_CLUTCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_CLUTCH</unmanaged-short>
        SimulationClutch = unchecked((System.Int16)(198)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_SHIFTER</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_SHIFTER</unmanaged-short>
        SimulationShifter = unchecked((System.Int16)(199)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_STEERING</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_STEERING</unmanaged-short>
        SimulationSteering = unchecked((System.Int16)(200)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_TURRET_DIRECTION</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_TURRET_DIRECTION</unmanaged-short>
        SimulationTurretDirection = unchecked((System.Int16)(201)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_BARREL_ELEVATION</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_BARREL_ELEVATION</unmanaged-short>
        SimulationBarrelElevation = unchecked((System.Int16)(202)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_DIVE_PLANE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_DIVE_PLANE</unmanaged-short>
        SimulationDivePlane = unchecked((System.Int16)(203)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_BALLAST</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_BALLAST</unmanaged-short>
        SimulationBallast = unchecked((System.Int16)(204)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_BICYCLE_CRANK</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_BICYCLE_CRANK</unmanaged-short>
        SimulationBicycleCrank = unchecked((System.Int16)(205)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_HANDLE_BARS</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_HANDLE_BARS</unmanaged-short>
        SimulationHandleBars = unchecked((System.Int16)(206)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_FRONT_BRAKE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_FRONT_BRAKE</unmanaged-short>
        SimulationFrontBrake = unchecked((System.Int16)(207)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SIMULATION_REAR_BRAKE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SIMULATION_REAR_BRAKE</unmanaged-short>
        SimulationRearBrake = unchecked((System.Int16)(208)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_BELT</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_BELT</unmanaged-short>
        VrBelt = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_BODY_SUIT</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_BODY_SUIT</unmanaged-short>
        VrBodySuit = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_FLEXOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_FLEXOR</unmanaged-short>
        VrFlexor = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_GLOVE</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_GLOVE</unmanaged-short>
        VrGlove = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_HEAD_TRACKER</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_HEAD_TRACKER</unmanaged-short>
        VrHeadTracker = unchecked((System.Int16)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_HEAD_MOUNTED_DISPLAY</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_HEAD_MOUNTED_DISPLAY</unmanaged-short>
        VrHeadMountedDisplay = unchecked((System.Int16)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_HAND_TRACKER</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_HAND_TRACKER</unmanaged-short>
        VrHandTracker = unchecked((System.Int16)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_OCULOMETER</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_OCULOMETER</unmanaged-short>
        VrOculometer = unchecked((System.Int16)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_VEST</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_VEST</unmanaged-short>
        VrVest = unchecked((System.Int16)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_ANIMATRONIC_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_ANIMATRONIC_DEVICE</unmanaged-short>
        VrAnimatronicDevice = unchecked((System.Int16)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_STEREO_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_STEREO_ENABLE</unmanaged-short>
        VrStereoEnable = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_VR_DISPLAY_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_VR_DISPLAY_ENABLE</unmanaged-short>
        VrDisplayEnable = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_BASEBALL_BAT</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_BASEBALL_BAT</unmanaged-short>
        SportBaseballBat = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_GOLF_CLUB</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_GOLF_CLUB</unmanaged-short>
        SportGolfClub = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_ROWING_MACHINE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_ROWING_MACHINE</unmanaged-short>
        SportRowingMachine = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_TREADMILL</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_TREADMILL</unmanaged-short>
        SportTreadmill = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_STICK_TYPE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_STICK_TYPE</unmanaged-short>
        SportStickType = unchecked((System.Int16)(56)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_OAR</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_OAR</unmanaged-short>
        SportOar = unchecked((System.Int16)(48)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_SLOPE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_SLOPE</unmanaged-short>
        SportSlope = unchecked((System.Int16)(49)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_RATE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_RATE</unmanaged-short>
        SportRate = unchecked((System.Int16)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_STICK_SPEED</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_STICK_SPEED</unmanaged-short>
        SportStickSpeed = unchecked((System.Int16)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_STICK_FACE_ANGLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_STICK_FACE_ANGLE</unmanaged-short>
        SportStickFaceAngle = unchecked((System.Int16)(52)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_HEEL_TOE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_HEEL_TOE</unmanaged-short>
        SportHeelToe = unchecked((System.Int16)(53)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_FOLLOW_THROUGH</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_FOLLOW_THROUGH</unmanaged-short>
        SportFollowThrough = unchecked((System.Int16)(54)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_TEMPO</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_TEMPO</unmanaged-short>
        SportTempo = unchecked((System.Int16)(55)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_HEIGHT</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_HEIGHT</unmanaged-short>
        SportHeight = unchecked((System.Int16)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_PUTTER</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_PUTTER</unmanaged-short>
        SportPutter = unchecked((System.Int16)(80)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_1_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_1_IRON</unmanaged-short>
        Sport1Iron = unchecked((System.Int16)(81)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_2_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_2_IRON</unmanaged-short>
        Sport2Iron = unchecked((System.Int16)(82)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_3_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_3_IRON</unmanaged-short>
        Sport3Iron = unchecked((System.Int16)(83)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_4_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_4_IRON</unmanaged-short>
        Sport4Iron = unchecked((System.Int16)(84)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_5_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_5_IRON</unmanaged-short>
        Sport5Iron = unchecked((System.Int16)(85)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_6_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_6_IRON</unmanaged-short>
        Sport6Iron = unchecked((System.Int16)(86)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_7_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_7_IRON</unmanaged-short>
        Sport7Iron = unchecked((System.Int16)(87)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_8_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_8_IRON</unmanaged-short>
        Sport8Iron = unchecked((System.Int16)(88)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_9_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_9_IRON</unmanaged-short>
        Sport9Iron = unchecked((System.Int16)(89)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_10_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_10_IRON</unmanaged-short>
        Sport10Iron = unchecked((System.Int16)(90)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_11_IRON</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_11_IRON</unmanaged-short>
        Sport11Iron = unchecked((System.Int16)(91)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_SAND_WEDGE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_SAND_WEDGE</unmanaged-short>
        SportSandWedge = unchecked((System.Int16)(92)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_LOFT_WEDGE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_LOFT_WEDGE</unmanaged-short>
        SportLoftWedge = unchecked((System.Int16)(93)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_POWER_WEDGE</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_POWER_WEDGE</unmanaged-short>
        SportPowerWedge = unchecked((System.Int16)(94)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_1_WOOD</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_1_WOOD</unmanaged-short>
        Sport1Wood = unchecked((System.Int16)(95)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_3_WOOD</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_3_WOOD</unmanaged-short>
        Sport3Wood = unchecked((System.Int16)(96)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_5_WOOD</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_5_WOOD</unmanaged-short>
        Sport5Wood = unchecked((System.Int16)(97)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_7_WOOD</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_7_WOOD</unmanaged-short>
        Sport7Wood = unchecked((System.Int16)(98)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_SPORT_9_WOOD</unmanaged>
        /// <unmanaged-short>HID_USAGE_SPORT_9_WOOD</unmanaged-short>
        Sport9Wood = unchecked((System.Int16)(99)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_3D_GAME_CONTROLLER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_3D_GAME_CONTROLLER</unmanaged-short>
        Game3dGameController = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_PINBALL_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_PINBALL_DEVICE</unmanaged-short>
        GamePinballDevice = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GUN_DEVICE</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GUN_DEVICE</unmanaged-short>
        GameGunDevice = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_POINT_OF_VIEW</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_POINT_OF_VIEW</unmanaged-short>
        GamePointOfView = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GUN_SELECTOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GUN_SELECTOR</unmanaged-short>
        GameGunSelector = unchecked((System.Int16)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GAMEPAD_FIRE_JUMP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GAMEPAD_FIRE_JUMP</unmanaged-short>
        GameGamepadFireJump = unchecked((System.Int16)(55)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GAMEPAD_TRIGGER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GAMEPAD_TRIGGER</unmanaged-short>
        GameGamepadTrigger = unchecked((System.Int16)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_TURN_RIGHT_LEFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_TURN_RIGHT_LEFT</unmanaged-short>
        GameTurnRightLeft = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_PITCH_FORWARD_BACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_PITCH_FORWARD_BACK</unmanaged-short>
        GamePitchForwardBack = unchecked((System.Int16)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_ROLL_RIGHT_LEFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_ROLL_RIGHT_LEFT</unmanaged-short>
        GameRollRightLeft = unchecked((System.Int16)(35)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_MOVE_RIGHT_LEFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_MOVE_RIGHT_LEFT</unmanaged-short>
        GameMoveRightLeft = unchecked((System.Int16)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_MOVE_FORWARD_BACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_MOVE_FORWARD_BACK</unmanaged-short>
        GameMoveForwardBack = unchecked((System.Int16)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_MOVE_UP_DOWN</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_MOVE_UP_DOWN</unmanaged-short>
        GameMoveUpDown = unchecked((System.Int16)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_LEAN_RIGHT_LEFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_LEAN_RIGHT_LEFT</unmanaged-short>
        GameLeanRightLeft = unchecked((System.Int16)(39)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_LEAN_FORWARD_BACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_LEAN_FORWARD_BACK</unmanaged-short>
        GameLeanForwardBack = unchecked((System.Int16)(40)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_POV_HEIGHT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_POV_HEIGHT</unmanaged-short>
        GamePovHeight = unchecked((System.Int16)(41)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_FLIPPER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_FLIPPER</unmanaged-short>
        GameFlipper = unchecked((System.Int16)(42)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_SECONDARY_FLIPPER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_SECONDARY_FLIPPER</unmanaged-short>
        GameSecondaryFlipper = unchecked((System.Int16)(43)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_BUMP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_BUMP</unmanaged-short>
        GameBump = unchecked((System.Int16)(44)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_NEW_GAME</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_NEW_GAME</unmanaged-short>
        GameNewGame = unchecked((System.Int16)(45)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_SHOOT_BALL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_SHOOT_BALL</unmanaged-short>
        GameShootBall = unchecked((System.Int16)(46)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_PLAYER</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_PLAYER</unmanaged-short>
        GamePlayer = unchecked((System.Int16)(47)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GUN_BOLT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GUN_BOLT</unmanaged-short>
        GameGunBolt = unchecked((System.Int16)(48)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GUN_CLIP</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GUN_CLIP</unmanaged-short>
        GameGunClip = unchecked((System.Int16)(49)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GUN_SINGLE_SHOT</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GUN_SINGLE_SHOT</unmanaged-short>
        GameGunSingleShot = unchecked((System.Int16)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GUN_BURST</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GUN_BURST</unmanaged-short>
        GameGunBurst = unchecked((System.Int16)(52)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GUN_AUTOMATIC</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GUN_AUTOMATIC</unmanaged-short>
        GameGunAutomatic = unchecked((System.Int16)(53)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GAME_GUN_SAFETY</unmanaged>
        /// <unmanaged-short>HID_USAGE_GAME_GUN_SAFETY</unmanaged-short>
        GameGunSafety = unchecked((System.Int16)(54)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DEVICE_BATTERY_STRENGTH</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DEVICE_BATTERY_STRENGTH</unmanaged-short>
        GenericDeviceBatteryStrength = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DEVICE_WIRELESS_CHANNEL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DEVICE_WIRELESS_CHANNEL</unmanaged-short>
        GenericDeviceWirelessChannel = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DEVICE_WIRELESS_ID</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DEVICE_WIRELESS_ID</unmanaged-short>
        GenericDeviceWirelessId = unchecked((System.Int16)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DEVICE_DISCOVER_WIRELESS_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DEVICE_DISCOVER_WIRELESS_CONTROL</unmanaged-short>
        GenericDeviceDiscoverWirelessControl = unchecked((System.Int16)(35)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ENTERED</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ENTERED</unmanaged-short>
        GenericDeviceSecurityCodeCharEntered = unchecked((System.Int16)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ERASED</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CHAR_ERASED</unmanaged-short>
        GenericDeviceSecurityCodeCharErased = unchecked((System.Int16)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CLEARED</unmanaged>
        /// <unmanaged-short>HID_USAGE_GENERIC_DEVICE_SECURITY_CODE_CLEARED</unmanaged-short>
        GenericDeviceSecurityCodeCleared = unchecked((System.Int16)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_NOEVENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_NOEVENT</unmanaged-short>
        KeyboardNoevent = unchecked((System.Int16)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_ROLLOVER</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_ROLLOVER</unmanaged-short>
        KeyboardRollover = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_POSTFAIL</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_POSTFAIL</unmanaged-short>
        KeyboardPostfail = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_UNDEFINED</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_UNDEFINED</unmanaged-short>
        KeyboardUndefined = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_aA</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_aA</unmanaged-short>
        KeyboardAA = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_zZ</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_zZ</unmanaged-short>
        KeyboardZZ = unchecked((System.Int16)(29)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_ONE</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_ONE</unmanaged-short>
        KeyboardOne = unchecked((System.Int16)(30)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_ZERO</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_ZERO</unmanaged-short>
        KeyboardZero = unchecked((System.Int16)(39)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_LCTRL</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_LCTRL</unmanaged-short>
        KeyboardLctrl = unchecked((System.Int16)(224)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_LSHFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_LSHFT</unmanaged-short>
        KeyboardLshft = unchecked((System.Int16)(225)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_LALT</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_LALT</unmanaged-short>
        KeyboardLalt = unchecked((System.Int16)(226)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_LGUI</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_LGUI</unmanaged-short>
        KeyboardLgui = unchecked((System.Int16)(227)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_RCTRL</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_RCTRL</unmanaged-short>
        KeyboardRctrl = unchecked((System.Int16)(228)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_RSHFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_RSHFT</unmanaged-short>
        KeyboardRshft = unchecked((System.Int16)(229)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_RALT</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_RALT</unmanaged-short>
        KeyboardRalt = unchecked((System.Int16)(230)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_RGUI</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_RGUI</unmanaged-short>
        KeyboardRgui = unchecked((System.Int16)(231)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_SCROLL_LOCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_SCROLL_LOCK</unmanaged-short>
        KeyboardScrollLock = unchecked((System.Int16)(71)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_NUM_LOCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_NUM_LOCK</unmanaged-short>
        KeyboardNumLock = unchecked((System.Int16)(83)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_CAPS_LOCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_CAPS_LOCK</unmanaged-short>
        KeyboardCapsLock = unchecked((System.Int16)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F1</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F1</unmanaged-short>
        KeyboardF1 = unchecked((System.Int16)(58)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F2</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F2</unmanaged-short>
        KeyboardF2 = unchecked((System.Int16)(59)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F3</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F3</unmanaged-short>
        KeyboardF3 = unchecked((System.Int16)(60)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F4</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F4</unmanaged-short>
        KeyboardF4 = unchecked((System.Int16)(61)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F5</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F5</unmanaged-short>
        KeyboardF5 = unchecked((System.Int16)(62)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F6</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F6</unmanaged-short>
        KeyboardF6 = unchecked((System.Int16)(63)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F7</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F7</unmanaged-short>
        KeyboardF7 = unchecked((System.Int16)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F8</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F8</unmanaged-short>
        KeyboardF8 = unchecked((System.Int16)(65)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F9</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F9</unmanaged-short>
        KeyboardF9 = unchecked((System.Int16)(66)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F10</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F10</unmanaged-short>
        KeyboardF10 = unchecked((System.Int16)(67)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F11</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F11</unmanaged-short>
        KeyboardF11 = unchecked((System.Int16)(68)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F12</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F12</unmanaged-short>
        KeyboardF12 = unchecked((System.Int16)(69)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F13</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F13</unmanaged-short>
        KeyboardF13 = unchecked((System.Int16)(104)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F14</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F14</unmanaged-short>
        KeyboardF14 = unchecked((System.Int16)(105)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F15</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F15</unmanaged-short>
        KeyboardF15 = unchecked((System.Int16)(106)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F16</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F16</unmanaged-short>
        KeyboardF16 = unchecked((System.Int16)(107)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F17</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F17</unmanaged-short>
        KeyboardF17 = unchecked((System.Int16)(108)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F18</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F18</unmanaged-short>
        KeyboardF18 = unchecked((System.Int16)(109)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F19</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F19</unmanaged-short>
        KeyboardF19 = unchecked((System.Int16)(110)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F20</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F20</unmanaged-short>
        KeyboardF20 = unchecked((System.Int16)(111)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F21</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F21</unmanaged-short>
        KeyboardF21 = unchecked((System.Int16)(112)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F22</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F22</unmanaged-short>
        KeyboardF22 = unchecked((System.Int16)(113)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F23</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F23</unmanaged-short>
        KeyboardF23 = unchecked((System.Int16)(114)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_F24</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_F24</unmanaged-short>
        KeyboardF24 = unchecked((System.Int16)(115)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_RETURN</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_RETURN</unmanaged-short>
        KeyboardReturn = unchecked((System.Int16)(40)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_ESCAPE</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_ESCAPE</unmanaged-short>
        KeyboardEscape = unchecked((System.Int16)(41)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_DELETE</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_DELETE</unmanaged-short>
        KeyboardDelete = unchecked((System.Int16)(42)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_PRINT_SCREEN</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_PRINT_SCREEN</unmanaged-short>
        KeyboardPrintScreen = unchecked((System.Int16)(70)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_KEYBOARD_DELETE_FORWARD</unmanaged>
        /// <unmanaged-short>HID_USAGE_KEYBOARD_DELETE_FORWARD</unmanaged-short>
        KeyboardDeleteForward = unchecked((System.Int16)(76)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_NUM_LOCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_NUM_LOCK</unmanaged-short>
        LedNumLock = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_CAPS_LOCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_CAPS_LOCK</unmanaged-short>
        LedCapsLock = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SCROLL_LOCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SCROLL_LOCK</unmanaged-short>
        LedScrollLock = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_COMPOSE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_COMPOSE</unmanaged-short>
        LedCompose = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_KANA</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_KANA</unmanaged-short>
        LedKana = unchecked((System.Int16)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_POWER</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_POWER</unmanaged-short>
        LedPower = unchecked((System.Int16)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SHIFT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SHIFT</unmanaged-short>
        LedShift = unchecked((System.Int16)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_DO_NOT_DISTURB</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_DO_NOT_DISTURB</unmanaged-short>
        LedDoNotDisturb = unchecked((System.Int16)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_MUTE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_MUTE</unmanaged-short>
        LedMute = unchecked((System.Int16)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_TONE_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_TONE_ENABLE</unmanaged-short>
        LedToneEnable = unchecked((System.Int16)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_HIGH_CUT_FILTER</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_HIGH_CUT_FILTER</unmanaged-short>
        LedHighCutFilter = unchecked((System.Int16)(11)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_LOW_CUT_FILTER</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_LOW_CUT_FILTER</unmanaged-short>
        LedLowCutFilter = unchecked((System.Int16)(12)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_EQUALIZER_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_EQUALIZER_ENABLE</unmanaged-short>
        LedEqualizerEnable = unchecked((System.Int16)(13)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SOUND_FIELD_ON</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SOUND_FIELD_ON</unmanaged-short>
        LedSoundFieldOn = unchecked((System.Int16)(14)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SURROUND_FIELD_ON</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SURROUND_FIELD_ON</unmanaged-short>
        LedSurroundFieldOn = unchecked((System.Int16)(15)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_REPEAT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_REPEAT</unmanaged-short>
        LedRepeat = unchecked((System.Int16)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_STEREO</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_STEREO</unmanaged-short>
        LedStereo = unchecked((System.Int16)(17)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SAMPLING_RATE_DETECT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SAMPLING_RATE_DETECT</unmanaged-short>
        LedSamplingRateDetect = unchecked((System.Int16)(18)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SPINNING</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SPINNING</unmanaged-short>
        LedSpinning = unchecked((System.Int16)(19)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_CAV</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_CAV</unmanaged-short>
        LedCav = unchecked((System.Int16)(20)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_CLV</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_CLV</unmanaged-short>
        LedClv = unchecked((System.Int16)(21)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_RECORDING_FORMAT_DET</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_RECORDING_FORMAT_DET</unmanaged-short>
        LedRecordingFormatDet = unchecked((System.Int16)(22)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_OFF_HOOK</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_OFF_HOOK</unmanaged-short>
        LedOffHook = unchecked((System.Int16)(23)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_RING</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_RING</unmanaged-short>
        LedRing = unchecked((System.Int16)(24)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_MESSAGE_WAITING</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_MESSAGE_WAITING</unmanaged-short>
        LedMessageWaiting = unchecked((System.Int16)(25)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_DATA_MODE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_DATA_MODE</unmanaged-short>
        LedDataMode = unchecked((System.Int16)(26)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_BATTERY_OPERATION</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_BATTERY_OPERATION</unmanaged-short>
        LedBatteryOperation = unchecked((System.Int16)(27)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_BATTERY_OK</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_BATTERY_OK</unmanaged-short>
        LedBatteryOk = unchecked((System.Int16)(28)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_BATTERY_LOW</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_BATTERY_LOW</unmanaged-short>
        LedBatteryLow = unchecked((System.Int16)(29)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SPEAKER</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SPEAKER</unmanaged-short>
        LedSpeaker = unchecked((System.Int16)(30)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_HEAD_SET</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_HEAD_SET</unmanaged-short>
        LedHeadSet = unchecked((System.Int16)(31)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_HOLD</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_HOLD</unmanaged-short>
        LedHold = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_MICROPHONE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_MICROPHONE</unmanaged-short>
        LedMicrophone = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_COVERAGE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_COVERAGE</unmanaged-short>
        LedCoverage = unchecked((System.Int16)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_NIGHT_MODE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_NIGHT_MODE</unmanaged-short>
        LedNightMode = unchecked((System.Int16)(35)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SEND_CALLS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SEND_CALLS</unmanaged-short>
        LedSendCalls = unchecked((System.Int16)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_CALL_PICKUP</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_CALL_PICKUP</unmanaged-short>
        LedCallPickup = unchecked((System.Int16)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_CONFERENCE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_CONFERENCE</unmanaged-short>
        LedConference = unchecked((System.Int16)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_STAND_BY</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_STAND_BY</unmanaged-short>
        LedStandBy = unchecked((System.Int16)(39)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_CAMERA_ON</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_CAMERA_ON</unmanaged-short>
        LedCameraOn = unchecked((System.Int16)(40)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_CAMERA_OFF</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_CAMERA_OFF</unmanaged-short>
        LedCameraOff = unchecked((System.Int16)(41)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_ON_LINE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_ON_LINE</unmanaged-short>
        LedOnLine = unchecked((System.Int16)(42)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_OFF_LINE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_OFF_LINE</unmanaged-short>
        LedOffLine = unchecked((System.Int16)(43)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_BUSY</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_BUSY</unmanaged-short>
        LedBusy = unchecked((System.Int16)(44)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_READY</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_READY</unmanaged-short>
        LedReady = unchecked((System.Int16)(45)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_PAPER_OUT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_PAPER_OUT</unmanaged-short>
        LedPaperOut = unchecked((System.Int16)(46)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_PAPER_JAM</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_PAPER_JAM</unmanaged-short>
        LedPaperJam = unchecked((System.Int16)(47)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_REMOTE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_REMOTE</unmanaged-short>
        LedRemote = unchecked((System.Int16)(48)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_FORWARD</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_FORWARD</unmanaged-short>
        LedForward = unchecked((System.Int16)(49)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_REVERSE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_REVERSE</unmanaged-short>
        LedReverse = unchecked((System.Int16)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_STOP</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_STOP</unmanaged-short>
        LedStop = unchecked((System.Int16)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_REWIND</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_REWIND</unmanaged-short>
        LedRewind = unchecked((System.Int16)(52)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_FAST_FORWARD</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_FAST_FORWARD</unmanaged-short>
        LedFastForward = unchecked((System.Int16)(53)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_PLAY</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_PLAY</unmanaged-short>
        LedPlay = unchecked((System.Int16)(54)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_PAUSE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_PAUSE</unmanaged-short>
        LedPause = unchecked((System.Int16)(55)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_RECORD</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_RECORD</unmanaged-short>
        LedRecord = unchecked((System.Int16)(56)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_ERROR</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_ERROR</unmanaged-short>
        LedError = unchecked((System.Int16)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SELECTED_INDICATOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SELECTED_INDICATOR</unmanaged-short>
        LedSelectedIndicator = unchecked((System.Int16)(58)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_IN_USE_INDICATOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_IN_USE_INDICATOR</unmanaged-short>
        LedInUseIndicator = unchecked((System.Int16)(59)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_MULTI_MODE_INDICATOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_MULTI_MODE_INDICATOR</unmanaged-short>
        LedMultiModeIndicator = unchecked((System.Int16)(60)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_INDICATOR_ON</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_INDICATOR_ON</unmanaged-short>
        LedIndicatorOn = unchecked((System.Int16)(61)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_INDICATOR_FLASH</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_INDICATOR_FLASH</unmanaged-short>
        LedIndicatorFlash = unchecked((System.Int16)(62)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_INDICATOR_SLOW_BLINK</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_INDICATOR_SLOW_BLINK</unmanaged-short>
        LedIndicatorSlowBlink = unchecked((System.Int16)(63)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_INDICATOR_FAST_BLINK</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_INDICATOR_FAST_BLINK</unmanaged-short>
        LedIndicatorFastBlink = unchecked((System.Int16)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_INDICATOR_OFF</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_INDICATOR_OFF</unmanaged-short>
        LedIndicatorOff = unchecked((System.Int16)(65)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_FLASH_ON_TIME</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_FLASH_ON_TIME</unmanaged-short>
        LedFlashOnTime = unchecked((System.Int16)(66)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SLOW_BLINK_ON_TIME</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SLOW_BLINK_ON_TIME</unmanaged-short>
        LedSlowBlinkOnTime = unchecked((System.Int16)(67)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SLOW_BLINK_OFF_TIME</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SLOW_BLINK_OFF_TIME</unmanaged-short>
        LedSlowBlinkOffTime = unchecked((System.Int16)(68)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_FAST_BLINK_ON_TIME</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_FAST_BLINK_ON_TIME</unmanaged-short>
        LedFastBlinkOnTime = unchecked((System.Int16)(69)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_FAST_BLINK_OFF_TIME</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_FAST_BLINK_OFF_TIME</unmanaged-short>
        LedFastBlinkOffTime = unchecked((System.Int16)(70)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_INDICATOR_COLOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_INDICATOR_COLOR</unmanaged-short>
        LedIndicatorColor = unchecked((System.Int16)(71)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_RED</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_RED</unmanaged-short>
        LedRed = unchecked((System.Int16)(72)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_GREEN</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_GREEN</unmanaged-short>
        LedGreen = unchecked((System.Int16)(73)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_AMBER</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_AMBER</unmanaged-short>
        LedAmber = unchecked((System.Int16)(74)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_GENERIC_INDICATOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_GENERIC_INDICATOR</unmanaged-short>
        LedGenericIndicator = unchecked((System.Int16)(75)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_SYSTEM_SUSPEND</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_SYSTEM_SUSPEND</unmanaged-short>
        LedSystemSuspend = unchecked((System.Int16)(76)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LED_EXTERNAL_POWER</unmanaged>
        /// <unmanaged-short>HID_USAGE_LED_EXTERNAL_POWER</unmanaged-short>
        LedExternalPower = unchecked((System.Int16)(77)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_PHONE</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_PHONE</unmanaged-short>
        TelephonyPhone = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_ANSWERING_MACHINE</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_ANSWERING_MACHINE</unmanaged-short>
        TelephonyAnsweringMachine = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_MESSAGE_CONTROLS</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_MESSAGE_CONTROLS</unmanaged-short>
        TelephonyMessageControls = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_HANDSET</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_HANDSET</unmanaged-short>
        TelephonyHandset = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_HEADSET</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_HEADSET</unmanaged-short>
        TelephonyHeadset = unchecked((System.Int16)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_KEYPAD</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_KEYPAD</unmanaged-short>
        TelephonyKeypad = unchecked((System.Int16)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_PROGRAMMABLE_BUTTON</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_PROGRAMMABLE_BUTTON</unmanaged-short>
        TelephonyProgrammableButton = unchecked((System.Int16)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_REDIAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_REDIAL</unmanaged-short>
        TelephonyRedial = unchecked((System.Int16)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_TRANSFER</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_TRANSFER</unmanaged-short>
        TelephonyTransfer = unchecked((System.Int16)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_DROP</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_DROP</unmanaged-short>
        TelephonyDrop = unchecked((System.Int16)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_LINE</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_LINE</unmanaged-short>
        TelephonyLine = unchecked((System.Int16)(42)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_RING_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_RING_ENABLE</unmanaged-short>
        TelephonyRingEnable = unchecked((System.Int16)(45)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_SEND</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_SEND</unmanaged-short>
        TelephonySend = unchecked((System.Int16)(49)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_KEYPAD_0</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_KEYPAD_0</unmanaged-short>
        TelephonyKeypad0 = unchecked((System.Int16)(176)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_KEYPAD_D</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_KEYPAD_D</unmanaged-short>
        TelephonyKeypadD = unchecked((System.Int16)(191)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_TELEPHONY_HOST_AVAILABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_TELEPHONY_HOST_AVAILABLE</unmanaged-short>
        TelephonyHostAvailable = unchecked((System.Int16)(241)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMERCTRL</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMERCTRL</unmanaged-short>
        Consumerctrl = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_CHANNEL_INCREMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_CHANNEL_INCREMENT</unmanaged-short>
        ConsumerChannelIncrement = unchecked((System.Int16)(156)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_CHANNEL_DECREMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_CHANNEL_DECREMENT</unmanaged-short>
        ConsumerChannelDecrement = unchecked((System.Int16)(157)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_PLAY</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_PLAY</unmanaged-short>
        ConsumerPlay = unchecked((System.Int16)(176)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_PAUSE</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_PAUSE</unmanaged-short>
        ConsumerPause = unchecked((System.Int16)(177)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_RECORD</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_RECORD</unmanaged-short>
        ConsumerRecord = unchecked((System.Int16)(178)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_FAST_FORWARD</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_FAST_FORWARD</unmanaged-short>
        ConsumerFastForward = unchecked((System.Int16)(179)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_REWIND</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_REWIND</unmanaged-short>
        ConsumerRewind = unchecked((System.Int16)(180)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_SCAN_NEXT_TRACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_SCAN_NEXT_TRACK</unmanaged-short>
        ConsumerScanNextTrack = unchecked((System.Int16)(181)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_SCAN_PREV_TRACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_SCAN_PREV_TRACK</unmanaged-short>
        ConsumerScanPrevTrack = unchecked((System.Int16)(182)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_STOP</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_STOP</unmanaged-short>
        ConsumerStop = unchecked((System.Int16)(183)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_PLAY_PAUSE</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_PLAY_PAUSE</unmanaged-short>
        ConsumerPlayPause = unchecked((System.Int16)(205)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_GAMEDVR_OPEN_GAMEBAR</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_GAMEDVR_OPEN_GAMEBAR</unmanaged-short>
        ConsumerGamedvrOpenGamebar = unchecked((System.Int16)(208)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_RECORD</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_RECORD</unmanaged-short>
        ConsumerGamedvrToggleRecord = unchecked((System.Int16)(209)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_GAMEDVR_RECORD_CLIP</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_GAMEDVR_RECORD_CLIP</unmanaged-short>
        ConsumerGamedvrRecordClip = unchecked((System.Int16)(210)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_GAMEDVR_SCREENSHOT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_GAMEDVR_SCREENSHOT</unmanaged-short>
        ConsumerGamedvrScreenshot = unchecked((System.Int16)(211)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_INDICATOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_INDICATOR</unmanaged-short>
        ConsumerGamedvrToggleIndicator = unchecked((System.Int16)(212)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_MICROPHONE</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_MICROPHONE</unmanaged-short>
        ConsumerGamedvrToggleMicrophone = unchecked((System.Int16)(213)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_CAMERA</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_CAMERA</unmanaged-short>
        ConsumerGamedvrToggleCamera = unchecked((System.Int16)(214)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_BROADCAST</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_GAMEDVR_TOGGLE_BROADCAST</unmanaged-short>
        ConsumerGamedvrToggleBroadcast = unchecked((System.Int16)(215)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_VOLUME</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_VOLUME</unmanaged-short>
        ConsumerVolume = unchecked((System.Int16)(224)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_BALANCE</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_BALANCE</unmanaged-short>
        ConsumerBalance = unchecked((System.Int16)(225)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_MUTE</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_MUTE</unmanaged-short>
        ConsumerMute = unchecked((System.Int16)(226)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_BASS</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_BASS</unmanaged-short>
        ConsumerBass = unchecked((System.Int16)(227)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_TREBLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_TREBLE</unmanaged-short>
        ConsumerTreble = unchecked((System.Int16)(228)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_BASS_BOOST</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_BASS_BOOST</unmanaged-short>
        ConsumerBassBoost = unchecked((System.Int16)(229)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_SURROUND_MODE</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_SURROUND_MODE</unmanaged-short>
        ConsumerSurroundMode = unchecked((System.Int16)(230)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_LOUDNESS</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_LOUDNESS</unmanaged-short>
        ConsumerLoudness = unchecked((System.Int16)(231)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_MPX</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_MPX</unmanaged-short>
        ConsumerMpx = unchecked((System.Int16)(232)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_VOLUME_INCREMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_VOLUME_INCREMENT</unmanaged-short>
        ConsumerVolumeIncrement = unchecked((System.Int16)(233)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_VOLUME_DECREMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_VOLUME_DECREMENT</unmanaged-short>
        ConsumerVolumeDecrement = unchecked((System.Int16)(234)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_BASS_INCREMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_BASS_INCREMENT</unmanaged-short>
        ConsumerBassIncrement = unchecked((System.Int16)(338)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_BASS_DECREMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_BASS_DECREMENT</unmanaged-short>
        ConsumerBassDecrement = unchecked((System.Int16)(339)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_TREBLE_INCREMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_TREBLE_INCREMENT</unmanaged-short>
        ConsumerTrebleIncrement = unchecked((System.Int16)(340)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_TREBLE_DECREMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_TREBLE_DECREMENT</unmanaged-short>
        ConsumerTrebleDecrement = unchecked((System.Int16)(341)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AL_CONFIGURATION</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AL_CONFIGURATION</unmanaged-short>
        ConsumerAlConfiguration = unchecked((System.Int16)(387)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AL_EMAIL</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AL_EMAIL</unmanaged-short>
        ConsumerAlEmail = unchecked((System.Int16)(394)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AL_CALCULATOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AL_CALCULATOR</unmanaged-short>
        ConsumerAlCalculator = unchecked((System.Int16)(402)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AL_BROWSER</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AL_BROWSER</unmanaged-short>
        ConsumerAlBrowser = unchecked((System.Int16)(404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AL_SEARCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AL_SEARCH</unmanaged-short>
        ConsumerAlSearch = unchecked((System.Int16)(454)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_SEARCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_SEARCH</unmanaged-short>
        ConsumerAcSearch = unchecked((System.Int16)(545)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_GOTO</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_GOTO</unmanaged-short>
        ConsumerAcGoto = unchecked((System.Int16)(546)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_HOME</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_HOME</unmanaged-short>
        ConsumerAcHome = unchecked((System.Int16)(547)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_BACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_BACK</unmanaged-short>
        ConsumerAcBack = unchecked((System.Int16)(548)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_FORWARD</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_FORWARD</unmanaged-short>
        ConsumerAcForward = unchecked((System.Int16)(549)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_STOP</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_STOP</unmanaged-short>
        ConsumerAcStop = unchecked((System.Int16)(550)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_REFRESH</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_REFRESH</unmanaged-short>
        ConsumerAcRefresh = unchecked((System.Int16)(551)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_PREVIOUS</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_PREVIOUS</unmanaged-short>
        ConsumerAcPrevious = unchecked((System.Int16)(552)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_NEXT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_NEXT</unmanaged-short>
        ConsumerAcNext = unchecked((System.Int16)(553)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_BOOKMARKS</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_BOOKMARKS</unmanaged-short>
        ConsumerAcBookmarks = unchecked((System.Int16)(554)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_AC_PAN</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_AC_PAN</unmanaged-short>
        ConsumerAcPan = unchecked((System.Int16)(568)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_EXTENDED_KEYBOARD_ATTRIBUTES_COLLECTION</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_EXTENDED_KEYBOARD_ATTRIBUTES_COLLECTION</unmanaged-short>
        ConsumerExtendedKeyboardAttributesCollection = unchecked((System.Int16)(704)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_KEYBOARD_FORM_FACTOR</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_KEYBOARD_FORM_FACTOR</unmanaged-short>
        ConsumerKeyboardFormFactor = unchecked((System.Int16)(705)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_KEYBOARD_KEY_TYPE</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_KEYBOARD_KEY_TYPE</unmanaged-short>
        ConsumerKeyboardKeyType = unchecked((System.Int16)(706)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_KEYBOARD_PHYSICAL_LAYOUT</unmanaged-short>
        ConsumerKeyboardPhysicalLayout = unchecked((System.Int16)(707)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_VENDOR_SPECIFIC_KEYBOARD_PHYSICAL_LAYOUT</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_VENDOR_SPECIFIC_KEYBOARD_PHYSICAL_LAYOUT</unmanaged-short>
        ConsumerVendorSpecificKeyboardPhysicalLayout = unchecked((System.Int16)(708)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_KEYBOARD_IETF_LANGUAGE_TAG_INDEX</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_KEYBOARD_IETF_LANGUAGE_TAG_INDEX</unmanaged-short>
        ConsumerKeyboardIetfLanguageTagIndex = unchecked((System.Int16)(709)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CONSUMER_IMPLEMENTED_KEYBOARD_INPUT_ASSIST_CONTROLS</unmanaged>
        /// <unmanaged-short>HID_USAGE_CONSUMER_IMPLEMENTED_KEYBOARD_INPUT_ASSIST_CONTROLS</unmanaged-short>
        ConsumerImplementedKeyboardInputAssistControls = unchecked((System.Int16)(710)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_DIGITIZER</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_DIGITIZER</unmanaged-short>
        DigitizerDigitizer = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_PEN</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_PEN</unmanaged-short>
        DigitizerPen = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_LIGHT_PEN</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_LIGHT_PEN</unmanaged-short>
        DigitizerLightPen = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TOUCH_SCREEN</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TOUCH_SCREEN</unmanaged-short>
        DigitizerTouchScreen = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TOUCH_PAD</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TOUCH_PAD</unmanaged-short>
        DigitizerTouchPad = unchecked((System.Int16)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_WHITE_BOARD</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_WHITE_BOARD</unmanaged-short>
        DigitizerWhiteBoard = unchecked((System.Int16)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_COORD_MEASURING</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_COORD_MEASURING</unmanaged-short>
        DigitizerCoordMeasuring = unchecked((System.Int16)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_3D_DIGITIZER</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_3D_DIGITIZER</unmanaged-short>
        Digitizer3dDigitizer = unchecked((System.Int16)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_STEREO_PLOTTER</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_STEREO_PLOTTER</unmanaged-short>
        DigitizerStereoPlotter = unchecked((System.Int16)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_ARTICULATED_ARM</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_ARTICULATED_ARM</unmanaged-short>
        DigitizerArticulatedArm = unchecked((System.Int16)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_ARMATURE</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_ARMATURE</unmanaged-short>
        DigitizerArmature = unchecked((System.Int16)(11)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_MULTI_POINT</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_MULTI_POINT</unmanaged-short>
        DigitizerMultiPoint = unchecked((System.Int16)(12)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_FREE_SPACE_WAND</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_FREE_SPACE_WAND</unmanaged-short>
        DigitizerFreeSpaceWand = unchecked((System.Int16)(13)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_STYLUS</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_STYLUS</unmanaged-short>
        DigitizerStylus = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_PUCK</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_PUCK</unmanaged-short>
        DigitizerPuck = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_FINGER</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_FINGER</unmanaged-short>
        DigitizerFinger = unchecked((System.Int16)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TABLET_FUNC_KEYS</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TABLET_FUNC_KEYS</unmanaged-short>
        DigitizerTabletFuncKeys = unchecked((System.Int16)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_PROG_CHANGE_KEYS</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_PROG_CHANGE_KEYS</unmanaged-short>
        DigitizerProgChangeKeys = unchecked((System.Int16)(58)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TIP_PRESSURE</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TIP_PRESSURE</unmanaged-short>
        DigitizerTipPressure = unchecked((System.Int16)(48)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_BARREL_PRESSURE</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_BARREL_PRESSURE</unmanaged-short>
        DigitizerBarrelPressure = unchecked((System.Int16)(49)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_IN_RANGE</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_IN_RANGE</unmanaged-short>
        DigitizerInRange = unchecked((System.Int16)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TOUCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TOUCH</unmanaged-short>
        DigitizerTouch = unchecked((System.Int16)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_UNTOUCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_UNTOUCH</unmanaged-short>
        DigitizerUntouch = unchecked((System.Int16)(52)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TAP</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TAP</unmanaged-short>
        DigitizerTap = unchecked((System.Int16)(53)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_QUALITY</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_QUALITY</unmanaged-short>
        DigitizerQuality = unchecked((System.Int16)(54)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_DATA_VALID</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_DATA_VALID</unmanaged-short>
        DigitizerDataValid = unchecked((System.Int16)(55)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TRANSDUCER_INDEX</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TRANSDUCER_INDEX</unmanaged-short>
        DigitizerTransducerIndex = unchecked((System.Int16)(56)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_BATTERY_STRENGTH</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_BATTERY_STRENGTH</unmanaged-short>
        DigitizerBatteryStrength = unchecked((System.Int16)(59)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_INVERT</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_INVERT</unmanaged-short>
        DigitizerInvert = unchecked((System.Int16)(60)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_X_TILT</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_X_TILT</unmanaged-short>
        DigitizerXTilt = unchecked((System.Int16)(61)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_Y_TILT</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_Y_TILT</unmanaged-short>
        DigitizerYTilt = unchecked((System.Int16)(62)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_AZIMUTH</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_AZIMUTH</unmanaged-short>
        DigitizerAzimuth = unchecked((System.Int16)(63)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_ALTITUDE</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_ALTITUDE</unmanaged-short>
        DigitizerAltitude = unchecked((System.Int16)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TWIST</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TWIST</unmanaged-short>
        DigitizerTwist = unchecked((System.Int16)(65)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TIP_SWITCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TIP_SWITCH</unmanaged-short>
        DigitizerTipSwitch = unchecked((System.Int16)(66)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_SECONDARY_TIP_SWITCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_SECONDARY_TIP_SWITCH</unmanaged-short>
        DigitizerSecondaryTipSwitch = unchecked((System.Int16)(67)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_BARREL_SWITCH</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_BARREL_SWITCH</unmanaged-short>
        DigitizerBarrelSwitch = unchecked((System.Int16)(68)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_ERASER</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_ERASER</unmanaged-short>
        DigitizerEraser = unchecked((System.Int16)(69)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_DIGITIZER_TABLET_PICK</unmanaged>
        /// <unmanaged-short>HID_USAGE_DIGITIZER_TABLET_PICK</unmanaged-short>
        DigitizerTabletPick = unchecked((System.Int16)(70)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_SIMPLE_CONTROLLER</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_SIMPLE_CONTROLLER</unmanaged-short>
        HapticsSimpleController = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_LIST</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_LIST</unmanaged-short>
        HapticsWaveformList = unchecked((System.Int16)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_DURATION_LIST</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_DURATION_LIST</unmanaged-short>
        HapticsDurationList = unchecked((System.Int16)(17)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_AUTO_TRIGGER</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_AUTO_TRIGGER</unmanaged-short>
        HapticsAutoTrigger = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_MANUAL_TRIGGER</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_MANUAL_TRIGGER</unmanaged-short>
        HapticsManualTrigger = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_AUTO_ASSOCIATED_CONTROL</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_AUTO_ASSOCIATED_CONTROL</unmanaged-short>
        HapticsAutoAssociatedControl = unchecked((System.Int16)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_INTENSITY</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_INTENSITY</unmanaged-short>
        HapticsIntensity = unchecked((System.Int16)(35)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_REPEAT_COUNT</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_REPEAT_COUNT</unmanaged-short>
        HapticsRepeatCount = unchecked((System.Int16)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_RETRIGGER_PERIOD</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_RETRIGGER_PERIOD</unmanaged-short>
        HapticsRetriggerPeriod = unchecked((System.Int16)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_VENDOR_PAGE</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_VENDOR_PAGE</unmanaged-short>
        HapticsWaveformVendorPage = unchecked((System.Int16)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_VENDOR_ID</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_VENDOR_ID</unmanaged-short>
        HapticsWaveformVendorId = unchecked((System.Int16)(39)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_CUTOFF_TIME</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_CUTOFF_TIME</unmanaged-short>
        HapticsWaveformCutoffTime = unchecked((System.Int16)(40)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_BEGIN</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_BEGIN</unmanaged-short>
        HapticsWaveformBegin = unchecked((System.Int16)(4096)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_STOP</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_STOP</unmanaged-short>
        HapticsWaveformStop = unchecked((System.Int16)(4097)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_NULL</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_NULL</unmanaged-short>
        HapticsWaveformNull = unchecked((System.Int16)(4098)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_CLICK</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_CLICK</unmanaged-short>
        HapticsWaveformClick = unchecked((System.Int16)(4099)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_BUZZ</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_BUZZ</unmanaged-short>
        HapticsWaveformBuzz = unchecked((System.Int16)(4100)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_RUMBLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_RUMBLE</unmanaged-short>
        HapticsWaveformRumble = unchecked((System.Int16)(4101)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_PRESS</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_PRESS</unmanaged-short>
        HapticsWaveformPress = unchecked((System.Int16)(4102)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_RELEASE</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_RELEASE</unmanaged-short>
        HapticsWaveformRelease = unchecked((System.Int16)(4103)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_END</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_END</unmanaged-short>
        HapticsWaveformEnd = unchecked((System.Int16)(8191)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_VENDOR_BEGIN</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_VENDOR_BEGIN</unmanaged-short>
        HapticsWaveformVendorBegin = unchecked((System.Int16)(8192)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_HAPTICS_WAVEFORM_VENDOR_END</unmanaged>
        /// <unmanaged-short>HID_USAGE_HAPTICS_WAVEFORM_VENDOR_END</unmanaged-short>
        HapticsWaveformVendorEnd = unchecked((System.Int16)(12287)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_ALPHANUMERIC_DISPLAY</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_ALPHANUMERIC_DISPLAY</unmanaged-short>
        AlphanumericAlphanumericDisplay = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BITMAPPED_DISPLAY</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BITMAPPED_DISPLAY</unmanaged-short>
        AlphanumericBitmappedDisplay = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DISPLAY_ATTRIBUTES_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DISPLAY_ATTRIBUTES_REPORT</unmanaged-short>
        AlphanumericDisplayAttributesReport = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DISPLAY_CONTROL_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DISPLAY_CONTROL_REPORT</unmanaged-short>
        AlphanumericDisplayControlReport = unchecked((System.Int16)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHARACTER_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHARACTER_REPORT</unmanaged-short>
        AlphanumericCharacterReport = unchecked((System.Int16)(43)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DISPLAY_STATUS</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DISPLAY_STATUS</unmanaged-short>
        AlphanumericDisplayStatus = unchecked((System.Int16)(45)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CURSOR_POSITION_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CURSOR_POSITION_REPORT</unmanaged-short>
        AlphanumericCursorPositionReport = unchecked((System.Int16)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_FONT_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_FONT_REPORT</unmanaged-short>
        AlphanumericFontReport = unchecked((System.Int16)(59)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_FONT_DATA</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_FONT_DATA</unmanaged-short>
        AlphanumericFontData = unchecked((System.Int16)(60)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHARACTER_ATTRIBUTE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHARACTER_ATTRIBUTE</unmanaged-short>
        AlphanumericCharacterAttribute = unchecked((System.Int16)(72)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_PALETTE_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_PALETTE_REPORT</unmanaged-short>
        AlphanumericPaletteReport = unchecked((System.Int16)(133)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_PALETTE_DATA</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_PALETTE_DATA</unmanaged-short>
        AlphanumericPaletteData = unchecked((System.Int16)(136)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BLIT_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BLIT_REPORT</unmanaged-short>
        AlphanumericBlitReport = unchecked((System.Int16)(138)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BLIT_DATA</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BLIT_DATA</unmanaged-short>
        AlphanumericBlitData = unchecked((System.Int16)(143)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON</unmanaged-short>
        AlphanumericSoftButton = unchecked((System.Int16)(144)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_ASCII_CHARACTER_SET</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_ASCII_CHARACTER_SET</unmanaged-short>
        AlphanumericAsciiCharacterSet = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DATA_READ_BACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DATA_READ_BACK</unmanaged-short>
        AlphanumericDataReadBack = unchecked((System.Int16)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_FONT_READ_BACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_FONT_READ_BACK</unmanaged-short>
        AlphanumericFontReadBack = unchecked((System.Int16)(35)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CLEAR_DISPLAY</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CLEAR_DISPLAY</unmanaged-short>
        AlphanumericClearDisplay = unchecked((System.Int16)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DISPLAY_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DISPLAY_ENABLE</unmanaged-short>
        AlphanumericDisplayEnable = unchecked((System.Int16)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_DELAY</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_DELAY</unmanaged-short>
        AlphanumericScreenSaverDelay = unchecked((System.Int16)(39)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_SCREEN_SAVER_ENABLE</unmanaged-short>
        AlphanumericScreenSaverEnable = unchecked((System.Int16)(40)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_VERTICAL_SCROLL</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_VERTICAL_SCROLL</unmanaged-short>
        AlphanumericVerticalScroll = unchecked((System.Int16)(41)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_HORIZONTAL_SCROLL</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_HORIZONTAL_SCROLL</unmanaged-short>
        AlphanumericHorizontalScroll = unchecked((System.Int16)(42)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DISPLAY_DATA</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DISPLAY_DATA</unmanaged-short>
        AlphanumericDisplayData = unchecked((System.Int16)(44)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_STATUS_NOT_READY</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_STATUS_NOT_READY</unmanaged-short>
        AlphanumericStatusNotReady = unchecked((System.Int16)(46)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_STATUS_READY</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_STATUS_READY</unmanaged-short>
        AlphanumericStatusReady = unchecked((System.Int16)(47)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_ERR_NOT_A_LOADABLE_CHARACTER</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_ERR_NOT_A_LOADABLE_CHARACTER</unmanaged-short>
        AlphanumericErrNotALoadableCharacter = unchecked((System.Int16)(48)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_ERR_FONT_DATA_CANNOT_BE_READ</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_ERR_FONT_DATA_CANNOT_BE_READ</unmanaged-short>
        AlphanumericErrFontDataCannotBeRead = unchecked((System.Int16)(49)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_ROW</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_ROW</unmanaged-short>
        AlphanumericRow = unchecked((System.Int16)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_COLUMN</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_COLUMN</unmanaged-short>
        AlphanumericColumn = unchecked((System.Int16)(52)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_ROWS</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_ROWS</unmanaged-short>
        AlphanumericRows = unchecked((System.Int16)(53)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_COLUMNS</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_COLUMNS</unmanaged-short>
        AlphanumericColumns = unchecked((System.Int16)(54)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CURSOR_PIXEL_POSITIONING</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CURSOR_PIXEL_POSITIONING</unmanaged-short>
        AlphanumericCursorPixelPositioning = unchecked((System.Int16)(55)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CURSOR_MODE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CURSOR_MODE</unmanaged-short>
        AlphanumericCursorMode = unchecked((System.Int16)(56)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CURSOR_ENABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CURSOR_ENABLE</unmanaged-short>
        AlphanumericCursorEnable = unchecked((System.Int16)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CURSOR_BLINK</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CURSOR_BLINK</unmanaged-short>
        AlphanumericCursorBlink = unchecked((System.Int16)(58)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHAR_WIDTH</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHAR_WIDTH</unmanaged-short>
        AlphanumericCharWidth = unchecked((System.Int16)(61)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHAR_HEIGHT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHAR_HEIGHT</unmanaged-short>
        AlphanumericCharHeight = unchecked((System.Int16)(62)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHAR_SPACING_HORIZONTAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHAR_SPACING_HORIZONTAL</unmanaged-short>
        AlphanumericCharSpacingHorizontal = unchecked((System.Int16)(63)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHAR_SPACING_VERTICAL</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHAR_SPACING_VERTICAL</unmanaged-short>
        AlphanumericCharSpacingVertical = unchecked((System.Int16)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_UNICODE_CHAR_SET</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_UNICODE_CHAR_SET</unmanaged-short>
        AlphanumericUnicodeCharSet = unchecked((System.Int16)(65)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_FONT_7_SEGMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_FONT_7_SEGMENT</unmanaged-short>
        AlphanumericFont7Segment = unchecked((System.Int16)(66)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_7_SEGMENT_DIRECT_MAP</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_7_SEGMENT_DIRECT_MAP</unmanaged-short>
        Alphanumeric7SegmentDirectMap = unchecked((System.Int16)(67)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_FONT_14_SEGMENT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_FONT_14_SEGMENT</unmanaged-short>
        AlphanumericFont14Segment = unchecked((System.Int16)(68)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_14_SEGMENT_DIRECT_MAP</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_14_SEGMENT_DIRECT_MAP</unmanaged-short>
        Alphanumeric14SegmentDirectMap = unchecked((System.Int16)(69)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DISPLAY_BRIGHTNESS</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DISPLAY_BRIGHTNESS</unmanaged-short>
        AlphanumericDisplayBrightness = unchecked((System.Int16)(70)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DISPLAY_CONTRAST</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DISPLAY_CONTRAST</unmanaged-short>
        AlphanumericDisplayContrast = unchecked((System.Int16)(71)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_ATTRIBUTE_READBACK</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_ATTRIBUTE_READBACK</unmanaged-short>
        AlphanumericAttributeReadback = unchecked((System.Int16)(73)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_ATTRIBUTE_DATA</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_ATTRIBUTE_DATA</unmanaged-short>
        AlphanumericAttributeData = unchecked((System.Int16)(74)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHAR_ATTR_ENHANCE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHAR_ATTR_ENHANCE</unmanaged-short>
        AlphanumericCharAttrEnhance = unchecked((System.Int16)(75)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHAR_ATTR_UNDERLINE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHAR_ATTR_UNDERLINE</unmanaged-short>
        AlphanumericCharAttrUnderline = unchecked((System.Int16)(76)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_CHAR_ATTR_BLINK</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_CHAR_ATTR_BLINK</unmanaged-short>
        AlphanumericCharAttrBlink = unchecked((System.Int16)(77)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_X</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_X</unmanaged-short>
        AlphanumericBitmapSizeX = unchecked((System.Int16)(128)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_Y</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BITMAP_SIZE_Y</unmanaged-short>
        AlphanumericBitmapSizeY = unchecked((System.Int16)(129)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BIT_DEPTH_FORMAT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BIT_DEPTH_FORMAT</unmanaged-short>
        AlphanumericBitDepthFormat = unchecked((System.Int16)(131)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_DISPLAY_ORIENTATION</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_DISPLAY_ORIENTATION</unmanaged-short>
        AlphanumericDisplayOrientation = unchecked((System.Int16)(132)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_PALETTE_DATA_SIZE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_PALETTE_DATA_SIZE</unmanaged-short>
        AlphanumericPaletteDataSize = unchecked((System.Int16)(134)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_PALETTE_DATA_OFFSET</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_PALETTE_DATA_OFFSET</unmanaged-short>
        AlphanumericPaletteDataOffset = unchecked((System.Int16)(135)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X1</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X1</unmanaged-short>
        AlphanumericBlitRectangleX1 = unchecked((System.Int16)(139)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y1</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y1</unmanaged-short>
        AlphanumericBlitRectangleY1 = unchecked((System.Int16)(140)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X2</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_X2</unmanaged-short>
        AlphanumericBlitRectangleX2 = unchecked((System.Int16)(141)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y2</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_BLIT_RECTANGLE_Y2</unmanaged-short>
        AlphanumericBlitRectangleY2 = unchecked((System.Int16)(142)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_ID</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_ID</unmanaged-short>
        AlphanumericSoftButtonId = unchecked((System.Int16)(145)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_SIDE</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_SIDE</unmanaged-short>
        AlphanumericSoftButtonSide = unchecked((System.Int16)(146)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET1</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET1</unmanaged-short>
        AlphanumericSoftButtonOffset1 = unchecked((System.Int16)(147)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET2</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_OFFSET2</unmanaged-short>
        AlphanumericSoftButtonOffset2 = unchecked((System.Int16)(148)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_ALPHANUMERIC_SOFT_BUTTON_REPORT</unmanaged-short>
        AlphanumericSoftButtonReport = unchecked((System.Int16)(149)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY</unmanaged-short>
        Lamparray = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_ATTRBIUTES_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_ATTRBIUTES_REPORT</unmanaged-short>
        LamparrayAttrbiutesReport = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_COUNT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_COUNT</unmanaged-short>
        LamparrayLampCount = unchecked((System.Int16)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_BOUNDING_BOX_WIDTH_IN_MICROMETERS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_BOUNDING_BOX_WIDTH_IN_MICROMETERS</unmanaged-short>
        LamparrayBoundingBoxWidthInMicrometers = unchecked((System.Int16)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_BOUNDING_BOX_HEIGHT_IN_MICROMETERS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_BOUNDING_BOX_HEIGHT_IN_MICROMETERS</unmanaged-short>
        LamparrayBoundingBoxHeightInMicrometers = unchecked((System.Int16)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_BOUNDING_BOX_DEPTH_IN_MICROMETERS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_BOUNDING_BOX_DEPTH_IN_MICROMETERS</unmanaged-short>
        LamparrayBoundingBoxDepthInMicrometers = unchecked((System.Int16)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_KIND</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_KIND</unmanaged-short>
        LamparrayKind = unchecked((System.Int16)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_MIN_UPDATE_INTERVAL_IN_MICROSECONDS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_MIN_UPDATE_INTERVAL_IN_MICROSECONDS</unmanaged-short>
        LamparrayMinUpdateIntervalInMicroseconds = unchecked((System.Int16)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_REQUEST_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_REQUEST_REPORT</unmanaged-short>
        LamparrayLampAttributesRequestReport = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_ID</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_ID</unmanaged-short>
        LamparrayLampId = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_RESPONSE_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_ATTRIBUTES_RESPONSE_REPORT</unmanaged-short>
        LamparrayLampAttributesResponseReport = unchecked((System.Int16)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_POSITION_X_IN_MICROMETERS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_POSITION_X_IN_MICROMETERS</unmanaged-short>
        LamparrayPositionXInMicrometers = unchecked((System.Int16)(35)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_POSITION_Y_IN_MICROMETERS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_POSITION_Y_IN_MICROMETERS</unmanaged-short>
        LamparrayPositionYInMicrometers = unchecked((System.Int16)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_POSITION_Z_IN_MICROMETERS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_POSITION_Z_IN_MICROMETERS</unmanaged-short>
        LamparrayPositionZInMicrometers = unchecked((System.Int16)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_PURPOSES</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_PURPOSES</unmanaged-short>
        LamparrayLampPurposes = unchecked((System.Int16)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_UPDATE_LATENCY_IN_MICROSECONDS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_UPDATE_LATENCY_IN_MICROSECONDS</unmanaged-short>
        LamparrayUpdateLatencyInMicroseconds = unchecked((System.Int16)(39)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_RED_LEVEL_COUNT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_RED_LEVEL_COUNT</unmanaged-short>
        LamparrayRedLevelCount = unchecked((System.Int16)(40)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_GREEN_LEVEL_COUNT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_GREEN_LEVEL_COUNT</unmanaged-short>
        LamparrayGreenLevelCount = unchecked((System.Int16)(41)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_BLUE_LEVEL_COUNT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_BLUE_LEVEL_COUNT</unmanaged-short>
        LamparrayBlueLevelCount = unchecked((System.Int16)(42)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_INTENSITY_LEVEL_COUNT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_INTENSITY_LEVEL_COUNT</unmanaged-short>
        LamparrayIntensityLevelCount = unchecked((System.Int16)(43)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_IS_PROGRAMMABLE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_IS_PROGRAMMABLE</unmanaged-short>
        LamparrayIsProgrammable = unchecked((System.Int16)(44)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_INPUT_BINDING</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_INPUT_BINDING</unmanaged-short>
        LamparrayInputBinding = unchecked((System.Int16)(45)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_MULTI_UPDATE_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_MULTI_UPDATE_REPORT</unmanaged-short>
        LamparrayLampMultiUpdateReport = unchecked((System.Int16)(80)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_RED_UPDATE_CHANNEL</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_RED_UPDATE_CHANNEL</unmanaged-short>
        LamparrayLampRedUpdateChannel = unchecked((System.Int16)(81)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_GREEN_UPDATE_CHANNEL</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_GREEN_UPDATE_CHANNEL</unmanaged-short>
        LamparrayLampGreenUpdateChannel = unchecked((System.Int16)(82)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_BLUE_UPDATE_CHANNEL</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_BLUE_UPDATE_CHANNEL</unmanaged-short>
        LamparrayLampBlueUpdateChannel = unchecked((System.Int16)(83)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_INTENSITY_UPDATE_CHANNEL</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_INTENSITY_UPDATE_CHANNEL</unmanaged-short>
        LamparrayLampIntensityUpdateChannel = unchecked((System.Int16)(84)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_UPDATE_FLAGS</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_UPDATE_FLAGS</unmanaged-short>
        LamparrayLampUpdateFlags = unchecked((System.Int16)(85)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_RANGE_UPDATE_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_RANGE_UPDATE_REPORT</unmanaged-short>
        LamparrayLampRangeUpdateReport = unchecked((System.Int16)(96)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_ID_START</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_ID_START</unmanaged-short>
        LamparrayLampIdStart = unchecked((System.Int16)(97)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_LAMP_ID_END</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_LAMP_ID_END</unmanaged-short>
        LamparrayLampIdEnd = unchecked((System.Int16)(98)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_CONTROL_REPORT</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_CONTROL_REPORT</unmanaged-short>
        LamparrayControlReport = unchecked((System.Int16)(112)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_LAMPARRAY_AUTONOMOUS_MODE</unmanaged>
        /// <unmanaged-short>HID_USAGE_LAMPARRAY_AUTONOMOUS_MODE</unmanaged-short>
        LamparrayAutonomousMode = unchecked((System.Int16)(113)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CAMERA_AUTO_FOCUS</unmanaged>
        /// <unmanaged-short>HID_USAGE_CAMERA_AUTO_FOCUS</unmanaged-short>
        CameraAutoFocus = unchecked((System.Int16)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_CAMERA_SHUTTER</unmanaged>
        /// <unmanaged-short>HID_USAGE_CAMERA_SHUTTER</unmanaged-short>
        CameraShutter = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_MS_BTH_HF_DIALNUMBER</unmanaged>
        /// <unmanaged-short>HID_USAGE_MS_BTH_HF_DIALNUMBER</unmanaged-short>
        MsBthHfDialnumber = unchecked((System.Int16)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>HID_USAGE_MS_BTH_HF_DIALMEMORY</unmanaged>
        /// <unmanaged-short>HID_USAGE_MS_BTH_HF_DIALMEMORY</unmanaged-short>
        MsBthHfDialmemory = unchecked((System.Int16)(34))
    }
}
