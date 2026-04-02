using UnityEngine;


public class map_controller : MonoBehaviour
{


    private void OnMouseEnter()
    {
        IncreaseScale(true);
    }


    private void OnMouseExit() 
    {
        IncreaseScale(false);
    }


    private Vector3 initialScale;
    private Vector3 initialPosition;
    private void Awake()
    {
        initialScale = transform.localScale;
        initialPosition = transform.localPosition;
    }


    private void IncreaseScale(bool status)
    {
        Vector3 finalScale = initialScale;
        Vector3 finalPosition = initialPosition;

        if (status)
        {
            finalScale = initialScale * 1.1f;
            finalPosition.z = 10;

        }

        transform.localScale = finalScale;
        transform.localPosition = finalPosition;
    }
}