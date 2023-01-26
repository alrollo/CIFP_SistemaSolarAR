using Cifp;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LoadInfo : MonoBehaviour
{
    void Start()
    {
        IDataProvider dao = new JsonDataProvider();
        var textObject = GetComponent<Text>();
        textObject.text = dao.GetInformacion();
    }
       
}
