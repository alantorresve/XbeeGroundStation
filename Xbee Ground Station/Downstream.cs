using System;
using OBC;
namespace Downstream
{    
    public class Data_interpretation
    {
        private int ICAO;
        private int altitude;
        private ushort heading, hor_velocity;
        private short ver_hor_velocity;
        private ushort validFlags, squawk;
        private byte altitude_type;

        private int byte4;
        private string str_buffer;

        private int[,] dtat_buffer = new int[100, 9];

        public string Function_label;

        public int ICAO1, ICAO2, ICAO3;
        public double lat1, lat2, lat3;
        public double lon1, lon2, lon3;
        public double alt1, alt2, alt3;
        public double hea, hea2, hea3;
        public double hor, hor2, hor3;
        public double ver, ver2, ver3;
        public string CALL1, CALL2, CALL3;

        public byte EPSPV_1;
        public byte EPSPV_2;
        public byte EPSPV_3;
        public byte EPSPV_4;
        public byte EPS_Battery;
        public byte EPS_Power33;
        public byte EPS_Power5;
        public byte VGPS;
        public byte EPS_SW;
        public byte EPS_Temp_BAT;
        public byte EPS_Timeday;
        public byte EPS_VMTQ;
        public byte EPS_VADSB;
        public byte EPS_VUHF;
        public byte EPS_Temp_ENV;
        public byte EPS_Timehour;
        public byte EPS_Timemin;

         

        public void ALL_data(byte[] Data , int Offset)
        {
            const int uint8_t = 8 / 8;
            const int uint16_t = 16 / 8;
            const int uint32_t = 32 / 8;

            int[] type_table = new int[] { uint8_t*4,uint8_t*6, uint32_t, uint32_t, uint32_t , uint32_t , uint16_t , uint16_t , uint16_t , uint16_t, uint16_t, uint8_t , uint8_t * 9,
                                           uint8_t , uint8_t,uint32_t, uint32_t, uint32_t , uint32_t , uint16_t , uint16_t , uint16_t , uint16_t, uint16_t, uint8_t , uint8_t * 9,
                                           uint8_t , uint8_t,uint32_t, uint32_t, uint32_t , uint32_t , uint16_t , uint16_t , uint16_t , uint16_t, uint16_t, uint8_t , uint8_t * 9,
                                           uint8_t , uint8_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,
                                           uint16_t,uint16_t, uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,
                                           uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t};
            int[] dtat_table = new int[78];

            dtat_table[0] = type_table[0];
            for (int data_table_loop = 1; data_table_loop < dtat_table.Length; data_table_loop++)
            {
                if (data_table_loop < type_table.Length)
                {
                    dtat_table[data_table_loop] = dtat_table[data_table_loop - 1] + type_table[data_table_loop];
                }
            }
            

            for (int data_loop = 0; data_loop < dtat_table.Length; data_loop++)
            {
                for (int data_loop2 = 0; data_loop2 < type_table[data_loop + 1]; data_loop2++)
                {
                    dtat_buffer[data_loop, data_loop2] = Data[Offset + dtat_table[data_loop] + data_loop2];
                }
            }
           // ASCIItostr(0, 6);
           // /*功能標籤*/
           // Function_label = str_buffer;
           // /*ICAO*/
           // ICAO_data(1);
           // ICAO1 = ICAO;
           // ICAO_data(14);
           // ICAO2 = ICAO;
           // ICAO_data(27);
           // ICAO3 = ICAO;
           ///*緯度*/
           // data_Length32(2);
           // lat1 = byte4 * 1E7;
           // data_Length32(15);
           // lat2 = byte4 * 1E7;
           // data_Length32(28);
           // lat3 = byte4 * 1E7;
           // /*經度*/
           // data_Length32(3);
           // lon1 = byte4 * 1E7;
           // data_Length32(16);
           // lon1 = byte4 * 1E7;
           // data_Length32(29);
           // lon1 = byte4 * 1E7;
        }
        public void ICAO_save( int[,] dtat_buffer_ddd)
        {
            /*ICAO*/
            ICAO_data(dtat_buffer_ddd, 1);
            ICAO1 = ICAO;
            ICAO_data(dtat_buffer_ddd, 14);
            ICAO2 = ICAO;
            ICAO_data(dtat_buffer_ddd, 27);
            ICAO3 = ICAO;
            /*緯度*/
            data_Length32(dtat_buffer_ddd, 2);
            lat1 = byte4 * 1E7;
            data_Length32(dtat_buffer_ddd, 15);
            lat2 = byte4 * 1E7;
            data_Length32(dtat_buffer_ddd, 28);
            lat3 = byte4 * 1E7;
            /*經度*/
            data_Length32(dtat_buffer_ddd, 3);
            lon1 = byte4 * 1E7;
            data_Length32(dtat_buffer_ddd, 16);
            lon2 = byte4 * 1E7;
            data_Length32(dtat_buffer_ddd, 29);
            lon3 = byte4 * 1E7;
            /*高度*/
            data_Length32(dtat_buffer_ddd, 4);
            alt1 = byte4 * 1E3 - dtat_buffer_ddd[10, 0];
            data_Length32(dtat_buffer_ddd, 17);
            alt2 = byte4 * 1E3 - dtat_buffer_ddd[23, 0];
            data_Length32(dtat_buffer_ddd, 30);
            alt3 = byte4 * 1E3 - dtat_buffer_ddd[36, 0];
            /*標頭*/
            data_Length16(dtat_buffer_ddd,5);
            hea = byte4 * 1E2;
            data_Length16(dtat_buffer_ddd, 18);
            hea2 = byte4 * 1E2;
            data_Length16(dtat_buffer_ddd, 31);
            hea3 = byte4 * 1E2;
            /*HOR*/
            data_Length16(dtat_buffer_ddd, 6);
            hor = byte4;
            data_Length16(dtat_buffer_ddd, 19);
            hor2 = byte4;
            data_Length16(dtat_buffer_ddd, 32);
            hor3 = byte4;
            /*VOR*/
            data_Length16(dtat_buffer_ddd, 7);
            ver = byte4;
            data_Length16(dtat_buffer_ddd, 20);
            ver2 = byte4;
            data_Length16(dtat_buffer_ddd, 33);
            ver3 = byte4;
            /*呼號*/
            ASCIItostr(dtat_buffer_ddd, 11, 9);
            CALL1 = str_buffer;
            ASCIItostr(dtat_buffer_ddd, 27, 9);
            CALL2 = str_buffer;
            ASCIItostr(dtat_buffer_ddd, 37 , 9);
            CALL3 = str_buffer;
        }


        private void ICAO_data(int[,] dtat_buffer_ddd, int Offset)
        {
            ICAO = 0;
            for (int show_loop = 0; show_loop < 4; show_loop++)
            {
                ICAO = dtat_buffer[Offset, 3 - show_loop] << 8 * (3 - show_loop);
            }
        }
        private void data_Length32(int[,] dtat_buffer_ddd, int Offset)
        {
            byte4 = 0;
            for (int show_loop = 0; show_loop < 4; show_loop++)
            {
                byte4 = dtat_buffer[Offset,show_loop] << 8 * (3 - show_loop);
            }
        }
        private void data_Length16(int[,] dtat_buffer_ddd, int Offset)
        {
            byte4 = 0;
            for (int show_loop = 0; show_loop < 2; show_loop++)
            {
                byte4 = dtat_buffer[Offset, show_loop] << 8 * (2 - show_loop);
            }
        }
        private void ASCIItostr(int[,] dtat_buffer_ddd, int Offset,int unm)
        {
            str_buffer = "";
            for (int show_loop = 0; show_loop < unm; show_loop++)
            {
                str_buffer += Convert.ToChar(dtat_buffer[Offset, show_loop]);
            }  
        }
    }
 }