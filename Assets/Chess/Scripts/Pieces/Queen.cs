namespace Chess.Scripts.Core
{
    public class Queen : ChessPlayerPlacementHandler
    {
        protected override void HighlightLegalMoves()
        {
            HighlightRookMoves();   // Rook-like moves
            HighlightBishopMoves(); // Bishop-like moves
        }

        private void HighlightRookMoves()
        {
            HighlightDirection(0, 1);  // Right
            HighlightDirection(0, -1); // Left
            HighlightDirection(1, 0);  // Up
            HighlightDirection(-1, 0); // Down
        }

        private void HighlightBishopMoves()
        {
            HighlightDiagonal(1, 1);   // Top-right
            HighlightDiagonal(1, -1);  // Top-left
            HighlightDiagonal(-1, 1);  // Bottom-right
            HighlightDiagonal(-1, -1); // Bottom-left
        }

        private void HighlightDirection(int rowIncrement, int colIncrement)
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
