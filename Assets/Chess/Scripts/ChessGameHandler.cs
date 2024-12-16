using UnityEngine;

namespace Chess.Scripts.Core
{
    public class ChessGameHandler : MonoBehaviour
    {
        private ChessPiece selectedPiece;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    ChessPiece piece = hit.collider.GetComponent<ChessPiece>();
                    if (piece != null)
                    {
                        SelectPiece(piece);
                    }
                }
            }
        }

        private void SelectPiece(ChessPiece piece)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights(); // Clear previous highlights
            selectedPiece = piece;
            selectedPiece.CalculateLegalMoves();
        }
    }
}
