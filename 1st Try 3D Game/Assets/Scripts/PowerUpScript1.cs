using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using MusicFiles;

public class PowerUpScript1 : MonoBehaviour
{
    private MusicFile _musicFile;
    private ThirdPersonController _tpController;
    [SerializeField] private int _clipIndex = 0; // The index of the AudioClip to play

    private void Start()
    {
        _musicFile = GameObject.Find("AudioManager").GetComponent<MusicFile>();
        _tpController = GetComponent<ThirdPersonController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("powerup"))
        {
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(_musicFile.Music[_clipIndex], other.transform.position);
            _tpController.SprintSpeed = 10.0f;
            Invoke("ReturnToNormalSpeed", 4.0f);
        }
    }

    private void ReturnToNormalSpeed()
    {
        _tpController.SprintSpeed = 5.33f;
    }
}
