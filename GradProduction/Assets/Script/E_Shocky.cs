using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class E_Shocky : MonoBehaviour
{
	[SerializeField]
	private Transform m_Check;
    [SerializeField]
    private Transform m_Goal;

	private NavMeshAgent m_Agent;

    private bool check = false;

	void Start()
	{
		m_Agent = GetComponent<NavMeshAgent>();
        check = false;
	}

	void Update()
	{
        if(check == false){
		    m_Agent.SetDestination(m_Check.position);
        }
        else {
            m_Agent.SetDestination(m_Goal.position);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        //接触したオブジェクトのタグが"Player"のとき
        if (other.gameObject.tag == "Goal"){
            Destroy(other.gameObject);
            check = true;
        }
    }
}