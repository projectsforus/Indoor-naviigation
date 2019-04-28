using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UINavigations : MonoBehaviour {

    public RectTransform menuContainer;
    private Vector3 desiredMenuPosition;

	// Update is called once per frame
	void Update () {
        menuContainer.anchoredPosition3D = Vector3.Lerp(menuContainer.anchoredPosition3D, desiredMenuPosition, 0.5f);
        
    }

    public void NavigationRight(int Nav)
    {
        desiredMenuPosition = Vector3.right * 480 * Nav;
    }
   
    
}
