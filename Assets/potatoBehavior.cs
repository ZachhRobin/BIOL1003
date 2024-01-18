using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class potatoBehavior : MonoBehaviour
{
    [SerializeField]
    KeyCode One;
    [SerializeField]
    KeyCode Two;
    [SerializeField]
    KeyCode Three;
    [SerializeField]
    KeyCode Four;
    public Potato parent;
    int arms;
    int ears;
    int hat;
    int smile;

    // Start is called before the first frame update
    void Start()
    {
        parent = new Potato();
        
    }

    public Potato getPotato(){
        return parent;
    }

    // Update is called once per frame
    void Update()
    {

        arms = parent.getArms();
        ears = parent.getEars();
        hat = parent.getHat();
        smile = parent.getSmile();

                if (Input.GetKeyDown(One)) {
            parent.setArms( arms += 1);
        }
            if (Input.GetKeyDown(Two)) {
            parent.setEars( ears += 1);
        }
            if (Input.GetKeyDown(Three)) {
            parent.setHat( hat += 1);
        }
            if (Input.GetKeyDown(Four)) {   
            parent.setSmile( smile += 1);
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
    }
}
