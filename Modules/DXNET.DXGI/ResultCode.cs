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

    public partial class ResultCode
    {
        ///<summary>Constant InvalidCall</summary>
        ///<unmanaged>DXGI_ERROR_INVALID_CALL</unmanaged>
        public static readonly DXNET.ResultDescriptor InvalidCall = new DXNET.ResultDescriptor(unchecked((int)2289696769UL), "DXNET.DXGI", "DXGI_ERROR_INVALID_CALL", "InvalidCall");
        ///<summary>Constant NotFound</summary>
        ///<unmanaged>DXGI_ERROR_NOT_FOUND</unmanaged>
        public static readonly DXNET.ResultDescriptor NotFound = new DXNET.ResultDescriptor(unchecked((int)2289696770UL), "DXNET.DXGI", "DXGI_ERROR_NOT_FOUND", "NotFound");
        ///<summary>Constant MoreData</summary>
        ///<unmanaged>DXGI_ERROR_MORE_DATA</unmanaged>
        public static readonly DXNET.ResultDescriptor MoreData = new DXNET.ResultDescriptor(unchecked((int)2289696771UL), "DXNET.DXGI", "DXGI_ERROR_MORE_DATA", "MoreData");
        ///<summary>Constant Unsupported</summary>
        ///<unmanaged>DXGI_ERROR_UNSUPPORTED</unmanaged>
        public static readonly DXNET.ResultDescriptor Unsupported = new DXNET.ResultDescriptor(unchecked((int)2289696772UL), "DXNET.DXGI", "DXGI_ERROR_UNSUPPORTED", "Unsupported");
        ///<summary>Constant DeviceRemoved</summary>
        ///<unmanaged>DXGI_ERROR_DEVICE_REMOVED</unmanaged>
        public static readonly DXNET.ResultDescriptor DeviceRemoved = new DXNET.ResultDescriptor(unchecked((int)2289696773UL), "DXNET.DXGI", "DXGI_ERROR_DEVICE_REMOVED", "DeviceRemoved");
        ///<summary>Constant DeviceHung</summary>
        ///<unmanaged>DXGI_ERROR_DEVICE_HUNG</unmanaged>
        public static readonly DXNET.ResultDescriptor DeviceHung = new DXNET.ResultDescriptor(unchecked((int)2289696774UL), "DXNET.DXGI", "DXGI_ERROR_DEVICE_HUNG", "DeviceHung");
        ///<summary>Constant DeviceReset</summary>
        ///<unmanaged>DXGI_ERROR_DEVICE_RESET</unmanaged>
        public static readonly DXNET.ResultDescriptor DeviceReset = new DXNET.ResultDescriptor(unchecked((int)2289696775UL), "DXNET.DXGI", "DXGI_ERROR_DEVICE_RESET", "DeviceReset");
        ///<summary>Constant WasStillDrawing</summary>
        ///<unmanaged>DXGI_ERROR_WAS_STILL_DRAWING</unmanaged>
        public static readonly DXNET.ResultDescriptor WasStillDrawing = new DXNET.ResultDescriptor(unchecked((int)2289696778UL), "DXNET.DXGI", "DXGI_ERROR_WAS_STILL_DRAWING", "WasStillDrawing");
        ///<summary>Constant FrameStatisticsDisjoint</summary>
        ///<unmanaged>DXGI_ERROR_FRAME_STATISTICS_DISJOINT</unmanaged>
        public static readonly DXNET.ResultDescriptor FrameStatisticsDisjoint = new DXNET.ResultDescriptor(unchecked((int)2289696779UL), "DXNET.DXGI", "DXGI_ERROR_FRAME_STATISTICS_DISJOINT", "FrameStatisticsDisjoint");
        ///<summary>Constant GraphicsVidpnSourceInUse</summary>
        ///<unmanaged>DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE</unmanaged>
        public static readonly DXNET.ResultDescriptor GraphicsVidpnSourceInUse = new DXNET.ResultDescriptor(unchecked((int)2289696780UL), "DXNET.DXGI", "DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE", "GraphicsVidpnSourceInUse");
        ///<summary>Constant DriverInternalError</summary>
        ///<unmanaged>DXGI_ERROR_DRIVER_INTERNAL_ERROR</unmanaged>
        public static readonly DXNET.ResultDescriptor DriverInternalError = new DXNET.ResultDescriptor(unchecked((int)2289696800UL), "DXNET.DXGI", "DXGI_ERROR_DRIVER_INTERNAL_ERROR", "DriverInternalError");
        ///<summary>Constant Nonexclusive</summary>
        ///<unmanaged>DXGI_ERROR_NONEXCLUSIVE</unmanaged>
        public static readonly DXNET.ResultDescriptor Nonexclusive = new DXNET.ResultDescriptor(unchecked((int)2289696801UL), "DXNET.DXGI", "DXGI_ERROR_NONEXCLUSIVE", "Nonexclusive");
        ///<summary>Constant NotCurrentlyAvailable</summary>
        ///<unmanaged>DXGI_ERROR_NOT_CURRENTLY_AVAILABLE</unmanaged>
        public static readonly DXNET.ResultDescriptor NotCurrentlyAvailable = new DXNET.ResultDescriptor(unchecked((int)2289696802UL), "DXNET.DXGI", "DXGI_ERROR_NOT_CURRENTLY_AVAILABLE", "NotCurrentlyAvailable");
        ///<summary>Constant RemoteClientDisconnected</summary>
        ///<unmanaged>DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED</unmanaged>
        public static readonly DXNET.ResultDescriptor RemoteClientDisconnected = new DXNET.ResultDescriptor(unchecked((int)2289696803UL), "DXNET.DXGI", "DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED", "RemoteClientDisconnected");
        ///<summary>Constant RemoteOufOfMemory</summary>
        ///<unmanaged>DXGI_ERROR_REMOTE_OUTOFMEMORY</unmanaged>
        public static readonly DXNET.ResultDescriptor RemoteOufOfMemory = new DXNET.ResultDescriptor(unchecked((int)2289696804UL), "DXNET.DXGI", "DXGI_ERROR_REMOTE_OUTOFMEMORY", "RemoteOufOfMemory");
        ///<summary>Constant AccessLost</summary>
        ///<unmanaged>DXGI_ERROR_ACCESS_LOST</unmanaged>
        public static readonly DXNET.ResultDescriptor AccessLost = new DXNET.ResultDescriptor(unchecked((int)2289696806UL), "DXNET.DXGI", "DXGI_ERROR_ACCESS_LOST", "AccessLost");
        ///<summary>Constant WaitTimeout</summary>
        ///<unmanaged>DXGI_ERROR_WAIT_TIMEOUT</unmanaged>
        public static readonly DXNET.ResultDescriptor WaitTimeout = new DXNET.ResultDescriptor(unchecked((int)2289696807UL), "DXNET.DXGI", "DXGI_ERROR_WAIT_TIMEOUT", "WaitTimeout");
        ///<summary>Constant SessionDisconnected</summary>
        ///<unmanaged>DXGI_ERROR_SESSION_DISCONNECTED</unmanaged>
        public static readonly DXNET.ResultDescriptor SessionDisconnected = new DXNET.ResultDescriptor(unchecked((int)2289696808UL), "DXNET.DXGI", "DXGI_ERROR_SESSION_DISCONNECTED", "SessionDisconnected");
        ///<summary>Constant RestrictToOutputStale</summary>
        ///<unmanaged>DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE</unmanaged>
        public static readonly DXNET.ResultDescriptor RestrictToOutputStale = new DXNET.ResultDescriptor(unchecked((int)2289696809UL), "DXNET.DXGI", "DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE", "RestrictToOutputStale");
        ///<summary>Constant CannotProtectContent</summary>
        ///<unmanaged>DXGI_ERROR_CANNOT_PROTECT_CONTENT</unmanaged>
        public static readonly DXNET.ResultDescriptor CannotProtectContent = new DXNET.ResultDescriptor(unchecked((int)2289696810UL), "DXNET.DXGI", "DXGI_ERROR_CANNOT_PROTECT_CONTENT", "CannotProtectContent");
        ///<summary>Constant AccessDenied</summary>
        ///<unmanaged>DXGI_ERROR_ACCESS_DENIED</unmanaged>
        public static readonly DXNET.ResultDescriptor AccessDenied = new DXNET.ResultDescriptor(unchecked((int)2289696811UL), "DXNET.DXGI", "DXGI_ERROR_ACCESS_DENIED", "AccessDenied");
        ///<summary>Constant NameAlreadyExists</summary>
        ///<unmanaged>DXGI_ERROR_NAME_ALREADY_EXISTS</unmanaged>
        public static readonly DXNET.ResultDescriptor NameAlreadyExists = new DXNET.ResultDescriptor(unchecked((int)2289696812UL), "DXNET.DXGI", "DXGI_ERROR_NAME_ALREADY_EXISTS", "NameAlreadyExists");
        ///<summary>Constant SdkComponentMissing</summary>
        ///<unmanaged>DXGI_ERROR_SDK_COMPONENT_MISSING</unmanaged>
        public static readonly DXNET.ResultDescriptor SdkComponentMissing = new DXNET.ResultDescriptor(unchecked((int)2289696813UL), "DXNET.DXGI", "DXGI_ERROR_SDK_COMPONENT_MISSING", "SdkComponentMissing");
        ///<summary>Constant NotCurrent</summary>
        ///<unmanaged>DXGI_ERROR_NOT_CURRENT</unmanaged>
        public static readonly DXNET.ResultDescriptor NotCurrent = new DXNET.ResultDescriptor(unchecked((int)2289696814UL), "DXNET.DXGI", "DXGI_ERROR_NOT_CURRENT", "NotCurrent");
        ///<summary>Constant HwProtectionOufOfMemory</summary>
        ///<unmanaged>DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY</unmanaged>
        public static readonly DXNET.ResultDescriptor HwProtectionOufOfMemory = new DXNET.ResultDescriptor(unchecked((int)2289696816UL), "DXNET.DXGI", "DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY", "HwProtectionOufOfMemory");
        ///<summary>Constant DynamicCodePolicyViolation</summary>
        ///<unmanaged>DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION</unmanaged>
        public static readonly DXNET.ResultDescriptor DynamicCodePolicyViolation = new DXNET.ResultDescriptor(unchecked((int)2289696817UL), "DXNET.DXGI", "DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION", "DynamicCodePolicyViolation");
        ///<summary>Constant NonCompositedUi</summary>
        ///<unmanaged>DXGI_ERROR_NON_COMPOSITED_UI</unmanaged>
        public static readonly DXNET.ResultDescriptor NonCompositedUi = new DXNET.ResultDescriptor(unchecked((int)2289696818UL), "DXNET.DXGI", "DXGI_ERROR_NON_COMPOSITED_UI", "NonCompositedUi");
        ///<summary>Constant ModeChangeInProgress</summary>
        ///<unmanaged>DXGI_ERROR_MODE_CHANGE_IN_PROGRESS</unmanaged>
        public static readonly DXNET.ResultDescriptor ModeChangeInProgress = new DXNET.ResultDescriptor(unchecked((int)2289696805UL), "DXNET.DXGI", "DXGI_ERROR_MODE_CHANGE_IN_PROGRESS", "ModeChangeInProgress");
        ///<summary>Constant CacheCorrupt</summary>
        ///<unmanaged>DXGI_ERROR_CACHE_CORRUPT</unmanaged>
        public static readonly DXNET.ResultDescriptor CacheCorrupt = new DXNET.ResultDescriptor(unchecked((int)2289696819UL), "DXNET.DXGI", "DXGI_ERROR_CACHE_CORRUPT", "CacheCorrupt");
        ///<summary>Constant CacheFull</summary>
        ///<unmanaged>DXGI_ERROR_CACHE_FULL</unmanaged>
        public static readonly DXNET.ResultDescriptor CacheFull = new DXNET.ResultDescriptor(unchecked((int)2289696820UL), "DXNET.DXGI", "DXGI_ERROR_CACHE_FULL", "CacheFull");
        ///<summary>Constant CacheHashCollision</summary>
        ///<unmanaged>DXGI_ERROR_CACHE_HASH_COLLISION</unmanaged>
        public static readonly DXNET.ResultDescriptor CacheHashCollision = new DXNET.ResultDescriptor(unchecked((int)2289696821UL), "DXNET.DXGI", "DXGI_ERROR_CACHE_HASH_COLLISION", "CacheHashCollision");
        ///<summary>Constant AlreadyExists</summary>
        ///<unmanaged>DXGI_ERROR_ALREADY_EXISTS</unmanaged>
        public static readonly DXNET.ResultDescriptor AlreadyExists = new DXNET.ResultDescriptor(unchecked((int)2289696822UL), "DXNET.DXGI", "DXGI_ERROR_ALREADY_EXISTS", "AlreadyExists");
    }
}