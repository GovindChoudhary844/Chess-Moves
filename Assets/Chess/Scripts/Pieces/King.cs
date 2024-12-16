namespace Chess.Scripts.Core
{
    public class King : ChessPlayerPlacementHandler
    {
        protected override void HighlightLegalMoves()
        {
            int[,] kingMoves = {
                { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 },
                { 1, 1 }, { 1, -1 }, { -1, 1 }, { -1, -1 }
            };

            for (int i = 0; i < kingMoves.GetLength(0); i++)
            {
                int targetRow = row + kingMoves[i, 0];
                int targetCol = column + kingMoves[i, 1];

                if (!IsTileOccupied(targetRow, targetCol))
                {
                    HighlightTile(targetRow, targetCol);
                }
            }
        }
    }
}
