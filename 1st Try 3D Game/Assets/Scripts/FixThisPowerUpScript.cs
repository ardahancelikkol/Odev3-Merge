using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using MusicFiles;

public class PowerUpScript : MonoBehaviour
{
    private GameObject _music;
    private MusicFile _musicFile;
    private ThirdPersonController _tpController;
    [SerializeField] private int Number;

    private void Start()
    {
        _music = GameObject.Find("AuidoManager");
        _musicFile = _music.GetComponent(typeof(MusicFile)) as MusicFile;
        _tpController = GetComponent<ThirdPersonController>();
    }

    private void OnTriggerEnter(Collider wave)
    {
        if (wave.gameObject.CompareTag("powerup"))
        {
            Destroy(wave.gameObject);
            AudioSource.PlayClipAtPoint(_musicFile.Music[Number], gameObject.transform.position);
            _tpController.SprintSpeed = 10.0f;
            Invoke("BackToNormalSpeed", 4.0f);
        }
    }

    private void BackToNormalSpeed()
    {
        _tpController.SprintSpeed = 5.33f;
    }

}
