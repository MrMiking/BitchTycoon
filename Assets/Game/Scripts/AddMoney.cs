using UnityEngine;

public class AddMoney : MonoBehaviour
{
    public GameManager gameManager;

    public void AddPlayerMoney()
    {
        gameManager.AddMoney();
    }
}
