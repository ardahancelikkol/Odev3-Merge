using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource click;
    private void Start()
    {
        click.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider wave)
    {
        if (wave.gameObject.CompareTag("Coin"))
        {
            Destroy(wave.gameObject);
            click.Play();
        }

    }
}
