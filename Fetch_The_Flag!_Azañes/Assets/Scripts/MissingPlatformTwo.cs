using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MissingPlatformTwo : MonoBehaviour
{
    public float disappearDuration = 8f;

    private Renderer platRend;
    private Collider2D platCollide;

    void Start()
    {
        platRend = GetComponent<Renderer>();
        platCollide = GetComponent<Collider2D>();

        if (platRend == null || platCollide == null)
        {
            Debug.LogError("Missing Renderer or Collider2D component.");
            return;
        }

        StartCoroutine(PlatformVisibility());
    }

    IEnumerator PlatformVisibility()
    {
        while (true)
        { 
            SetPlatformVisible(true);
            yield return new WaitForSeconds(disappearDuration);

            SetPlatformVisible(false);
            yield return new WaitForSeconds(disappearDuration);
        }
    }

    void SetPlatformVisible(bool visible)
    {
        if (platRend != null)
        {
            platRend.enabled = visible;
        }
        if (platCollide != null)
        {
            platCollide.enabled = visible;
        }
    }
}

