using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;

    [SerializeField] private int currentWP = 0;
    [SerializeField] private float accuracy = 10;


    [SerializeField] private GameManager gameManager;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (gameManager.waypoints.Length == 0) return;
        if (Vector3.Distance(gameManager.waypoints[currentWP].transform.position, transform.position) < accuracy)
        {
            currentWP++;
            if (currentWP >= gameManager.waypoints.Length)
            {
                currentWP = 0;
            }
            navMeshAgent.SetDestination(gameManager.waypoints[currentWP].transform.position);
        }
    }


}
