using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public float life = 100;
    public float impact = 0.7f;

    public void SetAtaque(float value)
    {
        if (value >= 0.1f)
            life -= Time.deltaTime * impact;
        
    }

}
