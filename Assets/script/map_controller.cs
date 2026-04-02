using UnityEngine;
using UnityEngine.EventSystems;

public class UIHoverScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = originalScale * 3f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale;
    }
}