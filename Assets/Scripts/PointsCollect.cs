using UnityEngine;
using System.Collections;

public class PointsCollect : MonoBehaviour
{

    private Animator animatorPoint;

    void Start(){

        animatorPoint = GetComponent<Animator>();

    }
  
    void OnTriggerEnter2D(Collider2D col){

        if(col.CompareTag("Player")){

            animatorPoint.SetBool("canScale", true);
            UIManager.playerScore = UIManager.playerScore + 10;
            AudioManager.instanceSound.PlayPointSound();
            StartCoroutine(PointDestroy());

        }

         if(col.CompareTag("Fruit")){

            Destroy(gameObject);

        }

    }

    IEnumerator PointDestroy(){

        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);

    }

}
