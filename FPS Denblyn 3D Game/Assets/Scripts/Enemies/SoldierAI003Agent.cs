using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SoldierAI003Agent : MonoBehaviour
{
    SoldierAI003 AI003;
    [SerializeField] private Renderer myObject;

    public Transform player;
    public Transform tempPos;
    private Transform originalPos;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
	originalPos = tempPos;
        agent = GetComponent<NavMeshAgent>();
        myObject.material.color = Color.blue;
        AI003 = FindObjectOfType<SoldierAI003>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AI003.lookingAtPlayer == true)
            agent.destination = player.position;
	    else
	        agent.destination = originalPos.position;
    }
}
