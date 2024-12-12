using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{
    public string targetTag = "Player";
    public static int scoreVal = 1;
    public static int endScore = 0;

    private Renderer objRend;    
    private Collider2D objCollide;

    Audio_ sfx;

    private void Awake()
    {
        sfx = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_>();
    }
    void Start()
    {
        
        objRend = GetComponent<Renderer>();
        objCollide = GetComponent<Collider2D>();

        if (objRend == null || objCollide == null)
        {
            Debug.LogError("Missing Renderer or Collider2D component.");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            
            FlagCount.Instance.IncreaseScore(scoreVal);
            sfx.playSFX(sfx.flag);
            endScore = FlagCount.Instance.IncreaseScore(0);
            Disappear();
        }
    }

    void Disappear()
    {
        if (objRend != null)
        {
            objRend.enabled = false; 
        }
        if (objCollide != null)
        {
            objCollide.enabled = false; 
        }
    }
}