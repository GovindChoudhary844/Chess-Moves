namespace Chess.Scripts.Core
{
    public class Bishop : ChessPlayerPlacementHandler
    {
        protected override void HighlightLegalMoves()
        {
            HighlightDiagonal(1, 1);   // Top-right
            HighlightDiagonal(1, -1);  // Top-left
            HighlightDiagonal(-1, 1);  // Bottom-right
            HighlightDiagonal(-1, -1); // Bottom-left
        }

        private void HighlightDiagonal(int rowIncrement, int colIncrement)
        {
            int currentRow = row + rowIncrement;
            int currentCol = column + colIncrement;

            while (currentRow >= 0 && currentRow < 8 && currentCol >= 0 && currentCol < 8)
            {
                if (IsTileOccupied(currentRow, currentCol)) break;
                HighlightTile(currentRow, currentCol);
                currentRow += rowIncrement;
                currentCol += colIncrement;
            }
        }
    }
}
