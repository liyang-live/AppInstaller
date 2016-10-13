﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Win32.Com
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("3050F3F0-98B5-11CF-BB82-00AA00BDCE0B")]
    public interface ICustomDoc
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetUIHandler([In, MarshalAs(UnmanagedType.Interface)] IDocHostUIHandler idocHostUIHandler_0);
    }
}