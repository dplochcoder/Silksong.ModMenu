using System;
using System.Collections.Generic;
using System.Text;
using Silksong.ModMenu.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Silksong.ModMenu.Internal;

internal class DescriptionUpdate : MonoBehaviour
{
    internal IDynamicDescriptionModel? Model;
    private Text descriptionText;

    void Awake()
    {
        descriptionText = gameObject.GetComponent<Text>();
    }

    internal void UpdateDescription()
    {
        descriptionText?.text = Model?.GetDescription() ?? string.Empty;
    }
}
