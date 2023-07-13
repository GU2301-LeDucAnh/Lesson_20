using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    [SerializeField] private GameObject imgIcon;
    [SerializeField] private Text coinSpentTxt;
    [SerializeField] private Text playerLvCanUlock;
    [SerializeField] private Text rewardCoinTxt;
    [SerializeField] private Text rewardExpTxt;
    public void Init(GameObject imgIcon, int coinSpent, int playerLvCanUlock, int rewardCoin, int rewardExp)
    {
        this.imgIcon = imgIcon;
        this.coinSpentTxt.text = coinSpent.ToString();
        this.playerLvCanUlock.text = playerLvCanUlock.ToString();
        this.rewardCoinTxt.text = rewardCoin.ToString();
        this.rewardExpTxt.text = rewardExp.ToString();
    }
}
