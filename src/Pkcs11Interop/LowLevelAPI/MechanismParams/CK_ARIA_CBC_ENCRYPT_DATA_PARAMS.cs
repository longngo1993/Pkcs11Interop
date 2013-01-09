﻿/*
 *  Pkcs11Interop - Open-source .NET wrapper for unmanaged PKCS#11 libraries
 *  Copyright (C) 2012 Jaroslav Imrich <jimrich(at)jimrich(dot)sk>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License version 3
 *  as published by the Free Software Foundation.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Runtime.InteropServices;

namespace Net.Pkcs11Interop.LowLevelAPI.MechanismParams
{
    /// <summary>
    /// Structure that provides the parameters to the CKM_ARIA_CBC_ENCRYPT_DATA mechanism
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct CK_ARIA_CBC_ENCRYPT_DATA_PARAMS
    {
        /// <summary>
        /// 16-octet initialization vector
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Iv;

        /// <summary>
        /// Pointer to data to encrypt
        /// </summary>
        public IntPtr Data;

        /// <summary>
        /// Length of data to encrypt
        /// </summary>
        public uint Length;
    }
}
