using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public double HidingTime;
    public GameObject Players;

    public MonsterManager monster;

    public CameraManager cm;

    public TextMeshProUGUI tmp;
    private List<Player> PlayerList = new List<Player>();
    private double RemainingTime;
    private bool IsTimeOver;

    void Start()
    {
        RemainingTime = HidingTime;
        IsTimeOver = false;
        PlayerList = Players.GetComponentsInChildren<Player>().ToList();

        cm.set1();

    }

    void Update()
    {
        if (!IsTimeOver)
        {
            tmp.text = System.Math.Round(RemainingTime, 2).ToString();
            RemainingTime -= Time.deltaTime;
            IsTimeOver = RemainingTime <= 0f;
        } else
        {
            tmp.text = "0";
            tmp.color = Color.red;
            this.EndOfHide();
        }
    }

    void EndOfHide()
    {

        cm.set1();
        monster.liberarMonstruo();

    }

}
