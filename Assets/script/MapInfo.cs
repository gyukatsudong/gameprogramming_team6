using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegionUIController : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI popText;
    public Image logoImage;
    public MapUIManager mapUIManager;
    private RectTransform rectTransform;
    
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Start()
    {
        
        gameObject.SetActive(false);
    }

    public void DisplayRegion(RegionData data, float x, float y)
    {
        gameObject.SetActive(true);
        
        nameText.text = data.regionName;
        //popText.text = $"intel: {District.intel}";
        if (logoImage != null) logoImage.sprite = data.logo;

        

    }

   
    public void ClosePanel()
    {
        gameObject.SetActive(false);
        if (District.currentSelected != null)
        {
            District.currentSelected.Deselect();
            District.currentSelected = null;
        }
    }
}