using System;
using static System.Convert;
using static System.Math;
using System.Windows.Forms;

namespace Practica1_Bits
{
    public partial class Form1 : Form
    {
        /**
        First Byte:
            - bit 7    : sensor 1: on / off
            - bit 6    : sensor 2: on / off
            - bits 4-5 : tank level: ( empty: 0, half: 1, full: 2, filling: 3 )
            - bits 1-3 : movement direction: ( N: 0, NE: 1, E: 2, SE: 3, S: 4, SO: 5, O: 6, NO: 7 )
            - bit 0    : NOT USED
            
        Bytes 2 and 3:
            Represents the date. The 16 bits represent this data, the base year is 1900.
            The distribution is: YYYYYYY MMMM DDDDD, where from right to left, the first D is the
            LSD and the last Y is the MSD.
        */
        private int dataHolder;

        public Form1() => InitializeComponent();

        /*
        - pos:Indicates the bit index where starts the value that
            the function will return. This bit represents the Least Significant Digit of the value</param>
        - name: Indicates de size, in bits, of the data that read (the returned value will
            be a Int32 the size of the data. The default value is 1
        */
        public int GetsDataFromBit(int pos, int size = 1)
        {
            if (size == 1)
                return (dataHolder & ToInt32(Pow(2, pos))) >> pos; // int activeBit = ToInt32(Pow(2, pos));

            else if (pos != 0)
                return (dataHolder & ToInt32(Pow(2, pos + size)) - ToInt32(Pow(2, pos))) >> pos; // int lsd = ToInt32(Pow(2, pos));
                                                                                                 // int msdPlus1 = ToInt32(Pow(2, pos + size));
            else
                return (dataHolder & ToInt32(Pow(2, size)) - 1); // int activeBits = ToInt32(Pow(2, size)) - 1;
        }

        /*
        - data: The value that will be store.
        - pos: Indicates the bit index where starts to write.
            This bit represents the Least Significant Digit of the value
        */
        public void SetDataToBit(int data, int pos)
        {
            int size = 0, _data = data, offset = ToInt32(Pow(2, pos));
            while (_data != 0)
            {
                size++;
                _data >>= 1;
            }

            if (size == 1)
                dataHolder = (dataHolder | offset) | (data << pos | offset - 1);

            else if (pos != 0)
                dataHolder = (dataHolder | ToInt32(Pow(2, pos + size)) - offset) & ((data << pos) | offset - 1);

            else
                dataHolder = (dataHolder | ToInt32(Pow(2, size)) - 1) & (data | ~(offset - 1));
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                dataHolder = int.Parse(TxtInput.Text);

                TxtSensor1.Text = GetsDataFromBit(7) == 1 ? "Encendio" : "Apagado";

                TxtSensor2.Text = GetsDataFromBit(6) == 1 ? "Encendido" : "Apagado";

                switch (GetsDataFromBit(4, 2)) // TANK_LEVEL: 48d = 00110000b
                {
                    case 0: TxtLevel.Text = "Vacio"; break;
                    case 1: TxtLevel.Text = "Nivel Medio"; break;
                    case 2: TxtLevel.Text = "Lleno"; break;
                    default: TxtLevel.Text = "Proceso de Llenado"; break;
                }

                switch (GetsDataFromBit(1, 3)) // DIRECTION: 14d = 00001110b
                {
                    case 0: TxtDirection.Text = "N"; break;
                    case 1: TxtDirection.Text = "NE"; break;
                    case 2: TxtDirection.Text = "E"; break;
                    case 3: TxtDirection.Text = "SE"; break;
                    case 4: TxtDirection.Text = "S"; break;
                    case 5: TxtDirection.Text = "SO"; break;
                    case 6: TxtDirection.Text = "O"; break;
                    default: TxtDirection.Text = "NO"; break;
                }

                TxtDate.Text = String.Format("{0}/{1}/{2}",
                    GetsDataFromBit(17,7) + 1900,
                    GetsDataFromBit(13,4),
                    GetsDataFromBit(8,5)
                );

                // DAY_POS:      7936 = 0b0000000 0000 11111 00000000;    255 = 0b11111111
                // MONTH_POS:  122880 = 0b0000000 1111 00000 00000000;   8191 = 0b11111111 11111
                // YEAR_POS: 16646144 = 0b1111111 0000 00000 00000000; 131071 = 0b11111111 11111 1111
            }
            catch { return; }
        }

        private void BtnAdjustDate_Click(object sender, EventArgs e)
        {
            DateTime date = DatePicker.Value;
            if (date < new DateTime(1900,1,1)) return;
            SetDataToBit(date.Day, 8);
            SetDataToBit(date.Month, 13);
            SetDataToBit(date.Year - 1900, 17);
            TxtDateOutput.Text = GetsDataFromBit(8, 16).ToString();
        }
    }
}
