using System.Linq;
namespace Chess.Constant
{
    public static class Constants
    {
        private const int _row = 8;
        private const int _col = 8;
        private static char[] _rowName = new char[8] {'A','B','C','D','E','F','G','H'};

        public static int Row { get => _row; }
        public static int Col { get => _col; }

        public static char GetRowName(int index) => _rowName[index];

        public static int GetIndex(char row) => _rowName.Select((s, i) => new { i, s }).Where(t => t.s.Equals(row)).Select(t => t.i).FirstOrDefault();

    }
}