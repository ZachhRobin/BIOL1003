using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
        [SerializeField]
        KeyCode sex;
    public Potato child;
    int arms = 0;
    int ears = 0;
    int hat = 0;
    int smile = 0;
    // Start is called before the first frame update
    void Start()
    {
        Potato child = new Potato();
    }
    private int randomHelper() {
        int rand = UnityEngine.Random.Range(0,3);
        if (rand == 0) {return 1;}
        if (rand == 1) {return 4;}
        return 3;
    }
    private int sexHelper(int gene1, int gene2){
        // 3 is reccessive, // 1 and 2 mixed 0 is dominant
        // Reccesive both
        if (gene1 == 3 && gene2 == 3){
            return 3;
        }
        // Dominant both
        if (gene1 == 0 && gene2 == 0) {
            return 0;
        }
        // Mixed and Double recessive 50/50 recessive mixed
        if ((gene1 is 1 or 2 && gene2 == 3) || (gene1 == 3 && gene2 is 1 or 2)){
            return UnityEngine.Random.Range(2,4);
        }
        // Mixed and Double Dominant
        if (gene1 is 0 && (gene2 is 1 or 2) || (gene1 is 1 or 2 && gene2 is 0)){
            return UnityEngine.Random.Range(0,2);
        }
        // Mixed and Mixed
        if (gene1 is 1 or 2 && gene2 is 1 or 2){
            return randomHelper();
        }
        return 0;
    }

    public Potato Sex(Potato parent1, Potato parent2) {
        Potato resultPotato = new Potato();
        resultPotato.setArms(sexHelper(parent1.getArms(), parent2.getArms()));
        resultPotato.setEars(sexHelper(parent1.getEars(), parent2.getEars()));
        resultPotato.setHat(sexHelper(parent1.getHat(), parent2.getHat()));
        resultPotato.setSmile(sexHelper(parent1.getSmile(), parent2.getSmile()));
        return resultPotato;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(sex)) {
            child = Sex(GameObject.Find("Parent1").GetComponent<potatoBehavior>().getPotato(), GameObject.Find("Parent2").GetComponent<potatoBehavior>().getPotato());
        arms = child.getArms();
        ears = child.getEars();
        hat = child.getHat();
        smile = child.getSmile();
        }
        
//ARMS 3 recessive
        if ( arms == 3) {
            transform.GetChild (4).transform.localScale = new Vector3(0,0,0);
            transform.GetChild (5).transform.localScale = new Vector3(0,0,0);
        } else if ( arms == 2 || arms == 1 ) {
            transform.GetChild (4).transform.localScale = new Vector3(1,1,1);
            transform.GetChild (5).transform.localScale = new Vector3(0,0,0);
        } else {
            transform.GetChild (4).transform.localScale = new Vector3(0,0,0);
            transform.GetChild (5).transform.localScale = new Vector3(1,1,1);
         }
//EARS 3 recessive
        if (ears == 3 || ears == 2) {
            transform.GetChild (3).transform.localScale = new Vector3(0,0,0);
        } else {
            transform.GetChild (3).transform.localScale = new Vector3(1,1,1);
        }
//SMILE 3 Recessive
        if (smile == 3 ) {
            transform.GetChild (1).transform.localScale = new Vector3(1,1,1);
            transform.GetChild (2).transform.localScale = new Vector3(0,0,0);
        } else {
            transform.GetChild (1).transform.localScale = new Vector3(0,0,0);
            transform.GetChild (2).transform.localScale = new Vector3(1,1,1);
        }
//HAT AND SHOES
        if (hat == 3) {
            transform.GetChild (0).transform.localScale = new Vector3(1,1,1);
            transform.GetChild (6).transform.localScale = new Vector3(0,0,0);
        } else if (hat == 2 || hat == 1) {
            transform.GetChild (0).transform.localScale = new Vector3(1,1,1);
            transform.GetChild (6).transform.localScale = new Vector3(1,1,1);
        } else {
            transform.GetChild (6).transform.localScale = new Vector3(1,1,1);
            transform.GetChild (0).transform.localScale = new Vector3(0,0,0);
    }
    }}
