using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    private bool camAviailable;
    private WebCamTexture backCamera;
    private Texture defaultBackground;

    public RawImage background;
    public AspectRatioFitter fit;

   

    // Start is called before the first frame update
    void Start()
    {
        defaultBackground = background.texture;
        WebCamDevice[] devvices = WebCamTexture.devices;
        if (devvices.Length==0)
        {
            camAviailable = false;
            return;
        }
        for (int i = 0; i < devvices.Length; i++)
        {
            if (!devvices[i].isFrontFacing)
            {
                backCamera = new WebCamTexture(devvices[i].name, Screen.width, Screen.height);
            }
        }
        if (backCamera==null)
        {
            return;
        }
        backCamera.Play();
        background.texture = backCamera;
        camAviailable = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (!camAviailable)
        {
            return;
        }
        float ratio = (float)backCamera.width / (float)backCamera.height;
        fit.aspectRatio = ratio;

        float scaly = backCamera.videoVerticallyMirrored ? -1f : 1f;
        background.rectTransform.localScale = new Vector3(1f, scaly, 1f);

        int orient = -backCamera.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
    }
}
