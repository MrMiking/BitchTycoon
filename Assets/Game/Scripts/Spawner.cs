using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject money;

    public void SpawnMoney()
    {
        Vector3 randomPos = new Vector3(Random.Range(money.transform.localScale.x,transform.localScale.x - money.transform.localScale.x),transform.position.y,transform.position.z);
        Instantiate(money, randomPos, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}
