# Unity-echo3D-Demo-WhackAMole
Play the famous game in Unity!

## Setup
* Built with Unity 2020.3.25.  _(Note: The echo3D Unity SDK is supported in 2020.3.25 and higher.)_
* Register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).
* [Add the Unity SDK](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation). Troubleshoot [here](https://docs.echo3d.com/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity).
* Clone this repo. 


## Setup
* [Add these models](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D console from the Unity Assets/Models folder: <br>
   - Mole <br>
* Open the _SampleScene_ scene in Unity.
* [Set the API key](https://docs.echo3d.co/quickstart/access-the-console) and Entry IDs for the same "Mole" prefab in the Inspector. <br>
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/195749269-f7a43477-b67a-49e8-a212-6abdb9c948fd.png)<br>
![NEWAPIKeyandEntryID](https://user-images.githubusercontent.com/99516371/205407613-b746840f-8e8a-4ec8-b056-a680395dfab4.png)<br>
* [Type your Secret Key](https://docs.echo3d.co/web-console/deliver-pages/security-page#secret-key) as the value for the parameter secKey in the file Packages/co.echo3D.unity/Runtime/Echo3DHologram.cs. _(Note: Secret Key only matters if you have the Security Key enabled). You can turn it off in the Security options in your echo3D console._
![NEWSecKey2](https://user-images.githubusercontent.com/99516371/195749308-b2349a3b-7e43-4d3c-8f09-fbfa9d3cb0be.png)<br>
* (Recommended) To move, resize or edit the assets live in your Scene view, check the boxes for “Editor Preview” and “Ignore Model Transforms”. To enable this, click Echo3D > Load Editor Holograms in your Unity toolbar. <br>
![EditorPreviewAndIgnoreModelTransforms](https://user-images.githubusercontent.com/99516371/195749348-dc0b06ad-efa6-4dbd-962f-0119b5c33ea0.png)<br>
![LoadHolograms](https://user-images.githubusercontent.com/99516371/195749354-b2295183-f877-444a-af22-ed87ffb17705.png) <br>


## Run
Press Play in Unity. Click on the moles to whack them. You have 20 seconds.

## Learn More
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Sources
* Mole asset: [freepik](https://www.freepik.com/free-vector/lovely-happy-groundhog-day-background_832681.htm#query=mole&position=22&from_view=searchh) <br>
Hammer and title: Canva

## Screenshots
![WhackAMoleGIF](https://user-images.githubusercontent.com/99516371/176973343-caf748e0-4903-44e1-9d74-92d9df505589.gif)
![Cover](https://user-images.githubusercontent.com/99516371/176973363-053f608f-ae3c-4a3a-8460-7ff3e9147ccd.png)


