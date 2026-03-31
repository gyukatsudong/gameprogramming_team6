using UnityEngine;


public class Player
{
    private int hp = 100;

    public void Attack(int a)
    {

        Debug.Log(a+ "만큼의 데미지를 입혔다.");
    }
    
    public void Damage(int b)
    {
        hp = hp -= b;
        Debug.Log(b+ "만큼의 데미지를 입었다.");
        Debug.Log("피가 "+ hp + "만큼 남았다.");

    }

}
public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player mPlayer = new Player();
        mPlayer.Attack(20);
        mPlayer.Damage(50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
