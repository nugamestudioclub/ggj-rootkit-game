using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{

    public GameObject EnemyTarget {
        get => target;
        set => target = value;
    }

    public float HackCooldown { get; set; }
    public float DecoyCooldown { get; set; }
    public float BarrierCooldown { get; set; }



    public int PlayerHealth { get; private set; }
    [SerializeField]
    private int maxPlayerHealth = 3;

    public static GameState Instance { get; private set; }

    private GameObject target;
    private GameObject player;
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
    private void Update()
    {
        //Debug.Log($"Hack CD {HackCooldown}");
        //Debug.Log($"Decoy CD {DecoyCooldown}");
        //Debug.Log($"Barrier CD {BarrierCooldown}");
    }

    public GameObject FindPlayer()
    {
        return GameObject.FindWithTag("Player");
    }

    public void ResetPlayerHealth()
    {
        PlayerHealth = maxPlayerHealth;
    }

    public void DamagePlayer(int value)
    {
        PlayerHealth -= value;
        if (PlayerHealth <= 0 )
        {
            PlayerDie();
        }
    }

    public void PlayerDie()
    {
        //TODO Transition to Game over screen
        
    }
}
