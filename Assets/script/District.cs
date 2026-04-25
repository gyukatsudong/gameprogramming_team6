using UnityEngine;

public class District : MonoBehaviour
{
    private Vector3 originalPosition;
    private int originalSortingOrder;
    private SpriteRenderer spriteRenderer;

    [Header("Hover Settings")]
    public float liftAmount = 0.2f;
    public Color hoverColor = new Color(0.8f, 1f, 0.8f); // 마우스 올렸을 때 색상

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalPosition = transform.position;
        originalSortingOrder = spriteRenderer.sortingOrder;
    }

    void OnMouseEnter()
    {
        // 1. 살짝 위로 띄우기
        transform.position = originalPosition + new Vector3(0, liftAmount, 0);

        // 2. 다른 지역들보다 무조건 맨 앞에 그려지게 만들기
        spriteRenderer.sortingOrder = 100;

        // 3. 색상을 밝게 변경하여 '선택됨'을 강조
        spriteRenderer.color = hoverColor;
    }

    void OnMouseExit()
    {
        // 원래 상태로 완벽히 복구
        transform.position = originalPosition;
        spriteRenderer.sortingOrder = originalSortingOrder;
        spriteRenderer.color = Color.white;
    }
}