using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private int enemy_Health = 100;

    [SerializeField]
    private int enemy_Max_Health = 100;

    void EnemyHeath()
    {
        enemy_Health = GameObject.FindObjectOfType<Hit>().GetHit(30, enemy_Health);

        GameObject.FindObjectOfType<Game>().health_Text_enemy.text = enemy_Health.ToString();
        GameObject.FindObjectOfType<Game>().health_Image_enemy.fillAmount = enemy_Health / 100f;
    }

    private void Start()
    {
        GameObject.FindObjectOfType<Game>().health_Text_enemy.text = enemy_Health.ToString();
    }


    private void OnMouseDown()
    {
        GetComponent<Animator>().SetBool("Hit", true);
        GetComponent<Animator>().SetBool("Idle", false);
        EnemyHeath();
    }

    private void OnMouseUp()
    {
        GetComponent<Animator>().SetBool("Hit", false);
        GetComponent<Animator>().SetBool("Idle", true);
    }

    public void OnDestroy()
    {
        GetComponent<Animator>().SetBool("Death", true);
        GetComponent<Animator>().SetBool("Hit", false);
        GetComponent<Animator>().SetBool("Idle", false);
        GetComponent<Animator>().SetBool("Attack", false);
        Destroy(gameObject, 2);
    }

}
