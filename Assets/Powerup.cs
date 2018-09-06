using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public enum Type // Powerup.Type
    {
        None,
        Slowmo,
        Health,
        JetpackBoost
    }

    public Type type;

}
