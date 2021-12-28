using ChessAI.Enums;
using System;
using System.Text;

namespace ChessAI
{
    class Bitboard
    {
        public ulong Board { get; set; }

        public Bitboard()
        {
            Board = 0UL;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("\n");

            for (int rank = 0; rank < 8; rank++)
            {
                sb.Append(' ').Append(8 - rank).Append(' ');

                for (int file = 0; file < 8; file++)
                {
                    int square = rank * 8 + file;
                    var isOn = GetBit(square) ? 1 : 0;
                    sb.Append(' ').Append(isOn);
                }

                sb.Append("\n");
            }
            sb.Append("\n    A B C D E F G H");
            sb.Append("\n    Bitboard: ").Append(Board);
            return sb.ToString();
        }

        public bool GetBit(int square)
        {
            return Convert.ToBoolean(Board & (1UL << square));
        }

        public Bitboard SetBit(Square square)
        {
            Board |= 1UL << (int)square;
            return this;
        }

        public Bitboard PopBit(Square square)
        {
            if (!GetBit((int)square))
            {
                return this;
            }

            Board ^= (1UL << (int)square);
            return this;
        }
    }
}


