using UnityEngine;

public class dice : MonoBehaviour
{
    public Sprite[] diceSprites; // 6°³ ³Ö±â
    private SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void RollDice()
    {
        int random = Random.Range(0, 6);
        sr.sprite = diceSprites[random];
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RollDice();
        }
    }
}
