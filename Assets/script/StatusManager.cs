using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public GameObject StatusPanel;





    public void StatusUIopen()
    {
        StatusPanel.SetActive(true);
    }

    public void StatusUIclose()
    {
        StatusPanel.SetActive(false);
    }

}
