using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cameraFollow : MonoBehaviour
{
    public Transform objectToFollow;
    public static bool temp = false;
    bool backAngle = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            print("switched angle");
            backAngle = !backAngle;
        }

        if (!backAngle){
            transform.position = new Vector3(objectToFollow.position.x+0.3f, objectToFollow.position.y+1.55f, objectToFollow.position.z+0.3f);

            Vector3 eulerRotation = new Vector3(objectToFollow.eulerAngles.x, objectToFollow.eulerAngles.y, objectToFollow.eulerAngles.z);
    
            transform.rotation = Quaternion.Euler(eulerRotation);
        } else {
            transform.position = new Vector3(objectToFollow.position.x, objectToFollow.position.y+1.6f, objectToFollow.position.z);

            Vector3 eulerRotation = new Vector3(objectToFollow.eulerAngles.x, objectToFollow.eulerAngles.y+180, objectToFollow.eulerAngles.z);
    
            transform.rotation = Quaternion.Euler(eulerRotation);
        }


        
    }

    void OnGUI () {

        if (!temp){
            return;
        }
        GUIStyle style = new GUIStyle(GUI.skin.box);
        style.fontSize = 40;

        if (parkArea.first && parkArea2.second){
            GUI.Box (new Rect (0,0,200,50), "Success!", style);
        } else {
            GUI.Box (new Rect (0,0,200,50), "Fail", style);
        }
    }

}
