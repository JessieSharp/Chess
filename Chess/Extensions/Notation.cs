﻿using System;

namespace Chess.Extensions
{
    public class Notation
    {
        public static int GetPositionByLetter(string letter)
        {
            return letter switch
            {
                "a" => 0,
                "b" => 1,
                "c" => 2,
                "d" => 3,
                "e" => 4,
                "f" => 5,
                "g" => 6,
                "h" => 7,
                _ => -1
            };
        }

        public static string GetLetterByPosition(int position)
        {
            return position switch
            {
                0 => "a",
                1 => "b",
                2 => "c",
                3 => "d",
                4 => "e",
                5 => "f",
                6 => "g",
                7 => "h",
                _ => ""
            };
        }

        public static char GetChessFigureShort(PieceType pieceType)
        {
            return pieceType switch
            {
                PieceType.Pawn => 'P',
                PieceType.King => 'K',
                PieceType.Queen => 'Q',
                PieceType.Bishop => 'B',
                PieceType.Knight => 'N',
                PieceType.Rook => 'R',
                _ => throw new ArgumentOutOfRangeException(nameof(pieceType), pieceType, null)
            };
        }
    }
}