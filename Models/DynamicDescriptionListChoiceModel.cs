using System;
using System.Collections.Generic;

namespace Silksong.ModMenu.Models;

public class DynamicDescriptionListChoiceModel<T>(List<T> values, Func<T, string> getDescription)
    : ListChoiceModel<T>(values),
        IDynamicDescriptionChoiceModel<T>
{
    public string GetDescription() => getDescription(GetValue());
}
