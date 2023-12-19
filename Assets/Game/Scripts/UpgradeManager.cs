using TMPro;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public TextMeshProUGUI upgradeCost;
    public TextMeshProUGUI upgradeNumber;

    public GameManager gameManager;
    public Upgrader upgrader;

    private void Awake()
    {
        gameManager.UpdateText(upgradeCost, upgrader.cost, upgradeNumber, upgrader.number);
    }
    public void Upgrade()
    {
        if (gameManager.RemoveMoney(upgrader.cost))
        {
            upgrader.cost *= upgrader.costMultiplier;
            gameManager.player.clickPower *= upgrader.multiplier;
            upgrader.number += 1;
            gameManager.UpdateText(upgradeCost, upgrader.cost, upgradeNumber, upgrader.number);
        }
    }
}