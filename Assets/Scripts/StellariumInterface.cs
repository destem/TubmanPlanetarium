using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class StellariumInterface : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("Upload");
        }
	}

    IEnumerator Upload()
    {
       
        WWWForm form = new WWWForm();
        form.AddField("fov", "90");

        UnityWebRequest www = UnityWebRequest.Post("http://localhost:8090/api/main/fov", form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
            
        
    }

}
