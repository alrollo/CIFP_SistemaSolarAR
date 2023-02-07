using Cifp;
using System.Linq;
using UnityEngine;

public class LocationPlanet : MonoBehaviour
{
    void Start()
    {
        IDataProvider dao = new JsonDataProvider();
        
        var _id = this.gameObject.name;
        var planeta = CoreApp.Instance.Planetas.Where(x => x.Id == _id).FirstOrDefault();

        gameObject.transform.position = new Vector3(planeta.Distance, gameObject.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.localScale *= planeta.Size;
    }

}
