using UnityEngine;

namespace Chess.Scripts.Core
{
    public abstract class ChessPlayerPlacementHandler : MonoBehaviour
    {
        [SerializeField] protected int row, column; // Position of the piece
        protected ChessBoardPlacementHandler Board;

        private void Start()
        {
            Board = ChessBoardPlacementHandler.Instance;
            PlacePiece();
        }

        private void OnMouseDown()
        {
            Board.ClearHighlights();
            HighlightLegalMoves();
        }

        private void PlacePiece()
        {
            transform.position = Board.GetTile(row, column).transform.position;
        }

        // Each piece defines its own movement logic
        protected abstract void HighlightLegalMoves();

        protected void HighlightTile(int targetRow, int targetColumn)
        {
            if (targetRow >= 0 && targetRow < 8 && targetColumn >= 0 && targetColumn < 8)
            {
                Board.Highlight(targetRow, targetColumn);
            }
        }

        protected bool IsTileOccupied(int targetRow, int targetColumn)
        {
            return Board.IsTileOccupied(targetRow, targetColumn, gameObject.layer);
        }
    }
}
