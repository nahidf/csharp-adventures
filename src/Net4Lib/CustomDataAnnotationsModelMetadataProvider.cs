using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Net4Lib
{
    public class CustomDataAnnotationsModelMetadataProvider : DataAnnotationsModelMetadataProvider
    {
        protected override ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
        {
            var result = base.CreateMetadata(attributes, containerType,
                    modelAccessor, modelType, propertyName);

            CustomDisplayAttribute customDisplay = attributes.OfType<CustomDisplayAttribute>().FirstOrDefault();
            if (customDisplay != null)
            {
                result.Description = customDisplay.GetDescription();
                result.ShortDisplayName = customDisplay.GetShortName();
                result.Watermark = customDisplay.GetPrompt();
                result.Order = customDisplay.GetOrder() ?? ModelMetadata.DefaultOrder;

                result.DisplayName = customDisplay.GetName();
            }

            return result;
        }
    }
}
