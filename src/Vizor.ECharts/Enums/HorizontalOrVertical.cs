﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace Vizor.ECharts.Enums;

[JsonConverter(typeof(CamelCaseEnumConverter<HorizontalOrVertical>))]
public enum HorizontalOrVertical
{
	Horizontal,
	Vertical
}
