using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float delayTime = 2f;
    [SerializeField] ParticleSystem crashEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", delayTime);
        }
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

