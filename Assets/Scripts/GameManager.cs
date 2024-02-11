using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject spinCube;
    [SerializeField] private Animator spinCubeAnimator;

    [SerializeField] private GameObject chest;
    [SerializeField] private Animator chestAnimator;

    // Start is called before the first frame update
    void Start()
    {
        spinCube.SetActive(true);
        chest.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleAnim()
    {
        if(spinCube.activeSelf == true)
        {
            spinCubeAnimator.SetBool("Spin", !spinCubeAnimator.GetBool("Spin"));
        }
        else if (chest.activeSelf == true)
        {
            chestAnimator.SetBool("Open", !chestAnimator.GetBool("Open"));
        }
    }

    public void ToggleObj()
    {
        spinCube.SetActive(!spinCube.activeSelf);
        chest.SetActive(!chest.activeSelf);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
