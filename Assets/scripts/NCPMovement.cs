using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class NCPMovement: MonoBehaviour
    {
        public int speed = 5;
        public int range;
        public Transform target;

        private void Update()
        {
            if (target != null)
            {
                float distance = Vector2.Distance(transform.position, target.position);
                if (distance <= range)
                {
                    Vector2 direction = (target.position - transform.position).normalized;
                    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                }
            }
        }
    }
}