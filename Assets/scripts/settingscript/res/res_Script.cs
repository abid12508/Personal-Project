using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class res_Script : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;

    private Resolution[] resolutions;

    private List<Resolution> filteredResolutions;

    private float currentrefreshrate;
    private int currentResolutionIndex = 0;

    void Start(){
        resolutions = Screen.resolutions;
        filteredResolutions = new List<Resolution>();

        resolutionDropdown.ClearOptions();
        currentrefreshrate = Screen.currentResolution.refreshRate;

        for(int i=0; i < resolutions.Length; i++){
            if(resolutions[i].refreshRate == currentrefreshrate){
                filteredResolutions.Add(resolutions[i]);
            }
        }

        List<string> options = new List<string>();

        for(int i = 0; i < filteredResolutions.Count; i++){

            string resolutionOption = filteredResolutions[i].width + "x" + filteredResolutions[i].height + " " + filteredResolutions[i].refreshRate + "HZ";
            options.Add(resolutionOption);
            if(filteredResolutions[i].width == Screen.width && filteredResolutions[i].height == Screen.height){
                currentResolutionIndex = 1;
            }


        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

    }

    public void SetResolution(int resolutionIndex){

        Resolution resolution = filteredResolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, true);
    }




    
    


}
