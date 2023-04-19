using UnityEngine;

public class TaskManagement : MonoBehaviour
{
    public GameObject taskPrefab;
    [SerializeField] private int prefabHeight;
    [SerializeField] private string[] tasks;
    
    // Start is called before the first frame update
    void Start()
    {
        //Based on https://forum.unity.com/threads/modify-the-width-and-height-of-recttransform.270993/
        RectTransform rt = (RectTransform)this.GetComponent(typeof(RectTransform));
        rt.sizeDelta = new Vector2(100, tasks.Length * prefabHeight + 5);
        foreach (string s in tasks)
        {
            string[] input = s.Split(",");
            CreateTask(input[0].Trim(), input[1].Trim());
        }
    }

    //Based on https://answers.unity.com/questions/260100/instantiate-as-a-child-of-the-parent.html
    public void CreateTask(string title, string note)
    {
        GameObject taskObject = taskPrefab;
        Task t = taskObject.GetComponent<Task>();
        t.SetTitle(title);
        t.SetNote(note);
        Instantiate(taskObject, Vector3.zero, Quaternion.identity, gameObject.transform);
    }
}
