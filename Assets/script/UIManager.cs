using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject Seoul_map;
    public GameObject MapInfo;
    //  설정창 상태 확인용
    public static bool isSettingsOpen = false;

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        MapInfo.SetActive(false);
        Time.timeScale = 0f;
        Seoul_map.SetActive(false);
        isSettingsOpen = true; 
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        Time.timeScale = 1f;
        Seoul_map.SetActive(true) ;
        isSettingsOpen = false;
        
    }

 


}
