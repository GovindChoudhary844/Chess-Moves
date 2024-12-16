namespace Chess.Scripts.Core
{
    public class Rook : ChessPlayerPlacementHandler
    {
        protected override void HighlightLegalMoves()
        {
            HighlightDirection(0, 1);  // Right
            HighlightDirection(0, -1); // Left
            HighlightDirection(1, 0);  // Up
            HighlightDirection(-1, 0); // Down
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
    }
}
