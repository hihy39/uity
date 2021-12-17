using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.eggAmount += 1;
        Destroy(gameObject);
        Sfx.SoundPlay();
    }
}
