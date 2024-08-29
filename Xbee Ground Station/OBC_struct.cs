using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace OBC
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
    struct OBC_dataframe
    {

        public byte STX;
        public byte LEN;
        public byte SEQ;
        public byte SYS;
        public byte COMP;
        public byte MSG;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Nutsat;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] ADSB1_Name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public byte[] ADSB1_Data;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] ADSB2_Name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public byte[] ADSB2_Data;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] ADSB3_Name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public byte[] ADSB3_Data;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] ADSB4_Name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public byte[] ADSB4_Data;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPSPV_1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPSPV_2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPSPV_3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPSPV_4;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_Battery;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_Power33;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_Power5;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte VGPS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_PowerS;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_Temp_BAT;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_TimeHOUR;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_VMTQ;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_VADSB;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_VUHF;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_Temp_ENV;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_TimeMINUTE;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte EPS_TimeSECOND;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] OBC;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 35)]
        public byte[] GPS;
        public byte CKA;
        public byte CKB;

    }
    class OBC_struct
    {

        /// <summary>
        /// byte陣列轉換為結構
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bytearray"></param>
        /// <returns></returns>
        public static T ByteArrayToStructure<T>(byte[] bytearray)
        {
            T structure = default(T);

            int len = Marshal.SizeOf(typeof(T));

            IntPtr ptr = Marshal.AllocHGlobal(len);

            Marshal.Copy(bytearray, 0, ptr, len);

            structure = Marshal.PtrToStructure<T>(ptr);

            Marshal.FreeHGlobal(ptr);
            return structure;
        }
    }
}
