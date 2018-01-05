using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform Player; //refers to trasngorm of player model
    public Vector3 offset;
    // Update is called once per frame
	void Update () {
        transform.position = Player.position + offset;
	}
}
