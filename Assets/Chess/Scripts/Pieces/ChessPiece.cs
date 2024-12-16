using UnityEngine;

namespace Chess.Scripts.Core
{
    public abstract class ChessPiece : MonoBehaviour
    {
        [SerializeField] protected int row, column;

        protected virtual void Start()
        {
            // Place the piece on the chessboard based on its row and column
            transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
        }

        public abstract void CalculateLegalMoves();

        protected void HighlightMove(int targetRow, int targetColumn)
        {
            if (!IsWithinBounds(targetRow, targetColumn)) return;

            var tile = ChessBoardPlacementHandler.Instance.GetTile(targetRow, targetColumn);
            var enemyPiece = tile.GetComponentInChildren<ChessPiece>();

            if (enemyPiece != null && IsEnemy(enemyPiece))
            {
                ChessBoardPlacementHandler.Instance.Highlight(targetRow, targetColumn); // Use red highlight prefab
            }
            else if (enemyPiece == null)
            {
                ChessBoardPlacementHandler.Instance.Highlight(targetRow, targetColumn); // Normal highlight
            }
        }

        protected virtual bool IsEnemy(ChessPiece piece)
        {
            // Placeholder logic for determining enemy status
            return true; // Replace with actual team-based logic
        }


        protected bool IsWithinBounds(int targetRow, int targetColumn)
        {
            return targetRow >= 0 && targetRow < 8 && targetColumn >= 0 && targetColumn < 8;
        }
    }
}
