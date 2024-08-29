using System;
using System.Configuration;

namespace IEEE754
{
    public class IEEE754Convert
    {
        /// <summary>
        /// 將IEEE754 double 標準表示的數字轉換為已16進制字串ASCII表示
        /// </summary>
        /// <param name="mtq_gain">需要轉換的double值</param>
        public byte[] Doubletostring (double mtq_gain)//定址
        {                //////////////////ieee754
                         ////////////////////////
            long nValue = 0;
            long nSign;    //S符號 +-號  1.1E-4  這裡處理-4部分 1.1正負號
                           //IEEE 754 DOUBLE S
            if (mtq_gain >= 0)
            {
                nSign = 0x00;

            }
            else
            {
                nSign = 0x01;

                mtq_gain = mtq_gain * (-1);
            }
            long nHead = (long)mtq_gain;  //取整數部分
            double fTail = mtq_gain % 1;   //取小數部分
            int nShift = 0;
            String str = Convert.ToString(nHead, 2); //取整數部分做2近制轉換
            int nHead_Length = str.Length;
            //////////////////////////////科學記號正規化////////////////////////////////////////////
            if (nHead != 0)
            {
                nValue = nHead;                         //將整數部分放轉患後的是放入IEEE 754  F
                nHead_Length = str.Length - 1;                  //紀錄以放入長度
                nShift = nHead_Length;
            }
            else
            {
                while (nShift < 1024)   // (nHead_Length + nShift < 23)////////////////////////////0311//////////////////////////24
                {
                    if ((fTail * 2) >= 1)
                    {
                        nHead_Length = -(nShift) - 1;
                        break;
                    }
                    fTail = (fTail * 2) % 1; //取小數部分
                    nShift++;
                }
                nShift = 0;
                fTail = (fTail * 2) % 1;
            }
            /*
            (4.a) 單精度浮點數：正負號 1 bit，指數部份 8 bits，小數部份 23 bits，共 32 bits
            (4.b) 雙精度浮點數：正負號 1 bit，指數部份 11 bits，小數部份 52 bits，共 64 bits

            單精度的小數部份是 23 bits，故 單精度浮點數之精度為2^-23 = 1.192092896 * 10^-7，這就是它的精度。
            倍精度的小數部份是 52 bits，故 雙精度浮點數之精度為2^-52 = 2.220446049 * 10^-16，這就是倍精度的精度。
            */
            //IEEE 754 DOUBLE F  (科學記號前數值)  1.1E-4  這裡處理1.1部分

            while (nShift < 52)   // (nHead_Length + nShift < 23)////////////////////////////0311//////////////////////////24
            {
                if ((fTail * 2) >= 1)
                {
                    //nValue = (nValue << 1) | 0x00000001;//0x00000001& 0x7FFFFF
                    nValue = (nValue << 1) | 0x01;
                }
                else
                {
                    nValue = (nValue << 1);
                }
                fTail = (fTail * 2) % 1;
                nShift++;
            }
            /*
            單精度最大正數 ：+1.1111.... (小數點後23個1) * 2^127 = +(2- (2^-23)) * ( 2^127) = +3.402823668  * 10^38
            雙精度最大正數 ：一樣的算法， +(2-(2^-52)) * (2 ^ 1023) = +1.7976931348 * 10^308

            單精度最小負數 ： -(2- (2^-32)) * ( 2^127) = -3.402823668 * 10^38
            雙精度最小負數 ： -(2-(2^-52)) * (2 ^ 1023) = -1.7976931348 * 10^308
            */
            ///////////////精度倍率(n) 2 n次方    1.1E-4  這裡處理-4部分
            //int nExp = nHead_Length - 1 + 127;
            long nExp = nHead_Length + 1023;
            nExp = nExp << 52;//23/////////////////////////////7////F////F////F////F////F   
                              //nValue = nValue & 0x7FFFFF;//0x00000001& 0x7FFFFF  0111 1111 1111 1111 1111 1111  6*4=24
                              //nValue = nValue & 0x7FFFFFFFFFFFFFF;//0x00000001& 0x7FFFFF  0111 1111 1111 1111 1111 1111
            nValue = nValue & 0x1FFFFFFFFFFFFF;//0x00000001& 0x7FFFFF  0111 1111 1111 1111 1111 1111
            nValue = nValue | nExp;
            //nSign=nSign<<31;
            nSign = nSign << 63;//31
            nValue = nValue | nSign;

            long data1, data2, data3, data4, data5, data6, data7, data8;
            /*
            data1 =  nValue & 0x000000FF;
            data2 = (nValue & 0x0000FF00)>>8;
            data3 = (nValue & 0x00FF0000)>>16;
            data4 = (nValue>>24) & 0x000000FF;
             */
            data1 = (nValue & 0x00000000000000FF);
            data2 = (nValue & 0x000000000000FF00) >> 8;
            data3 = (nValue & 0x0000000000FF0000) >> 16;
            data4 = (nValue & 0x00000000FF000000) >> 24;
            data5 = (nValue & 0x000000FF00000000) >> 32;
            data6 = (nValue & 0x0000FF0000000000) >> 40;
            data7 = (nValue & 0x00FF000000000000) >> 48;
            //data8 = (nValue & 0xFF00000000000000) >> 56;
            data8 = (nValue >> 56) & 0x00000000000000FF;//右移56位置 對高位2為換成最低為2位 做 & 運算去除其他位元

            if (mtq_gain == 0)
            {
                data1 = 0x00;
                data2 = 0x00;
                data3 = 0x00;
                data4 = 0x00;
                data5 = 0x00;
                data6 = 0x00;
                data7 = 0x00;
                data8 = 0x00;
            }
            byte[] GTTC1 = new byte[8];
            GTTC1[0] = Convert.ToByte(data1);
            GTTC1[1] = Convert.ToByte(data2);
            GTTC1[2] = Convert.ToByte(data3);
            GTTC1[3] = Convert.ToByte(data4);
            GTTC1[4] = Convert.ToByte(data5);
            GTTC1[5] = Convert.ToByte(data6);
            GTTC1[6] = Convert.ToByte(data7);
            GTTC1[7] = Convert.ToByte(data8);
            return GTTC1;


        }

    }
}