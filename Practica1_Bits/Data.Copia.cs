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

        public void SetDataFromBit(int data, int pos, int size = 1)
        {
            int shift = ToInt32(Pow(2, pos));
            if (size == 1)
                dataHolder = (dataHolder | shift) & (data << pos | shift - 1);

            else if (pos != 0)
                dataHolder = (dataHolder | ToInt32(Pow(2, pos + size)) - shift) & ((data << pos) | shift - 1);

            else
                dataHolder = (dataHolder | ToInt32(Pow(2, size)) - 1) & (data | ~(shift - 1));
        }