using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    public double HidingTime;
    public GameObject Players;
    private List<Player> PlayerList = new List<Player>();
    private double RemainingTime;
    private bool IsTimeOver;

    // Start is called before the first frame update
    void Start()
    {
        RemainingTime = HidingTime;
        IsTimeOver = false;
        PlayerList = Players.GetComponentsInChildren<Player>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsTimeOver)
        {
            RemainingTime -= Time.deltaTime;
            IsTimeOver = RemainingTime <= 0;
        } else
        {
            EndOfRound();
            // Temporal: Resetea la ronda
            RemainingTime = HidingTime;
            IsTimeOver = false;
        }
    }

    void EndOfRound()
    {
        foreach (Player player in PlayerList)
        {
            if (!player.IsHiding())
            {
                Debug.Log(player);
            }
            else
            {
                int securityPercentage = player.GetCurrentRoom().SecurityPercentage;
                int randInt = (int)(Random.value * 100f);
                bool dead = securityPercentage < randInt;
                Debug.Log("Security = " + securityPercentage);
                Debug.Log("Random = " + randInt);
                if (dead) {
                    Debug.Log(player + " ):");
                }
                else
                {
                    Debug.Log(player + " (:");
                }
            }
        }
    }

    bool SeAcaboElTiempoDeEscondite()
    {
        return IsTimeOver;
    }
}
