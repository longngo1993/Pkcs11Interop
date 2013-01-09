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
    /// Structure that provides the parameters to the CKM_KEY_WRAP_SET_OAEP mechanism
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct CK_KEY_WRAP_SET_OAEP_PARAMS
    {
        /// <summary>
        /// Block contents byte
        /// </summary>
        public byte BC;

        /// <summary>
        /// Concatenation of hash of plaintext data (if present) and extra data (if present)
        /// </summary>
        public IntPtr X;
        
        /// <summary>
        /// Length in bytes of concatenation of hash of plaintext data (if present) and extra data (if present) or 0 if neither is present
        /// </summary>
        public uint XLen;
    }
}
