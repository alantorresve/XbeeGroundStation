

using System;
using crc8_method;
using Xbee_Ground_Station;

namespace Ground_command
{
    public class Epscontrol
    {
        Crc8_met crc8 = new Crc8_met();
        const byte ON = 0x01;
        const byte OFF = 0x02;
        public struct EPS_action
        {
            const ushort GPS_on = 0x018C;
            const ushort GPS_off = 0x027C;
            const ushort mtq_on = 0x014C;
            const ushort mtq_off = 0x02BC;
            const ushort adsb_on = 0x012C;
            const ushort adsb_off = 0x02DC;
            const ushort Obc_resat = 0x04DC;
        }

        public byte[] EPS_power(byte command, EPS_action action)
        {
            byte[] GTTC1 = new byte[9];//20
            GTTC1[0] = 0x4E;
            GTTC1[1] = 0x53;
            GTTC1[2] = 0x01;
            GTTC1[3] = 0x02;
            //GTTC1[4] = Convert.ToByte(action & 0XFF00) >>8);
            GTTC1[5] = command;
            GTTC1[6] = crc8.Cal_crc_table(GTTC1, 4, GTTC1[3]);
            GTTC1[7] = 0x50;
            GTTC1[8] = 0x4F;
            return GTTC1;

        }
        /// <summary>
        /// 控制器次系統開 controller subsystem ON
        /// </summary>
        /// <param name="command">命令 COMMAND</param>
        public byte[] EPS_ON(byte command)
        {
            byte[] GTTC1 = new byte[9];//20
            GTTC1[0] = 0x4E;
            GTTC1[1] = 0x53;
            GTTC1[2] = 0x01;
            GTTC1[3] = 0x02;
            GTTC1[4] = 0x01;
            GTTC1[5] = command;
            GTTC1[6] = crc8.Cal_crc_table(GTTC1, 4, GTTC1[3]);
            GTTC1[7] = 0x50;
            GTTC1[8] = 0x4F;
            return GTTC1;
            
        }

        /// <summary>
        /// 控制器次系統關 controller subsystem OFF
        /// </summary>
        /// <param name="command">命令 COMMAND</param>
        public byte[] EPS_OFF(byte command)
        {
            
            byte[] GTTC1 = new byte[9];//20
            GTTC1[0] = 0x4E;
            GTTC1[1] = 0x53;
            GTTC1[2] = 0x01;
            GTTC1[3] = 0x02;
            GTTC1[4] = 0x02;
            GTTC1[5] = command;
            GTTC1[6] = crc8.Cal_crc_table(GTTC1, 4, GTTC1[3]);
            GTTC1[7] = 0x50;
            GTTC1[8] = 0x4F;
            return GTTC1;
        }

        
        public class Sddownload
        {

        }
    }
}