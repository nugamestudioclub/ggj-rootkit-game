using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> _clips;

    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static AudioManager Instance { get; private set; }

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

    public void Balloon()
    {
        _audioSource.PlayOneShot(_clips[0]);
    }

    public void Stun()
    {
        _audioSource.PlayOneShot(_clips[1]);
    }

    public void DialUp()
    {
        _audioSource.PlayOneShot(_clips[5]);
    }

    public void Explosion()
    {
        _audioSource.PlayOneShot(_clips[6]);
    }

    public void Shoot()
    {
        _audioSource.PlayOneShot(_clips[8]);
    }
    
    public void DecoyBlip()
    {
        _audioSource.PlayOneShot(_clips[10]);
    }

    public void Damage()
    {
        _audioSource.PlayOneShot(_clips[3]);
    }

    public void Move()
    {
        _audioSource.PlayOneShot(_clips[11]);
    }

    public void Barrier()
    {
        _audioSource.PlayOneShot(_clips[12]);
    }
}