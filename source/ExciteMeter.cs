using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using SimpleJSON;
using MacGruber;

namespace ThatsLewd
{
  public class ExciteMeter : MVRScript
  {

    public override void Init()
    {
      CreateUI();
    }

    void OnDestroy()
    {
      Utils.OnDestroyUI();
    }

    void CreateUI()
    {
      Utils.OnInitUI(CreateUIElement);
    }

    public void Update()
    {
      // Do stuff
    }

    public override JSONClass GetJSON(bool includePhysical = true, bool includeAppearance = true, bool forceStore = false)
    {
      JSONClass json = base.GetJSON(includePhysical, includeAppearance, forceStore);

      return json;
    }

    public override void RestoreFromJSON(JSONClass json, bool restorePhysical = true, bool restoreAppearance = true, JSONArray presetAtoms = null, bool setMissingToDefault = true)
    {
      base.RestoreFromJSON(json, restorePhysical, restoreAppearance, presetAtoms, setMissingToDefault);
    }
  }
}
