using UnityEngine;
using UnityEngine.EventSystems;

public class DragUIElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;

    public RectTransform bearCollision1;
    public RectTransform bearCollision2;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Comenzó el arrastre del Guardian");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 previousPosition = rectTransform.anchoredPosition;

        // Intentamos mover al Guardian
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

        // Comprobamos si toca alguno de los osos
        if (IsColliding(bearCollision1) || IsColliding(bearCollision2))
        {
            // Si hay colisión, vuelve a la posición anterior
            rectTransform.anchoredPosition = previousPosition;
            Debug.Log("El Guardian colisionó con un oso");
        }
    }

    private bool IsColliding(RectTransform obstacle)
    {
        if (obstacle == null)
            return false;

        Rect guardianRect = GetWorldRect(rectTransform);
        Rect obstacleRect = GetWorldRect(obstacle);

        return guardianRect.Overlaps(obstacleRect);
    }

    private Rect GetWorldRect(RectTransform rt)
    {
        Vector3[] corners = new Vector3[4];
        rt.GetWorldCorners(corners);

        return new Rect(
            corners[0].x,
            corners[0].y,
            corners[2].x - corners[0].x,
            corners[2].y - corners[0].y
        );
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Terminó el arrastre del Guardian");
    }
}