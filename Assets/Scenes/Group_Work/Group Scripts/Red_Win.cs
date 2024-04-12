using UnityEngine;

public class Red_Win : MonoBehaviour
{
    public bool redWin = false;
    private Vector3 originalScale;
    public GameObject Text;

    private void Start()
    {
        originalScale = transform.localScale;
    }
    

    public void Update()
    {
        if (redWin)
        {
            ScaleUp();
            redWin = false;
        }
    }

     void ScaleUp()
    {
        transform.localScale = originalScale += new Vector3(2, 2, 2);
    }
}