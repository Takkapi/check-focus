using UnityEngine;

public class CheckFocus : MonoBehaviour
{
    #if UNITY_EDITOR
    private GameObject lastGameObject = null;
    protected void Update()
    {
        GameObject currentGameObject = UnityEngine.EventSystems.EventSystem.current?.currentSelectedGameObject;
        if(lastGameObject != currentGameObject) {
            lastGameObject = currentGameObject;
            if(currentGameObject == null) Debug.Log("Selection: NONE");
            else Debug.Log("Selection: " + currentGameObject.name);
        }
    }
    #endif
}
