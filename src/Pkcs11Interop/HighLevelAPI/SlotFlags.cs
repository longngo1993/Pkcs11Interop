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

using Net.Pkcs11Interop.Common;

namespace Net.Pkcs11Interop.HighLevelAPI
{
    /// <summary>
    /// Flags that provide capabilities of the slot
    /// </summary>
    public class SlotFlags
    {
        /// <summary>
        /// Bits flags that provide capabilities of the slot
        /// </summary>
        private uint _flags;

        /// <summary>
        /// Bits flags that provide capabilities of the slot
        /// </summary>
        public uint Flags
        {
            get
            {
                return _flags;
            }
        }

        /// <summary>
        /// True if a token is present in the slot (e.g. a device is in the reader)
        /// </summary>
        public bool TokenPresent
        {
            get
            {
                return ((_flags & CKF.CKF_TOKEN_PRESENT) == CKF.CKF_TOKEN_PRESENT);
            }
        }

        /// <summary>
        /// True if the reader supports removable devices
        /// </summary>
        public bool RemovableDevice
        {
            get
            {
                return ((_flags & CKF.CKF_REMOVABLE_DEVICE) == CKF.CKF_REMOVABLE_DEVICE);
            }
        }

        /// <summary>
        /// True if the slot is a hardware slot, as opposed to a software slot implementing a "soft token"
        /// </summary>
        public bool HardwareSlot
        {
            get
            {
                return ((_flags & CKF.CKF_HW_SLOT) == CKF.CKF_HW_SLOT);
            }
        }

        /// <summary>
        /// Initializes new instance of SlotFlags class
        /// </summary>
        /// <param name="flags">Bits flags that provide capabilities of the slot</param>
        internal SlotFlags(uint flags)
        {
            _flags = flags;
        }
    }
}
