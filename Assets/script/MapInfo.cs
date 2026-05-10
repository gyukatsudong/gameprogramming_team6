using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegionUIController : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI popText;
    public Image logoImage;

    private RectTransform rectTransform;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Start()
    {
        
        gameObject.SetActive(false);
    }

    public void DisplayRegion(RegionData data, Vector3 worldPosition)
    {
        
        nameText.text = data.regionName;
        popText.text = $"인구: {data.population:N0}명";
        if (logoImage != null) logoImage.sprite = data.logo;

        
        gameObject.SetActive(true);



    }

    // 닫기 버튼에 연결할 함수
    public void ClosePanel()
    {
        gameObject.SetActive(false);
    }
}