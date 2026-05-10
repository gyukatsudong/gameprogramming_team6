using UnityEngine;

[CreateAssetMenu(fileName = "NewRegion", menuName = "GameData/Region")]
public class RegionData : ScriptableObject
{
    public string regionName;   // 지역 이름 (예: 강남구)
    public int population;      // 인구수
    public Sprite logo;         // 지역 로고 이미지
}