using UnityEngine;

namespace Chess.Scripts.Core
{
    public class Pawn : ChessPlayerPlacementHandler
    {

        [SerializeField] private int direction = 1;

        protected override void HighlightLegalMoves()
        {
            int forwardStep = row + direction;

            // Forward move
            if (!IsTileOccupied(forwardStep, column))
                HighlightTile(forwardStep, column);

            // Diagonal captures
            IsTileOccupied(forwardStep, column - direction);

            IsTileOccupied(forwardStep, column + direction);
        }
    }
}
