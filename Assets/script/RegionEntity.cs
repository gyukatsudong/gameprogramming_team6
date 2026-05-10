using UnityEngine;

public class RegionEntity : MonoBehaviour
{
    public RegionData myData;
    public RegionUIController uiController;

    void OnMouseDown()
    {
        
        if (uiController != null && myData != null)
        {
            uiController.DisplayRegion(myData, transform.position);
        }
    }
}