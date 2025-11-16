using BepInEx.Logging;
using Silksong.ModMenu.Internal;
using Silksong.ModMenu.Models;

namespace Silksong.ModMenu.Elements;

public class DynamicDescriptionChoiceElement<T> : ChoiceElement<T>
{
    public DynamicDescriptionChoiceElement(string label, IDynamicDescriptionChoiceModel<T> model)
        : base(label, model, "")
    {
        var descriptionUpdate = DescriptionText.gameObject.AddComponent<DescriptionUpdate>();
        descriptionUpdate.Model = model;
        OnValueChanged += _ => descriptionUpdate.UpdateDescription();
        descriptionUpdate.UpdateDescription();
    }
}
