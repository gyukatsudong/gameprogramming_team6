using UnityEngine;
using UnityEngine.EventSystems;

public class RegionEntity : MonoBehaviour
{
    public RegionData myData;
    public RegionUIController uiController;
    public GameObject Region;
    public GameObject Mapinfo;
    public District District;
    private RectTransform rect;

    private void Start()
    {
        // RectTransform Ä³½Ì
        rect = Mapinfo.GetComponent<RectTransform>();
        Mapinfo.SetActive(false);
    }

    public void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (uiController != null && myData != null && rect != null && District.currentSelected != null)
        {
            Mapinfo.SetActive(true);
            Vector3 screenPos = Camera.main.WorldToScreenPoint(Region.transform.position);


            float targetX = screenPos.x + 150f;
            float targetY = screenPos.y;
            Debug.Log(targetX);
            if (targetY >= 1600f)
            {
                targetY -= 400f;
            }
            if (targetY <= 900f)
            {
                targetY += 300f;
            }
            if (targetX >= 2800f)
            {
                targetX -= 1800f;
            }
            rect.position = new Vector2(targetX, targetY);

            uiController.DisplayRegion(myData, targetX, targetY);

        }
 
    }
}