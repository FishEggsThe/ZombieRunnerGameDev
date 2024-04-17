using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    float chaseRange = 20;
    bool isProvoked = false;
    float turnSpeed = 5f;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked) {
            EngageTarget();
        } else if (distanceToTarget <= chaseRange) {
            isProvoked = true;
        }
    }

    private void OnDamageTaken()
    {
       isProvoked = true; 
    }

    private void EngageTarget()
    {
        FaceTarget();
        if (distanceToTarget >= navMeshAgent.stoppingDistance) {
            ChaseTarget();
        }
        if (distanceToTarget <= navMeshAgent.stoppingDistance) {
            AttackTarget();
        }
    }
    private void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
    }
    private void AttackTarget()
    {
        GetComponent<Animator>().SetBool("attack", true);
        //Debug.Log(name + "is eating your brains " + target.name + "!");
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
    }

    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = new Color(1, 1, 0, 0.75F);
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
