using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    private Animator animator;
	private int livePoints = 100;

    void Start()
    {
		animator = GetComponent<Animator>();
		animator.SetTrigger("Idle");
		animator.SetTrigger("Walking");    
    }

    void Update()
    {
        
    }

	void OnCollisionEnter(Collision bullet)
	{
		if (bullet.gameObject.name == "projectile")
		{
			livePoints -= 35;
			if (livePoints <= 0)
				Destroy(gameObject);	
			Destroy(bullet.gameObject);
		}
	}
}
