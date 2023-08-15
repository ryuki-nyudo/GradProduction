
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{
    //移動ターゲット
	[SerializeField]
	private Transform m_Target;
    [SerializeField]
	private Transform m_Goal;

	private NavMeshAgent m_Agent;
    private bool change = false;

	void Start()
	{
		m_Agent = GetComponent<NavMeshAgent>();
        change = false;
	}

	void Update()
	{
        if(change == false){
		    m_Agent.SetDestination(m_Target.position);
        }
        else {
            m_Agent.SetDestination(m_Goal.position);
        }
	}

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Target"){
            change = true;
            Destroy(other.gameObject);
        }
    }
}