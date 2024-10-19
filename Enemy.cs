using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Hp = 1001;
    public float Exp = 100; 

    private GameManager gm;
    private LevelManager LM;

    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        LM = FindObjectOfType<LevelManager>();
    }

    private void Update()
    {
        Die();
    }

    public void TakeDamage(float value)
    {
        Hp -= value;
    }

    public void Die()
    {
        if (Hp <= 0)
        {
            Destroy(this.gameObject);

            LM.AddExperience(Exp);
        }
    }
}
