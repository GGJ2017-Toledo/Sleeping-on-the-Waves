using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

    private int playerDanger;
    private Animation animator;
    private Transform target;
    private bool moveSkikpe;


	void Start () {
        animator = GetComponent<Animation>();
      
    }
	
	
	void Update () {
	
	}
}
