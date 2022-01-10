using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;

    [SerializeField] private int currentWP = 0;
    [SerializeField] private float accuracy = 1;


    [SerializeField] private GameManager gameManager;
    private Animator animator;

    private GameObject[] waypoints;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        waypoints = gameManager.waypoints;
    }

    private void Update()
    {
        // Debug.Log(Vector3.Distance(waypoints[1].transform.position, transform.position));



        CircleWalk();

    }

    private void CircleWalk()
    {
        if (waypoints.Length == 0) return;
        if (Vector3.Distance(waypoints[currentWP].transform.position, transform.position) < accuracy)
        {
            currentWP++;
            if (currentWP >= waypoints.Length)
            {
                currentWP = 0;
            }

            animator.SetBool("Walk", true);
            navMeshAgent.SetDestination(waypoints[currentWP].transform.position);
        }
    }

    // private void OnCollisionEnter(Collision other)
    // {
    //     animator.SetBool("Walk", false);
    // }


}
