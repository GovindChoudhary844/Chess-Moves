namespace Chess.Scripts.Core
{
    public class Knight : ChessPlayerPlacementHandler
    {
        protected override void HighlightLegalMoves()
        {
            int[,] knightMoves = {
                { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 },
                { 1, 2 }, { 1, -2 }, { -1, 2 }, { -1, -2 }
            };

            for (int i = 0; i < knightMoves.GetLength(0); i++)
            {
                int targetRow = row + knightMoves[i, 0];
                int targetCol = column + knightMoves[i, 1];

                if (!IsTileOccupied(targetRow, targetCol))
                {
                    HighlightTile(targetRow, targetCol);
                }
            }
        }
    }
}
