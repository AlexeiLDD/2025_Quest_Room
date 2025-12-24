using UnityEngine;

public class BasketLogic : MonoBehaviour
{
    [Header("Объекты шаров")]
    public GameObject ballRed;
    public GameObject ballGreen;

    [Header("Объект двери")]
    public GameObject door;

    private bool redInside = false;
    private bool greenInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ballRed)
        {
            redInside = true;
            Debug.Log("Красный шар в корзине");
        }

        if (other.gameObject == ballGreen)
        {
            greenInside = true;
            Debug.Log("Зеленый шар в корзине");
        }

        CheckConditions();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == ballRed) redInside = false;
        if (other.gameObject == ballGreen) greenInside = false;
    }

    void CheckConditions()
    {
        if (redInside && greenInside)
        {
            if (door != null) door.SetActive(false);

            GameObject ghostCube = GameObject.Find("DontDestroyOnLoad");
            if (ghostCube != null)
            {
                Destroy(ghostCube);
                Debug.Log("Куб-призрак уничтожен!");
            }
        }
    }
}
