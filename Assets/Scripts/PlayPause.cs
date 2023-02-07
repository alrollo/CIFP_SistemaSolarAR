using UnityEngine;

public class PlayPause : MonoBehaviour
{
    public void BtnPlayPauseOnClick()
    {
        CoreApp.Instance.Settings.IsPlaying = !CoreApp.Instance.Settings.IsPlaying;
        CoreApp.Instance.Settings.Save();
    }
}
