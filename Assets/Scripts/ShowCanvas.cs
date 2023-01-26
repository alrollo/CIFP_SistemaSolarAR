using Cifp;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ShowCanvas : MonoBehaviour
{
    public Canvas Canvas;

    public void OnMouseDown()
    {
        IDataProvider dao = new JsonDataProvider();
        var planetas = dao.GetPlanetas();

        var _id = this.gameObject.name;
        var planeta = planetas.Where(x => x.Id == _id).FirstOrDefault();

        if (planeta == null) {
            Debug.Log("No se ha encontrado información de `" + _id + "`");
            return;
        }




        this.BindInformation(planeta);
        this.Canvas.gameObject.SetActive(true);
    }

    private void BindInformation(Planeta planeta)
    {
        var textComponents = this.Canvas.gameObject.GetComponentsInChildren<Text>();
        var imageComponents = this.Canvas.gameObject.GetComponentsInChildren<Image>();

        var title = textComponents.Where(x => x.name == "Title").FirstOrDefault();
        var description = textComponents.Where(x => x.name == "Info").FirstOrDefault();
        var image = imageComponents.Where(x => x.name == "Image").FirstOrDefault();

        if (title != null)
            title.text = planeta.Name;

        if (description != null)
            description.text = planeta.Description;

        if (image != null)
        {
            image.sprite = Resources.Load<Sprite>($"Planetas/{planeta.Image}");
        }

       
    }
}
