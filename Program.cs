using System;
using ChessAI.Enums;

namespace ChessAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bbc\n");

            var bitboard = new Bitboard();

            Console.WriteLine(
                bitboard
                    .SetBit(Square.e4)
                    .PopBit(Square.e4)
                    .SetBit(Square.h5)
            );

            Console.ReadKey();
        }
    }
}
