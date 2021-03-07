using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class NPC : MonoBehaviour
{
    [SerializeField]
    protected float health = 100;
    [SerializeField]
    protected int ammo = 64;

    protected NavMeshAgent nma;

    private void Awake()
    {
        nma = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        move();
    }


    protected abstract void move();


}
