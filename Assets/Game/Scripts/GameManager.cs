using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;

    public TextMeshProUGUI moneyText;

    public void AddMoney()
    {
        player.money += player.clickPower;
        UpdateMoneyText();
    }

    public bool RemoveMoney(float value)
    {
        if (player.money >= value)
        {
            player.money -= value;
            UpdateMoneyText();
            return true;
        }
        print("Not enough money");
        return false;
    }

    public void UpdateText(TextMeshProUGUI upgradeCost,float cost, TextMeshProUGUI upgradeNumber, float number)
    {
        upgradeCost.text = "Cost : " + cost.ToString() + "$";
        upgradeNumber.text = "lvl " + number.ToString();
    }

    private void UpdateMoneyText()
    {
        if (player.money > 1000)
        {
            moneyText.text = (player.money / 1000).ToString("N2") + "K $";
        }
        else
        {
            moneyText.text = player.money.ToString("N2") + "$";
        }
    }
}