using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour
{
    private int smile;
    private int ears;
    private int arms;
    private int hat;
    private int sex;

//Constructors
    public Potato() {
         smile = 0;
         ears = 0;
         arms = 0;
         hat = 0;
         sex = 0;
    }

    public Potato(int smile, int ears, int arms, int hat, int sex) {
        this.smile = smile;
        this.ears = ears;
        this.arms = arms;
        this.hat = hat;
        this.sex = sex;
    }

//Method of sex
    public void sexytime (Potato partner) {
        new Potato();
    }

//GET commands
    public int getSmile() {
        return smile;
    }
    public int getEars() {
        return ears;
    }
    public int getArms() {
        return arms;
    }
    public int getHat() {
        return hat;
    }
    public int getSex() {
        return sex;
    }

//Set commands

    public void setSmile(int smile) {
        if (smile > 3) {
            smile = 0;
        }
        if (smile < 0) {
            smile = 0;
        }
        this.smile = smile;
    }
    public void setEars(int ears) {
        if (ears > 3) {
            ears = 0;
        }
        if (ears < 0) {
            ears = 0;
        }
        this.ears = ears;
    }
    public void setArms(int arms) {
        if (arms > 3) {
            arms = 0;
        }
        if (arms < 0) {
            arms = 0;
        }
        this.arms = arms;
    }
    public void setHat(int hat) {
        if (hat > 3) {
            hat = 0;
        }
        if (hat < 0) {
            hat = 0;
        }
        this.hat = hat;
    }
    public void setSex(int sex) {
        if (sex > 3) {
            sex = 0;
        }
        if (sex < 0) {
            sex = 0;
        }
        this.sex = sex;
    }
}
