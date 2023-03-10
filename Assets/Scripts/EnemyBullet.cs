using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int playerLayer;

    [SerializeField]
    private int damage = 1;

    private int _spriteMode;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.identity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        if (obj.layer == playerLayer && obj.CompareTag("Player"))
        {
            GameState.Instance.DamagePlayer(damage);
        }
        Destroy(gameObject);
    }



}
