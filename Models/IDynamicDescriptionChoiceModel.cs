using System;
using System.Collections.Generic;
using System.Text;

namespace Silksong.ModMenu.Models;

public interface IDynamicDescriptionChoiceModel<T> : IChoiceModel<T>, IDynamicDescriptionModel { }
