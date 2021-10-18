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

namespace DXNET.Win32
{
    public partial class ErrorCodeHelper
    {
        /// <summary>
        /// Converts a win32 error code to a <see cref="Result"/>.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <returns>A HRESULT code</returns>
        public static Result ToResult(ErrorCode errorCode)
        {
            return ToResult((int)errorCode);
        }
        
        /// <summary>
        /// Converts a win32 error code to a <see cref="Result"/>.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <returns>A HRESULT code</returns>
        public static Result ToResult(int errorCode)
        {
            return new Result(((errorCode <= 0) ? unchecked((uint)errorCode) : ((unchecked((uint)errorCode) & 0x0000FFFF) | 0x80070000)));
        }
    }

    public enum ErrorCode : int
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SUCCESS</unmanaged>
        /// <unmanaged-short>ERROR_SUCCESS</unmanaged-short>
        Success = unchecked((System.Int32)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_FUNCTION</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_FUNCTION</unmanaged-short>
        InvalidFunction = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_FILE_NOT_FOUND</unmanaged-short>
        FileNotFound = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATH_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_PATH_NOT_FOUND</unmanaged-short>
        PathNotFound = unchecked((System.Int32)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_OPEN_FILES</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_OPEN_FILES</unmanaged-short>
        TooManyOpenFiles = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_ACCESS_DENIED</unmanaged-short>
        AccessDenied = unchecked((System.Int32)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_HANDLE</unmanaged-short>
        InvalidHandle = unchecked((System.Int32)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ARENA_TRASHED</unmanaged>
        /// <unmanaged-short>ERROR_ARENA_TRASHED</unmanaged-short>
        ArenaTrashed = unchecked((System.Int32)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_ENOUGH_MEMORY</unmanaged>
        /// <unmanaged-short>ERROR_NOT_ENOUGH_MEMORY</unmanaged-short>
        NotEnoughMemory = unchecked((System.Int32)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_BLOCK</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_BLOCK</unmanaged-short>
        InvalidBlock = unchecked((System.Int32)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_ENVIRONMENT</unmanaged>
        /// <unmanaged-short>ERROR_BAD_ENVIRONMENT</unmanaged-short>
        BadEnvironment = unchecked((System.Int32)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_BAD_FORMAT</unmanaged-short>
        BadFormat = unchecked((System.Int32)(11)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ACCESS</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ACCESS</unmanaged-short>
        InvalidAccess = unchecked((System.Int32)(12)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DATA</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DATA</unmanaged-short>
        InvalidData = unchecked((System.Int32)(13)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OUTOFMEMORY</unmanaged>
        /// <unmanaged-short>ERROR_OUTOFMEMORY</unmanaged-short>
        Outofmemory = unchecked((System.Int32)(14)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DRIVE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DRIVE</unmanaged-short>
        InvalidDrive = unchecked((System.Int32)(15)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CURRENT_DIRECTORY</unmanaged>
        /// <unmanaged-short>ERROR_CURRENT_DIRECTORY</unmanaged-short>
        CurrentDirectory = unchecked((System.Int32)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SAME_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SAME_DEVICE</unmanaged-short>
        NotSameDevice = unchecked((System.Int32)(17)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_MORE_FILES</unmanaged>
        /// <unmanaged-short>ERROR_NO_MORE_FILES</unmanaged-short>
        NoMoreFiles = unchecked((System.Int32)(18)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WRITE_PROTECT</unmanaged>
        /// <unmanaged-short>ERROR_WRITE_PROTECT</unmanaged-short>
        WriteProtect = unchecked((System.Int32)(19)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_UNIT</unmanaged>
        /// <unmanaged-short>ERROR_BAD_UNIT</unmanaged-short>
        BadUnit = unchecked((System.Int32)(20)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_READY</unmanaged>
        /// <unmanaged-short>ERROR_NOT_READY</unmanaged-short>
        NotReady = unchecked((System.Int32)(21)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_COMMAND</unmanaged>
        /// <unmanaged-short>ERROR_BAD_COMMAND</unmanaged-short>
        BadCommand = unchecked((System.Int32)(22)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CRC</unmanaged>
        /// <unmanaged-short>ERROR_CRC</unmanaged-short>
        Crc = unchecked((System.Int32)(23)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_LENGTH</unmanaged>
        /// <unmanaged-short>ERROR_BAD_LENGTH</unmanaged-short>
        BadLength = unchecked((System.Int32)(24)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SEEK</unmanaged>
        /// <unmanaged-short>ERROR_SEEK</unmanaged-short>
        Seek = unchecked((System.Int32)(25)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_DOS_DISK</unmanaged>
        /// <unmanaged-short>ERROR_NOT_DOS_DISK</unmanaged-short>
        NotDosDisk = unchecked((System.Int32)(26)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECTOR_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SECTOR_NOT_FOUND</unmanaged-short>
        SectorNotFound = unchecked((System.Int32)(27)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OUT_OF_PAPER</unmanaged>
        /// <unmanaged-short>ERROR_OUT_OF_PAPER</unmanaged-short>
        OutOfPaper = unchecked((System.Int32)(28)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WRITE_FAULT</unmanaged>
        /// <unmanaged-short>ERROR_WRITE_FAULT</unmanaged-short>
        WriteFault = unchecked((System.Int32)(29)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_READ_FAULT</unmanaged>
        /// <unmanaged-short>ERROR_READ_FAULT</unmanaged-short>
        ReadFault = unchecked((System.Int32)(30)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GEN_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_GEN_FAILURE</unmanaged-short>
        GenFailure = unchecked((System.Int32)(31)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHARING_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_SHARING_VIOLATION</unmanaged-short>
        SharingViolation = unchecked((System.Int32)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOCK_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_LOCK_VIOLATION</unmanaged-short>
        LockViolation = unchecked((System.Int32)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WRONG_DISK</unmanaged>
        /// <unmanaged-short>ERROR_WRONG_DISK</unmanaged-short>
        WrongDisk = unchecked((System.Int32)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHARING_BUFFER_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_SHARING_BUFFER_EXCEEDED</unmanaged-short>
        SharingBufferExceeded = unchecked((System.Int32)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HANDLE_EOF</unmanaged>
        /// <unmanaged-short>ERROR_HANDLE_EOF</unmanaged-short>
        HandleEof = unchecked((System.Int32)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HANDLE_DISK_FULL</unmanaged>
        /// <unmanaged-short>ERROR_HANDLE_DISK_FULL</unmanaged-short>
        HandleDiskFull = unchecked((System.Int32)(39)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SUPPORTED</unmanaged-short>
        NotSupported = unchecked((System.Int32)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REM_NOT_LIST</unmanaged>
        /// <unmanaged-short>ERROR_REM_NOT_LIST</unmanaged-short>
        RemNotList = unchecked((System.Int32)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DUP_NAME</unmanaged>
        /// <unmanaged-short>ERROR_DUP_NAME</unmanaged-short>
        DupName = unchecked((System.Int32)(52)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_NETPATH</unmanaged>
        /// <unmanaged-short>ERROR_BAD_NETPATH</unmanaged-short>
        BadNetpath = unchecked((System.Int32)(53)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NETWORK_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_NETWORK_BUSY</unmanaged-short>
        NetworkBusy = unchecked((System.Int32)(54)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEV_NOT_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_DEV_NOT_EXIST</unmanaged-short>
        DevNotExist = unchecked((System.Int32)(55)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_CMDS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_CMDS</unmanaged-short>
        TooManyCmds = unchecked((System.Int32)(56)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ADAP_HDW_ERR</unmanaged>
        /// <unmanaged-short>ERROR_ADAP_HDW_ERR</unmanaged-short>
        AdapHdwErr = unchecked((System.Int32)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_NET_RESP</unmanaged>
        /// <unmanaged-short>ERROR_BAD_NET_RESP</unmanaged-short>
        BadNetResp = unchecked((System.Int32)(58)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNEXP_NET_ERR</unmanaged>
        /// <unmanaged-short>ERROR_UNEXP_NET_ERR</unmanaged-short>
        UnexpNetErr = unchecked((System.Int32)(59)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_REM_ADAP</unmanaged>
        /// <unmanaged-short>ERROR_BAD_REM_ADAP</unmanaged-short>
        BadRemAdap = unchecked((System.Int32)(60)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTQ_FULL</unmanaged>
        /// <unmanaged-short>ERROR_PRINTQ_FULL</unmanaged-short>
        PrintqFull = unchecked((System.Int32)(61)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SPOOL_SPACE</unmanaged>
        /// <unmanaged-short>ERROR_NO_SPOOL_SPACE</unmanaged-short>
        NoSpoolSpace = unchecked((System.Int32)(62)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINT_CANCELLED</unmanaged>
        /// <unmanaged-short>ERROR_PRINT_CANCELLED</unmanaged-short>
        PrintCancelled = unchecked((System.Int32)(63)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NETNAME_DELETED</unmanaged>
        /// <unmanaged-short>ERROR_NETNAME_DELETED</unmanaged-short>
        NetnameDeleted = unchecked((System.Int32)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NETWORK_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_NETWORK_ACCESS_DENIED</unmanaged-short>
        NetworkAccessDenied = unchecked((System.Int32)(65)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_DEV_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_DEV_TYPE</unmanaged-short>
        BadDevType = unchecked((System.Int32)(66)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_NET_NAME</unmanaged>
        /// <unmanaged-short>ERROR_BAD_NET_NAME</unmanaged-short>
        BadNetName = unchecked((System.Int32)(67)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_NAMES</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_NAMES</unmanaged-short>
        TooManyNames = unchecked((System.Int32)(68)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_SESS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_SESS</unmanaged-short>
        TooManySess = unchecked((System.Int32)(69)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHARING_PAUSED</unmanaged>
        /// <unmanaged-short>ERROR_SHARING_PAUSED</unmanaged-short>
        SharingPaused = unchecked((System.Int32)(70)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REQ_NOT_ACCEP</unmanaged>
        /// <unmanaged-short>ERROR_REQ_NOT_ACCEP</unmanaged-short>
        ReqNotAccep = unchecked((System.Int32)(71)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REDIR_PAUSED</unmanaged>
        /// <unmanaged-short>ERROR_REDIR_PAUSED</unmanaged-short>
        RedirPaused = unchecked((System.Int32)(72)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_FILE_EXISTS</unmanaged-short>
        FileExists = unchecked((System.Int32)(80)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_MAKE</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_MAKE</unmanaged-short>
        CannotMake = unchecked((System.Int32)(82)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAIL_I24</unmanaged>
        /// <unmanaged-short>ERROR_FAIL_I24</unmanaged-short>
        FailI24 = unchecked((System.Int32)(83)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OUT_OF_STRUCTURES</unmanaged>
        /// <unmanaged-short>ERROR_OUT_OF_STRUCTURES</unmanaged-short>
        OutOfStructures = unchecked((System.Int32)(84)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_ASSIGNED</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_ASSIGNED</unmanaged-short>
        AlreadyAssigned = unchecked((System.Int32)(85)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PASSWORD</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PASSWORD</unmanaged-short>
        InvalidPassword = unchecked((System.Int32)(86)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PARAMETER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PARAMETER</unmanaged-short>
        InvalidParameter = unchecked((System.Int32)(87)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NET_WRITE_FAULT</unmanaged>
        /// <unmanaged-short>ERROR_NET_WRITE_FAULT</unmanaged-short>
        NetWriteFault = unchecked((System.Int32)(88)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_PROC_SLOTS</unmanaged>
        /// <unmanaged-short>ERROR_NO_PROC_SLOTS</unmanaged-short>
        NoProcSlots = unchecked((System.Int32)(89)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_SEMAPHORES</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_SEMAPHORES</unmanaged-short>
        TooManySemaphores = unchecked((System.Int32)(100)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXCL_SEM_ALREADY_OWNED</unmanaged>
        /// <unmanaged-short>ERROR_EXCL_SEM_ALREADY_OWNED</unmanaged-short>
        ExclSemAlreadyOwned = unchecked((System.Int32)(101)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SEM_IS_SET</unmanaged>
        /// <unmanaged-short>ERROR_SEM_IS_SET</unmanaged-short>
        SemIsSet = unchecked((System.Int32)(102)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_SEM_REQUESTS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_SEM_REQUESTS</unmanaged-short>
        TooManySemRequests = unchecked((System.Int32)(103)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_AT_INTERRUPT_TIME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_AT_INTERRUPT_TIME</unmanaged-short>
        InvalidAtInterruptTime = unchecked((System.Int32)(104)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SEM_OWNER_DIED</unmanaged>
        /// <unmanaged-short>ERROR_SEM_OWNER_DIED</unmanaged-short>
        SemOwnerDied = unchecked((System.Int32)(105)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SEM_USER_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_SEM_USER_LIMIT</unmanaged-short>
        SemUserLimit = unchecked((System.Int32)(106)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_CHANGE</unmanaged>
        /// <unmanaged-short>ERROR_DISK_CHANGE</unmanaged-short>
        DiskChange = unchecked((System.Int32)(107)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVE_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_DRIVE_LOCKED</unmanaged-short>
        DriveLocked = unchecked((System.Int32)(108)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BROKEN_PIPE</unmanaged>
        /// <unmanaged-short>ERROR_BROKEN_PIPE</unmanaged-short>
        BrokenPipe = unchecked((System.Int32)(109)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPEN_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_OPEN_FAILED</unmanaged-short>
        OpenFailed = unchecked((System.Int32)(110)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BUFFER_OVERFLOW</unmanaged>
        /// <unmanaged-short>ERROR_BUFFER_OVERFLOW</unmanaged-short>
        BufferOverflow = unchecked((System.Int32)(111)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_FULL</unmanaged>
        /// <unmanaged-short>ERROR_DISK_FULL</unmanaged-short>
        DiskFull = unchecked((System.Int32)(112)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_MORE_SEARCH_HANDLES</unmanaged>
        /// <unmanaged-short>ERROR_NO_MORE_SEARCH_HANDLES</unmanaged-short>
        NoMoreSearchHandles = unchecked((System.Int32)(113)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_TARGET_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_TARGET_HANDLE</unmanaged-short>
        InvalidTargetHandle = unchecked((System.Int32)(114)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_CATEGORY</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_CATEGORY</unmanaged-short>
        InvalidCategory = unchecked((System.Int32)(117)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_VERIFY_SWITCH</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_VERIFY_SWITCH</unmanaged-short>
        InvalidVerifySwitch = unchecked((System.Int32)(118)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_DRIVER_LEVEL</unmanaged>
        /// <unmanaged-short>ERROR_BAD_DRIVER_LEVEL</unmanaged-short>
        BadDriverLevel = unchecked((System.Int32)(119)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CALL_NOT_IMPLEMENTED</unmanaged>
        /// <unmanaged-short>ERROR_CALL_NOT_IMPLEMENTED</unmanaged-short>
        CallNotImplemented = unchecked((System.Int32)(120)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SEM_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_SEM_TIMEOUT</unmanaged-short>
        SemTimeout = unchecked((System.Int32)(121)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSUFFICIENT_BUFFER</unmanaged>
        /// <unmanaged-short>ERROR_INSUFFICIENT_BUFFER</unmanaged-short>
        InsufficientBuffer = unchecked((System.Int32)(122)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_NAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_NAME</unmanaged-short>
        InvalidName = unchecked((System.Int32)(123)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LEVEL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LEVEL</unmanaged-short>
        InvalidLevel = unchecked((System.Int32)(124)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_VOLUME_LABEL</unmanaged>
        /// <unmanaged-short>ERROR_NO_VOLUME_LABEL</unmanaged-short>
        NoVolumeLabel = unchecked((System.Int32)(125)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MOD_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_MOD_NOT_FOUND</unmanaged-short>
        ModNotFound = unchecked((System.Int32)(126)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROC_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_PROC_NOT_FOUND</unmanaged-short>
        ProcNotFound = unchecked((System.Int32)(127)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAIT_NO_CHILDREN</unmanaged>
        /// <unmanaged-short>ERROR_WAIT_NO_CHILDREN</unmanaged-short>
        WaitNoChildren = unchecked((System.Int32)(128)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CHILD_NOT_COMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_CHILD_NOT_COMPLETE</unmanaged-short>
        ChildNotComplete = unchecked((System.Int32)(129)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIRECT_ACCESS_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_DIRECT_ACCESS_HANDLE</unmanaged-short>
        DirectAccessHandle = unchecked((System.Int32)(130)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NEGATIVE_SEEK</unmanaged>
        /// <unmanaged-short>ERROR_NEGATIVE_SEEK</unmanaged-short>
        NegativeSeek = unchecked((System.Int32)(131)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SEEK_ON_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_SEEK_ON_DEVICE</unmanaged-short>
        SeekOnDevice = unchecked((System.Int32)(132)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IS_JOIN_TARGET</unmanaged>
        /// <unmanaged-short>ERROR_IS_JOIN_TARGET</unmanaged-short>
        IsJoinTarget = unchecked((System.Int32)(133)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IS_JOINED</unmanaged>
        /// <unmanaged-short>ERROR_IS_JOINED</unmanaged-short>
        IsJoined = unchecked((System.Int32)(134)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IS_SUBSTED</unmanaged>
        /// <unmanaged-short>ERROR_IS_SUBSTED</unmanaged-short>
        IsSubsted = unchecked((System.Int32)(135)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_JOINED</unmanaged>
        /// <unmanaged-short>ERROR_NOT_JOINED</unmanaged-short>
        NotJoined = unchecked((System.Int32)(136)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SUBSTED</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SUBSTED</unmanaged-short>
        NotSubsted = unchecked((System.Int32)(137)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_JOIN_TO_JOIN</unmanaged>
        /// <unmanaged-short>ERROR_JOIN_TO_JOIN</unmanaged-short>
        JoinToJoin = unchecked((System.Int32)(138)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SUBST_TO_SUBST</unmanaged>
        /// <unmanaged-short>ERROR_SUBST_TO_SUBST</unmanaged-short>
        SubstToSubst = unchecked((System.Int32)(139)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_JOIN_TO_SUBST</unmanaged>
        /// <unmanaged-short>ERROR_JOIN_TO_SUBST</unmanaged-short>
        JoinToSubst = unchecked((System.Int32)(140)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SUBST_TO_JOIN</unmanaged>
        /// <unmanaged-short>ERROR_SUBST_TO_JOIN</unmanaged-short>
        SubstToJoin = unchecked((System.Int32)(141)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BUSY_DRIVE</unmanaged>
        /// <unmanaged-short>ERROR_BUSY_DRIVE</unmanaged-short>
        BusyDrive = unchecked((System.Int32)(142)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SAME_DRIVE</unmanaged>
        /// <unmanaged-short>ERROR_SAME_DRIVE</unmanaged-short>
        SameDrive = unchecked((System.Int32)(143)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIR_NOT_ROOT</unmanaged>
        /// <unmanaged-short>ERROR_DIR_NOT_ROOT</unmanaged-short>
        DirNotRoot = unchecked((System.Int32)(144)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIR_NOT_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_DIR_NOT_EMPTY</unmanaged-short>
        DirNotEmpty = unchecked((System.Int32)(145)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IS_SUBST_PATH</unmanaged>
        /// <unmanaged-short>ERROR_IS_SUBST_PATH</unmanaged-short>
        IsSubstPath = unchecked((System.Int32)(146)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IS_JOIN_PATH</unmanaged>
        /// <unmanaged-short>ERROR_IS_JOIN_PATH</unmanaged-short>
        IsJoinPath = unchecked((System.Int32)(147)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATH_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_PATH_BUSY</unmanaged-short>
        PathBusy = unchecked((System.Int32)(148)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IS_SUBST_TARGET</unmanaged>
        /// <unmanaged-short>ERROR_IS_SUBST_TARGET</unmanaged-short>
        IsSubstTarget = unchecked((System.Int32)(149)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_TRACE</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_TRACE</unmanaged-short>
        SystemTrace = unchecked((System.Int32)(150)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_EVENT_COUNT</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_EVENT_COUNT</unmanaged-short>
        InvalidEventCount = unchecked((System.Int32)(151)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_MUXWAITERS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_MUXWAITERS</unmanaged-short>
        TooManyMuxwaiters = unchecked((System.Int32)(152)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LIST_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LIST_FORMAT</unmanaged-short>
        InvalidListFormat = unchecked((System.Int32)(153)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LABEL_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_LABEL_TOO_LONG</unmanaged-short>
        LabelTooLong = unchecked((System.Int32)(154)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_TCBS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_TCBS</unmanaged-short>
        TooManyTcbs = unchecked((System.Int32)(155)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SIGNAL_REFUSED</unmanaged>
        /// <unmanaged-short>ERROR_SIGNAL_REFUSED</unmanaged-short>
        SignalRefused = unchecked((System.Int32)(156)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISCARDED</unmanaged>
        /// <unmanaged-short>ERROR_DISCARDED</unmanaged-short>
        Discarded = unchecked((System.Int32)(157)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_NOT_LOCKED</unmanaged-short>
        NotLocked = unchecked((System.Int32)(158)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_THREADID_ADDR</unmanaged>
        /// <unmanaged-short>ERROR_BAD_THREADID_ADDR</unmanaged-short>
        BadThreadidAddr = unchecked((System.Int32)(159)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_ARGUMENTS</unmanaged>
        /// <unmanaged-short>ERROR_BAD_ARGUMENTS</unmanaged-short>
        BadArguments = unchecked((System.Int32)(160)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_PATHNAME</unmanaged>
        /// <unmanaged-short>ERROR_BAD_PATHNAME</unmanaged-short>
        BadPathname = unchecked((System.Int32)(161)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SIGNAL_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_SIGNAL_PENDING</unmanaged-short>
        SignalPending = unchecked((System.Int32)(162)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MAX_THRDS_REACHED</unmanaged>
        /// <unmanaged-short>ERROR_MAX_THRDS_REACHED</unmanaged-short>
        MaxThrdsReached = unchecked((System.Int32)(164)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOCK_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_LOCK_FAILED</unmanaged-short>
        LockFailed = unchecked((System.Int32)(167)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_BUSY</unmanaged-short>
        Busy = unchecked((System.Int32)(170)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_SUPPORT_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_SUPPORT_IN_PROGRESS</unmanaged-short>
        DeviceSupportInProgress = unchecked((System.Int32)(171)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANCEL_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_CANCEL_VIOLATION</unmanaged-short>
        CancelViolation = unchecked((System.Int32)(173)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ATOMIC_LOCKS_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_ATOMIC_LOCKS_NOT_SUPPORTED</unmanaged-short>
        AtomicLocksNotSupported = unchecked((System.Int32)(174)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SEGMENT_NUMBER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SEGMENT_NUMBER</unmanaged-short>
        InvalidSegmentNumber = unchecked((System.Int32)(180)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ORDINAL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ORDINAL</unmanaged-short>
        InvalidOrdinal = unchecked((System.Int32)(182)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_EXISTS</unmanaged-short>
        AlreadyExists = unchecked((System.Int32)(183)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_FLAG_NUMBER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_FLAG_NUMBER</unmanaged-short>
        InvalidFlagNumber = unchecked((System.Int32)(186)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SEM_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SEM_NOT_FOUND</unmanaged-short>
        SemNotFound = unchecked((System.Int32)(187)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_STARTING_CODESEG</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_STARTING_CODESEG</unmanaged-short>
        InvalidStartingCodeseg = unchecked((System.Int32)(188)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_STACKSEG</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_STACKSEG</unmanaged-short>
        InvalidStackseg = unchecked((System.Int32)(189)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MODULETYPE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MODULETYPE</unmanaged-short>
        InvalidModuletype = unchecked((System.Int32)(190)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_EXE_SIGNATURE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_EXE_SIGNATURE</unmanaged-short>
        InvalidExeSignature = unchecked((System.Int32)(191)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXE_MARKED_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_EXE_MARKED_INVALID</unmanaged-short>
        ExeMarkedInvalid = unchecked((System.Int32)(192)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_EXE_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_BAD_EXE_FORMAT</unmanaged-short>
        BadExeFormat = unchecked((System.Int32)(193)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ITERATED_DATA_EXCEEDS_64k</unmanaged>
        /// <unmanaged-short>ERROR_ITERATED_DATA_EXCEEDS_64k</unmanaged-short>
        IteratedDataExceeds64k = unchecked((System.Int32)(194)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MINALLOCSIZE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MINALLOCSIZE</unmanaged-short>
        InvalidMinallocsize = unchecked((System.Int32)(195)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DYNLINK_FROM_INVALID_RING</unmanaged>
        /// <unmanaged-short>ERROR_DYNLINK_FROM_INVALID_RING</unmanaged-short>
        DynlinkFromInvalidRing = unchecked((System.Int32)(196)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IOPL_NOT_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_IOPL_NOT_ENABLED</unmanaged-short>
        IoplNotEnabled = unchecked((System.Int32)(197)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SEGDPL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SEGDPL</unmanaged-short>
        InvalidSegdpl = unchecked((System.Int32)(198)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_AUTODATASEG_EXCEEDS_64k</unmanaged>
        /// <unmanaged-short>ERROR_AUTODATASEG_EXCEEDS_64k</unmanaged-short>
        AutodatasegExceeds64k = unchecked((System.Int32)(199)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RING2SEG_MUST_BE_MOVABLE</unmanaged>
        /// <unmanaged-short>ERROR_RING2SEG_MUST_BE_MOVABLE</unmanaged-short>
        Ring2segMustBeMovable = unchecked((System.Int32)(200)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RELOC_CHAIN_XEEDS_SEGLIM</unmanaged>
        /// <unmanaged-short>ERROR_RELOC_CHAIN_XEEDS_SEGLIM</unmanaged-short>
        RelocChainXeedsSeglim = unchecked((System.Int32)(201)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INFLOOP_IN_RELOC_CHAIN</unmanaged>
        /// <unmanaged-short>ERROR_INFLOOP_IN_RELOC_CHAIN</unmanaged-short>
        InfloopInRelocChain = unchecked((System.Int32)(202)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENVVAR_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_ENVVAR_NOT_FOUND</unmanaged-short>
        EnvvarNotFound = unchecked((System.Int32)(203)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SIGNAL_SENT</unmanaged>
        /// <unmanaged-short>ERROR_NO_SIGNAL_SENT</unmanaged-short>
        NoSignalSent = unchecked((System.Int32)(205)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILENAME_EXCED_RANGE</unmanaged>
        /// <unmanaged-short>ERROR_FILENAME_EXCED_RANGE</unmanaged-short>
        FilenameExcedRange = unchecked((System.Int32)(206)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RING2_STACK_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_RING2_STACK_IN_USE</unmanaged-short>
        Ring2StackInUse = unchecked((System.Int32)(207)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_META_EXPANSION_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_META_EXPANSION_TOO_LONG</unmanaged-short>
        MetaExpansionTooLong = unchecked((System.Int32)(208)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SIGNAL_NUMBER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SIGNAL_NUMBER</unmanaged-short>
        InvalidSignalNumber = unchecked((System.Int32)(209)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_THREAD_1_INACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_THREAD_1_INACTIVE</unmanaged-short>
        Thread1Inactive = unchecked((System.Int32)(210)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_LOCKED</unmanaged-short>
        Locked = unchecked((System.Int32)(212)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_MODULES</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_MODULES</unmanaged-short>
        TooManyModules = unchecked((System.Int32)(214)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NESTING_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_NESTING_NOT_ALLOWED</unmanaged-short>
        NestingNotAllowed = unchecked((System.Int32)(215)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXE_MACHINE_TYPE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_EXE_MACHINE_TYPE_MISMATCH</unmanaged-short>
        ExeMachineTypeMismatch = unchecked((System.Int32)(216)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY</unmanaged>
        /// <unmanaged-short>ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY</unmanaged-short>
        ExeCannotModifySignedBinary = unchecked((System.Int32)(217)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY</unmanaged>
        /// <unmanaged-short>ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY</unmanaged-short>
        ExeCannotModifyStrongSignedBinary = unchecked((System.Int32)(218)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_CHECKED_OUT</unmanaged>
        /// <unmanaged-short>ERROR_FILE_CHECKED_OUT</unmanaged-short>
        FileCheckedOut = unchecked((System.Int32)(220)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CHECKOUT_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_CHECKOUT_REQUIRED</unmanaged-short>
        CheckoutRequired = unchecked((System.Int32)(221)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_FILE_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_FILE_TYPE</unmanaged-short>
        BadFileType = unchecked((System.Int32)(222)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_TOO_LARGE</unmanaged>
        /// <unmanaged-short>ERROR_FILE_TOO_LARGE</unmanaged-short>
        FileTooLarge = unchecked((System.Int32)(223)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FORMS_AUTH_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_FORMS_AUTH_REQUIRED</unmanaged-short>
        FormsAuthRequired = unchecked((System.Int32)(224)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VIRUS_INFECTED</unmanaged>
        /// <unmanaged-short>ERROR_VIRUS_INFECTED</unmanaged-short>
        VirusInfected = unchecked((System.Int32)(225)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VIRUS_DELETED</unmanaged>
        /// <unmanaged-short>ERROR_VIRUS_DELETED</unmanaged-short>
        VirusDeleted = unchecked((System.Int32)(226)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PIPE_LOCAL</unmanaged>
        /// <unmanaged-short>ERROR_PIPE_LOCAL</unmanaged-short>
        PipeLocal = unchecked((System.Int32)(229)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_PIPE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_PIPE</unmanaged-short>
        BadPipe = unchecked((System.Int32)(230)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PIPE_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_PIPE_BUSY</unmanaged-short>
        PipeBusy = unchecked((System.Int32)(231)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_DATA</unmanaged>
        /// <unmanaged-short>ERROR_NO_DATA</unmanaged-short>
        NoData = unchecked((System.Int32)(232)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PIPE_NOT_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_PIPE_NOT_CONNECTED</unmanaged-short>
        PipeNotConnected = unchecked((System.Int32)(233)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MORE_DATA</unmanaged>
        /// <unmanaged-short>ERROR_MORE_DATA</unmanaged-short>
        MoreData = unchecked((System.Int32)(234)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_WORK_DONE</unmanaged>
        /// <unmanaged-short>ERROR_NO_WORK_DONE</unmanaged-short>
        NoWorkDone = unchecked((System.Int32)(235)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VC_DISCONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_VC_DISCONNECTED</unmanaged-short>
        VcDisconnected = unchecked((System.Int32)(240)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_EA_NAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_EA_NAME</unmanaged-short>
        InvalidEaName = unchecked((System.Int32)(254)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EA_LIST_INCONSISTENT</unmanaged>
        /// <unmanaged-short>ERROR_EA_LIST_INCONSISTENT</unmanaged-short>
        EaListInconsistent = unchecked((System.Int32)(255)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_MORE_ITEMS</unmanaged>
        /// <unmanaged-short>ERROR_NO_MORE_ITEMS</unmanaged-short>
        NoMoreItems = unchecked((System.Int32)(259)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_COPY</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_COPY</unmanaged-short>
        CannotCopy = unchecked((System.Int32)(266)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIRECTORY</unmanaged>
        /// <unmanaged-short>ERROR_DIRECTORY</unmanaged-short>
        Directory = unchecked((System.Int32)(267)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EAS_DIDNT_FIT</unmanaged>
        /// <unmanaged-short>ERROR_EAS_DIDNT_FIT</unmanaged-short>
        EasDidntFit = unchecked((System.Int32)(275)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EA_FILE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_EA_FILE_CORRUPT</unmanaged-short>
        EaFileCorrupt = unchecked((System.Int32)(276)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EA_TABLE_FULL</unmanaged>
        /// <unmanaged-short>ERROR_EA_TABLE_FULL</unmanaged-short>
        EaTableFull = unchecked((System.Int32)(277)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_EA_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_EA_HANDLE</unmanaged-short>
        InvalidEaHandle = unchecked((System.Int32)(278)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EAS_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_EAS_NOT_SUPPORTED</unmanaged-short>
        EasNotSupported = unchecked((System.Int32)(282)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_OWNER</unmanaged>
        /// <unmanaged-short>ERROR_NOT_OWNER</unmanaged-short>
        NotOwner = unchecked((System.Int32)(288)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_POSTS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_POSTS</unmanaged-short>
        TooManyPosts = unchecked((System.Int32)(298)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PARTIAL_COPY</unmanaged>
        /// <unmanaged-short>ERROR_PARTIAL_COPY</unmanaged-short>
        PartialCopy = unchecked((System.Int32)(299)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPLOCK_NOT_GRANTED</unmanaged>
        /// <unmanaged-short>ERROR_OPLOCK_NOT_GRANTED</unmanaged-short>
        OplockNotGranted = unchecked((System.Int32)(300)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_OPLOCK_PROTOCOL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_OPLOCK_PROTOCOL</unmanaged-short>
        InvalidOplockProtocol = unchecked((System.Int32)(301)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_TOO_FRAGMENTED</unmanaged>
        /// <unmanaged-short>ERROR_DISK_TOO_FRAGMENTED</unmanaged-short>
        DiskTooFragmented = unchecked((System.Int32)(302)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DELETE_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_DELETE_PENDING</unmanaged-short>
        DeletePending = unchecked((System.Int32)(303)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING</unmanaged>
        /// <unmanaged-short>ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING</unmanaged-short>
        IncompatibleWithGlobalShortNameRegistrySetting = unchecked((System.Int32)(304)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME</unmanaged-short>
        ShortNamesNotEnabledOnVolume = unchecked((System.Int32)(305)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECURITY_STREAM_IS_INCONSISTENT</unmanaged>
        /// <unmanaged-short>ERROR_SECURITY_STREAM_IS_INCONSISTENT</unmanaged-short>
        SecurityStreamIsInconsistent = unchecked((System.Int32)(306)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LOCK_RANGE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LOCK_RANGE</unmanaged-short>
        InvalidLockRange = unchecked((System.Int32)(307)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT</unmanaged-short>
        ImageSubsystemNotPresent = unchecked((System.Int32)(308)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOTIFICATION_GUID_ALREADY_DEFINED</unmanaged>
        /// <unmanaged-short>ERROR_NOTIFICATION_GUID_ALREADY_DEFINED</unmanaged-short>
        NotificationGuidAlreadyDefined = unchecked((System.Int32)(309)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_EXCEPTION_HANDLER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_EXCEPTION_HANDLER</unmanaged-short>
        InvalidExceptionHandler = unchecked((System.Int32)(310)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DUPLICATE_PRIVILEGES</unmanaged>
        /// <unmanaged-short>ERROR_DUPLICATE_PRIVILEGES</unmanaged-short>
        DuplicatePrivileges = unchecked((System.Int32)(311)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_RANGES_PROCESSED</unmanaged>
        /// <unmanaged-short>ERROR_NO_RANGES_PROCESSED</unmanaged-short>
        NoRangesProcessed = unchecked((System.Int32)(312)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_ALLOWED_ON_SYSTEM_FILE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_ALLOWED_ON_SYSTEM_FILE</unmanaged-short>
        NotAllowedOnSystemFile = unchecked((System.Int32)(313)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_RESOURCES_EXHAUSTED</unmanaged>
        /// <unmanaged-short>ERROR_DISK_RESOURCES_EXHAUSTED</unmanaged-short>
        DiskResourcesExhausted = unchecked((System.Int32)(314)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_TOKEN</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_TOKEN</unmanaged-short>
        InvalidToken = unchecked((System.Int32)(315)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_FEATURE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_FEATURE_NOT_SUPPORTED</unmanaged-short>
        DeviceFeatureNotSupported = unchecked((System.Int32)(316)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MR_MID_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_MR_MID_NOT_FOUND</unmanaged-short>
        MrMidNotFound = unchecked((System.Int32)(317)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SCOPE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SCOPE_NOT_FOUND</unmanaged-short>
        ScopeNotFound = unchecked((System.Int32)(318)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNDEFINED_SCOPE</unmanaged>
        /// <unmanaged-short>ERROR_UNDEFINED_SCOPE</unmanaged-short>
        UndefinedScope = unchecked((System.Int32)(319)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_CAP</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_CAP</unmanaged-short>
        InvalidCap = unchecked((System.Int32)(320)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_UNREACHABLE</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_UNREACHABLE</unmanaged-short>
        DeviceUnreachable = unchecked((System.Int32)(321)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_NO_RESOURCES</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_NO_RESOURCES</unmanaged-short>
        DeviceNoResources = unchecked((System.Int32)(322)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DATA_CHECKSUM_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DATA_CHECKSUM_ERROR</unmanaged-short>
        DataChecksumError = unchecked((System.Int32)(323)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INTERMIXED_KERNEL_EA_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_INTERMIXED_KERNEL_EA_OPERATION</unmanaged-short>
        IntermixedKernelEaOperation = unchecked((System.Int32)(324)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED</unmanaged-short>
        FileLevelTrimNotSupported = unchecked((System.Int32)(326)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OFFSET_ALIGNMENT_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_OFFSET_ALIGNMENT_VIOLATION</unmanaged-short>
        OffsetAlignmentViolation = unchecked((System.Int32)(327)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_FIELD_IN_PARAMETER_LIST</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_FIELD_IN_PARAMETER_LIST</unmanaged-short>
        InvalidFieldInParameterList = unchecked((System.Int32)(328)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPERATION_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_OPERATION_IN_PROGRESS</unmanaged-short>
        OperationInProgress = unchecked((System.Int32)(329)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_DEVICE_PATH</unmanaged>
        /// <unmanaged-short>ERROR_BAD_DEVICE_PATH</unmanaged-short>
        BadDevicePath = unchecked((System.Int32)(330)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_DESCRIPTORS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_DESCRIPTORS</unmanaged-short>
        TooManyDescriptors = unchecked((System.Int32)(331)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SCRUB_DATA_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_SCRUB_DATA_DISABLED</unmanaged-short>
        ScrubDataDisabled = unchecked((System.Int32)(332)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_REDUNDANT_STORAGE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_REDUNDANT_STORAGE</unmanaged-short>
        NotRedundantStorage = unchecked((System.Int32)(333)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESIDENT_FILE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_RESIDENT_FILE_NOT_SUPPORTED</unmanaged-short>
        ResidentFileNotSupported = unchecked((System.Int32)(334)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COMPRESSED_FILE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_COMPRESSED_FILE_NOT_SUPPORTED</unmanaged-short>
        CompressedFileNotSupported = unchecked((System.Int32)(335)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIRECTORY_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_DIRECTORY_NOT_SUPPORTED</unmanaged-short>
        DirectoryNotSupported = unchecked((System.Int32)(336)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_READ_FROM_COPY</unmanaged>
        /// <unmanaged-short>ERROR_NOT_READ_FROM_COPY</unmanaged-short>
        NotReadFromCopy = unchecked((System.Int32)(337)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FT_WRITE_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_FT_WRITE_FAILURE</unmanaged-short>
        FtWriteFailure = unchecked((System.Int32)(338)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FT_DI_SCAN_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_FT_DI_SCAN_REQUIRED</unmanaged-short>
        FtDiScanRequired = unchecked((System.Int32)(339)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_KERNEL_INFO_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_KERNEL_INFO_VERSION</unmanaged-short>
        InvalidKernelInfoVersion = unchecked((System.Int32)(340)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PEP_INFO_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PEP_INFO_VERSION</unmanaged-short>
        InvalidPepInfoVersion = unchecked((System.Int32)(341)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OBJECT_NOT_EXTERNALLY_BACKED</unmanaged>
        /// <unmanaged-short>ERROR_OBJECT_NOT_EXTERNALLY_BACKED</unmanaged-short>
        ObjectNotExternallyBacked = unchecked((System.Int32)(342)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXTERNAL_BACKING_PROVIDER_UNKNOWN</unmanaged>
        /// <unmanaged-short>ERROR_EXTERNAL_BACKING_PROVIDER_UNKNOWN</unmanaged-short>
        ExternalBackingProviderUnknown = unchecked((System.Int32)(343)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COMPRESSION_NOT_BENEFICIAL</unmanaged>
        /// <unmanaged-short>ERROR_COMPRESSION_NOT_BENEFICIAL</unmanaged-short>
        CompressionNotBeneficial = unchecked((System.Int32)(344)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STORAGE_TOPOLOGY_ID_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_STORAGE_TOPOLOGY_ID_MISMATCH</unmanaged-short>
        StorageTopologyIdMismatch = unchecked((System.Int32)(345)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BLOCKED_BY_PARENTAL_CONTROLS</unmanaged>
        /// <unmanaged-short>ERROR_BLOCKED_BY_PARENTAL_CONTROLS</unmanaged-short>
        BlockedByParentalControls = unchecked((System.Int32)(346)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BLOCK_TOO_MANY_REFERENCES</unmanaged>
        /// <unmanaged-short>ERROR_BLOCK_TOO_MANY_REFERENCES</unmanaged-short>
        BlockTooManyReferences = unchecked((System.Int32)(347)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MARKED_TO_DISALLOW_WRITES</unmanaged>
        /// <unmanaged-short>ERROR_MARKED_TO_DISALLOW_WRITES</unmanaged-short>
        MarkedToDisallowWrites = unchecked((System.Int32)(348)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENCLAVE_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_ENCLAVE_FAILURE</unmanaged-short>
        EnclaveFailure = unchecked((System.Int32)(349)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAIL_NOACTION_REBOOT</unmanaged>
        /// <unmanaged-short>ERROR_FAIL_NOACTION_REBOOT</unmanaged-short>
        FailNoactionReboot = unchecked((System.Int32)(350)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAIL_SHUTDOWN</unmanaged>
        /// <unmanaged-short>ERROR_FAIL_SHUTDOWN</unmanaged-short>
        FailShutdown = unchecked((System.Int32)(351)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAIL_RESTART</unmanaged>
        /// <unmanaged-short>ERROR_FAIL_RESTART</unmanaged-short>
        FailRestart = unchecked((System.Int32)(352)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MAX_SESSIONS_REACHED</unmanaged>
        /// <unmanaged-short>ERROR_MAX_SESSIONS_REACHED</unmanaged-short>
        MaxSessionsReached = unchecked((System.Int32)(353)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NETWORK_ACCESS_DENIED_EDP</unmanaged>
        /// <unmanaged-short>ERROR_NETWORK_ACCESS_DENIED_EDP</unmanaged-short>
        NetworkAccessDeniedEdp = unchecked((System.Int32)(354)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_HINT_NAME_BUFFER_TOO_SMALL</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_HINT_NAME_BUFFER_TOO_SMALL</unmanaged-short>
        DeviceHintNameBufferTooSmall = unchecked((System.Int32)(355)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EDP_POLICY_DENIES_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_EDP_POLICY_DENIES_OPERATION</unmanaged-short>
        EdpPolicyDeniesOperation = unchecked((System.Int32)(356)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EDP_DPL_POLICY_CANT_BE_SATISFIED</unmanaged>
        /// <unmanaged-short>ERROR_EDP_DPL_POLICY_CANT_BE_SATISFIED</unmanaged-short>
        EdpDplPolicyCantBeSatisfied = unchecked((System.Int32)(357)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT</unmanaged-short>
        CloudFileSyncRootMetadataCorrupt = unchecked((System.Int32)(358)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_IN_MAINTENANCE</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_IN_MAINTENANCE</unmanaged-short>
        DeviceInMaintenance = unchecked((System.Int32)(359)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SUPPORTED_ON_DAX</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SUPPORTED_ON_DAX</unmanaged-short>
        NotSupportedOnDax = unchecked((System.Int32)(360)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DAX_MAPPING_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DAX_MAPPING_EXISTS</unmanaged-short>
        DaxMappingExists = unchecked((System.Int32)(361)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_PROVIDER_NOT_RUNNING</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_PROVIDER_NOT_RUNNING</unmanaged-short>
        CloudFileProviderNotRunning = unchecked((System.Int32)(362)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_METADATA_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_METADATA_CORRUPT</unmanaged-short>
        CloudFileMetadataCorrupt = unchecked((System.Int32)(363)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_METADATA_TOO_LARGE</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_METADATA_TOO_LARGE</unmanaged-short>
        CloudFileMetadataTooLarge = unchecked((System.Int32)(364)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE</unmanaged-short>
        CloudFilePropertyBlobTooLarge = unchecked((System.Int32)(365)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH</unmanaged-short>
        CloudFilePropertyBlobChecksumMismatch = unchecked((System.Int32)(366)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CHILD_PROCESS_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_CHILD_PROCESS_BLOCKED</unmanaged-short>
        ChildProcessBlocked = unchecked((System.Int32)(367)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STORAGE_LOST_DATA_PERSISTENCE</unmanaged>
        /// <unmanaged-short>ERROR_STORAGE_LOST_DATA_PERSISTENCE</unmanaged-short>
        StorageLostDataPersistence = unchecked((System.Int32)(368)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE</unmanaged-short>
        FileSystemVirtualizationUnavailable = unchecked((System.Int32)(369)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT</unmanaged-short>
        FileSystemVirtualizationMetadataCorrupt = unchecked((System.Int32)(370)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_SYSTEM_VIRTUALIZATION_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_FILE_SYSTEM_VIRTUALIZATION_BUSY</unmanaged-short>
        FileSystemVirtualizationBusy = unchecked((System.Int32)(371)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN</unmanaged>
        /// <unmanaged-short>ERROR_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN</unmanaged-short>
        FileSystemVirtualizationProviderUnknown = unchecked((System.Int32)(372)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GDI_HANDLE_LEAK</unmanaged>
        /// <unmanaged-short>ERROR_GDI_HANDLE_LEAK</unmanaged-short>
        GdiHandleLeak = unchecked((System.Int32)(373)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS</unmanaged-short>
        CloudFileTooManyPropertyBlobs = unchecked((System.Int32)(374)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED</unmanaged-short>
        CloudFilePropertyVersionNotSupported = unchecked((System.Int32)(375)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_A_CLOUD_FILE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_A_CLOUD_FILE</unmanaged-short>
        NotACloudFile = unchecked((System.Int32)(376)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_NOT_IN_SYNC</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_NOT_IN_SYNC</unmanaged-short>
        CloudFileNotInSync = unchecked((System.Int32)(377)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_ALREADY_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_ALREADY_CONNECTED</unmanaged-short>
        CloudFileAlreadyConnected = unchecked((System.Int32)(378)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_NOT_SUPPORTED</unmanaged-short>
        CloudFileNotSupported = unchecked((System.Int32)(379)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_INVALID_REQUEST</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_INVALID_REQUEST</unmanaged-short>
        CloudFileInvalidRequest = unchecked((System.Int32)(380)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_READ_ONLY_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_READ_ONLY_VOLUME</unmanaged-short>
        CloudFileReadOnlyVolume = unchecked((System.Int32)(381)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_CONNECTED_PROVIDER_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_CONNECTED_PROVIDER_ONLY</unmanaged-short>
        CloudFileConnectedProviderOnly = unchecked((System.Int32)(382)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_VALIDATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_VALIDATION_FAILED</unmanaged-short>
        CloudFileValidationFailed = unchecked((System.Int32)(383)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SMB1_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_SMB1_NOT_AVAILABLE</unmanaged-short>
        Smb1NotAvailable = unchecked((System.Int32)(384)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION</unmanaged-short>
        FileSystemVirtualizationInvalidOperation = unchecked((System.Int32)(385)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_AUTHENTICATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_AUTHENTICATION_FAILED</unmanaged-short>
        CloudFileAuthenticationFailed = unchecked((System.Int32)(386)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_INSUFFICIENT_RESOURCES</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_INSUFFICIENT_RESOURCES</unmanaged-short>
        CloudFileInsufficientResources = unchecked((System.Int32)(387)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_NETWORK_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_NETWORK_UNAVAILABLE</unmanaged-short>
        CloudFileNetworkUnavailable = unchecked((System.Int32)(388)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_UNSUCCESSFUL</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_UNSUCCESSFUL</unmanaged-short>
        CloudFileUnsuccessful = unchecked((System.Int32)(389)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_NOT_UNDER_SYNC_ROOT</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_NOT_UNDER_SYNC_ROOT</unmanaged-short>
        CloudFileNotUnderSyncRoot = unchecked((System.Int32)(390)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_IN_USE</unmanaged-short>
        CloudFileInUse = unchecked((System.Int32)(391)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_PINNED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_PINNED</unmanaged-short>
        CloudFilePinned = unchecked((System.Int32)(392)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_REQUEST_ABORTED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_REQUEST_ABORTED</unmanaged-short>
        CloudFileRequestAborted = unchecked((System.Int32)(393)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_PROPERTY_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_PROPERTY_CORRUPT</unmanaged-short>
        CloudFilePropertyCorrupt = unchecked((System.Int32)(394)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_ACCESS_DENIED</unmanaged-short>
        CloudFileAccessDenied = unchecked((System.Int32)(395)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_INCOMPATIBLE_HARDLINKS</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_INCOMPATIBLE_HARDLINKS</unmanaged-short>
        CloudFileIncompatibleHardlinks = unchecked((System.Int32)(396)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_PROPERTY_LOCK_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_PROPERTY_LOCK_CONFLICT</unmanaged-short>
        CloudFilePropertyLockConflict = unchecked((System.Int32)(397)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_REQUEST_CANCELED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_REQUEST_CANCELED</unmanaged-short>
        CloudFileRequestCanceled = unchecked((System.Int32)(398)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXTERNAL_SYSKEY_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_EXTERNAL_SYSKEY_NOT_SUPPORTED</unmanaged-short>
        ExternalSyskeyNotSupported = unchecked((System.Int32)(399)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_THREAD_MODE_ALREADY_BACKGROUND</unmanaged>
        /// <unmanaged-short>ERROR_THREAD_MODE_ALREADY_BACKGROUND</unmanaged-short>
        ThreadModeAlreadyBackground = unchecked((System.Int32)(400)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_THREAD_MODE_NOT_BACKGROUND</unmanaged>
        /// <unmanaged-short>ERROR_THREAD_MODE_NOT_BACKGROUND</unmanaged-short>
        ThreadModeNotBackground = unchecked((System.Int32)(401)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROCESS_MODE_ALREADY_BACKGROUND</unmanaged>
        /// <unmanaged-short>ERROR_PROCESS_MODE_ALREADY_BACKGROUND</unmanaged-short>
        ProcessModeAlreadyBackground = unchecked((System.Int32)(402)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROCESS_MODE_NOT_BACKGROUND</unmanaged>
        /// <unmanaged-short>ERROR_PROCESS_MODE_NOT_BACKGROUND</unmanaged-short>
        ProcessModeNotBackground = unchecked((System.Int32)(403)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLOUD_FILE_PROVIDER_TERMINATED</unmanaged>
        /// <unmanaged-short>ERROR_CLOUD_FILE_PROVIDER_TERMINATED</unmanaged-short>
        CloudFileProviderTerminated = unchecked((System.Int32)(404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_A_CLOUD_SYNC_ROOT</unmanaged>
        /// <unmanaged-short>ERROR_NOT_A_CLOUD_SYNC_ROOT</unmanaged-short>
        NotACloudSyncRoot = unchecked((System.Int32)(405)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_PROTECTED_UNDER_DPL</unmanaged>
        /// <unmanaged-short>ERROR_FILE_PROTECTED_UNDER_DPL</unmanaged-short>
        FileProtectedUnderDpl = unchecked((System.Int32)(406)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLUME_NOT_CLUSTER_ALIGNED</unmanaged>
        /// <unmanaged-short>ERROR_VOLUME_NOT_CLUSTER_ALIGNED</unmanaged-short>
        VolumeNotClusterAligned = unchecked((System.Int32)(407)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND</unmanaged-short>
        NoPhysicallyAlignedFreeSpaceFound = unchecked((System.Int32)(408)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPX_FILE_NOT_ENCRYPTED</unmanaged>
        /// <unmanaged-short>ERROR_APPX_FILE_NOT_ENCRYPTED</unmanaged-short>
        AppxFileNotEncrypted = unchecked((System.Int32)(409)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED</unmanaged>
        /// <unmanaged-short>ERROR_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED</unmanaged-short>
        RwrawEncryptedFileNotEncrypted = unchecked((System.Int32)(410)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET</unmanaged>
        /// <unmanaged-short>ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET</unmanaged-short>
        RwrawEncryptedInvalidEdatainfoFileoffset = unchecked((System.Int32)(411)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE</unmanaged>
        /// <unmanaged-short>ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE</unmanaged-short>
        RwrawEncryptedInvalidEdatainfoFilerange = unchecked((System.Int32)(412)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER</unmanaged>
        /// <unmanaged-short>ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER</unmanaged-short>
        RwrawEncryptedInvalidEdatainfoParameter = unchecked((System.Int32)(413)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LINUX_SUBSYSTEM_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_LINUX_SUBSYSTEM_NOT_PRESENT</unmanaged-short>
        LinuxSubsystemNotPresent = unchecked((System.Int32)(414)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FT_READ_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_FT_READ_FAILURE</unmanaged-short>
        FtReadFailure = unchecked((System.Int32)(415)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STORAGE_RESERVE_ID_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_STORAGE_RESERVE_ID_INVALID</unmanaged-short>
        StorageReserveIdInvalid = unchecked((System.Int32)(416)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STORAGE_RESERVE_DOES_NOT_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_STORAGE_RESERVE_DOES_NOT_EXIST</unmanaged-short>
        StorageReserveDoesNotExist = unchecked((System.Int32)(417)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STORAGE_RESERVE_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_STORAGE_RESERVE_ALREADY_EXISTS</unmanaged-short>
        StorageReserveAlreadyExists = unchecked((System.Int32)(418)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STORAGE_RESERVE_NOT_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_STORAGE_RESERVE_NOT_EMPTY</unmanaged-short>
        StorageReserveNotEmpty = unchecked((System.Int32)(419)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_A_DAX_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_NOT_A_DAX_VOLUME</unmanaged-short>
        NotADaxVolume = unchecked((System.Int32)(420)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_DAX_MAPPABLE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_DAX_MAPPABLE</unmanaged-short>
        NotDaxMappable = unchecked((System.Int32)(421)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIME_CRITICAL_THREAD</unmanaged>
        /// <unmanaged-short>ERROR_TIME_CRITICAL_THREAD</unmanaged-short>
        TimeCriticalThread = unchecked((System.Int32)(422)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DPL_NOT_SUPPORTED_FOR_USER</unmanaged>
        /// <unmanaged-short>ERROR_DPL_NOT_SUPPORTED_FOR_USER</unmanaged-short>
        DplNotSupportedForUser = unchecked((System.Int32)(423)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CASE_DIFFERING_NAMES_IN_DIR</unmanaged>
        /// <unmanaged-short>ERROR_CASE_DIFFERING_NAMES_IN_DIR</unmanaged-short>
        CaseDifferingNamesInDir = unchecked((System.Int32)(424)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_NOT_DEVUNLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_NOT_DEVUNLOCKED</unmanaged-short>
        CapauthzNotDevunlocked = unchecked((System.Int32)(450)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_CHANGE_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_CHANGE_TYPE</unmanaged-short>
        CapauthzChangeType = unchecked((System.Int32)(451)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_NOT_PROVISIONED</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_NOT_PROVISIONED</unmanaged-short>
        CapauthzNotProvisioned = unchecked((System.Int32)(452)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_NOT_AUTHORIZED</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_NOT_AUTHORIZED</unmanaged-short>
        CapauthzNotAuthorized = unchecked((System.Int32)(453)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_NO_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_NO_POLICY</unmanaged-short>
        CapauthzNoPolicy = unchecked((System.Int32)(454)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_DB_CORRUPTED</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_DB_CORRUPTED</unmanaged-short>
        CapauthzDbCorrupted = unchecked((System.Int32)(455)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_SCCD_INVALID_CATALOG</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_SCCD_INVALID_CATALOG</unmanaged-short>
        CapauthzSccdInvalidCatalog = unchecked((System.Int32)(456)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_SCCD_NO_AUTH_ENTITY</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_SCCD_NO_AUTH_ENTITY</unmanaged-short>
        CapauthzSccdNoAuthEntity = unchecked((System.Int32)(457)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_SCCD_PARSE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_SCCD_PARSE_ERROR</unmanaged-short>
        CapauthzSccdParseError = unchecked((System.Int32)(458)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_SCCD_DEV_MODE_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_SCCD_DEV_MODE_REQUIRED</unmanaged-short>
        CapauthzSccdDevModeRequired = unchecked((System.Int32)(459)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAPAUTHZ_SCCD_NO_CAPABILITY_MATCH</unmanaged>
        /// <unmanaged-short>ERROR_CAPAUTHZ_SCCD_NO_CAPABILITY_MATCH</unmanaged-short>
        CapauthzSccdNoCapabilityMatch = unchecked((System.Int32)(460)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_QUERY_REMOVE_DEVICE_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_PNP_QUERY_REMOVE_DEVICE_TIMEOUT</unmanaged-short>
        PnpQueryRemoveDeviceTimeout = unchecked((System.Int32)(480)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_QUERY_REMOVE_RELATED_DEVICE_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_PNP_QUERY_REMOVE_RELATED_DEVICE_TIMEOUT</unmanaged-short>
        PnpQueryRemoveRelatedDeviceTimeout = unchecked((System.Int32)(481)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_QUERY_REMOVE_UNRELATED_DEVICE_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_PNP_QUERY_REMOVE_UNRELATED_DEVICE_TIMEOUT</unmanaged-short>
        PnpQueryRemoveUnrelatedDeviceTimeout = unchecked((System.Int32)(482)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_HARDWARE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_HARDWARE_ERROR</unmanaged-short>
        DeviceHardwareError = unchecked((System.Int32)(483)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ADDRESS</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ADDRESS</unmanaged-short>
        InvalidAddress = unchecked((System.Int32)(487)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VRF_CFG_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_VRF_CFG_ENABLED</unmanaged-short>
        VrfCfgEnabled = unchecked((System.Int32)(1183)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PARTITION_TERMINATING</unmanaged>
        /// <unmanaged-short>ERROR_PARTITION_TERMINATING</unmanaged-short>
        PartitionTerminating = unchecked((System.Int32)(1184)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_USER_PROFILE_LOAD</unmanaged>
        /// <unmanaged-short>ERROR_USER_PROFILE_LOAD</unmanaged-short>
        UserProfileLoad = unchecked((System.Int32)(500)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ARITHMETIC_OVERFLOW</unmanaged>
        /// <unmanaged-short>ERROR_ARITHMETIC_OVERFLOW</unmanaged-short>
        ArithmeticOverflow = unchecked((System.Int32)(534)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PIPE_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_PIPE_CONNECTED</unmanaged-short>
        PipeConnected = unchecked((System.Int32)(535)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PIPE_LISTENING</unmanaged>
        /// <unmanaged-short>ERROR_PIPE_LISTENING</unmanaged-short>
        PipeListening = unchecked((System.Int32)(536)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VERIFIER_STOP</unmanaged>
        /// <unmanaged-short>ERROR_VERIFIER_STOP</unmanaged-short>
        VerifierStop = unchecked((System.Int32)(537)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ABIOS_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_ABIOS_ERROR</unmanaged-short>
        AbiosError = unchecked((System.Int32)(538)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WX86_WARNING</unmanaged>
        /// <unmanaged-short>ERROR_WX86_WARNING</unmanaged-short>
        Wx86Warning = unchecked((System.Int32)(539)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WX86_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_WX86_ERROR</unmanaged-short>
        Wx86Error = unchecked((System.Int32)(540)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIMER_NOT_CANCELED</unmanaged>
        /// <unmanaged-short>ERROR_TIMER_NOT_CANCELED</unmanaged-short>
        TimerNotCanceled = unchecked((System.Int32)(541)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNWIND</unmanaged>
        /// <unmanaged-short>ERROR_UNWIND</unmanaged-short>
        Unwind = unchecked((System.Int32)(542)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_STACK</unmanaged>
        /// <unmanaged-short>ERROR_BAD_STACK</unmanaged-short>
        BadStack = unchecked((System.Int32)(543)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_UNWIND_TARGET</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_UNWIND_TARGET</unmanaged-short>
        InvalidUnwindTarget = unchecked((System.Int32)(544)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PORT_ATTRIBUTES</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PORT_ATTRIBUTES</unmanaged-short>
        InvalidPortAttributes = unchecked((System.Int32)(545)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PORT_MESSAGE_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_PORT_MESSAGE_TOO_LONG</unmanaged-short>
        PortMessageTooLong = unchecked((System.Int32)(546)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_QUOTA_LOWER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_QUOTA_LOWER</unmanaged-short>
        InvalidQuotaLower = unchecked((System.Int32)(547)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_ALREADY_ATTACHED</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_ALREADY_ATTACHED</unmanaged-short>
        DeviceAlreadyAttached = unchecked((System.Int32)(548)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTRUCTION_MISALIGNMENT</unmanaged>
        /// <unmanaged-short>ERROR_INSTRUCTION_MISALIGNMENT</unmanaged-short>
        InstructionMisalignment = unchecked((System.Int32)(549)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROFILING_NOT_STARTED</unmanaged>
        /// <unmanaged-short>ERROR_PROFILING_NOT_STARTED</unmanaged-short>
        ProfilingNotStarted = unchecked((System.Int32)(550)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROFILING_NOT_STOPPED</unmanaged>
        /// <unmanaged-short>ERROR_PROFILING_NOT_STOPPED</unmanaged-short>
        ProfilingNotStopped = unchecked((System.Int32)(551)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COULD_NOT_INTERPRET</unmanaged>
        /// <unmanaged-short>ERROR_COULD_NOT_INTERPRET</unmanaged-short>
        CouldNotInterpret = unchecked((System.Int32)(552)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROFILING_AT_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_PROFILING_AT_LIMIT</unmanaged-short>
        ProfilingAtLimit = unchecked((System.Int32)(553)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_WAIT</unmanaged>
        /// <unmanaged-short>ERROR_CANT_WAIT</unmanaged-short>
        CantWait = unchecked((System.Int32)(554)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_TERMINATE_SELF</unmanaged>
        /// <unmanaged-short>ERROR_CANT_TERMINATE_SELF</unmanaged-short>
        CantTerminateSelf = unchecked((System.Int32)(555)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNEXPECTED_MM_CREATE_ERR</unmanaged>
        /// <unmanaged-short>ERROR_UNEXPECTED_MM_CREATE_ERR</unmanaged-short>
        UnexpectedMmCreateErr = unchecked((System.Int32)(556)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNEXPECTED_MM_MAP_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_UNEXPECTED_MM_MAP_ERROR</unmanaged-short>
        UnexpectedMmMapError = unchecked((System.Int32)(557)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNEXPECTED_MM_EXTEND_ERR</unmanaged>
        /// <unmanaged-short>ERROR_UNEXPECTED_MM_EXTEND_ERR</unmanaged-short>
        UnexpectedMmExtendErr = unchecked((System.Int32)(558)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_FUNCTION_TABLE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_FUNCTION_TABLE</unmanaged-short>
        BadFunctionTable = unchecked((System.Int32)(559)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_GUID_TRANSLATION</unmanaged>
        /// <unmanaged-short>ERROR_NO_GUID_TRANSLATION</unmanaged-short>
        NoGuidTranslation = unchecked((System.Int32)(560)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LDT_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LDT_SIZE</unmanaged-short>
        InvalidLdtSize = unchecked((System.Int32)(561)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LDT_OFFSET</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LDT_OFFSET</unmanaged-short>
        InvalidLdtOffset = unchecked((System.Int32)(563)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LDT_DESCRIPTOR</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LDT_DESCRIPTOR</unmanaged-short>
        InvalidLdtDescriptor = unchecked((System.Int32)(564)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_THREADS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_THREADS</unmanaged-short>
        TooManyThreads = unchecked((System.Int32)(565)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_THREAD_NOT_IN_PROCESS</unmanaged>
        /// <unmanaged-short>ERROR_THREAD_NOT_IN_PROCESS</unmanaged-short>
        ThreadNotInProcess = unchecked((System.Int32)(566)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGEFILE_QUOTA_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_PAGEFILE_QUOTA_EXCEEDED</unmanaged-short>
        PagefileQuotaExceeded = unchecked((System.Int32)(567)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOGON_SERVER_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_LOGON_SERVER_CONFLICT</unmanaged-short>
        LogonServerConflict = unchecked((System.Int32)(568)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYNCHRONIZATION_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_SYNCHRONIZATION_REQUIRED</unmanaged-short>
        SynchronizationRequired = unchecked((System.Int32)(569)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NET_OPEN_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_NET_OPEN_FAILED</unmanaged-short>
        NetOpenFailed = unchecked((System.Int32)(570)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IO_PRIVILEGE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IO_PRIVILEGE_FAILED</unmanaged-short>
        IoPrivilegeFailed = unchecked((System.Int32)(571)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONTROL_C_EXIT</unmanaged>
        /// <unmanaged-short>ERROR_CONTROL_C_EXIT</unmanaged-short>
        ControlCExit = unchecked((System.Int32)(572)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MISSING_SYSTEMFILE</unmanaged>
        /// <unmanaged-short>ERROR_MISSING_SYSTEMFILE</unmanaged-short>
        MissingSystemfile = unchecked((System.Int32)(573)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNHANDLED_EXCEPTION</unmanaged>
        /// <unmanaged-short>ERROR_UNHANDLED_EXCEPTION</unmanaged-short>
        UnhandledException = unchecked((System.Int32)(574)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APP_INIT_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_APP_INIT_FAILURE</unmanaged-short>
        AppInitFailure = unchecked((System.Int32)(575)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGEFILE_CREATE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PAGEFILE_CREATE_FAILED</unmanaged-short>
        PagefileCreateFailed = unchecked((System.Int32)(576)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_IMAGE_HASH</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_IMAGE_HASH</unmanaged-short>
        InvalidImageHash = unchecked((System.Int32)(577)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_PAGEFILE</unmanaged>
        /// <unmanaged-short>ERROR_NO_PAGEFILE</unmanaged-short>
        NoPagefile = unchecked((System.Int32)(578)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ILLEGAL_FLOAT_CONTEXT</unmanaged>
        /// <unmanaged-short>ERROR_ILLEGAL_FLOAT_CONTEXT</unmanaged-short>
        IllegalFloatContext = unchecked((System.Int32)(579)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_EVENT_PAIR</unmanaged>
        /// <unmanaged-short>ERROR_NO_EVENT_PAIR</unmanaged-short>
        NoEventPair = unchecked((System.Int32)(580)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DOMAIN_CTRLR_CONFIG_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DOMAIN_CTRLR_CONFIG_ERROR</unmanaged-short>
        DomainCtrlrConfigError = unchecked((System.Int32)(581)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ILLEGAL_CHARACTER</unmanaged>
        /// <unmanaged-short>ERROR_ILLEGAL_CHARACTER</unmanaged-short>
        IllegalCharacter = unchecked((System.Int32)(582)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNDEFINED_CHARACTER</unmanaged>
        /// <unmanaged-short>ERROR_UNDEFINED_CHARACTER</unmanaged-short>
        UndefinedCharacter = unchecked((System.Int32)(583)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLOPPY_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_FLOPPY_VOLUME</unmanaged-short>
        FloppyVolume = unchecked((System.Int32)(584)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT</unmanaged>
        /// <unmanaged-short>ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT</unmanaged-short>
        BiosFailedToConnectInterrupt = unchecked((System.Int32)(585)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BACKUP_CONTROLLER</unmanaged>
        /// <unmanaged-short>ERROR_BACKUP_CONTROLLER</unmanaged-short>
        BackupController = unchecked((System.Int32)(586)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUTANT_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_MUTANT_LIMIT_EXCEEDED</unmanaged-short>
        MutantLimitExceeded = unchecked((System.Int32)(587)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FS_DRIVER_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_FS_DRIVER_REQUIRED</unmanaged-short>
        FsDriverRequired = unchecked((System.Int32)(588)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_LOAD_REGISTRY_FILE</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_LOAD_REGISTRY_FILE</unmanaged-short>
        CannotLoadRegistryFile = unchecked((System.Int32)(589)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEBUG_ATTACH_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DEBUG_ATTACH_FAILED</unmanaged-short>
        DebugAttachFailed = unchecked((System.Int32)(590)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_PROCESS_TERMINATED</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_PROCESS_TERMINATED</unmanaged-short>
        SystemProcessTerminated = unchecked((System.Int32)(591)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DATA_NOT_ACCEPTED</unmanaged>
        /// <unmanaged-short>ERROR_DATA_NOT_ACCEPTED</unmanaged-short>
        DataNotAccepted = unchecked((System.Int32)(592)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VDM_HARD_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_VDM_HARD_ERROR</unmanaged-short>
        VdmHardError = unchecked((System.Int32)(593)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVER_CANCEL_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_DRIVER_CANCEL_TIMEOUT</unmanaged-short>
        DriverCancelTimeout = unchecked((System.Int32)(594)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REPLY_MESSAGE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_REPLY_MESSAGE_MISMATCH</unmanaged-short>
        ReplyMessageMismatch = unchecked((System.Int32)(595)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOST_WRITEBEHIND_DATA</unmanaged>
        /// <unmanaged-short>ERROR_LOST_WRITEBEHIND_DATA</unmanaged-short>
        LostWritebehindData = unchecked((System.Int32)(596)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIENT_SERVER_PARAMETERS_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_CLIENT_SERVER_PARAMETERS_INVALID</unmanaged-short>
        ClientServerParametersInvalid = unchecked((System.Int32)(597)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_TINY_STREAM</unmanaged>
        /// <unmanaged-short>ERROR_NOT_TINY_STREAM</unmanaged-short>
        NotTinyStream = unchecked((System.Int32)(598)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STACK_OVERFLOW_READ</unmanaged>
        /// <unmanaged-short>ERROR_STACK_OVERFLOW_READ</unmanaged-short>
        StackOverflowRead = unchecked((System.Int32)(599)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONVERT_TO_LARGE</unmanaged>
        /// <unmanaged-short>ERROR_CONVERT_TO_LARGE</unmanaged-short>
        ConvertToLarge = unchecked((System.Int32)(600)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FOUND_OUT_OF_SCOPE</unmanaged>
        /// <unmanaged-short>ERROR_FOUND_OUT_OF_SCOPE</unmanaged-short>
        FoundOutOfScope = unchecked((System.Int32)(601)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALLOCATE_BUCKET</unmanaged>
        /// <unmanaged-short>ERROR_ALLOCATE_BUCKET</unmanaged-short>
        AllocateBucket = unchecked((System.Int32)(602)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MARSHALL_OVERFLOW</unmanaged>
        /// <unmanaged-short>ERROR_MARSHALL_OVERFLOW</unmanaged-short>
        MarshallOverflow = unchecked((System.Int32)(603)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_VARIANT</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_VARIANT</unmanaged-short>
        InvalidVariant = unchecked((System.Int32)(604)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_COMPRESSION_BUFFER</unmanaged>
        /// <unmanaged-short>ERROR_BAD_COMPRESSION_BUFFER</unmanaged-short>
        BadCompressionBuffer = unchecked((System.Int32)(605)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_AUDIT_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_AUDIT_FAILED</unmanaged-short>
        AuditFailed = unchecked((System.Int32)(606)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIMER_RESOLUTION_NOT_SET</unmanaged>
        /// <unmanaged-short>ERROR_TIMER_RESOLUTION_NOT_SET</unmanaged-short>
        TimerResolutionNotSet = unchecked((System.Int32)(607)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSUFFICIENT_LOGON_INFO</unmanaged>
        /// <unmanaged-short>ERROR_INSUFFICIENT_LOGON_INFO</unmanaged-short>
        InsufficientLogonInfo = unchecked((System.Int32)(608)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_DLL_ENTRYPOINT</unmanaged>
        /// <unmanaged-short>ERROR_BAD_DLL_ENTRYPOINT</unmanaged-short>
        BadDllEntrypoint = unchecked((System.Int32)(609)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_SERVICE_ENTRYPOINT</unmanaged>
        /// <unmanaged-short>ERROR_BAD_SERVICE_ENTRYPOINT</unmanaged-short>
        BadServiceEntrypoint = unchecked((System.Int32)(610)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IP_ADDRESS_CONFLICT1</unmanaged>
        /// <unmanaged-short>ERROR_IP_ADDRESS_CONFLICT1</unmanaged-short>
        IpAddressConflict1 = unchecked((System.Int32)(611)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IP_ADDRESS_CONFLICT2</unmanaged>
        /// <unmanaged-short>ERROR_IP_ADDRESS_CONFLICT2</unmanaged-short>
        IpAddressConflict2 = unchecked((System.Int32)(612)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REGISTRY_QUOTA_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_REGISTRY_QUOTA_LIMIT</unmanaged-short>
        RegistryQuotaLimit = unchecked((System.Int32)(613)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_CALLBACK_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_NO_CALLBACK_ACTIVE</unmanaged-short>
        NoCallbackActive = unchecked((System.Int32)(614)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PWD_TOO_SHORT</unmanaged>
        /// <unmanaged-short>ERROR_PWD_TOO_SHORT</unmanaged-short>
        PwdTooShort = unchecked((System.Int32)(615)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PWD_TOO_RECENT</unmanaged>
        /// <unmanaged-short>ERROR_PWD_TOO_RECENT</unmanaged-short>
        PwdTooRecent = unchecked((System.Int32)(616)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PWD_HISTORY_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_PWD_HISTORY_CONFLICT</unmanaged-short>
        PwdHistoryConflict = unchecked((System.Int32)(617)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNSUPPORTED_COMPRESSION</unmanaged>
        /// <unmanaged-short>ERROR_UNSUPPORTED_COMPRESSION</unmanaged-short>
        UnsupportedCompression = unchecked((System.Int32)(618)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_HW_PROFILE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_HW_PROFILE</unmanaged-short>
        InvalidHwProfile = unchecked((System.Int32)(619)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PLUGPLAY_DEVICE_PATH</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PLUGPLAY_DEVICE_PATH</unmanaged-short>
        InvalidPlugplayDevicePath = unchecked((System.Int32)(620)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUOTA_LIST_INCONSISTENT</unmanaged>
        /// <unmanaged-short>ERROR_QUOTA_LIST_INCONSISTENT</unmanaged-short>
        QuotaListInconsistent = unchecked((System.Int32)(621)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVALUATION_EXPIRATION</unmanaged>
        /// <unmanaged-short>ERROR_EVALUATION_EXPIRATION</unmanaged-short>
        EvaluationExpiration = unchecked((System.Int32)(622)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ILLEGAL_DLL_RELOCATION</unmanaged>
        /// <unmanaged-short>ERROR_ILLEGAL_DLL_RELOCATION</unmanaged-short>
        IllegalDllRelocation = unchecked((System.Int32)(623)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DLL_INIT_FAILED_LOGOFF</unmanaged>
        /// <unmanaged-short>ERROR_DLL_INIT_FAILED_LOGOFF</unmanaged-short>
        DllInitFailedLogoff = unchecked((System.Int32)(624)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VALIDATE_CONTINUE</unmanaged>
        /// <unmanaged-short>ERROR_VALIDATE_CONTINUE</unmanaged-short>
        ValidateContinue = unchecked((System.Int32)(625)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_MORE_MATCHES</unmanaged>
        /// <unmanaged-short>ERROR_NO_MORE_MATCHES</unmanaged-short>
        NoMoreMatches = unchecked((System.Int32)(626)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RANGE_LIST_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_RANGE_LIST_CONFLICT</unmanaged-short>
        RangeListConflict = unchecked((System.Int32)(627)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVER_SID_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_SERVER_SID_MISMATCH</unmanaged-short>
        ServerSidMismatch = unchecked((System.Int32)(628)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_ENABLE_DENY_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_CANT_ENABLE_DENY_ONLY</unmanaged-short>
        CantEnableDenyOnly = unchecked((System.Int32)(629)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLOAT_MULTIPLE_FAULTS</unmanaged>
        /// <unmanaged-short>ERROR_FLOAT_MULTIPLE_FAULTS</unmanaged-short>
        FloatMultipleFaults = unchecked((System.Int32)(630)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLOAT_MULTIPLE_TRAPS</unmanaged>
        /// <unmanaged-short>ERROR_FLOAT_MULTIPLE_TRAPS</unmanaged-short>
        FloatMultipleTraps = unchecked((System.Int32)(631)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOINTERFACE</unmanaged>
        /// <unmanaged-short>ERROR_NOINTERFACE</unmanaged-short>
        Nointerface = unchecked((System.Int32)(632)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVER_FAILED_SLEEP</unmanaged>
        /// <unmanaged-short>ERROR_DRIVER_FAILED_SLEEP</unmanaged-short>
        DriverFailedSleep = unchecked((System.Int32)(633)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CORRUPT_SYSTEM_FILE</unmanaged>
        /// <unmanaged-short>ERROR_CORRUPT_SYSTEM_FILE</unmanaged-short>
        CorruptSystemFile = unchecked((System.Int32)(634)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COMMITMENT_MINIMUM</unmanaged>
        /// <unmanaged-short>ERROR_COMMITMENT_MINIMUM</unmanaged-short>
        CommitmentMinimum = unchecked((System.Int32)(635)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_RESTART_ENUMERATION</unmanaged>
        /// <unmanaged-short>ERROR_PNP_RESTART_ENUMERATION</unmanaged-short>
        PnpRestartEnumeration = unchecked((System.Int32)(636)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_IMAGE_BAD_SIGNATURE</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_IMAGE_BAD_SIGNATURE</unmanaged-short>
        SystemImageBadSignature = unchecked((System.Int32)(637)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_REBOOT_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_PNP_REBOOT_REQUIRED</unmanaged-short>
        PnpRebootRequired = unchecked((System.Int32)(638)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSUFFICIENT_POWER</unmanaged>
        /// <unmanaged-short>ERROR_INSUFFICIENT_POWER</unmanaged-short>
        InsufficientPower = unchecked((System.Int32)(639)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MULTIPLE_FAULT_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_MULTIPLE_FAULT_VIOLATION</unmanaged-short>
        MultipleFaultViolation = unchecked((System.Int32)(640)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_SHUTDOWN</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_SHUTDOWN</unmanaged-short>
        SystemShutdown = unchecked((System.Int32)(641)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PORT_NOT_SET</unmanaged>
        /// <unmanaged-short>ERROR_PORT_NOT_SET</unmanaged-short>
        PortNotSet = unchecked((System.Int32)(642)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_VERSION_CHECK_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_DS_VERSION_CHECK_FAILURE</unmanaged-short>
        DsVersionCheckFailure = unchecked((System.Int32)(643)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RANGE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_RANGE_NOT_FOUND</unmanaged-short>
        RangeNotFound = unchecked((System.Int32)(644)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SAFE_MODE_DRIVER</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SAFE_MODE_DRIVER</unmanaged-short>
        NotSafeModeDriver = unchecked((System.Int32)(646)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAILED_DRIVER_ENTRY</unmanaged>
        /// <unmanaged-short>ERROR_FAILED_DRIVER_ENTRY</unmanaged-short>
        FailedDriverEntry = unchecked((System.Int32)(647)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_ENUMERATION_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_ENUMERATION_ERROR</unmanaged-short>
        DeviceEnumerationError = unchecked((System.Int32)(648)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MOUNT_POINT_NOT_RESOLVED</unmanaged>
        /// <unmanaged-short>ERROR_MOUNT_POINT_NOT_RESOLVED</unmanaged-short>
        MountPointNotResolved = unchecked((System.Int32)(649)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DEVICE_OBJECT_PARAMETER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DEVICE_OBJECT_PARAMETER</unmanaged-short>
        InvalidDeviceObjectParameter = unchecked((System.Int32)(650)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_OCCURED</unmanaged>
        /// <unmanaged-short>ERROR_MCA_OCCURED</unmanaged-short>
        McaOccured = unchecked((System.Int32)(651)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVER_DATABASE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DRIVER_DATABASE_ERROR</unmanaged-short>
        DriverDatabaseError = unchecked((System.Int32)(652)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_HIVE_TOO_LARGE</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_HIVE_TOO_LARGE</unmanaged-short>
        SystemHiveTooLarge = unchecked((System.Int32)(653)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVER_FAILED_PRIOR_UNLOAD</unmanaged>
        /// <unmanaged-short>ERROR_DRIVER_FAILED_PRIOR_UNLOAD</unmanaged-short>
        DriverFailedPriorUnload = unchecked((System.Int32)(654)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLSNAP_PREPARE_HIBERNATE</unmanaged>
        /// <unmanaged-short>ERROR_VOLSNAP_PREPARE_HIBERNATE</unmanaged-short>
        VolsnapPrepareHibernate = unchecked((System.Int32)(655)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HIBERNATION_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_HIBERNATION_FAILURE</unmanaged-short>
        HibernationFailure = unchecked((System.Int32)(656)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PWD_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_PWD_TOO_LONG</unmanaged-short>
        PwdTooLong = unchecked((System.Int32)(657)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_SYSTEM_LIMITATION</unmanaged>
        /// <unmanaged-short>ERROR_FILE_SYSTEM_LIMITATION</unmanaged-short>
        FileSystemLimitation = unchecked((System.Int32)(665)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ASSERTION_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_ASSERTION_FAILURE</unmanaged-short>
        AssertionFailure = unchecked((System.Int32)(668)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACPI_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_ACPI_ERROR</unmanaged-short>
        AcpiError = unchecked((System.Int32)(669)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WOW_ASSERTION</unmanaged>
        /// <unmanaged-short>ERROR_WOW_ASSERTION</unmanaged-short>
        WowAssertion = unchecked((System.Int32)(670)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_BAD_MPS_TABLE</unmanaged>
        /// <unmanaged-short>ERROR_PNP_BAD_MPS_TABLE</unmanaged-short>
        PnpBadMpsTable = unchecked((System.Int32)(671)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_TRANSLATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PNP_TRANSLATION_FAILED</unmanaged-short>
        PnpTranslationFailed = unchecked((System.Int32)(672)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_IRQ_TRANSLATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PNP_IRQ_TRANSLATION_FAILED</unmanaged-short>
        PnpIrqTranslationFailed = unchecked((System.Int32)(673)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PNP_INVALID_ID</unmanaged>
        /// <unmanaged-short>ERROR_PNP_INVALID_ID</unmanaged-short>
        PnpInvalidId = unchecked((System.Int32)(674)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAKE_SYSTEM_DEBUGGER</unmanaged>
        /// <unmanaged-short>ERROR_WAKE_SYSTEM_DEBUGGER</unmanaged-short>
        WakeSystemDebugger = unchecked((System.Int32)(675)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HANDLES_CLOSED</unmanaged>
        /// <unmanaged-short>ERROR_HANDLES_CLOSED</unmanaged-short>
        HandlesClosed = unchecked((System.Int32)(676)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXTRANEOUS_INFORMATION</unmanaged>
        /// <unmanaged-short>ERROR_EXTRANEOUS_INFORMATION</unmanaged-short>
        ExtraneousInformation = unchecked((System.Int32)(677)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RXACT_COMMIT_NECESSARY</unmanaged>
        /// <unmanaged-short>ERROR_RXACT_COMMIT_NECESSARY</unmanaged-short>
        RxactCommitNecessary = unchecked((System.Int32)(678)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEDIA_CHECK</unmanaged>
        /// <unmanaged-short>ERROR_MEDIA_CHECK</unmanaged-short>
        MediaCheck = unchecked((System.Int32)(679)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GUID_SUBSTITUTION_MADE</unmanaged>
        /// <unmanaged-short>ERROR_GUID_SUBSTITUTION_MADE</unmanaged-short>
        GuidSubstitutionMade = unchecked((System.Int32)(680)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STOPPED_ON_SYMLINK</unmanaged>
        /// <unmanaged-short>ERROR_STOPPED_ON_SYMLINK</unmanaged-short>
        StoppedOnSymlink = unchecked((System.Int32)(681)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LONGJUMP</unmanaged>
        /// <unmanaged-short>ERROR_LONGJUMP</unmanaged-short>
        Longjump = unchecked((System.Int32)(682)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PLUGPLAY_QUERY_VETOED</unmanaged>
        /// <unmanaged-short>ERROR_PLUGPLAY_QUERY_VETOED</unmanaged-short>
        PlugplayQueryVetoed = unchecked((System.Int32)(683)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNWIND_CONSOLIDATE</unmanaged>
        /// <unmanaged-short>ERROR_UNWIND_CONSOLIDATE</unmanaged-short>
        UnwindConsolidate = unchecked((System.Int32)(684)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REGISTRY_HIVE_RECOVERED</unmanaged>
        /// <unmanaged-short>ERROR_REGISTRY_HIVE_RECOVERED</unmanaged-short>
        RegistryHiveRecovered = unchecked((System.Int32)(685)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DLL_MIGHT_BE_INSECURE</unmanaged>
        /// <unmanaged-short>ERROR_DLL_MIGHT_BE_INSECURE</unmanaged-short>
        DllMightBeInsecure = unchecked((System.Int32)(686)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DLL_MIGHT_BE_INCOMPATIBLE</unmanaged>
        /// <unmanaged-short>ERROR_DLL_MIGHT_BE_INCOMPATIBLE</unmanaged-short>
        DllMightBeIncompatible = unchecked((System.Int32)(687)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_EXCEPTION_NOT_HANDLED</unmanaged>
        /// <unmanaged-short>ERROR_DBG_EXCEPTION_NOT_HANDLED</unmanaged-short>
        DbgExceptionNotHandled = unchecked((System.Int32)(688)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_REPLY_LATER</unmanaged>
        /// <unmanaged-short>ERROR_DBG_REPLY_LATER</unmanaged-short>
        DbgReplyLater = unchecked((System.Int32)(689)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE</unmanaged-short>
        DbgUnableToProvideHandle = unchecked((System.Int32)(690)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_TERMINATE_THREAD</unmanaged>
        /// <unmanaged-short>ERROR_DBG_TERMINATE_THREAD</unmanaged-short>
        DbgTerminateThread = unchecked((System.Int32)(691)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_TERMINATE_PROCESS</unmanaged>
        /// <unmanaged-short>ERROR_DBG_TERMINATE_PROCESS</unmanaged-short>
        DbgTerminateProcess = unchecked((System.Int32)(692)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_CONTROL_C</unmanaged>
        /// <unmanaged-short>ERROR_DBG_CONTROL_C</unmanaged-short>
        DbgControlC = unchecked((System.Int32)(693)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_PRINTEXCEPTION_C</unmanaged>
        /// <unmanaged-short>ERROR_DBG_PRINTEXCEPTION_C</unmanaged-short>
        DbgPrintexceptionC = unchecked((System.Int32)(694)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_RIPEXCEPTION</unmanaged>
        /// <unmanaged-short>ERROR_DBG_RIPEXCEPTION</unmanaged-short>
        DbgRipexception = unchecked((System.Int32)(695)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_CONTROL_BREAK</unmanaged>
        /// <unmanaged-short>ERROR_DBG_CONTROL_BREAK</unmanaged-short>
        DbgControlBreak = unchecked((System.Int32)(696)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_COMMAND_EXCEPTION</unmanaged>
        /// <unmanaged-short>ERROR_DBG_COMMAND_EXCEPTION</unmanaged-short>
        DbgCommandException = unchecked((System.Int32)(697)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OBJECT_NAME_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_OBJECT_NAME_EXISTS</unmanaged-short>
        ObjectNameExists = unchecked((System.Int32)(698)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_THREAD_WAS_SUSPENDED</unmanaged>
        /// <unmanaged-short>ERROR_THREAD_WAS_SUSPENDED</unmanaged-short>
        ThreadWasSuspended = unchecked((System.Int32)(699)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IMAGE_NOT_AT_BASE</unmanaged>
        /// <unmanaged-short>ERROR_IMAGE_NOT_AT_BASE</unmanaged-short>
        ImageNotAtBase = unchecked((System.Int32)(700)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RXACT_STATE_CREATED</unmanaged>
        /// <unmanaged-short>ERROR_RXACT_STATE_CREATED</unmanaged-short>
        RxactStateCreated = unchecked((System.Int32)(701)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SEGMENT_NOTIFICATION</unmanaged>
        /// <unmanaged-short>ERROR_SEGMENT_NOTIFICATION</unmanaged-short>
        SegmentNotification = unchecked((System.Int32)(702)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_CURRENT_DIRECTORY</unmanaged>
        /// <unmanaged-short>ERROR_BAD_CURRENT_DIRECTORY</unmanaged-short>
        BadCurrentDirectory = unchecked((System.Int32)(703)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FT_READ_RECOVERY_FROM_BACKUP</unmanaged>
        /// <unmanaged-short>ERROR_FT_READ_RECOVERY_FROM_BACKUP</unmanaged-short>
        FtReadRecoveryFromBackup = unchecked((System.Int32)(704)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FT_WRITE_RECOVERY</unmanaged>
        /// <unmanaged-short>ERROR_FT_WRITE_RECOVERY</unmanaged-short>
        FtWriteRecovery = unchecked((System.Int32)(705)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IMAGE_MACHINE_TYPE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_IMAGE_MACHINE_TYPE_MISMATCH</unmanaged-short>
        ImageMachineTypeMismatch = unchecked((System.Int32)(706)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RECEIVE_PARTIAL</unmanaged>
        /// <unmanaged-short>ERROR_RECEIVE_PARTIAL</unmanaged-short>
        ReceivePartial = unchecked((System.Int32)(707)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RECEIVE_EXPEDITED</unmanaged>
        /// <unmanaged-short>ERROR_RECEIVE_EXPEDITED</unmanaged-short>
        ReceiveExpedited = unchecked((System.Int32)(708)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RECEIVE_PARTIAL_EXPEDITED</unmanaged>
        /// <unmanaged-short>ERROR_RECEIVE_PARTIAL_EXPEDITED</unmanaged-short>
        ReceivePartialExpedited = unchecked((System.Int32)(709)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVENT_DONE</unmanaged>
        /// <unmanaged-short>ERROR_EVENT_DONE</unmanaged-short>
        EventDone = unchecked((System.Int32)(710)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVENT_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_EVENT_PENDING</unmanaged-short>
        EventPending = unchecked((System.Int32)(711)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CHECKING_FILE_SYSTEM</unmanaged>
        /// <unmanaged-short>ERROR_CHECKING_FILE_SYSTEM</unmanaged-short>
        CheckingFileSystem = unchecked((System.Int32)(712)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FATAL_APP_EXIT</unmanaged>
        /// <unmanaged-short>ERROR_FATAL_APP_EXIT</unmanaged-short>
        FatalAppExit = unchecked((System.Int32)(713)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PREDEFINED_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_PREDEFINED_HANDLE</unmanaged-short>
        PredefinedHandle = unchecked((System.Int32)(714)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAS_UNLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_WAS_UNLOCKED</unmanaged-short>
        WasUnlocked = unchecked((System.Int32)(715)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_NOTIFICATION</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_NOTIFICATION</unmanaged-short>
        ServiceNotification = unchecked((System.Int32)(716)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAS_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_WAS_LOCKED</unmanaged-short>
        WasLocked = unchecked((System.Int32)(717)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_HARD_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_LOG_HARD_ERROR</unmanaged-short>
        LogHardError = unchecked((System.Int32)(718)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_WIN32</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_WIN32</unmanaged-short>
        AlreadyWin32 = unchecked((System.Int32)(719)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE</unmanaged>
        /// <unmanaged-short>ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE</unmanaged-short>
        ImageMachineTypeMismatchExe = unchecked((System.Int32)(720)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_YIELD_PERFORMED</unmanaged>
        /// <unmanaged-short>ERROR_NO_YIELD_PERFORMED</unmanaged-short>
        NoYieldPerformed = unchecked((System.Int32)(721)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIMER_RESUME_IGNORED</unmanaged>
        /// <unmanaged-short>ERROR_TIMER_RESUME_IGNORED</unmanaged-short>
        TimerResumeIgnored = unchecked((System.Int32)(722)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ARBITRATION_UNHANDLED</unmanaged>
        /// <unmanaged-short>ERROR_ARBITRATION_UNHANDLED</unmanaged-short>
        ArbitrationUnhandled = unchecked((System.Int32)(723)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CARDBUS_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_CARDBUS_NOT_SUPPORTED</unmanaged-short>
        CardbusNotSupported = unchecked((System.Int32)(724)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MP_PROCESSOR_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_MP_PROCESSOR_MISMATCH</unmanaged-short>
        MpProcessorMismatch = unchecked((System.Int32)(725)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HIBERNATED</unmanaged>
        /// <unmanaged-short>ERROR_HIBERNATED</unmanaged-short>
        Hibernated = unchecked((System.Int32)(726)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESUME_HIBERNATION</unmanaged>
        /// <unmanaged-short>ERROR_RESUME_HIBERNATION</unmanaged-short>
        ResumeHibernation = unchecked((System.Int32)(727)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FIRMWARE_UPDATED</unmanaged>
        /// <unmanaged-short>ERROR_FIRMWARE_UPDATED</unmanaged-short>
        FirmwareUpdated = unchecked((System.Int32)(728)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVERS_LEAKING_LOCKED_PAGES</unmanaged>
        /// <unmanaged-short>ERROR_DRIVERS_LEAKING_LOCKED_PAGES</unmanaged-short>
        DriversLeakingLockedPages = unchecked((System.Int32)(729)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAKE_SYSTEM</unmanaged>
        /// <unmanaged-short>ERROR_WAKE_SYSTEM</unmanaged-short>
        WakeSystem = unchecked((System.Int32)(730)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAIT_1</unmanaged>
        /// <unmanaged-short>ERROR_WAIT_1</unmanaged-short>
        Wait1 = unchecked((System.Int32)(731)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAIT_2</unmanaged>
        /// <unmanaged-short>ERROR_WAIT_2</unmanaged-short>
        Wait2 = unchecked((System.Int32)(732)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAIT_3</unmanaged>
        /// <unmanaged-short>ERROR_WAIT_3</unmanaged-short>
        Wait3 = unchecked((System.Int32)(733)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAIT_63</unmanaged>
        /// <unmanaged-short>ERROR_WAIT_63</unmanaged-short>
        Wait63 = unchecked((System.Int32)(734)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ABANDONED_WAIT_0</unmanaged>
        /// <unmanaged-short>ERROR_ABANDONED_WAIT_0</unmanaged-short>
        AbandonedWait0 = unchecked((System.Int32)(735)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ABANDONED_WAIT_63</unmanaged>
        /// <unmanaged-short>ERROR_ABANDONED_WAIT_63</unmanaged-short>
        AbandonedWait63 = unchecked((System.Int32)(736)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_USER_APC</unmanaged>
        /// <unmanaged-short>ERROR_USER_APC</unmanaged-short>
        UserApc = unchecked((System.Int32)(737)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_KERNEL_APC</unmanaged>
        /// <unmanaged-short>ERROR_KERNEL_APC</unmanaged-short>
        KernelApc = unchecked((System.Int32)(738)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALERTED</unmanaged>
        /// <unmanaged-short>ERROR_ALERTED</unmanaged-short>
        Alerted = unchecked((System.Int32)(739)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ELEVATION_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_ELEVATION_REQUIRED</unmanaged-short>
        ElevationRequired = unchecked((System.Int32)(740)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REPARSE</unmanaged>
        /// <unmanaged-short>ERROR_REPARSE</unmanaged-short>
        Reparse = unchecked((System.Int32)(741)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPLOCK_BREAK_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_OPLOCK_BREAK_IN_PROGRESS</unmanaged-short>
        OplockBreakInProgress = unchecked((System.Int32)(742)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLUME_MOUNTED</unmanaged>
        /// <unmanaged-short>ERROR_VOLUME_MOUNTED</unmanaged-short>
        VolumeMounted = unchecked((System.Int32)(743)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RXACT_COMMITTED</unmanaged>
        /// <unmanaged-short>ERROR_RXACT_COMMITTED</unmanaged-short>
        RxactCommitted = unchecked((System.Int32)(744)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOTIFY_CLEANUP</unmanaged>
        /// <unmanaged-short>ERROR_NOTIFY_CLEANUP</unmanaged-short>
        NotifyCleanup = unchecked((System.Int32)(745)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED</unmanaged-short>
        PrimaryTransportConnectFailed = unchecked((System.Int32)(746)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGE_FAULT_TRANSITION</unmanaged>
        /// <unmanaged-short>ERROR_PAGE_FAULT_TRANSITION</unmanaged-short>
        PageFaultTransition = unchecked((System.Int32)(747)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGE_FAULT_DEMAND_ZERO</unmanaged>
        /// <unmanaged-short>ERROR_PAGE_FAULT_DEMAND_ZERO</unmanaged-short>
        PageFaultDemandZero = unchecked((System.Int32)(748)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGE_FAULT_COPY_ON_WRITE</unmanaged>
        /// <unmanaged-short>ERROR_PAGE_FAULT_COPY_ON_WRITE</unmanaged-short>
        PageFaultCopyOnWrite = unchecked((System.Int32)(749)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGE_FAULT_GUARD_PAGE</unmanaged>
        /// <unmanaged-short>ERROR_PAGE_FAULT_GUARD_PAGE</unmanaged-short>
        PageFaultGuardPage = unchecked((System.Int32)(750)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGE_FAULT_PAGING_FILE</unmanaged>
        /// <unmanaged-short>ERROR_PAGE_FAULT_PAGING_FILE</unmanaged-short>
        PageFaultPagingFile = unchecked((System.Int32)(751)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CACHE_PAGE_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_CACHE_PAGE_LOCKED</unmanaged-short>
        CachePageLocked = unchecked((System.Int32)(752)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CRASH_DUMP</unmanaged>
        /// <unmanaged-short>ERROR_CRASH_DUMP</unmanaged-short>
        CrashDump = unchecked((System.Int32)(753)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BUFFER_ALL_ZEROS</unmanaged>
        /// <unmanaged-short>ERROR_BUFFER_ALL_ZEROS</unmanaged-short>
        BufferAllZeros = unchecked((System.Int32)(754)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REPARSE_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_REPARSE_OBJECT</unmanaged-short>
        ReparseObject = unchecked((System.Int32)(755)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_REQUIREMENTS_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_REQUIREMENTS_CHANGED</unmanaged-short>
        ResourceRequirementsChanged = unchecked((System.Int32)(756)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSLATION_COMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_TRANSLATION_COMPLETE</unmanaged-short>
        TranslationComplete = unchecked((System.Int32)(757)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOTHING_TO_TERMINATE</unmanaged>
        /// <unmanaged-short>ERROR_NOTHING_TO_TERMINATE</unmanaged-short>
        NothingToTerminate = unchecked((System.Int32)(758)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROCESS_NOT_IN_JOB</unmanaged>
        /// <unmanaged-short>ERROR_PROCESS_NOT_IN_JOB</unmanaged-short>
        ProcessNotInJob = unchecked((System.Int32)(759)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROCESS_IN_JOB</unmanaged>
        /// <unmanaged-short>ERROR_PROCESS_IN_JOB</unmanaged-short>
        ProcessInJob = unchecked((System.Int32)(760)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLSNAP_HIBERNATE_READY</unmanaged>
        /// <unmanaged-short>ERROR_VOLSNAP_HIBERNATE_READY</unmanaged-short>
        VolsnapHibernateReady = unchecked((System.Int32)(761)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY</unmanaged>
        /// <unmanaged-short>ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY</unmanaged-short>
        FsfilterOpCompletedSuccessfully = unchecked((System.Int32)(762)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED</unmanaged-short>
        InterruptVectorAlreadyConnected = unchecked((System.Int32)(763)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INTERRUPT_STILL_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_INTERRUPT_STILL_CONNECTED</unmanaged-short>
        InterruptStillConnected = unchecked((System.Int32)(764)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WAIT_FOR_OPLOCK</unmanaged>
        /// <unmanaged-short>ERROR_WAIT_FOR_OPLOCK</unmanaged-short>
        WaitForOplock = unchecked((System.Int32)(765)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_EXCEPTION_HANDLED</unmanaged>
        /// <unmanaged-short>ERROR_DBG_EXCEPTION_HANDLED</unmanaged-short>
        DbgExceptionHandled = unchecked((System.Int32)(766)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_CONTINUE</unmanaged>
        /// <unmanaged-short>ERROR_DBG_CONTINUE</unmanaged-short>
        DbgContinue = unchecked((System.Int32)(767)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CALLBACK_POP_STACK</unmanaged>
        /// <unmanaged-short>ERROR_CALLBACK_POP_STACK</unmanaged-short>
        CallbackPopStack = unchecked((System.Int32)(768)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COMPRESSION_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_COMPRESSION_DISABLED</unmanaged-short>
        CompressionDisabled = unchecked((System.Int32)(769)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANTFETCHBACKWARDS</unmanaged>
        /// <unmanaged-short>ERROR_CANTFETCHBACKWARDS</unmanaged-short>
        Cantfetchbackwards = unchecked((System.Int32)(770)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANTSCROLLBACKWARDS</unmanaged>
        /// <unmanaged-short>ERROR_CANTSCROLLBACKWARDS</unmanaged-short>
        Cantscrollbackwards = unchecked((System.Int32)(771)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ROWSNOTRELEASED</unmanaged>
        /// <unmanaged-short>ERROR_ROWSNOTRELEASED</unmanaged-short>
        Rowsnotreleased = unchecked((System.Int32)(772)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_ACCESSOR_FLAGS</unmanaged>
        /// <unmanaged-short>ERROR_BAD_ACCESSOR_FLAGS</unmanaged-short>
        BadAccessorFlags = unchecked((System.Int32)(773)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ERRORS_ENCOUNTERED</unmanaged>
        /// <unmanaged-short>ERROR_ERRORS_ENCOUNTERED</unmanaged-short>
        ErrorsEncountered = unchecked((System.Int32)(774)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_CAPABLE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_CAPABLE</unmanaged-short>
        NotCapable = unchecked((System.Int32)(775)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REQUEST_OUT_OF_SEQUENCE</unmanaged>
        /// <unmanaged-short>ERROR_REQUEST_OUT_OF_SEQUENCE</unmanaged-short>
        RequestOutOfSequence = unchecked((System.Int32)(776)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VERSION_PARSE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_VERSION_PARSE_ERROR</unmanaged-short>
        VersionParseError = unchecked((System.Int32)(777)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BADSTARTPOSITION</unmanaged>
        /// <unmanaged-short>ERROR_BADSTARTPOSITION</unmanaged-short>
        Badstartposition = unchecked((System.Int32)(778)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEMORY_HARDWARE</unmanaged>
        /// <unmanaged-short>ERROR_MEMORY_HARDWARE</unmanaged-short>
        MemoryHardware = unchecked((System.Int32)(779)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_REPAIR_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_DISK_REPAIR_DISABLED</unmanaged-short>
        DiskRepairDisabled = unchecked((System.Int32)(780)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE</unmanaged-short>
        InsufficientResourceForSpecifiedSharedSectionSize = unchecked((System.Int32)(781)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_POWERSTATE_TRANSITION</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_POWERSTATE_TRANSITION</unmanaged-short>
        SystemPowerstateTransition = unchecked((System.Int32)(782)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION</unmanaged-short>
        SystemPowerstateComplexTransition = unchecked((System.Int32)(783)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_EXCEPTION</unmanaged>
        /// <unmanaged-short>ERROR_MCA_EXCEPTION</unmanaged-short>
        McaException = unchecked((System.Int32)(784)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCESS_AUDIT_BY_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_ACCESS_AUDIT_BY_POLICY</unmanaged-short>
        AccessAuditByPolicy = unchecked((System.Int32)(785)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY</unmanaged-short>
        AccessDisabledNoSaferUiByPolicy = unchecked((System.Int32)(786)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ABANDON_HIBERFILE</unmanaged>
        /// <unmanaged-short>ERROR_ABANDON_HIBERFILE</unmanaged-short>
        AbandonHiberfile = unchecked((System.Int32)(787)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED</unmanaged-short>
        LostWritebehindDataNetworkDisconnected = unchecked((System.Int32)(788)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR</unmanaged-short>
        LostWritebehindDataNetworkServerError = unchecked((System.Int32)(789)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR</unmanaged-short>
        LostWritebehindDataLocalDiskError = unchecked((System.Int32)(790)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_MCFG_TABLE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_MCFG_TABLE</unmanaged-short>
        BadMcfgTable = unchecked((System.Int32)(791)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_REPAIR_REDIRECTED</unmanaged>
        /// <unmanaged-short>ERROR_DISK_REPAIR_REDIRECTED</unmanaged-short>
        DiskRepairRedirected = unchecked((System.Int32)(792)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_REPAIR_UNSUCCESSFUL</unmanaged>
        /// <unmanaged-short>ERROR_DISK_REPAIR_UNSUCCESSFUL</unmanaged-short>
        DiskRepairUnsuccessful = unchecked((System.Int32)(793)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CORRUPT_LOG_OVERFULL</unmanaged>
        /// <unmanaged-short>ERROR_CORRUPT_LOG_OVERFULL</unmanaged-short>
        CorruptLogOverfull = unchecked((System.Int32)(794)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CORRUPT_LOG_CORRUPTED</unmanaged>
        /// <unmanaged-short>ERROR_CORRUPT_LOG_CORRUPTED</unmanaged-short>
        CorruptLogCorrupted = unchecked((System.Int32)(795)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CORRUPT_LOG_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_CORRUPT_LOG_UNAVAILABLE</unmanaged-short>
        CorruptLogUnavailable = unchecked((System.Int32)(796)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CORRUPT_LOG_DELETED_FULL</unmanaged>
        /// <unmanaged-short>ERROR_CORRUPT_LOG_DELETED_FULL</unmanaged-short>
        CorruptLogDeletedFull = unchecked((System.Int32)(797)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CORRUPT_LOG_CLEARED</unmanaged>
        /// <unmanaged-short>ERROR_CORRUPT_LOG_CLEARED</unmanaged-short>
        CorruptLogCleared = unchecked((System.Int32)(798)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ORPHAN_NAME_EXHAUSTED</unmanaged>
        /// <unmanaged-short>ERROR_ORPHAN_NAME_EXHAUSTED</unmanaged-short>
        OrphanNameExhausted = unchecked((System.Int32)(799)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE</unmanaged-short>
        OplockSwitchedToNewHandle = unchecked((System.Int32)(800)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_GRANT_REQUESTED_OPLOCK</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_GRANT_REQUESTED_OPLOCK</unmanaged-short>
        CannotGrantRequestedOplock = unchecked((System.Int32)(801)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_BREAK_OPLOCK</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_BREAK_OPLOCK</unmanaged-short>
        CannotBreakOplock = unchecked((System.Int32)(802)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPLOCK_HANDLE_CLOSED</unmanaged>
        /// <unmanaged-short>ERROR_OPLOCK_HANDLE_CLOSED</unmanaged-short>
        OplockHandleClosed = unchecked((System.Int32)(803)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_ACE_CONDITION</unmanaged>
        /// <unmanaged-short>ERROR_NO_ACE_CONDITION</unmanaged-short>
        NoAceCondition = unchecked((System.Int32)(804)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ACE_CONDITION</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ACE_CONDITION</unmanaged-short>
        InvalidAceCondition = unchecked((System.Int32)(805)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_HANDLE_REVOKED</unmanaged>
        /// <unmanaged-short>ERROR_FILE_HANDLE_REVOKED</unmanaged-short>
        FileHandleRevoked = unchecked((System.Int32)(806)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IMAGE_AT_DIFFERENT_BASE</unmanaged>
        /// <unmanaged-short>ERROR_IMAGE_AT_DIFFERENT_BASE</unmanaged-short>
        ImageAtDifferentBase = unchecked((System.Int32)(807)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENCRYPTED_IO_NOT_POSSIBLE</unmanaged>
        /// <unmanaged-short>ERROR_ENCRYPTED_IO_NOT_POSSIBLE</unmanaged-short>
        EncryptedIoNotPossible = unchecked((System.Int32)(808)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_METADATA_OPTIMIZATION_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_FILE_METADATA_OPTIMIZATION_IN_PROGRESS</unmanaged-short>
        FileMetadataOptimizationInProgress = unchecked((System.Int32)(809)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUOTA_ACTIVITY</unmanaged>
        /// <unmanaged-short>ERROR_QUOTA_ACTIVITY</unmanaged-short>
        QuotaActivity = unchecked((System.Int32)(810)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HANDLE_REVOKED</unmanaged>
        /// <unmanaged-short>ERROR_HANDLE_REVOKED</unmanaged-short>
        HandleRevoked = unchecked((System.Int32)(811)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CALLBACK_INVOKE_INLINE</unmanaged>
        /// <unmanaged-short>ERROR_CALLBACK_INVOKE_INLINE</unmanaged-short>
        CallbackInvokeInline = unchecked((System.Int32)(812)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CPU_SET_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_CPU_SET_INVALID</unmanaged-short>
        CpuSetInvalid = unchecked((System.Int32)(813)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENCLAVE_NOT_TERMINATED</unmanaged>
        /// <unmanaged-short>ERROR_ENCLAVE_NOT_TERMINATED</unmanaged-short>
        EnclaveNotTerminated = unchecked((System.Int32)(814)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENCLAVE_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_ENCLAVE_VIOLATION</unmanaged-short>
        EnclaveViolation = unchecked((System.Int32)(815)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EA_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_EA_ACCESS_DENIED</unmanaged-short>
        EaAccessDenied = unchecked((System.Int32)(994)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPERATION_ABORTED</unmanaged>
        /// <unmanaged-short>ERROR_OPERATION_ABORTED</unmanaged-short>
        OperationAborted = unchecked((System.Int32)(995)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IO_INCOMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_IO_INCOMPLETE</unmanaged-short>
        IoIncomplete = unchecked((System.Int32)(996)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IO_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_IO_PENDING</unmanaged-short>
        IoPending = unchecked((System.Int32)(997)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOACCESS</unmanaged>
        /// <unmanaged-short>ERROR_NOACCESS</unmanaged-short>
        Noaccess = unchecked((System.Int32)(998)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SWAPERROR</unmanaged>
        /// <unmanaged-short>ERROR_SWAPERROR</unmanaged-short>
        Swaperror = unchecked((System.Int32)(999)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STACK_OVERFLOW</unmanaged>
        /// <unmanaged-short>ERROR_STACK_OVERFLOW</unmanaged-short>
        StackOverflow = unchecked((System.Int32)(1001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MESSAGE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MESSAGE</unmanaged-short>
        InvalidMessage = unchecked((System.Int32)(1002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAN_NOT_COMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_CAN_NOT_COMPLETE</unmanaged-short>
        CanNotComplete = unchecked((System.Int32)(1003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_FLAGS</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_FLAGS</unmanaged-short>
        InvalidFlags = unchecked((System.Int32)(1004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNRECOGNIZED_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_UNRECOGNIZED_VOLUME</unmanaged-short>
        UnrecognizedVolume = unchecked((System.Int32)(1005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_FILE_INVALID</unmanaged-short>
        FileInvalid = unchecked((System.Int32)(1006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FULLSCREEN_MODE</unmanaged>
        /// <unmanaged-short>ERROR_FULLSCREEN_MODE</unmanaged-short>
        FullscreenMode = unchecked((System.Int32)(1007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_TOKEN</unmanaged>
        /// <unmanaged-short>ERROR_NO_TOKEN</unmanaged-short>
        NoToken = unchecked((System.Int32)(1008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BADDB</unmanaged>
        /// <unmanaged-short>ERROR_BADDB</unmanaged-short>
        Baddb = unchecked((System.Int32)(1009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BADKEY</unmanaged>
        /// <unmanaged-short>ERROR_BADKEY</unmanaged-short>
        Badkey = unchecked((System.Int32)(1010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANTOPEN</unmanaged>
        /// <unmanaged-short>ERROR_CANTOPEN</unmanaged-short>
        Cantopen = unchecked((System.Int32)(1011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANTREAD</unmanaged>
        /// <unmanaged-short>ERROR_CANTREAD</unmanaged-short>
        Cantread = unchecked((System.Int32)(1012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANTWRITE</unmanaged>
        /// <unmanaged-short>ERROR_CANTWRITE</unmanaged-short>
        Cantwrite = unchecked((System.Int32)(1013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REGISTRY_RECOVERED</unmanaged>
        /// <unmanaged-short>ERROR_REGISTRY_RECOVERED</unmanaged-short>
        RegistryRecovered = unchecked((System.Int32)(1014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REGISTRY_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_REGISTRY_CORRUPT</unmanaged-short>
        RegistryCorrupt = unchecked((System.Int32)(1015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REGISTRY_IO_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_REGISTRY_IO_FAILED</unmanaged-short>
        RegistryIoFailed = unchecked((System.Int32)(1016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_REGISTRY_FILE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_REGISTRY_FILE</unmanaged-short>
        NotRegistryFile = unchecked((System.Int32)(1017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_KEY_DELETED</unmanaged>
        /// <unmanaged-short>ERROR_KEY_DELETED</unmanaged-short>
        KeyDeleted = unchecked((System.Int32)(1018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_LOG_SPACE</unmanaged>
        /// <unmanaged-short>ERROR_NO_LOG_SPACE</unmanaged-short>
        NoLogSpace = unchecked((System.Int32)(1019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_KEY_HAS_CHILDREN</unmanaged>
        /// <unmanaged-short>ERROR_KEY_HAS_CHILDREN</unmanaged-short>
        KeyHasChildren = unchecked((System.Int32)(1020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CHILD_MUST_BE_VOLATILE</unmanaged>
        /// <unmanaged-short>ERROR_CHILD_MUST_BE_VOLATILE</unmanaged-short>
        ChildMustBeVolatile = unchecked((System.Int32)(1021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOTIFY_ENUM_DIR</unmanaged>
        /// <unmanaged-short>ERROR_NOTIFY_ENUM_DIR</unmanaged-short>
        NotifyEnumDir = unchecked((System.Int32)(1022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPENDENT_SERVICES_RUNNING</unmanaged>
        /// <unmanaged-short>ERROR_DEPENDENT_SERVICES_RUNNING</unmanaged-short>
        DependentServicesRunning = unchecked((System.Int32)(1051)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SERVICE_CONTROL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SERVICE_CONTROL</unmanaged-short>
        InvalidServiceControl = unchecked((System.Int32)(1052)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_REQUEST_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_REQUEST_TIMEOUT</unmanaged-short>
        ServiceRequestTimeout = unchecked((System.Int32)(1053)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_NO_THREAD</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_NO_THREAD</unmanaged-short>
        ServiceNoThread = unchecked((System.Int32)(1054)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_DATABASE_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_DATABASE_LOCKED</unmanaged-short>
        ServiceDatabaseLocked = unchecked((System.Int32)(1055)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_ALREADY_RUNNING</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_ALREADY_RUNNING</unmanaged-short>
        ServiceAlreadyRunning = unchecked((System.Int32)(1056)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SERVICE_ACCOUNT</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SERVICE_ACCOUNT</unmanaged-short>
        InvalidServiceAccount = unchecked((System.Int32)(1057)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_DISABLED</unmanaged-short>
        ServiceDisabled = unchecked((System.Int32)(1058)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CIRCULAR_DEPENDENCY</unmanaged>
        /// <unmanaged-short>ERROR_CIRCULAR_DEPENDENCY</unmanaged-short>
        CircularDependency = unchecked((System.Int32)(1059)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_DOES_NOT_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_DOES_NOT_EXIST</unmanaged-short>
        ServiceDoesNotExist = unchecked((System.Int32)(1060)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_CANNOT_ACCEPT_CTRL</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_CANNOT_ACCEPT_CTRL</unmanaged-short>
        ServiceCannotAcceptCtrl = unchecked((System.Int32)(1061)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_NOT_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_NOT_ACTIVE</unmanaged-short>
        ServiceNotActive = unchecked((System.Int32)(1062)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAILED_SERVICE_CONTROLLER_CONNECT</unmanaged>
        /// <unmanaged-short>ERROR_FAILED_SERVICE_CONTROLLER_CONNECT</unmanaged-short>
        FailedServiceControllerConnect = unchecked((System.Int32)(1063)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXCEPTION_IN_SERVICE</unmanaged>
        /// <unmanaged-short>ERROR_EXCEPTION_IN_SERVICE</unmanaged-short>
        ExceptionInService = unchecked((System.Int32)(1064)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DATABASE_DOES_NOT_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_DATABASE_DOES_NOT_EXIST</unmanaged-short>
        DatabaseDoesNotExist = unchecked((System.Int32)(1065)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_SPECIFIC_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_SPECIFIC_ERROR</unmanaged-short>
        ServiceSpecificError = unchecked((System.Int32)(1066)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROCESS_ABORTED</unmanaged>
        /// <unmanaged-short>ERROR_PROCESS_ABORTED</unmanaged-short>
        ProcessAborted = unchecked((System.Int32)(1067)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_DEPENDENCY_FAIL</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_DEPENDENCY_FAIL</unmanaged-short>
        ServiceDependencyFail = unchecked((System.Int32)(1068)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_LOGON_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_LOGON_FAILED</unmanaged-short>
        ServiceLogonFailed = unchecked((System.Int32)(1069)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_START_HANG</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_START_HANG</unmanaged-short>
        ServiceStartHang = unchecked((System.Int32)(1070)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SERVICE_LOCK</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SERVICE_LOCK</unmanaged-short>
        InvalidServiceLock = unchecked((System.Int32)(1071)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_MARKED_FOR_DELETE</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_MARKED_FOR_DELETE</unmanaged-short>
        ServiceMarkedForDelete = unchecked((System.Int32)(1072)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_EXISTS</unmanaged-short>
        ServiceExists = unchecked((System.Int32)(1073)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_RUNNING_LKG</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_RUNNING_LKG</unmanaged-short>
        AlreadyRunningLkg = unchecked((System.Int32)(1074)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_DEPENDENCY_DELETED</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_DEPENDENCY_DELETED</unmanaged-short>
        ServiceDependencyDeleted = unchecked((System.Int32)(1075)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BOOT_ALREADY_ACCEPTED</unmanaged>
        /// <unmanaged-short>ERROR_BOOT_ALREADY_ACCEPTED</unmanaged-short>
        BootAlreadyAccepted = unchecked((System.Int32)(1076)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_NEVER_STARTED</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_NEVER_STARTED</unmanaged-short>
        ServiceNeverStarted = unchecked((System.Int32)(1077)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DUPLICATE_SERVICE_NAME</unmanaged>
        /// <unmanaged-short>ERROR_DUPLICATE_SERVICE_NAME</unmanaged-short>
        DuplicateServiceName = unchecked((System.Int32)(1078)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIFFERENT_SERVICE_ACCOUNT</unmanaged>
        /// <unmanaged-short>ERROR_DIFFERENT_SERVICE_ACCOUNT</unmanaged-short>
        DifferentServiceAccount = unchecked((System.Int32)(1079)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_DETECT_DRIVER_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_DETECT_DRIVER_FAILURE</unmanaged-short>
        CannotDetectDriverFailure = unchecked((System.Int32)(1080)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_DETECT_PROCESS_ABORT</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_DETECT_PROCESS_ABORT</unmanaged-short>
        CannotDetectProcessAbort = unchecked((System.Int32)(1081)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_RECOVERY_PROGRAM</unmanaged>
        /// <unmanaged-short>ERROR_NO_RECOVERY_PROGRAM</unmanaged-short>
        NoRecoveryProgram = unchecked((System.Int32)(1082)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_NOT_IN_EXE</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_NOT_IN_EXE</unmanaged-short>
        ServiceNotInExe = unchecked((System.Int32)(1083)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SAFEBOOT_SERVICE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SAFEBOOT_SERVICE</unmanaged-short>
        NotSafebootService = unchecked((System.Int32)(1084)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_END_OF_MEDIA</unmanaged>
        /// <unmanaged-short>ERROR_END_OF_MEDIA</unmanaged-short>
        EndOfMedia = unchecked((System.Int32)(1100)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILEMARK_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_FILEMARK_DETECTED</unmanaged-short>
        FilemarkDetected = unchecked((System.Int32)(1101)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BEGINNING_OF_MEDIA</unmanaged>
        /// <unmanaged-short>ERROR_BEGINNING_OF_MEDIA</unmanaged-short>
        BeginningOfMedia = unchecked((System.Int32)(1102)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SETMARK_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_SETMARK_DETECTED</unmanaged-short>
        SetmarkDetected = unchecked((System.Int32)(1103)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_DATA_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_NO_DATA_DETECTED</unmanaged-short>
        NoDataDetected = unchecked((System.Int32)(1104)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PARTITION_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_PARTITION_FAILURE</unmanaged-short>
        PartitionFailure = unchecked((System.Int32)(1105)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_BLOCK_LENGTH</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_BLOCK_LENGTH</unmanaged-short>
        InvalidBlockLength = unchecked((System.Int32)(1106)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_NOT_PARTITIONED</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_NOT_PARTITIONED</unmanaged-short>
        DeviceNotPartitioned = unchecked((System.Int32)(1107)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_LOCK_MEDIA</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_LOCK_MEDIA</unmanaged-short>
        UnableToLockMedia = unchecked((System.Int32)(1108)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_UNLOAD_MEDIA</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_UNLOAD_MEDIA</unmanaged-short>
        UnableToUnloadMedia = unchecked((System.Int32)(1109)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEDIA_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_MEDIA_CHANGED</unmanaged-short>
        MediaChanged = unchecked((System.Int32)(1110)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BUS_RESET</unmanaged>
        /// <unmanaged-short>ERROR_BUS_RESET</unmanaged-short>
        BusReset = unchecked((System.Int32)(1111)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_MEDIA_IN_DRIVE</unmanaged>
        /// <unmanaged-short>ERROR_NO_MEDIA_IN_DRIVE</unmanaged-short>
        NoMediaInDrive = unchecked((System.Int32)(1112)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_UNICODE_TRANSLATION</unmanaged>
        /// <unmanaged-short>ERROR_NO_UNICODE_TRANSLATION</unmanaged-short>
        NoUnicodeTranslation = unchecked((System.Int32)(1113)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DLL_INIT_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DLL_INIT_FAILED</unmanaged-short>
        DllInitFailed = unchecked((System.Int32)(1114)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHUTDOWN_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_SHUTDOWN_IN_PROGRESS</unmanaged-short>
        ShutdownInProgress = unchecked((System.Int32)(1115)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SHUTDOWN_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_NO_SHUTDOWN_IN_PROGRESS</unmanaged-short>
        NoShutdownInProgress = unchecked((System.Int32)(1116)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IO_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_IO_DEVICE</unmanaged-short>
        IoDevice = unchecked((System.Int32)(1117)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERIAL_NO_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_SERIAL_NO_DEVICE</unmanaged-short>
        SerialNoDevice = unchecked((System.Int32)(1118)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IRQ_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_IRQ_BUSY</unmanaged-short>
        IrqBusy = unchecked((System.Int32)(1119)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MORE_WRITES</unmanaged>
        /// <unmanaged-short>ERROR_MORE_WRITES</unmanaged-short>
        MoreWrites = unchecked((System.Int32)(1120)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COUNTER_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_COUNTER_TIMEOUT</unmanaged-short>
        CounterTimeout = unchecked((System.Int32)(1121)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLOPPY_ID_MARK_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_FLOPPY_ID_MARK_NOT_FOUND</unmanaged-short>
        FloppyIdMarkNotFound = unchecked((System.Int32)(1122)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLOPPY_WRONG_CYLINDER</unmanaged>
        /// <unmanaged-short>ERROR_FLOPPY_WRONG_CYLINDER</unmanaged-short>
        FloppyWrongCylinder = unchecked((System.Int32)(1123)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLOPPY_UNKNOWN_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_FLOPPY_UNKNOWN_ERROR</unmanaged-short>
        FloppyUnknownError = unchecked((System.Int32)(1124)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLOPPY_BAD_REGISTERS</unmanaged>
        /// <unmanaged-short>ERROR_FLOPPY_BAD_REGISTERS</unmanaged-short>
        FloppyBadRegisters = unchecked((System.Int32)(1125)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_RECALIBRATE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DISK_RECALIBRATE_FAILED</unmanaged-short>
        DiskRecalibrateFailed = unchecked((System.Int32)(1126)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_OPERATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DISK_OPERATION_FAILED</unmanaged-short>
        DiskOperationFailed = unchecked((System.Int32)(1127)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_RESET_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DISK_RESET_FAILED</unmanaged-short>
        DiskResetFailed = unchecked((System.Int32)(1128)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EOM_OVERFLOW</unmanaged>
        /// <unmanaged-short>ERROR_EOM_OVERFLOW</unmanaged-short>
        EomOverflow = unchecked((System.Int32)(1129)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_ENOUGH_SERVER_MEMORY</unmanaged>
        /// <unmanaged-short>ERROR_NOT_ENOUGH_SERVER_MEMORY</unmanaged-short>
        NotEnoughServerMemory = unchecked((System.Int32)(1130)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_POSSIBLE_DEADLOCK</unmanaged>
        /// <unmanaged-short>ERROR_POSSIBLE_DEADLOCK</unmanaged-short>
        PossibleDeadlock = unchecked((System.Int32)(1131)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MAPPED_ALIGNMENT</unmanaged>
        /// <unmanaged-short>ERROR_MAPPED_ALIGNMENT</unmanaged-short>
        MappedAlignment = unchecked((System.Int32)(1132)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SET_POWER_STATE_VETOED</unmanaged>
        /// <unmanaged-short>ERROR_SET_POWER_STATE_VETOED</unmanaged-short>
        SetPowerStateVetoed = unchecked((System.Int32)(1140)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SET_POWER_STATE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_SET_POWER_STATE_FAILED</unmanaged-short>
        SetPowerStateFailed = unchecked((System.Int32)(1141)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_LINKS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_LINKS</unmanaged-short>
        TooManyLinks = unchecked((System.Int32)(1142)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OLD_WIN_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_OLD_WIN_VERSION</unmanaged-short>
        OldWinVersion = unchecked((System.Int32)(1150)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APP_WRONG_OS</unmanaged>
        /// <unmanaged-short>ERROR_APP_WRONG_OS</unmanaged-short>
        AppWrongOs = unchecked((System.Int32)(1151)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SINGLE_INSTANCE_APP</unmanaged>
        /// <unmanaged-short>ERROR_SINGLE_INSTANCE_APP</unmanaged-short>
        SingleInstanceApp = unchecked((System.Int32)(1152)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RMODE_APP</unmanaged>
        /// <unmanaged-short>ERROR_RMODE_APP</unmanaged-short>
        RmodeApp = unchecked((System.Int32)(1153)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DLL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DLL</unmanaged-short>
        InvalidDll = unchecked((System.Int32)(1154)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_ASSOCIATION</unmanaged>
        /// <unmanaged-short>ERROR_NO_ASSOCIATION</unmanaged-short>
        NoAssociation = unchecked((System.Int32)(1155)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DDE_FAIL</unmanaged>
        /// <unmanaged-short>ERROR_DDE_FAIL</unmanaged-short>
        DdeFail = unchecked((System.Int32)(1156)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DLL_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DLL_NOT_FOUND</unmanaged-short>
        DllNotFound = unchecked((System.Int32)(1157)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_MORE_USER_HANDLES</unmanaged>
        /// <unmanaged-short>ERROR_NO_MORE_USER_HANDLES</unmanaged-short>
        NoMoreUserHandles = unchecked((System.Int32)(1158)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MESSAGE_SYNC_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_MESSAGE_SYNC_ONLY</unmanaged-short>
        MessageSyncOnly = unchecked((System.Int32)(1159)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SOURCE_ELEMENT_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_SOURCE_ELEMENT_EMPTY</unmanaged-short>
        SourceElementEmpty = unchecked((System.Int32)(1160)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DESTINATION_ELEMENT_FULL</unmanaged>
        /// <unmanaged-short>ERROR_DESTINATION_ELEMENT_FULL</unmanaged-short>
        DestinationElementFull = unchecked((System.Int32)(1161)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ILLEGAL_ELEMENT_ADDRESS</unmanaged>
        /// <unmanaged-short>ERROR_ILLEGAL_ELEMENT_ADDRESS</unmanaged-short>
        IllegalElementAddress = unchecked((System.Int32)(1162)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MAGAZINE_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_MAGAZINE_NOT_PRESENT</unmanaged-short>
        MagazineNotPresent = unchecked((System.Int32)(1163)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_REINITIALIZATION_NEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_REINITIALIZATION_NEEDED</unmanaged-short>
        DeviceReinitializationNeeded = unchecked((System.Int32)(1164)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_REQUIRES_CLEANING</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_REQUIRES_CLEANING</unmanaged-short>
        DeviceRequiresCleaning = unchecked((System.Int32)(1165)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_DOOR_OPEN</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_DOOR_OPEN</unmanaged-short>
        DeviceDoorOpen = unchecked((System.Int32)(1166)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_NOT_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_NOT_CONNECTED</unmanaged-short>
        DeviceNotConnected = unchecked((System.Int32)(1167)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NOT_FOUND</unmanaged-short>
        NotFound = unchecked((System.Int32)(1168)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_MATCH</unmanaged>
        /// <unmanaged-short>ERROR_NO_MATCH</unmanaged-short>
        NoMatch = unchecked((System.Int32)(1169)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SET_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SET_NOT_FOUND</unmanaged-short>
        SetNotFound = unchecked((System.Int32)(1170)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_POINT_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_POINT_NOT_FOUND</unmanaged-short>
        PointNotFound = unchecked((System.Int32)(1171)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_TRACKING_SERVICE</unmanaged>
        /// <unmanaged-short>ERROR_NO_TRACKING_SERVICE</unmanaged-short>
        NoTrackingService = unchecked((System.Int32)(1172)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_VOLUME_ID</unmanaged>
        /// <unmanaged-short>ERROR_NO_VOLUME_ID</unmanaged-short>
        NoVolumeId = unchecked((System.Int32)(1173)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_REMOVE_REPLACED</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_REMOVE_REPLACED</unmanaged-short>
        UnableToRemoveReplaced = unchecked((System.Int32)(1175)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_MOVE_REPLACEMENT</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_MOVE_REPLACEMENT</unmanaged-short>
        UnableToMoveReplacement = unchecked((System.Int32)(1176)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_MOVE_REPLACEMENT_2</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_MOVE_REPLACEMENT_2</unmanaged-short>
        UnableToMoveReplacement2 = unchecked((System.Int32)(1177)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_JOURNAL_DELETE_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_JOURNAL_DELETE_IN_PROGRESS</unmanaged-short>
        JournalDeleteInProgress = unchecked((System.Int32)(1178)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_JOURNAL_NOT_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_JOURNAL_NOT_ACTIVE</unmanaged-short>
        JournalNotActive = unchecked((System.Int32)(1179)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_POTENTIAL_FILE_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_POTENTIAL_FILE_FOUND</unmanaged-short>
        PotentialFileFound = unchecked((System.Int32)(1180)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_JOURNAL_ENTRY_DELETED</unmanaged>
        /// <unmanaged-short>ERROR_JOURNAL_ENTRY_DELETED</unmanaged-short>
        JournalEntryDeleted = unchecked((System.Int32)(1181)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHUTDOWN_IS_SCHEDULED</unmanaged>
        /// <unmanaged-short>ERROR_SHUTDOWN_IS_SCHEDULED</unmanaged-short>
        ShutdownIsScheduled = unchecked((System.Int32)(1190)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHUTDOWN_USERS_LOGGED_ON</unmanaged>
        /// <unmanaged-short>ERROR_SHUTDOWN_USERS_LOGGED_ON</unmanaged-short>
        ShutdownUsersLoggedOn = unchecked((System.Int32)(1191)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_DEVICE</unmanaged-short>
        BadDevice = unchecked((System.Int32)(1200)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONNECTION_UNAVAIL</unmanaged>
        /// <unmanaged-short>ERROR_CONNECTION_UNAVAIL</unmanaged-short>
        ConnectionUnavail = unchecked((System.Int32)(1201)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_ALREADY_REMEMBERED</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_ALREADY_REMEMBERED</unmanaged-short>
        DeviceAlreadyRemembered = unchecked((System.Int32)(1202)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_NET_OR_BAD_PATH</unmanaged>
        /// <unmanaged-short>ERROR_NO_NET_OR_BAD_PATH</unmanaged-short>
        NoNetOrBadPath = unchecked((System.Int32)(1203)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_PROVIDER</unmanaged>
        /// <unmanaged-short>ERROR_BAD_PROVIDER</unmanaged-short>
        BadProvider = unchecked((System.Int32)(1204)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_OPEN_PROFILE</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_OPEN_PROFILE</unmanaged-short>
        CannotOpenProfile = unchecked((System.Int32)(1205)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_PROFILE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_PROFILE</unmanaged-short>
        BadProfile = unchecked((System.Int32)(1206)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_CONTAINER</unmanaged>
        /// <unmanaged-short>ERROR_NOT_CONTAINER</unmanaged-short>
        NotContainer = unchecked((System.Int32)(1207)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXTENDED_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_EXTENDED_ERROR</unmanaged-short>
        ExtendedError = unchecked((System.Int32)(1208)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_GROUPNAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_GROUPNAME</unmanaged-short>
        InvalidGroupname = unchecked((System.Int32)(1209)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_COMPUTERNAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_COMPUTERNAME</unmanaged-short>
        InvalidComputername = unchecked((System.Int32)(1210)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_EVENTNAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_EVENTNAME</unmanaged-short>
        InvalidEventname = unchecked((System.Int32)(1211)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DOMAINNAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DOMAINNAME</unmanaged-short>
        InvalidDomainname = unchecked((System.Int32)(1212)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SERVICENAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SERVICENAME</unmanaged-short>
        InvalidServicename = unchecked((System.Int32)(1213)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_NETNAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_NETNAME</unmanaged-short>
        InvalidNetname = unchecked((System.Int32)(1214)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SHARENAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SHARENAME</unmanaged-short>
        InvalidSharename = unchecked((System.Int32)(1215)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PASSWORDNAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PASSWORDNAME</unmanaged-short>
        InvalidPasswordname = unchecked((System.Int32)(1216)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MESSAGENAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MESSAGENAME</unmanaged-short>
        InvalidMessagename = unchecked((System.Int32)(1217)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MESSAGEDEST</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MESSAGEDEST</unmanaged-short>
        InvalidMessagedest = unchecked((System.Int32)(1218)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SESSION_CREDENTIAL_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_SESSION_CREDENTIAL_CONFLICT</unmanaged-short>
        SessionCredentialConflict = unchecked((System.Int32)(1219)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REMOTE_SESSION_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_REMOTE_SESSION_LIMIT_EXCEEDED</unmanaged-short>
        RemoteSessionLimitExceeded = unchecked((System.Int32)(1220)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DUP_DOMAINNAME</unmanaged>
        /// <unmanaged-short>ERROR_DUP_DOMAINNAME</unmanaged-short>
        DupDomainname = unchecked((System.Int32)(1221)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_NETWORK</unmanaged>
        /// <unmanaged-short>ERROR_NO_NETWORK</unmanaged-short>
        NoNetwork = unchecked((System.Int32)(1222)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANCELLED</unmanaged>
        /// <unmanaged-short>ERROR_CANCELLED</unmanaged-short>
        Cancelled = unchecked((System.Int32)(1223)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_USER_MAPPED_FILE</unmanaged>
        /// <unmanaged-short>ERROR_USER_MAPPED_FILE</unmanaged-short>
        UserMappedFile = unchecked((System.Int32)(1224)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONNECTION_REFUSED</unmanaged>
        /// <unmanaged-short>ERROR_CONNECTION_REFUSED</unmanaged-short>
        ConnectionRefused = unchecked((System.Int32)(1225)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRACEFUL_DISCONNECT</unmanaged>
        /// <unmanaged-short>ERROR_GRACEFUL_DISCONNECT</unmanaged-short>
        GracefulDisconnect = unchecked((System.Int32)(1226)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ADDRESS_ALREADY_ASSOCIATED</unmanaged>
        /// <unmanaged-short>ERROR_ADDRESS_ALREADY_ASSOCIATED</unmanaged-short>
        AddressAlreadyAssociated = unchecked((System.Int32)(1227)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ADDRESS_NOT_ASSOCIATED</unmanaged>
        /// <unmanaged-short>ERROR_ADDRESS_NOT_ASSOCIATED</unmanaged-short>
        AddressNotAssociated = unchecked((System.Int32)(1228)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONNECTION_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_CONNECTION_INVALID</unmanaged-short>
        ConnectionInvalid = unchecked((System.Int32)(1229)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONNECTION_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_CONNECTION_ACTIVE</unmanaged-short>
        ConnectionActive = unchecked((System.Int32)(1230)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NETWORK_UNREACHABLE</unmanaged>
        /// <unmanaged-short>ERROR_NETWORK_UNREACHABLE</unmanaged-short>
        NetworkUnreachable = unchecked((System.Int32)(1231)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOST_UNREACHABLE</unmanaged>
        /// <unmanaged-short>ERROR_HOST_UNREACHABLE</unmanaged-short>
        HostUnreachable = unchecked((System.Int32)(1232)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROTOCOL_UNREACHABLE</unmanaged>
        /// <unmanaged-short>ERROR_PROTOCOL_UNREACHABLE</unmanaged-short>
        ProtocolUnreachable = unchecked((System.Int32)(1233)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PORT_UNREACHABLE</unmanaged>
        /// <unmanaged-short>ERROR_PORT_UNREACHABLE</unmanaged-short>
        PortUnreachable = unchecked((System.Int32)(1234)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REQUEST_ABORTED</unmanaged>
        /// <unmanaged-short>ERROR_REQUEST_ABORTED</unmanaged-short>
        RequestAborted = unchecked((System.Int32)(1235)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONNECTION_ABORTED</unmanaged>
        /// <unmanaged-short>ERROR_CONNECTION_ABORTED</unmanaged-short>
        ConnectionAborted = unchecked((System.Int32)(1236)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RETRY</unmanaged>
        /// <unmanaged-short>ERROR_RETRY</unmanaged-short>
        Retry = unchecked((System.Int32)(1237)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONNECTION_COUNT_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_CONNECTION_COUNT_LIMIT</unmanaged-short>
        ConnectionCountLimit = unchecked((System.Int32)(1238)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOGIN_TIME_RESTRICTION</unmanaged>
        /// <unmanaged-short>ERROR_LOGIN_TIME_RESTRICTION</unmanaged-short>
        LoginTimeRestriction = unchecked((System.Int32)(1239)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOGIN_WKSTA_RESTRICTION</unmanaged>
        /// <unmanaged-short>ERROR_LOGIN_WKSTA_RESTRICTION</unmanaged-short>
        LoginWkstaRestriction = unchecked((System.Int32)(1240)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INCORRECT_ADDRESS</unmanaged>
        /// <unmanaged-short>ERROR_INCORRECT_ADDRESS</unmanaged-short>
        IncorrectAddress = unchecked((System.Int32)(1241)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_REGISTERED</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_REGISTERED</unmanaged-short>
        AlreadyRegistered = unchecked((System.Int32)(1242)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_NOT_FOUND</unmanaged-short>
        ServiceNotFound = unchecked((System.Int32)(1243)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_AUTHENTICATED</unmanaged>
        /// <unmanaged-short>ERROR_NOT_AUTHENTICATED</unmanaged-short>
        NotAuthenticated = unchecked((System.Int32)(1244)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_LOGGED_ON</unmanaged>
        /// <unmanaged-short>ERROR_NOT_LOGGED_ON</unmanaged-short>
        NotLoggedOn = unchecked((System.Int32)(1245)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONTINUE</unmanaged>
        /// <unmanaged-short>ERROR_CONTINUE</unmanaged-short>
        Continue = unchecked((System.Int32)(1246)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_INITIALIZED</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_INITIALIZED</unmanaged-short>
        AlreadyInitialized = unchecked((System.Int32)(1247)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_MORE_DEVICES</unmanaged>
        /// <unmanaged-short>ERROR_NO_MORE_DEVICES</unmanaged-short>
        NoMoreDevices = unchecked((System.Int32)(1248)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_SITE</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_SITE</unmanaged-short>
        NoSuchSite = unchecked((System.Int32)(1249)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DOMAIN_CONTROLLER_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DOMAIN_CONTROLLER_EXISTS</unmanaged-short>
        DomainControllerExists = unchecked((System.Int32)(1250)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ONLY_IF_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_ONLY_IF_CONNECTED</unmanaged-short>
        OnlyIfConnected = unchecked((System.Int32)(1251)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OVERRIDE_NOCHANGES</unmanaged>
        /// <unmanaged-short>ERROR_OVERRIDE_NOCHANGES</unmanaged-short>
        OverrideNochanges = unchecked((System.Int32)(1252)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_USER_PROFILE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_USER_PROFILE</unmanaged-short>
        BadUserProfile = unchecked((System.Int32)(1253)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SUPPORTED_ON_SBS</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SUPPORTED_ON_SBS</unmanaged-short>
        NotSupportedOnSbs = unchecked((System.Int32)(1254)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVER_SHUTDOWN_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_SERVER_SHUTDOWN_IN_PROGRESS</unmanaged-short>
        ServerShutdownInProgress = unchecked((System.Int32)(1255)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOST_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_HOST_DOWN</unmanaged-short>
        HostDown = unchecked((System.Int32)(1256)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NON_ACCOUNT_SID</unmanaged>
        /// <unmanaged-short>ERROR_NON_ACCOUNT_SID</unmanaged-short>
        NonAccountSid = unchecked((System.Int32)(1257)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NON_DOMAIN_SID</unmanaged>
        /// <unmanaged-short>ERROR_NON_DOMAIN_SID</unmanaged-short>
        NonDomainSid = unchecked((System.Int32)(1258)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPHELP_BLOCK</unmanaged>
        /// <unmanaged-short>ERROR_APPHELP_BLOCK</unmanaged-short>
        ApphelpBlock = unchecked((System.Int32)(1259)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCESS_DISABLED_BY_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_ACCESS_DISABLED_BY_POLICY</unmanaged-short>
        AccessDisabledByPolicy = unchecked((System.Int32)(1260)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REG_NAT_CONSUMPTION</unmanaged>
        /// <unmanaged-short>ERROR_REG_NAT_CONSUMPTION</unmanaged-short>
        RegNatConsumption = unchecked((System.Int32)(1261)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CSCSHARE_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_CSCSHARE_OFFLINE</unmanaged-short>
        CscshareOffline = unchecked((System.Int32)(1262)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PKINIT_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_PKINIT_FAILURE</unmanaged-short>
        PkinitFailure = unchecked((System.Int32)(1263)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SMARTCARD_SUBSYSTEM_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_SMARTCARD_SUBSYSTEM_FAILURE</unmanaged-short>
        SmartcardSubsystemFailure = unchecked((System.Int32)(1264)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DOWNGRADE_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_DOWNGRADE_DETECTED</unmanaged-short>
        DowngradeDetected = unchecked((System.Int32)(1265)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MACHINE_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_MACHINE_LOCKED</unmanaged-short>
        MachineLocked = unchecked((System.Int32)(1271)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SMB_GUEST_LOGON_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_SMB_GUEST_LOGON_BLOCKED</unmanaged-short>
        SmbGuestLogonBlocked = unchecked((System.Int32)(1272)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CALLBACK_SUPPLIED_INVALID_DATA</unmanaged>
        /// <unmanaged-short>ERROR_CALLBACK_SUPPLIED_INVALID_DATA</unmanaged-short>
        CallbackSuppliedInvalidData = unchecked((System.Int32)(1273)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED</unmanaged-short>
        SyncForegroundRefreshRequired = unchecked((System.Int32)(1274)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVER_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_DRIVER_BLOCKED</unmanaged-short>
        DriverBlocked = unchecked((System.Int32)(1275)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_IMPORT_OF_NON_DLL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_IMPORT_OF_NON_DLL</unmanaged-short>
        InvalidImportOfNonDll = unchecked((System.Int32)(1276)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCESS_DISABLED_WEBBLADE</unmanaged>
        /// <unmanaged-short>ERROR_ACCESS_DISABLED_WEBBLADE</unmanaged-short>
        AccessDisabledWebblade = unchecked((System.Int32)(1277)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER</unmanaged>
        /// <unmanaged-short>ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER</unmanaged-short>
        AccessDisabledWebbladeTamper = unchecked((System.Int32)(1278)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RECOVERY_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_RECOVERY_FAILURE</unmanaged-short>
        RecoveryFailure = unchecked((System.Int32)(1279)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_FIBER</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_FIBER</unmanaged-short>
        AlreadyFiber = unchecked((System.Int32)(1280)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_THREAD</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_THREAD</unmanaged-short>
        AlreadyThread = unchecked((System.Int32)(1281)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STACK_BUFFER_OVERRUN</unmanaged>
        /// <unmanaged-short>ERROR_STACK_BUFFER_OVERRUN</unmanaged-short>
        StackBufferOverrun = unchecked((System.Int32)(1282)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PARAMETER_QUOTA_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_PARAMETER_QUOTA_EXCEEDED</unmanaged-short>
        ParameterQuotaExceeded = unchecked((System.Int32)(1283)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEBUGGER_INACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_DEBUGGER_INACTIVE</unmanaged-short>
        DebuggerInactive = unchecked((System.Int32)(1284)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DELAY_LOAD_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DELAY_LOAD_FAILED</unmanaged-short>
        DelayLoadFailed = unchecked((System.Int32)(1285)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VDM_DISALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_VDM_DISALLOWED</unmanaged-short>
        VdmDisallowed = unchecked((System.Int32)(1286)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNIDENTIFIED_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_UNIDENTIFIED_ERROR</unmanaged-short>
        UnidentifiedError = unchecked((System.Int32)(1287)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_CRUNTIME_PARAMETER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_CRUNTIME_PARAMETER</unmanaged-short>
        InvalidCruntimeParameter = unchecked((System.Int32)(1288)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BEYOND_VDL</unmanaged>
        /// <unmanaged-short>ERROR_BEYOND_VDL</unmanaged-short>
        BeyondVdl = unchecked((System.Int32)(1289)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INCOMPATIBLE_SERVICE_SID_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_INCOMPATIBLE_SERVICE_SID_TYPE</unmanaged-short>
        IncompatibleServiceSidType = unchecked((System.Int32)(1290)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVER_PROCESS_TERMINATED</unmanaged>
        /// <unmanaged-short>ERROR_DRIVER_PROCESS_TERMINATED</unmanaged-short>
        DriverProcessTerminated = unchecked((System.Int32)(1291)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IMPLEMENTATION_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_IMPLEMENTATION_LIMIT</unmanaged-short>
        ImplementationLimit = unchecked((System.Int32)(1292)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROCESS_IS_PROTECTED</unmanaged>
        /// <unmanaged-short>ERROR_PROCESS_IS_PROTECTED</unmanaged-short>
        ProcessIsProtected = unchecked((System.Int32)(1293)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICE_NOTIFY_CLIENT_LAGGING</unmanaged>
        /// <unmanaged-short>ERROR_SERVICE_NOTIFY_CLIENT_LAGGING</unmanaged-short>
        ServiceNotifyClientLagging = unchecked((System.Int32)(1294)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_QUOTA_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DISK_QUOTA_EXCEEDED</unmanaged-short>
        DiskQuotaExceeded = unchecked((System.Int32)(1295)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONTENT_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_CONTENT_BLOCKED</unmanaged-short>
        ContentBlocked = unchecked((System.Int32)(1296)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE</unmanaged>
        /// <unmanaged-short>ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE</unmanaged-short>
        IncompatibleServicePrivilege = unchecked((System.Int32)(1297)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APP_HANG</unmanaged>
        /// <unmanaged-short>ERROR_APP_HANG</unmanaged-short>
        AppHang = unchecked((System.Int32)(1298)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LABEL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LABEL</unmanaged-short>
        InvalidLabel = unchecked((System.Int32)(1299)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_ALL_ASSIGNED</unmanaged>
        /// <unmanaged-short>ERROR_NOT_ALL_ASSIGNED</unmanaged-short>
        NotAllAssigned = unchecked((System.Int32)(1300)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SOME_NOT_MAPPED</unmanaged>
        /// <unmanaged-short>ERROR_SOME_NOT_MAPPED</unmanaged-short>
        SomeNotMapped = unchecked((System.Int32)(1301)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_QUOTAS_FOR_ACCOUNT</unmanaged>
        /// <unmanaged-short>ERROR_NO_QUOTAS_FOR_ACCOUNT</unmanaged-short>
        NoQuotasForAccount = unchecked((System.Int32)(1302)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOCAL_USER_SESSION_KEY</unmanaged>
        /// <unmanaged-short>ERROR_LOCAL_USER_SESSION_KEY</unmanaged-short>
        LocalUserSessionKey = unchecked((System.Int32)(1303)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NULL_LM_PASSWORD</unmanaged>
        /// <unmanaged-short>ERROR_NULL_LM_PASSWORD</unmanaged-short>
        NullLmPassword = unchecked((System.Int32)(1304)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_REVISION</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_REVISION</unmanaged-short>
        UnknownRevision = unchecked((System.Int32)(1305)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REVISION_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_REVISION_MISMATCH</unmanaged-short>
        RevisionMismatch = unchecked((System.Int32)(1306)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_OWNER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_OWNER</unmanaged-short>
        InvalidOwner = unchecked((System.Int32)(1307)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PRIMARY_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PRIMARY_GROUP</unmanaged-short>
        InvalidPrimaryGroup = unchecked((System.Int32)(1308)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_IMPERSONATION_TOKEN</unmanaged>
        /// <unmanaged-short>ERROR_NO_IMPERSONATION_TOKEN</unmanaged-short>
        NoImpersonationToken = unchecked((System.Int32)(1309)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_DISABLE_MANDATORY</unmanaged>
        /// <unmanaged-short>ERROR_CANT_DISABLE_MANDATORY</unmanaged-short>
        CantDisableMandatory = unchecked((System.Int32)(1310)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_LOGON_SERVERS</unmanaged>
        /// <unmanaged-short>ERROR_NO_LOGON_SERVERS</unmanaged-short>
        NoLogonServers = unchecked((System.Int32)(1311)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_LOGON_SESSION</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_LOGON_SESSION</unmanaged-short>
        NoSuchLogonSession = unchecked((System.Int32)(1312)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_PRIVILEGE</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_PRIVILEGE</unmanaged-short>
        NoSuchPrivilege = unchecked((System.Int32)(1313)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRIVILEGE_NOT_HELD</unmanaged>
        /// <unmanaged-short>ERROR_PRIVILEGE_NOT_HELD</unmanaged-short>
        PrivilegeNotHeld = unchecked((System.Int32)(1314)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ACCOUNT_NAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ACCOUNT_NAME</unmanaged-short>
        InvalidAccountName = unchecked((System.Int32)(1315)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_USER_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_USER_EXISTS</unmanaged-short>
        UserExists = unchecked((System.Int32)(1316)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_USER</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_USER</unmanaged-short>
        NoSuchUser = unchecked((System.Int32)(1317)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GROUP_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_GROUP_EXISTS</unmanaged-short>
        GroupExists = unchecked((System.Int32)(1318)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_GROUP</unmanaged-short>
        NoSuchGroup = unchecked((System.Int32)(1319)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEMBER_IN_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_MEMBER_IN_GROUP</unmanaged-short>
        MemberInGroup = unchecked((System.Int32)(1320)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEMBER_NOT_IN_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_MEMBER_NOT_IN_GROUP</unmanaged-short>
        MemberNotInGroup = unchecked((System.Int32)(1321)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LAST_ADMIN</unmanaged>
        /// <unmanaged-short>ERROR_LAST_ADMIN</unmanaged-short>
        LastAdmin = unchecked((System.Int32)(1322)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WRONG_PASSWORD</unmanaged>
        /// <unmanaged-short>ERROR_WRONG_PASSWORD</unmanaged-short>
        WrongPassword = unchecked((System.Int32)(1323)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ILL_FORMED_PASSWORD</unmanaged>
        /// <unmanaged-short>ERROR_ILL_FORMED_PASSWORD</unmanaged-short>
        IllFormedPassword = unchecked((System.Int32)(1324)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PASSWORD_RESTRICTION</unmanaged>
        /// <unmanaged-short>ERROR_PASSWORD_RESTRICTION</unmanaged-short>
        PasswordRestriction = unchecked((System.Int32)(1325)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOGON_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_LOGON_FAILURE</unmanaged-short>
        LogonFailure = unchecked((System.Int32)(1326)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCOUNT_RESTRICTION</unmanaged>
        /// <unmanaged-short>ERROR_ACCOUNT_RESTRICTION</unmanaged-short>
        AccountRestriction = unchecked((System.Int32)(1327)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LOGON_HOURS</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LOGON_HOURS</unmanaged-short>
        InvalidLogonHours = unchecked((System.Int32)(1328)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_WORKSTATION</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_WORKSTATION</unmanaged-short>
        InvalidWorkstation = unchecked((System.Int32)(1329)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PASSWORD_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_PASSWORD_EXPIRED</unmanaged-short>
        PasswordExpired = unchecked((System.Int32)(1330)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCOUNT_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_ACCOUNT_DISABLED</unmanaged-short>
        AccountDisabled = unchecked((System.Int32)(1331)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NONE_MAPPED</unmanaged>
        /// <unmanaged-short>ERROR_NONE_MAPPED</unmanaged-short>
        NoneMapped = unchecked((System.Int32)(1332)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_LUIDS_REQUESTED</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_LUIDS_REQUESTED</unmanaged-short>
        TooManyLuidsRequested = unchecked((System.Int32)(1333)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LUIDS_EXHAUSTED</unmanaged>
        /// <unmanaged-short>ERROR_LUIDS_EXHAUSTED</unmanaged-short>
        LuidsExhausted = unchecked((System.Int32)(1334)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SUB_AUTHORITY</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SUB_AUTHORITY</unmanaged-short>
        InvalidSubAuthority = unchecked((System.Int32)(1335)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ACL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ACL</unmanaged-short>
        InvalidAcl = unchecked((System.Int32)(1336)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SID</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SID</unmanaged-short>
        InvalidSid = unchecked((System.Int32)(1337)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SECURITY_DESCR</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SECURITY_DESCR</unmanaged-short>
        InvalidSecurityDescr = unchecked((System.Int32)(1338)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_INHERITANCE_ACL</unmanaged>
        /// <unmanaged-short>ERROR_BAD_INHERITANCE_ACL</unmanaged-short>
        BadInheritanceAcl = unchecked((System.Int32)(1340)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVER_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_SERVER_DISABLED</unmanaged-short>
        ServerDisabled = unchecked((System.Int32)(1341)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVER_NOT_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_SERVER_NOT_DISABLED</unmanaged-short>
        ServerNotDisabled = unchecked((System.Int32)(1342)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ID_AUTHORITY</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ID_AUTHORITY</unmanaged-short>
        InvalidIdAuthority = unchecked((System.Int32)(1343)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALLOTTED_SPACE_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_ALLOTTED_SPACE_EXCEEDED</unmanaged-short>
        AllottedSpaceExceeded = unchecked((System.Int32)(1344)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_GROUP_ATTRIBUTES</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_GROUP_ATTRIBUTES</unmanaged-short>
        InvalidGroupAttributes = unchecked((System.Int32)(1345)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_IMPERSONATION_LEVEL</unmanaged>
        /// <unmanaged-short>ERROR_BAD_IMPERSONATION_LEVEL</unmanaged-short>
        BadImpersonationLevel = unchecked((System.Int32)(1346)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_OPEN_ANONYMOUS</unmanaged>
        /// <unmanaged-short>ERROR_CANT_OPEN_ANONYMOUS</unmanaged-short>
        CantOpenAnonymous = unchecked((System.Int32)(1347)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_VALIDATION_CLASS</unmanaged>
        /// <unmanaged-short>ERROR_BAD_VALIDATION_CLASS</unmanaged-short>
        BadValidationClass = unchecked((System.Int32)(1348)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_TOKEN_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_TOKEN_TYPE</unmanaged-short>
        BadTokenType = unchecked((System.Int32)(1349)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SECURITY_ON_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_NO_SECURITY_ON_OBJECT</unmanaged-short>
        NoSecurityOnObject = unchecked((System.Int32)(1350)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_ACCESS_DOMAIN_INFO</unmanaged>
        /// <unmanaged-short>ERROR_CANT_ACCESS_DOMAIN_INFO</unmanaged-short>
        CantAccessDomainInfo = unchecked((System.Int32)(1351)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SERVER_STATE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SERVER_STATE</unmanaged-short>
        InvalidServerState = unchecked((System.Int32)(1352)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DOMAIN_STATE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DOMAIN_STATE</unmanaged-short>
        InvalidDomainState = unchecked((System.Int32)(1353)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DOMAIN_ROLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DOMAIN_ROLE</unmanaged-short>
        InvalidDomainRole = unchecked((System.Int32)(1354)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_DOMAIN</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_DOMAIN</unmanaged-short>
        NoSuchDomain = unchecked((System.Int32)(1355)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DOMAIN_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DOMAIN_EXISTS</unmanaged-short>
        DomainExists = unchecked((System.Int32)(1356)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DOMAIN_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DOMAIN_LIMIT_EXCEEDED</unmanaged-short>
        DomainLimitExceeded = unchecked((System.Int32)(1357)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INTERNAL_DB_CORRUPTION</unmanaged>
        /// <unmanaged-short>ERROR_INTERNAL_DB_CORRUPTION</unmanaged-short>
        InternalDbCorruption = unchecked((System.Int32)(1358)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_INTERNAL_ERROR</unmanaged-short>
        InternalError = unchecked((System.Int32)(1359)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GENERIC_NOT_MAPPED</unmanaged>
        /// <unmanaged-short>ERROR_GENERIC_NOT_MAPPED</unmanaged-short>
        GenericNotMapped = unchecked((System.Int32)(1360)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_DESCRIPTOR_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_BAD_DESCRIPTOR_FORMAT</unmanaged-short>
        BadDescriptorFormat = unchecked((System.Int32)(1361)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_LOGON_PROCESS</unmanaged>
        /// <unmanaged-short>ERROR_NOT_LOGON_PROCESS</unmanaged-short>
        NotLogonProcess = unchecked((System.Int32)(1362)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOGON_SESSION_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_LOGON_SESSION_EXISTS</unmanaged-short>
        LogonSessionExists = unchecked((System.Int32)(1363)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_PACKAGE</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_PACKAGE</unmanaged-short>
        NoSuchPackage = unchecked((System.Int32)(1364)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_LOGON_SESSION_STATE</unmanaged>
        /// <unmanaged-short>ERROR_BAD_LOGON_SESSION_STATE</unmanaged-short>
        BadLogonSessionState = unchecked((System.Int32)(1365)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOGON_SESSION_COLLISION</unmanaged>
        /// <unmanaged-short>ERROR_LOGON_SESSION_COLLISION</unmanaged-short>
        LogonSessionCollision = unchecked((System.Int32)(1366)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LOGON_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LOGON_TYPE</unmanaged-short>
        InvalidLogonType = unchecked((System.Int32)(1367)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_IMPERSONATE</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_IMPERSONATE</unmanaged-short>
        CannotImpersonate = unchecked((System.Int32)(1368)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RXACT_INVALID_STATE</unmanaged>
        /// <unmanaged-short>ERROR_RXACT_INVALID_STATE</unmanaged-short>
        RxactInvalidState = unchecked((System.Int32)(1369)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RXACT_COMMIT_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_RXACT_COMMIT_FAILURE</unmanaged-short>
        RxactCommitFailure = unchecked((System.Int32)(1370)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPECIAL_ACCOUNT</unmanaged>
        /// <unmanaged-short>ERROR_SPECIAL_ACCOUNT</unmanaged-short>
        SpecialAccount = unchecked((System.Int32)(1371)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPECIAL_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_SPECIAL_GROUP</unmanaged-short>
        SpecialGroup = unchecked((System.Int32)(1372)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPECIAL_USER</unmanaged>
        /// <unmanaged-short>ERROR_SPECIAL_USER</unmanaged-short>
        SpecialUser = unchecked((System.Int32)(1373)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEMBERS_PRIMARY_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_MEMBERS_PRIMARY_GROUP</unmanaged-short>
        MembersPrimaryGroup = unchecked((System.Int32)(1374)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOKEN_ALREADY_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_TOKEN_ALREADY_IN_USE</unmanaged-short>
        TokenAlreadyInUse = unchecked((System.Int32)(1375)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_ALIAS</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_ALIAS</unmanaged-short>
        NoSuchAlias = unchecked((System.Int32)(1376)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEMBER_NOT_IN_ALIAS</unmanaged>
        /// <unmanaged-short>ERROR_MEMBER_NOT_IN_ALIAS</unmanaged-short>
        MemberNotInAlias = unchecked((System.Int32)(1377)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEMBER_IN_ALIAS</unmanaged>
        /// <unmanaged-short>ERROR_MEMBER_IN_ALIAS</unmanaged-short>
        MemberInAlias = unchecked((System.Int32)(1378)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALIAS_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_ALIAS_EXISTS</unmanaged-short>
        AliasExists = unchecked((System.Int32)(1379)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOGON_NOT_GRANTED</unmanaged>
        /// <unmanaged-short>ERROR_LOGON_NOT_GRANTED</unmanaged-short>
        LogonNotGranted = unchecked((System.Int32)(1380)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_SECRETS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_SECRETS</unmanaged-short>
        TooManySecrets = unchecked((System.Int32)(1381)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECRET_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_SECRET_TOO_LONG</unmanaged-short>
        SecretTooLong = unchecked((System.Int32)(1382)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INTERNAL_DB_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_INTERNAL_DB_ERROR</unmanaged-short>
        InternalDbError = unchecked((System.Int32)(1383)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_CONTEXT_IDS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_CONTEXT_IDS</unmanaged-short>
        TooManyContextIds = unchecked((System.Int32)(1384)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOGON_TYPE_NOT_GRANTED</unmanaged>
        /// <unmanaged-short>ERROR_LOGON_TYPE_NOT_GRANTED</unmanaged-short>
        LogonTypeNotGranted = unchecked((System.Int32)(1385)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NT_CROSS_ENCRYPTION_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_NT_CROSS_ENCRYPTION_REQUIRED</unmanaged-short>
        NtCrossEncryptionRequired = unchecked((System.Int32)(1386)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUCH_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUCH_MEMBER</unmanaged-short>
        NoSuchMember = unchecked((System.Int32)(1387)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MEMBER</unmanaged-short>
        InvalidMember = unchecked((System.Int32)(1388)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TOO_MANY_SIDS</unmanaged>
        /// <unmanaged-short>ERROR_TOO_MANY_SIDS</unmanaged-short>
        TooManySids = unchecked((System.Int32)(1389)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LM_CROSS_ENCRYPTION_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_LM_CROSS_ENCRYPTION_REQUIRED</unmanaged-short>
        LmCrossEncryptionRequired = unchecked((System.Int32)(1390)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_INHERITANCE</unmanaged>
        /// <unmanaged-short>ERROR_NO_INHERITANCE</unmanaged-short>
        NoInheritance = unchecked((System.Int32)(1391)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_FILE_CORRUPT</unmanaged-short>
        FileCorrupt = unchecked((System.Int32)(1392)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_DISK_CORRUPT</unmanaged-short>
        DiskCorrupt = unchecked((System.Int32)(1393)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_USER_SESSION_KEY</unmanaged>
        /// <unmanaged-short>ERROR_NO_USER_SESSION_KEY</unmanaged-short>
        NoUserSessionKey = unchecked((System.Int32)(1394)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LICENSE_QUOTA_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_LICENSE_QUOTA_EXCEEDED</unmanaged-short>
        LicenseQuotaExceeded = unchecked((System.Int32)(1395)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WRONG_TARGET_NAME</unmanaged>
        /// <unmanaged-short>ERROR_WRONG_TARGET_NAME</unmanaged-short>
        WrongTargetName = unchecked((System.Int32)(1396)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUTUAL_AUTH_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_MUTUAL_AUTH_FAILED</unmanaged-short>
        MutualAuthFailed = unchecked((System.Int32)(1397)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIME_SKEW</unmanaged>
        /// <unmanaged-short>ERROR_TIME_SKEW</unmanaged-short>
        TimeSkew = unchecked((System.Int32)(1398)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CURRENT_DOMAIN_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_CURRENT_DOMAIN_NOT_ALLOWED</unmanaged-short>
        CurrentDomainNotAllowed = unchecked((System.Int32)(1399)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_WINDOW_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_WINDOW_HANDLE</unmanaged-short>
        InvalidWindowHandle = unchecked((System.Int32)(1400)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MENU_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MENU_HANDLE</unmanaged-short>
        InvalidMenuHandle = unchecked((System.Int32)(1401)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_CURSOR_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_CURSOR_HANDLE</unmanaged-short>
        InvalidCursorHandle = unchecked((System.Int32)(1402)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ACCEL_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ACCEL_HANDLE</unmanaged-short>
        InvalidAccelHandle = unchecked((System.Int32)(1403)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_HOOK_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_HOOK_HANDLE</unmanaged-short>
        InvalidHookHandle = unchecked((System.Int32)(1404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DWP_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DWP_HANDLE</unmanaged-short>
        InvalidDwpHandle = unchecked((System.Int32)(1405)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TLW_WITH_WSCHILD</unmanaged>
        /// <unmanaged-short>ERROR_TLW_WITH_WSCHILD</unmanaged-short>
        TlwWithWschild = unchecked((System.Int32)(1406)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_FIND_WND_CLASS</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_FIND_WND_CLASS</unmanaged-short>
        CannotFindWndClass = unchecked((System.Int32)(1407)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WINDOW_OF_OTHER_THREAD</unmanaged>
        /// <unmanaged-short>ERROR_WINDOW_OF_OTHER_THREAD</unmanaged-short>
        WindowOfOtherThread = unchecked((System.Int32)(1408)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOTKEY_ALREADY_REGISTERED</unmanaged>
        /// <unmanaged-short>ERROR_HOTKEY_ALREADY_REGISTERED</unmanaged-short>
        HotkeyAlreadyRegistered = unchecked((System.Int32)(1409)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLASS_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_CLASS_ALREADY_EXISTS</unmanaged-short>
        ClassAlreadyExists = unchecked((System.Int32)(1410)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLASS_DOES_NOT_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_CLASS_DOES_NOT_EXIST</unmanaged-short>
        ClassDoesNotExist = unchecked((System.Int32)(1411)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLASS_HAS_WINDOWS</unmanaged>
        /// <unmanaged-short>ERROR_CLASS_HAS_WINDOWS</unmanaged-short>
        ClassHasWindows = unchecked((System.Int32)(1412)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_INDEX</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_INDEX</unmanaged-short>
        InvalidIndex = unchecked((System.Int32)(1413)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ICON_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ICON_HANDLE</unmanaged-short>
        InvalidIconHandle = unchecked((System.Int32)(1414)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRIVATE_DIALOG_INDEX</unmanaged>
        /// <unmanaged-short>ERROR_PRIVATE_DIALOG_INDEX</unmanaged-short>
        PrivateDialogIndex = unchecked((System.Int32)(1415)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LISTBOX_ID_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_LISTBOX_ID_NOT_FOUND</unmanaged-short>
        ListboxIdNotFound = unchecked((System.Int32)(1416)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_WILDCARD_CHARACTERS</unmanaged>
        /// <unmanaged-short>ERROR_NO_WILDCARD_CHARACTERS</unmanaged-short>
        NoWildcardCharacters = unchecked((System.Int32)(1417)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIPBOARD_NOT_OPEN</unmanaged>
        /// <unmanaged-short>ERROR_CLIPBOARD_NOT_OPEN</unmanaged-short>
        ClipboardNotOpen = unchecked((System.Int32)(1418)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOTKEY_NOT_REGISTERED</unmanaged>
        /// <unmanaged-short>ERROR_HOTKEY_NOT_REGISTERED</unmanaged-short>
        HotkeyNotRegistered = unchecked((System.Int32)(1419)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WINDOW_NOT_DIALOG</unmanaged>
        /// <unmanaged-short>ERROR_WINDOW_NOT_DIALOG</unmanaged-short>
        WindowNotDialog = unchecked((System.Int32)(1420)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONTROL_ID_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CONTROL_ID_NOT_FOUND</unmanaged-short>
        ControlIdNotFound = unchecked((System.Int32)(1421)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_COMBOBOX_MESSAGE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_COMBOBOX_MESSAGE</unmanaged-short>
        InvalidComboboxMessage = unchecked((System.Int32)(1422)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WINDOW_NOT_COMBOBOX</unmanaged>
        /// <unmanaged-short>ERROR_WINDOW_NOT_COMBOBOX</unmanaged-short>
        WindowNotCombobox = unchecked((System.Int32)(1423)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_EDIT_HEIGHT</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_EDIT_HEIGHT</unmanaged-short>
        InvalidEditHeight = unchecked((System.Int32)(1424)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DC_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DC_NOT_FOUND</unmanaged-short>
        DcNotFound = unchecked((System.Int32)(1425)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_HOOK_FILTER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_HOOK_FILTER</unmanaged-short>
        InvalidHookFilter = unchecked((System.Int32)(1426)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_FILTER_PROC</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_FILTER_PROC</unmanaged-short>
        InvalidFilterProc = unchecked((System.Int32)(1427)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOOK_NEEDS_HMOD</unmanaged>
        /// <unmanaged-short>ERROR_HOOK_NEEDS_HMOD</unmanaged-short>
        HookNeedsHmod = unchecked((System.Int32)(1428)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GLOBAL_ONLY_HOOK</unmanaged>
        /// <unmanaged-short>ERROR_GLOBAL_ONLY_HOOK</unmanaged-short>
        GlobalOnlyHook = unchecked((System.Int32)(1429)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_JOURNAL_HOOK_SET</unmanaged>
        /// <unmanaged-short>ERROR_JOURNAL_HOOK_SET</unmanaged-short>
        JournalHookSet = unchecked((System.Int32)(1430)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOOK_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_HOOK_NOT_INSTALLED</unmanaged-short>
        HookNotInstalled = unchecked((System.Int32)(1431)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LB_MESSAGE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LB_MESSAGE</unmanaged-short>
        InvalidLbMessage = unchecked((System.Int32)(1432)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SETCOUNT_ON_BAD_LB</unmanaged>
        /// <unmanaged-short>ERROR_SETCOUNT_ON_BAD_LB</unmanaged-short>
        SetcountOnBadLb = unchecked((System.Int32)(1433)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LB_WITHOUT_TABSTOPS</unmanaged>
        /// <unmanaged-short>ERROR_LB_WITHOUT_TABSTOPS</unmanaged-short>
        LbWithoutTabstops = unchecked((System.Int32)(1434)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DESTROY_OBJECT_OF_OTHER_THREAD</unmanaged>
        /// <unmanaged-short>ERROR_DESTROY_OBJECT_OF_OTHER_THREAD</unmanaged-short>
        DestroyObjectOfOtherThread = unchecked((System.Int32)(1435)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CHILD_WINDOW_MENU</unmanaged>
        /// <unmanaged-short>ERROR_CHILD_WINDOW_MENU</unmanaged-short>
        ChildWindowMenu = unchecked((System.Int32)(1436)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SYSTEM_MENU</unmanaged>
        /// <unmanaged-short>ERROR_NO_SYSTEM_MENU</unmanaged-short>
        NoSystemMenu = unchecked((System.Int32)(1437)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MSGBOX_STYLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MSGBOX_STYLE</unmanaged-short>
        InvalidMsgboxStyle = unchecked((System.Int32)(1438)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SPI_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SPI_VALUE</unmanaged-short>
        InvalidSpiValue = unchecked((System.Int32)(1439)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SCREEN_ALREADY_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_SCREEN_ALREADY_LOCKED</unmanaged-short>
        ScreenAlreadyLocked = unchecked((System.Int32)(1440)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HWNDS_HAVE_DIFF_PARENT</unmanaged>
        /// <unmanaged-short>ERROR_HWNDS_HAVE_DIFF_PARENT</unmanaged-short>
        HwndsHaveDiffParent = unchecked((System.Int32)(1441)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_CHILD_WINDOW</unmanaged>
        /// <unmanaged-short>ERROR_NOT_CHILD_WINDOW</unmanaged-short>
        NotChildWindow = unchecked((System.Int32)(1442)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_GW_COMMAND</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_GW_COMMAND</unmanaged-short>
        InvalidGwCommand = unchecked((System.Int32)(1443)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_THREAD_ID</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_THREAD_ID</unmanaged-short>
        InvalidThreadId = unchecked((System.Int32)(1444)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NON_MDICHILD_WINDOW</unmanaged>
        /// <unmanaged-short>ERROR_NON_MDICHILD_WINDOW</unmanaged-short>
        NonMdichildWindow = unchecked((System.Int32)(1445)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_POPUP_ALREADY_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_POPUP_ALREADY_ACTIVE</unmanaged-short>
        PopupAlreadyActive = unchecked((System.Int32)(1446)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SCROLLBARS</unmanaged>
        /// <unmanaged-short>ERROR_NO_SCROLLBARS</unmanaged-short>
        NoScrollbars = unchecked((System.Int32)(1447)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SCROLLBAR_RANGE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SCROLLBAR_RANGE</unmanaged-short>
        InvalidScrollbarRange = unchecked((System.Int32)(1448)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SHOWWIN_COMMAND</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SHOWWIN_COMMAND</unmanaged-short>
        InvalidShowwinCommand = unchecked((System.Int32)(1449)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SYSTEM_RESOURCES</unmanaged>
        /// <unmanaged-short>ERROR_NO_SYSTEM_RESOURCES</unmanaged-short>
        NoSystemResources = unchecked((System.Int32)(1450)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NONPAGED_SYSTEM_RESOURCES</unmanaged>
        /// <unmanaged-short>ERROR_NONPAGED_SYSTEM_RESOURCES</unmanaged-short>
        NonpagedSystemResources = unchecked((System.Int32)(1451)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGED_SYSTEM_RESOURCES</unmanaged>
        /// <unmanaged-short>ERROR_PAGED_SYSTEM_RESOURCES</unmanaged-short>
        PagedSystemResources = unchecked((System.Int32)(1452)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WORKING_SET_QUOTA</unmanaged>
        /// <unmanaged-short>ERROR_WORKING_SET_QUOTA</unmanaged-short>
        WorkingSetQuota = unchecked((System.Int32)(1453)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PAGEFILE_QUOTA</unmanaged>
        /// <unmanaged-short>ERROR_PAGEFILE_QUOTA</unmanaged-short>
        PagefileQuota = unchecked((System.Int32)(1454)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COMMITMENT_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_COMMITMENT_LIMIT</unmanaged-short>
        CommitmentLimit = unchecked((System.Int32)(1455)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MENU_ITEM_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_MENU_ITEM_NOT_FOUND</unmanaged-short>
        MenuItemNotFound = unchecked((System.Int32)(1456)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_KEYBOARD_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_KEYBOARD_HANDLE</unmanaged-short>
        InvalidKeyboardHandle = unchecked((System.Int32)(1457)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOOK_TYPE_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_HOOK_TYPE_NOT_ALLOWED</unmanaged-short>
        HookTypeNotAllowed = unchecked((System.Int32)(1458)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION</unmanaged>
        /// <unmanaged-short>ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION</unmanaged-short>
        RequiresInteractiveWindowstation = unchecked((System.Int32)(1459)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_TIMEOUT</unmanaged-short>
        Timeout = unchecked((System.Int32)(1460)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MONITOR_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MONITOR_HANDLE</unmanaged-short>
        InvalidMonitorHandle = unchecked((System.Int32)(1461)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INCORRECT_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_INCORRECT_SIZE</unmanaged-short>
        IncorrectSize = unchecked((System.Int32)(1462)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYMLINK_CLASS_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_SYMLINK_CLASS_DISABLED</unmanaged-short>
        SymlinkClassDisabled = unchecked((System.Int32)(1463)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYMLINK_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_SYMLINK_NOT_SUPPORTED</unmanaged-short>
        SymlinkNotSupported = unchecked((System.Int32)(1464)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_XML_PARSE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_XML_PARSE_ERROR</unmanaged-short>
        XmlParseError = unchecked((System.Int32)(1465)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_XMLDSIG_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_XMLDSIG_ERROR</unmanaged-short>
        XmldsigError = unchecked((System.Int32)(1466)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESTART_APPLICATION</unmanaged>
        /// <unmanaged-short>ERROR_RESTART_APPLICATION</unmanaged-short>
        RestartApplication = unchecked((System.Int32)(1467)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WRONG_COMPARTMENT</unmanaged>
        /// <unmanaged-short>ERROR_WRONG_COMPARTMENT</unmanaged-short>
        WrongCompartment = unchecked((System.Int32)(1468)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_AUTHIP_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_AUTHIP_FAILURE</unmanaged-short>
        AuthipFailure = unchecked((System.Int32)(1469)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_NVRAM_RESOURCES</unmanaged>
        /// <unmanaged-short>ERROR_NO_NVRAM_RESOURCES</unmanaged-short>
        NoNvramResources = unchecked((System.Int32)(1470)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_GUI_PROCESS</unmanaged>
        /// <unmanaged-short>ERROR_NOT_GUI_PROCESS</unmanaged-short>
        NotGuiProcess = unchecked((System.Int32)(1471)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVENTLOG_FILE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_EVENTLOG_FILE_CORRUPT</unmanaged-short>
        EventlogFileCorrupt = unchecked((System.Int32)(1500)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVENTLOG_CANT_START</unmanaged>
        /// <unmanaged-short>ERROR_EVENTLOG_CANT_START</unmanaged-short>
        EventlogCantStart = unchecked((System.Int32)(1501)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_FILE_FULL</unmanaged>
        /// <unmanaged-short>ERROR_LOG_FILE_FULL</unmanaged-short>
        LogFileFull = unchecked((System.Int32)(1502)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVENTLOG_FILE_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_EVENTLOG_FILE_CHANGED</unmanaged-short>
        EventlogFileChanged = unchecked((System.Int32)(1503)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONTAINER_ASSIGNED</unmanaged>
        /// <unmanaged-short>ERROR_CONTAINER_ASSIGNED</unmanaged-short>
        ContainerAssigned = unchecked((System.Int32)(1504)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_JOB_NO_CONTAINER</unmanaged>
        /// <unmanaged-short>ERROR_JOB_NO_CONTAINER</unmanaged-short>
        JobNoContainer = unchecked((System.Int32)(1505)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_TASK_NAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_TASK_NAME</unmanaged-short>
        InvalidTaskName = unchecked((System.Int32)(1550)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_TASK_INDEX</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_TASK_INDEX</unmanaged-short>
        InvalidTaskIndex = unchecked((System.Int32)(1551)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_THREAD_ALREADY_IN_TASK</unmanaged>
        /// <unmanaged-short>ERROR_THREAD_ALREADY_IN_TASK</unmanaged-short>
        ThreadAlreadyInTask = unchecked((System.Int32)(1552)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_SERVICE_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_SERVICE_FAILURE</unmanaged-short>
        InstallServiceFailure = unchecked((System.Int32)(1601)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_USEREXIT</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_USEREXIT</unmanaged-short>
        InstallUserexit = unchecked((System.Int32)(1602)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_FAILURE</unmanaged-short>
        InstallFailure = unchecked((System.Int32)(1603)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_SUSPEND</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_SUSPEND</unmanaged-short>
        InstallSuspend = unchecked((System.Int32)(1604)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_PRODUCT</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_PRODUCT</unmanaged-short>
        UnknownProduct = unchecked((System.Int32)(1605)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_FEATURE</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_FEATURE</unmanaged-short>
        UnknownFeature = unchecked((System.Int32)(1606)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_COMPONENT</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_COMPONENT</unmanaged-short>
        UnknownComponent = unchecked((System.Int32)(1607)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_PROPERTY</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_PROPERTY</unmanaged-short>
        UnknownProperty = unchecked((System.Int32)(1608)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_HANDLE_STATE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_HANDLE_STATE</unmanaged-short>
        InvalidHandleState = unchecked((System.Int32)(1609)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_CONFIGURATION</unmanaged>
        /// <unmanaged-short>ERROR_BAD_CONFIGURATION</unmanaged-short>
        BadConfiguration = unchecked((System.Int32)(1610)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INDEX_ABSENT</unmanaged>
        /// <unmanaged-short>ERROR_INDEX_ABSENT</unmanaged-short>
        IndexAbsent = unchecked((System.Int32)(1611)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_SOURCE_ABSENT</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_SOURCE_ABSENT</unmanaged-short>
        InstallSourceAbsent = unchecked((System.Int32)(1612)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_PACKAGE_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_PACKAGE_VERSION</unmanaged-short>
        InstallPackageVersion = unchecked((System.Int32)(1613)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRODUCT_UNINSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_PRODUCT_UNINSTALLED</unmanaged-short>
        ProductUninstalled = unchecked((System.Int32)(1614)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_QUERY_SYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_BAD_QUERY_SYNTAX</unmanaged-short>
        BadQuerySyntax = unchecked((System.Int32)(1615)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_FIELD</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_FIELD</unmanaged-short>
        InvalidField = unchecked((System.Int32)(1616)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_REMOVED</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_REMOVED</unmanaged-short>
        DeviceRemoved = unchecked((System.Int32)(1617)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_ALREADY_RUNNING</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_ALREADY_RUNNING</unmanaged-short>
        InstallAlreadyRunning = unchecked((System.Int32)(1618)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_PACKAGE_OPEN_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_PACKAGE_OPEN_FAILED</unmanaged-short>
        InstallPackageOpenFailed = unchecked((System.Int32)(1619)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_PACKAGE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_PACKAGE_INVALID</unmanaged-short>
        InstallPackageInvalid = unchecked((System.Int32)(1620)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_UI_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_UI_FAILURE</unmanaged-short>
        InstallUiFailure = unchecked((System.Int32)(1621)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_LOG_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_LOG_FAILURE</unmanaged-short>
        InstallLogFailure = unchecked((System.Int32)(1622)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_LANGUAGE_UNSUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_LANGUAGE_UNSUPPORTED</unmanaged-short>
        InstallLanguageUnsupported = unchecked((System.Int32)(1623)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_TRANSFORM_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_TRANSFORM_FAILURE</unmanaged-short>
        InstallTransformFailure = unchecked((System.Int32)(1624)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_PACKAGE_REJECTED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_PACKAGE_REJECTED</unmanaged-short>
        InstallPackageRejected = unchecked((System.Int32)(1625)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FUNCTION_NOT_CALLED</unmanaged>
        /// <unmanaged-short>ERROR_FUNCTION_NOT_CALLED</unmanaged-short>
        FunctionNotCalled = unchecked((System.Int32)(1626)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FUNCTION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_FUNCTION_FAILED</unmanaged-short>
        FunctionFailed = unchecked((System.Int32)(1627)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_TABLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_TABLE</unmanaged-short>
        InvalidTable = unchecked((System.Int32)(1628)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DATATYPE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DATATYPE_MISMATCH</unmanaged-short>
        DatatypeMismatch = unchecked((System.Int32)(1629)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNSUPPORTED_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_UNSUPPORTED_TYPE</unmanaged-short>
        UnsupportedType = unchecked((System.Int32)(1630)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CREATE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_CREATE_FAILED</unmanaged-short>
        CreateFailed = unchecked((System.Int32)(1631)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_TEMP_UNWRITABLE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_TEMP_UNWRITABLE</unmanaged-short>
        InstallTempUnwritable = unchecked((System.Int32)(1632)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_PLATFORM_UNSUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_PLATFORM_UNSUPPORTED</unmanaged-short>
        InstallPlatformUnsupported = unchecked((System.Int32)(1633)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_NOTUSED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_NOTUSED</unmanaged-short>
        InstallNotused = unchecked((System.Int32)(1634)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_PACKAGE_OPEN_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_PACKAGE_OPEN_FAILED</unmanaged-short>
        PatchPackageOpenFailed = unchecked((System.Int32)(1635)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_PACKAGE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_PACKAGE_INVALID</unmanaged-short>
        PatchPackageInvalid = unchecked((System.Int32)(1636)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_PACKAGE_UNSUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_PACKAGE_UNSUPPORTED</unmanaged-short>
        PatchPackageUnsupported = unchecked((System.Int32)(1637)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRODUCT_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_PRODUCT_VERSION</unmanaged-short>
        ProductVersion = unchecked((System.Int32)(1638)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_COMMAND_LINE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_COMMAND_LINE</unmanaged-short>
        InvalidCommandLine = unchecked((System.Int32)(1639)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_REMOTE_DISALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_REMOTE_DISALLOWED</unmanaged-short>
        InstallRemoteDisallowed = unchecked((System.Int32)(1640)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SUCCESS_REBOOT_INITIATED</unmanaged>
        /// <unmanaged-short>ERROR_SUCCESS_REBOOT_INITIATED</unmanaged-short>
        SuccessRebootInitiated = unchecked((System.Int32)(1641)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_TARGET_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_TARGET_NOT_FOUND</unmanaged-short>
        PatchTargetNotFound = unchecked((System.Int32)(1642)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_PACKAGE_REJECTED</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_PACKAGE_REJECTED</unmanaged-short>
        PatchPackageRejected = unchecked((System.Int32)(1643)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_TRANSFORM_REJECTED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_TRANSFORM_REJECTED</unmanaged-short>
        InstallTransformRejected = unchecked((System.Int32)(1644)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_REMOTE_PROHIBITED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_REMOTE_PROHIBITED</unmanaged-short>
        InstallRemoteProhibited = unchecked((System.Int32)(1645)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_REMOVAL_UNSUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_REMOVAL_UNSUPPORTED</unmanaged-short>
        PatchRemovalUnsupported = unchecked((System.Int32)(1646)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_PATCH</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_PATCH</unmanaged-short>
        UnknownPatch = unchecked((System.Int32)(1647)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_NO_SEQUENCE</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_NO_SEQUENCE</unmanaged-short>
        PatchNoSequence = unchecked((System.Int32)(1648)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_REMOVAL_DISALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_REMOVAL_DISALLOWED</unmanaged-short>
        PatchRemovalDisallowed = unchecked((System.Int32)(1649)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PATCH_XML</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PATCH_XML</unmanaged-short>
        InvalidPatchXml = unchecked((System.Int32)(1650)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT</unmanaged>
        /// <unmanaged-short>ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT</unmanaged-short>
        PatchManagedAdvertisedProduct = unchecked((System.Int32)(1651)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_SERVICE_SAFEBOOT</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_SERVICE_SAFEBOOT</unmanaged-short>
        InstallServiceSafeboot = unchecked((System.Int32)(1652)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAIL_FAST_EXCEPTION</unmanaged>
        /// <unmanaged-short>ERROR_FAIL_FAST_EXCEPTION</unmanaged-short>
        FailFastException = unchecked((System.Int32)(1653)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_REJECTED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_REJECTED</unmanaged-short>
        InstallRejected = unchecked((System.Int32)(1654)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DYNAMIC_CODE_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_DYNAMIC_CODE_BLOCKED</unmanaged-short>
        DynamicCodeBlocked = unchecked((System.Int32)(1655)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SAME_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SAME_OBJECT</unmanaged-short>
        NotSameObject = unchecked((System.Int32)(1656)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STRICT_CFG_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_STRICT_CFG_VIOLATION</unmanaged-short>
        StrictCfgViolation = unchecked((System.Int32)(1657)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SET_CONTEXT_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_SET_CONTEXT_DENIED</unmanaged-short>
        SetContextDenied = unchecked((System.Int32)(1660)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CROSS_PARTITION_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_CROSS_PARTITION_VIOLATION</unmanaged-short>
        CrossPartitionViolation = unchecked((System.Int32)(1661)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_USER_BUFFER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_USER_BUFFER</unmanaged-short>
        InvalidUserBuffer = unchecked((System.Int32)(1784)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNRECOGNIZED_MEDIA</unmanaged>
        /// <unmanaged-short>ERROR_UNRECOGNIZED_MEDIA</unmanaged-short>
        UnrecognizedMedia = unchecked((System.Int32)(1785)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_TRUST_LSA_SECRET</unmanaged>
        /// <unmanaged-short>ERROR_NO_TRUST_LSA_SECRET</unmanaged-short>
        NoTrustLsaSecret = unchecked((System.Int32)(1786)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_TRUST_SAM_ACCOUNT</unmanaged>
        /// <unmanaged-short>ERROR_NO_TRUST_SAM_ACCOUNT</unmanaged-short>
        NoTrustSamAccount = unchecked((System.Int32)(1787)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRUSTED_DOMAIN_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_TRUSTED_DOMAIN_FAILURE</unmanaged-short>
        TrustedDomainFailure = unchecked((System.Int32)(1788)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRUSTED_RELATIONSHIP_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_TRUSTED_RELATIONSHIP_FAILURE</unmanaged-short>
        TrustedRelationshipFailure = unchecked((System.Int32)(1789)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRUST_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_TRUST_FAILURE</unmanaged-short>
        TrustFailure = unchecked((System.Int32)(1790)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NETLOGON_NOT_STARTED</unmanaged>
        /// <unmanaged-short>ERROR_NETLOGON_NOT_STARTED</unmanaged-short>
        NetlogonNotStarted = unchecked((System.Int32)(1792)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCOUNT_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_ACCOUNT_EXPIRED</unmanaged-short>
        AccountExpired = unchecked((System.Int32)(1793)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REDIRECTOR_HAS_OPEN_HANDLES</unmanaged>
        /// <unmanaged-short>ERROR_REDIRECTOR_HAS_OPEN_HANDLES</unmanaged-short>
        RedirectorHasOpenHandles = unchecked((System.Int32)(1794)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_DRIVER_ALREADY_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_DRIVER_ALREADY_INSTALLED</unmanaged-short>
        PrinterDriverAlreadyInstalled = unchecked((System.Int32)(1795)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_PORT</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_PORT</unmanaged-short>
        UnknownPort = unchecked((System.Int32)(1796)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_PRINTER_DRIVER</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_PRINTER_DRIVER</unmanaged-short>
        UnknownPrinterDriver = unchecked((System.Int32)(1797)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_PRINTPROCESSOR</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_PRINTPROCESSOR</unmanaged-short>
        UnknownPrintprocessor = unchecked((System.Int32)(1798)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_SEPARATOR_FILE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_SEPARATOR_FILE</unmanaged-short>
        InvalidSeparatorFile = unchecked((System.Int32)(1799)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PRIORITY</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PRIORITY</unmanaged-short>
        InvalidPriority = unchecked((System.Int32)(1800)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PRINTER_NAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PRINTER_NAME</unmanaged-short>
        InvalidPrinterName = unchecked((System.Int32)(1801)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_ALREADY_EXISTS</unmanaged-short>
        PrinterAlreadyExists = unchecked((System.Int32)(1802)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PRINTER_COMMAND</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PRINTER_COMMAND</unmanaged-short>
        InvalidPrinterCommand = unchecked((System.Int32)(1803)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DATATYPE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DATATYPE</unmanaged-short>
        InvalidDatatype = unchecked((System.Int32)(1804)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_ENVIRONMENT</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_ENVIRONMENT</unmanaged-short>
        InvalidEnvironment = unchecked((System.Int32)(1805)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT</unmanaged>
        /// <unmanaged-short>ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT</unmanaged-short>
        NologonInterdomainTrustAccount = unchecked((System.Int32)(1807)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT</unmanaged>
        /// <unmanaged-short>ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT</unmanaged-short>
        NologonWorkstationTrustAccount = unchecked((System.Int32)(1808)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOLOGON_SERVER_TRUST_ACCOUNT</unmanaged>
        /// <unmanaged-short>ERROR_NOLOGON_SERVER_TRUST_ACCOUNT</unmanaged-short>
        NologonServerTrustAccount = unchecked((System.Int32)(1809)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DOMAIN_TRUST_INCONSISTENT</unmanaged>
        /// <unmanaged-short>ERROR_DOMAIN_TRUST_INCONSISTENT</unmanaged-short>
        DomainTrustInconsistent = unchecked((System.Int32)(1810)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVER_HAS_OPEN_HANDLES</unmanaged>
        /// <unmanaged-short>ERROR_SERVER_HAS_OPEN_HANDLES</unmanaged-short>
        ServerHasOpenHandles = unchecked((System.Int32)(1811)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_DATA_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_DATA_NOT_FOUND</unmanaged-short>
        ResourceDataNotFound = unchecked((System.Int32)(1812)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_TYPE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_TYPE_NOT_FOUND</unmanaged-short>
        ResourceTypeNotFound = unchecked((System.Int32)(1813)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_NAME_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_NAME_NOT_FOUND</unmanaged-short>
        ResourceNameNotFound = unchecked((System.Int32)(1814)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_LANG_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_LANG_NOT_FOUND</unmanaged-short>
        ResourceLangNotFound = unchecked((System.Int32)(1815)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_ENOUGH_QUOTA</unmanaged>
        /// <unmanaged-short>ERROR_NOT_ENOUGH_QUOTA</unmanaged-short>
        NotEnoughQuota = unchecked((System.Int32)(1816)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_TIME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_TIME</unmanaged-short>
        InvalidTime = unchecked((System.Int32)(1901)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_FORM_NAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_FORM_NAME</unmanaged-short>
        InvalidFormName = unchecked((System.Int32)(1902)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_FORM_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_FORM_SIZE</unmanaged-short>
        InvalidFormSize = unchecked((System.Int32)(1903)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_WAITING</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_WAITING</unmanaged-short>
        AlreadyWaiting = unchecked((System.Int32)(1904)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_DELETED</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_DELETED</unmanaged-short>
        PrinterDeleted = unchecked((System.Int32)(1905)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PRINTER_STATE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PRINTER_STATE</unmanaged-short>
        InvalidPrinterState = unchecked((System.Int32)(1906)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PASSWORD_MUST_CHANGE</unmanaged>
        /// <unmanaged-short>ERROR_PASSWORD_MUST_CHANGE</unmanaged-short>
        PasswordMustChange = unchecked((System.Int32)(1907)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DOMAIN_CONTROLLER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DOMAIN_CONTROLLER_NOT_FOUND</unmanaged-short>
        DomainControllerNotFound = unchecked((System.Int32)(1908)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACCOUNT_LOCKED_OUT</unmanaged>
        /// <unmanaged-short>ERROR_ACCOUNT_LOCKED_OUT</unmanaged-short>
        AccountLockedOut = unchecked((System.Int32)(1909)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SITENAME</unmanaged>
        /// <unmanaged-short>ERROR_NO_SITENAME</unmanaged-short>
        NoSitename = unchecked((System.Int32)(1919)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_ACCESS_FILE</unmanaged>
        /// <unmanaged-short>ERROR_CANT_ACCESS_FILE</unmanaged-short>
        CantAccessFile = unchecked((System.Int32)(1920)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_RESOLVE_FILENAME</unmanaged>
        /// <unmanaged-short>ERROR_CANT_RESOLVE_FILENAME</unmanaged-short>
        CantResolveFilename = unchecked((System.Int32)(1921)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_KM_DRIVER_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_KM_DRIVER_BLOCKED</unmanaged-short>
        KmDriverBlocked = unchecked((System.Int32)(1930)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONTEXT_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_CONTEXT_EXPIRED</unmanaged-short>
        ContextExpired = unchecked((System.Int32)(1931)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PER_USER_TRUST_QUOTA_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_PER_USER_TRUST_QUOTA_EXCEEDED</unmanaged-short>
        PerUserTrustQuotaExceeded = unchecked((System.Int32)(1932)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED</unmanaged-short>
        AllUserTrustQuotaExceeded = unchecked((System.Int32)(1933)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED</unmanaged-short>
        UserDeleteTrustQuotaExceeded = unchecked((System.Int32)(1934)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_AUTHENTICATION_FIREWALL_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_AUTHENTICATION_FIREWALL_FAILED</unmanaged-short>
        AuthenticationFirewallFailed = unchecked((System.Int32)(1935)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED</unmanaged-short>
        RemotePrintConnectionsBlocked = unchecked((System.Int32)(1936)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NTLM_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_NTLM_BLOCKED</unmanaged-short>
        NtlmBlocked = unchecked((System.Int32)(1937)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PASSWORD_CHANGE_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_PASSWORD_CHANGE_REQUIRED</unmanaged-short>
        PasswordChangeRequired = unchecked((System.Int32)(1938)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOST_MODE_LOGON_RESTRICTION</unmanaged>
        /// <unmanaged-short>ERROR_LOST_MODE_LOGON_RESTRICTION</unmanaged-short>
        LostModeLogonRestriction = unchecked((System.Int32)(1939)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PIXEL_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PIXEL_FORMAT</unmanaged-short>
        InvalidPixelFormat = unchecked((System.Int32)(2000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_DRIVER</unmanaged>
        /// <unmanaged-short>ERROR_BAD_DRIVER</unmanaged-short>
        BadDriver = unchecked((System.Int32)(2001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_WINDOW_STYLE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_WINDOW_STYLE</unmanaged-short>
        InvalidWindowStyle = unchecked((System.Int32)(2002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_METAFILE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_METAFILE_NOT_SUPPORTED</unmanaged-short>
        MetafileNotSupported = unchecked((System.Int32)(2003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSFORM_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSFORM_NOT_SUPPORTED</unmanaged-short>
        TransformNotSupported = unchecked((System.Int32)(2004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIPPING_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_CLIPPING_NOT_SUPPORTED</unmanaged-short>
        ClippingNotSupported = unchecked((System.Int32)(2005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_CMM</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_CMM</unmanaged-short>
        InvalidCmm = unchecked((System.Int32)(2010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PROFILE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PROFILE</unmanaged-short>
        InvalidProfile = unchecked((System.Int32)(2011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TAG_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_TAG_NOT_FOUND</unmanaged-short>
        TagNotFound = unchecked((System.Int32)(2012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TAG_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_TAG_NOT_PRESENT</unmanaged-short>
        TagNotPresent = unchecked((System.Int32)(2013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DUPLICATE_TAG</unmanaged>
        /// <unmanaged-short>ERROR_DUPLICATE_TAG</unmanaged-short>
        DuplicateTag = unchecked((System.Int32)(2014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE</unmanaged-short>
        ProfileNotAssociatedWithDevice = unchecked((System.Int32)(2015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROFILE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_PROFILE_NOT_FOUND</unmanaged-short>
        ProfileNotFound = unchecked((System.Int32)(2016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_COLORSPACE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_COLORSPACE</unmanaged-short>
        InvalidColorspace = unchecked((System.Int32)(2017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ICM_NOT_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_ICM_NOT_ENABLED</unmanaged-short>
        IcmNotEnabled = unchecked((System.Int32)(2018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DELETING_ICM_XFORM</unmanaged>
        /// <unmanaged-short>ERROR_DELETING_ICM_XFORM</unmanaged-short>
        DeletingIcmXform = unchecked((System.Int32)(2019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_TRANSFORM</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_TRANSFORM</unmanaged-short>
        InvalidTransform = unchecked((System.Int32)(2020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COLORSPACE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_COLORSPACE_MISMATCH</unmanaged-short>
        ColorspaceMismatch = unchecked((System.Int32)(2021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_COLORINDEX</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_COLORINDEX</unmanaged-short>
        InvalidColorindex = unchecked((System.Int32)(2022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROFILE_DOES_NOT_MATCH_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_PROFILE_DOES_NOT_MATCH_DEVICE</unmanaged-short>
        ProfileDoesNotMatchDevice = unchecked((System.Int32)(2023)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONNECTED_OTHER_PASSWORD</unmanaged>
        /// <unmanaged-short>ERROR_CONNECTED_OTHER_PASSWORD</unmanaged-short>
        ConnectedOtherPassword = unchecked((System.Int32)(2108)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT</unmanaged>
        /// <unmanaged-short>ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT</unmanaged-short>
        ConnectedOtherPasswordDefault = unchecked((System.Int32)(2109)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_USERNAME</unmanaged>
        /// <unmanaged-short>ERROR_BAD_USERNAME</unmanaged-short>
        BadUsername = unchecked((System.Int32)(2202)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_NOT_CONNECTED</unmanaged-short>
        NotConnected = unchecked((System.Int32)(2250)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPEN_FILES</unmanaged>
        /// <unmanaged-short>ERROR_OPEN_FILES</unmanaged-short>
        OpenFiles = unchecked((System.Int32)(2401)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACTIVE_CONNECTIONS</unmanaged>
        /// <unmanaged-short>ERROR_ACTIVE_CONNECTIONS</unmanaged-short>
        ActiveConnections = unchecked((System.Int32)(2402)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_IN_USE</unmanaged-short>
        DeviceInUse = unchecked((System.Int32)(2404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNKNOWN_PRINT_MONITOR</unmanaged>
        /// <unmanaged-short>ERROR_UNKNOWN_PRINT_MONITOR</unmanaged-short>
        UnknownPrintMonitor = unchecked((System.Int32)(3000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_DRIVER_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_DRIVER_IN_USE</unmanaged-short>
        PrinterDriverInUse = unchecked((System.Int32)(3001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPOOL_FILE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SPOOL_FILE_NOT_FOUND</unmanaged-short>
        SpoolFileNotFound = unchecked((System.Int32)(3002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPL_NO_STARTDOC</unmanaged>
        /// <unmanaged-short>ERROR_SPL_NO_STARTDOC</unmanaged-short>
        SplNoStartdoc = unchecked((System.Int32)(3003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPL_NO_ADDJOB</unmanaged>
        /// <unmanaged-short>ERROR_SPL_NO_ADDJOB</unmanaged-short>
        SplNoAddjob = unchecked((System.Int32)(3004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED</unmanaged-short>
        PrintProcessorAlreadyInstalled = unchecked((System.Int32)(3005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINT_MONITOR_ALREADY_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_PRINT_MONITOR_ALREADY_INSTALLED</unmanaged-short>
        PrintMonitorAlreadyInstalled = unchecked((System.Int32)(3006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PRINT_MONITOR</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PRINT_MONITOR</unmanaged-short>
        InvalidPrintMonitor = unchecked((System.Int32)(3007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINT_MONITOR_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_PRINT_MONITOR_IN_USE</unmanaged-short>
        PrintMonitorInUse = unchecked((System.Int32)(3008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_HAS_JOBS_QUEUED</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_HAS_JOBS_QUEUED</unmanaged-short>
        PrinterHasJobsQueued = unchecked((System.Int32)(3009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SUCCESS_REBOOT_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_SUCCESS_REBOOT_REQUIRED</unmanaged-short>
        SuccessRebootRequired = unchecked((System.Int32)(3010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SUCCESS_RESTART_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_SUCCESS_RESTART_REQUIRED</unmanaged-short>
        SuccessRestartRequired = unchecked((System.Int32)(3011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_NOT_FOUND</unmanaged-short>
        PrinterNotFound = unchecked((System.Int32)(3012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_DRIVER_WARNED</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_DRIVER_WARNED</unmanaged-short>
        PrinterDriverWarned = unchecked((System.Int32)(3013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_DRIVER_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_DRIVER_BLOCKED</unmanaged-short>
        PrinterDriverBlocked = unchecked((System.Int32)(3014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_DRIVER_PACKAGE_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_DRIVER_PACKAGE_IN_USE</unmanaged-short>
        PrinterDriverPackageInUse = unchecked((System.Int32)(3015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND</unmanaged-short>
        CoreDriverPackageNotFound = unchecked((System.Int32)(3016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAIL_REBOOT_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_FAIL_REBOOT_REQUIRED</unmanaged-short>
        FailRebootRequired = unchecked((System.Int32)(3017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FAIL_REBOOT_INITIATED</unmanaged>
        /// <unmanaged-short>ERROR_FAIL_REBOOT_INITIATED</unmanaged-short>
        FailRebootInitiated = unchecked((System.Int32)(3018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED</unmanaged-short>
        PrinterDriverDownloadNeeded = unchecked((System.Int32)(3019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINT_JOB_RESTART_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_PRINT_JOB_RESTART_REQUIRED</unmanaged-short>
        PrintJobRestartRequired = unchecked((System.Int32)(3020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PRINTER_DRIVER_MANIFEST</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PRINTER_DRIVER_MANIFEST</unmanaged-short>
        InvalidPrinterDriverManifest = unchecked((System.Int32)(3021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRINTER_NOT_SHAREABLE</unmanaged>
        /// <unmanaged-short>ERROR_PRINTER_NOT_SHAREABLE</unmanaged-short>
        PrinterNotShareable = unchecked((System.Int32)(3022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REQUEST_PAUSED</unmanaged>
        /// <unmanaged-short>ERROR_REQUEST_PAUSED</unmanaged-short>
        RequestPaused = unchecked((System.Int32)(3050)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPEXEC_CONDITION_NOT_SATISFIED</unmanaged>
        /// <unmanaged-short>ERROR_APPEXEC_CONDITION_NOT_SATISFIED</unmanaged-short>
        AppexecConditionNotSatisfied = unchecked((System.Int32)(3060)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPEXEC_HANDLE_INVALIDATED</unmanaged>
        /// <unmanaged-short>ERROR_APPEXEC_HANDLE_INVALIDATED</unmanaged-short>
        AppexecHandleInvalidated = unchecked((System.Int32)(3061)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPEXEC_INVALID_HOST_GENERATION</unmanaged>
        /// <unmanaged-short>ERROR_APPEXEC_INVALID_HOST_GENERATION</unmanaged-short>
        AppexecInvalidHostGeneration = unchecked((System.Int32)(3062)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION</unmanaged>
        /// <unmanaged-short>ERROR_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION</unmanaged-short>
        AppexecUnexpectedProcessRegistration = unchecked((System.Int32)(3063)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPEXEC_INVALID_HOST_STATE</unmanaged>
        /// <unmanaged-short>ERROR_APPEXEC_INVALID_HOST_STATE</unmanaged-short>
        AppexecInvalidHostState = unchecked((System.Int32)(3064)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPEXEC_NO_DONOR</unmanaged>
        /// <unmanaged-short>ERROR_APPEXEC_NO_DONOR</unmanaged-short>
        AppexecNoDonor = unchecked((System.Int32)(3065)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPEXEC_HOST_ID_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_APPEXEC_HOST_ID_MISMATCH</unmanaged-short>
        AppexecHostIdMismatch = unchecked((System.Int32)(3066)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPEXEC_UNKNOWN_USER</unmanaged>
        /// <unmanaged-short>ERROR_APPEXEC_UNKNOWN_USER</unmanaged-short>
        AppexecUnknownUser = unchecked((System.Int32)(3067)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IO_REISSUE_AS_CACHED</unmanaged>
        /// <unmanaged-short>ERROR_IO_REISSUE_AS_CACHED</unmanaged-short>
        IoReissueAsCached = unchecked((System.Int32)(3950)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WINS_INTERNAL</unmanaged>
        /// <unmanaged-short>ERROR_WINS_INTERNAL</unmanaged-short>
        WinsInternal = unchecked((System.Int32)(4000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CAN_NOT_DEL_LOCAL_WINS</unmanaged>
        /// <unmanaged-short>ERROR_CAN_NOT_DEL_LOCAL_WINS</unmanaged-short>
        CanNotDelLocalWins = unchecked((System.Int32)(4001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATIC_INIT</unmanaged>
        /// <unmanaged-short>ERROR_STATIC_INIT</unmanaged-short>
        StaticInit = unchecked((System.Int32)(4002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INC_BACKUP</unmanaged>
        /// <unmanaged-short>ERROR_INC_BACKUP</unmanaged-short>
        IncBackup = unchecked((System.Int32)(4003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FULL_BACKUP</unmanaged>
        /// <unmanaged-short>ERROR_FULL_BACKUP</unmanaged-short>
        FullBackup = unchecked((System.Int32)(4004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REC_NON_EXISTENT</unmanaged>
        /// <unmanaged-short>ERROR_REC_NON_EXISTENT</unmanaged-short>
        RecNonExistent = unchecked((System.Int32)(4005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RPL_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_RPL_NOT_ALLOWED</unmanaged-short>
        RplNotAllowed = unchecked((System.Int32)(4006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DHCP_ADDRESS_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_DHCP_ADDRESS_CONFLICT</unmanaged-short>
        DhcpAddressConflict = unchecked((System.Int32)(4100)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_GUID_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_WMI_GUID_NOT_FOUND</unmanaged-short>
        WmiGuidNotFound = unchecked((System.Int32)(4200)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_INSTANCE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_WMI_INSTANCE_NOT_FOUND</unmanaged-short>
        WmiInstanceNotFound = unchecked((System.Int32)(4201)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_ITEMID_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_WMI_ITEMID_NOT_FOUND</unmanaged-short>
        WmiItemidNotFound = unchecked((System.Int32)(4202)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_TRY_AGAIN</unmanaged>
        /// <unmanaged-short>ERROR_WMI_TRY_AGAIN</unmanaged-short>
        WmiTryAgain = unchecked((System.Int32)(4203)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_DP_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_WMI_DP_NOT_FOUND</unmanaged-short>
        WmiDpNotFound = unchecked((System.Int32)(4204)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_UNRESOLVED_INSTANCE_REF</unmanaged>
        /// <unmanaged-short>ERROR_WMI_UNRESOLVED_INSTANCE_REF</unmanaged-short>
        WmiUnresolvedInstanceRef = unchecked((System.Int32)(4205)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_ALREADY_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_WMI_ALREADY_ENABLED</unmanaged-short>
        WmiAlreadyEnabled = unchecked((System.Int32)(4206)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_GUID_DISCONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_WMI_GUID_DISCONNECTED</unmanaged-short>
        WmiGuidDisconnected = unchecked((System.Int32)(4207)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_SERVER_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_WMI_SERVER_UNAVAILABLE</unmanaged-short>
        WmiServerUnavailable = unchecked((System.Int32)(4208)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_DP_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_WMI_DP_FAILED</unmanaged-short>
        WmiDpFailed = unchecked((System.Int32)(4209)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_INVALID_MOF</unmanaged>
        /// <unmanaged-short>ERROR_WMI_INVALID_MOF</unmanaged-short>
        WmiInvalidMof = unchecked((System.Int32)(4210)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_INVALID_REGINFO</unmanaged>
        /// <unmanaged-short>ERROR_WMI_INVALID_REGINFO</unmanaged-short>
        WmiInvalidReginfo = unchecked((System.Int32)(4211)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_ALREADY_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_WMI_ALREADY_DISABLED</unmanaged-short>
        WmiAlreadyDisabled = unchecked((System.Int32)(4212)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_READ_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_WMI_READ_ONLY</unmanaged-short>
        WmiReadOnly = unchecked((System.Int32)(4213)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WMI_SET_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_WMI_SET_FAILURE</unmanaged-short>
        WmiSetFailure = unchecked((System.Int32)(4214)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_APPCONTAINER</unmanaged>
        /// <unmanaged-short>ERROR_NOT_APPCONTAINER</unmanaged-short>
        NotAppcontainer = unchecked((System.Int32)(4250)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPCONTAINER_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_APPCONTAINER_REQUIRED</unmanaged-short>
        AppcontainerRequired = unchecked((System.Int32)(4251)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SUPPORTED_IN_APPCONTAINER</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SUPPORTED_IN_APPCONTAINER</unmanaged-short>
        NotSupportedInAppcontainer = unchecked((System.Int32)(4252)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_PACKAGE_SID_LENGTH</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_PACKAGE_SID_LENGTH</unmanaged-short>
        InvalidPackageSidLength = unchecked((System.Int32)(4253)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MEDIA</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MEDIA</unmanaged-short>
        InvalidMedia = unchecked((System.Int32)(4300)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_LIBRARY</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_LIBRARY</unmanaged-short>
        InvalidLibrary = unchecked((System.Int32)(4301)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_MEDIA_POOL</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_MEDIA_POOL</unmanaged-short>
        InvalidMediaPool = unchecked((System.Int32)(4302)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DRIVE_MEDIA_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DRIVE_MEDIA_MISMATCH</unmanaged-short>
        DriveMediaMismatch = unchecked((System.Int32)(4303)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEDIA_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_MEDIA_OFFLINE</unmanaged-short>
        MediaOffline = unchecked((System.Int32)(4304)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LIBRARY_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_LIBRARY_OFFLINE</unmanaged-short>
        LibraryOffline = unchecked((System.Int32)(4305)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_EMPTY</unmanaged-short>
        Empty = unchecked((System.Int32)(4306)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_NOT_EMPTY</unmanaged-short>
        NotEmpty = unchecked((System.Int32)(4307)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEDIA_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_MEDIA_UNAVAILABLE</unmanaged-short>
        MediaUnavailable = unchecked((System.Int32)(4308)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_DISABLED</unmanaged-short>
        ResourceDisabled = unchecked((System.Int32)(4309)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_CLEANER</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_CLEANER</unmanaged-short>
        InvalidCleaner = unchecked((System.Int32)(4310)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_CLEAN</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_CLEAN</unmanaged-short>
        UnableToClean = unchecked((System.Int32)(4311)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OBJECT_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_OBJECT_NOT_FOUND</unmanaged-short>
        ObjectNotFound = unchecked((System.Int32)(4312)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DATABASE_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_DATABASE_FAILURE</unmanaged-short>
        DatabaseFailure = unchecked((System.Int32)(4313)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DATABASE_FULL</unmanaged>
        /// <unmanaged-short>ERROR_DATABASE_FULL</unmanaged-short>
        DatabaseFull = unchecked((System.Int32)(4314)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEDIA_INCOMPATIBLE</unmanaged>
        /// <unmanaged-short>ERROR_MEDIA_INCOMPATIBLE</unmanaged-short>
        MediaIncompatible = unchecked((System.Int32)(4315)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_NOT_PRESENT</unmanaged-short>
        ResourceNotPresent = unchecked((System.Int32)(4316)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_OPERATION</unmanaged-short>
        InvalidOperation = unchecked((System.Int32)(4317)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEDIA_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_MEDIA_NOT_AVAILABLE</unmanaged-short>
        MediaNotAvailable = unchecked((System.Int32)(4318)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEVICE_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_DEVICE_NOT_AVAILABLE</unmanaged-short>
        DeviceNotAvailable = unchecked((System.Int32)(4319)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REQUEST_REFUSED</unmanaged>
        /// <unmanaged-short>ERROR_REQUEST_REFUSED</unmanaged-short>
        RequestRefused = unchecked((System.Int32)(4320)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_DRIVE_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_DRIVE_OBJECT</unmanaged-short>
        InvalidDriveObject = unchecked((System.Int32)(4321)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LIBRARY_FULL</unmanaged>
        /// <unmanaged-short>ERROR_LIBRARY_FULL</unmanaged-short>
        LibraryFull = unchecked((System.Int32)(4322)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MEDIUM_NOT_ACCESSIBLE</unmanaged>
        /// <unmanaged-short>ERROR_MEDIUM_NOT_ACCESSIBLE</unmanaged-short>
        MediumNotAccessible = unchecked((System.Int32)(4323)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_LOAD_MEDIUM</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_LOAD_MEDIUM</unmanaged-short>
        UnableToLoadMedium = unchecked((System.Int32)(4324)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_INVENTORY_DRIVE</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_INVENTORY_DRIVE</unmanaged-short>
        UnableToInventoryDrive = unchecked((System.Int32)(4325)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_INVENTORY_SLOT</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_INVENTORY_SLOT</unmanaged-short>
        UnableToInventorySlot = unchecked((System.Int32)(4326)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_INVENTORY_TRANSPORT</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_INVENTORY_TRANSPORT</unmanaged-short>
        UnableToInventoryTransport = unchecked((System.Int32)(4327)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSPORT_FULL</unmanaged>
        /// <unmanaged-short>ERROR_TRANSPORT_FULL</unmanaged-short>
        TransportFull = unchecked((System.Int32)(4328)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CONTROLLING_IEPORT</unmanaged>
        /// <unmanaged-short>ERROR_CONTROLLING_IEPORT</unmanaged-short>
        ControllingIeport = unchecked((System.Int32)(4329)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA</unmanaged>
        /// <unmanaged-short>ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA</unmanaged-short>
        UnableToEjectMountedMedia = unchecked((System.Int32)(4330)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLEANER_SLOT_SET</unmanaged>
        /// <unmanaged-short>ERROR_CLEANER_SLOT_SET</unmanaged-short>
        CleanerSlotSet = unchecked((System.Int32)(4331)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLEANER_SLOT_NOT_SET</unmanaged>
        /// <unmanaged-short>ERROR_CLEANER_SLOT_NOT_SET</unmanaged-short>
        CleanerSlotNotSet = unchecked((System.Int32)(4332)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLEANER_CARTRIDGE_SPENT</unmanaged>
        /// <unmanaged-short>ERROR_CLEANER_CARTRIDGE_SPENT</unmanaged-short>
        CleanerCartridgeSpent = unchecked((System.Int32)(4333)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNEXPECTED_OMID</unmanaged>
        /// <unmanaged-short>ERROR_UNEXPECTED_OMID</unmanaged-short>
        UnexpectedOmid = unchecked((System.Int32)(4334)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_DELETE_LAST_ITEM</unmanaged>
        /// <unmanaged-short>ERROR_CANT_DELETE_LAST_ITEM</unmanaged-short>
        CantDeleteLastItem = unchecked((System.Int32)(4335)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MESSAGE_EXCEEDS_MAX_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_MESSAGE_EXCEEDS_MAX_SIZE</unmanaged-short>
        MessageExceedsMaxSize = unchecked((System.Int32)(4336)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLUME_CONTAINS_SYS_FILES</unmanaged>
        /// <unmanaged-short>ERROR_VOLUME_CONTAINS_SYS_FILES</unmanaged-short>
        VolumeContainsSysFiles = unchecked((System.Int32)(4337)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INDIGENOUS_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_INDIGENOUS_TYPE</unmanaged-short>
        IndigenousType = unchecked((System.Int32)(4338)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SUPPORTING_DRIVES</unmanaged>
        /// <unmanaged-short>ERROR_NO_SUPPORTING_DRIVES</unmanaged-short>
        NoSupportingDrives = unchecked((System.Int32)(4339)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLEANER_CARTRIDGE_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_CLEANER_CARTRIDGE_INSTALLED</unmanaged-short>
        CleanerCartridgeInstalled = unchecked((System.Int32)(4340)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IEPORT_FULL</unmanaged>
        /// <unmanaged-short>ERROR_IEPORT_FULL</unmanaged-short>
        IeportFull = unchecked((System.Int32)(4341)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_FILE_OFFLINE</unmanaged-short>
        FileOffline = unchecked((System.Int32)(4350)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REMOTE_STORAGE_NOT_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_REMOTE_STORAGE_NOT_ACTIVE</unmanaged-short>
        RemoteStorageNotActive = unchecked((System.Int32)(4351)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REMOTE_STORAGE_MEDIA_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_REMOTE_STORAGE_MEDIA_ERROR</unmanaged-short>
        RemoteStorageMediaError = unchecked((System.Int32)(4352)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_A_REPARSE_POINT</unmanaged>
        /// <unmanaged-short>ERROR_NOT_A_REPARSE_POINT</unmanaged-short>
        NotAReparsePoint = unchecked((System.Int32)(4390)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REPARSE_ATTRIBUTE_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_REPARSE_ATTRIBUTE_CONFLICT</unmanaged-short>
        ReparseAttributeConflict = unchecked((System.Int32)(4391)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_REPARSE_DATA</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_REPARSE_DATA</unmanaged-short>
        InvalidReparseData = unchecked((System.Int32)(4392)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REPARSE_TAG_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_REPARSE_TAG_INVALID</unmanaged-short>
        ReparseTagInvalid = unchecked((System.Int32)(4393)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REPARSE_TAG_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_REPARSE_TAG_MISMATCH</unmanaged-short>
        ReparseTagMismatch = unchecked((System.Int32)(4394)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REPARSE_POINT_ENCOUNTERED</unmanaged>
        /// <unmanaged-short>ERROR_REPARSE_POINT_ENCOUNTERED</unmanaged-short>
        ReparsePointEncountered = unchecked((System.Int32)(4395)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APP_DATA_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_APP_DATA_NOT_FOUND</unmanaged-short>
        AppDataNotFound = unchecked((System.Int32)(4400)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APP_DATA_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_APP_DATA_EXPIRED</unmanaged-short>
        AppDataExpired = unchecked((System.Int32)(4401)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APP_DATA_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_APP_DATA_CORRUPT</unmanaged-short>
        AppDataCorrupt = unchecked((System.Int32)(4402)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APP_DATA_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_APP_DATA_LIMIT_EXCEEDED</unmanaged-short>
        AppDataLimitExceeded = unchecked((System.Int32)(4403)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APP_DATA_REBOOT_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_APP_DATA_REBOOT_REQUIRED</unmanaged-short>
        AppDataRebootRequired = unchecked((System.Int32)(4404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_ROLLBACK_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_ROLLBACK_DETECTED</unmanaged-short>
        SecurebootRollbackDetected = unchecked((System.Int32)(4420)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_POLICY_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_POLICY_VIOLATION</unmanaged-short>
        SecurebootPolicyViolation = unchecked((System.Int32)(4421)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_INVALID_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_INVALID_POLICY</unmanaged-short>
        SecurebootInvalidPolicy = unchecked((System.Int32)(4422)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND</unmanaged-short>
        SecurebootPolicyPublisherNotFound = unchecked((System.Int32)(4423)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_POLICY_NOT_SIGNED</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_POLICY_NOT_SIGNED</unmanaged-short>
        SecurebootPolicyNotSigned = unchecked((System.Int32)(4424)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_NOT_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_NOT_ENABLED</unmanaged-short>
        SecurebootNotEnabled = unchecked((System.Int32)(4425)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_FILE_REPLACED</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_FILE_REPLACED</unmanaged-short>
        SecurebootFileReplaced = unchecked((System.Int32)(4426)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_POLICY_NOT_AUTHORIZED</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_POLICY_NOT_AUTHORIZED</unmanaged-short>
        SecurebootPolicyNotAuthorized = unchecked((System.Int32)(4427)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_POLICY_UNKNOWN</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_POLICY_UNKNOWN</unmanaged-short>
        SecurebootPolicyUnknown = unchecked((System.Int32)(4428)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION</unmanaged-short>
        SecurebootPolicyMissingAntirollbackversion = unchecked((System.Int32)(4429)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_PLATFORM_ID_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_PLATFORM_ID_MISMATCH</unmanaged-short>
        SecurebootPlatformIdMismatch = unchecked((System.Int32)(4430)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_POLICY_ROLLBACK_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_POLICY_ROLLBACK_DETECTED</unmanaged-short>
        SecurebootPolicyRollbackDetected = unchecked((System.Int32)(4431)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_POLICY_UPGRADE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_POLICY_UPGRADE_MISMATCH</unmanaged-short>
        SecurebootPolicyUpgradeMismatch = unchecked((System.Int32)(4432)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING</unmanaged-short>
        SecurebootRequiredPolicyFileMissing = unchecked((System.Int32)(4433)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_NOT_BASE_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_NOT_BASE_POLICY</unmanaged-short>
        SecurebootNotBasePolicy = unchecked((System.Int32)(4434)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY</unmanaged-short>
        SecurebootNotSupplementalPolicy = unchecked((System.Int32)(4435)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED</unmanaged-short>
        OffloadReadFltNotSupported = unchecked((System.Int32)(4440)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED</unmanaged-short>
        OffloadWriteFltNotSupported = unchecked((System.Int32)(4441)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED</unmanaged-short>
        OffloadReadFileNotSupported = unchecked((System.Int32)(4442)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED</unmanaged-short>
        OffloadWriteFileNotSupported = unchecked((System.Int32)(4443)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALREADY_HAS_STREAM_ID</unmanaged>
        /// <unmanaged-short>ERROR_ALREADY_HAS_STREAM_ID</unmanaged-short>
        AlreadyHasStreamId = unchecked((System.Int32)(4444)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SMR_GARBAGE_COLLECTION_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_SMR_GARBAGE_COLLECTION_REQUIRED</unmanaged-short>
        SmrGarbageCollectionRequired = unchecked((System.Int32)(4445)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WOF_WIM_HEADER_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_WOF_WIM_HEADER_CORRUPT</unmanaged-short>
        WofWimHeaderCorrupt = unchecked((System.Int32)(4446)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WOF_WIM_RESOURCE_TABLE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_WOF_WIM_RESOURCE_TABLE_CORRUPT</unmanaged-short>
        WofWimResourceTableCorrupt = unchecked((System.Int32)(4447)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WOF_FILE_RESOURCE_TABLE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_WOF_FILE_RESOURCE_TABLE_CORRUPT</unmanaged-short>
        WofFileResourceTableCorrupt = unchecked((System.Int32)(4448)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLUME_NOT_SIS_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_VOLUME_NOT_SIS_ENABLED</unmanaged-short>
        VolumeNotSisEnabled = unchecked((System.Int32)(4500)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_INTEGRITY_ROLLBACK_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_INTEGRITY_ROLLBACK_DETECTED</unmanaged-short>
        SystemIntegrityRollbackDetected = unchecked((System.Int32)(4550)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_INTEGRITY_POLICY_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_INTEGRITY_POLICY_VIOLATION</unmanaged-short>
        SystemIntegrityPolicyViolation = unchecked((System.Int32)(4551)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_INTEGRITY_INVALID_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_INTEGRITY_INVALID_POLICY</unmanaged-short>
        SystemIntegrityInvalidPolicy = unchecked((System.Int32)(4552)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED</unmanaged-short>
        SystemIntegrityPolicyNotSigned = unchecked((System.Int32)(4553)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VSM_NOT_INITIALIZED</unmanaged>
        /// <unmanaged-short>ERROR_VSM_NOT_INITIALIZED</unmanaged-short>
        VsmNotInitialized = unchecked((System.Int32)(4560)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VSM_DMA_PROTECTION_NOT_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_VSM_DMA_PROTECTION_NOT_IN_USE</unmanaged-short>
        VsmDmaProtectionNotInUse = unchecked((System.Int32)(4561)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PLATFORM_MANIFEST_NOT_AUTHORIZED</unmanaged>
        /// <unmanaged-short>ERROR_PLATFORM_MANIFEST_NOT_AUTHORIZED</unmanaged-short>
        PlatformManifestNotAuthorized = unchecked((System.Int32)(4570)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PLATFORM_MANIFEST_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_PLATFORM_MANIFEST_INVALID</unmanaged-short>
        PlatformManifestInvalid = unchecked((System.Int32)(4571)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED</unmanaged>
        /// <unmanaged-short>ERROR_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED</unmanaged-short>
        PlatformManifestFileNotAuthorized = unchecked((System.Int32)(4572)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED</unmanaged>
        /// <unmanaged-short>ERROR_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED</unmanaged-short>
        PlatformManifestCatalogNotAuthorized = unchecked((System.Int32)(4573)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND</unmanaged-short>
        PlatformManifestBinaryIdNotFound = unchecked((System.Int32)(4574)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PLATFORM_MANIFEST_NOT_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_PLATFORM_MANIFEST_NOT_ACTIVE</unmanaged-short>
        PlatformManifestNotActive = unchecked((System.Int32)(4575)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PLATFORM_MANIFEST_NOT_SIGNED</unmanaged>
        /// <unmanaged-short>ERROR_PLATFORM_MANIFEST_NOT_SIGNED</unmanaged-short>
        PlatformManifestNotSigned = unchecked((System.Int32)(4576)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPENDENT_RESOURCE_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DEPENDENT_RESOURCE_EXISTS</unmanaged-short>
        DependentResourceExists = unchecked((System.Int32)(5001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPENDENCY_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DEPENDENCY_NOT_FOUND</unmanaged-short>
        DependencyNotFound = unchecked((System.Int32)(5002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPENDENCY_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DEPENDENCY_ALREADY_EXISTS</unmanaged-short>
        DependencyAlreadyExists = unchecked((System.Int32)(5003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_NOT_ONLINE</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_NOT_ONLINE</unmanaged-short>
        ResourceNotOnline = unchecked((System.Int32)(5004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOST_NODE_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_HOST_NODE_NOT_AVAILABLE</unmanaged-short>
        HostNodeNotAvailable = unchecked((System.Int32)(5005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_NOT_AVAILABLE</unmanaged-short>
        ResourceNotAvailable = unchecked((System.Int32)(5006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_NOT_FOUND</unmanaged-short>
        ResourceNotFound = unchecked((System.Int32)(5007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHUTDOWN_CLUSTER</unmanaged>
        /// <unmanaged-short>ERROR_SHUTDOWN_CLUSTER</unmanaged-short>
        ShutdownCluster = unchecked((System.Int32)(5008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_EVICT_ACTIVE_NODE</unmanaged>
        /// <unmanaged-short>ERROR_CANT_EVICT_ACTIVE_NODE</unmanaged-short>
        CantEvictActiveNode = unchecked((System.Int32)(5009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OBJECT_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_OBJECT_ALREADY_EXISTS</unmanaged-short>
        ObjectAlreadyExists = unchecked((System.Int32)(5010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OBJECT_IN_LIST</unmanaged>
        /// <unmanaged-short>ERROR_OBJECT_IN_LIST</unmanaged-short>
        ObjectInList = unchecked((System.Int32)(5011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GROUP_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_GROUP_NOT_AVAILABLE</unmanaged-short>
        GroupNotAvailable = unchecked((System.Int32)(5012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GROUP_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_GROUP_NOT_FOUND</unmanaged-short>
        GroupNotFound = unchecked((System.Int32)(5013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GROUP_NOT_ONLINE</unmanaged>
        /// <unmanaged-short>ERROR_GROUP_NOT_ONLINE</unmanaged-short>
        GroupNotOnline = unchecked((System.Int32)(5014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOST_NODE_NOT_RESOURCE_OWNER</unmanaged>
        /// <unmanaged-short>ERROR_HOST_NODE_NOT_RESOURCE_OWNER</unmanaged-short>
        HostNodeNotResourceOwner = unchecked((System.Int32)(5015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HOST_NODE_NOT_GROUP_OWNER</unmanaged>
        /// <unmanaged-short>ERROR_HOST_NODE_NOT_GROUP_OWNER</unmanaged-short>
        HostNodeNotGroupOwner = unchecked((System.Int32)(5016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESMON_CREATE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_RESMON_CREATE_FAILED</unmanaged-short>
        ResmonCreateFailed = unchecked((System.Int32)(5017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESMON_ONLINE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_RESMON_ONLINE_FAILED</unmanaged-short>
        ResmonOnlineFailed = unchecked((System.Int32)(5018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_ONLINE</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_ONLINE</unmanaged-short>
        ResourceOnline = unchecked((System.Int32)(5019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUORUM_RESOURCE</unmanaged>
        /// <unmanaged-short>ERROR_QUORUM_RESOURCE</unmanaged-short>
        QuorumResource = unchecked((System.Int32)(5020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_QUORUM_CAPABLE</unmanaged>
        /// <unmanaged-short>ERROR_NOT_QUORUM_CAPABLE</unmanaged-short>
        NotQuorumCapable = unchecked((System.Int32)(5021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_SHUTTING_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_SHUTTING_DOWN</unmanaged-short>
        ClusterShuttingDown = unchecked((System.Int32)(5022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_STATE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_STATE</unmanaged-short>
        InvalidState = unchecked((System.Int32)(5023)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_PROPERTIES_STORED</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_PROPERTIES_STORED</unmanaged-short>
        ResourcePropertiesStored = unchecked((System.Int32)(5024)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_QUORUM_CLASS</unmanaged>
        /// <unmanaged-short>ERROR_NOT_QUORUM_CLASS</unmanaged-short>
        NotQuorumClass = unchecked((System.Int32)(5025)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CORE_RESOURCE</unmanaged>
        /// <unmanaged-short>ERROR_CORE_RESOURCE</unmanaged-short>
        CoreResource = unchecked((System.Int32)(5026)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUORUM_RESOURCE_ONLINE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_QUORUM_RESOURCE_ONLINE_FAILED</unmanaged-short>
        QuorumResourceOnlineFailed = unchecked((System.Int32)(5027)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUORUMLOG_OPEN_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_QUORUMLOG_OPEN_FAILED</unmanaged-short>
        QuorumlogOpenFailed = unchecked((System.Int32)(5028)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTERLOG_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTERLOG_CORRUPT</unmanaged-short>
        ClusterlogCorrupt = unchecked((System.Int32)(5029)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE</unmanaged-short>
        ClusterlogRecordExceedsMaxsize = unchecked((System.Int32)(5030)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE</unmanaged-short>
        ClusterlogExceedsMaxsize = unchecked((System.Int32)(5031)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND</unmanaged-short>
        ClusterlogChkpointNotFound = unchecked((System.Int32)(5032)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE</unmanaged-short>
        ClusterlogNotEnoughSpace = unchecked((System.Int32)(5033)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUORUM_OWNER_ALIVE</unmanaged>
        /// <unmanaged-short>ERROR_QUORUM_OWNER_ALIVE</unmanaged-short>
        QuorumOwnerAlive = unchecked((System.Int32)(5034)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NETWORK_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_NETWORK_NOT_AVAILABLE</unmanaged-short>
        NetworkNotAvailable = unchecked((System.Int32)(5035)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NODE_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_NODE_NOT_AVAILABLE</unmanaged-short>
        NodeNotAvailable = unchecked((System.Int32)(5036)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALL_NODES_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_ALL_NODES_NOT_AVAILABLE</unmanaged-short>
        AllNodesNotAvailable = unchecked((System.Int32)(5037)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_FAILED</unmanaged-short>
        ResourceFailed = unchecked((System.Int32)(5038)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_NODE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_NODE</unmanaged-short>
        ClusterInvalidNode = unchecked((System.Int32)(5039)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_EXISTS</unmanaged-short>
        ClusterNodeExists = unchecked((System.Int32)(5040)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_JOIN_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_JOIN_IN_PROGRESS</unmanaged-short>
        ClusterJoinInProgress = unchecked((System.Int32)(5041)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_NOT_FOUND</unmanaged-short>
        ClusterNodeNotFound = unchecked((System.Int32)(5042)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND</unmanaged-short>
        ClusterLocalNodeNotFound = unchecked((System.Int32)(5043)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETWORK_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETWORK_EXISTS</unmanaged-short>
        ClusterNetworkExists = unchecked((System.Int32)(5044)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETWORK_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETWORK_NOT_FOUND</unmanaged-short>
        ClusterNetworkNotFound = unchecked((System.Int32)(5045)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETINTERFACE_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETINTERFACE_EXISTS</unmanaged-short>
        ClusterNetinterfaceExists = unchecked((System.Int32)(5046)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETINTERFACE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETINTERFACE_NOT_FOUND</unmanaged-short>
        ClusterNetinterfaceNotFound = unchecked((System.Int32)(5047)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_REQUEST</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_REQUEST</unmanaged-short>
        ClusterInvalidRequest = unchecked((System.Int32)(5048)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_NETWORK_PROVIDER</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_NETWORK_PROVIDER</unmanaged-short>
        ClusterInvalidNetworkProvider = unchecked((System.Int32)(5049)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_DOWN</unmanaged-short>
        ClusterNodeDown = unchecked((System.Int32)(5050)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_UNREACHABLE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_UNREACHABLE</unmanaged-short>
        ClusterNodeUnreachable = unchecked((System.Int32)(5051)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_NOT_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_NOT_MEMBER</unmanaged-short>
        ClusterNodeNotMember = unchecked((System.Int32)(5052)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS</unmanaged-short>
        ClusterJoinNotInProgress = unchecked((System.Int32)(5053)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_NETWORK</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_NETWORK</unmanaged-short>
        ClusterInvalidNetwork = unchecked((System.Int32)(5054)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_UP</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_UP</unmanaged-short>
        ClusterNodeUp = unchecked((System.Int32)(5056)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_IPADDR_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_IPADDR_IN_USE</unmanaged-short>
        ClusterIpaddrInUse = unchecked((System.Int32)(5057)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_NOT_PAUSED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_NOT_PAUSED</unmanaged-short>
        ClusterNodeNotPaused = unchecked((System.Int32)(5058)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NO_SECURITY_CONTEXT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NO_SECURITY_CONTEXT</unmanaged-short>
        ClusterNoSecurityContext = unchecked((System.Int32)(5059)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETWORK_NOT_INTERNAL</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETWORK_NOT_INTERNAL</unmanaged-short>
        ClusterNetworkNotInternal = unchecked((System.Int32)(5060)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_ALREADY_UP</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_ALREADY_UP</unmanaged-short>
        ClusterNodeAlreadyUp = unchecked((System.Int32)(5061)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_ALREADY_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_ALREADY_DOWN</unmanaged-short>
        ClusterNodeAlreadyDown = unchecked((System.Int32)(5062)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETWORK_ALREADY_ONLINE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETWORK_ALREADY_ONLINE</unmanaged-short>
        ClusterNetworkAlreadyOnline = unchecked((System.Int32)(5063)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE</unmanaged-short>
        ClusterNetworkAlreadyOffline = unchecked((System.Int32)(5064)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_ALREADY_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_ALREADY_MEMBER</unmanaged-short>
        ClusterNodeAlreadyMember = unchecked((System.Int32)(5065)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_LAST_INTERNAL_NETWORK</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_LAST_INTERNAL_NETWORK</unmanaged-short>
        ClusterLastInternalNetwork = unchecked((System.Int32)(5066)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS</unmanaged-short>
        ClusterNetworkHasDependents = unchecked((System.Int32)(5067)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_OPERATION_ON_QUORUM</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_OPERATION_ON_QUORUM</unmanaged-short>
        InvalidOperationOnQuorum = unchecked((System.Int32)(5068)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPENDENCY_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_DEPENDENCY_NOT_ALLOWED</unmanaged-short>
        DependencyNotAllowed = unchecked((System.Int32)(5069)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_PAUSED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_PAUSED</unmanaged-short>
        ClusterNodePaused = unchecked((System.Int32)(5070)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NODE_CANT_HOST_RESOURCE</unmanaged>
        /// <unmanaged-short>ERROR_NODE_CANT_HOST_RESOURCE</unmanaged-short>
        NodeCantHostResource = unchecked((System.Int32)(5071)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_NOT_READY</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_NOT_READY</unmanaged-short>
        ClusterNodeNotReady = unchecked((System.Int32)(5072)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_SHUTTING_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_SHUTTING_DOWN</unmanaged-short>
        ClusterNodeShuttingDown = unchecked((System.Int32)(5073)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_JOIN_ABORTED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_JOIN_ABORTED</unmanaged-short>
        ClusterJoinAborted = unchecked((System.Int32)(5074)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INCOMPATIBLE_VERSIONS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INCOMPATIBLE_VERSIONS</unmanaged-short>
        ClusterIncompatibleVersions = unchecked((System.Int32)(5075)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED</unmanaged-short>
        ClusterMaxnumOfResourcesExceeded = unchecked((System.Int32)(5076)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED</unmanaged-short>
        ClusterSystemConfigChanged = unchecked((System.Int32)(5077)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND</unmanaged-short>
        ClusterResourceTypeNotFound = unchecked((System.Int32)(5078)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED</unmanaged-short>
        ClusterRestypeNotSupported = unchecked((System.Int32)(5079)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESNAME_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESNAME_NOT_FOUND</unmanaged-short>
        ClusterResnameNotFound = unchecked((System.Int32)(5080)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED</unmanaged-short>
        ClusterNoRpcPackagesRegistered = unchecked((System.Int32)(5081)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST</unmanaged-short>
        ClusterOwnerNotInPreflist = unchecked((System.Int32)(5082)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_DATABASE_SEQMISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_DATABASE_SEQMISMATCH</unmanaged-short>
        ClusterDatabaseSeqmismatch = unchecked((System.Int32)(5083)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESMON_INVALID_STATE</unmanaged>
        /// <unmanaged-short>ERROR_RESMON_INVALID_STATE</unmanaged-short>
        ResmonInvalidState = unchecked((System.Int32)(5084)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_GUM_NOT_LOCKER</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_GUM_NOT_LOCKER</unmanaged-short>
        ClusterGumNotLocker = unchecked((System.Int32)(5085)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUORUM_DISK_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_QUORUM_DISK_NOT_FOUND</unmanaged-short>
        QuorumDiskNotFound = unchecked((System.Int32)(5086)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DATABASE_BACKUP_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_DATABASE_BACKUP_CORRUPT</unmanaged-short>
        DatabaseBackupCorrupt = unchecked((System.Int32)(5087)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT</unmanaged-short>
        ClusterNodeAlreadyHasDfsRoot = unchecked((System.Int32)(5088)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_PROPERTY_UNCHANGEABLE</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_PROPERTY_UNCHANGEABLE</unmanaged-short>
        ResourcePropertyUnchangeable = unchecked((System.Int32)(5089)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_ADMIN_ACCESS_POINT</unmanaged>
        /// <unmanaged-short>ERROR_NO_ADMIN_ACCESS_POINT</unmanaged-short>
        NoAdminAccessPoint = unchecked((System.Int32)(5090)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE</unmanaged-short>
        ClusterMembershipInvalidState = unchecked((System.Int32)(5890)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_QUORUMLOG_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_QUORUMLOG_NOT_FOUND</unmanaged-short>
        ClusterQuorumlogNotFound = unchecked((System.Int32)(5891)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_MEMBERSHIP_HALT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_MEMBERSHIP_HALT</unmanaged-short>
        ClusterMembershipHalt = unchecked((System.Int32)(5892)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INSTANCE_ID_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INSTANCE_ID_MISMATCH</unmanaged-short>
        ClusterInstanceIdMismatch = unchecked((System.Int32)(5893)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP</unmanaged-short>
        ClusterNetworkNotFoundForIp = unchecked((System.Int32)(5894)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH</unmanaged-short>
        ClusterPropertyDataTypeMismatch = unchecked((System.Int32)(5895)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP</unmanaged-short>
        ClusterEvictWithoutCleanup = unchecked((System.Int32)(5896)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_PARAMETER_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_PARAMETER_MISMATCH</unmanaged-short>
        ClusterParameterMismatch = unchecked((System.Int32)(5897)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NODE_CANNOT_BE_CLUSTERED</unmanaged>
        /// <unmanaged-short>ERROR_NODE_CANNOT_BE_CLUSTERED</unmanaged-short>
        NodeCannotBeClustered = unchecked((System.Int32)(5898)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_WRONG_OS_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_WRONG_OS_VERSION</unmanaged-short>
        ClusterWrongOsVersion = unchecked((System.Int32)(5899)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME</unmanaged-short>
        ClusterCantCreateDupClusterName = unchecked((System.Int32)(5900)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSCFG_ALREADY_COMMITTED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSCFG_ALREADY_COMMITTED</unmanaged-short>
        CluscfgAlreadyCommitted = unchecked((System.Int32)(5901)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSCFG_ROLLBACK_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSCFG_ROLLBACK_FAILED</unmanaged-short>
        CluscfgRollbackFailed = unchecked((System.Int32)(5902)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT</unmanaged-short>
        CluscfgSystemDiskDriveLetterConflict = unchecked((System.Int32)(5903)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_OLD_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_OLD_VERSION</unmanaged-short>
        ClusterOldVersion = unchecked((System.Int32)(5904)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME</unmanaged-short>
        ClusterMismatchedComputerAcctName = unchecked((System.Int32)(5905)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NO_NET_ADAPTERS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NO_NET_ADAPTERS</unmanaged-short>
        ClusterNoNetAdapters = unchecked((System.Int32)(5906)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_POISONED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_POISONED</unmanaged-short>
        ClusterPoisoned = unchecked((System.Int32)(5907)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_GROUP_MOVING</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_GROUP_MOVING</unmanaged-short>
        ClusterGroupMoving = unchecked((System.Int32)(5908)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_TYPE_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_TYPE_BUSY</unmanaged-short>
        ClusterResourceTypeBusy = unchecked((System.Int32)(5909)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_CALL_TIMED_OUT</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_CALL_TIMED_OUT</unmanaged-short>
        ResourceCallTimedOut = unchecked((System.Int32)(5910)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_CLUSTER_IPV6_ADDRESS</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_CLUSTER_IPV6_ADDRESS</unmanaged-short>
        InvalidClusterIpv6Address = unchecked((System.Int32)(5911)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION</unmanaged-short>
        ClusterInternalInvalidFunction = unchecked((System.Int32)(5912)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS</unmanaged-short>
        ClusterParameterOutOfBounds = unchecked((System.Int32)(5913)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_PARTIAL_SEND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_PARTIAL_SEND</unmanaged-short>
        ClusterPartialSend = unchecked((System.Int32)(5914)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION</unmanaged-short>
        ClusterRegistryInvalidFunction = unchecked((System.Int32)(5915)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_STRING_TERMINATION</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_STRING_TERMINATION</unmanaged-short>
        ClusterInvalidStringTermination = unchecked((System.Int32)(5916)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_STRING_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_STRING_FORMAT</unmanaged-short>
        ClusterInvalidStringFormat = unchecked((System.Int32)(5917)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS</unmanaged-short>
        ClusterDatabaseTransactionInProgress = unchecked((System.Int32)(5918)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS</unmanaged-short>
        ClusterDatabaseTransactionNotInProgress = unchecked((System.Int32)(5919)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NULL_DATA</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NULL_DATA</unmanaged-short>
        ClusterNullData = unchecked((System.Int32)(5920)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_PARTIAL_READ</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_PARTIAL_READ</unmanaged-short>
        ClusterPartialRead = unchecked((System.Int32)(5921)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_PARTIAL_WRITE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_PARTIAL_WRITE</unmanaged-short>
        ClusterPartialWrite = unchecked((System.Int32)(5922)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_CANT_DESERIALIZE_DATA</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_CANT_DESERIALIZE_DATA</unmanaged-short>
        ClusterCantDeserializeData = unchecked((System.Int32)(5923)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT</unmanaged-short>
        DependentResourcePropertyConflict = unchecked((System.Int32)(5924)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NO_QUORUM</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NO_QUORUM</unmanaged-short>
        ClusterNoQuorum = unchecked((System.Int32)(5925)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_IPV6_NETWORK</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_IPV6_NETWORK</unmanaged-short>
        ClusterInvalidIpv6Network = unchecked((System.Int32)(5926)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK</unmanaged-short>
        ClusterInvalidIpv6TunnelNetwork = unchecked((System.Int32)(5927)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP</unmanaged-short>
        QuorumNotAllowedInThisGroup = unchecked((System.Int32)(5928)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPENDENCY_TREE_TOO_COMPLEX</unmanaged>
        /// <unmanaged-short>ERROR_DEPENDENCY_TREE_TOO_COMPLEX</unmanaged-short>
        DependencyTreeTooComplex = unchecked((System.Int32)(5929)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXCEPTION_IN_RESOURCE_CALL</unmanaged>
        /// <unmanaged-short>ERROR_EXCEPTION_IN_RESOURCE_CALL</unmanaged-short>
        ExceptionInResourceCall = unchecked((System.Int32)(5930)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RHS_FAILED_INITIALIZATION</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RHS_FAILED_INITIALIZATION</unmanaged-short>
        ClusterRhsFailedInitialization = unchecked((System.Int32)(5931)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NOT_INSTALLED</unmanaged-short>
        ClusterNotInstalled = unchecked((System.Int32)(5932)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE</unmanaged-short>
        ClusterResourcesMustBeOnlineOnTheSameNode = unchecked((System.Int32)(5933)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_MAX_NODES_IN_CLUSTER</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_MAX_NODES_IN_CLUSTER</unmanaged-short>
        ClusterMaxNodesInCluster = unchecked((System.Int32)(5934)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_TOO_MANY_NODES</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_TOO_MANY_NODES</unmanaged-short>
        ClusterTooManyNodes = unchecked((System.Int32)(5935)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_OBJECT_ALREADY_USED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_OBJECT_ALREADY_USED</unmanaged-short>
        ClusterObjectAlreadyUsed = unchecked((System.Int32)(5936)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NONCORE_GROUPS_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NONCORE_GROUPS_FOUND</unmanaged-short>
        NoncoreGroupsFound = unchecked((System.Int32)(5937)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_SHARE_RESOURCE_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_FILE_SHARE_RESOURCE_CONFLICT</unmanaged-short>
        FileShareResourceConflict = unchecked((System.Int32)(5938)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_EVICT_INVALID_REQUEST</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_EVICT_INVALID_REQUEST</unmanaged-short>
        ClusterEvictInvalidRequest = unchecked((System.Int32)(5939)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_SINGLETON_RESOURCE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_SINGLETON_RESOURCE</unmanaged-short>
        ClusterSingletonResource = unchecked((System.Int32)(5940)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE</unmanaged-short>
        ClusterGroupSingletonResource = unchecked((System.Int32)(5941)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED</unmanaged-short>
        ClusterResourceProviderFailed = unchecked((System.Int32)(5942)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR</unmanaged-short>
        ClusterResourceConfigurationError = unchecked((System.Int32)(5943)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_GROUP_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_GROUP_BUSY</unmanaged-short>
        ClusterGroupBusy = unchecked((System.Int32)(5944)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NOT_SHARED_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NOT_SHARED_VOLUME</unmanaged-short>
        ClusterNotSharedVolume = unchecked((System.Int32)(5945)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR</unmanaged-short>
        ClusterInvalidSecurityDescriptor = unchecked((System.Int32)(5946)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_SHARED_VOLUMES_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_SHARED_VOLUMES_IN_USE</unmanaged-short>
        ClusterSharedVolumesInUse = unchecked((System.Int32)(5947)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_USE_SHARED_VOLUMES_API</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_USE_SHARED_VOLUMES_API</unmanaged-short>
        ClusterUseSharedVolumesApi = unchecked((System.Int32)(5948)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_BACKUP_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_BACKUP_IN_PROGRESS</unmanaged-short>
        ClusterBackupInProgress = unchecked((System.Int32)(5949)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NON_CSV_PATH</unmanaged>
        /// <unmanaged-short>ERROR_NON_CSV_PATH</unmanaged-short>
        NonCsvPath = unchecked((System.Int32)(5950)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CSV_VOLUME_NOT_LOCAL</unmanaged>
        /// <unmanaged-short>ERROR_CSV_VOLUME_NOT_LOCAL</unmanaged-short>
        CsvVolumeNotLocal = unchecked((System.Int32)(5951)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_WATCHDOG_TERMINATING</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_WATCHDOG_TERMINATING</unmanaged-short>
        ClusterWatchdogTerminating = unchecked((System.Int32)(5952)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES</unmanaged-short>
        ClusterResourceVetoedMoveIncompatibleNodes = unchecked((System.Int32)(5953)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_NODE_WEIGHT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_NODE_WEIGHT</unmanaged-short>
        ClusterInvalidNodeWeight = unchecked((System.Int32)(5954)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_VETOED_CALL</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_VETOED_CALL</unmanaged-short>
        ClusterResourceVetoedCall = unchecked((System.Int32)(5955)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESMON_SYSTEM_RESOURCES_LACKING</unmanaged>
        /// <unmanaged-short>ERROR_RESMON_SYSTEM_RESOURCES_LACKING</unmanaged-short>
        ResmonSystemResourcesLacking = unchecked((System.Int32)(5956)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION</unmanaged-short>
        ClusterResourceVetoedMoveNotEnoughResourcesOnDestination = unchecked((System.Int32)(5957)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE</unmanaged-short>
        ClusterResourceVetoedMoveNotEnoughResourcesOnSource = unchecked((System.Int32)(5958)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_GROUP_QUEUED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_GROUP_QUEUED</unmanaged-short>
        ClusterGroupQueued = unchecked((System.Int32)(5959)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_LOCKED_STATUS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_LOCKED_STATUS</unmanaged-short>
        ClusterResourceLockedStatus = unchecked((System.Int32)(5960)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED</unmanaged-short>
        ClusterSharedVolumeFailoverNotAllowed = unchecked((System.Int32)(5961)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS</unmanaged-short>
        ClusterNodeDrainInProgress = unchecked((System.Int32)(5962)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_DISK_NOT_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_DISK_NOT_CONNECTED</unmanaged-short>
        ClusterDiskNotConnected = unchecked((System.Int32)(5963)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DISK_NOT_CSV_CAPABLE</unmanaged>
        /// <unmanaged-short>ERROR_DISK_NOT_CSV_CAPABLE</unmanaged-short>
        DiskNotCsvCapable = unchecked((System.Int32)(5964)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE</unmanaged-short>
        ResourceNotInAvailableStorage = unchecked((System.Int32)(5965)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED</unmanaged-short>
        ClusterSharedVolumeRedirected = unchecked((System.Int32)(5966)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED</unmanaged-short>
        ClusterSharedVolumeNotRedirected = unchecked((System.Int32)(5967)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES</unmanaged-short>
        ClusterCannotReturnProperties = unchecked((System.Int32)(5968)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES</unmanaged-short>
        ClusterResourceContainsUnsupportedDiffAreaForSharedVolumes = unchecked((System.Int32)(5969)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE</unmanaged-short>
        ClusterResourceIsInMaintenanceMode = unchecked((System.Int32)(5970)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_AFFINITY_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_AFFINITY_CONFLICT</unmanaged-short>
        ClusterAffinityConflict = unchecked((System.Int32)(5971)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE</unmanaged-short>
        ClusterResourceIsReplicaVirtualMachine = unchecked((System.Int32)(5972)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_UPGRADE_INCOMPATIBLE_VERSIONS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_UPGRADE_INCOMPATIBLE_VERSIONS</unmanaged-short>
        ClusterUpgradeIncompatibleVersions = unchecked((System.Int32)(5973)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_UPGRADE_FIX_QUORUM_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_UPGRADE_FIX_QUORUM_NOT_SUPPORTED</unmanaged-short>
        ClusterUpgradeFixQuorumNotSupported = unchecked((System.Int32)(5974)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_UPGRADE_RESTART_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_UPGRADE_RESTART_REQUIRED</unmanaged-short>
        ClusterUpgradeRestartRequired = unchecked((System.Int32)(5975)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_UPGRADE_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_UPGRADE_IN_PROGRESS</unmanaged-short>
        ClusterUpgradeInProgress = unchecked((System.Int32)(5976)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_UPGRADE_INCOMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_UPGRADE_INCOMPLETE</unmanaged-short>
        ClusterUpgradeIncomplete = unchecked((System.Int32)(5977)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_IN_GRACE_PERIOD</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_IN_GRACE_PERIOD</unmanaged-short>
        ClusterNodeInGracePeriod = unchecked((System.Int32)(5978)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_CSV_IO_PAUSE_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_CSV_IO_PAUSE_TIMEOUT</unmanaged-short>
        ClusterCsvIoPauseTimeout = unchecked((System.Int32)(5979)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NODE_NOT_ACTIVE_CLUSTER_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_NODE_NOT_ACTIVE_CLUSTER_MEMBER</unmanaged-short>
        NodeNotActiveClusterMember = unchecked((System.Int32)(5980)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_NOT_MONITORED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_NOT_MONITORED</unmanaged-short>
        ClusterResourceNotMonitored = unchecked((System.Int32)(5981)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_DOES_NOT_SUPPORT_UNMONITORED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_DOES_NOT_SUPPORT_UNMONITORED</unmanaged-short>
        ClusterResourceDoesNotSupportUnmonitored = unchecked((System.Int32)(5982)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_RESOURCE_IS_REPLICATED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_RESOURCE_IS_REPLICATED</unmanaged-short>
        ClusterResourceIsReplicated = unchecked((System.Int32)(5983)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_ISOLATED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_ISOLATED</unmanaged-short>
        ClusterNodeIsolated = unchecked((System.Int32)(5984)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_NODE_QUARANTINED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_NODE_QUARANTINED</unmanaged-short>
        ClusterNodeQuarantined = unchecked((System.Int32)(5985)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_DATABASE_UPDATE_CONDITION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_DATABASE_UPDATE_CONDITION_FAILED</unmanaged-short>
        ClusterDatabaseUpdateConditionFailed = unchecked((System.Int32)(5986)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_SPACE_DEGRADED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_SPACE_DEGRADED</unmanaged-short>
        ClusterSpaceDegraded = unchecked((System.Int32)(5987)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_TOKEN_DELEGATION_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_TOKEN_DELEGATION_NOT_SUPPORTED</unmanaged-short>
        ClusterTokenDelegationNotSupported = unchecked((System.Int32)(5988)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_CSV_INVALID_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_CSV_INVALID_HANDLE</unmanaged-short>
        ClusterCsvInvalidHandle = unchecked((System.Int32)(5989)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR</unmanaged-short>
        ClusterCsvSupportedOnlyOnCoordinator = unchecked((System.Int32)(5990)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GROUPSET_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_GROUPSET_NOT_AVAILABLE</unmanaged-short>
        GroupsetNotAvailable = unchecked((System.Int32)(5991)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GROUPSET_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_GROUPSET_NOT_FOUND</unmanaged-short>
        GroupsetNotFound = unchecked((System.Int32)(5992)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GROUPSET_CANT_PROVIDE</unmanaged>
        /// <unmanaged-short>ERROR_GROUPSET_CANT_PROVIDE</unmanaged-short>
        GroupsetCantProvide = unchecked((System.Int32)(5993)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_FAULT_DOMAIN_PARENT_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_FAULT_DOMAIN_PARENT_NOT_FOUND</unmanaged-short>
        ClusterFaultDomainParentNotFound = unchecked((System.Int32)(5994)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_FAULT_DOMAIN_INVALID_HIERARCHY</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_FAULT_DOMAIN_INVALID_HIERARCHY</unmanaged-short>
        ClusterFaultDomainInvalidHierarchy = unchecked((System.Int32)(5995)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_FAULT_DOMAIN_FAILED_S2D_VALIDATION</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_FAULT_DOMAIN_FAILED_S2D_VALIDATION</unmanaged-short>
        ClusterFaultDomainFailedS2DValidation = unchecked((System.Int32)(5996)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_FAULT_DOMAIN_S2D_CONNECTIVITY_LOSS</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_FAULT_DOMAIN_S2D_CONNECTIVITY_LOSS</unmanaged-short>
        ClusterFaultDomainS2DConnectivityLoss = unchecked((System.Int32)(5997)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTER_INVALID_INFRASTRUCTURE_FILESERVER_NAME</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTER_INVALID_INFRASTRUCTURE_FILESERVER_NAME</unmanaged-short>
        ClusterInvalidInfrastructureFileserverName = unchecked((System.Int32)(5998)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLUSTERSET_MANAGEMENT_CLUSTER_UNREACHABLE</unmanaged>
        /// <unmanaged-short>ERROR_CLUSTERSET_MANAGEMENT_CLUSTER_UNREACHABLE</unmanaged-short>
        ClustersetManagementClusterUnreachable = unchecked((System.Int32)(5999)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENCRYPTION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_ENCRYPTION_FAILED</unmanaged-short>
        EncryptionFailed = unchecked((System.Int32)(6000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DECRYPTION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DECRYPTION_FAILED</unmanaged-short>
        DecryptionFailed = unchecked((System.Int32)(6001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_ENCRYPTED</unmanaged>
        /// <unmanaged-short>ERROR_FILE_ENCRYPTED</unmanaged-short>
        FileEncrypted = unchecked((System.Int32)(6002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_RECOVERY_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_NO_RECOVERY_POLICY</unmanaged-short>
        NoRecoveryPolicy = unchecked((System.Int32)(6003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_EFS</unmanaged>
        /// <unmanaged-short>ERROR_NO_EFS</unmanaged-short>
        NoEfs = unchecked((System.Int32)(6004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_WRONG_EFS</unmanaged>
        /// <unmanaged-short>ERROR_WRONG_EFS</unmanaged-short>
        WrongEfs = unchecked((System.Int32)(6005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_USER_KEYS</unmanaged>
        /// <unmanaged-short>ERROR_NO_USER_KEYS</unmanaged-short>
        NoUserKeys = unchecked((System.Int32)(6006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_NOT_ENCRYPTED</unmanaged>
        /// <unmanaged-short>ERROR_FILE_NOT_ENCRYPTED</unmanaged-short>
        FileNotEncrypted = unchecked((System.Int32)(6007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_EXPORT_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_NOT_EXPORT_FORMAT</unmanaged-short>
        NotExportFormat = unchecked((System.Int32)(6008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_READ_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_FILE_READ_ONLY</unmanaged-short>
        FileReadOnly = unchecked((System.Int32)(6009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIR_EFS_DISALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_DIR_EFS_DISALLOWED</unmanaged-short>
        DirEfsDisallowed = unchecked((System.Int32)(6010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EFS_SERVER_NOT_TRUSTED</unmanaged>
        /// <unmanaged-short>ERROR_EFS_SERVER_NOT_TRUSTED</unmanaged-short>
        EfsServerNotTrusted = unchecked((System.Int32)(6011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_RECOVERY_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_BAD_RECOVERY_POLICY</unmanaged-short>
        BadRecoveryPolicy = unchecked((System.Int32)(6012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EFS_ALG_BLOB_TOO_BIG</unmanaged>
        /// <unmanaged-short>ERROR_EFS_ALG_BLOB_TOO_BIG</unmanaged-short>
        EfsAlgBlobTooBig = unchecked((System.Int32)(6013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLUME_NOT_SUPPORT_EFS</unmanaged>
        /// <unmanaged-short>ERROR_VOLUME_NOT_SUPPORT_EFS</unmanaged-short>
        VolumeNotSupportEfs = unchecked((System.Int32)(6014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EFS_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_EFS_DISABLED</unmanaged-short>
        EfsDisabled = unchecked((System.Int32)(6015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EFS_VERSION_NOT_SUPPORT</unmanaged>
        /// <unmanaged-short>ERROR_EFS_VERSION_NOT_SUPPORT</unmanaged-short>
        EfsVersionNotSupport = unchecked((System.Int32)(6016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE</unmanaged>
        /// <unmanaged-short>ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE</unmanaged-short>
        CsEncryptionInvalidServerResponse = unchecked((System.Int32)(6017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER</unmanaged>
        /// <unmanaged-short>ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER</unmanaged-short>
        CsEncryptionUnsupportedServer = unchecked((System.Int32)(6018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE</unmanaged>
        /// <unmanaged-short>ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE</unmanaged-short>
        CsEncryptionExistingEncryptedFile = unchecked((System.Int32)(6019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE</unmanaged>
        /// <unmanaged-short>ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE</unmanaged-short>
        CsEncryptionNewEncryptedFile = unchecked((System.Int32)(6020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CS_ENCRYPTION_FILE_NOT_CSE</unmanaged>
        /// <unmanaged-short>ERROR_CS_ENCRYPTION_FILE_NOT_CSE</unmanaged-short>
        CsEncryptionFileNotCse = unchecked((System.Int32)(6021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENCRYPTION_POLICY_DENIES_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_ENCRYPTION_POLICY_DENIES_OPERATION</unmanaged-short>
        EncryptionPolicyDeniesOperation = unchecked((System.Int32)(6022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_BROWSER_SERVERS_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NO_BROWSER_SERVERS_FOUND</unmanaged-short>
        NoBrowserServersFound = unchecked((System.Int32)(6118)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_SECTOR_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_SECTOR_INVALID</unmanaged-short>
        LogSectorInvalid = unchecked((System.Int32)(6600)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_SECTOR_PARITY_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_SECTOR_PARITY_INVALID</unmanaged-short>
        LogSectorParityInvalid = unchecked((System.Int32)(6601)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_SECTOR_REMAPPED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_SECTOR_REMAPPED</unmanaged-short>
        LogSectorRemapped = unchecked((System.Int32)(6602)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_BLOCK_INCOMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_LOG_BLOCK_INCOMPLETE</unmanaged-short>
        LogBlockIncomplete = unchecked((System.Int32)(6603)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_INVALID_RANGE</unmanaged>
        /// <unmanaged-short>ERROR_LOG_INVALID_RANGE</unmanaged-short>
        LogInvalidRange = unchecked((System.Int32)(6604)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_BLOCKS_EXHAUSTED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_BLOCKS_EXHAUSTED</unmanaged-short>
        LogBlocksExhausted = unchecked((System.Int32)(6605)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_READ_CONTEXT_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_READ_CONTEXT_INVALID</unmanaged-short>
        LogReadContextInvalid = unchecked((System.Int32)(6606)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_RESTART_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_RESTART_INVALID</unmanaged-short>
        LogRestartInvalid = unchecked((System.Int32)(6607)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_BLOCK_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_LOG_BLOCK_VERSION</unmanaged-short>
        LogBlockVersion = unchecked((System.Int32)(6608)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_BLOCK_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_BLOCK_INVALID</unmanaged-short>
        LogBlockInvalid = unchecked((System.Int32)(6609)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_READ_MODE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_READ_MODE_INVALID</unmanaged-short>
        LogReadModeInvalid = unchecked((System.Int32)(6610)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_NO_RESTART</unmanaged>
        /// <unmanaged-short>ERROR_LOG_NO_RESTART</unmanaged-short>
        LogNoRestart = unchecked((System.Int32)(6611)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_METADATA_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_LOG_METADATA_CORRUPT</unmanaged-short>
        LogMetadataCorrupt = unchecked((System.Int32)(6612)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_METADATA_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_METADATA_INVALID</unmanaged-short>
        LogMetadataInvalid = unchecked((System.Int32)(6613)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_METADATA_INCONSISTENT</unmanaged>
        /// <unmanaged-short>ERROR_LOG_METADATA_INCONSISTENT</unmanaged-short>
        LogMetadataInconsistent = unchecked((System.Int32)(6614)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_RESERVATION_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_RESERVATION_INVALID</unmanaged-short>
        LogReservationInvalid = unchecked((System.Int32)(6615)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CANT_DELETE</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CANT_DELETE</unmanaged-short>
        LogCantDelete = unchecked((System.Int32)(6616)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CONTAINER_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CONTAINER_LIMIT_EXCEEDED</unmanaged-short>
        LogContainerLimitExceeded = unchecked((System.Int32)(6617)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_START_OF_LOG</unmanaged>
        /// <unmanaged-short>ERROR_LOG_START_OF_LOG</unmanaged-short>
        LogStartOfLog = unchecked((System.Int32)(6618)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_POLICY_ALREADY_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_POLICY_ALREADY_INSTALLED</unmanaged-short>
        LogPolicyAlreadyInstalled = unchecked((System.Int32)(6619)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_POLICY_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_POLICY_NOT_INSTALLED</unmanaged-short>
        LogPolicyNotInstalled = unchecked((System.Int32)(6620)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_POLICY_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_POLICY_INVALID</unmanaged-short>
        LogPolicyInvalid = unchecked((System.Int32)(6621)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_POLICY_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_LOG_POLICY_CONFLICT</unmanaged-short>
        LogPolicyConflict = unchecked((System.Int32)(6622)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_PINNED_ARCHIVE_TAIL</unmanaged>
        /// <unmanaged-short>ERROR_LOG_PINNED_ARCHIVE_TAIL</unmanaged-short>
        LogPinnedArchiveTail = unchecked((System.Int32)(6623)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_RECORD_NONEXISTENT</unmanaged>
        /// <unmanaged-short>ERROR_LOG_RECORD_NONEXISTENT</unmanaged-short>
        LogRecordNonexistent = unchecked((System.Int32)(6624)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_RECORDS_RESERVED_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_RECORDS_RESERVED_INVALID</unmanaged-short>
        LogRecordsReservedInvalid = unchecked((System.Int32)(6625)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_SPACE_RESERVED_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_SPACE_RESERVED_INVALID</unmanaged-short>
        LogSpaceReservedInvalid = unchecked((System.Int32)(6626)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_TAIL_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_TAIL_INVALID</unmanaged-short>
        LogTailInvalid = unchecked((System.Int32)(6627)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_FULL</unmanaged>
        /// <unmanaged-short>ERROR_LOG_FULL</unmanaged-short>
        LogFull = unchecked((System.Int32)(6628)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COULD_NOT_RESIZE_LOG</unmanaged>
        /// <unmanaged-short>ERROR_COULD_NOT_RESIZE_LOG</unmanaged-short>
        CouldNotResizeLog = unchecked((System.Int32)(6629)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_MULTIPLEXED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_MULTIPLEXED</unmanaged-short>
        LogMultiplexed = unchecked((System.Int32)(6630)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_DEDICATED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_DEDICATED</unmanaged-short>
        LogDedicated = unchecked((System.Int32)(6631)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS</unmanaged-short>
        LogArchiveNotInProgress = unchecked((System.Int32)(6632)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_ARCHIVE_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_LOG_ARCHIVE_IN_PROGRESS</unmanaged-short>
        LogArchiveInProgress = unchecked((System.Int32)(6633)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_EPHEMERAL</unmanaged>
        /// <unmanaged-short>ERROR_LOG_EPHEMERAL</unmanaged-short>
        LogEphemeral = unchecked((System.Int32)(6634)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_NOT_ENOUGH_CONTAINERS</unmanaged>
        /// <unmanaged-short>ERROR_LOG_NOT_ENOUGH_CONTAINERS</unmanaged-short>
        LogNotEnoughContainers = unchecked((System.Int32)(6635)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CLIENT_ALREADY_REGISTERED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CLIENT_ALREADY_REGISTERED</unmanaged-short>
        LogClientAlreadyRegistered = unchecked((System.Int32)(6636)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CLIENT_NOT_REGISTERED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CLIENT_NOT_REGISTERED</unmanaged-short>
        LogClientNotRegistered = unchecked((System.Int32)(6637)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_FULL_HANDLER_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_LOG_FULL_HANDLER_IN_PROGRESS</unmanaged-short>
        LogFullHandlerInProgress = unchecked((System.Int32)(6638)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CONTAINER_READ_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CONTAINER_READ_FAILED</unmanaged-short>
        LogContainerReadFailed = unchecked((System.Int32)(6639)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CONTAINER_WRITE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CONTAINER_WRITE_FAILED</unmanaged-short>
        LogContainerWriteFailed = unchecked((System.Int32)(6640)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CONTAINER_OPEN_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CONTAINER_OPEN_FAILED</unmanaged-short>
        LogContainerOpenFailed = unchecked((System.Int32)(6641)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CONTAINER_STATE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CONTAINER_STATE_INVALID</unmanaged-short>
        LogContainerStateInvalid = unchecked((System.Int32)(6642)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_STATE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_LOG_STATE_INVALID</unmanaged-short>
        LogStateInvalid = unchecked((System.Int32)(6643)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_PINNED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_PINNED</unmanaged-short>
        LogPinned = unchecked((System.Int32)(6644)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_METADATA_FLUSH_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_METADATA_FLUSH_FAILED</unmanaged-short>
        LogMetadataFlushFailed = unchecked((System.Int32)(6645)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_INCONSISTENT_SECURITY</unmanaged>
        /// <unmanaged-short>ERROR_LOG_INCONSISTENT_SECURITY</unmanaged-short>
        LogInconsistentSecurity = unchecked((System.Int32)(6646)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_APPENDED_FLUSH_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_APPENDED_FLUSH_FAILED</unmanaged-short>
        LogAppendedFlushFailed = unchecked((System.Int32)(6647)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_PINNED_RESERVATION</unmanaged>
        /// <unmanaged-short>ERROR_LOG_PINNED_RESERVATION</unmanaged-short>
        LogPinnedReservation = unchecked((System.Int32)(6648)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_TRANSACTION</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_TRANSACTION</unmanaged-short>
        InvalidTransaction = unchecked((System.Int32)(6700)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_NOT_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_NOT_ACTIVE</unmanaged-short>
        TransactionNotActive = unchecked((System.Int32)(6701)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_REQUEST_NOT_VALID</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_REQUEST_NOT_VALID</unmanaged-short>
        TransactionRequestNotValid = unchecked((System.Int32)(6702)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_NOT_REQUESTED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_NOT_REQUESTED</unmanaged-short>
        TransactionNotRequested = unchecked((System.Int32)(6703)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_ALREADY_ABORTED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_ALREADY_ABORTED</unmanaged-short>
        TransactionAlreadyAborted = unchecked((System.Int32)(6704)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_ALREADY_COMMITTED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_ALREADY_COMMITTED</unmanaged-short>
        TransactionAlreadyCommitted = unchecked((System.Int32)(6705)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TM_INITIALIZATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_TM_INITIALIZATION_FAILED</unmanaged-short>
        TmInitializationFailed = unchecked((System.Int32)(6706)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCEMANAGER_READ_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCEMANAGER_READ_ONLY</unmanaged-short>
        ResourcemanagerReadOnly = unchecked((System.Int32)(6707)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_NOT_JOINED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_NOT_JOINED</unmanaged-short>
        TransactionNotJoined = unchecked((System.Int32)(6708)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_SUPERIOR_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_SUPERIOR_EXISTS</unmanaged-short>
        TransactionSuperiorExists = unchecked((System.Int32)(6709)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CRM_PROTOCOL_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_CRM_PROTOCOL_ALREADY_EXISTS</unmanaged-short>
        CrmProtocolAlreadyExists = unchecked((System.Int32)(6710)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_PROPAGATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_PROPAGATION_FAILED</unmanaged-short>
        TransactionPropagationFailed = unchecked((System.Int32)(6711)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CRM_PROTOCOL_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CRM_PROTOCOL_NOT_FOUND</unmanaged-short>
        CrmProtocolNotFound = unchecked((System.Int32)(6712)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER</unmanaged-short>
        TransactionInvalidMarshallBuffer = unchecked((System.Int32)(6713)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CURRENT_TRANSACTION_NOT_VALID</unmanaged>
        /// <unmanaged-short>ERROR_CURRENT_TRANSACTION_NOT_VALID</unmanaged-short>
        CurrentTransactionNotValid = unchecked((System.Int32)(6714)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_NOT_FOUND</unmanaged-short>
        TransactionNotFound = unchecked((System.Int32)(6715)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCEMANAGER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCEMANAGER_NOT_FOUND</unmanaged-short>
        ResourcemanagerNotFound = unchecked((System.Int32)(6716)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENLISTMENT_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_ENLISTMENT_NOT_FOUND</unmanaged-short>
        EnlistmentNotFound = unchecked((System.Int32)(6717)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTIONMANAGER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTIONMANAGER_NOT_FOUND</unmanaged-short>
        TransactionmanagerNotFound = unchecked((System.Int32)(6718)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTIONMANAGER_NOT_ONLINE</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTIONMANAGER_NOT_ONLINE</unmanaged-short>
        TransactionmanagerNotOnline = unchecked((System.Int32)(6719)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION</unmanaged-short>
        TransactionmanagerRecoveryNameCollision = unchecked((System.Int32)(6720)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_NOT_ROOT</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_NOT_ROOT</unmanaged-short>
        TransactionNotRoot = unchecked((System.Int32)(6721)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_OBJECT_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_OBJECT_EXPIRED</unmanaged-short>
        TransactionObjectExpired = unchecked((System.Int32)(6722)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED</unmanaged-short>
        TransactionResponseNotEnlisted = unchecked((System.Int32)(6723)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_RECORD_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_RECORD_TOO_LONG</unmanaged-short>
        TransactionRecordTooLong = unchecked((System.Int32)(6724)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED</unmanaged-short>
        ImplicitTransactionNotSupported = unchecked((System.Int32)(6725)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_INTEGRITY_VIOLATED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_INTEGRITY_VIOLATED</unmanaged-short>
        TransactionIntegrityViolated = unchecked((System.Int32)(6726)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH</unmanaged-short>
        TransactionmanagerIdentityMismatch = unchecked((System.Int32)(6727)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT</unmanaged>
        /// <unmanaged-short>ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT</unmanaged-short>
        RmCannotBeFrozenForSnapshot = unchecked((System.Int32)(6728)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_MUST_WRITETHROUGH</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_MUST_WRITETHROUGH</unmanaged-short>
        TransactionMustWritethrough = unchecked((System.Int32)(6729)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_NO_SUPERIOR</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_NO_SUPERIOR</unmanaged-short>
        TransactionNoSuperior = unchecked((System.Int32)(6730)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HEURISTIC_DAMAGE_POSSIBLE</unmanaged>
        /// <unmanaged-short>ERROR_HEURISTIC_DAMAGE_POSSIBLE</unmanaged-short>
        HeuristicDamagePossible = unchecked((System.Int32)(6731)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTIONAL_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTIONAL_CONFLICT</unmanaged-short>
        TransactionalConflict = unchecked((System.Int32)(6800)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RM_NOT_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_RM_NOT_ACTIVE</unmanaged-short>
        RmNotActive = unchecked((System.Int32)(6801)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RM_METADATA_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_RM_METADATA_CORRUPT</unmanaged-short>
        RmMetadataCorrupt = unchecked((System.Int32)(6802)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIRECTORY_NOT_RM</unmanaged>
        /// <unmanaged-short>ERROR_DIRECTORY_NOT_RM</unmanaged-short>
        DirectoryNotRm = unchecked((System.Int32)(6803)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE</unmanaged-short>
        TransactionsUnsupportedRemote = unchecked((System.Int32)(6805)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_RESIZE_INVALID_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_LOG_RESIZE_INVALID_SIZE</unmanaged-short>
        LogResizeInvalidSize = unchecked((System.Int32)(6806)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OBJECT_NO_LONGER_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_OBJECT_NO_LONGER_EXISTS</unmanaged-short>
        ObjectNoLongerExists = unchecked((System.Int32)(6807)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STREAM_MINIVERSION_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_STREAM_MINIVERSION_NOT_FOUND</unmanaged-short>
        StreamMiniversionNotFound = unchecked((System.Int32)(6808)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STREAM_MINIVERSION_NOT_VALID</unmanaged>
        /// <unmanaged-short>ERROR_STREAM_MINIVERSION_NOT_VALID</unmanaged-short>
        StreamMiniversionNotValid = unchecked((System.Int32)(6809)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION</unmanaged>
        /// <unmanaged-short>ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION</unmanaged-short>
        MiniversionInaccessibleFromSpecifiedTransaction = unchecked((System.Int32)(6810)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT</unmanaged>
        /// <unmanaged-short>ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT</unmanaged-short>
        CantOpenMiniversionWithModifyIntent = unchecked((System.Int32)(6811)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS</unmanaged>
        /// <unmanaged-short>ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS</unmanaged-short>
        CantCreateMoreStreamMiniversions = unchecked((System.Int32)(6812)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REMOTE_FILE_VERSION_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_REMOTE_FILE_VERSION_MISMATCH</unmanaged-short>
        RemoteFileVersionMismatch = unchecked((System.Int32)(6814)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HANDLE_NO_LONGER_VALID</unmanaged>
        /// <unmanaged-short>ERROR_HANDLE_NO_LONGER_VALID</unmanaged-short>
        HandleNoLongerValid = unchecked((System.Int32)(6815)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_TXF_METADATA</unmanaged>
        /// <unmanaged-short>ERROR_NO_TXF_METADATA</unmanaged-short>
        NoTxfMetadata = unchecked((System.Int32)(6816)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_CORRUPTION_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_CORRUPTION_DETECTED</unmanaged-short>
        LogCorruptionDetected = unchecked((System.Int32)(6817)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_RECOVER_WITH_HANDLE_OPEN</unmanaged>
        /// <unmanaged-short>ERROR_CANT_RECOVER_WITH_HANDLE_OPEN</unmanaged-short>
        CantRecoverWithHandleOpen = unchecked((System.Int32)(6818)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RM_DISCONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_RM_DISCONNECTED</unmanaged-short>
        RmDisconnected = unchecked((System.Int32)(6819)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ENLISTMENT_NOT_SUPERIOR</unmanaged>
        /// <unmanaged-short>ERROR_ENLISTMENT_NOT_SUPERIOR</unmanaged-short>
        EnlistmentNotSuperior = unchecked((System.Int32)(6820)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RECOVERY_NOT_NEEDED</unmanaged>
        /// <unmanaged-short>ERROR_RECOVERY_NOT_NEEDED</unmanaged-short>
        RecoveryNotNeeded = unchecked((System.Int32)(6821)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RM_ALREADY_STARTED</unmanaged>
        /// <unmanaged-short>ERROR_RM_ALREADY_STARTED</unmanaged-short>
        RmAlreadyStarted = unchecked((System.Int32)(6822)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FILE_IDENTITY_NOT_PERSISTENT</unmanaged>
        /// <unmanaged-short>ERROR_FILE_IDENTITY_NOT_PERSISTENT</unmanaged-short>
        FileIdentityNotPersistent = unchecked((System.Int32)(6823)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY</unmanaged>
        /// <unmanaged-short>ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY</unmanaged-short>
        CantBreakTransactionalDependency = unchecked((System.Int32)(6824)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANT_CROSS_RM_BOUNDARY</unmanaged>
        /// <unmanaged-short>ERROR_CANT_CROSS_RM_BOUNDARY</unmanaged-short>
        CantCrossRmBoundary = unchecked((System.Int32)(6825)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TXF_DIR_NOT_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_TXF_DIR_NOT_EMPTY</unmanaged-short>
        TxfDirNotEmpty = unchecked((System.Int32)(6826)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INDOUBT_TRANSACTIONS_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_INDOUBT_TRANSACTIONS_EXIST</unmanaged-short>
        IndoubtTransactionsExist = unchecked((System.Int32)(6827)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TM_VOLATILE</unmanaged>
        /// <unmanaged-short>ERROR_TM_VOLATILE</unmanaged-short>
        TmVolatile = unchecked((System.Int32)(6828)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ROLLBACK_TIMER_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_ROLLBACK_TIMER_EXPIRED</unmanaged-short>
        RollbackTimerExpired = unchecked((System.Int32)(6829)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TXF_ATTRIBUTE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_TXF_ATTRIBUTE_CORRUPT</unmanaged-short>
        TxfAttributeCorrupt = unchecked((System.Int32)(6830)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION</unmanaged>
        /// <unmanaged-short>ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION</unmanaged-short>
        EfsNotAllowedInTransaction = unchecked((System.Int32)(6831)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED</unmanaged-short>
        TransactionalOpenNotAllowed = unchecked((System.Int32)(6832)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_LOG_GROWTH_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_LOG_GROWTH_FAILED</unmanaged-short>
        LogGrowthFailed = unchecked((System.Int32)(6833)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE</unmanaged-short>
        TransactedMappingUnsupportedRemote = unchecked((System.Int32)(6834)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TXF_METADATA_ALREADY_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_TXF_METADATA_ALREADY_PRESENT</unmanaged-short>
        TxfMetadataAlreadyPresent = unchecked((System.Int32)(6835)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET</unmanaged-short>
        TransactionScopeCallbacksNotSet = unchecked((System.Int32)(6836)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_REQUIRED_PROMOTION</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_REQUIRED_PROMOTION</unmanaged-short>
        TransactionRequiredPromotion = unchecked((System.Int32)(6837)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION</unmanaged-short>
        CannotExecuteFileInTransaction = unchecked((System.Int32)(6838)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTIONS_NOT_FROZEN</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTIONS_NOT_FROZEN</unmanaged-short>
        TransactionsNotFrozen = unchecked((System.Int32)(6839)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_FREEZE_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_FREEZE_IN_PROGRESS</unmanaged-short>
        TransactionFreezeInProgress = unchecked((System.Int32)(6840)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SNAPSHOT_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SNAPSHOT_VOLUME</unmanaged-short>
        NotSnapshotVolume = unchecked((System.Int32)(6841)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SAVEPOINT_WITH_OPEN_FILES</unmanaged>
        /// <unmanaged-short>ERROR_NO_SAVEPOINT_WITH_OPEN_FILES</unmanaged-short>
        NoSavepointWithOpenFiles = unchecked((System.Int32)(6842)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DATA_LOST_REPAIR</unmanaged>
        /// <unmanaged-short>ERROR_DATA_LOST_REPAIR</unmanaged-short>
        DataLostRepair = unchecked((System.Int32)(6843)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION</unmanaged>
        /// <unmanaged-short>ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION</unmanaged-short>
        SparseNotAllowedInTransaction = unchecked((System.Int32)(6844)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TM_IDENTITY_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_TM_IDENTITY_MISMATCH</unmanaged-short>
        TmIdentityMismatch = unchecked((System.Int32)(6845)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLOATED_SECTION</unmanaged>
        /// <unmanaged-short>ERROR_FLOATED_SECTION</unmanaged-short>
        FloatedSection = unchecked((System.Int32)(6846)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_ACCEPT_TRANSACTED_WORK</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_ACCEPT_TRANSACTED_WORK</unmanaged-short>
        CannotAcceptTransactedWork = unchecked((System.Int32)(6847)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_ABORT_TRANSACTIONS</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_ABORT_TRANSACTIONS</unmanaged-short>
        CannotAbortTransactions = unchecked((System.Int32)(6848)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BAD_CLUSTERS</unmanaged>
        /// <unmanaged-short>ERROR_BAD_CLUSTERS</unmanaged-short>
        BadClusters = unchecked((System.Int32)(6849)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION</unmanaged>
        /// <unmanaged-short>ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION</unmanaged-short>
        CompressionNotAllowedInTransaction = unchecked((System.Int32)(6850)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLUME_DIRTY</unmanaged>
        /// <unmanaged-short>ERROR_VOLUME_DIRTY</unmanaged-short>
        VolumeDirty = unchecked((System.Int32)(6851)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_LINK_TRACKING_IN_TRANSACTION</unmanaged>
        /// <unmanaged-short>ERROR_NO_LINK_TRACKING_IN_TRANSACTION</unmanaged-short>
        NoLinkTrackingInTransaction = unchecked((System.Int32)(6852)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION</unmanaged>
        /// <unmanaged-short>ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION</unmanaged-short>
        OperationNotSupportedInTransaction = unchecked((System.Int32)(6853)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EXPIRED_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_EXPIRED_HANDLE</unmanaged-short>
        ExpiredHandle = unchecked((System.Int32)(6854)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TRANSACTION_NOT_ENLISTED</unmanaged>
        /// <unmanaged-short>ERROR_TRANSACTION_NOT_ENLISTED</unmanaged-short>
        TransactionNotEnlisted = unchecked((System.Int32)(6855)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_WINSTATION_NAME_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_CTX_WINSTATION_NAME_INVALID</unmanaged-short>
        CtxWinstationNameInvalid = unchecked((System.Int32)(7001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_INVALID_PD</unmanaged>
        /// <unmanaged-short>ERROR_CTX_INVALID_PD</unmanaged-short>
        CtxInvalidPd = unchecked((System.Int32)(7002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_PD_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CTX_PD_NOT_FOUND</unmanaged-short>
        CtxPdNotFound = unchecked((System.Int32)(7003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_WD_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CTX_WD_NOT_FOUND</unmanaged-short>
        CtxWdNotFound = unchecked((System.Int32)(7004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY</unmanaged-short>
        CtxCannotMakeEventlogEntry = unchecked((System.Int32)(7005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_SERVICE_NAME_COLLISION</unmanaged>
        /// <unmanaged-short>ERROR_CTX_SERVICE_NAME_COLLISION</unmanaged-short>
        CtxServiceNameCollision = unchecked((System.Int32)(7006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CLOSE_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CLOSE_PENDING</unmanaged-short>
        CtxClosePending = unchecked((System.Int32)(7007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_NO_OUTBUF</unmanaged>
        /// <unmanaged-short>ERROR_CTX_NO_OUTBUF</unmanaged-short>
        CtxNoOutbuf = unchecked((System.Int32)(7008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_MODEM_INF_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CTX_MODEM_INF_NOT_FOUND</unmanaged-short>
        CtxModemInfNotFound = unchecked((System.Int32)(7009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_INVALID_MODEMNAME</unmanaged>
        /// <unmanaged-short>ERROR_CTX_INVALID_MODEMNAME</unmanaged-short>
        CtxInvalidModemname = unchecked((System.Int32)(7010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_MODEM_RESPONSE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_CTX_MODEM_RESPONSE_ERROR</unmanaged-short>
        CtxModemResponseError = unchecked((System.Int32)(7011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_MODEM_RESPONSE_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_CTX_MODEM_RESPONSE_TIMEOUT</unmanaged-short>
        CtxModemResponseTimeout = unchecked((System.Int32)(7012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_MODEM_RESPONSE_NO_CARRIER</unmanaged>
        /// <unmanaged-short>ERROR_CTX_MODEM_RESPONSE_NO_CARRIER</unmanaged-short>
        CtxModemResponseNoCarrier = unchecked((System.Int32)(7013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE</unmanaged>
        /// <unmanaged-short>ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE</unmanaged-short>
        CtxModemResponseNoDialtone = unchecked((System.Int32)(7014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_MODEM_RESPONSE_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_CTX_MODEM_RESPONSE_BUSY</unmanaged-short>
        CtxModemResponseBusy = unchecked((System.Int32)(7015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_MODEM_RESPONSE_VOICE</unmanaged>
        /// <unmanaged-short>ERROR_CTX_MODEM_RESPONSE_VOICE</unmanaged-short>
        CtxModemResponseVoice = unchecked((System.Int32)(7016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_TD_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_CTX_TD_ERROR</unmanaged-short>
        CtxTdError = unchecked((System.Int32)(7017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_WINSTATION_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CTX_WINSTATION_NOT_FOUND</unmanaged-short>
        CtxWinstationNotFound = unchecked((System.Int32)(7022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_WINSTATION_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_CTX_WINSTATION_ALREADY_EXISTS</unmanaged-short>
        CtxWinstationAlreadyExists = unchecked((System.Int32)(7023)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_WINSTATION_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_CTX_WINSTATION_BUSY</unmanaged-short>
        CtxWinstationBusy = unchecked((System.Int32)(7024)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_BAD_VIDEO_MODE</unmanaged>
        /// <unmanaged-short>ERROR_CTX_BAD_VIDEO_MODE</unmanaged-short>
        CtxBadVideoMode = unchecked((System.Int32)(7025)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_GRAPHICS_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_CTX_GRAPHICS_INVALID</unmanaged-short>
        CtxGraphicsInvalid = unchecked((System.Int32)(7035)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_LOGON_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_CTX_LOGON_DISABLED</unmanaged-short>
        CtxLogonDisabled = unchecked((System.Int32)(7037)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_NOT_CONSOLE</unmanaged>
        /// <unmanaged-short>ERROR_CTX_NOT_CONSOLE</unmanaged-short>
        CtxNotConsole = unchecked((System.Int32)(7038)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CLIENT_QUERY_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CLIENT_QUERY_TIMEOUT</unmanaged-short>
        CtxClientQueryTimeout = unchecked((System.Int32)(7040)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CONSOLE_DISCONNECT</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CONSOLE_DISCONNECT</unmanaged-short>
        CtxConsoleDisconnect = unchecked((System.Int32)(7041)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CONSOLE_CONNECT</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CONSOLE_CONNECT</unmanaged-short>
        CtxConsoleConnect = unchecked((System.Int32)(7042)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_SHADOW_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_CTX_SHADOW_DENIED</unmanaged-short>
        CtxShadowDenied = unchecked((System.Int32)(7044)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_WINSTATION_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_CTX_WINSTATION_ACCESS_DENIED</unmanaged-short>
        CtxWinstationAccessDenied = unchecked((System.Int32)(7045)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_INVALID_WD</unmanaged>
        /// <unmanaged-short>ERROR_CTX_INVALID_WD</unmanaged-short>
        CtxInvalidWd = unchecked((System.Int32)(7049)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_SHADOW_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_CTX_SHADOW_INVALID</unmanaged-short>
        CtxShadowInvalid = unchecked((System.Int32)(7050)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_SHADOW_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_CTX_SHADOW_DISABLED</unmanaged-short>
        CtxShadowDisabled = unchecked((System.Int32)(7051)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CLIENT_LICENSE_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CLIENT_LICENSE_IN_USE</unmanaged-short>
        CtxClientLicenseInUse = unchecked((System.Int32)(7052)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CLIENT_LICENSE_NOT_SET</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CLIENT_LICENSE_NOT_SET</unmanaged-short>
        CtxClientLicenseNotSet = unchecked((System.Int32)(7053)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_LICENSE_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_CTX_LICENSE_NOT_AVAILABLE</unmanaged-short>
        CtxLicenseNotAvailable = unchecked((System.Int32)(7054)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_LICENSE_CLIENT_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_CTX_LICENSE_CLIENT_INVALID</unmanaged-short>
        CtxLicenseClientInvalid = unchecked((System.Int32)(7055)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_LICENSE_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_CTX_LICENSE_EXPIRED</unmanaged-short>
        CtxLicenseExpired = unchecked((System.Int32)(7056)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_SHADOW_NOT_RUNNING</unmanaged>
        /// <unmanaged-short>ERROR_CTX_SHADOW_NOT_RUNNING</unmanaged-short>
        CtxShadowNotRunning = unchecked((System.Int32)(7057)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE</unmanaged>
        /// <unmanaged-short>ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE</unmanaged-short>
        CtxShadowEndedByModeChange = unchecked((System.Int32)(7058)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ACTIVATION_COUNT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_ACTIVATION_COUNT_EXCEEDED</unmanaged-short>
        ActivationCountExceeded = unchecked((System.Int32)(7059)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_WINSTATIONS_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_CTX_WINSTATIONS_DISABLED</unmanaged-short>
        CtxWinstationsDisabled = unchecked((System.Int32)(7060)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED</unmanaged-short>
        CtxEncryptionLevelRequired = unchecked((System.Int32)(7061)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_SESSION_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_CTX_SESSION_IN_USE</unmanaged-short>
        CtxSessionInUse = unchecked((System.Int32)(7062)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_NO_FORCE_LOGOFF</unmanaged>
        /// <unmanaged-short>ERROR_CTX_NO_FORCE_LOGOFF</unmanaged-short>
        CtxNoForceLogoff = unchecked((System.Int32)(7063)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_ACCOUNT_RESTRICTION</unmanaged>
        /// <unmanaged-short>ERROR_CTX_ACCOUNT_RESTRICTION</unmanaged-short>
        CtxAccountRestriction = unchecked((System.Int32)(7064)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RDP_PROTOCOL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_RDP_PROTOCOL_ERROR</unmanaged-short>
        RdpProtocolError = unchecked((System.Int32)(7065)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CDM_CONNECT</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CDM_CONNECT</unmanaged-short>
        CtxCdmConnect = unchecked((System.Int32)(7066)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_CDM_DISCONNECT</unmanaged>
        /// <unmanaged-short>ERROR_CTX_CDM_DISCONNECT</unmanaged-short>
        CtxCdmDisconnect = unchecked((System.Int32)(7067)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTX_SECURITY_LAYER_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_CTX_SECURITY_LAYER_ERROR</unmanaged-short>
        CtxSecurityLayerError = unchecked((System.Int32)(7068)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TS_INCOMPATIBLE_SESSIONS</unmanaged>
        /// <unmanaged-short>ERROR_TS_INCOMPATIBLE_SESSIONS</unmanaged-short>
        TsIncompatibleSessions = unchecked((System.Int32)(7069)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TS_VIDEO_SUBSYSTEM_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_TS_VIDEO_SUBSYSTEM_ERROR</unmanaged-short>
        TsVideoSubsystemError = unchecked((System.Int32)(7070)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_DS_NOT_INSTALLED</unmanaged-short>
        DsNotInstalled = unchecked((System.Int32)(8200)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY</unmanaged>
        /// <unmanaged-short>ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY</unmanaged-short>
        DsMembershipEvaluatedLocally = unchecked((System.Int32)(8201)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_ATTRIBUTE_OR_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_ATTRIBUTE_OR_VALUE</unmanaged-short>
        DsNoAttributeOrValue = unchecked((System.Int32)(8202)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_ATTRIBUTE_SYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_ATTRIBUTE_SYNTAX</unmanaged-short>
        DsInvalidAttributeSyntax = unchecked((System.Int32)(8203)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED</unmanaged-short>
        DsAttributeTypeUndefined = unchecked((System.Int32)(8204)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS</unmanaged-short>
        DsAttributeOrValueExists = unchecked((System.Int32)(8205)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_DS_BUSY</unmanaged-short>
        DsBusy = unchecked((System.Int32)(8206)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNAVAILABLE</unmanaged-short>
        DsUnavailable = unchecked((System.Int32)(8207)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_RIDS_ALLOCATED</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_RIDS_ALLOCATED</unmanaged-short>
        DsNoRidsAllocated = unchecked((System.Int32)(8208)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_MORE_RIDS</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_MORE_RIDS</unmanaged-short>
        DsNoMoreRids = unchecked((System.Int32)(8209)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INCORRECT_ROLE_OWNER</unmanaged>
        /// <unmanaged-short>ERROR_DS_INCORRECT_ROLE_OWNER</unmanaged-short>
        DsIncorrectRoleOwner = unchecked((System.Int32)(8210)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_RIDMGR_INIT_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_RIDMGR_INIT_ERROR</unmanaged-short>
        DsRidmgrInitError = unchecked((System.Int32)(8211)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJ_CLASS_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJ_CLASS_VIOLATION</unmanaged-short>
        DsObjClassViolation = unchecked((System.Int32)(8212)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_ON_NON_LEAF</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_ON_NON_LEAF</unmanaged-short>
        DsCantOnNonLeaf = unchecked((System.Int32)(8213)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_ON_RDN</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_ON_RDN</unmanaged-short>
        DsCantOnRdn = unchecked((System.Int32)(8214)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MOD_OBJ_CLASS</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MOD_OBJ_CLASS</unmanaged-short>
        DsCantModObjClass = unchecked((System.Int32)(8215)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CROSS_DOM_MOVE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_CROSS_DOM_MOVE_ERROR</unmanaged-short>
        DsCrossDomMoveError = unchecked((System.Int32)(8216)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GC_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_DS_GC_NOT_AVAILABLE</unmanaged-short>
        DsGcNotAvailable = unchecked((System.Int32)(8217)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SHARED_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_SHARED_POLICY</unmanaged-short>
        SharedPolicy = unchecked((System.Int32)(8218)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_POLICY_OBJECT_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_POLICY_OBJECT_NOT_FOUND</unmanaged-short>
        PolicyObjectNotFound = unchecked((System.Int32)(8219)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_POLICY_ONLY_IN_DS</unmanaged>
        /// <unmanaged-short>ERROR_POLICY_ONLY_IN_DS</unmanaged-short>
        PolicyOnlyInDs = unchecked((System.Int32)(8220)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROMOTION_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_PROMOTION_ACTIVE</unmanaged-short>
        PromotionActive = unchecked((System.Int32)(8221)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_PROMOTION_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_NO_PROMOTION_ACTIVE</unmanaged-short>
        NoPromotionActive = unchecked((System.Int32)(8222)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OPERATIONS_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_OPERATIONS_ERROR</unmanaged-short>
        DsOperationsError = unchecked((System.Int32)(8224)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_PROTOCOL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_PROTOCOL_ERROR</unmanaged-short>
        DsProtocolError = unchecked((System.Int32)(8225)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_TIMELIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DS_TIMELIMIT_EXCEEDED</unmanaged-short>
        DsTimelimitExceeded = unchecked((System.Int32)(8226)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SIZELIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DS_SIZELIMIT_EXCEEDED</unmanaged-short>
        DsSizelimitExceeded = unchecked((System.Int32)(8227)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ADMIN_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DS_ADMIN_LIMIT_EXCEEDED</unmanaged-short>
        DsAdminLimitExceeded = unchecked((System.Int32)(8228)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_COMPARE_FALSE</unmanaged>
        /// <unmanaged-short>ERROR_DS_COMPARE_FALSE</unmanaged-short>
        DsCompareFalse = unchecked((System.Int32)(8229)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_COMPARE_TRUE</unmanaged>
        /// <unmanaged-short>ERROR_DS_COMPARE_TRUE</unmanaged-short>
        DsCompareTrue = unchecked((System.Int32)(8230)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_AUTH_METHOD_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_DS_AUTH_METHOD_NOT_SUPPORTED</unmanaged-short>
        DsAuthMethodNotSupported = unchecked((System.Int32)(8231)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_STRONG_AUTH_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_DS_STRONG_AUTH_REQUIRED</unmanaged-short>
        DsStrongAuthRequired = unchecked((System.Int32)(8232)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INAPPROPRIATE_AUTH</unmanaged>
        /// <unmanaged-short>ERROR_DS_INAPPROPRIATE_AUTH</unmanaged-short>
        DsInappropriateAuth = unchecked((System.Int32)(8233)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_AUTH_UNKNOWN</unmanaged>
        /// <unmanaged-short>ERROR_DS_AUTH_UNKNOWN</unmanaged-short>
        DsAuthUnknown = unchecked((System.Int32)(8234)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_REFERRAL</unmanaged>
        /// <unmanaged-short>ERROR_DS_REFERRAL</unmanaged-short>
        DsReferral = unchecked((System.Int32)(8235)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNAVAILABLE_CRIT_EXTENSION</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNAVAILABLE_CRIT_EXTENSION</unmanaged-short>
        DsUnavailableCritExtension = unchecked((System.Int32)(8236)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CONFIDENTIALITY_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_DS_CONFIDENTIALITY_REQUIRED</unmanaged-short>
        DsConfidentialityRequired = unchecked((System.Int32)(8237)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INAPPROPRIATE_MATCHING</unmanaged>
        /// <unmanaged-short>ERROR_DS_INAPPROPRIATE_MATCHING</unmanaged-short>
        DsInappropriateMatching = unchecked((System.Int32)(8238)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CONSTRAINT_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_DS_CONSTRAINT_VIOLATION</unmanaged-short>
        DsConstraintViolation = unchecked((System.Int32)(8239)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_SUCH_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_SUCH_OBJECT</unmanaged-short>
        DsNoSuchObject = unchecked((System.Int32)(8240)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ALIAS_PROBLEM</unmanaged>
        /// <unmanaged-short>ERROR_DS_ALIAS_PROBLEM</unmanaged-short>
        DsAliasProblem = unchecked((System.Int32)(8241)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_DN_SYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_DN_SYNTAX</unmanaged-short>
        DsInvalidDnSyntax = unchecked((System.Int32)(8242)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_IS_LEAF</unmanaged>
        /// <unmanaged-short>ERROR_DS_IS_LEAF</unmanaged-short>
        DsIsLeaf = unchecked((System.Int32)(8243)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ALIAS_DEREF_PROBLEM</unmanaged>
        /// <unmanaged-short>ERROR_DS_ALIAS_DEREF_PROBLEM</unmanaged-short>
        DsAliasDerefProblem = unchecked((System.Int32)(8244)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNWILLING_TO_PERFORM</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNWILLING_TO_PERFORM</unmanaged-short>
        DsUnwillingToPerform = unchecked((System.Int32)(8245)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_LOOP_DETECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_LOOP_DETECT</unmanaged-short>
        DsLoopDetect = unchecked((System.Int32)(8246)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAMING_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAMING_VIOLATION</unmanaged-short>
        DsNamingViolation = unchecked((System.Int32)(8247)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJECT_RESULTS_TOO_LARGE</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJECT_RESULTS_TOO_LARGE</unmanaged-short>
        DsObjectResultsTooLarge = unchecked((System.Int32)(8248)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_AFFECTS_MULTIPLE_DSAS</unmanaged>
        /// <unmanaged-short>ERROR_DS_AFFECTS_MULTIPLE_DSAS</unmanaged-short>
        DsAffectsMultipleDsas = unchecked((System.Int32)(8249)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SERVER_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_DS_SERVER_DOWN</unmanaged-short>
        DsServerDown = unchecked((System.Int32)(8250)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_LOCAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_LOCAL_ERROR</unmanaged-short>
        DsLocalError = unchecked((System.Int32)(8251)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ENCODING_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_ENCODING_ERROR</unmanaged-short>
        DsEncodingError = unchecked((System.Int32)(8252)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DECODING_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_DECODING_ERROR</unmanaged-short>
        DsDecodingError = unchecked((System.Int32)(8253)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_FILTER_UNKNOWN</unmanaged>
        /// <unmanaged-short>ERROR_DS_FILTER_UNKNOWN</unmanaged-short>
        DsFilterUnknown = unchecked((System.Int32)(8254)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_PARAM_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_PARAM_ERROR</unmanaged-short>
        DsParamError = unchecked((System.Int32)(8255)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_DS_NOT_SUPPORTED</unmanaged-short>
        DsNotSupported = unchecked((System.Int32)(8256)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_RESULTS_RETURNED</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_RESULTS_RETURNED</unmanaged-short>
        DsNoResultsReturned = unchecked((System.Int32)(8257)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CONTROL_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DS_CONTROL_NOT_FOUND</unmanaged-short>
        DsControlNotFound = unchecked((System.Int32)(8258)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CLIENT_LOOP</unmanaged>
        /// <unmanaged-short>ERROR_DS_CLIENT_LOOP</unmanaged-short>
        DsClientLoop = unchecked((System.Int32)(8259)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_REFERRAL_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DS_REFERRAL_LIMIT_EXCEEDED</unmanaged-short>
        DsReferralLimitExceeded = unchecked((System.Int32)(8260)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SORT_CONTROL_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_DS_SORT_CONTROL_MISSING</unmanaged-short>
        DsSortControlMissing = unchecked((System.Int32)(8261)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OFFSET_RANGE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_OFFSET_RANGE_ERROR</unmanaged-short>
        DsOffsetRangeError = unchecked((System.Int32)(8262)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_RIDMGR_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_DS_RIDMGR_DISABLED</unmanaged-short>
        DsRidmgrDisabled = unchecked((System.Int32)(8263)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ROOT_MUST_BE_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_ROOT_MUST_BE_NC</unmanaged-short>
        DsRootMustBeNc = unchecked((System.Int32)(8301)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ADD_REPLICA_INHIBITED</unmanaged>
        /// <unmanaged-short>ERROR_DS_ADD_REPLICA_INHIBITED</unmanaged-short>
        DsAddReplicaInhibited = unchecked((System.Int32)(8302)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATT_NOT_DEF_IN_SCHEMA</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATT_NOT_DEF_IN_SCHEMA</unmanaged-short>
        DsAttNotDefInSchema = unchecked((System.Int32)(8303)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MAX_OBJ_SIZE_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DS_MAX_OBJ_SIZE_EXCEEDED</unmanaged-short>
        DsMaxObjSizeExceeded = unchecked((System.Int32)(8304)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJ_STRING_NAME_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJ_STRING_NAME_EXISTS</unmanaged-short>
        DsObjStringNameExists = unchecked((System.Int32)(8305)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA</unmanaged-short>
        DsNoRdnDefinedInSchema = unchecked((System.Int32)(8306)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_RDN_DOESNT_MATCH_SCHEMA</unmanaged>
        /// <unmanaged-short>ERROR_DS_RDN_DOESNT_MATCH_SCHEMA</unmanaged-short>
        DsRdnDoesntMatchSchema = unchecked((System.Int32)(8307)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_REQUESTED_ATTS_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_REQUESTED_ATTS_FOUND</unmanaged-short>
        DsNoRequestedAttsFound = unchecked((System.Int32)(8308)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_USER_BUFFER_TO_SMALL</unmanaged>
        /// <unmanaged-short>ERROR_DS_USER_BUFFER_TO_SMALL</unmanaged-short>
        DsUserBufferToSmall = unchecked((System.Int32)(8309)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATT_IS_NOT_ON_OBJ</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATT_IS_NOT_ON_OBJ</unmanaged-short>
        DsAttIsNotOnObj = unchecked((System.Int32)(8310)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ILLEGAL_MOD_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_DS_ILLEGAL_MOD_OPERATION</unmanaged-short>
        DsIllegalModOperation = unchecked((System.Int32)(8311)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJ_TOO_LARGE</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJ_TOO_LARGE</unmanaged-short>
        DsObjTooLarge = unchecked((System.Int32)(8312)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_BAD_INSTANCE_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_DS_BAD_INSTANCE_TYPE</unmanaged-short>
        DsBadInstanceType = unchecked((System.Int32)(8313)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MASTERDSA_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_DS_MASTERDSA_REQUIRED</unmanaged-short>
        DsMasterdsaRequired = unchecked((System.Int32)(8314)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJECT_CLASS_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJECT_CLASS_REQUIRED</unmanaged-short>
        DsObjectClassRequired = unchecked((System.Int32)(8315)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MISSING_REQUIRED_ATT</unmanaged>
        /// <unmanaged-short>ERROR_DS_MISSING_REQUIRED_ATT</unmanaged-short>
        DsMissingRequiredAtt = unchecked((System.Int32)(8316)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATT_NOT_DEF_FOR_CLASS</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATT_NOT_DEF_FOR_CLASS</unmanaged-short>
        DsAttNotDefForClass = unchecked((System.Int32)(8317)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATT_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATT_ALREADY_EXISTS</unmanaged-short>
        DsAttAlreadyExists = unchecked((System.Int32)(8318)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_ADD_ATT_VALUES</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_ADD_ATT_VALUES</unmanaged-short>
        DsCantAddAttValues = unchecked((System.Int32)(8320)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SINGLE_VALUE_CONSTRAINT</unmanaged>
        /// <unmanaged-short>ERROR_DS_SINGLE_VALUE_CONSTRAINT</unmanaged-short>
        DsSingleValueConstraint = unchecked((System.Int32)(8321)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_RANGE_CONSTRAINT</unmanaged>
        /// <unmanaged-short>ERROR_DS_RANGE_CONSTRAINT</unmanaged-short>
        DsRangeConstraint = unchecked((System.Int32)(8322)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATT_VAL_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATT_VAL_ALREADY_EXISTS</unmanaged-short>
        DsAttValAlreadyExists = unchecked((System.Int32)(8323)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_REM_MISSING_ATT</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_REM_MISSING_ATT</unmanaged-short>
        DsCantRemMissingAtt = unchecked((System.Int32)(8324)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_REM_MISSING_ATT_VAL</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_REM_MISSING_ATT_VAL</unmanaged-short>
        DsCantRemMissingAttVal = unchecked((System.Int32)(8325)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ROOT_CANT_BE_SUBREF</unmanaged>
        /// <unmanaged-short>ERROR_DS_ROOT_CANT_BE_SUBREF</unmanaged-short>
        DsRootCantBeSubref = unchecked((System.Int32)(8326)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_CHAINING</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_CHAINING</unmanaged-short>
        DsNoChaining = unchecked((System.Int32)(8327)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_CHAINED_EVAL</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_CHAINED_EVAL</unmanaged-short>
        DsNoChainedEval = unchecked((System.Int32)(8328)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_PARENT_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_PARENT_OBJECT</unmanaged-short>
        DsNoParentObject = unchecked((System.Int32)(8329)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_PARENT_IS_AN_ALIAS</unmanaged>
        /// <unmanaged-short>ERROR_DS_PARENT_IS_AN_ALIAS</unmanaged-short>
        DsParentIsAnAlias = unchecked((System.Int32)(8330)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MIX_MASTER_AND_REPS</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MIX_MASTER_AND_REPS</unmanaged-short>
        DsCantMixMasterAndReps = unchecked((System.Int32)(8331)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CHILDREN_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_DS_CHILDREN_EXIST</unmanaged-short>
        DsChildrenExist = unchecked((System.Int32)(8332)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJ_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJ_NOT_FOUND</unmanaged-short>
        DsObjNotFound = unchecked((System.Int32)(8333)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ALIASED_OBJ_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_DS_ALIASED_OBJ_MISSING</unmanaged-short>
        DsAliasedObjMissing = unchecked((System.Int32)(8334)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_BAD_NAME_SYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_DS_BAD_NAME_SYNTAX</unmanaged-short>
        DsBadNameSyntax = unchecked((System.Int32)(8335)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ALIAS_POINTS_TO_ALIAS</unmanaged>
        /// <unmanaged-short>ERROR_DS_ALIAS_POINTS_TO_ALIAS</unmanaged-short>
        DsAliasPointsToAlias = unchecked((System.Int32)(8336)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_DEREF_ALIAS</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_DEREF_ALIAS</unmanaged-short>
        DsCantDerefAlias = unchecked((System.Int32)(8337)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OUT_OF_SCOPE</unmanaged>
        /// <unmanaged-short>ERROR_DS_OUT_OF_SCOPE</unmanaged-short>
        DsOutOfScope = unchecked((System.Int32)(8338)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJECT_BEING_REMOVED</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJECT_BEING_REMOVED</unmanaged-short>
        DsObjectBeingRemoved = unchecked((System.Int32)(8339)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_DELETE_DSA_OBJ</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_DELETE_DSA_OBJ</unmanaged-short>
        DsCantDeleteDsaObj = unchecked((System.Int32)(8340)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GENERIC_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_GENERIC_ERROR</unmanaged-short>
        DsGenericError = unchecked((System.Int32)(8341)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DSA_MUST_BE_INT_MASTER</unmanaged>
        /// <unmanaged-short>ERROR_DS_DSA_MUST_BE_INT_MASTER</unmanaged-short>
        DsDsaMustBeIntMaster = unchecked((System.Int32)(8342)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CLASS_NOT_DSA</unmanaged>
        /// <unmanaged-short>ERROR_DS_CLASS_NOT_DSA</unmanaged-short>
        DsClassNotDsa = unchecked((System.Int32)(8343)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INSUFF_ACCESS_RIGHTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_INSUFF_ACCESS_RIGHTS</unmanaged-short>
        DsInsuffAccessRights = unchecked((System.Int32)(8344)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ILLEGAL_SUPERIOR</unmanaged>
        /// <unmanaged-short>ERROR_DS_ILLEGAL_SUPERIOR</unmanaged-short>
        DsIllegalSuperior = unchecked((System.Int32)(8345)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATTRIBUTE_OWNED_BY_SAM</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATTRIBUTE_OWNED_BY_SAM</unmanaged-short>
        DsAttributeOwnedBySam = unchecked((System.Int32)(8346)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_TOO_MANY_PARTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_TOO_MANY_PARTS</unmanaged-short>
        DsNameTooManyParts = unchecked((System.Int32)(8347)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_TOO_LONG</unmanaged-short>
        DsNameTooLong = unchecked((System.Int32)(8348)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_VALUE_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_VALUE_TOO_LONG</unmanaged-short>
        DsNameValueTooLong = unchecked((System.Int32)(8349)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_UNPARSEABLE</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_UNPARSEABLE</unmanaged-short>
        DsNameUnparseable = unchecked((System.Int32)(8350)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_TYPE_UNKNOWN</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_TYPE_UNKNOWN</unmanaged-short>
        DsNameTypeUnknown = unchecked((System.Int32)(8351)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NOT_AN_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_NOT_AN_OBJECT</unmanaged-short>
        DsNotAnObject = unchecked((System.Int32)(8352)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SEC_DESC_TOO_SHORT</unmanaged>
        /// <unmanaged-short>ERROR_DS_SEC_DESC_TOO_SHORT</unmanaged-short>
        DsSecDescTooShort = unchecked((System.Int32)(8353)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SEC_DESC_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_DS_SEC_DESC_INVALID</unmanaged-short>
        DsSecDescInvalid = unchecked((System.Int32)(8354)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_DELETED_NAME</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_DELETED_NAME</unmanaged-short>
        DsNoDeletedName = unchecked((System.Int32)(8355)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SUBREF_MUST_HAVE_PARENT</unmanaged>
        /// <unmanaged-short>ERROR_DS_SUBREF_MUST_HAVE_PARENT</unmanaged-short>
        DsSubrefMustHaveParent = unchecked((System.Int32)(8356)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NCNAME_MUST_BE_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_NCNAME_MUST_BE_NC</unmanaged-short>
        DsNcnameMustBeNc = unchecked((System.Int32)(8357)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_ADD_SYSTEM_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_ADD_SYSTEM_ONLY</unmanaged-short>
        DsCantAddSystemOnly = unchecked((System.Int32)(8358)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CLASS_MUST_BE_CONCRETE</unmanaged>
        /// <unmanaged-short>ERROR_DS_CLASS_MUST_BE_CONCRETE</unmanaged-short>
        DsClassMustBeConcrete = unchecked((System.Int32)(8359)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_DMD</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_DMD</unmanaged-short>
        DsInvalidDmd = unchecked((System.Int32)(8360)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJ_GUID_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJ_GUID_EXISTS</unmanaged-short>
        DsObjGuidExists = unchecked((System.Int32)(8361)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NOT_ON_BACKLINK</unmanaged>
        /// <unmanaged-short>ERROR_DS_NOT_ON_BACKLINK</unmanaged-short>
        DsNotOnBacklink = unchecked((System.Int32)(8362)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_CROSSREF_FOR_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_CROSSREF_FOR_NC</unmanaged-short>
        DsNoCrossrefForNc = unchecked((System.Int32)(8363)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SHUTTING_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_DS_SHUTTING_DOWN</unmanaged-short>
        DsShuttingDown = unchecked((System.Int32)(8364)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNKNOWN_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNKNOWN_OPERATION</unmanaged-short>
        DsUnknownOperation = unchecked((System.Int32)(8365)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_ROLE_OWNER</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_ROLE_OWNER</unmanaged-short>
        DsInvalidRoleOwner = unchecked((System.Int32)(8366)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_COULDNT_CONTACT_FSMO</unmanaged>
        /// <unmanaged-short>ERROR_DS_COULDNT_CONTACT_FSMO</unmanaged-short>
        DsCouldntContactFsmo = unchecked((System.Int32)(8367)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CROSS_NC_DN_RENAME</unmanaged>
        /// <unmanaged-short>ERROR_DS_CROSS_NC_DN_RENAME</unmanaged-short>
        DsCrossNcDnRename = unchecked((System.Int32)(8368)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MOD_SYSTEM_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MOD_SYSTEM_ONLY</unmanaged-short>
        DsCantModSystemOnly = unchecked((System.Int32)(8369)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_REPLICATOR_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_DS_REPLICATOR_ONLY</unmanaged-short>
        DsReplicatorOnly = unchecked((System.Int32)(8370)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJ_CLASS_NOT_DEFINED</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJ_CLASS_NOT_DEFINED</unmanaged-short>
        DsObjClassNotDefined = unchecked((System.Int32)(8371)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OBJ_CLASS_NOT_SUBCLASS</unmanaged>
        /// <unmanaged-short>ERROR_DS_OBJ_CLASS_NOT_SUBCLASS</unmanaged-short>
        DsObjClassNotSubclass = unchecked((System.Int32)(8372)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_REFERENCE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_REFERENCE_INVALID</unmanaged-short>
        DsNameReferenceInvalid = unchecked((System.Int32)(8373)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CROSS_REF_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_CROSS_REF_EXISTS</unmanaged-short>
        DsCrossRefExists = unchecked((System.Int32)(8374)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_DEL_MASTER_CROSSREF</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_DEL_MASTER_CROSSREF</unmanaged-short>
        DsCantDelMasterCrossref = unchecked((System.Int32)(8375)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD</unmanaged>
        /// <unmanaged-short>ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD</unmanaged-short>
        DsSubtreeNotifyNotNcHead = unchecked((System.Int32)(8376)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX</unmanaged>
        /// <unmanaged-short>ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX</unmanaged-short>
        DsNotifyFilterTooComplex = unchecked((System.Int32)(8377)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DUP_RDN</unmanaged>
        /// <unmanaged-short>ERROR_DS_DUP_RDN</unmanaged-short>
        DsDupRdn = unchecked((System.Int32)(8378)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DUP_OID</unmanaged>
        /// <unmanaged-short>ERROR_DS_DUP_OID</unmanaged-short>
        DsDupOid = unchecked((System.Int32)(8379)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DUP_MAPI_ID</unmanaged>
        /// <unmanaged-short>ERROR_DS_DUP_MAPI_ID</unmanaged-short>
        DsDupMapiId = unchecked((System.Int32)(8380)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DUP_SCHEMA_ID_GUID</unmanaged>
        /// <unmanaged-short>ERROR_DS_DUP_SCHEMA_ID_GUID</unmanaged-short>
        DsDupSchemaIdGuid = unchecked((System.Int32)(8381)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DUP_LDAP_DISPLAY_NAME</unmanaged>
        /// <unmanaged-short>ERROR_DS_DUP_LDAP_DISPLAY_NAME</unmanaged-short>
        DsDupLdapDisplayName = unchecked((System.Int32)(8382)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SEMANTIC_ATT_TEST</unmanaged>
        /// <unmanaged-short>ERROR_DS_SEMANTIC_ATT_TEST</unmanaged-short>
        DsSemanticAttTest = unchecked((System.Int32)(8383)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SYNTAX_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_SYNTAX_MISMATCH</unmanaged-short>
        DsSyntaxMismatch = unchecked((System.Int32)(8384)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_EXISTS_IN_MUST_HAVE</unmanaged>
        /// <unmanaged-short>ERROR_DS_EXISTS_IN_MUST_HAVE</unmanaged-short>
        DsExistsInMustHave = unchecked((System.Int32)(8385)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_EXISTS_IN_MAY_HAVE</unmanaged>
        /// <unmanaged-short>ERROR_DS_EXISTS_IN_MAY_HAVE</unmanaged-short>
        DsExistsInMayHave = unchecked((System.Int32)(8386)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NONEXISTENT_MAY_HAVE</unmanaged>
        /// <unmanaged-short>ERROR_DS_NONEXISTENT_MAY_HAVE</unmanaged-short>
        DsNonexistentMayHave = unchecked((System.Int32)(8387)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NONEXISTENT_MUST_HAVE</unmanaged>
        /// <unmanaged-short>ERROR_DS_NONEXISTENT_MUST_HAVE</unmanaged-short>
        DsNonexistentMustHave = unchecked((System.Int32)(8388)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_AUX_CLS_TEST_FAIL</unmanaged>
        /// <unmanaged-short>ERROR_DS_AUX_CLS_TEST_FAIL</unmanaged-short>
        DsAuxClsTestFail = unchecked((System.Int32)(8389)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NONEXISTENT_POSS_SUP</unmanaged>
        /// <unmanaged-short>ERROR_DS_NONEXISTENT_POSS_SUP</unmanaged-short>
        DsNonexistentPossSup = unchecked((System.Int32)(8390)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SUB_CLS_TEST_FAIL</unmanaged>
        /// <unmanaged-short>ERROR_DS_SUB_CLS_TEST_FAIL</unmanaged-short>
        DsSubClsTestFail = unchecked((System.Int32)(8391)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_BAD_RDN_ATT_ID_SYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_DS_BAD_RDN_ATT_ID_SYNTAX</unmanaged-short>
        DsBadRdnAttIdSyntax = unchecked((System.Int32)(8392)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_EXISTS_IN_AUX_CLS</unmanaged>
        /// <unmanaged-short>ERROR_DS_EXISTS_IN_AUX_CLS</unmanaged-short>
        DsExistsInAuxCls = unchecked((System.Int32)(8393)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_EXISTS_IN_SUB_CLS</unmanaged>
        /// <unmanaged-short>ERROR_DS_EXISTS_IN_SUB_CLS</unmanaged-short>
        DsExistsInSubCls = unchecked((System.Int32)(8394)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_EXISTS_IN_POSS_SUP</unmanaged>
        /// <unmanaged-short>ERROR_DS_EXISTS_IN_POSS_SUP</unmanaged-short>
        DsExistsInPossSup = unchecked((System.Int32)(8395)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_RECALCSCHEMA_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_RECALCSCHEMA_FAILED</unmanaged-short>
        DsRecalcschemaFailed = unchecked((System.Int32)(8396)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_TREE_DELETE_NOT_FINISHED</unmanaged>
        /// <unmanaged-short>ERROR_DS_TREE_DELETE_NOT_FINISHED</unmanaged-short>
        DsTreeDeleteNotFinished = unchecked((System.Int32)(8397)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_DELETE</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_DELETE</unmanaged-short>
        DsCantDelete = unchecked((System.Int32)(8398)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATT_SCHEMA_REQ_ID</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATT_SCHEMA_REQ_ID</unmanaged-short>
        DsAttSchemaReqId = unchecked((System.Int32)(8399)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_BAD_ATT_SCHEMA_SYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_DS_BAD_ATT_SCHEMA_SYNTAX</unmanaged-short>
        DsBadAttSchemaSyntax = unchecked((System.Int32)(8400)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_CACHE_ATT</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_CACHE_ATT</unmanaged-short>
        DsCantCacheAtt = unchecked((System.Int32)(8401)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_CACHE_CLASS</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_CACHE_CLASS</unmanaged-short>
        DsCantCacheClass = unchecked((System.Int32)(8402)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_REMOVE_ATT_CACHE</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_REMOVE_ATT_CACHE</unmanaged-short>
        DsCantRemoveAttCache = unchecked((System.Int32)(8403)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_REMOVE_CLASS_CACHE</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_REMOVE_CLASS_CACHE</unmanaged-short>
        DsCantRemoveClassCache = unchecked((System.Int32)(8404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_RETRIEVE_DN</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_RETRIEVE_DN</unmanaged-short>
        DsCantRetrieveDn = unchecked((System.Int32)(8405)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MISSING_SUPREF</unmanaged>
        /// <unmanaged-short>ERROR_DS_MISSING_SUPREF</unmanaged-short>
        DsMissingSupref = unchecked((System.Int32)(8406)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_RETRIEVE_INSTANCE</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_RETRIEVE_INSTANCE</unmanaged-short>
        DsCantRetrieveInstance = unchecked((System.Int32)(8407)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CODE_INCONSISTENCY</unmanaged>
        /// <unmanaged-short>ERROR_DS_CODE_INCONSISTENCY</unmanaged-short>
        DsCodeInconsistency = unchecked((System.Int32)(8408)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DATABASE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_DATABASE_ERROR</unmanaged-short>
        DsDatabaseError = unchecked((System.Int32)(8409)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GOVERNSID_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_DS_GOVERNSID_MISSING</unmanaged-short>
        DsGovernsidMissing = unchecked((System.Int32)(8410)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MISSING_EXPECTED_ATT</unmanaged>
        /// <unmanaged-short>ERROR_DS_MISSING_EXPECTED_ATT</unmanaged-short>
        DsMissingExpectedAtt = unchecked((System.Int32)(8411)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NCNAME_MISSING_CR_REF</unmanaged>
        /// <unmanaged-short>ERROR_DS_NCNAME_MISSING_CR_REF</unmanaged-short>
        DsNcnameMissingCrRef = unchecked((System.Int32)(8412)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SECURITY_CHECKING_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_SECURITY_CHECKING_ERROR</unmanaged-short>
        DsSecurityCheckingError = unchecked((System.Int32)(8413)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SCHEMA_NOT_LOADED</unmanaged>
        /// <unmanaged-short>ERROR_DS_SCHEMA_NOT_LOADED</unmanaged-short>
        DsSchemaNotLoaded = unchecked((System.Int32)(8414)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SCHEMA_ALLOC_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_SCHEMA_ALLOC_FAILED</unmanaged-short>
        DsSchemaAllocFailed = unchecked((System.Int32)(8415)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ATT_SCHEMA_REQ_SYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_DS_ATT_SCHEMA_REQ_SYNTAX</unmanaged-short>
        DsAttSchemaReqSyntax = unchecked((System.Int32)(8416)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GCVERIFY_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_GCVERIFY_ERROR</unmanaged-short>
        DsGcverifyError = unchecked((System.Int32)(8417)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SCHEMA_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SCHEMA_MISMATCH</unmanaged-short>
        DsDraSchemaMismatch = unchecked((System.Int32)(8418)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_FIND_DSA_OBJ</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_FIND_DSA_OBJ</unmanaged-short>
        DsCantFindDsaObj = unchecked((System.Int32)(8419)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_FIND_EXPECTED_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_FIND_EXPECTED_NC</unmanaged-short>
        DsCantFindExpectedNc = unchecked((System.Int32)(8420)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_FIND_NC_IN_CACHE</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_FIND_NC_IN_CACHE</unmanaged-short>
        DsCantFindNcInCache = unchecked((System.Int32)(8421)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_RETRIEVE_CHILD</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_RETRIEVE_CHILD</unmanaged-short>
        DsCantRetrieveChild = unchecked((System.Int32)(8422)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SECURITY_ILLEGAL_MODIFY</unmanaged>
        /// <unmanaged-short>ERROR_DS_SECURITY_ILLEGAL_MODIFY</unmanaged-short>
        DsSecurityIllegalModify = unchecked((System.Int32)(8423)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_REPLACE_HIDDEN_REC</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_REPLACE_HIDDEN_REC</unmanaged-short>
        DsCantReplaceHiddenRec = unchecked((System.Int32)(8424)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_BAD_HIERARCHY_FILE</unmanaged>
        /// <unmanaged-short>ERROR_DS_BAD_HIERARCHY_FILE</unmanaged-short>
        DsBadHierarchyFile = unchecked((System.Int32)(8425)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED</unmanaged-short>
        DsBuildHierarchyTableFailed = unchecked((System.Int32)(8426)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CONFIG_PARAM_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_DS_CONFIG_PARAM_MISSING</unmanaged-short>
        DsConfigParamMissing = unchecked((System.Int32)(8427)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_COUNTING_AB_INDICES_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_COUNTING_AB_INDICES_FAILED</unmanaged-short>
        DsCountingAbIndicesFailed = unchecked((System.Int32)(8428)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED</unmanaged-short>
        DsHierarchyTableMallocFailed = unchecked((System.Int32)(8429)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INTERNAL_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_DS_INTERNAL_FAILURE</unmanaged-short>
        DsInternalFailure = unchecked((System.Int32)(8430)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNKNOWN_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNKNOWN_ERROR</unmanaged-short>
        DsUnknownError = unchecked((System.Int32)(8431)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ROOT_REQUIRES_CLASS_TOP</unmanaged>
        /// <unmanaged-short>ERROR_DS_ROOT_REQUIRES_CLASS_TOP</unmanaged-short>
        DsRootRequiresClassTop = unchecked((System.Int32)(8432)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_REFUSING_FSMO_ROLES</unmanaged>
        /// <unmanaged-short>ERROR_DS_REFUSING_FSMO_ROLES</unmanaged-short>
        DsRefusingFsmoRoles = unchecked((System.Int32)(8433)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MISSING_FSMO_SETTINGS</unmanaged>
        /// <unmanaged-short>ERROR_DS_MISSING_FSMO_SETTINGS</unmanaged-short>
        DsMissingFsmoSettings = unchecked((System.Int32)(8434)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNABLE_TO_SURRENDER_ROLES</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNABLE_TO_SURRENDER_ROLES</unmanaged-short>
        DsUnableToSurrenderRoles = unchecked((System.Int32)(8435)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_GENERIC</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_GENERIC</unmanaged-short>
        DsDraGeneric = unchecked((System.Int32)(8436)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_INVALID_PARAMETER</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_INVALID_PARAMETER</unmanaged-short>
        DsDraInvalidParameter = unchecked((System.Int32)(8437)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_BUSY</unmanaged-short>
        DsDraBusy = unchecked((System.Int32)(8438)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_BAD_DN</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_BAD_DN</unmanaged-short>
        DsDraBadDn = unchecked((System.Int32)(8439)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_BAD_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_BAD_NC</unmanaged-short>
        DsDraBadNc = unchecked((System.Int32)(8440)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_DN_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_DN_EXISTS</unmanaged-short>
        DsDraDnExists = unchecked((System.Int32)(8441)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_INTERNAL_ERROR</unmanaged-short>
        DsDraInternalError = unchecked((System.Int32)(8442)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_INCONSISTENT_DIT</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_INCONSISTENT_DIT</unmanaged-short>
        DsDraInconsistentDit = unchecked((System.Int32)(8443)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_CONNECTION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_CONNECTION_FAILED</unmanaged-short>
        DsDraConnectionFailed = unchecked((System.Int32)(8444)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_BAD_INSTANCE_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_BAD_INSTANCE_TYPE</unmanaged-short>
        DsDraBadInstanceType = unchecked((System.Int32)(8445)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_OUT_OF_MEM</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_OUT_OF_MEM</unmanaged-short>
        DsDraOutOfMem = unchecked((System.Int32)(8446)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_MAIL_PROBLEM</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_MAIL_PROBLEM</unmanaged-short>
        DsDraMailProblem = unchecked((System.Int32)(8447)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_REF_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_REF_ALREADY_EXISTS</unmanaged-short>
        DsDraRefAlreadyExists = unchecked((System.Int32)(8448)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_REF_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_REF_NOT_FOUND</unmanaged-short>
        DsDraRefNotFound = unchecked((System.Int32)(8449)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_OBJ_IS_REP_SOURCE</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_OBJ_IS_REP_SOURCE</unmanaged-short>
        DsDraObjIsRepSource = unchecked((System.Int32)(8450)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_DB_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_DB_ERROR</unmanaged-short>
        DsDraDbError = unchecked((System.Int32)(8451)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_NO_REPLICA</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_NO_REPLICA</unmanaged-short>
        DsDraNoReplica = unchecked((System.Int32)(8452)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_ACCESS_DENIED</unmanaged-short>
        DsDraAccessDenied = unchecked((System.Int32)(8453)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_NOT_SUPPORTED</unmanaged-short>
        DsDraNotSupported = unchecked((System.Int32)(8454)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_RPC_CANCELLED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_RPC_CANCELLED</unmanaged-short>
        DsDraRpcCancelled = unchecked((System.Int32)(8455)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SOURCE_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SOURCE_DISABLED</unmanaged-short>
        DsDraSourceDisabled = unchecked((System.Int32)(8456)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SINK_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SINK_DISABLED</unmanaged-short>
        DsDraSinkDisabled = unchecked((System.Int32)(8457)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_NAME_COLLISION</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_NAME_COLLISION</unmanaged-short>
        DsDraNameCollision = unchecked((System.Int32)(8458)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SOURCE_REINSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SOURCE_REINSTALLED</unmanaged-short>
        DsDraSourceReinstalled = unchecked((System.Int32)(8459)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_MISSING_PARENT</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_MISSING_PARENT</unmanaged-short>
        DsDraMissingParent = unchecked((System.Int32)(8460)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_PREEMPTED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_PREEMPTED</unmanaged-short>
        DsDraPreempted = unchecked((System.Int32)(8461)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_ABANDON_SYNC</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_ABANDON_SYNC</unmanaged-short>
        DsDraAbandonSync = unchecked((System.Int32)(8462)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SHUTDOWN</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SHUTDOWN</unmanaged-short>
        DsDraShutdown = unchecked((System.Int32)(8463)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET</unmanaged-short>
        DsDraIncompatiblePartialSet = unchecked((System.Int32)(8464)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA</unmanaged-short>
        DsDraSourceIsPartialReplica = unchecked((System.Int32)(8465)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_EXTN_CONNECTION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_EXTN_CONNECTION_FAILED</unmanaged-short>
        DsDraExtnConnectionFailed = unchecked((System.Int32)(8466)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INSTALL_SCHEMA_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_INSTALL_SCHEMA_MISMATCH</unmanaged-short>
        DsInstallSchemaMismatch = unchecked((System.Int32)(8467)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DUP_LINK_ID</unmanaged>
        /// <unmanaged-short>ERROR_DS_DUP_LINK_ID</unmanaged-short>
        DsDupLinkId = unchecked((System.Int32)(8468)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_ERROR_RESOLVING</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_ERROR_RESOLVING</unmanaged-short>
        DsNameErrorResolving = unchecked((System.Int32)(8469)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_ERROR_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_ERROR_NOT_FOUND</unmanaged-short>
        DsNameErrorNotFound = unchecked((System.Int32)(8470)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_ERROR_NOT_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_ERROR_NOT_UNIQUE</unmanaged-short>
        DsNameErrorNotUnique = unchecked((System.Int32)(8471)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_ERROR_NO_MAPPING</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_ERROR_NO_MAPPING</unmanaged-short>
        DsNameErrorNoMapping = unchecked((System.Int32)(8472)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_ERROR_DOMAIN_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_ERROR_DOMAIN_ONLY</unmanaged-short>
        DsNameErrorDomainOnly = unchecked((System.Int32)(8473)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING</unmanaged-short>
        DsNameErrorNoSyntacticalMapping = unchecked((System.Int32)(8474)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CONSTRUCTED_ATT_MOD</unmanaged>
        /// <unmanaged-short>ERROR_DS_CONSTRUCTED_ATT_MOD</unmanaged-short>
        DsConstructedAttMod = unchecked((System.Int32)(8475)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_WRONG_OM_OBJ_CLASS</unmanaged>
        /// <unmanaged-short>ERROR_DS_WRONG_OM_OBJ_CLASS</unmanaged-short>
        DsWrongOmObjClass = unchecked((System.Int32)(8476)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_REPL_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_REPL_PENDING</unmanaged-short>
        DsDraReplPending = unchecked((System.Int32)(8477)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DS_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DS_REQUIRED</unmanaged-short>
        DsDsRequired = unchecked((System.Int32)(8478)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_LDAP_DISPLAY_NAME</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_LDAP_DISPLAY_NAME</unmanaged-short>
        DsInvalidLdapDisplayName = unchecked((System.Int32)(8479)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NON_BASE_SEARCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_NON_BASE_SEARCH</unmanaged-short>
        DsNonBaseSearch = unchecked((System.Int32)(8480)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_RETRIEVE_ATTS</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_RETRIEVE_ATTS</unmanaged-short>
        DsCantRetrieveAtts = unchecked((System.Int32)(8481)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_BACKLINK_WITHOUT_LINK</unmanaged>
        /// <unmanaged-short>ERROR_DS_BACKLINK_WITHOUT_LINK</unmanaged-short>
        DsBacklinkWithoutLink = unchecked((System.Int32)(8482)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_EPOCH_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_EPOCH_MISMATCH</unmanaged-short>
        DsEpochMismatch = unchecked((System.Int32)(8483)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SRC_NAME_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_SRC_NAME_MISMATCH</unmanaged-short>
        DsSrcNameMismatch = unchecked((System.Int32)(8484)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SRC_AND_DST_NC_IDENTICAL</unmanaged>
        /// <unmanaged-short>ERROR_DS_SRC_AND_DST_NC_IDENTICAL</unmanaged-short>
        DsSrcAndDstNcIdentical = unchecked((System.Int32)(8485)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DST_NC_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_DST_NC_MISMATCH</unmanaged-short>
        DsDstNcMismatch = unchecked((System.Int32)(8486)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC</unmanaged-short>
        DsNotAuthoritiveForDstNc = unchecked((System.Int32)(8487)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SRC_GUID_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_SRC_GUID_MISMATCH</unmanaged-short>
        DsSrcGuidMismatch = unchecked((System.Int32)(8488)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MOVE_DELETED_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MOVE_DELETED_OBJECT</unmanaged-short>
        DsCantMoveDeletedObject = unchecked((System.Int32)(8489)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_PDC_OPERATION_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_DS_PDC_OPERATION_IN_PROGRESS</unmanaged-short>
        DsPdcOperationInProgress = unchecked((System.Int32)(8490)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD</unmanaged>
        /// <unmanaged-short>ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD</unmanaged-short>
        DsCrossDomainCleanupReqd = unchecked((System.Int32)(8491)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION</unmanaged-short>
        DsIllegalXdomMoveOperation = unchecked((System.Int32)(8492)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS</unmanaged-short>
        DsCantWithAcctGroupMembershps = unchecked((System.Int32)(8493)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NC_MUST_HAVE_NC_PARENT</unmanaged>
        /// <unmanaged-short>ERROR_DS_NC_MUST_HAVE_NC_PARENT</unmanaged-short>
        DsNcMustHaveNcParent = unchecked((System.Int32)(8494)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE</unmanaged>
        /// <unmanaged-short>ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE</unmanaged-short>
        DsCrImpossibleToValidate = unchecked((System.Int32)(8495)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DST_DOMAIN_NOT_NATIVE</unmanaged>
        /// <unmanaged-short>ERROR_DS_DST_DOMAIN_NOT_NATIVE</unmanaged-short>
        DsDstDomainNotNative = unchecked((System.Int32)(8496)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER</unmanaged>
        /// <unmanaged-short>ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER</unmanaged-short>
        DsMissingInfrastructureContainer = unchecked((System.Int32)(8497)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MOVE_ACCOUNT_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MOVE_ACCOUNT_GROUP</unmanaged-short>
        DsCantMoveAccountGroup = unchecked((System.Int32)(8498)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MOVE_RESOURCE_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MOVE_RESOURCE_GROUP</unmanaged-short>
        DsCantMoveResourceGroup = unchecked((System.Int32)(8499)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_SEARCH_FLAG</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_SEARCH_FLAG</unmanaged-short>
        DsInvalidSearchFlag = unchecked((System.Int32)(8500)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_TREE_DELETE_ABOVE_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_TREE_DELETE_ABOVE_NC</unmanaged-short>
        DsNoTreeDeleteAboveNc = unchecked((System.Int32)(8501)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE</unmanaged>
        /// <unmanaged-short>ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE</unmanaged-short>
        DsCouldntLockTreeForDelete = unchecked((System.Int32)(8502)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE</unmanaged>
        /// <unmanaged-short>ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE</unmanaged-short>
        DsCouldntIdentifyObjectsForTreeDelete = unchecked((System.Int32)(8503)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SAM_INIT_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_DS_SAM_INIT_FAILURE</unmanaged-short>
        DsSamInitFailure = unchecked((System.Int32)(8504)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SENSITIVE_GROUP_VIOLATION</unmanaged>
        /// <unmanaged-short>ERROR_DS_SENSITIVE_GROUP_VIOLATION</unmanaged-short>
        DsSensitiveGroupViolation = unchecked((System.Int32)(8505)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MOD_PRIMARYGROUPID</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MOD_PRIMARYGROUPID</unmanaged-short>
        DsCantModPrimarygroupid = unchecked((System.Int32)(8506)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD</unmanaged>
        /// <unmanaged-short>ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD</unmanaged-short>
        DsIllegalBaseSchemaMod = unchecked((System.Int32)(8507)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NONSAFE_SCHEMA_CHANGE</unmanaged>
        /// <unmanaged-short>ERROR_DS_NONSAFE_SCHEMA_CHANGE</unmanaged-short>
        DsNonsafeSchemaChange = unchecked((System.Int32)(8508)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SCHEMA_UPDATE_DISALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_DS_SCHEMA_UPDATE_DISALLOWED</unmanaged-short>
        DsSchemaUpdateDisallowed = unchecked((System.Int32)(8509)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_CREATE_UNDER_SCHEMA</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_CREATE_UNDER_SCHEMA</unmanaged-short>
        DsCantCreateUnderSchema = unchecked((System.Int32)(8510)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INSTALL_NO_SRC_SCH_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_DS_INSTALL_NO_SRC_SCH_VERSION</unmanaged-short>
        DsInstallNoSrcSchVersion = unchecked((System.Int32)(8511)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE</unmanaged>
        /// <unmanaged-short>ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE</unmanaged-short>
        DsInstallNoSchVersionInInifile = unchecked((System.Int32)(8512)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_GROUP_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_GROUP_TYPE</unmanaged-short>
        DsInvalidGroupType = unchecked((System.Int32)(8513)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN</unmanaged-short>
        DsNoNestGlobalgroupInMixeddomain = unchecked((System.Int32)(8514)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN</unmanaged-short>
        DsNoNestLocalgroupInMixeddomain = unchecked((System.Int32)(8515)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER</unmanaged-short>
        DsGlobalCantHaveLocalMember = unchecked((System.Int32)(8516)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER</unmanaged-short>
        DsGlobalCantHaveUniversalMember = unchecked((System.Int32)(8517)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER</unmanaged-short>
        DsUniversalCantHaveLocalMember = unchecked((System.Int32)(8518)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER</unmanaged-short>
        DsGlobalCantHaveCrossdomainMember = unchecked((System.Int32)(8519)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER</unmanaged-short>
        DsLocalCantHaveCrossdomainLocalMember = unchecked((System.Int32)(8520)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_HAVE_PRIMARY_MEMBERS</unmanaged>
        /// <unmanaged-short>ERROR_DS_HAVE_PRIMARY_MEMBERS</unmanaged-short>
        DsHavePrimaryMembers = unchecked((System.Int32)(8521)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_STRING_SD_CONVERSION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_STRING_SD_CONVERSION_FAILED</unmanaged-short>
        DsStringSdConversionFailed = unchecked((System.Int32)(8522)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAMING_MASTER_GC</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAMING_MASTER_GC</unmanaged-short>
        DsNamingMasterGc = unchecked((System.Int32)(8523)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DNS_LOOKUP_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_DS_DNS_LOOKUP_FAILURE</unmanaged-short>
        DsDnsLookupFailure = unchecked((System.Int32)(8524)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_COULDNT_UPDATE_SPNS</unmanaged>
        /// <unmanaged-short>ERROR_DS_COULDNT_UPDATE_SPNS</unmanaged-short>
        DsCouldntUpdateSpns = unchecked((System.Int32)(8525)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_RETRIEVE_SD</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_RETRIEVE_SD</unmanaged-short>
        DsCantRetrieveSd = unchecked((System.Int32)(8526)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_KEY_NOT_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_DS_KEY_NOT_UNIQUE</unmanaged-short>
        DsKeyNotUnique = unchecked((System.Int32)(8527)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_WRONG_LINKED_ATT_SYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_DS_WRONG_LINKED_ATT_SYNTAX</unmanaged-short>
        DsWrongLinkedAttSyntax = unchecked((System.Int32)(8528)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD</unmanaged>
        /// <unmanaged-short>ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD</unmanaged-short>
        DsSamNeedBootkeyPassword = unchecked((System.Int32)(8529)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY</unmanaged>
        /// <unmanaged-short>ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY</unmanaged-short>
        DsSamNeedBootkeyFloppy = unchecked((System.Int32)(8530)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_START</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_START</unmanaged-short>
        DsCantStart = unchecked((System.Int32)(8531)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INIT_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_DS_INIT_FAILURE</unmanaged-short>
        DsInitFailure = unchecked((System.Int32)(8532)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION</unmanaged-short>
        DsNoPktPrivacyOnConnection = unchecked((System.Int32)(8533)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SOURCE_DOMAIN_IN_FOREST</unmanaged>
        /// <unmanaged-short>ERROR_DS_SOURCE_DOMAIN_IN_FOREST</unmanaged-short>
        DsSourceDomainInForest = unchecked((System.Int32)(8534)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST</unmanaged>
        /// <unmanaged-short>ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST</unmanaged-short>
        DsDestinationDomainNotInForest = unchecked((System.Int32)(8535)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED</unmanaged-short>
        DsDestinationAuditingNotEnabled = unchecked((System.Int32)(8536)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN</unmanaged-short>
        DsCantFindDcForSrcDomain = unchecked((System.Int32)(8537)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER</unmanaged>
        /// <unmanaged-short>ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER</unmanaged-short>
        DsSrcObjNotGroupOrUser = unchecked((System.Int32)(8538)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SRC_SID_EXISTS_IN_FOREST</unmanaged>
        /// <unmanaged-short>ERROR_DS_SRC_SID_EXISTS_IN_FOREST</unmanaged-short>
        DsSrcSidExistsInForest = unchecked((System.Int32)(8539)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH</unmanaged-short>
        DsSrcAndDstObjectClassMismatch = unchecked((System.Int32)(8540)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SAM_INIT_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_SAM_INIT_FAILURE</unmanaged-short>
        SamInitFailure = unchecked((System.Int32)(8541)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SCHEMA_INFO_SHIP</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SCHEMA_INFO_SHIP</unmanaged-short>
        DsDraSchemaInfoShip = unchecked((System.Int32)(8542)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SCHEMA_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SCHEMA_CONFLICT</unmanaged-short>
        DsDraSchemaConflict = unchecked((System.Int32)(8543)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT</unmanaged-short>
        DsDraEarlierSchemaConflict = unchecked((System.Int32)(8544)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_OBJ_NC_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_OBJ_NC_MISMATCH</unmanaged-short>
        DsDraObjNcMismatch = unchecked((System.Int32)(8545)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NC_STILL_HAS_DSAS</unmanaged>
        /// <unmanaged-short>ERROR_DS_NC_STILL_HAS_DSAS</unmanaged-short>
        DsNcStillHasDsas = unchecked((System.Int32)(8546)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GC_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_DS_GC_REQUIRED</unmanaged-short>
        DsGcRequired = unchecked((System.Int32)(8547)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY</unmanaged>
        /// <unmanaged-short>ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY</unmanaged-short>
        DsLocalMemberOfLocalOnly = unchecked((System.Int32)(8548)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS</unmanaged-short>
        DsNoFpoInUniversalGroups = unchecked((System.Int32)(8549)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_ADD_TO_GC</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_ADD_TO_GC</unmanaged-short>
        DsCantAddToGc = unchecked((System.Int32)(8550)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_CHECKPOINT_WITH_PDC</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_CHECKPOINT_WITH_PDC</unmanaged-short>
        DsNoCheckpointWithPdc = unchecked((System.Int32)(8551)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SOURCE_AUDITING_NOT_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_DS_SOURCE_AUDITING_NOT_ENABLED</unmanaged-short>
        DsSourceAuditingNotEnabled = unchecked((System.Int32)(8552)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC</unmanaged-short>
        DsCantCreateInNondomainNc = unchecked((System.Int32)(8553)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_NAME_FOR_SPN</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_NAME_FOR_SPN</unmanaged-short>
        DsInvalidNameForSpn = unchecked((System.Int32)(8554)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS</unmanaged>
        /// <unmanaged-short>ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS</unmanaged-short>
        DsFilterUsesContructedAttrs = unchecked((System.Int32)(8555)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNICODEPWD_NOT_IN_QUOTES</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNICODEPWD_NOT_IN_QUOTES</unmanaged-short>
        DsUnicodepwdNotInQuotes = unchecked((System.Int32)(8556)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED</unmanaged-short>
        DsMachineAccountQuotaExceeded = unchecked((System.Int32)(8557)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MUST_BE_RUN_ON_DST_DC</unmanaged>
        /// <unmanaged-short>ERROR_DS_MUST_BE_RUN_ON_DST_DC</unmanaged-short>
        DsMustBeRunOnDstDc = unchecked((System.Int32)(8558)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER</unmanaged>
        /// <unmanaged-short>ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER</unmanaged-short>
        DsSrcDcMustBeSp4OrGreater = unchecked((System.Int32)(8559)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ</unmanaged-short>
        DsCantTreeDeleteCriticalObj = unchecked((System.Int32)(8560)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INIT_FAILURE_CONSOLE</unmanaged>
        /// <unmanaged-short>ERROR_DS_INIT_FAILURE_CONSOLE</unmanaged-short>
        DsInitFailureConsole = unchecked((System.Int32)(8561)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SAM_INIT_FAILURE_CONSOLE</unmanaged>
        /// <unmanaged-short>ERROR_DS_SAM_INIT_FAILURE_CONSOLE</unmanaged-short>
        DsSamInitFailureConsole = unchecked((System.Int32)(8562)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_FOREST_VERSION_TOO_HIGH</unmanaged>
        /// <unmanaged-short>ERROR_DS_FOREST_VERSION_TOO_HIGH</unmanaged-short>
        DsForestVersionTooHigh = unchecked((System.Int32)(8563)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DOMAIN_VERSION_TOO_HIGH</unmanaged>
        /// <unmanaged-short>ERROR_DS_DOMAIN_VERSION_TOO_HIGH</unmanaged-short>
        DsDomainVersionTooHigh = unchecked((System.Int32)(8564)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_FOREST_VERSION_TOO_LOW</unmanaged>
        /// <unmanaged-short>ERROR_DS_FOREST_VERSION_TOO_LOW</unmanaged-short>
        DsForestVersionTooLow = unchecked((System.Int32)(8565)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DOMAIN_VERSION_TOO_LOW</unmanaged>
        /// <unmanaged-short>ERROR_DS_DOMAIN_VERSION_TOO_LOW</unmanaged-short>
        DsDomainVersionTooLow = unchecked((System.Int32)(8566)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INCOMPATIBLE_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_DS_INCOMPATIBLE_VERSION</unmanaged-short>
        DsIncompatibleVersion = unchecked((System.Int32)(8567)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_LOW_DSA_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_DS_LOW_DSA_VERSION</unmanaged-short>
        DsLowDsaVersion = unchecked((System.Int32)(8568)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN</unmanaged-short>
        DsNoBehaviorVersionInMixeddomain = unchecked((System.Int32)(8569)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NOT_SUPPORTED_SORT_ORDER</unmanaged>
        /// <unmanaged-short>ERROR_DS_NOT_SUPPORTED_SORT_ORDER</unmanaged-short>
        DsNotSupportedSortOrder = unchecked((System.Int32)(8570)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_NOT_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_NOT_UNIQUE</unmanaged-short>
        DsNameNotUnique = unchecked((System.Int32)(8571)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4</unmanaged>
        /// <unmanaged-short>ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4</unmanaged-short>
        DsMachineAccountCreatedPrent4 = unchecked((System.Int32)(8572)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OUT_OF_VERSION_STORE</unmanaged>
        /// <unmanaged-short>ERROR_DS_OUT_OF_VERSION_STORE</unmanaged-short>
        DsOutOfVersionStore = unchecked((System.Int32)(8573)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INCOMPATIBLE_CONTROLS_USED</unmanaged>
        /// <unmanaged-short>ERROR_DS_INCOMPATIBLE_CONTROLS_USED</unmanaged-short>
        DsIncompatibleControlsUsed = unchecked((System.Int32)(8574)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_REF_DOMAIN</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_REF_DOMAIN</unmanaged-short>
        DsNoRefDomain = unchecked((System.Int32)(8575)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_RESERVED_LINK_ID</unmanaged>
        /// <unmanaged-short>ERROR_DS_RESERVED_LINK_ID</unmanaged-short>
        DsReservedLinkId = unchecked((System.Int32)(8576)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_LINK_ID_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_DS_LINK_ID_NOT_AVAILABLE</unmanaged-short>
        DsLinkIdNotAvailable = unchecked((System.Int32)(8577)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER</unmanaged>
        /// <unmanaged-short>ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER</unmanaged-short>
        DsAgCantHaveUniversalMember = unchecked((System.Int32)(8578)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE</unmanaged-short>
        DsModifydnDisallowedByInstanceType = unchecked((System.Int32)(8579)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC</unmanaged-short>
        DsNoObjectMoveInSchemaNc = unchecked((System.Int32)(8580)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG</unmanaged>
        /// <unmanaged-short>ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG</unmanaged-short>
        DsModifydnDisallowedByFlag = unchecked((System.Int32)(8581)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MODIFYDN_WRONG_GRANDPARENT</unmanaged>
        /// <unmanaged-short>ERROR_DS_MODIFYDN_WRONG_GRANDPARENT</unmanaged-short>
        DsModifydnWrongGrandparent = unchecked((System.Int32)(8582)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NAME_ERROR_TRUST_REFERRAL</unmanaged>
        /// <unmanaged-short>ERROR_DS_NAME_ERROR_TRUST_REFERRAL</unmanaged-short>
        DsNameErrorTrustReferral = unchecked((System.Int32)(8583)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER</unmanaged>
        /// <unmanaged-short>ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER</unmanaged-short>
        NotSupportedOnStandardServer = unchecked((System.Int32)(8584)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD</unmanaged-short>
        DsCantAccessRemotePartOfAd = unchecked((System.Int32)(8585)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2</unmanaged>
        /// <unmanaged-short>ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2</unmanaged-short>
        DsCrImpossibleToValidateV2 = unchecked((System.Int32)(8586)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_THREAD_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DS_THREAD_LIMIT_EXCEEDED</unmanaged-short>
        DsThreadLimitExceeded = unchecked((System.Int32)(8587)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NOT_CLOSEST</unmanaged>
        /// <unmanaged-short>ERROR_DS_NOT_CLOSEST</unmanaged-short>
        DsNotClosest = unchecked((System.Int32)(8588)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF</unmanaged-short>
        DsCantDeriveSpnWithoutServerRef = unchecked((System.Int32)(8589)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SINGLE_USER_MODE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_SINGLE_USER_MODE_FAILED</unmanaged-short>
        DsSingleUserModeFailed = unchecked((System.Int32)(8590)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NTDSCRIPT_SYNTAX_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_NTDSCRIPT_SYNTAX_ERROR</unmanaged-short>
        DsNtdscriptSyntaxError = unchecked((System.Int32)(8591)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NTDSCRIPT_PROCESS_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_NTDSCRIPT_PROCESS_ERROR</unmanaged-short>
        DsNtdscriptProcessError = unchecked((System.Int32)(8592)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DIFFERENT_REPL_EPOCHS</unmanaged>
        /// <unmanaged-short>ERROR_DS_DIFFERENT_REPL_EPOCHS</unmanaged-short>
        DsDifferentReplEpochs = unchecked((System.Int32)(8593)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRS_EXTENSIONS_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRS_EXTENSIONS_CHANGED</unmanaged-short>
        DsDrsExtensionsChanged = unchecked((System.Int32)(8594)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR</unmanaged>
        /// <unmanaged-short>ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR</unmanaged-short>
        DsReplicaSetChangeNotAllowedOnDisabledCr = unchecked((System.Int32)(8595)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_MSDS_INTID</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_MSDS_INTID</unmanaged-short>
        DsNoMsdsIntid = unchecked((System.Int32)(8596)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DUP_MSDS_INTID</unmanaged>
        /// <unmanaged-short>ERROR_DS_DUP_MSDS_INTID</unmanaged-short>
        DsDupMsdsIntid = unchecked((System.Int32)(8597)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_EXISTS_IN_RDNATTID</unmanaged>
        /// <unmanaged-short>ERROR_DS_EXISTS_IN_RDNATTID</unmanaged-short>
        DsExistsInRdnattid = unchecked((System.Int32)(8598)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_AUTHORIZATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_AUTHORIZATION_FAILED</unmanaged-short>
        DsAuthorizationFailed = unchecked((System.Int32)(8599)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_SCRIPT</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_SCRIPT</unmanaged-short>
        DsInvalidScript = unchecked((System.Int32)(8600)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_REMOTE_CROSSREF_OP_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_REMOTE_CROSSREF_OP_FAILED</unmanaged-short>
        DsRemoteCrossrefOpFailed = unchecked((System.Int32)(8601)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CROSS_REF_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_DS_CROSS_REF_BUSY</unmanaged-short>
        DsCrossRefBusy = unchecked((System.Int32)(8602)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN</unmanaged-short>
        DsCantDeriveSpnForDeletedDomain = unchecked((System.Int32)(8603)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC</unmanaged-short>
        DsCantDemoteWithWriteableNc = unchecked((System.Int32)(8604)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DUPLICATE_ID_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DS_DUPLICATE_ID_FOUND</unmanaged-short>
        DsDuplicateIdFound = unchecked((System.Int32)(8605)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT</unmanaged-short>
        DsInsufficientAttrToCreateObject = unchecked((System.Int32)(8606)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_GROUP_CONVERSION_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_DS_GROUP_CONVERSION_ERROR</unmanaged-short>
        DsGroupConversionError = unchecked((System.Int32)(8607)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MOVE_APP_BASIC_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MOVE_APP_BASIC_GROUP</unmanaged-short>
        DsCantMoveAppBasicGroup = unchecked((System.Int32)(8608)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_CANT_MOVE_APP_QUERY_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_DS_CANT_MOVE_APP_QUERY_GROUP</unmanaged-short>
        DsCantMoveAppQueryGroup = unchecked((System.Int32)(8609)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_ROLE_NOT_VERIFIED</unmanaged>
        /// <unmanaged-short>ERROR_DS_ROLE_NOT_VERIFIED</unmanaged-short>
        DsRoleNotVerified = unchecked((System.Int32)(8610)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL</unmanaged>
        /// <unmanaged-short>ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL</unmanaged-short>
        DsWkoContainerCannotBeSpecial = unchecked((System.Int32)(8611)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DOMAIN_RENAME_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_DS_DOMAIN_RENAME_IN_PROGRESS</unmanaged-short>
        DsDomainRenameInProgress = unchecked((System.Int32)(8612)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_EXISTING_AD_CHILD_NC</unmanaged>
        /// <unmanaged-short>ERROR_DS_EXISTING_AD_CHILD_NC</unmanaged-short>
        DsExistingAdChildNc = unchecked((System.Int32)(8613)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_REPL_LIFETIME_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DS_REPL_LIFETIME_EXCEEDED</unmanaged-short>
        DsReplLifetimeExceeded = unchecked((System.Int32)(8614)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER</unmanaged>
        /// <unmanaged-short>ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER</unmanaged-short>
        DsDisallowedInSystemContainer = unchecked((System.Int32)(8615)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_LDAP_SEND_QUEUE_FULL</unmanaged>
        /// <unmanaged-short>ERROR_DS_LDAP_SEND_QUEUE_FULL</unmanaged-short>
        DsLdapSendQueueFull = unchecked((System.Int32)(8616)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_OUT_SCHEDULE_WINDOW</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_OUT_SCHEDULE_WINDOW</unmanaged-short>
        DsDraOutScheduleWindow = unchecked((System.Int32)(8617)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_POLICY_NOT_KNOWN</unmanaged>
        /// <unmanaged-short>ERROR_DS_POLICY_NOT_KNOWN</unmanaged-short>
        DsPolicyNotKnown = unchecked((System.Int32)(8618)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SITE_SETTINGS_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_NO_SITE_SETTINGS_OBJECT</unmanaged-short>
        NoSiteSettingsObject = unchecked((System.Int32)(8619)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_SECRETS</unmanaged>
        /// <unmanaged-short>ERROR_NO_SECRETS</unmanaged-short>
        NoSecrets = unchecked((System.Int32)(8620)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_WRITABLE_DC_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NO_WRITABLE_DC_FOUND</unmanaged-short>
        NoWritableDcFound = unchecked((System.Int32)(8621)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_SERVER_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_SERVER_OBJECT</unmanaged-short>
        DsNoServerObject = unchecked((System.Int32)(8622)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NO_NTDSA_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_NO_NTDSA_OBJECT</unmanaged-short>
        DsNoNtdsaObject = unchecked((System.Int32)(8623)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_NON_ASQ_SEARCH</unmanaged>
        /// <unmanaged-short>ERROR_DS_NON_ASQ_SEARCH</unmanaged-short>
        DsNonAsqSearch = unchecked((System.Int32)(8624)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_AUDIT_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_DS_AUDIT_FAILURE</unmanaged-short>
        DsAuditFailure = unchecked((System.Int32)(8625)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE</unmanaged-short>
        DsInvalidSearchFlagSubtree = unchecked((System.Int32)(8626)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_INVALID_SEARCH_FLAG_TUPLE</unmanaged>
        /// <unmanaged-short>ERROR_DS_INVALID_SEARCH_FLAG_TUPLE</unmanaged-short>
        DsInvalidSearchFlagTuple = unchecked((System.Int32)(8627)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_HIERARCHY_TABLE_TOO_DEEP</unmanaged>
        /// <unmanaged-short>ERROR_DS_HIERARCHY_TABLE_TOO_DEEP</unmanaged-short>
        DsHierarchyTableTooDeep = unchecked((System.Int32)(8628)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_CORRUPT_UTD_VECTOR</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_CORRUPT_UTD_VECTOR</unmanaged-short>
        DsDraCorruptUtdVector = unchecked((System.Int32)(8629)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_SECRETS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_SECRETS_DENIED</unmanaged-short>
        DsDraSecretsDenied = unchecked((System.Int32)(8630)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_RESERVED_MAPI_ID</unmanaged>
        /// <unmanaged-short>ERROR_DS_RESERVED_MAPI_ID</unmanaged-short>
        DsReservedMapiId = unchecked((System.Int32)(8631)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MAPI_ID_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_DS_MAPI_ID_NOT_AVAILABLE</unmanaged-short>
        DsMapiIdNotAvailable = unchecked((System.Int32)(8632)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_MISSING_KRBTGT_SECRET</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_MISSING_KRBTGT_SECRET</unmanaged-short>
        DsDraMissingKrbtgtSecret = unchecked((System.Int32)(8633)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST</unmanaged>
        /// <unmanaged-short>ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST</unmanaged-short>
        DsDomainNameExistsInForest = unchecked((System.Int32)(8634)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST</unmanaged>
        /// <unmanaged-short>ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST</unmanaged-short>
        DsFlatNameExistsInForest = unchecked((System.Int32)(8635)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_USER_PRINCIPAL_NAME</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_USER_PRINCIPAL_NAME</unmanaged-short>
        InvalidUserPrincipalName = unchecked((System.Int32)(8636)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS</unmanaged>
        /// <unmanaged-short>ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS</unmanaged-short>
        DsOidMappedGroupCantHaveMembers = unchecked((System.Int32)(8637)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_OID_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_DS_OID_NOT_FOUND</unmanaged-short>
        DsOidNotFound = unchecked((System.Int32)(8638)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DRA_RECYCLED_TARGET</unmanaged>
        /// <unmanaged-short>ERROR_DS_DRA_RECYCLED_TARGET</unmanaged-short>
        DsDraRecycledTarget = unchecked((System.Int32)(8639)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_DISALLOWED_NC_REDIRECT</unmanaged>
        /// <unmanaged-short>ERROR_DS_DISALLOWED_NC_REDIRECT</unmanaged-short>
        DsDisallowedNcRedirect = unchecked((System.Int32)(8640)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_HIGH_ADLDS_FFL</unmanaged>
        /// <unmanaged-short>ERROR_DS_HIGH_ADLDS_FFL</unmanaged-short>
        DsHighAdldsFfl = unchecked((System.Int32)(8641)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_HIGH_DSA_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_DS_HIGH_DSA_VERSION</unmanaged-short>
        DsHighDsaVersion = unchecked((System.Int32)(8642)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_LOW_ADLDS_FFL</unmanaged>
        /// <unmanaged-short>ERROR_DS_LOW_ADLDS_FFL</unmanaged-short>
        DsLowAdldsFfl = unchecked((System.Int32)(8643)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION</unmanaged>
        /// <unmanaged-short>ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION</unmanaged-short>
        DomainSidSameAsLocalWorkstation = unchecked((System.Int32)(8644)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED</unmanaged-short>
        DsUndeleteSamValidationFailed = unchecked((System.Int32)(8645)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INCORRECT_ACCOUNT_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_INCORRECT_ACCOUNT_TYPE</unmanaged-short>
        IncorrectAccountType = unchecked((System.Int32)(8646)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_SPN_VALUE_NOT_UNIQUE_IN_FOREST</unmanaged>
        /// <unmanaged-short>ERROR_DS_SPN_VALUE_NOT_UNIQUE_IN_FOREST</unmanaged-short>
        DsSpnValueNotUniqueInForest = unchecked((System.Int32)(8647)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_UPN_VALUE_NOT_UNIQUE_IN_FOREST</unmanaged>
        /// <unmanaged-short>ERROR_DS_UPN_VALUE_NOT_UNIQUE_IN_FOREST</unmanaged-short>
        DsUpnValueNotUniqueInForest = unchecked((System.Int32)(8648)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_MISSING_FOREST_TRUST</unmanaged>
        /// <unmanaged-short>ERROR_DS_MISSING_FOREST_TRUST</unmanaged-short>
        DsMissingForestTrust = unchecked((System.Int32)(8649)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DS_VALUE_KEY_NOT_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_DS_VALUE_KEY_NOT_UNIQUE</unmanaged-short>
        DsValueKeyNotUnique = unchecked((System.Int32)(8650)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_QM_POLICY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_QM_POLICY_EXISTS</unmanaged-short>
        IpsecQmPolicyExists = unchecked((System.Int32)(13000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_QM_POLICY_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_QM_POLICY_NOT_FOUND</unmanaged-short>
        IpsecQmPolicyNotFound = unchecked((System.Int32)(13001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_QM_POLICY_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_QM_POLICY_IN_USE</unmanaged-short>
        IpsecQmPolicyInUse = unchecked((System.Int32)(13002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_POLICY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_POLICY_EXISTS</unmanaged-short>
        IpsecMmPolicyExists = unchecked((System.Int32)(13003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_POLICY_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_POLICY_NOT_FOUND</unmanaged-short>
        IpsecMmPolicyNotFound = unchecked((System.Int32)(13004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_POLICY_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_POLICY_IN_USE</unmanaged-short>
        IpsecMmPolicyInUse = unchecked((System.Int32)(13005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_FILTER_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_FILTER_EXISTS</unmanaged-short>
        IpsecMmFilterExists = unchecked((System.Int32)(13006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_FILTER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_FILTER_NOT_FOUND</unmanaged-short>
        IpsecMmFilterNotFound = unchecked((System.Int32)(13007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_TRANSPORT_FILTER_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_TRANSPORT_FILTER_EXISTS</unmanaged-short>
        IpsecTransportFilterExists = unchecked((System.Int32)(13008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND</unmanaged-short>
        IpsecTransportFilterNotFound = unchecked((System.Int32)(13009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_AUTH_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_AUTH_EXISTS</unmanaged-short>
        IpsecMmAuthExists = unchecked((System.Int32)(13010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_AUTH_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_AUTH_NOT_FOUND</unmanaged-short>
        IpsecMmAuthNotFound = unchecked((System.Int32)(13011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_AUTH_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_AUTH_IN_USE</unmanaged-short>
        IpsecMmAuthInUse = unchecked((System.Int32)(13012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND</unmanaged-short>
        IpsecDefaultMmPolicyNotFound = unchecked((System.Int32)(13013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND</unmanaged-short>
        IpsecDefaultMmAuthNotFound = unchecked((System.Int32)(13014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND</unmanaged-short>
        IpsecDefaultQmPolicyNotFound = unchecked((System.Int32)(13015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_TUNNEL_FILTER_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_TUNNEL_FILTER_EXISTS</unmanaged-short>
        IpsecTunnelFilterExists = unchecked((System.Int32)(13016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND</unmanaged-short>
        IpsecTunnelFilterNotFound = unchecked((System.Int32)(13017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_FILTER_PENDING_DELETION</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_FILTER_PENDING_DELETION</unmanaged-short>
        IpsecMmFilterPendingDeletion = unchecked((System.Int32)(13018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION</unmanaged-short>
        IpsecTransportFilterPendingDeletion = unchecked((System.Int32)(13019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION</unmanaged-short>
        IpsecTunnelFilterPendingDeletion = unchecked((System.Int32)(13020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_POLICY_PENDING_DELETION</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_POLICY_PENDING_DELETION</unmanaged-short>
        IpsecMmPolicyPendingDeletion = unchecked((System.Int32)(13021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_MM_AUTH_PENDING_DELETION</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_MM_AUTH_PENDING_DELETION</unmanaged-short>
        IpsecMmAuthPendingDeletion = unchecked((System.Int32)(13022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_QM_POLICY_PENDING_DELETION</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_QM_POLICY_PENDING_DELETION</unmanaged-short>
        IpsecQmPolicyPendingDeletion = unchecked((System.Int32)(13023)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NEG_STATUS_BEGIN</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NEG_STATUS_BEGIN</unmanaged-short>
        IpsecIkeNegStatusBegin = unchecked((System.Int32)(13800)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_AUTH_FAIL</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_AUTH_FAIL</unmanaged-short>
        IpsecIkeAuthFail = unchecked((System.Int32)(13801)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_ATTRIB_FAIL</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_ATTRIB_FAIL</unmanaged-short>
        IpsecIkeAttribFail = unchecked((System.Int32)(13802)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NEGOTIATION_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NEGOTIATION_PENDING</unmanaged-short>
        IpsecIkeNegotiationPending = unchecked((System.Int32)(13803)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR</unmanaged-short>
        IpsecIkeGeneralProcessingError = unchecked((System.Int32)(13804)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_TIMED_OUT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_TIMED_OUT</unmanaged-short>
        IpsecIkeTimedOut = unchecked((System.Int32)(13805)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NO_CERT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NO_CERT</unmanaged-short>
        IpsecIkeNoCert = unchecked((System.Int32)(13806)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_SA_DELETED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_SA_DELETED</unmanaged-short>
        IpsecIkeSaDeleted = unchecked((System.Int32)(13807)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_SA_REAPED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_SA_REAPED</unmanaged-short>
        IpsecIkeSaReaped = unchecked((System.Int32)(13808)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_MM_ACQUIRE_DROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_MM_ACQUIRE_DROP</unmanaged-short>
        IpsecIkeMmAcquireDrop = unchecked((System.Int32)(13809)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_QM_ACQUIRE_DROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_QM_ACQUIRE_DROP</unmanaged-short>
        IpsecIkeQmAcquireDrop = unchecked((System.Int32)(13810)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_QUEUE_DROP_MM</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_QUEUE_DROP_MM</unmanaged-short>
        IpsecIkeQueueDropMm = unchecked((System.Int32)(13811)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM</unmanaged-short>
        IpsecIkeQueueDropNoMm = unchecked((System.Int32)(13812)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_DROP_NO_RESPONSE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_DROP_NO_RESPONSE</unmanaged-short>
        IpsecIkeDropNoResponse = unchecked((System.Int32)(13813)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_MM_DELAY_DROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_MM_DELAY_DROP</unmanaged-short>
        IpsecIkeMmDelayDrop = unchecked((System.Int32)(13814)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_QM_DELAY_DROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_QM_DELAY_DROP</unmanaged-short>
        IpsecIkeQmDelayDrop = unchecked((System.Int32)(13815)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_ERROR</unmanaged-short>
        IpsecIkeError = unchecked((System.Int32)(13816)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_CRL_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_CRL_FAILED</unmanaged-short>
        IpsecIkeCrlFailed = unchecked((System.Int32)(13817)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_KEY_USAGE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_KEY_USAGE</unmanaged-short>
        IpsecIkeInvalidKeyUsage = unchecked((System.Int32)(13818)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_CERT_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_CERT_TYPE</unmanaged-short>
        IpsecIkeInvalidCertType = unchecked((System.Int32)(13819)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NO_PRIVATE_KEY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NO_PRIVATE_KEY</unmanaged-short>
        IpsecIkeNoPrivateKey = unchecked((System.Int32)(13820)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY</unmanaged-short>
        IpsecIkeSimultaneousRekey = unchecked((System.Int32)(13821)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_DH_FAIL</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_DH_FAIL</unmanaged-short>
        IpsecIkeDhFail = unchecked((System.Int32)(13822)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED</unmanaged-short>
        IpsecIkeCriticalPayloadNotRecognized = unchecked((System.Int32)(13823)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_HEADER</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_HEADER</unmanaged-short>
        IpsecIkeInvalidHeader = unchecked((System.Int32)(13824)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NO_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NO_POLICY</unmanaged-short>
        IpsecIkeNoPolicy = unchecked((System.Int32)(13825)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_SIGNATURE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_SIGNATURE</unmanaged-short>
        IpsecIkeInvalidSignature = unchecked((System.Int32)(13826)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_KERBEROS_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_KERBEROS_ERROR</unmanaged-short>
        IpsecIkeKerberosError = unchecked((System.Int32)(13827)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NO_PUBLIC_KEY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NO_PUBLIC_KEY</unmanaged-short>
        IpsecIkeNoPublicKey = unchecked((System.Int32)(13828)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR</unmanaged-short>
        IpsecIkeProcessErr = unchecked((System.Int32)(13829)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_SA</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_SA</unmanaged-short>
        IpsecIkeProcessErrSa = unchecked((System.Int32)(13830)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_PROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_PROP</unmanaged-short>
        IpsecIkeProcessErrProp = unchecked((System.Int32)(13831)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_TRANS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_TRANS</unmanaged-short>
        IpsecIkeProcessErrTrans = unchecked((System.Int32)(13832)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_KE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_KE</unmanaged-short>
        IpsecIkeProcessErrKe = unchecked((System.Int32)(13833)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_ID</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_ID</unmanaged-short>
        IpsecIkeProcessErrId = unchecked((System.Int32)(13834)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_CERT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_CERT</unmanaged-short>
        IpsecIkeProcessErrCert = unchecked((System.Int32)(13835)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ</unmanaged-short>
        IpsecIkeProcessErrCertReq = unchecked((System.Int32)(13836)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_HASH</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_HASH</unmanaged-short>
        IpsecIkeProcessErrHash = unchecked((System.Int32)(13837)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_SIG</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_SIG</unmanaged-short>
        IpsecIkeProcessErrSig = unchecked((System.Int32)(13838)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_NONCE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_NONCE</unmanaged-short>
        IpsecIkeProcessErrNonce = unchecked((System.Int32)(13839)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY</unmanaged-short>
        IpsecIkeProcessErrNotify = unchecked((System.Int32)(13840)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_DELETE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_DELETE</unmanaged-short>
        IpsecIkeProcessErrDelete = unchecked((System.Int32)(13841)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR</unmanaged-short>
        IpsecIkeProcessErrVendor = unchecked((System.Int32)(13842)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_PAYLOAD</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_PAYLOAD</unmanaged-short>
        IpsecIkeInvalidPayload = unchecked((System.Int32)(13843)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_LOAD_SOFT_SA</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_LOAD_SOFT_SA</unmanaged-short>
        IpsecIkeLoadSoftSa = unchecked((System.Int32)(13844)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN</unmanaged-short>
        IpsecIkeSoftSaTornDown = unchecked((System.Int32)(13845)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_COOKIE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_COOKIE</unmanaged-short>
        IpsecIkeInvalidCookie = unchecked((System.Int32)(13846)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NO_PEER_CERT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NO_PEER_CERT</unmanaged-short>
        IpsecIkeNoPeerCert = unchecked((System.Int32)(13847)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PEER_CRL_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PEER_CRL_FAILED</unmanaged-short>
        IpsecIkePeerCrlFailed = unchecked((System.Int32)(13848)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_POLICY_CHANGE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_POLICY_CHANGE</unmanaged-short>
        IpsecIkePolicyChange = unchecked((System.Int32)(13849)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NO_MM_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NO_MM_POLICY</unmanaged-short>
        IpsecIkeNoMmPolicy = unchecked((System.Int32)(13850)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NOTCBPRIV</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NOTCBPRIV</unmanaged-short>
        IpsecIkeNotcbpriv = unchecked((System.Int32)(13851)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_SECLOADFAIL</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_SECLOADFAIL</unmanaged-short>
        IpsecIkeSecloadfail = unchecked((System.Int32)(13852)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_FAILSSPINIT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_FAILSSPINIT</unmanaged-short>
        IpsecIkeFailsspinit = unchecked((System.Int32)(13853)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_FAILQUERYSSP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_FAILQUERYSSP</unmanaged-short>
        IpsecIkeFailqueryssp = unchecked((System.Int32)(13854)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_SRVACQFAIL</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_SRVACQFAIL</unmanaged-short>
        IpsecIkeSrvacqfail = unchecked((System.Int32)(13855)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_SRVQUERYCRED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_SRVQUERYCRED</unmanaged-short>
        IpsecIkeSrvquerycred = unchecked((System.Int32)(13856)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_GETSPIFAIL</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_GETSPIFAIL</unmanaged-short>
        IpsecIkeGetspifail = unchecked((System.Int32)(13857)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_FILTER</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_FILTER</unmanaged-short>
        IpsecIkeInvalidFilter = unchecked((System.Int32)(13858)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_OUT_OF_MEMORY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_OUT_OF_MEMORY</unmanaged-short>
        IpsecIkeOutOfMemory = unchecked((System.Int32)(13859)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED</unmanaged-short>
        IpsecIkeAddUpdateKeyFailed = unchecked((System.Int32)(13860)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_POLICY</unmanaged-short>
        IpsecIkeInvalidPolicy = unchecked((System.Int32)(13861)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_UNKNOWN_DOI</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_UNKNOWN_DOI</unmanaged-short>
        IpsecIkeUnknownDoi = unchecked((System.Int32)(13862)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_SITUATION</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_SITUATION</unmanaged-short>
        IpsecIkeInvalidSituation = unchecked((System.Int32)(13863)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_DH_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_DH_FAILURE</unmanaged-short>
        IpsecIkeDhFailure = unchecked((System.Int32)(13864)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_GROUP</unmanaged-short>
        IpsecIkeInvalidGroup = unchecked((System.Int32)(13865)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_ENCRYPT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_ENCRYPT</unmanaged-short>
        IpsecIkeEncrypt = unchecked((System.Int32)(13866)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_DECRYPT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_DECRYPT</unmanaged-short>
        IpsecIkeDecrypt = unchecked((System.Int32)(13867)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_POLICY_MATCH</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_POLICY_MATCH</unmanaged-short>
        IpsecIkePolicyMatch = unchecked((System.Int32)(13868)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_UNSUPPORTED_ID</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_UNSUPPORTED_ID</unmanaged-short>
        IpsecIkeUnsupportedId = unchecked((System.Int32)(13869)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_HASH</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_HASH</unmanaged-short>
        IpsecIkeInvalidHash = unchecked((System.Int32)(13870)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_HASH_ALG</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_HASH_ALG</unmanaged-short>
        IpsecIkeInvalidHashAlg = unchecked((System.Int32)(13871)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_HASH_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_HASH_SIZE</unmanaged-short>
        IpsecIkeInvalidHashSize = unchecked((System.Int32)(13872)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG</unmanaged-short>
        IpsecIkeInvalidEncryptAlg = unchecked((System.Int32)(13873)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_AUTH_ALG</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_AUTH_ALG</unmanaged-short>
        IpsecIkeInvalidAuthAlg = unchecked((System.Int32)(13874)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_SIG</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_SIG</unmanaged-short>
        IpsecIkeInvalidSig = unchecked((System.Int32)(13875)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_LOAD_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_LOAD_FAILED</unmanaged-short>
        IpsecIkeLoadFailed = unchecked((System.Int32)(13876)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_RPC_DELETE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_RPC_DELETE</unmanaged-short>
        IpsecIkeRpcDelete = unchecked((System.Int32)(13877)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_BENIGN_REINIT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_BENIGN_REINIT</unmanaged-short>
        IpsecIkeBenignReinit = unchecked((System.Int32)(13878)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY</unmanaged-short>
        IpsecIkeInvalidResponderLifetimeNotify = unchecked((System.Int32)(13879)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION</unmanaged-short>
        IpsecIkeInvalidMajorVersion = unchecked((System.Int32)(13880)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN</unmanaged-short>
        IpsecIkeInvalidCertKeylen = unchecked((System.Int32)(13881)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_MM_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_MM_LIMIT</unmanaged-short>
        IpsecIkeMmLimit = unchecked((System.Int32)(13882)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NEGOTIATION_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NEGOTIATION_DISABLED</unmanaged-short>
        IpsecIkeNegotiationDisabled = unchecked((System.Int32)(13883)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_QM_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_QM_LIMIT</unmanaged-short>
        IpsecIkeQmLimit = unchecked((System.Int32)(13884)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_MM_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_MM_EXPIRED</unmanaged-short>
        IpsecIkeMmExpired = unchecked((System.Int32)(13885)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID</unmanaged-short>
        IpsecIkePeerMmAssumedInvalid = unchecked((System.Int32)(13886)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH</unmanaged-short>
        IpsecIkeCertChainPolicyMismatch = unchecked((System.Int32)(13887)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID</unmanaged-short>
        IpsecIkeUnexpectedMessageId = unchecked((System.Int32)(13888)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD</unmanaged-short>
        IpsecIkeInvalidAuthPayload = unchecked((System.Int32)(13889)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_DOS_COOKIE_SENT</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_DOS_COOKIE_SENT</unmanaged-short>
        IpsecIkeDosCookieSent = unchecked((System.Int32)(13890)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_SHUTTING_DOWN</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_SHUTTING_DOWN</unmanaged-short>
        IpsecIkeShuttingDown = unchecked((System.Int32)(13891)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_CGA_AUTH_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_CGA_AUTH_FAILED</unmanaged-short>
        IpsecIkeCgaAuthFailed = unchecked((System.Int32)(13892)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PROCESS_ERR_NATOA</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PROCESS_ERR_NATOA</unmanaged-short>
        IpsecIkeProcessErrNatoa = unchecked((System.Int32)(13893)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INVALID_MM_FOR_QM</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INVALID_MM_FOR_QM</unmanaged-short>
        IpsecIkeInvalidMmForQm = unchecked((System.Int32)(13894)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_QM_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_QM_EXPIRED</unmanaged-short>
        IpsecIkeQmExpired = unchecked((System.Int32)(13895)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_TOO_MANY_FILTERS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_TOO_MANY_FILTERS</unmanaged-short>
        IpsecIkeTooManyFilters = unchecked((System.Int32)(13896)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NEG_STATUS_END</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NEG_STATUS_END</unmanaged-short>
        IpsecIkeNegStatusEnd = unchecked((System.Int32)(13897)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL</unmanaged-short>
        IpsecIkeKillDummyNapTunnel = unchecked((System.Int32)(13898)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE</unmanaged-short>
        IpsecIkeInnerIpAssignmentFailure = unchecked((System.Int32)(13899)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING</unmanaged-short>
        IpsecIkeRequireCpPayloadMissing = unchecked((System.Int32)(13900)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING</unmanaged-short>
        IpsecKeyModuleImpersonationNegotiationPending = unchecked((System.Int32)(13901)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS</unmanaged-short>
        IpsecIkeCoexistenceSuppress = unchecked((System.Int32)(13902)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_RATELIMIT_DROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_RATELIMIT_DROP</unmanaged-short>
        IpsecIkeRatelimitDrop = unchecked((System.Int32)(13903)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE</unmanaged-short>
        IpsecIkePeerDoesntSupportMobike = unchecked((System.Int32)(13904)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE</unmanaged-short>
        IpsecIkeAuthorizationFailure = unchecked((System.Int32)(13905)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE</unmanaged-short>
        IpsecIkeStrongCredAuthorizationFailure = unchecked((System.Int32)(13906)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY</unmanaged-short>
        IpsecIkeAuthorizationFailureWithOptionalRetry = unchecked((System.Int32)(13907)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE</unmanaged-short>
        IpsecIkeStrongCredAuthorizationAndCertmapFailure = unchecked((System.Int32)(13908)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END</unmanaged-short>
        IpsecIkeNegStatusExtendedEnd = unchecked((System.Int32)(13909)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_BAD_SPI</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_BAD_SPI</unmanaged-short>
        IpsecBadSpi = unchecked((System.Int32)(13910)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_SA_LIFETIME_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_SA_LIFETIME_EXPIRED</unmanaged-short>
        IpsecSaLifetimeExpired = unchecked((System.Int32)(13911)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_WRONG_SA</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_WRONG_SA</unmanaged-short>
        IpsecWrongSa = unchecked((System.Int32)(13912)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_REPLAY_CHECK_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_REPLAY_CHECK_FAILED</unmanaged-short>
        IpsecReplayCheckFailed = unchecked((System.Int32)(13913)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_INVALID_PACKET</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_INVALID_PACKET</unmanaged-short>
        IpsecInvalidPacket = unchecked((System.Int32)(13914)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_INTEGRITY_CHECK_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_INTEGRITY_CHECK_FAILED</unmanaged-short>
        IpsecIntegrityCheckFailed = unchecked((System.Int32)(13915)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_CLEAR_TEXT_DROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_CLEAR_TEXT_DROP</unmanaged-short>
        IpsecClearTextDrop = unchecked((System.Int32)(13916)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_AUTH_FIREWALL_DROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_AUTH_FIREWALL_DROP</unmanaged-short>
        IpsecAuthFirewallDrop = unchecked((System.Int32)(13917)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_THROTTLE_DROP</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_THROTTLE_DROP</unmanaged-short>
        IpsecThrottleDrop = unchecked((System.Int32)(13918)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DOSP_BLOCK</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DOSP_BLOCK</unmanaged-short>
        IpsecDospBlock = unchecked((System.Int32)(13925)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DOSP_RECEIVED_MULTICAST</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DOSP_RECEIVED_MULTICAST</unmanaged-short>
        IpsecDospReceivedMulticast = unchecked((System.Int32)(13926)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DOSP_INVALID_PACKET</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DOSP_INVALID_PACKET</unmanaged-short>
        IpsecDospInvalidPacket = unchecked((System.Int32)(13927)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED</unmanaged-short>
        IpsecDospStateLookupFailed = unchecked((System.Int32)(13928)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DOSP_MAX_ENTRIES</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DOSP_MAX_ENTRIES</unmanaged-short>
        IpsecDospMaxEntries = unchecked((System.Int32)(13929)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED</unmanaged-short>
        IpsecDospKeymodNotAllowed = unchecked((System.Int32)(13930)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DOSP_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DOSP_NOT_INSTALLED</unmanaged-short>
        IpsecDospNotInstalled = unchecked((System.Int32)(13931)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES</unmanaged>
        /// <unmanaged-short>ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES</unmanaged-short>
        IpsecDospMaxPerIpRatelimitQueues = unchecked((System.Int32)(13932)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_SECTION_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SXS_SECTION_NOT_FOUND</unmanaged-short>
        SxsSectionNotFound = unchecked((System.Int32)(14000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_CANT_GEN_ACTCTX</unmanaged>
        /// <unmanaged-short>ERROR_SXS_CANT_GEN_ACTCTX</unmanaged-short>
        SxsCantGenActctx = unchecked((System.Int32)(14001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_INVALID_ACTCTXDATA_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_INVALID_ACTCTXDATA_FORMAT</unmanaged-short>
        SxsInvalidActctxdataFormat = unchecked((System.Int32)(14002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_ASSEMBLY_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SXS_ASSEMBLY_NOT_FOUND</unmanaged-short>
        SxsAssemblyNotFound = unchecked((System.Int32)(14003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_MANIFEST_FORMAT_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_SXS_MANIFEST_FORMAT_ERROR</unmanaged-short>
        SxsManifestFormatError = unchecked((System.Int32)(14004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_MANIFEST_PARSE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_SXS_MANIFEST_PARSE_ERROR</unmanaged-short>
        SxsManifestParseError = unchecked((System.Int32)(14005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_ACTIVATION_CONTEXT_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_SXS_ACTIVATION_CONTEXT_DISABLED</unmanaged-short>
        SxsActivationContextDisabled = unchecked((System.Int32)(14006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_KEY_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SXS_KEY_NOT_FOUND</unmanaged-short>
        SxsKeyNotFound = unchecked((System.Int32)(14007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_VERSION_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_VERSION_CONFLICT</unmanaged-short>
        SxsVersionConflict = unchecked((System.Int32)(14008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_WRONG_SECTION_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_WRONG_SECTION_TYPE</unmanaged-short>
        SxsWrongSectionType = unchecked((System.Int32)(14009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_THREAD_QUERIES_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_SXS_THREAD_QUERIES_DISABLED</unmanaged-short>
        SxsThreadQueriesDisabled = unchecked((System.Int32)(14010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET</unmanaged>
        /// <unmanaged-short>ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET</unmanaged-short>
        SxsProcessDefaultAlreadySet = unchecked((System.Int32)(14011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_UNKNOWN_ENCODING_GROUP</unmanaged>
        /// <unmanaged-short>ERROR_SXS_UNKNOWN_ENCODING_GROUP</unmanaged-short>
        SxsUnknownEncodingGroup = unchecked((System.Int32)(14012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_UNKNOWN_ENCODING</unmanaged>
        /// <unmanaged-short>ERROR_SXS_UNKNOWN_ENCODING</unmanaged-short>
        SxsUnknownEncoding = unchecked((System.Int32)(14013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_INVALID_XML_NAMESPACE_URI</unmanaged>
        /// <unmanaged-short>ERROR_SXS_INVALID_XML_NAMESPACE_URI</unmanaged-short>
        SxsInvalidXmlNamespaceUri = unchecked((System.Int32)(14014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED</unmanaged-short>
        SxsRootManifestDependencyNotInstalled = unchecked((System.Int32)(14015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED</unmanaged-short>
        SxsLeafManifestDependencyNotInstalled = unchecked((System.Int32)(14016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE</unmanaged-short>
        SxsInvalidAssemblyIdentityAttribute = unchecked((System.Int32)(14017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE</unmanaged-short>
        SxsManifestMissingRequiredDefaultNamespace = unchecked((System.Int32)(14018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE</unmanaged-short>
        SxsManifestInvalidRequiredDefaultNamespace = unchecked((System.Int32)(14019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT</unmanaged-short>
        SxsPrivateManifestCrossPathWithReparsePoint = unchecked((System.Int32)(14020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_DUPLICATE_DLL_NAME</unmanaged>
        /// <unmanaged-short>ERROR_SXS_DUPLICATE_DLL_NAME</unmanaged-short>
        SxsDuplicateDllName = unchecked((System.Int32)(14021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME</unmanaged>
        /// <unmanaged-short>ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME</unmanaged-short>
        SxsDuplicateWindowclassName = unchecked((System.Int32)(14022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_DUPLICATE_CLSID</unmanaged>
        /// <unmanaged-short>ERROR_SXS_DUPLICATE_CLSID</unmanaged-short>
        SxsDuplicateClsid = unchecked((System.Int32)(14023)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_DUPLICATE_IID</unmanaged>
        /// <unmanaged-short>ERROR_SXS_DUPLICATE_IID</unmanaged-short>
        SxsDuplicateIid = unchecked((System.Int32)(14024)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_DUPLICATE_TLBID</unmanaged>
        /// <unmanaged-short>ERROR_SXS_DUPLICATE_TLBID</unmanaged-short>
        SxsDuplicateTlbid = unchecked((System.Int32)(14025)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_DUPLICATE_PROGID</unmanaged>
        /// <unmanaged-short>ERROR_SXS_DUPLICATE_PROGID</unmanaged-short>
        SxsDuplicateProgid = unchecked((System.Int32)(14026)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_DUPLICATE_ASSEMBLY_NAME</unmanaged>
        /// <unmanaged-short>ERROR_SXS_DUPLICATE_ASSEMBLY_NAME</unmanaged-short>
        SxsDuplicateAssemblyName = unchecked((System.Int32)(14027)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_FILE_HASH_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_SXS_FILE_HASH_MISMATCH</unmanaged-short>
        SxsFileHashMismatch = unchecked((System.Int32)(14028)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_POLICY_PARSE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_SXS_POLICY_PARSE_ERROR</unmanaged-short>
        SxsPolicyParseError = unchecked((System.Int32)(14029)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_MISSINGQUOTE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_MISSINGQUOTE</unmanaged-short>
        SxsXmlEMissingquote = unchecked((System.Int32)(14030)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_COMMENTSYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_COMMENTSYNTAX</unmanaged-short>
        SxsXmlECommentsyntax = unchecked((System.Int32)(14031)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_BADSTARTNAMECHAR</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_BADSTARTNAMECHAR</unmanaged-short>
        SxsXmlEBadstartnamechar = unchecked((System.Int32)(14032)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_BADNAMECHAR</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_BADNAMECHAR</unmanaged-short>
        SxsXmlEBadnamechar = unchecked((System.Int32)(14033)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_BADCHARINSTRING</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_BADCHARINSTRING</unmanaged-short>
        SxsXmlEBadcharinstring = unchecked((System.Int32)(14034)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_XMLDECLSYNTAX</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_XMLDECLSYNTAX</unmanaged-short>
        SxsXmlEXmldeclsyntax = unchecked((System.Int32)(14035)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_BADCHARDATA</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_BADCHARDATA</unmanaged-short>
        SxsXmlEBadchardata = unchecked((System.Int32)(14036)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_MISSINGWHITESPACE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_MISSINGWHITESPACE</unmanaged-short>
        SxsXmlEMissingwhitespace = unchecked((System.Int32)(14037)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_EXPECTINGTAGEND</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_EXPECTINGTAGEND</unmanaged-short>
        SxsXmlEExpectingtagend = unchecked((System.Int32)(14038)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_MISSINGSEMICOLON</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_MISSINGSEMICOLON</unmanaged-short>
        SxsXmlEMissingsemicolon = unchecked((System.Int32)(14039)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNBALANCEDPAREN</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNBALANCEDPAREN</unmanaged-short>
        SxsXmlEUnbalancedparen = unchecked((System.Int32)(14040)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INTERNALERROR</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INTERNALERROR</unmanaged-short>
        SxsXmlEInternalerror = unchecked((System.Int32)(14041)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE</unmanaged-short>
        SxsXmlEUnexpectedWhitespace = unchecked((System.Int32)(14042)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INCOMPLETE_ENCODING</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INCOMPLETE_ENCODING</unmanaged-short>
        SxsXmlEIncompleteEncoding = unchecked((System.Int32)(14043)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_MISSING_PAREN</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_MISSING_PAREN</unmanaged-short>
        SxsXmlEMissingParen = unchecked((System.Int32)(14044)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE</unmanaged-short>
        SxsXmlEExpectingclosequote = unchecked((System.Int32)(14045)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_MULTIPLE_COLONS</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_MULTIPLE_COLONS</unmanaged-short>
        SxsXmlEMultipleColons = unchecked((System.Int32)(14046)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INVALID_DECIMAL</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INVALID_DECIMAL</unmanaged-short>
        SxsXmlEInvalidDecimal = unchecked((System.Int32)(14047)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INVALID_HEXIDECIMAL</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INVALID_HEXIDECIMAL</unmanaged-short>
        SxsXmlEInvalidHexidecimal = unchecked((System.Int32)(14048)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INVALID_UNICODE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INVALID_UNICODE</unmanaged-short>
        SxsXmlEInvalidUnicode = unchecked((System.Int32)(14049)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK</unmanaged-short>
        SxsXmlEWhitespaceorquestionmark = unchecked((System.Int32)(14050)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNEXPECTEDENDTAG</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNEXPECTEDENDTAG</unmanaged-short>
        SxsXmlEUnexpectedendtag = unchecked((System.Int32)(14051)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNCLOSEDTAG</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNCLOSEDTAG</unmanaged-short>
        SxsXmlEUnclosedtag = unchecked((System.Int32)(14052)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_DUPLICATEATTRIBUTE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_DUPLICATEATTRIBUTE</unmanaged-short>
        SxsXmlEDuplicateattribute = unchecked((System.Int32)(14053)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_MULTIPLEROOTS</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_MULTIPLEROOTS</unmanaged-short>
        SxsXmlEMultipleroots = unchecked((System.Int32)(14054)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INVALIDATROOTLEVEL</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INVALIDATROOTLEVEL</unmanaged-short>
        SxsXmlEInvalidatrootlevel = unchecked((System.Int32)(14055)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_BADXMLDECL</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_BADXMLDECL</unmanaged-short>
        SxsXmlEBadxmldecl = unchecked((System.Int32)(14056)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_MISSINGROOT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_MISSINGROOT</unmanaged-short>
        SxsXmlEMissingroot = unchecked((System.Int32)(14057)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNEXPECTEDEOF</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNEXPECTEDEOF</unmanaged-short>
        SxsXmlEUnexpectedeof = unchecked((System.Int32)(14058)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_BADPEREFINSUBSET</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_BADPEREFINSUBSET</unmanaged-short>
        SxsXmlEBadperefinsubset = unchecked((System.Int32)(14059)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNCLOSEDSTARTTAG</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNCLOSEDSTARTTAG</unmanaged-short>
        SxsXmlEUnclosedstarttag = unchecked((System.Int32)(14060)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNCLOSEDENDTAG</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNCLOSEDENDTAG</unmanaged-short>
        SxsXmlEUnclosedendtag = unchecked((System.Int32)(14061)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNCLOSEDSTRING</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNCLOSEDSTRING</unmanaged-short>
        SxsXmlEUnclosedstring = unchecked((System.Int32)(14062)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNCLOSEDCOMMENT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNCLOSEDCOMMENT</unmanaged-short>
        SxsXmlEUnclosedcomment = unchecked((System.Int32)(14063)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNCLOSEDDECL</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNCLOSEDDECL</unmanaged-short>
        SxsXmlEUncloseddecl = unchecked((System.Int32)(14064)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNCLOSEDCDATA</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNCLOSEDCDATA</unmanaged-short>
        SxsXmlEUnclosedcdata = unchecked((System.Int32)(14065)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_RESERVEDNAMESPACE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_RESERVEDNAMESPACE</unmanaged-short>
        SxsXmlEReservednamespace = unchecked((System.Int32)(14066)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INVALIDENCODING</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INVALIDENCODING</unmanaged-short>
        SxsXmlEInvalidencoding = unchecked((System.Int32)(14067)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INVALIDSWITCH</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INVALIDSWITCH</unmanaged-short>
        SxsXmlEInvalidswitch = unchecked((System.Int32)(14068)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_BADXMLCASE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_BADXMLCASE</unmanaged-short>
        SxsXmlEBadxmlcase = unchecked((System.Int32)(14069)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INVALID_STANDALONE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INVALID_STANDALONE</unmanaged-short>
        SxsXmlEInvalidStandalone = unchecked((System.Int32)(14070)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_UNEXPECTED_STANDALONE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_UNEXPECTED_STANDALONE</unmanaged-short>
        SxsXmlEUnexpectedStandalone = unchecked((System.Int32)(14071)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_INVALID_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_INVALID_VERSION</unmanaged-short>
        SxsXmlEInvalidVersion = unchecked((System.Int32)(14072)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_XML_E_MISSINGEQUALS</unmanaged>
        /// <unmanaged-short>ERROR_SXS_XML_E_MISSINGEQUALS</unmanaged-short>
        SxsXmlEMissingequals = unchecked((System.Int32)(14073)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_PROTECTION_RECOVERY_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_SXS_PROTECTION_RECOVERY_FAILED</unmanaged-short>
        SxsProtectionRecoveryFailed = unchecked((System.Int32)(14074)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT</unmanaged-short>
        SxsProtectionPublicKeyTooShort = unchecked((System.Int32)(14075)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_PROTECTION_CATALOG_NOT_VALID</unmanaged>
        /// <unmanaged-short>ERROR_SXS_PROTECTION_CATALOG_NOT_VALID</unmanaged-short>
        SxsProtectionCatalogNotValid = unchecked((System.Int32)(14076)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_UNTRANSLATABLE_HRESULT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_UNTRANSLATABLE_HRESULT</unmanaged-short>
        SxsUntranslatableHresult = unchecked((System.Int32)(14077)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING</unmanaged-short>
        SxsProtectionCatalogFileMissing = unchecked((System.Int32)(14078)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE</unmanaged-short>
        SxsMissingAssemblyIdentityAttribute = unchecked((System.Int32)(14079)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME</unmanaged>
        /// <unmanaged-short>ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME</unmanaged-short>
        SxsInvalidAssemblyIdentityAttributeName = unchecked((System.Int32)(14080)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_ASSEMBLY_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_SXS_ASSEMBLY_MISSING</unmanaged-short>
        SxsAssemblyMissing = unchecked((System.Int32)(14081)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_CORRUPT_ACTIVATION_STACK</unmanaged>
        /// <unmanaged-short>ERROR_SXS_CORRUPT_ACTIVATION_STACK</unmanaged-short>
        SxsCorruptActivationStack = unchecked((System.Int32)(14082)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_CORRUPTION</unmanaged>
        /// <unmanaged-short>ERROR_SXS_CORRUPTION</unmanaged-short>
        SxsCorruption = unchecked((System.Int32)(14083)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_EARLY_DEACTIVATION</unmanaged>
        /// <unmanaged-short>ERROR_SXS_EARLY_DEACTIVATION</unmanaged-short>
        SxsEarlyDeactivation = unchecked((System.Int32)(14084)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_INVALID_DEACTIVATION</unmanaged>
        /// <unmanaged-short>ERROR_SXS_INVALID_DEACTIVATION</unmanaged-short>
        SxsInvalidDeactivation = unchecked((System.Int32)(14085)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_MULTIPLE_DEACTIVATION</unmanaged>
        /// <unmanaged-short>ERROR_SXS_MULTIPLE_DEACTIVATION</unmanaged-short>
        SxsMultipleDeactivation = unchecked((System.Int32)(14086)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_PROCESS_TERMINATION_REQUESTED</unmanaged>
        /// <unmanaged-short>ERROR_SXS_PROCESS_TERMINATION_REQUESTED</unmanaged-short>
        SxsProcessTerminationRequested = unchecked((System.Int32)(14087)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_RELEASE_ACTIVATION_CONTEXT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_RELEASE_ACTIVATION_CONTEXT</unmanaged-short>
        SxsReleaseActivationContext = unchecked((System.Int32)(14088)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY</unmanaged-short>
        SxsSystemDefaultActivationContextEmpty = unchecked((System.Int32)(14089)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE</unmanaged-short>
        SxsInvalidIdentityAttributeValue = unchecked((System.Int32)(14090)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME</unmanaged>
        /// <unmanaged-short>ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME</unmanaged-short>
        SxsInvalidIdentityAttributeName = unchecked((System.Int32)(14091)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE</unmanaged-short>
        SxsIdentityDuplicateAttribute = unchecked((System.Int32)(14092)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_IDENTITY_PARSE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_SXS_IDENTITY_PARSE_ERROR</unmanaged-short>
        SxsIdentityParseError = unchecked((System.Int32)(14093)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MALFORMED_SUBSTITUTION_STRING</unmanaged>
        /// <unmanaged-short>ERROR_MALFORMED_SUBSTITUTION_STRING</unmanaged-short>
        MalformedSubstitutionString = unchecked((System.Int32)(14094)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN</unmanaged>
        /// <unmanaged-short>ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN</unmanaged-short>
        SxsIncorrectPublicKeyToken = unchecked((System.Int32)(14095)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_UNMAPPED_SUBSTITUTION_STRING</unmanaged>
        /// <unmanaged-short>ERROR_UNMAPPED_SUBSTITUTION_STRING</unmanaged-short>
        UnmappedSubstitutionString = unchecked((System.Int32)(14096)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_ASSEMBLY_NOT_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_SXS_ASSEMBLY_NOT_LOCKED</unmanaged-short>
        SxsAssemblyNotLocked = unchecked((System.Int32)(14097)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_COMPONENT_STORE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_COMPONENT_STORE_CORRUPT</unmanaged-short>
        SxsComponentStoreCorrupt = unchecked((System.Int32)(14098)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ADVANCED_INSTALLER_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_ADVANCED_INSTALLER_FAILED</unmanaged-short>
        AdvancedInstallerFailed = unchecked((System.Int32)(14099)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_XML_ENCODING_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_XML_ENCODING_MISMATCH</unmanaged-short>
        XmlEncodingMismatch = unchecked((System.Int32)(14100)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT</unmanaged-short>
        SxsManifestIdentitySameButContentsDifferent = unchecked((System.Int32)(14101)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_IDENTITIES_DIFFERENT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_IDENTITIES_DIFFERENT</unmanaged-short>
        SxsIdentitiesDifferent = unchecked((System.Int32)(14102)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT</unmanaged>
        /// <unmanaged-short>ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT</unmanaged-short>
        SxsAssemblyIsNotADeployment = unchecked((System.Int32)(14103)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY</unmanaged>
        /// <unmanaged-short>ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY</unmanaged-short>
        SxsFileNotPartOfAssembly = unchecked((System.Int32)(14104)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_MANIFEST_TOO_BIG</unmanaged>
        /// <unmanaged-short>ERROR_SXS_MANIFEST_TOO_BIG</unmanaged-short>
        SxsManifestTooBig = unchecked((System.Int32)(14105)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_SETTING_NOT_REGISTERED</unmanaged>
        /// <unmanaged-short>ERROR_SXS_SETTING_NOT_REGISTERED</unmanaged-short>
        SxsSettingNotRegistered = unchecked((System.Int32)(14106)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE</unmanaged-short>
        SxsTransactionClosureIncomplete = unchecked((System.Int32)(14107)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SMI_PRIMITIVE_INSTALLER_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_SMI_PRIMITIVE_INSTALLER_FAILED</unmanaged-short>
        SmiPrimitiveInstallerFailed = unchecked((System.Int32)(14108)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GENERIC_COMMAND_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_GENERIC_COMMAND_FAILED</unmanaged-short>
        GenericCommandFailed = unchecked((System.Int32)(14109)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SXS_FILE_HASH_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_SXS_FILE_HASH_MISSING</unmanaged-short>
        SxsFileHashMissing = unchecked((System.Int32)(14110)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_INVALID_CHANNEL_PATH</unmanaged>
        /// <unmanaged-short>ERROR_EVT_INVALID_CHANNEL_PATH</unmanaged-short>
        EvtInvalidChannelPath = unchecked((System.Int32)(15000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_INVALID_QUERY</unmanaged>
        /// <unmanaged-short>ERROR_EVT_INVALID_QUERY</unmanaged-short>
        EvtInvalidQuery = unchecked((System.Int32)(15001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND</unmanaged-short>
        EvtPublisherMetadataNotFound = unchecked((System.Int32)(15002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND</unmanaged-short>
        EvtEventTemplateNotFound = unchecked((System.Int32)(15003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_INVALID_PUBLISHER_NAME</unmanaged>
        /// <unmanaged-short>ERROR_EVT_INVALID_PUBLISHER_NAME</unmanaged-short>
        EvtInvalidPublisherName = unchecked((System.Int32)(15004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_INVALID_EVENT_DATA</unmanaged>
        /// <unmanaged-short>ERROR_EVT_INVALID_EVENT_DATA</unmanaged-short>
        EvtInvalidEventData = unchecked((System.Int32)(15005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_CHANNEL_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_EVT_CHANNEL_NOT_FOUND</unmanaged-short>
        EvtChannelNotFound = unchecked((System.Int32)(15007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_MALFORMED_XML_TEXT</unmanaged>
        /// <unmanaged-short>ERROR_EVT_MALFORMED_XML_TEXT</unmanaged-short>
        EvtMalformedXmlText = unchecked((System.Int32)(15008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL</unmanaged>
        /// <unmanaged-short>ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL</unmanaged-short>
        EvtSubscriptionToDirectChannel = unchecked((System.Int32)(15009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_CONFIGURATION_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_EVT_CONFIGURATION_ERROR</unmanaged-short>
        EvtConfigurationError = unchecked((System.Int32)(15010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_QUERY_RESULT_STALE</unmanaged>
        /// <unmanaged-short>ERROR_EVT_QUERY_RESULT_STALE</unmanaged-short>
        EvtQueryResultStale = unchecked((System.Int32)(15011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_QUERY_RESULT_INVALID_POSITION</unmanaged>
        /// <unmanaged-short>ERROR_EVT_QUERY_RESULT_INVALID_POSITION</unmanaged-short>
        EvtQueryResultInvalidPosition = unchecked((System.Int32)(15012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_NON_VALIDATING_MSXML</unmanaged>
        /// <unmanaged-short>ERROR_EVT_NON_VALIDATING_MSXML</unmanaged-short>
        EvtNonValidatingMsxml = unchecked((System.Int32)(15013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_ALREADYSCOPED</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_ALREADYSCOPED</unmanaged-short>
        EvtFilterAlreadyscoped = unchecked((System.Int32)(15014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_NOTELTSET</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_NOTELTSET</unmanaged-short>
        EvtFilterNoteltset = unchecked((System.Int32)(15015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_INVARG</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_INVARG</unmanaged-short>
        EvtFilterInvarg = unchecked((System.Int32)(15016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_INVTEST</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_INVTEST</unmanaged-short>
        EvtFilterInvtest = unchecked((System.Int32)(15017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_INVTYPE</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_INVTYPE</unmanaged-short>
        EvtFilterInvtype = unchecked((System.Int32)(15018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_PARSEERR</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_PARSEERR</unmanaged-short>
        EvtFilterParseerr = unchecked((System.Int32)(15019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_UNSUPPORTEDOP</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_UNSUPPORTEDOP</unmanaged-short>
        EvtFilterUnsupportedop = unchecked((System.Int32)(15020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_UNEXPECTEDTOKEN</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_UNEXPECTEDTOKEN</unmanaged-short>
        EvtFilterUnexpectedtoken = unchecked((System.Int32)(15021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL</unmanaged>
        /// <unmanaged-short>ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL</unmanaged-short>
        EvtInvalidOperationOverEnabledDirectChannel = unchecked((System.Int32)(15022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE</unmanaged-short>
        EvtInvalidChannelPropertyValue = unchecked((System.Int32)(15023)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE</unmanaged-short>
        EvtInvalidPublisherPropertyValue = unchecked((System.Int32)(15024)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_CHANNEL_CANNOT_ACTIVATE</unmanaged>
        /// <unmanaged-short>ERROR_EVT_CHANNEL_CANNOT_ACTIVATE</unmanaged-short>
        EvtChannelCannotActivate = unchecked((System.Int32)(15025)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_TOO_COMPLEX</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_TOO_COMPLEX</unmanaged-short>
        EvtFilterTooComplex = unchecked((System.Int32)(15026)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_MESSAGE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_EVT_MESSAGE_NOT_FOUND</unmanaged-short>
        EvtMessageNotFound = unchecked((System.Int32)(15027)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_MESSAGE_ID_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_EVT_MESSAGE_ID_NOT_FOUND</unmanaged-short>
        EvtMessageIdNotFound = unchecked((System.Int32)(15028)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_UNRESOLVED_VALUE_INSERT</unmanaged>
        /// <unmanaged-short>ERROR_EVT_UNRESOLVED_VALUE_INSERT</unmanaged-short>
        EvtUnresolvedValueInsert = unchecked((System.Int32)(15029)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_UNRESOLVED_PARAMETER_INSERT</unmanaged>
        /// <unmanaged-short>ERROR_EVT_UNRESOLVED_PARAMETER_INSERT</unmanaged-short>
        EvtUnresolvedParameterInsert = unchecked((System.Int32)(15030)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_MAX_INSERTS_REACHED</unmanaged>
        /// <unmanaged-short>ERROR_EVT_MAX_INSERTS_REACHED</unmanaged-short>
        EvtMaxInsertsReached = unchecked((System.Int32)(15031)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_EVENT_DEFINITION_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_EVT_EVENT_DEFINITION_NOT_FOUND</unmanaged-short>
        EvtEventDefinitionNotFound = unchecked((System.Int32)(15032)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND</unmanaged-short>
        EvtMessageLocaleNotFound = unchecked((System.Int32)(15033)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_VERSION_TOO_OLD</unmanaged>
        /// <unmanaged-short>ERROR_EVT_VERSION_TOO_OLD</unmanaged-short>
        EvtVersionTooOld = unchecked((System.Int32)(15034)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_VERSION_TOO_NEW</unmanaged>
        /// <unmanaged-short>ERROR_EVT_VERSION_TOO_NEW</unmanaged-short>
        EvtVersionTooNew = unchecked((System.Int32)(15035)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY</unmanaged>
        /// <unmanaged-short>ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY</unmanaged-short>
        EvtCannotOpenChannelOfQuery = unchecked((System.Int32)(15036)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_PUBLISHER_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_EVT_PUBLISHER_DISABLED</unmanaged-short>
        EvtPublisherDisabled = unchecked((System.Int32)(15037)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EVT_FILTER_OUT_OF_RANGE</unmanaged>
        /// <unmanaged-short>ERROR_EVT_FILTER_OUT_OF_RANGE</unmanaged-short>
        EvtFilterOutOfRange = unchecked((System.Int32)(15038)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE</unmanaged>
        /// <unmanaged-short>ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE</unmanaged-short>
        EcSubscriptionCannotActivate = unchecked((System.Int32)(15080)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EC_LOG_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_EC_LOG_DISABLED</unmanaged-short>
        EcLogDisabled = unchecked((System.Int32)(15081)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EC_CIRCULAR_FORWARDING</unmanaged>
        /// <unmanaged-short>ERROR_EC_CIRCULAR_FORWARDING</unmanaged-short>
        EcCircularForwarding = unchecked((System.Int32)(15082)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EC_CREDSTORE_FULL</unmanaged>
        /// <unmanaged-short>ERROR_EC_CREDSTORE_FULL</unmanaged-short>
        EcCredstoreFull = unchecked((System.Int32)(15083)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EC_CRED_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_EC_CRED_NOT_FOUND</unmanaged-short>
        EcCredNotFound = unchecked((System.Int32)(15084)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_EC_NO_ACTIVE_CHANNEL</unmanaged>
        /// <unmanaged-short>ERROR_EC_NO_ACTIVE_CHANNEL</unmanaged-short>
        EcNoActiveChannel = unchecked((System.Int32)(15085)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUI_FILE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_MUI_FILE_NOT_FOUND</unmanaged-short>
        MuiFileNotFound = unchecked((System.Int32)(15100)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUI_INVALID_FILE</unmanaged>
        /// <unmanaged-short>ERROR_MUI_INVALID_FILE</unmanaged-short>
        MuiInvalidFile = unchecked((System.Int32)(15101)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUI_INVALID_RC_CONFIG</unmanaged>
        /// <unmanaged-short>ERROR_MUI_INVALID_RC_CONFIG</unmanaged-short>
        MuiInvalidRcConfig = unchecked((System.Int32)(15102)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUI_INVALID_LOCALE_NAME</unmanaged>
        /// <unmanaged-short>ERROR_MUI_INVALID_LOCALE_NAME</unmanaged-short>
        MuiInvalidLocaleName = unchecked((System.Int32)(15103)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME</unmanaged>
        /// <unmanaged-short>ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME</unmanaged-short>
        MuiInvalidUltimatefallbackName = unchecked((System.Int32)(15104)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUI_FILE_NOT_LOADED</unmanaged>
        /// <unmanaged-short>ERROR_MUI_FILE_NOT_LOADED</unmanaged-short>
        MuiFileNotLoaded = unchecked((System.Int32)(15105)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESOURCE_ENUM_USER_STOP</unmanaged>
        /// <unmanaged-short>ERROR_RESOURCE_ENUM_USER_STOP</unmanaged-short>
        ResourceEnumUserStop = unchecked((System.Int32)(15106)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED</unmanaged-short>
        MuiIntlsettingsUilangNotInstalled = unchecked((System.Int32)(15107)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME</unmanaged>
        /// <unmanaged-short>ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME</unmanaged-short>
        MuiIntlsettingsInvalidLocaleName = unchecked((System.Int32)(15108)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE</unmanaged-short>
        MrmRuntimeNoDefaultOrNeutralResource = unchecked((System.Int32)(15110)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_INVALID_PRICONFIG</unmanaged>
        /// <unmanaged-short>ERROR_MRM_INVALID_PRICONFIG</unmanaged-short>
        MrmInvalidPriconfig = unchecked((System.Int32)(15111)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_INVALID_FILE_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_INVALID_FILE_TYPE</unmanaged-short>
        MrmInvalidFileType = unchecked((System.Int32)(15112)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_UNKNOWN_QUALIFIER</unmanaged>
        /// <unmanaged-short>ERROR_MRM_UNKNOWN_QUALIFIER</unmanaged-short>
        MrmUnknownQualifier = unchecked((System.Int32)(15113)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_INVALID_QUALIFIER_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_INVALID_QUALIFIER_VALUE</unmanaged-short>
        MrmInvalidQualifierValue = unchecked((System.Int32)(15114)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_NO_CANDIDATE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_NO_CANDIDATE</unmanaged-short>
        MrmNoCandidate = unchecked((System.Int32)(15115)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE</unmanaged-short>
        MrmNoMatchOrDefaultCandidate = unchecked((System.Int32)(15116)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_RESOURCE_TYPE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_MRM_RESOURCE_TYPE_MISMATCH</unmanaged-short>
        MrmResourceTypeMismatch = unchecked((System.Int32)(15117)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_DUPLICATE_MAP_NAME</unmanaged>
        /// <unmanaged-short>ERROR_MRM_DUPLICATE_MAP_NAME</unmanaged-short>
        MrmDuplicateMapName = unchecked((System.Int32)(15118)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_DUPLICATE_ENTRY</unmanaged>
        /// <unmanaged-short>ERROR_MRM_DUPLICATE_ENTRY</unmanaged-short>
        MrmDuplicateEntry = unchecked((System.Int32)(15119)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_INVALID_RESOURCE_IDENTIFIER</unmanaged>
        /// <unmanaged-short>ERROR_MRM_INVALID_RESOURCE_IDENTIFIER</unmanaged-short>
        MrmInvalidResourceIdentifier = unchecked((System.Int32)(15120)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_FILEPATH_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_MRM_FILEPATH_TOO_LONG</unmanaged-short>
        MrmFilepathTooLong = unchecked((System.Int32)(15121)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE</unmanaged-short>
        MrmUnsupportedDirectoryType = unchecked((System.Int32)(15122)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_INVALID_PRI_FILE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_INVALID_PRI_FILE</unmanaged-short>
        MrmInvalidPriFile = unchecked((System.Int32)(15126)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_NAMED_RESOURCE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_MRM_NAMED_RESOURCE_NOT_FOUND</unmanaged-short>
        MrmNamedResourceNotFound = unchecked((System.Int32)(15127)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_MAP_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_MRM_MAP_NOT_FOUND</unmanaged-short>
        MrmMapNotFound = unchecked((System.Int32)(15135)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_UNSUPPORTED_PROFILE_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_UNSUPPORTED_PROFILE_TYPE</unmanaged-short>
        MrmUnsupportedProfileType = unchecked((System.Int32)(15136)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_INVALID_QUALIFIER_OPERATOR</unmanaged>
        /// <unmanaged-short>ERROR_MRM_INVALID_QUALIFIER_OPERATOR</unmanaged-short>
        MrmInvalidQualifierOperator = unchecked((System.Int32)(15137)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE</unmanaged-short>
        MrmIndeterminateQualifierValue = unchecked((System.Int32)(15138)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_AUTOMERGE_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_MRM_AUTOMERGE_ENABLED</unmanaged-short>
        MrmAutomergeEnabled = unchecked((System.Int32)(15139)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_TOO_MANY_RESOURCES</unmanaged>
        /// <unmanaged-short>ERROR_MRM_TOO_MANY_RESOURCES</unmanaged-short>
        MrmTooManyResources = unchecked((System.Int32)(15140)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_MERGE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_MERGE</unmanaged-short>
        MrmUnsupportedFileTypeForMerge = unchecked((System.Int32)(15141)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_LOAD_UNLOAD_PRI_FILE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_LOAD_UNLOAD_PRI_FILE</unmanaged-short>
        MrmUnsupportedFileTypeForLoadUnloadPriFile = unchecked((System.Int32)(15142)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_NO_CURRENT_VIEW_ON_THREAD</unmanaged>
        /// <unmanaged-short>ERROR_MRM_NO_CURRENT_VIEW_ON_THREAD</unmanaged-short>
        MrmNoCurrentViewOnThread = unchecked((System.Int32)(15143)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DIFFERENT_PROFILE_RESOURCE_MANAGER_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_DIFFERENT_PROFILE_RESOURCE_MANAGER_EXIST</unmanaged-short>
        DifferentProfileResourceManagerExist = unchecked((System.Int32)(15144)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_OPERATION_NOT_ALLOWED_FROM_SYSTEM_COMPONENT</unmanaged>
        /// <unmanaged-short>ERROR_OPERATION_NOT_ALLOWED_FROM_SYSTEM_COMPONENT</unmanaged-short>
        OperationNotAllowedFromSystemComponent = unchecked((System.Int32)(15145)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_DIRECT_REF_TO_NON_DEFAULT_RESOURCE</unmanaged>
        /// <unmanaged-short>ERROR_MRM_DIRECT_REF_TO_NON_DEFAULT_RESOURCE</unmanaged-short>
        MrmDirectRefToNonDefaultResource = unchecked((System.Int32)(15146)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_GENERATION_COUNT_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_MRM_GENERATION_COUNT_MISMATCH</unmanaged-short>
        MrmGenerationCountMismatch = unchecked((System.Int32)(15147)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_VERSION_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_VERSION_MISMATCH</unmanaged-short>
        PriMergeVersionMismatch = unchecked((System.Int32)(15148)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_MISSING_SCHEMA</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_MISSING_SCHEMA</unmanaged-short>
        PriMergeMissingSchema = unchecked((System.Int32)(15149)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_LOAD_FILE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_LOAD_FILE_FAILED</unmanaged-short>
        PriMergeLoadFileFailed = unchecked((System.Int32)(15150)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_ADD_FILE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_ADD_FILE_FAILED</unmanaged-short>
        PriMergeAddFileFailed = unchecked((System.Int32)(15151)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_WRITE_FILE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_WRITE_FILE_FAILED</unmanaged-short>
        PriMergeWriteFileFailed = unchecked((System.Int32)(15152)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_MULTIPLE_PACKAGE_FAMILIES_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_MULTIPLE_PACKAGE_FAMILIES_NOT_ALLOWED</unmanaged-short>
        PriMergeMultiplePackageFamiliesNotAllowed = unchecked((System.Int32)(15153)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_MULTIPLE_MAIN_PACKAGES_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_MULTIPLE_MAIN_PACKAGES_NOT_ALLOWED</unmanaged-short>
        PriMergeMultipleMainPackagesNotAllowed = unchecked((System.Int32)(15154)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_BUNDLE_PACKAGES_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_BUNDLE_PACKAGES_NOT_ALLOWED</unmanaged-short>
        PriMergeBundlePackagesNotAllowed = unchecked((System.Int32)(15155)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_MAIN_PACKAGE_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_MAIN_PACKAGE_REQUIRED</unmanaged-short>
        PriMergeMainPackageRequired = unchecked((System.Int32)(15156)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_RESOURCE_PACKAGE_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_RESOURCE_PACKAGE_REQUIRED</unmanaged-short>
        PriMergeResourcePackageRequired = unchecked((System.Int32)(15157)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PRI_MERGE_INVALID_FILE_NAME</unmanaged>
        /// <unmanaged-short>ERROR_PRI_MERGE_INVALID_FILE_NAME</unmanaged-short>
        PriMergeInvalidFileName = unchecked((System.Int32)(15158)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MRM_PACKAGE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_MRM_PACKAGE_NOT_FOUND</unmanaged-short>
        MrmPackageNotFound = unchecked((System.Int32)(15159)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_INVALID_CAPABILITIES_STRING</unmanaged>
        /// <unmanaged-short>ERROR_MCA_INVALID_CAPABILITIES_STRING</unmanaged-short>
        McaInvalidCapabilitiesString = unchecked((System.Int32)(15200)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_INVALID_VCP_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_MCA_INVALID_VCP_VERSION</unmanaged-short>
        McaInvalidVcpVersion = unchecked((System.Int32)(15201)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION</unmanaged>
        /// <unmanaged-short>ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION</unmanaged-short>
        McaMonitorViolatesMccsSpecification = unchecked((System.Int32)(15202)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_MCCS_VERSION_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_MCA_MCCS_VERSION_MISMATCH</unmanaged-short>
        McaMccsVersionMismatch = unchecked((System.Int32)(15203)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_UNSUPPORTED_MCCS_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_MCA_UNSUPPORTED_MCCS_VERSION</unmanaged-short>
        McaUnsupportedMccsVersion = unchecked((System.Int32)(15204)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_MCA_INTERNAL_ERROR</unmanaged-short>
        McaInternalError = unchecked((System.Int32)(15205)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED</unmanaged>
        /// <unmanaged-short>ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED</unmanaged-short>
        McaInvalidTechnologyTypeReturned = unchecked((System.Int32)(15206)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE</unmanaged>
        /// <unmanaged-short>ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE</unmanaged-short>
        McaUnsupportedColorTemperature = unchecked((System.Int32)(15207)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_AMBIGUOUS_SYSTEM_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_AMBIGUOUS_SYSTEM_DEVICE</unmanaged-short>
        AmbiguousSystemDevice = unchecked((System.Int32)(15250)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_DEVICE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_DEVICE_NOT_FOUND</unmanaged-short>
        SystemDeviceNotFound = unchecked((System.Int32)(15299)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HASH_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_HASH_NOT_SUPPORTED</unmanaged-short>
        HashNotSupported = unchecked((System.Int32)(15300)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HASH_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_HASH_NOT_PRESENT</unmanaged-short>
        HashNotPresent = unchecked((System.Int32)(15301)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED</unmanaged>
        /// <unmanaged-short>ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED</unmanaged-short>
        SecondaryIcProviderNotRegistered = unchecked((System.Int32)(15321)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GPIO_CLIENT_INFORMATION_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_GPIO_CLIENT_INFORMATION_INVALID</unmanaged-short>
        GpioClientInformationInvalid = unchecked((System.Int32)(15322)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GPIO_VERSION_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GPIO_VERSION_NOT_SUPPORTED</unmanaged-short>
        GpioVersionNotSupported = unchecked((System.Int32)(15323)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GPIO_INVALID_REGISTRATION_PACKET</unmanaged>
        /// <unmanaged-short>ERROR_GPIO_INVALID_REGISTRATION_PACKET</unmanaged-short>
        GpioInvalidRegistrationPacket = unchecked((System.Int32)(15324)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GPIO_OPERATION_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_GPIO_OPERATION_DENIED</unmanaged-short>
        GpioOperationDenied = unchecked((System.Int32)(15325)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE</unmanaged>
        /// <unmanaged-short>ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE</unmanaged-short>
        GpioIncompatibleConnectMode = unchecked((System.Int32)(15326)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED</unmanaged>
        /// <unmanaged-short>ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED</unmanaged-short>
        GpioInterruptAlreadyUnmasked = unchecked((System.Int32)(15327)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CANNOT_SWITCH_RUNLEVEL</unmanaged>
        /// <unmanaged-short>ERROR_CANNOT_SWITCH_RUNLEVEL</unmanaged-short>
        CannotSwitchRunlevel = unchecked((System.Int32)(15400)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_RUNLEVEL_SETTING</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_RUNLEVEL_SETTING</unmanaged-short>
        InvalidRunlevelSetting = unchecked((System.Int32)(15401)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RUNLEVEL_SWITCH_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_RUNLEVEL_SWITCH_TIMEOUT</unmanaged-short>
        RunlevelSwitchTimeout = unchecked((System.Int32)(15402)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT</unmanaged-short>
        RunlevelSwitchAgentTimeout = unchecked((System.Int32)(15403)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RUNLEVEL_SWITCH_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_RUNLEVEL_SWITCH_IN_PROGRESS</unmanaged-short>
        RunlevelSwitchInProgress = unchecked((System.Int32)(15404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SERVICES_FAILED_AUTOSTART</unmanaged>
        /// <unmanaged-short>ERROR_SERVICES_FAILED_AUTOSTART</unmanaged-short>
        ServicesFailedAutostart = unchecked((System.Int32)(15405)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_COM_TASK_STOP_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_COM_TASK_STOP_PENDING</unmanaged-short>
        ComTaskStopPending = unchecked((System.Int32)(15501)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_OPEN_PACKAGE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_OPEN_PACKAGE_FAILED</unmanaged-short>
        InstallOpenPackageFailed = unchecked((System.Int32)(15600)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_PACKAGE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_PACKAGE_NOT_FOUND</unmanaged-short>
        InstallPackageNotFound = unchecked((System.Int32)(15601)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_INVALID_PACKAGE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_INVALID_PACKAGE</unmanaged-short>
        InstallInvalidPackage = unchecked((System.Int32)(15602)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED</unmanaged-short>
        InstallResolveDependencyFailed = unchecked((System.Int32)(15603)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_OUT_OF_DISK_SPACE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_OUT_OF_DISK_SPACE</unmanaged-short>
        InstallOutOfDiskSpace = unchecked((System.Int32)(15604)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_NETWORK_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_NETWORK_FAILURE</unmanaged-short>
        InstallNetworkFailure = unchecked((System.Int32)(15605)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_REGISTRATION_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_REGISTRATION_FAILURE</unmanaged-short>
        InstallRegistrationFailure = unchecked((System.Int32)(15606)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_DEREGISTRATION_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_DEREGISTRATION_FAILURE</unmanaged-short>
        InstallDeregistrationFailure = unchecked((System.Int32)(15607)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_CANCEL</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_CANCEL</unmanaged-short>
        InstallCancel = unchecked((System.Int32)(15608)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_FAILED</unmanaged-short>
        InstallFailed = unchecked((System.Int32)(15609)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REMOVE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_REMOVE_FAILED</unmanaged-short>
        RemoveFailed = unchecked((System.Int32)(15610)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGE_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGE_ALREADY_EXISTS</unmanaged-short>
        PackageAlreadyExists = unchecked((System.Int32)(15611)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NEEDS_REMEDIATION</unmanaged>
        /// <unmanaged-short>ERROR_NEEDS_REMEDIATION</unmanaged-short>
        NeedsRemediation = unchecked((System.Int32)(15612)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_PREREQUISITE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_PREREQUISITE_FAILED</unmanaged-short>
        InstallPrerequisiteFailed = unchecked((System.Int32)(15613)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGE_REPOSITORY_CORRUPTED</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGE_REPOSITORY_CORRUPTED</unmanaged-short>
        PackageRepositoryCorrupted = unchecked((System.Int32)(15614)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_POLICY_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_POLICY_FAILURE</unmanaged-short>
        InstallPolicyFailure = unchecked((System.Int32)(15615)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGE_UPDATING</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGE_UPDATING</unmanaged-short>
        PackageUpdating = unchecked((System.Int32)(15616)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPLOYMENT_BLOCKED_BY_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_DEPLOYMENT_BLOCKED_BY_POLICY</unmanaged-short>
        DeploymentBlockedByPolicy = unchecked((System.Int32)(15617)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGES_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGES_IN_USE</unmanaged-short>
        PackagesInUse = unchecked((System.Int32)(15618)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RECOVERY_FILE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_RECOVERY_FILE_CORRUPT</unmanaged-short>
        RecoveryFileCorrupt = unchecked((System.Int32)(15619)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INVALID_STAGED_SIGNATURE</unmanaged>
        /// <unmanaged-short>ERROR_INVALID_STAGED_SIGNATURE</unmanaged-short>
        InvalidStagedSignature = unchecked((System.Int32)(15620)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED</unmanaged-short>
        DeletingExistingApplicationdataStoreFailed = unchecked((System.Int32)(15621)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_PACKAGE_DOWNGRADE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_PACKAGE_DOWNGRADE</unmanaged-short>
        InstallPackageDowngrade = unchecked((System.Int32)(15622)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SYSTEM_NEEDS_REMEDIATION</unmanaged>
        /// <unmanaged-short>ERROR_SYSTEM_NEEDS_REMEDIATION</unmanaged-short>
        SystemNeedsRemediation = unchecked((System.Int32)(15623)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN</unmanaged>
        /// <unmanaged-short>ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN</unmanaged-short>
        AppxIntegrityFailureClrNgen = unchecked((System.Int32)(15624)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_RESILIENCY_FILE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_RESILIENCY_FILE_CORRUPT</unmanaged-short>
        ResiliencyFileCorrupt = unchecked((System.Int32)(15625)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING</unmanaged-short>
        InstallFirewallServiceNotRunning = unchecked((System.Int32)(15626)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGE_MOVE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGE_MOVE_FAILED</unmanaged-short>
        PackageMoveFailed = unchecked((System.Int32)(15627)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_VOLUME_NOT_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_VOLUME_NOT_EMPTY</unmanaged-short>
        InstallVolumeNotEmpty = unchecked((System.Int32)(15628)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_VOLUME_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_VOLUME_OFFLINE</unmanaged-short>
        InstallVolumeOffline = unchecked((System.Int32)(15629)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_VOLUME_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_VOLUME_CORRUPT</unmanaged-short>
        InstallVolumeCorrupt = unchecked((System.Int32)(15630)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NEEDS_REGISTRATION</unmanaged>
        /// <unmanaged-short>ERROR_NEEDS_REGISTRATION</unmanaged-short>
        NeedsRegistration = unchecked((System.Int32)(15631)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_WRONG_PROCESSOR_ARCHITECTURE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_WRONG_PROCESSOR_ARCHITECTURE</unmanaged-short>
        InstallWrongProcessorArchitecture = unchecked((System.Int32)(15632)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEV_SIDELOAD_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_DEV_SIDELOAD_LIMIT_EXCEEDED</unmanaged-short>
        DevSideloadLimitExceeded = unchecked((System.Int32)(15633)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE</unmanaged-short>
        InstallOptionalPackageRequiresMainPackage = unchecked((System.Int32)(15634)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGE_NOT_SUPPORTED_ON_FILESYSTEM</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGE_NOT_SUPPORTED_ON_FILESYSTEM</unmanaged-short>
        PackageNotSupportedOnFilesystem = unchecked((System.Int32)(15635)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGE_MOVE_BLOCKED_BY_STREAMING</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGE_MOVE_BLOCKED_BY_STREAMING</unmanaged-short>
        PackageMoveBlockedByStreaming = unchecked((System.Int32)(15636)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_OPTIONAL_PACKAGE_APPLICATIONID_NOT_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_OPTIONAL_PACKAGE_APPLICATIONID_NOT_UNIQUE</unmanaged-short>
        InstallOptionalPackageApplicationidNotUnique = unchecked((System.Int32)(15637)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGE_STAGING_ONHOLD</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGE_STAGING_ONHOLD</unmanaged-short>
        PackageStagingOnhold = unchecked((System.Int32)(15638)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_INVALID_RELATED_SET_UPDATE</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_INVALID_RELATED_SET_UPDATE</unmanaged-short>
        InstallInvalidRelatedSetUpdate = unchecked((System.Int32)(15639)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_FULLTRUST_CAPABILITY</unmanaged>
        /// <unmanaged-short>ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_FULLTRUST_CAPABILITY</unmanaged-short>
        InstallOptionalPackageRequiresMainPackageFulltrustCapability = unchecked((System.Int32)(15640)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPLOYMENT_BLOCKED_BY_USER_LOG_OFF</unmanaged>
        /// <unmanaged-short>ERROR_DEPLOYMENT_BLOCKED_BY_USER_LOG_OFF</unmanaged-short>
        DeploymentBlockedByUserLogOff = unchecked((System.Int32)(15641)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PROVISION_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_PROVISIONED</unmanaged>
        /// <unmanaged-short>ERROR_PROVISION_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_PROVISIONED</unmanaged-short>
        ProvisionOptionalPackageRequiresMainPackageProvisioned = unchecked((System.Int32)(15642)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGES_REPUTATION_CHECK_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGES_REPUTATION_CHECK_FAILED</unmanaged-short>
        PackagesReputationCheckFailed = unchecked((System.Int32)(15643)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_PACKAGES_REPUTATION_CHECK_TIMEDOUT</unmanaged>
        /// <unmanaged-short>ERROR_PACKAGES_REPUTATION_CHECK_TIMEDOUT</unmanaged-short>
        PackagesReputationCheckTimedout = unchecked((System.Int32)(15644)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DEPLOYMENT_OPTION_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_DEPLOYMENT_OPTION_NOT_SUPPORTED</unmanaged-short>
        DeploymentOptionNotSupported = unchecked((System.Int32)(15645)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_APPINSTALLER_ACTIVATION_BLOCKED</unmanaged>
        /// <unmanaged-short>ERROR_APPINSTALLER_ACTIVATION_BLOCKED</unmanaged-short>
        AppinstallerActivationBlocked = unchecked((System.Int32)(15646)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_REGISTRATION_FROM_REMOTE_DRIVE_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_REGISTRATION_FROM_REMOTE_DRIVE_NOT_SUPPORTED</unmanaged-short>
        RegistrationFromRemoteDriveNotSupported = unchecked((System.Int32)(15647)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_LOAD_STORE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_LOAD_STORE_FAILED</unmanaged-short>
        StateLoadStoreFailed = unchecked((System.Int32)(15800)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_GET_VERSION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_GET_VERSION_FAILED</unmanaged-short>
        StateGetVersionFailed = unchecked((System.Int32)(15801)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_SET_VERSION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_SET_VERSION_FAILED</unmanaged-short>
        StateSetVersionFailed = unchecked((System.Int32)(15802)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_STRUCTURED_RESET_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_STRUCTURED_RESET_FAILED</unmanaged-short>
        StateStructuredResetFailed = unchecked((System.Int32)(15803)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_OPEN_CONTAINER_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_OPEN_CONTAINER_FAILED</unmanaged-short>
        StateOpenContainerFailed = unchecked((System.Int32)(15804)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_CREATE_CONTAINER_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_CREATE_CONTAINER_FAILED</unmanaged-short>
        StateCreateContainerFailed = unchecked((System.Int32)(15805)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_DELETE_CONTAINER_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_DELETE_CONTAINER_FAILED</unmanaged-short>
        StateDeleteContainerFailed = unchecked((System.Int32)(15806)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_READ_SETTING_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_READ_SETTING_FAILED</unmanaged-short>
        StateReadSettingFailed = unchecked((System.Int32)(15807)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_WRITE_SETTING_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_WRITE_SETTING_FAILED</unmanaged-short>
        StateWriteSettingFailed = unchecked((System.Int32)(15808)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_DELETE_SETTING_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_DELETE_SETTING_FAILED</unmanaged-short>
        StateDeleteSettingFailed = unchecked((System.Int32)(15809)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_QUERY_SETTING_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_QUERY_SETTING_FAILED</unmanaged-short>
        StateQuerySettingFailed = unchecked((System.Int32)(15810)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_READ_COMPOSITE_SETTING_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_READ_COMPOSITE_SETTING_FAILED</unmanaged-short>
        StateReadCompositeSettingFailed = unchecked((System.Int32)(15811)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED</unmanaged-short>
        StateWriteCompositeSettingFailed = unchecked((System.Int32)(15812)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_ENUMERATE_CONTAINER_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_ENUMERATE_CONTAINER_FAILED</unmanaged-short>
        StateEnumerateContainerFailed = unchecked((System.Int32)(15813)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_ENUMERATE_SETTINGS_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_ENUMERATE_SETTINGS_FAILED</unmanaged-short>
        StateEnumerateSettingsFailed = unchecked((System.Int32)(15814)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED</unmanaged-short>
        StateCompositeSettingValueSizeLimitExceeded = unchecked((System.Int32)(15815)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED</unmanaged-short>
        StateSettingValueSizeLimitExceeded = unchecked((System.Int32)(15816)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED</unmanaged-short>
        StateSettingNameSizeLimitExceeded = unchecked((System.Int32)(15817)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED</unmanaged-short>
        StateContainerNameSizeLimitExceeded = unchecked((System.Int32)(15818)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_API_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_API_UNAVAILABLE</unmanaged-short>
        ApiUnavailable = unchecked((System.Int32)(15841)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_AUDITING_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_AUDITING_DISABLED</unmanaged-short>
        AuditingDisabled = unchecked((System.Int32)(-1073151999)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ALL_SIDS_FILTERED</unmanaged>
        /// <unmanaged-short>ERROR_ALL_SIDS_FILTERED</unmanaged-short>
        AllSidsFiltered = unchecked((System.Int32)(-1073151998)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BIZRULES_NOT_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_BIZRULES_NOT_ENABLED</unmanaged-short>
        BizrulesNotEnabled = unchecked((System.Int32)(-1073151997)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CRED_REQUIRES_CONFIRMATION</unmanaged>
        /// <unmanaged-short>ERROR_CRED_REQUIRES_CONFIRMATION</unmanaged-short>
        CredRequiresConfirmation = unchecked((System.Int32)(-2146865127)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_IO_COMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_FLT_IO_COMPLETE</unmanaged-short>
        FltIoComplete = unchecked((System.Int32)(2031617)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_NO_HANDLER_DEFINED</unmanaged>
        /// <unmanaged-short>ERROR_FLT_NO_HANDLER_DEFINED</unmanaged-short>
        FltNoHandlerDefined = unchecked((System.Int32)(-2145452031)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_CONTEXT_ALREADY_DEFINED</unmanaged>
        /// <unmanaged-short>ERROR_FLT_CONTEXT_ALREADY_DEFINED</unmanaged-short>
        FltContextAlreadyDefined = unchecked((System.Int32)(-2145452030)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_INVALID_ASYNCHRONOUS_REQUEST</unmanaged>
        /// <unmanaged-short>ERROR_FLT_INVALID_ASYNCHRONOUS_REQUEST</unmanaged-short>
        FltInvalidAsynchronousRequest = unchecked((System.Int32)(-2145452029)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_DISALLOW_FAST_IO</unmanaged>
        /// <unmanaged-short>ERROR_FLT_DISALLOW_FAST_IO</unmanaged-short>
        FltDisallowFastIo = unchecked((System.Int32)(-2145452028)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_INVALID_NAME_REQUEST</unmanaged>
        /// <unmanaged-short>ERROR_FLT_INVALID_NAME_REQUEST</unmanaged-short>
        FltInvalidNameRequest = unchecked((System.Int32)(-2145452027)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_NOT_SAFE_TO_POST_OPERATION</unmanaged>
        /// <unmanaged-short>ERROR_FLT_NOT_SAFE_TO_POST_OPERATION</unmanaged-short>
        FltNotSafeToPostOperation = unchecked((System.Int32)(-2145452026)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_NOT_INITIALIZED</unmanaged>
        /// <unmanaged-short>ERROR_FLT_NOT_INITIALIZED</unmanaged-short>
        FltNotInitialized = unchecked((System.Int32)(-2145452025)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_FILTER_NOT_READY</unmanaged>
        /// <unmanaged-short>ERROR_FLT_FILTER_NOT_READY</unmanaged-short>
        FltFilterNotReady = unchecked((System.Int32)(-2145452024)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_POST_OPERATION_CLEANUP</unmanaged>
        /// <unmanaged-short>ERROR_FLT_POST_OPERATION_CLEANUP</unmanaged-short>
        FltPostOperationCleanup = unchecked((System.Int32)(-2145452023)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_FLT_INTERNAL_ERROR</unmanaged-short>
        FltInternalError = unchecked((System.Int32)(-2145452022)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_DELETING_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_FLT_DELETING_OBJECT</unmanaged-short>
        FltDeletingObject = unchecked((System.Int32)(-2145452021)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_MUST_BE_NONPAGED_POOL</unmanaged>
        /// <unmanaged-short>ERROR_FLT_MUST_BE_NONPAGED_POOL</unmanaged-short>
        FltMustBeNonpagedPool = unchecked((System.Int32)(-2145452020)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_DUPLICATE_ENTRY</unmanaged>
        /// <unmanaged-short>ERROR_FLT_DUPLICATE_ENTRY</unmanaged-short>
        FltDuplicateEntry = unchecked((System.Int32)(-2145452019)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_CBDQ_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_FLT_CBDQ_DISABLED</unmanaged-short>
        FltCbdqDisabled = unchecked((System.Int32)(-2145452018)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_DO_NOT_ATTACH</unmanaged>
        /// <unmanaged-short>ERROR_FLT_DO_NOT_ATTACH</unmanaged-short>
        FltDoNotAttach = unchecked((System.Int32)(-2145452017)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_DO_NOT_DETACH</unmanaged>
        /// <unmanaged-short>ERROR_FLT_DO_NOT_DETACH</unmanaged-short>
        FltDoNotDetach = unchecked((System.Int32)(-2145452016)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_INSTANCE_ALTITUDE_COLLISION</unmanaged>
        /// <unmanaged-short>ERROR_FLT_INSTANCE_ALTITUDE_COLLISION</unmanaged-short>
        FltInstanceAltitudeCollision = unchecked((System.Int32)(-2145452015)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_INSTANCE_NAME_COLLISION</unmanaged>
        /// <unmanaged-short>ERROR_FLT_INSTANCE_NAME_COLLISION</unmanaged-short>
        FltInstanceNameCollision = unchecked((System.Int32)(-2145452014)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_FILTER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_FLT_FILTER_NOT_FOUND</unmanaged-short>
        FltFilterNotFound = unchecked((System.Int32)(-2145452013)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_VOLUME_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_FLT_VOLUME_NOT_FOUND</unmanaged-short>
        FltVolumeNotFound = unchecked((System.Int32)(-2145452012)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_INSTANCE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_FLT_INSTANCE_NOT_FOUND</unmanaged-short>
        FltInstanceNotFound = unchecked((System.Int32)(-2145452011)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_CONTEXT_ALLOCATION_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_FLT_CONTEXT_ALLOCATION_NOT_FOUND</unmanaged-short>
        FltContextAllocationNotFound = unchecked((System.Int32)(-2145452010)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_INVALID_CONTEXT_REGISTRATION</unmanaged>
        /// <unmanaged-short>ERROR_FLT_INVALID_CONTEXT_REGISTRATION</unmanaged-short>
        FltInvalidContextRegistration = unchecked((System.Int32)(-2145452009)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_NAME_CACHE_MISS</unmanaged>
        /// <unmanaged-short>ERROR_FLT_NAME_CACHE_MISS</unmanaged-short>
        FltNameCacheMiss = unchecked((System.Int32)(-2145452008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_NO_DEVICE_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_FLT_NO_DEVICE_OBJECT</unmanaged-short>
        FltNoDeviceObject = unchecked((System.Int32)(-2145452007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_VOLUME_ALREADY_MOUNTED</unmanaged>
        /// <unmanaged-short>ERROR_FLT_VOLUME_ALREADY_MOUNTED</unmanaged-short>
        FltVolumeAlreadyMounted = unchecked((System.Int32)(-2145452006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_ALREADY_ENLISTED</unmanaged>
        /// <unmanaged-short>ERROR_FLT_ALREADY_ENLISTED</unmanaged-short>
        FltAlreadyEnlisted = unchecked((System.Int32)(-2145452005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_CONTEXT_ALREADY_LINKED</unmanaged>
        /// <unmanaged-short>ERROR_FLT_CONTEXT_ALREADY_LINKED</unmanaged-short>
        FltContextAlreadyLinked = unchecked((System.Int32)(-2145452004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_NO_WAITER_FOR_REPLY</unmanaged>
        /// <unmanaged-short>ERROR_FLT_NO_WAITER_FOR_REPLY</unmanaged-short>
        FltNoWaiterForReply = unchecked((System.Int32)(-2145452000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_FLT_REGISTRATION_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_FLT_REGISTRATION_BUSY</unmanaged-short>
        FltRegistrationBusy = unchecked((System.Int32)(-2145451997)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HUNG_DISPLAY_DRIVER_THREAD</unmanaged>
        /// <unmanaged-short>ERROR_HUNG_DISPLAY_DRIVER_THREAD</unmanaged-short>
        HungDisplayDriverThread = unchecked((System.Int32)(-2144993279)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_NO_DESCRIPTOR</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_NO_DESCRIPTOR</unmanaged-short>
        MonitorNoDescriptor = unchecked((System.Int32)(2494465)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT</unmanaged-short>
        MonitorUnknownDescriptorFormat = unchecked((System.Int32)(2494466)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_INVALID_DESCRIPTOR_CHECKSUM</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_INVALID_DESCRIPTOR_CHECKSUM</unmanaged-short>
        MonitorInvalidDescriptorChecksum = unchecked((System.Int32)(-1071247357)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_INVALID_STANDARD_TIMING_BLOCK</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_INVALID_STANDARD_TIMING_BLOCK</unmanaged-short>
        MonitorInvalidStandardTimingBlock = unchecked((System.Int32)(-1071247356)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED</unmanaged-short>
        MonitorWmiDatablockRegistrationFailed = unchecked((System.Int32)(-1071247355)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK</unmanaged-short>
        MonitorInvalidSerialNumberMondscBlock = unchecked((System.Int32)(-1071247354)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK</unmanaged-short>
        MonitorInvalidUserFriendlyMondscBlock = unchecked((System.Int32)(-1071247353)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_NO_MORE_DESCRIPTOR_DATA</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_NO_MORE_DESCRIPTOR_DATA</unmanaged-short>
        MonitorNoMoreDescriptorData = unchecked((System.Int32)(-1071247352)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_INVALID_DETAILED_TIMING_BLOCK</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_INVALID_DETAILED_TIMING_BLOCK</unmanaged-short>
        MonitorInvalidDetailedTimingBlock = unchecked((System.Int32)(-1071247351)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_MONITOR_INVALID_MANUFACTURE_DATE</unmanaged>
        /// <unmanaged-short>ERROR_MONITOR_INVALID_MANUFACTURE_DATE</unmanaged-short>
        MonitorInvalidManufactureDate = unchecked((System.Int32)(-1071247350)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER</unmanaged-short>
        GraphicsNotExclusiveModeOwner = unchecked((System.Int32)(-1071243264)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INSUFFICIENT_DMA_BUFFER</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INSUFFICIENT_DMA_BUFFER</unmanaged-short>
        GraphicsInsufficientDmaBuffer = unchecked((System.Int32)(-1071243263)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_DISPLAY_ADAPTER</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_DISPLAY_ADAPTER</unmanaged-short>
        GraphicsInvalidDisplayAdapter = unchecked((System.Int32)(-1071243262)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ADAPTER_WAS_RESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ADAPTER_WAS_RESET</unmanaged-short>
        GraphicsAdapterWasReset = unchecked((System.Int32)(-1071243261)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_DRIVER_MODEL</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_DRIVER_MODEL</unmanaged-short>
        GraphicsInvalidDriverModel = unchecked((System.Int32)(-1071243260)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PRESENT_MODE_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PRESENT_MODE_CHANGED</unmanaged-short>
        GraphicsPresentModeChanged = unchecked((System.Int32)(-1071243259)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PRESENT_OCCLUDED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PRESENT_OCCLUDED</unmanaged-short>
        GraphicsPresentOccluded = unchecked((System.Int32)(-1071243258)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PRESENT_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PRESENT_DENIED</unmanaged-short>
        GraphicsPresentDenied = unchecked((System.Int32)(-1071243257)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CANNOTCOLORCONVERT</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CANNOTCOLORCONVERT</unmanaged-short>
        GraphicsCannotcolorconvert = unchecked((System.Int32)(-1071243256)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DRIVER_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DRIVER_MISMATCH</unmanaged-short>
        GraphicsDriverMismatch = unchecked((System.Int32)(-1071243255)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PARTIAL_DATA_POPULATED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PARTIAL_DATA_POPULATED</unmanaged-short>
        GraphicsPartialDataPopulated = unchecked((System.Int32)(1076240394)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PRESENT_REDIRECTION_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PRESENT_REDIRECTION_DISABLED</unmanaged-short>
        GraphicsPresentRedirectionDisabled = unchecked((System.Int32)(-1071243253)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PRESENT_UNOCCLUDED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PRESENT_UNOCCLUDED</unmanaged-short>
        GraphicsPresentUnoccluded = unchecked((System.Int32)(-1071243252)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_WINDOWDC_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_WINDOWDC_NOT_AVAILABLE</unmanaged-short>
        GraphicsWindowdcNotAvailable = unchecked((System.Int32)(-1071243251)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_WINDOWLESS_PRESENT_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_WINDOWLESS_PRESENT_DISABLED</unmanaged-short>
        GraphicsWindowlessPresentDisabled = unchecked((System.Int32)(-1071243250)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PRESENT_INVALID_WINDOW</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PRESENT_INVALID_WINDOW</unmanaged-short>
        GraphicsPresentInvalidWindow = unchecked((System.Int32)(-1071243249)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PRESENT_BUFFER_NOT_BOUND</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PRESENT_BUFFER_NOT_BOUND</unmanaged-short>
        GraphicsPresentBufferNotBound = unchecked((System.Int32)(-1071243248)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_VAIL_STATE_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_VAIL_STATE_CHANGED</unmanaged-short>
        GraphicsVailStateChanged = unchecked((System.Int32)(-1071243247)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_VIDEO_MEMORY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_VIDEO_MEMORY</unmanaged-short>
        GraphicsNoVideoMemory = unchecked((System.Int32)(-1071243008)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CANT_LOCK_MEMORY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CANT_LOCK_MEMORY</unmanaged-short>
        GraphicsCantLockMemory = unchecked((System.Int32)(-1071243007)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ALLOCATION_BUSY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ALLOCATION_BUSY</unmanaged-short>
        GraphicsAllocationBusy = unchecked((System.Int32)(-1071243006)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_TOO_MANY_REFERENCES</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_TOO_MANY_REFERENCES</unmanaged-short>
        GraphicsTooManyReferences = unchecked((System.Int32)(-1071243005)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_TRY_AGAIN_LATER</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_TRY_AGAIN_LATER</unmanaged-short>
        GraphicsTryAgainLater = unchecked((System.Int32)(-1071243004)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_TRY_AGAIN_NOW</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_TRY_AGAIN_NOW</unmanaged-short>
        GraphicsTryAgainNow = unchecked((System.Int32)(-1071243003)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ALLOCATION_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ALLOCATION_INVALID</unmanaged-short>
        GraphicsAllocationInvalid = unchecked((System.Int32)(-1071243002)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE</unmanaged-short>
        GraphicsUnswizzlingApertureUnavailable = unchecked((System.Int32)(-1071243001)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED</unmanaged-short>
        GraphicsUnswizzlingApertureUnsupported = unchecked((System.Int32)(-1071243000)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION</unmanaged-short>
        GraphicsCantEvictPinnedAllocation = unchecked((System.Int32)(-1071242999)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_ALLOCATION_USAGE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_ALLOCATION_USAGE</unmanaged-short>
        GraphicsInvalidAllocationUsage = unchecked((System.Int32)(-1071242992)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION</unmanaged-short>
        GraphicsCantRenderLockedAllocation = unchecked((System.Int32)(-1071242991)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ALLOCATION_CLOSED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ALLOCATION_CLOSED</unmanaged-short>
        GraphicsAllocationClosed = unchecked((System.Int32)(-1071242990)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_ALLOCATION_INSTANCE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_ALLOCATION_INSTANCE</unmanaged-short>
        GraphicsInvalidAllocationInstance = unchecked((System.Int32)(-1071242989)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_ALLOCATION_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_ALLOCATION_HANDLE</unmanaged-short>
        GraphicsInvalidAllocationHandle = unchecked((System.Int32)(-1071242988)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_WRONG_ALLOCATION_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_WRONG_ALLOCATION_DEVICE</unmanaged-short>
        GraphicsWrongAllocationDevice = unchecked((System.Int32)(-1071242987)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ALLOCATION_CONTENT_LOST</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ALLOCATION_CONTENT_LOST</unmanaged-short>
        GraphicsAllocationContentLost = unchecked((System.Int32)(-1071242986)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_GPU_EXCEPTION_ON_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_GPU_EXCEPTION_ON_DEVICE</unmanaged-short>
        GraphicsGpuExceptionOnDevice = unchecked((System.Int32)(-1071242752)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_SKIP_ALLOCATION_PREPARATION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_SKIP_ALLOCATION_PREPARATION</unmanaged-short>
        GraphicsSkipAllocationPreparation = unchecked((System.Int32)(1076240897)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY</unmanaged-short>
        GraphicsInvalidVidpnTopology = unchecked((System.Int32)(-1071242496)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED</unmanaged-short>
        GraphicsVidpnTopologyNotSupported = unchecked((System.Int32)(-1071242495)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED</unmanaged-short>
        GraphicsVidpnTopologyCurrentlyNotSupported = unchecked((System.Int32)(-1071242494)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDPN</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDPN</unmanaged-short>
        GraphicsInvalidVidpn = unchecked((System.Int32)(-1071242493)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE</unmanaged-short>
        GraphicsInvalidVideoPresentSource = unchecked((System.Int32)(-1071242492)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET</unmanaged-short>
        GraphicsInvalidVideoPresentTarget = unchecked((System.Int32)(-1071242491)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED</unmanaged-short>
        GraphicsVidpnModalityNotSupported = unchecked((System.Int32)(-1071242490)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MODE_NOT_PINNED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MODE_NOT_PINNED</unmanaged-short>
        GraphicsModeNotPinned = unchecked((System.Int32)(2499335)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDPN_SOURCEMODESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDPN_SOURCEMODESET</unmanaged-short>
        GraphicsInvalidVidpnSourcemodeset = unchecked((System.Int32)(-1071242488)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDPN_TARGETMODESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDPN_TARGETMODESET</unmanaged-short>
        GraphicsInvalidVidpnTargetmodeset = unchecked((System.Int32)(-1071242487)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_FREQUENCY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_FREQUENCY</unmanaged-short>
        GraphicsInvalidFrequency = unchecked((System.Int32)(-1071242486)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_ACTIVE_REGION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_ACTIVE_REGION</unmanaged-short>
        GraphicsInvalidActiveRegion = unchecked((System.Int32)(-1071242485)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_TOTAL_REGION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_TOTAL_REGION</unmanaged-short>
        GraphicsInvalidTotalRegion = unchecked((System.Int32)(-1071242484)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE</unmanaged-short>
        GraphicsInvalidVideoPresentSourceMode = unchecked((System.Int32)(-1071242480)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE</unmanaged-short>
        GraphicsInvalidVideoPresentTargetMode = unchecked((System.Int32)(-1071242479)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET</unmanaged-short>
        GraphicsPinnedModeMustRemainInSet = unchecked((System.Int32)(-1071242478)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY</unmanaged-short>
        GraphicsPathAlreadyInTopology = unchecked((System.Int32)(-1071242477)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MODE_ALREADY_IN_MODESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MODE_ALREADY_IN_MODESET</unmanaged-short>
        GraphicsModeAlreadyInModeset = unchecked((System.Int32)(-1071242476)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET</unmanaged-short>
        GraphicsInvalidVideopresentsourceset = unchecked((System.Int32)(-1071242475)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET</unmanaged-short>
        GraphicsInvalidVideopresenttargetset = unchecked((System.Int32)(-1071242474)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_SOURCE_ALREADY_IN_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_SOURCE_ALREADY_IN_SET</unmanaged-short>
        GraphicsSourceAlreadyInSet = unchecked((System.Int32)(-1071242473)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_TARGET_ALREADY_IN_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_TARGET_ALREADY_IN_SET</unmanaged-short>
        GraphicsTargetAlreadyInSet = unchecked((System.Int32)(-1071242472)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDPN_PRESENT_PATH</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDPN_PRESENT_PATH</unmanaged-short>
        GraphicsInvalidVidpnPresentPath = unchecked((System.Int32)(-1071242471)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY</unmanaged-short>
        GraphicsNoRecommendedVidpnTopology = unchecked((System.Int32)(-1071242470)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET</unmanaged-short>
        GraphicsInvalidMonitorFrequencyrangeset = unchecked((System.Int32)(-1071242469)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE</unmanaged-short>
        GraphicsInvalidMonitorFrequencyrange = unchecked((System.Int32)(-1071242468)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET</unmanaged-short>
        GraphicsFrequencyrangeNotInSet = unchecked((System.Int32)(-1071242467)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_PREFERRED_MODE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_PREFERRED_MODE</unmanaged-short>
        GraphicsNoPreferredMode = unchecked((System.Int32)(2499358)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET</unmanaged-short>
        GraphicsFrequencyrangeAlreadyInSet = unchecked((System.Int32)(-1071242465)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_STALE_MODESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_STALE_MODESET</unmanaged-short>
        GraphicsStaleModeset = unchecked((System.Int32)(-1071242464)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MONITOR_SOURCEMODESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MONITOR_SOURCEMODESET</unmanaged-short>
        GraphicsInvalidMonitorSourcemodeset = unchecked((System.Int32)(-1071242463)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MONITOR_SOURCE_MODE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MONITOR_SOURCE_MODE</unmanaged-short>
        GraphicsInvalidMonitorSourceMode = unchecked((System.Int32)(-1071242462)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN</unmanaged-short>
        GraphicsNoRecommendedFunctionalVidpn = unchecked((System.Int32)(-1071242461)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MODE_ID_MUST_BE_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MODE_ID_MUST_BE_UNIQUE</unmanaged-short>
        GraphicsModeIdMustBeUnique = unchecked((System.Int32)(-1071242460)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION</unmanaged-short>
        GraphicsEmptyAdapterMonitorModeSupportIntersection = unchecked((System.Int32)(-1071242459)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES</unmanaged-short>
        GraphicsVideoPresentTargetsLessThanSources = unchecked((System.Int32)(-1071242458)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PATH_NOT_IN_TOPOLOGY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PATH_NOT_IN_TOPOLOGY</unmanaged-short>
        GraphicsPathNotInTopology = unchecked((System.Int32)(-1071242457)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE</unmanaged-short>
        GraphicsAdapterMustHaveAtLeastOneSource = unchecked((System.Int32)(-1071242456)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET</unmanaged-short>
        GraphicsAdapterMustHaveAtLeastOneTarget = unchecked((System.Int32)(-1071242455)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MONITORDESCRIPTORSET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MONITORDESCRIPTORSET</unmanaged-short>
        GraphicsInvalidMonitordescriptorset = unchecked((System.Int32)(-1071242454)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MONITORDESCRIPTOR</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MONITORDESCRIPTOR</unmanaged-short>
        GraphicsInvalidMonitordescriptor = unchecked((System.Int32)(-1071242453)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET</unmanaged-short>
        GraphicsMonitordescriptorNotInSet = unchecked((System.Int32)(-1071242452)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET</unmanaged-short>
        GraphicsMonitordescriptorAlreadyInSet = unchecked((System.Int32)(-1071242451)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE</unmanaged-short>
        GraphicsMonitordescriptorIdMustBeUnique = unchecked((System.Int32)(-1071242450)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE</unmanaged-short>
        GraphicsInvalidVidpnTargetSubsetType = unchecked((System.Int32)(-1071242449)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_RESOURCES_NOT_RELATED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_RESOURCES_NOT_RELATED</unmanaged-short>
        GraphicsResourcesNotRelated = unchecked((System.Int32)(-1071242448)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE</unmanaged-short>
        GraphicsSourceIdMustBeUnique = unchecked((System.Int32)(-1071242447)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE</unmanaged-short>
        GraphicsTargetIdMustBeUnique = unchecked((System.Int32)(-1071242446)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET</unmanaged-short>
        GraphicsNoAvailableVidpnTarget = unchecked((System.Int32)(-1071242445)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER</unmanaged-short>
        GraphicsMonitorCouldNotBeAssociatedWithAdapter = unchecked((System.Int32)(-1071242444)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_VIDPNMGR</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_VIDPNMGR</unmanaged-short>
        GraphicsNoVidpnmgr = unchecked((System.Int32)(-1071242443)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_ACTIVE_VIDPN</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_ACTIVE_VIDPN</unmanaged-short>
        GraphicsNoActiveVidpn = unchecked((System.Int32)(-1071242442)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_STALE_VIDPN_TOPOLOGY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_STALE_VIDPN_TOPOLOGY</unmanaged-short>
        GraphicsStaleVidpnTopology = unchecked((System.Int32)(-1071242441)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MONITOR_NOT_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MONITOR_NOT_CONNECTED</unmanaged-short>
        GraphicsMonitorNotConnected = unchecked((System.Int32)(-1071242440)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY</unmanaged-short>
        GraphicsSourceNotInTopology = unchecked((System.Int32)(-1071242439)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE</unmanaged-short>
        GraphicsInvalidPrimarysurfaceSize = unchecked((System.Int32)(-1071242438)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VISIBLEREGION_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VISIBLEREGION_SIZE</unmanaged-short>
        GraphicsInvalidVisibleregionSize = unchecked((System.Int32)(-1071242437)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_STRIDE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_STRIDE</unmanaged-short>
        GraphicsInvalidStride = unchecked((System.Int32)(-1071242436)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_PIXELFORMAT</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_PIXELFORMAT</unmanaged-short>
        GraphicsInvalidPixelformat = unchecked((System.Int32)(-1071242435)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_COLORBASIS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_COLORBASIS</unmanaged-short>
        GraphicsInvalidColorbasis = unchecked((System.Int32)(-1071242434)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_PIXELVALUEACCESSMODE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_PIXELVALUEACCESSMODE</unmanaged-short>
        GraphicsInvalidPixelvalueaccessmode = unchecked((System.Int32)(-1071242433)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_TARGET_NOT_IN_TOPOLOGY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_TARGET_NOT_IN_TOPOLOGY</unmanaged-short>
        GraphicsTargetNotInTopology = unchecked((System.Int32)(-1071242432)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT</unmanaged-short>
        GraphicsNoDisplayModeManagementSupport = unchecked((System.Int32)(-1071242431)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE</unmanaged-short>
        GraphicsVidpnSourceInUse = unchecked((System.Int32)(-1071242430)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN</unmanaged-short>
        GraphicsCantAccessActiveVidpn = unchecked((System.Int32)(-1071242429)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL</unmanaged-short>
        GraphicsInvalidPathImportanceOrdinal = unchecked((System.Int32)(-1071242428)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION</unmanaged-short>
        GraphicsInvalidPathContentGeometryTransformation = unchecked((System.Int32)(-1071242427)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED</unmanaged-short>
        GraphicsPathContentGeometryTransformationNotSupported = unchecked((System.Int32)(-1071242426)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_GAMMA_RAMP</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_GAMMA_RAMP</unmanaged-short>
        GraphicsInvalidGammaRamp = unchecked((System.Int32)(-1071242425)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED</unmanaged-short>
        GraphicsGammaRampNotSupported = unchecked((System.Int32)(-1071242424)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED</unmanaged-short>
        GraphicsMultisamplingNotSupported = unchecked((System.Int32)(-1071242423)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MODE_NOT_IN_MODESET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MODE_NOT_IN_MODESET</unmanaged-short>
        GraphicsModeNotInModeset = unchecked((System.Int32)(-1071242422)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DATASET_IS_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DATASET_IS_EMPTY</unmanaged-short>
        GraphicsDatasetIsEmpty = unchecked((System.Int32)(2499403)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET</unmanaged-short>
        GraphicsNoMoreElementsInDataset = unchecked((System.Int32)(2499404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON</unmanaged-short>
        GraphicsInvalidVidpnTopologyRecommendationReason = unchecked((System.Int32)(-1071242419)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_PATH_CONTENT_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_PATH_CONTENT_TYPE</unmanaged-short>
        GraphicsInvalidPathContentType = unchecked((System.Int32)(-1071242418)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_COPYPROTECTION_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_COPYPROTECTION_TYPE</unmanaged-short>
        GraphicsInvalidCopyprotectionType = unchecked((System.Int32)(-1071242417)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS</unmanaged-short>
        GraphicsUnassignedModesetAlreadyExists = unchecked((System.Int32)(-1071242416)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED</unmanaged-short>
        GraphicsPathContentGeometryTransformationNotPinned = unchecked((System.Int32)(2499409)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_SCANLINE_ORDERING</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_SCANLINE_ORDERING</unmanaged-short>
        GraphicsInvalidScanlineOrdering = unchecked((System.Int32)(-1071242414)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED</unmanaged-short>
        GraphicsTopologyChangesNotAllowed = unchecked((System.Int32)(-1071242413)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS</unmanaged-short>
        GraphicsNoAvailableImportanceOrdinals = unchecked((System.Int32)(-1071242412)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT</unmanaged-short>
        GraphicsIncompatiblePrivateFormat = unchecked((System.Int32)(-1071242411)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM</unmanaged-short>
        GraphicsInvalidModePruningAlgorithm = unchecked((System.Int32)(-1071242410)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN</unmanaged-short>
        GraphicsInvalidMonitorCapabilityOrigin = unchecked((System.Int32)(-1071242409)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT</unmanaged-short>
        GraphicsInvalidMonitorFrequencyrangeConstraint = unchecked((System.Int32)(-1071242408)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MAX_NUM_PATHS_REACHED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MAX_NUM_PATHS_REACHED</unmanaged-short>
        GraphicsMaxNumPathsReached = unchecked((System.Int32)(-1071242407)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION</unmanaged-short>
        GraphicsCancelVidpnTopologyAugmentation = unchecked((System.Int32)(-1071242406)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_CLIENT_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_CLIENT_TYPE</unmanaged-short>
        GraphicsInvalidClientType = unchecked((System.Int32)(-1071242405)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CLIENTVIDPN_NOT_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CLIENTVIDPN_NOT_SET</unmanaged-short>
        GraphicsClientvidpnNotSet = unchecked((System.Int32)(-1071242404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED</unmanaged-short>
        GraphicsSpecifiedChildAlreadyConnected = unchecked((System.Int32)(-1071242240)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED</unmanaged-short>
        GraphicsChildDescriptorNotSupported = unchecked((System.Int32)(-1071242239)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_UNKNOWN_CHILD_STATUS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_UNKNOWN_CHILD_STATUS</unmanaged-short>
        GraphicsUnknownChildStatus = unchecked((System.Int32)(1076241455)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NOT_A_LINKED_ADAPTER</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NOT_A_LINKED_ADAPTER</unmanaged-short>
        GraphicsNotALinkedAdapter = unchecked((System.Int32)(-1071242192)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_LEADLINK_NOT_ENUMERATED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_LEADLINK_NOT_ENUMERATED</unmanaged-short>
        GraphicsLeadlinkNotEnumerated = unchecked((System.Int32)(-1071242191)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CHAINLINKS_NOT_ENUMERATED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CHAINLINKS_NOT_ENUMERATED</unmanaged-short>
        GraphicsChainlinksNotEnumerated = unchecked((System.Int32)(-1071242190)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ADAPTER_CHAIN_NOT_READY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ADAPTER_CHAIN_NOT_READY</unmanaged-short>
        GraphicsAdapterChainNotReady = unchecked((System.Int32)(-1071242189)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CHAINLINKS_NOT_STARTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CHAINLINKS_NOT_STARTED</unmanaged-short>
        GraphicsChainlinksNotStarted = unchecked((System.Int32)(-1071242188)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_CHAINLINKS_NOT_POWERED_ON</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_CHAINLINKS_NOT_POWERED_ON</unmanaged-short>
        GraphicsChainlinksNotPoweredOn = unchecked((System.Int32)(-1071242187)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE</unmanaged-short>
        GraphicsInconsistentDeviceLinkState = unchecked((System.Int32)(-1071242186)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_LEADLINK_START_DEFERRED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_LEADLINK_START_DEFERRED</unmanaged-short>
        GraphicsLeadlinkStartDeferred = unchecked((System.Int32)(1076241463)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NOT_POST_DEVICE_DRIVER</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NOT_POST_DEVICE_DRIVER</unmanaged-short>
        GraphicsNotPostDeviceDriver = unchecked((System.Int32)(-1071242184)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_POLLING_TOO_FREQUENTLY</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_POLLING_TOO_FREQUENTLY</unmanaged-short>
        GraphicsPollingTooFrequently = unchecked((System.Int32)(1076241465)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_START_DEFERRED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_START_DEFERRED</unmanaged-short>
        GraphicsStartDeferred = unchecked((System.Int32)(1076241466)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED</unmanaged-short>
        GraphicsAdapterAccessNotExcluded = unchecked((System.Int32)(-1071242181)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DEPENDABLE_CHILD_STATUS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DEPENDABLE_CHILD_STATUS</unmanaged-short>
        GraphicsDependableChildStatus = unchecked((System.Int32)(1076241468)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_NOT_SUPPORTED</unmanaged-short>
        GraphicsOpmNotSupported = unchecked((System.Int32)(-1071241984)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_COPP_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_COPP_NOT_SUPPORTED</unmanaged-short>
        GraphicsCoppNotSupported = unchecked((System.Int32)(-1071241983)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_UAB_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_UAB_NOT_SUPPORTED</unmanaged-short>
        GraphicsUabNotSupported = unchecked((System.Int32)(-1071241982)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS</unmanaged-short>
        GraphicsOpmInvalidEncryptedParameters = unchecked((System.Int32)(-1071241981)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_NO_VIDEO_OUTPUTS_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_NO_VIDEO_OUTPUTS_EXIST</unmanaged-short>
        GraphicsOpmNoVideoOutputsExist = unchecked((System.Int32)(-1071241979)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_INTERNAL_ERROR</unmanaged-short>
        GraphicsOpmInternalError = unchecked((System.Int32)(-1071241973)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_INVALID_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_INVALID_HANDLE</unmanaged-short>
        GraphicsOpmInvalidHandle = unchecked((System.Int32)(-1071241972)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH</unmanaged-short>
        GraphicsPvpInvalidCertificateLength = unchecked((System.Int32)(-1071241970)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_SPANNING_MODE_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_SPANNING_MODE_ENABLED</unmanaged-short>
        GraphicsOpmSpanningModeEnabled = unchecked((System.Int32)(-1071241969)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_THEATER_MODE_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_THEATER_MODE_ENABLED</unmanaged-short>
        GraphicsOpmTheaterModeEnabled = unchecked((System.Int32)(-1071241968)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PVP_HFS_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PVP_HFS_FAILED</unmanaged-short>
        GraphicsPvpHfsFailed = unchecked((System.Int32)(-1071241967)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_INVALID_SRM</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_INVALID_SRM</unmanaged-short>
        GraphicsOpmInvalidSrm = unchecked((System.Int32)(-1071241966)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP</unmanaged-short>
        GraphicsOpmOutputDoesNotSupportHdcp = unchecked((System.Int32)(-1071241965)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP</unmanaged-short>
        GraphicsOpmOutputDoesNotSupportAcp = unchecked((System.Int32)(-1071241964)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA</unmanaged-short>
        GraphicsOpmOutputDoesNotSupportCgmsa = unchecked((System.Int32)(-1071241963)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_HDCP_SRM_NEVER_SET</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_HDCP_SRM_NEVER_SET</unmanaged-short>
        GraphicsOpmHdcpSrmNeverSet = unchecked((System.Int32)(-1071241962)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_RESOLUTION_TOO_HIGH</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_RESOLUTION_TOO_HIGH</unmanaged-short>
        GraphicsOpmResolutionTooHigh = unchecked((System.Int32)(-1071241961)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE</unmanaged-short>
        GraphicsOpmAllHdcpHardwareAlreadyInUse = unchecked((System.Int32)(-1071241960)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_NO_LONGER_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_NO_LONGER_EXISTS</unmanaged-short>
        GraphicsOpmVideoOutputNoLongerExists = unchecked((System.Int32)(-1071241958)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_SESSION_TYPE_CHANGE_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_SESSION_TYPE_CHANGE_IN_PROGRESS</unmanaged-short>
        GraphicsOpmSessionTypeChangeInProgress = unchecked((System.Int32)(-1071241957)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS</unmanaged-short>
        GraphicsOpmVideoOutputDoesNotHaveCoppSemantics = unchecked((System.Int32)(-1071241956)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST</unmanaged-short>
        GraphicsOpmInvalidInformationRequest = unchecked((System.Int32)(-1071241955)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR</unmanaged-short>
        GraphicsOpmDriverInternalError = unchecked((System.Int32)(-1071241954)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS</unmanaged-short>
        GraphicsOpmVideoOutputDoesNotHaveOpmSemantics = unchecked((System.Int32)(-1071241953)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED</unmanaged-short>
        GraphicsOpmSignalingNotSupported = unchecked((System.Int32)(-1071241952)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST</unmanaged-short>
        GraphicsOpmInvalidConfigurationRequest = unchecked((System.Int32)(-1071241951)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_I2C_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_I2C_NOT_SUPPORTED</unmanaged-short>
        GraphicsI2CNotSupported = unchecked((System.Int32)(-1071241856)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST</unmanaged-short>
        GraphicsI2CDeviceDoesNotExist = unchecked((System.Int32)(-1071241855)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA</unmanaged-short>
        GraphicsI2CErrorTransmittingData = unchecked((System.Int32)(-1071241854)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_I2C_ERROR_RECEIVING_DATA</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_I2C_ERROR_RECEIVING_DATA</unmanaged-short>
        GraphicsI2CErrorReceivingData = unchecked((System.Int32)(-1071241853)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED</unmanaged-short>
        GraphicsDdcciVcpNotSupported = unchecked((System.Int32)(-1071241852)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DDCCI_INVALID_DATA</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DDCCI_INVALID_DATA</unmanaged-short>
        GraphicsDdcciInvalidData = unchecked((System.Int32)(-1071241851)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE</unmanaged-short>
        GraphicsDdcciMonitorReturnedInvalidTimingStatusByte = unchecked((System.Int32)(-1071241850)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MCA_INVALID_CAPABILITIES_STRING</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MCA_INVALID_CAPABILITIES_STRING</unmanaged-short>
        GraphicsMcaInvalidCapabilitiesString = unchecked((System.Int32)(-1071241849)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MCA_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MCA_INTERNAL_ERROR</unmanaged-short>
        GraphicsMcaInternalError = unchecked((System.Int32)(-1071241848)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND</unmanaged-short>
        GraphicsDdcciInvalidMessageCommand = unchecked((System.Int32)(-1071241847)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH</unmanaged-short>
        GraphicsDdcciInvalidMessageLength = unchecked((System.Int32)(-1071241846)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM</unmanaged-short>
        GraphicsDdcciInvalidMessageChecksum = unchecked((System.Int32)(-1071241845)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE</unmanaged-short>
        GraphicsInvalidPhysicalMonitorHandle = unchecked((System.Int32)(-1071241844)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MONITOR_NO_LONGER_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MONITOR_NO_LONGER_EXISTS</unmanaged-short>
        GraphicsMonitorNoLongerExists = unchecked((System.Int32)(-1071241843)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DDCCI_CURRENT_CURRENT_VALUE_GREATER_THAN_MAXIMUM_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DDCCI_CURRENT_CURRENT_VALUE_GREATER_THAN_MAXIMUM_VALUE</unmanaged-short>
        GraphicsDdcciCurrentCurrentValueGreaterThanMaximumValue = unchecked((System.Int32)(-1071241768)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MCA_INVALID_VCP_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MCA_INVALID_VCP_VERSION</unmanaged-short>
        GraphicsMcaInvalidVcpVersion = unchecked((System.Int32)(-1071241767)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION</unmanaged-short>
        GraphicsMcaMonitorViolatesMccsSpecification = unchecked((System.Int32)(-1071241766)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MCA_MCCS_VERSION_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MCA_MCCS_VERSION_MISMATCH</unmanaged-short>
        GraphicsMcaMccsVersionMismatch = unchecked((System.Int32)(-1071241765)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MCA_UNSUPPORTED_MCCS_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MCA_UNSUPPORTED_MCCS_VERSION</unmanaged-short>
        GraphicsMcaUnsupportedMccsVersion = unchecked((System.Int32)(-1071241764)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED</unmanaged-short>
        GraphicsMcaInvalidTechnologyTypeReturned = unchecked((System.Int32)(-1071241762)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MCA_UNSUPPORTED_COLOR_TEMPERATURE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MCA_UNSUPPORTED_COLOR_TEMPERATURE</unmanaged-short>
        GraphicsMcaUnsupportedColorTemperature = unchecked((System.Int32)(-1071241761)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED</unmanaged-short>
        GraphicsOnlyConsoleSessionSupported = unchecked((System.Int32)(-1071241760)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME</unmanaged-short>
        GraphicsNoDisplayDeviceCorrespondsToName = unchecked((System.Int32)(-1071241759)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP</unmanaged-short>
        GraphicsDisplayDeviceNotAttachedToDesktop = unchecked((System.Int32)(-1071241758)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED</unmanaged-short>
        GraphicsMirroringDevicesNotSupported = unchecked((System.Int32)(-1071241757)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INVALID_POINTER</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INVALID_POINTER</unmanaged-short>
        GraphicsInvalidPointer = unchecked((System.Int32)(-1071241756)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE</unmanaged-short>
        GraphicsNoMonitorsCorrespondToDisplayDevice = unchecked((System.Int32)(-1071241755)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL</unmanaged-short>
        GraphicsParameterArrayTooSmall = unchecked((System.Int32)(-1071241754)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_INTERNAL_ERROR</unmanaged-short>
        GraphicsInternalError = unchecked((System.Int32)(-1071241753)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS</unmanaged-short>
        GraphicsSessionTypeChangeInProgress = unchecked((System.Int32)(-1071249944)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INTERFACE_CLOSING</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INTERFACE_CLOSING</unmanaged-short>
        NdisInterfaceClosing = unchecked((System.Int32)(-2144075774)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_BAD_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_BAD_VERSION</unmanaged-short>
        NdisBadVersion = unchecked((System.Int32)(-2144075772)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_BAD_CHARACTERISTICS</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_BAD_CHARACTERISTICS</unmanaged-short>
        NdisBadCharacteristics = unchecked((System.Int32)(-2144075771)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_ADAPTER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_ADAPTER_NOT_FOUND</unmanaged-short>
        NdisAdapterNotFound = unchecked((System.Int32)(-2144075770)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_OPEN_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_OPEN_FAILED</unmanaged-short>
        NdisOpenFailed = unchecked((System.Int32)(-2144075769)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_DEVICE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_DEVICE_FAILED</unmanaged-short>
        NdisDeviceFailed = unchecked((System.Int32)(-2144075768)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_MULTICAST_FULL</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_MULTICAST_FULL</unmanaged-short>
        NdisMulticastFull = unchecked((System.Int32)(-2144075767)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_MULTICAST_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_MULTICAST_EXISTS</unmanaged-short>
        NdisMulticastExists = unchecked((System.Int32)(-2144075766)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_MULTICAST_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_MULTICAST_NOT_FOUND</unmanaged-short>
        NdisMulticastNotFound = unchecked((System.Int32)(-2144075765)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_REQUEST_ABORTED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_REQUEST_ABORTED</unmanaged-short>
        NdisRequestAborted = unchecked((System.Int32)(-2144075764)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_RESET_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_RESET_IN_PROGRESS</unmanaged-short>
        NdisResetInProgress = unchecked((System.Int32)(-2144075763)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_NOT_SUPPORTED</unmanaged-short>
        NdisNotSupported = unchecked((System.Int32)(-2144075589)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INVALID_PACKET</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INVALID_PACKET</unmanaged-short>
        NdisInvalidPacket = unchecked((System.Int32)(-2144075761)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_ADAPTER_NOT_READY</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_ADAPTER_NOT_READY</unmanaged-short>
        NdisAdapterNotReady = unchecked((System.Int32)(-2144075759)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INVALID_LENGTH</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INVALID_LENGTH</unmanaged-short>
        NdisInvalidLength = unchecked((System.Int32)(-2144075756)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INVALID_DATA</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INVALID_DATA</unmanaged-short>
        NdisInvalidData = unchecked((System.Int32)(-2144075755)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_BUFFER_TOO_SHORT</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_BUFFER_TOO_SHORT</unmanaged-short>
        NdisBufferTooShort = unchecked((System.Int32)(-2144075754)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INVALID_OID</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INVALID_OID</unmanaged-short>
        NdisInvalidOid = unchecked((System.Int32)(-2144075753)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_ADAPTER_REMOVED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_ADAPTER_REMOVED</unmanaged-short>
        NdisAdapterRemoved = unchecked((System.Int32)(-2144075752)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_UNSUPPORTED_MEDIA</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_UNSUPPORTED_MEDIA</unmanaged-short>
        NdisUnsupportedMedia = unchecked((System.Int32)(-2144075751)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_GROUP_ADDRESS_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_GROUP_ADDRESS_IN_USE</unmanaged-short>
        NdisGroupAddressInUse = unchecked((System.Int32)(-2144075750)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_FILE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_FILE_NOT_FOUND</unmanaged-short>
        NdisFileNotFound = unchecked((System.Int32)(-2144075749)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_ERROR_READING_FILE</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_ERROR_READING_FILE</unmanaged-short>
        NdisErrorReadingFile = unchecked((System.Int32)(-2144075748)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_ALREADY_MAPPED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_ALREADY_MAPPED</unmanaged-short>
        NdisAlreadyMapped = unchecked((System.Int32)(-2144075747)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_RESOURCE_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_RESOURCE_CONFLICT</unmanaged-short>
        NdisResourceConflict = unchecked((System.Int32)(-2144075746)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_MEDIA_DISCONNECTED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_MEDIA_DISCONNECTED</unmanaged-short>
        NdisMediaDisconnected = unchecked((System.Int32)(-2144075745)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INVALID_ADDRESS</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INVALID_ADDRESS</unmanaged-short>
        NdisInvalidAddress = unchecked((System.Int32)(-2144075742)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INVALID_DEVICE_REQUEST</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INVALID_DEVICE_REQUEST</unmanaged-short>
        NdisInvalidDeviceRequest = unchecked((System.Int32)(-2144075760)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_PAUSED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_PAUSED</unmanaged-short>
        NdisPaused = unchecked((System.Int32)(-2144075734)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INTERFACE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INTERFACE_NOT_FOUND</unmanaged-short>
        NdisInterfaceNotFound = unchecked((System.Int32)(-2144075733)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_UNSUPPORTED_REVISION</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_UNSUPPORTED_REVISION</unmanaged-short>
        NdisUnsupportedRevision = unchecked((System.Int32)(-2144075732)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INVALID_PORT</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INVALID_PORT</unmanaged-short>
        NdisInvalidPort = unchecked((System.Int32)(-2144075731)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INVALID_PORT_STATE</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INVALID_PORT_STATE</unmanaged-short>
        NdisInvalidPortState = unchecked((System.Int32)(-2144075730)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_LOW_POWER_STATE</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_LOW_POWER_STATE</unmanaged-short>
        NdisLowPowerState = unchecked((System.Int32)(-2144075729)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_REINIT_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_REINIT_REQUIRED</unmanaged-short>
        NdisReinitRequired = unchecked((System.Int32)(-2144075728)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_NO_QUEUES</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_NO_QUEUES</unmanaged-short>
        NdisNoQueues = unchecked((System.Int32)(-2144075727)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_DOT11_AUTO_CONFIG_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_DOT11_AUTO_CONFIG_ENABLED</unmanaged-short>
        NdisDot11AutoConfigEnabled = unchecked((System.Int32)(-2144067584)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_DOT11_MEDIA_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_DOT11_MEDIA_IN_USE</unmanaged-short>
        NdisDot11MediaInUse = unchecked((System.Int32)(-2144067583)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_DOT11_POWER_STATE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_DOT11_POWER_STATE_INVALID</unmanaged-short>
        NdisDot11PowerStateInvalid = unchecked((System.Int32)(-2144067582)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_PM_WOL_PATTERN_LIST_FULL</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_PM_WOL_PATTERN_LIST_FULL</unmanaged-short>
        NdisPmWolPatternListFull = unchecked((System.Int32)(-2144067581)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL</unmanaged-short>
        NdisPmProtocolOffloadListFull = unchecked((System.Int32)(-2144067580)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE</unmanaged-short>
        NdisDot11ApChannelCurrentlyNotAvailable = unchecked((System.Int32)(-2144067579)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE</unmanaged-short>
        NdisDot11ApBandCurrentlyNotAvailable = unchecked((System.Int32)(-2144067578)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED</unmanaged-short>
        NdisDot11ApChannelNotAllowed = unchecked((System.Int32)(-2144067577)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_DOT11_AP_BAND_NOT_ALLOWED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_DOT11_AP_BAND_NOT_ALLOWED</unmanaged-short>
        NdisDot11ApBandNotAllowed = unchecked((System.Int32)(-2144067576)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_INDICATION_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_INDICATION_REQUIRED</unmanaged-short>
        NdisIndicationRequired = unchecked((System.Int32)(3407873)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_OFFLOAD_POLICY</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_OFFLOAD_POLICY</unmanaged-short>
        NdisOffloadPolicy = unchecked((System.Int32)(-1070329841)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_OFFLOAD_CONNECTION_REJECTED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_OFFLOAD_CONNECTION_REJECTED</unmanaged-short>
        NdisOffloadConnectionRejected = unchecked((System.Int32)(-1070329838)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NDIS_OFFLOAD_PATH_REJECTED</unmanaged>
        /// <unmanaged-short>ERROR_NDIS_OFFLOAD_PATH_REJECTED</unmanaged-short>
        NdisOffloadPathRejected = unchecked((System.Int32)(-1070329837)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_HYPERCALL_CODE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_HYPERCALL_CODE</unmanaged-short>
        HvInvalidHypercallCode = unchecked((System.Int32)(-1070268414)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_HYPERCALL_INPUT</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_HYPERCALL_INPUT</unmanaged-short>
        HvInvalidHypercallInput = unchecked((System.Int32)(-1070268413)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_ALIGNMENT</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_ALIGNMENT</unmanaged-short>
        HvInvalidAlignment = unchecked((System.Int32)(-1070268412)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_PARAMETER</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_PARAMETER</unmanaged-short>
        HvInvalidParameter = unchecked((System.Int32)(-1070268411)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_HV_ACCESS_DENIED</unmanaged-short>
        HvAccessDenied = unchecked((System.Int32)(-1070268410)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_PARTITION_STATE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_PARTITION_STATE</unmanaged-short>
        HvInvalidPartitionState = unchecked((System.Int32)(-1070268409)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_OPERATION_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_HV_OPERATION_DENIED</unmanaged-short>
        HvOperationDenied = unchecked((System.Int32)(-1070268408)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_UNKNOWN_PROPERTY</unmanaged>
        /// <unmanaged-short>ERROR_HV_UNKNOWN_PROPERTY</unmanaged-short>
        HvUnknownProperty = unchecked((System.Int32)(-1070268407)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_PROPERTY_VALUE_OUT_OF_RANGE</unmanaged>
        /// <unmanaged-short>ERROR_HV_PROPERTY_VALUE_OUT_OF_RANGE</unmanaged-short>
        HvPropertyValueOutOfRange = unchecked((System.Int32)(-1070268406)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INSUFFICIENT_MEMORY</unmanaged>
        /// <unmanaged-short>ERROR_HV_INSUFFICIENT_MEMORY</unmanaged-short>
        HvInsufficientMemory = unchecked((System.Int32)(-1070268405)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_PARTITION_TOO_DEEP</unmanaged>
        /// <unmanaged-short>ERROR_HV_PARTITION_TOO_DEEP</unmanaged-short>
        HvPartitionTooDeep = unchecked((System.Int32)(-1070268404)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_PARTITION_ID</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_PARTITION_ID</unmanaged-short>
        HvInvalidPartitionId = unchecked((System.Int32)(-1070268403)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_VP_INDEX</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_VP_INDEX</unmanaged-short>
        HvInvalidVpIndex = unchecked((System.Int32)(-1070268402)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_PORT_ID</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_PORT_ID</unmanaged-short>
        HvInvalidPortId = unchecked((System.Int32)(-1070268399)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_CONNECTION_ID</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_CONNECTION_ID</unmanaged-short>
        HvInvalidConnectionId = unchecked((System.Int32)(-1070268398)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INSUFFICIENT_BUFFERS</unmanaged>
        /// <unmanaged-short>ERROR_HV_INSUFFICIENT_BUFFERS</unmanaged-short>
        HvInsufficientBuffers = unchecked((System.Int32)(-1070268397)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_NOT_ACKNOWLEDGED</unmanaged>
        /// <unmanaged-short>ERROR_HV_NOT_ACKNOWLEDGED</unmanaged-short>
        HvNotAcknowledged = unchecked((System.Int32)(-1070268396)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_VP_STATE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_VP_STATE</unmanaged-short>
        HvInvalidVpState = unchecked((System.Int32)(-1070268395)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_ACKNOWLEDGED</unmanaged>
        /// <unmanaged-short>ERROR_HV_ACKNOWLEDGED</unmanaged-short>
        HvAcknowledged = unchecked((System.Int32)(-1070268394)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_SAVE_RESTORE_STATE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_SAVE_RESTORE_STATE</unmanaged-short>
        HvInvalidSaveRestoreState = unchecked((System.Int32)(-1070268393)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_SYNIC_STATE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_SYNIC_STATE</unmanaged-short>
        HvInvalidSynicState = unchecked((System.Int32)(-1070268392)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_OBJECT_IN_USE</unmanaged>
        /// <unmanaged-short>ERROR_HV_OBJECT_IN_USE</unmanaged-short>
        HvObjectInUse = unchecked((System.Int32)(-1070268391)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_PROXIMITY_DOMAIN_INFO</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_PROXIMITY_DOMAIN_INFO</unmanaged-short>
        HvInvalidProximityDomainInfo = unchecked((System.Int32)(-1070268390)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_NO_DATA</unmanaged>
        /// <unmanaged-short>ERROR_HV_NO_DATA</unmanaged-short>
        HvNoData = unchecked((System.Int32)(-1070268389)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INACTIVE</unmanaged-short>
        HvInactive = unchecked((System.Int32)(-1070268388)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_NO_RESOURCES</unmanaged>
        /// <unmanaged-short>ERROR_HV_NO_RESOURCES</unmanaged-short>
        HvNoResources = unchecked((System.Int32)(-1070268387)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_FEATURE_UNAVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_HV_FEATURE_UNAVAILABLE</unmanaged-short>
        HvFeatureUnavailable = unchecked((System.Int32)(-1070268386)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INSUFFICIENT_BUFFER</unmanaged>
        /// <unmanaged-short>ERROR_HV_INSUFFICIENT_BUFFER</unmanaged-short>
        HvInsufficientBuffer = unchecked((System.Int32)(-1070268365)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INSUFFICIENT_DEVICE_DOMAINS</unmanaged>
        /// <unmanaged-short>ERROR_HV_INSUFFICIENT_DEVICE_DOMAINS</unmanaged-short>
        HvInsufficientDeviceDomains = unchecked((System.Int32)(-1070268360)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_CPUID_FEATURE_VALIDATION</unmanaged>
        /// <unmanaged-short>ERROR_HV_CPUID_FEATURE_VALIDATION</unmanaged-short>
        HvCpuidFeatureValidation = unchecked((System.Int32)(-1070268356)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_CPUID_XSAVE_FEATURE_VALIDATION</unmanaged>
        /// <unmanaged-short>ERROR_HV_CPUID_XSAVE_FEATURE_VALIDATION</unmanaged-short>
        HvCpuidXsaveFeatureValidation = unchecked((System.Int32)(-1070268355)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_PROCESSOR_STARTUP_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_HV_PROCESSOR_STARTUP_TIMEOUT</unmanaged-short>
        HvProcessorStartupTimeout = unchecked((System.Int32)(-1070268354)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_SMX_ENABLED</unmanaged>
        /// <unmanaged-short>ERROR_HV_SMX_ENABLED</unmanaged-short>
        HvSmxEnabled = unchecked((System.Int32)(-1070268353)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_LP_INDEX</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_LP_INDEX</unmanaged-short>
        HvInvalidLpIndex = unchecked((System.Int32)(-1070268351)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_REGISTER_VALUE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_REGISTER_VALUE</unmanaged-short>
        HvInvalidRegisterValue = unchecked((System.Int32)(-1070268336)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_VTL_STATE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_VTL_STATE</unmanaged-short>
        HvInvalidVtlState = unchecked((System.Int32)(-1070268335)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_NX_NOT_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_HV_NX_NOT_DETECTED</unmanaged-short>
        HvNxNotDetected = unchecked((System.Int32)(-1070268331)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_DEVICE_ID</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_DEVICE_ID</unmanaged-short>
        HvInvalidDeviceId = unchecked((System.Int32)(-1070268329)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_DEVICE_STATE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_DEVICE_STATE</unmanaged-short>
        HvInvalidDeviceState = unchecked((System.Int32)(-1070268328)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_PENDING_PAGE_REQUESTS</unmanaged>
        /// <unmanaged-short>ERROR_HV_PENDING_PAGE_REQUESTS</unmanaged-short>
        HvPendingPageRequests = unchecked((System.Int32)(3473497)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_PAGE_REQUEST_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_HV_PAGE_REQUEST_INVALID</unmanaged-short>
        HvPageRequestInvalid = unchecked((System.Int32)(-1070268320)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_CPU_GROUP_ID</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_CPU_GROUP_ID</unmanaged-short>
        HvInvalidCpuGroupId = unchecked((System.Int32)(-1070268305)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INVALID_CPU_GROUP_STATE</unmanaged>
        /// <unmanaged-short>ERROR_HV_INVALID_CPU_GROUP_STATE</unmanaged-short>
        HvInvalidCpuGroupState = unchecked((System.Int32)(-1070268304)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_OPERATION_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_HV_OPERATION_FAILED</unmanaged-short>
        HvOperationFailed = unchecked((System.Int32)(-1070268303)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE</unmanaged-short>
        HvNotAllowedWithNestedVirtActive = unchecked((System.Int32)(-1070268302)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_INSUFFICIENT_ROOT_MEMORY</unmanaged>
        /// <unmanaged-short>ERROR_HV_INSUFFICIENT_ROOT_MEMORY</unmanaged-short>
        HvInsufficientRootMemory = unchecked((System.Int32)(-1070268301)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_HV_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_HV_NOT_PRESENT</unmanaged-short>
        HvNotPresent = unchecked((System.Int32)(-1070264320)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_DUPLICATE_HANDLER</unmanaged>
        /// <unmanaged-short>ERROR_VID_DUPLICATE_HANDLER</unmanaged-short>
        VidDuplicateHandler = unchecked((System.Int32)(-1070137343)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_TOO_MANY_HANDLERS</unmanaged>
        /// <unmanaged-short>ERROR_VID_TOO_MANY_HANDLERS</unmanaged-short>
        VidTooManyHandlers = unchecked((System.Int32)(-1070137342)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_QUEUE_FULL</unmanaged>
        /// <unmanaged-short>ERROR_VID_QUEUE_FULL</unmanaged-short>
        VidQueueFull = unchecked((System.Int32)(-1070137341)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_HANDLER_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_VID_HANDLER_NOT_PRESENT</unmanaged-short>
        VidHandlerNotPresent = unchecked((System.Int32)(-1070137340)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_OBJECT_NAME</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_OBJECT_NAME</unmanaged-short>
        VidInvalidObjectName = unchecked((System.Int32)(-1070137339)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_PARTITION_NAME_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_VID_PARTITION_NAME_TOO_LONG</unmanaged-short>
        VidPartitionNameTooLong = unchecked((System.Int32)(-1070137338)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MESSAGE_QUEUE_NAME_TOO_LONG</unmanaged>
        /// <unmanaged-short>ERROR_VID_MESSAGE_QUEUE_NAME_TOO_LONG</unmanaged-short>
        VidMessageQueueNameTooLong = unchecked((System.Int32)(-1070137337)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_PARTITION_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_VID_PARTITION_ALREADY_EXISTS</unmanaged-short>
        VidPartitionAlreadyExists = unchecked((System.Int32)(-1070137336)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_PARTITION_DOES_NOT_EXIST</unmanaged>
        /// <unmanaged-short>ERROR_VID_PARTITION_DOES_NOT_EXIST</unmanaged-short>
        VidPartitionDoesNotExist = unchecked((System.Int32)(-1070137335)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_PARTITION_NAME_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_VID_PARTITION_NAME_NOT_FOUND</unmanaged-short>
        VidPartitionNameNotFound = unchecked((System.Int32)(-1070137334)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MESSAGE_QUEUE_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_VID_MESSAGE_QUEUE_ALREADY_EXISTS</unmanaged-short>
        VidMessageQueueAlreadyExists = unchecked((System.Int32)(-1070137333)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT</unmanaged-short>
        VidExceededMbpEntryMapLimit = unchecked((System.Int32)(-1070137332)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MB_STILL_REFERENCED</unmanaged>
        /// <unmanaged-short>ERROR_VID_MB_STILL_REFERENCED</unmanaged-short>
        VidMbStillReferenced = unchecked((System.Int32)(-1070137331)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_CHILD_GPA_PAGE_SET_CORRUPTED</unmanaged>
        /// <unmanaged-short>ERROR_VID_CHILD_GPA_PAGE_SET_CORRUPTED</unmanaged-short>
        VidChildGpaPageSetCorrupted = unchecked((System.Int32)(-1070137330)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_NUMA_SETTINGS</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_NUMA_SETTINGS</unmanaged-short>
        VidInvalidNumaSettings = unchecked((System.Int32)(-1070137329)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_NUMA_NODE_INDEX</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_NUMA_NODE_INDEX</unmanaged-short>
        VidInvalidNumaNodeIndex = unchecked((System.Int32)(-1070137328)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED</unmanaged>
        /// <unmanaged-short>ERROR_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED</unmanaged-short>
        VidNotificationQueueAlreadyAssociated = unchecked((System.Int32)(-1070137327)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_MEMORY_BLOCK_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_MEMORY_BLOCK_HANDLE</unmanaged-short>
        VidInvalidMemoryBlockHandle = unchecked((System.Int32)(-1070137326)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_PAGE_RANGE_OVERFLOW</unmanaged>
        /// <unmanaged-short>ERROR_VID_PAGE_RANGE_OVERFLOW</unmanaged-short>
        VidPageRangeOverflow = unchecked((System.Int32)(-1070137325)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_MESSAGE_QUEUE_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_MESSAGE_QUEUE_HANDLE</unmanaged-short>
        VidInvalidMessageQueueHandle = unchecked((System.Int32)(-1070137324)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_GPA_RANGE_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_GPA_RANGE_HANDLE</unmanaged-short>
        VidInvalidGpaRangeHandle = unchecked((System.Int32)(-1070137323)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE</unmanaged>
        /// <unmanaged-short>ERROR_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE</unmanaged-short>
        VidNoMemoryBlockNotificationQueue = unchecked((System.Int32)(-1070137322)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED</unmanaged-short>
        VidMemoryBlockLockCountExceeded = unchecked((System.Int32)(-1070137321)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_PPM_HANDLE</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_PPM_HANDLE</unmanaged-short>
        VidInvalidPpmHandle = unchecked((System.Int32)(-1070137320)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MBPS_ARE_LOCKED</unmanaged>
        /// <unmanaged-short>ERROR_VID_MBPS_ARE_LOCKED</unmanaged-short>
        VidMbpsAreLocked = unchecked((System.Int32)(-1070137319)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MESSAGE_QUEUE_CLOSED</unmanaged>
        /// <unmanaged-short>ERROR_VID_MESSAGE_QUEUE_CLOSED</unmanaged-short>
        VidMessageQueueClosed = unchecked((System.Int32)(-1070137318)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED</unmanaged>
        /// <unmanaged-short>ERROR_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED</unmanaged-short>
        VidVirtualProcessorLimitExceeded = unchecked((System.Int32)(-1070137317)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_STOP_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_VID_STOP_PENDING</unmanaged-short>
        VidStopPending = unchecked((System.Int32)(-1070137316)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_PROCESSOR_STATE</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_PROCESSOR_STATE</unmanaged-short>
        VidInvalidProcessorState = unchecked((System.Int32)(-1070137315)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT</unmanaged-short>
        VidExceededKmContextCountLimit = unchecked((System.Int32)(-1070137314)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_KM_INTERFACE_ALREADY_INITIALIZED</unmanaged>
        /// <unmanaged-short>ERROR_VID_KM_INTERFACE_ALREADY_INITIALIZED</unmanaged-short>
        VidKmInterfaceAlreadyInitialized = unchecked((System.Int32)(-1070137313)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MB_PROPERTY_ALREADY_SET_RESET</unmanaged>
        /// <unmanaged-short>ERROR_VID_MB_PROPERTY_ALREADY_SET_RESET</unmanaged-short>
        VidMbPropertyAlreadySetReset = unchecked((System.Int32)(-1070137312)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MMIO_RANGE_DESTROYED</unmanaged>
        /// <unmanaged-short>ERROR_VID_MMIO_RANGE_DESTROYED</unmanaged-short>
        VidMmioRangeDestroyed = unchecked((System.Int32)(-1070137311)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_INVALID_CHILD_GPA_PAGE_SET</unmanaged>
        /// <unmanaged-short>ERROR_VID_INVALID_CHILD_GPA_PAGE_SET</unmanaged-short>
        VidInvalidChildGpaPageSet = unchecked((System.Int32)(-1070137310)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_RESERVE_PAGE_SET_IS_BEING_USED</unmanaged>
        /// <unmanaged-short>ERROR_VID_RESERVE_PAGE_SET_IS_BEING_USED</unmanaged-short>
        VidReservePageSetIsBeingUsed = unchecked((System.Int32)(-1070137309)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_RESERVE_PAGE_SET_TOO_SMALL</unmanaged>
        /// <unmanaged-short>ERROR_VID_RESERVE_PAGE_SET_TOO_SMALL</unmanaged-short>
        VidReservePageSetTooSmall = unchecked((System.Int32)(-1070137308)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE</unmanaged>
        /// <unmanaged-short>ERROR_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE</unmanaged-short>
        VidMbpAlreadyLockedUsingReservedPage = unchecked((System.Int32)(-1070137307)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_MBP_COUNT_EXCEEDED_LIMIT</unmanaged>
        /// <unmanaged-short>ERROR_VID_MBP_COUNT_EXCEEDED_LIMIT</unmanaged-short>
        VidMbpCountExceededLimit = unchecked((System.Int32)(-1070137306)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_SAVED_STATE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_VID_SAVED_STATE_CORRUPT</unmanaged-short>
        VidSavedStateCorrupt = unchecked((System.Int32)(-1070137305)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_SAVED_STATE_UNRECOGNIZED_ITEM</unmanaged>
        /// <unmanaged-short>ERROR_VID_SAVED_STATE_UNRECOGNIZED_ITEM</unmanaged-short>
        VidSavedStateUnrecognizedItem = unchecked((System.Int32)(-1070137304)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_SAVED_STATE_INCOMPATIBLE</unmanaged>
        /// <unmanaged-short>ERROR_VID_SAVED_STATE_INCOMPATIBLE</unmanaged-short>
        VidSavedStateIncompatible = unchecked((System.Int32)(-1070137303)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_VTL_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_VID_VTL_ACCESS_DENIED</unmanaged-short>
        VidVtlAccessDenied = unchecked((System.Int32)(-1070137302)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_TERMINATED_DURING_START</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_TERMINATED_DURING_START</unmanaged-short>
        VmcomputeTerminatedDuringStart = unchecked((System.Int32)(-1070137088)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_IMAGE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_IMAGE_MISMATCH</unmanaged-short>
        VmcomputeImageMismatch = unchecked((System.Int32)(-1070137087)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_HYPERV_NOT_INSTALLED</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_HYPERV_NOT_INSTALLED</unmanaged-short>
        VmcomputeHypervNotInstalled = unchecked((System.Int32)(-1070137086)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_OPERATION_PENDING</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_OPERATION_PENDING</unmanaged-short>
        VmcomputeOperationPending = unchecked((System.Int32)(-1070137085)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_TOO_MANY_NOTIFICATIONS</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_TOO_MANY_NOTIFICATIONS</unmanaged-short>
        VmcomputeTooManyNotifications = unchecked((System.Int32)(-1070137084)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_INVALID_STATE</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_INVALID_STATE</unmanaged-short>
        VmcomputeInvalidState = unchecked((System.Int32)(-1070137083)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_UNEXPECTED_EXIT</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_UNEXPECTED_EXIT</unmanaged-short>
        VmcomputeUnexpectedExit = unchecked((System.Int32)(-1070137082)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_TERMINATED</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_TERMINATED</unmanaged-short>
        VmcomputeTerminated = unchecked((System.Int32)(-1070137081)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_CONNECT_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_CONNECT_FAILED</unmanaged-short>
        VmcomputeConnectFailed = unchecked((System.Int32)(-1070137080)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_TIMEOUT</unmanaged-short>
        VmcomputeTimeout = unchecked((System.Int32)(-1070137079)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_CONNECTION_CLOSED</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_CONNECTION_CLOSED</unmanaged-short>
        VmcomputeConnectionClosed = unchecked((System.Int32)(-1070137078)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_UNKNOWN_MESSAGE</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_UNKNOWN_MESSAGE</unmanaged-short>
        VmcomputeUnknownMessage = unchecked((System.Int32)(-1070137077)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_UNSUPPORTED_PROTOCOL_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_UNSUPPORTED_PROTOCOL_VERSION</unmanaged-short>
        VmcomputeUnsupportedProtocolVersion = unchecked((System.Int32)(-1070137076)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_INVALID_JSON</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_INVALID_JSON</unmanaged-short>
        VmcomputeInvalidJson = unchecked((System.Int32)(-1070137075)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_SYSTEM_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_SYSTEM_NOT_FOUND</unmanaged-short>
        VmcomputeSystemNotFound = unchecked((System.Int32)(-1070137074)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_SYSTEM_ALREADY_EXISTS</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_SYSTEM_ALREADY_EXISTS</unmanaged-short>
        VmcomputeSystemAlreadyExists = unchecked((System.Int32)(-1070137073)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_SYSTEM_ALREADY_STOPPED</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_SYSTEM_ALREADY_STOPPED</unmanaged-short>
        VmcomputeSystemAlreadyStopped = unchecked((System.Int32)(-1070137072)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_PROTOCOL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_PROTOCOL_ERROR</unmanaged-short>
        VmcomputeProtocolError = unchecked((System.Int32)(-1070137071)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_INVALID_LAYER</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_INVALID_LAYER</unmanaged-short>
        VmcomputeInvalidLayer = unchecked((System.Int32)(-1070137070)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VMCOMPUTE_WINDOWS_INSIDER_REQUIRED</unmanaged>
        /// <unmanaged-short>ERROR_VMCOMPUTE_WINDOWS_INSIDER_REQUIRED</unmanaged-short>
        VmcomputeWindowsInsiderRequired = unchecked((System.Int32)(-1070137069)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VNET_VIRTUAL_SWITCH_NAME_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_VNET_VIRTUAL_SWITCH_NAME_NOT_FOUND</unmanaged-short>
        VnetVirtualSwitchNameNotFound = unchecked((System.Int32)(-1070136832)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED</unmanaged>
        /// <unmanaged-short>ERROR_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED</unmanaged-short>
        VidRemoteNodeParentGpaPagesUsed = unchecked((System.Int32)(-2143879167)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VSMB_SAVED_STATE_FILE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_VSMB_SAVED_STATE_FILE_NOT_FOUND</unmanaged-short>
        VsmbSavedStateFileNotFound = unchecked((System.Int32)(-1070136320)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VSMB_SAVED_STATE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_VSMB_SAVED_STATE_CORRUPT</unmanaged-short>
        VsmbSavedStateCorrupt = unchecked((System.Int32)(-1070136319)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_INCOMPLETE_REGENERATION</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_INCOMPLETE_REGENERATION</unmanaged-short>
        VolmgrIncompleteRegeneration = unchecked((System.Int32)(-2143813631)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_INCOMPLETE_DISK_MIGRATION</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_INCOMPLETE_DISK_MIGRATION</unmanaged-short>
        VolmgrIncompleteDiskMigration = unchecked((System.Int32)(-2143813630)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DATABASE_FULL</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DATABASE_FULL</unmanaged-short>
        VolmgrDatabaseFull = unchecked((System.Int32)(-1070071807)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_CONFIGURATION_CORRUPTED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_CONFIGURATION_CORRUPTED</unmanaged-short>
        VolmgrDiskConfigurationCorrupted = unchecked((System.Int32)(-1070071806)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC</unmanaged-short>
        VolmgrDiskConfigurationNotInSync = unchecked((System.Int32)(-1070071805)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_CONFIG_UPDATE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_CONFIG_UPDATE_FAILED</unmanaged-short>
        VolmgrPackConfigUpdateFailed = unchecked((System.Int32)(-1070071804)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME</unmanaged-short>
        VolmgrDiskContainsNonSimpleVolume = unchecked((System.Int32)(-1070071803)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_DUPLICATE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_DUPLICATE</unmanaged-short>
        VolmgrDiskDuplicate = unchecked((System.Int32)(-1070071802)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_DYNAMIC</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_DYNAMIC</unmanaged-short>
        VolmgrDiskDynamic = unchecked((System.Int32)(-1070071801)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_ID_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_ID_INVALID</unmanaged-short>
        VolmgrDiskIdInvalid = unchecked((System.Int32)(-1070071800)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_INVALID</unmanaged-short>
        VolmgrDiskInvalid = unchecked((System.Int32)(-1070071799)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_LAST_VOTER</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_LAST_VOTER</unmanaged-short>
        VolmgrDiskLastVoter = unchecked((System.Int32)(-1070071798)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_LAYOUT_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_LAYOUT_INVALID</unmanaged-short>
        VolmgrDiskLayoutInvalid = unchecked((System.Int32)(-1070071797)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS</unmanaged-short>
        VolmgrDiskLayoutNonBasicBetweenBasicPartitions = unchecked((System.Int32)(-1070071796)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED</unmanaged-short>
        VolmgrDiskLayoutNotCylinderAligned = unchecked((System.Int32)(-1070071795)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL</unmanaged-short>
        VolmgrDiskLayoutPartitionsTooSmall = unchecked((System.Int32)(-1070071794)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS</unmanaged-short>
        VolmgrDiskLayoutPrimaryBetweenLogicalPartitions = unchecked((System.Int32)(-1070071793)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS</unmanaged-short>
        VolmgrDiskLayoutTooManyPartitions = unchecked((System.Int32)(-1070071792)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_MISSING</unmanaged-short>
        VolmgrDiskMissing = unchecked((System.Int32)(-1070071791)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_NOT_EMPTY</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_NOT_EMPTY</unmanaged-short>
        VolmgrDiskNotEmpty = unchecked((System.Int32)(-1070071790)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_NOT_ENOUGH_SPACE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_NOT_ENOUGH_SPACE</unmanaged-short>
        VolmgrDiskNotEnoughSpace = unchecked((System.Int32)(-1070071789)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_REVECTORING_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_REVECTORING_FAILED</unmanaged-short>
        VolmgrDiskRevectoringFailed = unchecked((System.Int32)(-1070071788)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_SECTOR_SIZE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_SECTOR_SIZE_INVALID</unmanaged-short>
        VolmgrDiskSectorSizeInvalid = unchecked((System.Int32)(-1070071787)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_SET_NOT_CONTAINED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_SET_NOT_CONTAINED</unmanaged-short>
        VolmgrDiskSetNotContained = unchecked((System.Int32)(-1070071786)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS</unmanaged-short>
        VolmgrDiskUsedByMultipleMembers = unchecked((System.Int32)(-1070071785)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES</unmanaged-short>
        VolmgrDiskUsedByMultiplePlexes = unchecked((System.Int32)(-1070071784)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED</unmanaged-short>
        VolmgrDynamicDiskNotSupported = unchecked((System.Int32)(-1070071783)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_EXTENT_ALREADY_USED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_EXTENT_ALREADY_USED</unmanaged-short>
        VolmgrExtentAlreadyUsed = unchecked((System.Int32)(-1070071782)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_EXTENT_NOT_CONTIGUOUS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_EXTENT_NOT_CONTIGUOUS</unmanaged-short>
        VolmgrExtentNotContiguous = unchecked((System.Int32)(-1070071781)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION</unmanaged-short>
        VolmgrExtentNotInPublicRegion = unchecked((System.Int32)(-1070071780)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED</unmanaged-short>
        VolmgrExtentNotSectorAligned = unchecked((System.Int32)(-1070071779)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION</unmanaged-short>
        VolmgrExtentOverlapsEbrPartition = unchecked((System.Int32)(-1070071778)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH</unmanaged-short>
        VolmgrExtentVolumeLengthsDoNotMatch = unchecked((System.Int32)(-1070071777)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED</unmanaged-short>
        VolmgrFaultTolerantNotSupported = unchecked((System.Int32)(-1070071776)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_INTERLEAVE_LENGTH_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_INTERLEAVE_LENGTH_INVALID</unmanaged-short>
        VolmgrInterleaveLengthInvalid = unchecked((System.Int32)(-1070071775)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_MAXIMUM_REGISTERED_USERS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_MAXIMUM_REGISTERED_USERS</unmanaged-short>
        VolmgrMaximumRegisteredUsers = unchecked((System.Int32)(-1070071774)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_MEMBER_IN_SYNC</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_MEMBER_IN_SYNC</unmanaged-short>
        VolmgrMemberInSync = unchecked((System.Int32)(-1070071773)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_MEMBER_INDEX_DUPLICATE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_MEMBER_INDEX_DUPLICATE</unmanaged-short>
        VolmgrMemberIndexDuplicate = unchecked((System.Int32)(-1070071772)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_MEMBER_INDEX_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_MEMBER_INDEX_INVALID</unmanaged-short>
        VolmgrMemberIndexInvalid = unchecked((System.Int32)(-1070071771)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_MEMBER_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_MEMBER_MISSING</unmanaged-short>
        VolmgrMemberMissing = unchecked((System.Int32)(-1070071770)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_MEMBER_NOT_DETACHED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_MEMBER_NOT_DETACHED</unmanaged-short>
        VolmgrMemberNotDetached = unchecked((System.Int32)(-1070071769)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_MEMBER_REGENERATING</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_MEMBER_REGENERATING</unmanaged-short>
        VolmgrMemberRegenerating = unchecked((System.Int32)(-1070071768)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_ALL_DISKS_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_ALL_DISKS_FAILED</unmanaged-short>
        VolmgrAllDisksFailed = unchecked((System.Int32)(-1070071767)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NO_REGISTERED_USERS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NO_REGISTERED_USERS</unmanaged-short>
        VolmgrNoRegisteredUsers = unchecked((System.Int32)(-1070071766)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NO_SUCH_USER</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NO_SUCH_USER</unmanaged-short>
        VolmgrNoSuchUser = unchecked((System.Int32)(-1070071765)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NOTIFICATION_RESET</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NOTIFICATION_RESET</unmanaged-short>
        VolmgrNotificationReset = unchecked((System.Int32)(-1070071764)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NUMBER_OF_MEMBERS_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NUMBER_OF_MEMBERS_INVALID</unmanaged-short>
        VolmgrNumberOfMembersInvalid = unchecked((System.Int32)(-1070071763)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NUMBER_OF_PLEXES_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NUMBER_OF_PLEXES_INVALID</unmanaged-short>
        VolmgrNumberOfPlexesInvalid = unchecked((System.Int32)(-1070071762)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_DUPLICATE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_DUPLICATE</unmanaged-short>
        VolmgrPackDuplicate = unchecked((System.Int32)(-1070071761)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_ID_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_ID_INVALID</unmanaged-short>
        VolmgrPackIdInvalid = unchecked((System.Int32)(-1070071760)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_INVALID</unmanaged-short>
        VolmgrPackInvalid = unchecked((System.Int32)(-1070071759)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_NAME_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_NAME_INVALID</unmanaged-short>
        VolmgrPackNameInvalid = unchecked((System.Int32)(-1070071758)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_OFFLINE</unmanaged-short>
        VolmgrPackOffline = unchecked((System.Int32)(-1070071757)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_HAS_QUORUM</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_HAS_QUORUM</unmanaged-short>
        VolmgrPackHasQuorum = unchecked((System.Int32)(-1070071756)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_WITHOUT_QUORUM</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_WITHOUT_QUORUM</unmanaged-short>
        VolmgrPackWithoutQuorum = unchecked((System.Int32)(-1070071755)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PARTITION_STYLE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PARTITION_STYLE_INVALID</unmanaged-short>
        VolmgrPartitionStyleInvalid = unchecked((System.Int32)(-1070071754)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PARTITION_UPDATE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PARTITION_UPDATE_FAILED</unmanaged-short>
        VolmgrPartitionUpdateFailed = unchecked((System.Int32)(-1070071753)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_IN_SYNC</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_IN_SYNC</unmanaged-short>
        VolmgrPlexInSync = unchecked((System.Int32)(-1070071752)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_INDEX_DUPLICATE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_INDEX_DUPLICATE</unmanaged-short>
        VolmgrPlexIndexDuplicate = unchecked((System.Int32)(-1070071751)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_INDEX_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_INDEX_INVALID</unmanaged-short>
        VolmgrPlexIndexInvalid = unchecked((System.Int32)(-1070071750)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_LAST_ACTIVE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_LAST_ACTIVE</unmanaged-short>
        VolmgrPlexLastActive = unchecked((System.Int32)(-1070071749)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_MISSING</unmanaged-short>
        VolmgrPlexMissing = unchecked((System.Int32)(-1070071748)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_REGENERATING</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_REGENERATING</unmanaged-short>
        VolmgrPlexRegenerating = unchecked((System.Int32)(-1070071747)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_TYPE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_TYPE_INVALID</unmanaged-short>
        VolmgrPlexTypeInvalid = unchecked((System.Int32)(-1070071746)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_NOT_RAID5</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_NOT_RAID5</unmanaged-short>
        VolmgrPlexNotRaid5 = unchecked((System.Int32)(-1070071745)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_NOT_SIMPLE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_NOT_SIMPLE</unmanaged-short>
        VolmgrPlexNotSimple = unchecked((System.Int32)(-1070071744)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_STRUCTURE_SIZE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_STRUCTURE_SIZE_INVALID</unmanaged-short>
        VolmgrStructureSizeInvalid = unchecked((System.Int32)(-1070071743)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS</unmanaged-short>
        VolmgrTooManyNotificationRequests = unchecked((System.Int32)(-1070071742)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_TRANSACTION_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_TRANSACTION_IN_PROGRESS</unmanaged-short>
        VolmgrTransactionInProgress = unchecked((System.Int32)(-1070071741)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE</unmanaged-short>
        VolmgrUnexpectedDiskLayoutChange = unchecked((System.Int32)(-1070071740)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_CONTAINS_MISSING_DISK</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_CONTAINS_MISSING_DISK</unmanaged-short>
        VolmgrVolumeContainsMissingDisk = unchecked((System.Int32)(-1070071739)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_ID_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_ID_INVALID</unmanaged-short>
        VolmgrVolumeIdInvalid = unchecked((System.Int32)(-1070071738)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_LENGTH_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_LENGTH_INVALID</unmanaged-short>
        VolmgrVolumeLengthInvalid = unchecked((System.Int32)(-1070071737)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE</unmanaged-short>
        VolmgrVolumeLengthNotSectorSizeMultiple = unchecked((System.Int32)(-1070071736)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_NOT_MIRRORED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_NOT_MIRRORED</unmanaged-short>
        VolmgrVolumeNotMirrored = unchecked((System.Int32)(-1070071735)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_NOT_RETAINED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_NOT_RETAINED</unmanaged-short>
        VolmgrVolumeNotRetained = unchecked((System.Int32)(-1070071734)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_OFFLINE</unmanaged-short>
        VolmgrVolumeOffline = unchecked((System.Int32)(-1070071733)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_RETAINED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_RETAINED</unmanaged-short>
        VolmgrVolumeRetained = unchecked((System.Int32)(-1070071732)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NUMBER_OF_EXTENTS_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NUMBER_OF_EXTENTS_INVALID</unmanaged-short>
        VolmgrNumberOfExtentsInvalid = unchecked((System.Int32)(-1070071731)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_DIFFERENT_SECTOR_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_DIFFERENT_SECTOR_SIZE</unmanaged-short>
        VolmgrDifferentSectorSize = unchecked((System.Int32)(-1070071730)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_BAD_BOOT_DISK</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_BAD_BOOT_DISK</unmanaged-short>
        VolmgrBadBootDisk = unchecked((System.Int32)(-1070071729)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_CONFIG_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_CONFIG_OFFLINE</unmanaged-short>
        VolmgrPackConfigOffline = unchecked((System.Int32)(-1070071728)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_CONFIG_ONLINE</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_CONFIG_ONLINE</unmanaged-short>
        VolmgrPackConfigOnline = unchecked((System.Int32)(-1070071727)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NOT_PRIMARY_PACK</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NOT_PRIMARY_PACK</unmanaged-short>
        VolmgrNotPrimaryPack = unchecked((System.Int32)(-1070071726)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PACK_LOG_UPDATE_FAILED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PACK_LOG_UPDATE_FAILED</unmanaged-short>
        VolmgrPackLogUpdateFailed = unchecked((System.Int32)(-1070071725)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID</unmanaged-short>
        VolmgrNumberOfDisksInPlexInvalid = unchecked((System.Int32)(-1070071724)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID</unmanaged-short>
        VolmgrNumberOfDisksInMemberInvalid = unchecked((System.Int32)(-1070071723)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_VOLUME_MIRRORED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_VOLUME_MIRRORED</unmanaged-short>
        VolmgrVolumeMirrored = unchecked((System.Int32)(-1070071722)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PLEX_NOT_SIMPLE_SPANNED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PLEX_NOT_SIMPLE_SPANNED</unmanaged-short>
        VolmgrPlexNotSimpleSpanned = unchecked((System.Int32)(-1070071721)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NO_VALID_LOG_COPIES</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NO_VALID_LOG_COPIES</unmanaged-short>
        VolmgrNoValidLogCopies = unchecked((System.Int32)(-1070071720)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_PRIMARY_PACK_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_PRIMARY_PACK_PRESENT</unmanaged-short>
        VolmgrPrimaryPackPresent = unchecked((System.Int32)(-1070071719)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_NUMBER_OF_DISKS_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_NUMBER_OF_DISKS_INVALID</unmanaged-short>
        VolmgrNumberOfDisksInvalid = unchecked((System.Int32)(-1070071718)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_MIRROR_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_MIRROR_NOT_SUPPORTED</unmanaged-short>
        VolmgrMirrorNotSupported = unchecked((System.Int32)(-1070071717)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLMGR_RAID5_NOT_SUPPORTED</unmanaged>
        /// <unmanaged-short>ERROR_VOLMGR_RAID5_NOT_SUPPORTED</unmanaged-short>
        VolmgrRaid5NotSupported = unchecked((System.Int32)(-1070071716)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BCD_NOT_ALL_ENTRIES_IMPORTED</unmanaged>
        /// <unmanaged-short>ERROR_BCD_NOT_ALL_ENTRIES_IMPORTED</unmanaged-short>
        BcdNotAllEntriesImported = unchecked((System.Int32)(-2143748095)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BCD_TOO_MANY_ELEMENTS</unmanaged>
        /// <unmanaged-short>ERROR_BCD_TOO_MANY_ELEMENTS</unmanaged-short>
        BcdTooManyElements = unchecked((System.Int32)(-1070006270)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED</unmanaged>
        /// <unmanaged-short>ERROR_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED</unmanaged-short>
        BcdNotAllEntriesSynchronized = unchecked((System.Int32)(-2143748093)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_DRIVE_FOOTER_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_VHD_DRIVE_FOOTER_MISSING</unmanaged-short>
        VhdDriveFooterMissing = unchecked((System.Int32)(-1069940735)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH</unmanaged-short>
        VhdDriveFooterChecksumMismatch = unchecked((System.Int32)(-1069940734)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_DRIVE_FOOTER_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_VHD_DRIVE_FOOTER_CORRUPT</unmanaged-short>
        VhdDriveFooterCorrupt = unchecked((System.Int32)(-1069940733)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_FORMAT_UNKNOWN</unmanaged>
        /// <unmanaged-short>ERROR_VHD_FORMAT_UNKNOWN</unmanaged-short>
        VhdFormatUnknown = unchecked((System.Int32)(-1069940732)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_FORMAT_UNSUPPORTED_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_VHD_FORMAT_UNSUPPORTED_VERSION</unmanaged-short>
        VhdFormatUnsupportedVersion = unchecked((System.Int32)(-1069940731)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH</unmanaged-short>
        VhdSparseHeaderChecksumMismatch = unchecked((System.Int32)(-1069940730)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION</unmanaged>
        /// <unmanaged-short>ERROR_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION</unmanaged-short>
        VhdSparseHeaderUnsupportedVersion = unchecked((System.Int32)(-1069940729)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_SPARSE_HEADER_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_VHD_SPARSE_HEADER_CORRUPT</unmanaged-short>
        VhdSparseHeaderCorrupt = unchecked((System.Int32)(-1069940728)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_BLOCK_ALLOCATION_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_BLOCK_ALLOCATION_FAILURE</unmanaged-short>
        VhdBlockAllocationFailure = unchecked((System.Int32)(-1069940727)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT</unmanaged>
        /// <unmanaged-short>ERROR_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT</unmanaged-short>
        VhdBlockAllocationTableCorrupt = unchecked((System.Int32)(-1069940726)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_INVALID_BLOCK_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_INVALID_BLOCK_SIZE</unmanaged-short>
        VhdInvalidBlockSize = unchecked((System.Int32)(-1069940725)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_BITMAP_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_VHD_BITMAP_MISMATCH</unmanaged-short>
        VhdBitmapMismatch = unchecked((System.Int32)(-1069940724)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_PARENT_VHD_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_VHD_PARENT_VHD_NOT_FOUND</unmanaged-short>
        VhdParentVhdNotFound = unchecked((System.Int32)(-1069940723)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_CHILD_PARENT_ID_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_VHD_CHILD_PARENT_ID_MISMATCH</unmanaged-short>
        VhdChildParentIdMismatch = unchecked((System.Int32)(-1069940722)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH</unmanaged-short>
        VhdChildParentTimestampMismatch = unchecked((System.Int32)(-1069940721)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_METADATA_READ_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_METADATA_READ_FAILURE</unmanaged-short>
        VhdMetadataReadFailure = unchecked((System.Int32)(-1069940720)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_METADATA_WRITE_FAILURE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_METADATA_WRITE_FAILURE</unmanaged-short>
        VhdMetadataWriteFailure = unchecked((System.Int32)(-1069940719)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_INVALID_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_INVALID_SIZE</unmanaged-short>
        VhdInvalidSize = unchecked((System.Int32)(-1069940718)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_INVALID_FILE_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_INVALID_FILE_SIZE</unmanaged-short>
        VhdInvalidFileSize = unchecked((System.Int32)(-1069940717)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VIRTDISK_PROVIDER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_VIRTDISK_PROVIDER_NOT_FOUND</unmanaged-short>
        VirtdiskProviderNotFound = unchecked((System.Int32)(-1069940716)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VIRTDISK_NOT_VIRTUAL_DISK</unmanaged>
        /// <unmanaged-short>ERROR_VIRTDISK_NOT_VIRTUAL_DISK</unmanaged-short>
        VirtdiskNotVirtualDisk = unchecked((System.Int32)(-1069940715)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_PARENT_VHD_ACCESS_DENIED</unmanaged>
        /// <unmanaged-short>ERROR_VHD_PARENT_VHD_ACCESS_DENIED</unmanaged-short>
        VhdParentVhdAccessDenied = unchecked((System.Int32)(-1069940714)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_CHILD_PARENT_SIZE_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_VHD_CHILD_PARENT_SIZE_MISMATCH</unmanaged-short>
        VhdChildParentSizeMismatch = unchecked((System.Int32)(-1069940713)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED</unmanaged>
        /// <unmanaged-short>ERROR_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED</unmanaged-short>
        VhdDifferencingChainCycleDetected = unchecked((System.Int32)(-1069940712)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT</unmanaged>
        /// <unmanaged-short>ERROR_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT</unmanaged-short>
        VhdDifferencingChainErrorInParent = unchecked((System.Int32)(-1069940711)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VIRTUAL_DISK_LIMITATION</unmanaged>
        /// <unmanaged-short>ERROR_VIRTUAL_DISK_LIMITATION</unmanaged-short>
        VirtualDiskLimitation = unchecked((System.Int32)(-1069940710)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_INVALID_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_INVALID_TYPE</unmanaged-short>
        VhdInvalidType = unchecked((System.Int32)(-1069940709)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_INVALID_STATE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_INVALID_STATE</unmanaged-short>
        VhdInvalidState = unchecked((System.Int32)(-1069940708)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE</unmanaged-short>
        VirtdiskUnsupportedDiskSectorSize = unchecked((System.Int32)(-1069940707)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VIRTDISK_DISK_ALREADY_OWNED</unmanaged>
        /// <unmanaged-short>ERROR_VIRTDISK_DISK_ALREADY_OWNED</unmanaged-short>
        VirtdiskDiskAlreadyOwned = unchecked((System.Int32)(-1069940706)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VIRTDISK_DISK_ONLINE_AND_WRITABLE</unmanaged>
        /// <unmanaged-short>ERROR_VIRTDISK_DISK_ONLINE_AND_WRITABLE</unmanaged-short>
        VirtdiskDiskOnlineAndWritable = unchecked((System.Int32)(-1069940705)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTLOG_TRACKING_NOT_INITIALIZED</unmanaged>
        /// <unmanaged-short>ERROR_CTLOG_TRACKING_NOT_INITIALIZED</unmanaged-short>
        CtlogTrackingNotInitialized = unchecked((System.Int32)(-1069940704)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE</unmanaged>
        /// <unmanaged-short>ERROR_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE</unmanaged-short>
        CtlogLogfileSizeExceededMaxsize = unchecked((System.Int32)(-1069940703)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTLOG_VHD_CHANGED_OFFLINE</unmanaged>
        /// <unmanaged-short>ERROR_CTLOG_VHD_CHANGED_OFFLINE</unmanaged-short>
        CtlogVhdChangedOffline = unchecked((System.Int32)(-1069940702)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTLOG_INVALID_TRACKING_STATE</unmanaged>
        /// <unmanaged-short>ERROR_CTLOG_INVALID_TRACKING_STATE</unmanaged-short>
        CtlogInvalidTrackingState = unchecked((System.Int32)(-1069940701)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CTLOG_INCONSISTENT_TRACKING_FILE</unmanaged>
        /// <unmanaged-short>ERROR_CTLOG_INCONSISTENT_TRACKING_FILE</unmanaged-short>
        CtlogInconsistentTrackingFile = unchecked((System.Int32)(-1069940700)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_RESIZE_WOULD_TRUNCATE_DATA</unmanaged>
        /// <unmanaged-short>ERROR_VHD_RESIZE_WOULD_TRUNCATE_DATA</unmanaged-short>
        VhdResizeWouldTruncateData = unchecked((System.Int32)(-1069940699)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE</unmanaged-short>
        VhdCouldNotComputeMinimumVirtualSize = unchecked((System.Int32)(-1069940698)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE</unmanaged>
        /// <unmanaged-short>ERROR_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE</unmanaged-short>
        VhdAlreadyAtOrBelowMinimumVirtualSize = unchecked((System.Int32)(-1069940697)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_METADATA_FULL</unmanaged>
        /// <unmanaged-short>ERROR_VHD_METADATA_FULL</unmanaged-short>
        VhdMetadataFull = unchecked((System.Int32)(-1069940696)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_INVALID_CHANGE_TRACKING_ID</unmanaged>
        /// <unmanaged-short>ERROR_VHD_INVALID_CHANGE_TRACKING_ID</unmanaged-short>
        VhdInvalidChangeTrackingId = unchecked((System.Int32)(-1069940695)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_CHANGE_TRACKING_DISABLED</unmanaged>
        /// <unmanaged-short>ERROR_VHD_CHANGE_TRACKING_DISABLED</unmanaged-short>
        VhdChangeTrackingDisabled = unchecked((System.Int32)(-1069940694)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_MISSING_CHANGE_TRACKING_INFORMATION</unmanaged>
        /// <unmanaged-short>ERROR_VHD_MISSING_CHANGE_TRACKING_INFORMATION</unmanaged-short>
        VhdMissingChangeTrackingInformation = unchecked((System.Int32)(-1069940688)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_QUERY_STORAGE_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_QUERY_STORAGE_ERROR</unmanaged-short>
        QueryStorageError = unchecked((System.Int32)(-2143682559)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_POOL_WAS_DELETED</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_POOL_WAS_DELETED</unmanaged-short>
        SpacesPoolWasDeleted = unchecked((System.Int32)(15138817)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_FAULT_DOMAIN_TYPE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_FAULT_DOMAIN_TYPE_INVALID</unmanaged-short>
        SpacesFaultDomainTypeInvalid = unchecked((System.Int32)(-2132344831)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_INTERNAL_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_INTERNAL_ERROR</unmanaged-short>
        SpacesInternalError = unchecked((System.Int32)(-2132344830)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_RESILIENCY_TYPE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_RESILIENCY_TYPE_INVALID</unmanaged-short>
        SpacesResiliencyTypeInvalid = unchecked((System.Int32)(-2132344829)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_DRIVE_SECTOR_SIZE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_DRIVE_SECTOR_SIZE_INVALID</unmanaged-short>
        SpacesDriveSectorSizeInvalid = unchecked((System.Int32)(-2132344828)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_DRIVE_REDUNDANCY_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_DRIVE_REDUNDANCY_INVALID</unmanaged-short>
        SpacesDriveRedundancyInvalid = unchecked((System.Int32)(-2132344826)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_NUMBER_OF_DATA_COPIES_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_NUMBER_OF_DATA_COPIES_INVALID</unmanaged-short>
        SpacesNumberOfDataCopiesInvalid = unchecked((System.Int32)(-2132344825)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_PARITY_LAYOUT_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_PARITY_LAYOUT_INVALID</unmanaged-short>
        SpacesParityLayoutInvalid = unchecked((System.Int32)(-2132344824)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_INTERLEAVE_LENGTH_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_INTERLEAVE_LENGTH_INVALID</unmanaged-short>
        SpacesInterleaveLengthInvalid = unchecked((System.Int32)(-2132344823)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_NUMBER_OF_COLUMNS_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_NUMBER_OF_COLUMNS_INVALID</unmanaged-short>
        SpacesNumberOfColumnsInvalid = unchecked((System.Int32)(-2132344822)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_NOT_ENOUGH_DRIVES</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_NOT_ENOUGH_DRIVES</unmanaged-short>
        SpacesNotEnoughDrives = unchecked((System.Int32)(-2132344821)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_EXTENDED_ERROR</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_EXTENDED_ERROR</unmanaged-short>
        SpacesExtendedError = unchecked((System.Int32)(-2132344820)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_PROVISIONING_TYPE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_PROVISIONING_TYPE_INVALID</unmanaged-short>
        SpacesProvisioningTypeInvalid = unchecked((System.Int32)(-2132344819)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_ALLOCATION_SIZE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_ALLOCATION_SIZE_INVALID</unmanaged-short>
        SpacesAllocationSizeInvalid = unchecked((System.Int32)(-2132344818)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_ENCLOSURE_AWARE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_ENCLOSURE_AWARE_INVALID</unmanaged-short>
        SpacesEnclosureAwareInvalid = unchecked((System.Int32)(-2132344817)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_WRITE_CACHE_SIZE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_WRITE_CACHE_SIZE_INVALID</unmanaged-short>
        SpacesWriteCacheSizeInvalid = unchecked((System.Int32)(-2132344816)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_NUMBER_OF_GROUPS_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_NUMBER_OF_GROUPS_INVALID</unmanaged-short>
        SpacesNumberOfGroupsInvalid = unchecked((System.Int32)(-2132344815)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_DRIVE_OPERATIONAL_STATE_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_DRIVE_OPERATIONAL_STATE_INVALID</unmanaged-short>
        SpacesDriveOperationalStateInvalid = unchecked((System.Int32)(-2132344814)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_ENTRY_INCOMPLETE</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_ENTRY_INCOMPLETE</unmanaged-short>
        SpacesEntryIncomplete = unchecked((System.Int32)(-2132344813)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SPACES_ENTRY_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_SPACES_ENTRY_INVALID</unmanaged-short>
        SpacesEntryInvalid = unchecked((System.Int32)(-2132344812)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLSNAP_BOOTFILE_NOT_VALID</unmanaged>
        /// <unmanaged-short>ERROR_VOLSNAP_BOOTFILE_NOT_VALID</unmanaged-short>
        VolsnapBootfileNotValid = unchecked((System.Int32)(-2138963967)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VOLSNAP_ACTIVATION_TIMEOUT</unmanaged>
        /// <unmanaged-short>ERROR_VOLSNAP_ACTIVATION_TIMEOUT</unmanaged-short>
        VolsnapActivationTimeout = unchecked((System.Int32)(-2138963966)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIERING_NOT_SUPPORTED_ON_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_TIERING_NOT_SUPPORTED_ON_VOLUME</unmanaged-short>
        TieringNotSupportedOnVolume = unchecked((System.Int32)(-2138898431)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIERING_VOLUME_DISMOUNT_IN_PROGRESS</unmanaged>
        /// <unmanaged-short>ERROR_TIERING_VOLUME_DISMOUNT_IN_PROGRESS</unmanaged-short>
        TieringVolumeDismountInProgress = unchecked((System.Int32)(-2138898430)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIERING_STORAGE_TIER_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_TIERING_STORAGE_TIER_NOT_FOUND</unmanaged-short>
        TieringStorageTierNotFound = unchecked((System.Int32)(-2138898429)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIERING_INVALID_FILE_ID</unmanaged>
        /// <unmanaged-short>ERROR_TIERING_INVALID_FILE_ID</unmanaged-short>
        TieringInvalidFileId = unchecked((System.Int32)(-2138898428)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIERING_WRONG_CLUSTER_NODE</unmanaged>
        /// <unmanaged-short>ERROR_TIERING_WRONG_CLUSTER_NODE</unmanaged-short>
        TieringWrongClusterNode = unchecked((System.Int32)(-2138898427)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIERING_ALREADY_PROCESSING</unmanaged>
        /// <unmanaged-short>ERROR_TIERING_ALREADY_PROCESSING</unmanaged-short>
        TieringAlreadyProcessing = unchecked((System.Int32)(-2138898426)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIERING_CANNOT_PIN_OBJECT</unmanaged>
        /// <unmanaged-short>ERROR_TIERING_CANNOT_PIN_OBJECT</unmanaged-short>
        TieringCannotPinObject = unchecked((System.Int32)(-2138898425)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_TIERING_FILE_IS_NOT_PINNED</unmanaged>
        /// <unmanaged-short>ERROR_TIERING_FILE_IS_NOT_PINNED</unmanaged-short>
        TieringFileIsNotPinned = unchecked((System.Int32)(-2138898424)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NOT_A_TIERED_VOLUME</unmanaged>
        /// <unmanaged-short>ERROR_NOT_A_TIERED_VOLUME</unmanaged-short>
        NotATieredVolume = unchecked((System.Int32)(-2138898423)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_ATTRIBUTE_NOT_PRESENT</unmanaged>
        /// <unmanaged-short>ERROR_ATTRIBUTE_NOT_PRESENT</unmanaged-short>
        AttributeNotPresent = unchecked((System.Int32)(-2138898422)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SECCORE_INVALID_COMMAND</unmanaged>
        /// <unmanaged-short>ERROR_SECCORE_INVALID_COMMAND</unmanaged-short>
        SeccoreInvalidCommand = unchecked((System.Int32)(-1058537472)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_NO_APPLICABLE_APP_LICENSES_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_NO_APPLICABLE_APP_LICENSES_FOUND</unmanaged-short>
        NoApplicableAppLicensesFound = unchecked((System.Int32)(-1058406399)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_LICENSE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_LICENSE_NOT_FOUND</unmanaged-short>
        ClipLicenseNotFound = unchecked((System.Int32)(-1058406398)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_DEVICE_LICENSE_MISSING</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_DEVICE_LICENSE_MISSING</unmanaged-short>
        ClipDeviceLicenseMissing = unchecked((System.Int32)(-1058406397)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_LICENSE_INVALID_SIGNATURE</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_LICENSE_INVALID_SIGNATURE</unmanaged-short>
        ClipLicenseInvalidSignature = unchecked((System.Int32)(-1058406396)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID</unmanaged-short>
        ClipKeyholderLicenseMissingOrInvalid = unchecked((System.Int32)(-1058406395)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_LICENSE_EXPIRED</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_LICENSE_EXPIRED</unmanaged-short>
        ClipLicenseExpired = unchecked((System.Int32)(-1058406394)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE</unmanaged-short>
        ClipLicenseSignedByUnknownSource = unchecked((System.Int32)(-1058406393)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_LICENSE_NOT_SIGNED</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_LICENSE_NOT_SIGNED</unmanaged-short>
        ClipLicenseNotSigned = unchecked((System.Int32)(-1058406392)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE</unmanaged-short>
        ClipLicenseHardwareIdOutOfTolerance = unchecked((System.Int32)(-1058406391)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_CLIP_LICENSE_DEVICE_ID_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_CLIP_LICENSE_DEVICE_ID_MISMATCH</unmanaged-short>
        ClipLicenseDeviceIdMismatch = unchecked((System.Int32)(-1058406390)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_CREATE_PROCESS_FAILURE_LOCKDOWN</unmanaged>
        /// <unmanaged-short>ERROR_DBG_CREATE_PROCESS_FAILURE_LOCKDOWN</unmanaged-short>
        DbgCreateProcessFailureLockdown = unchecked((System.Int32)(-2135949311)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_ATTACH_PROCESS_FAILURE_LOCKDOWN</unmanaged>
        /// <unmanaged-short>ERROR_DBG_ATTACH_PROCESS_FAILURE_LOCKDOWN</unmanaged-short>
        DbgAttachProcessFailureLockdown = unchecked((System.Int32)(-2135949310)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_CONNECT_SERVER_FAILURE_LOCKDOWN</unmanaged>
        /// <unmanaged-short>ERROR_DBG_CONNECT_SERVER_FAILURE_LOCKDOWN</unmanaged-short>
        DbgConnectServerFailureLockdown = unchecked((System.Int32)(-2135949309)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_DBG_START_SERVER_FAILURE_LOCKDOWN</unmanaged>
        /// <unmanaged-short>ERROR_DBG_START_SERVER_FAILURE_LOCKDOWN</unmanaged-short>
        DbgStartServerFailureLockdown = unchecked((System.Int32)(-2135949308)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_IO_PREEMPTED</unmanaged>
        /// <unmanaged-short>ERROR_IO_PREEMPTED</unmanaged-short>
        IoPreempted = unchecked((System.Int32)(-1996423167)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_ERROR_STORED</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_ERROR_STORED</unmanaged-short>
        SvhdxErrorStored = unchecked((System.Int32)(-1067712512)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_ERROR_NOT_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_ERROR_NOT_AVAILABLE</unmanaged-short>
        SvhdxErrorNotAvailable = unchecked((System.Int32)(-1067647232)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_UNIT_ATTENTION_AVAILABLE</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_UNIT_ATTENTION_AVAILABLE</unmanaged-short>
        SvhdxUnitAttentionAvailable = unchecked((System.Int32)(-1067647231)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED</unmanaged-short>
        SvhdxUnitAttentionCapacityDataChanged = unchecked((System.Int32)(-1067647230)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED</unmanaged-short>
        SvhdxUnitAttentionReservationsPreempted = unchecked((System.Int32)(-1067647229)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED</unmanaged-short>
        SvhdxUnitAttentionReservationsReleased = unchecked((System.Int32)(-1067647228)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED</unmanaged-short>
        SvhdxUnitAttentionRegistrationsPreempted = unchecked((System.Int32)(-1067647227)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED</unmanaged-short>
        SvhdxUnitAttentionOperatingDefinitionChanged = unchecked((System.Int32)(-1067647226)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_RESERVATION_CONFLICT</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_RESERVATION_CONFLICT</unmanaged-short>
        SvhdxReservationConflict = unchecked((System.Int32)(-1067647225)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_WRONG_FILE_TYPE</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_WRONG_FILE_TYPE</unmanaged-short>
        SvhdxWrongFileType = unchecked((System.Int32)(-1067647224)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_VERSION_MISMATCH</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_VERSION_MISMATCH</unmanaged-short>
        SvhdxVersionMismatch = unchecked((System.Int32)(-1067647223)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHD_SHARED</unmanaged>
        /// <unmanaged-short>ERROR_VHD_SHARED</unmanaged-short>
        VhdShared = unchecked((System.Int32)(-1067647222)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SVHDX_NO_INITIATOR</unmanaged>
        /// <unmanaged-short>ERROR_SVHDX_NO_INITIATOR</unmanaged-short>
        SvhdxNoInitiator = unchecked((System.Int32)(-1067647221)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_VHDSET_BACKING_STORAGE_NOT_FOUND</unmanaged>
        /// <unmanaged-short>ERROR_VHDSET_BACKING_STORAGE_NOT_FOUND</unmanaged-short>
        VhdsetBackingStorageNotFound = unchecked((System.Int32)(-1067647220)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP</unmanaged>
        /// <unmanaged-short>ERROR_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP</unmanaged-short>
        SmbNoPreauthIntegrityHashOverlap = unchecked((System.Int32)(-1067646976)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ERROR_SMB_BAD_CLUSTER_DIALECT</unmanaged>
        /// <unmanaged-short>ERROR_SMB_BAD_CLUSTER_DIALECT</unmanaged-short>
        SmbBadClusterDialect = unchecked((System.Int32)(-1067646975))
    }
}

