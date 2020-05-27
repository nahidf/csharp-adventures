using System;
using System.ComponentModel.DataAnnotations;

namespace Net4Lib
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Method, AllowMultiple = false)]
    public class CustomDisplayAttribute : Attribute
    {
        private DisplayAttribute _innerAttribute;

        public CustomDisplayAttribute()
        {
            _innerAttribute = new DisplayAttribute();
        }

        public string ShortName
        {
            get
            {
                return _innerAttribute.ShortName;
            }
            set
            {
                _innerAttribute.ShortName = value;
            }
        }

        public string Name
        {
            get
            {
                return _innerAttribute.Name;
            }
            set
            {
                _innerAttribute.Name = value;
            }
        }

        public string Description
        {
            get
            {
                return _innerAttribute.Description;
            }
            set
            {
                _innerAttribute.Description = value;
            }
        }

        public string Prompt
        {
            get
            {
                return _innerAttribute.Prompt;
            }
            set
            {
                _innerAttribute.Prompt = value;
            }
        }

        public string GroupName
        {
            get
            {
                return _innerAttribute.GroupName;
            }
            set
            {
                _innerAttribute.GroupName = value;
            }
        }

        public Type ResourceType
        {
            get
            {
                return _innerAttribute.ResourceType;
            }
            set
            {
                _innerAttribute.ResourceType = value;
            }
        }

        public bool AutoGenerateField
        {
            get
            {
                return _innerAttribute.AutoGenerateField;
            }
            set
            {
                _innerAttribute.AutoGenerateField = value;
            }
        }

        public bool AutoGenerateFilter
        {
            get
            {
                return _innerAttribute.AutoGenerateFilter;
            }
            set
            {
                _innerAttribute.AutoGenerateFilter = value;
            }
        }

        public int Order
        {
            get
            {
                return _innerAttribute.Order;
            }
            set
            {
                _innerAttribute.Order = value;
            }
        }

        public string GetShortName()
        {
            return _innerAttribute.GetShortName();
        }

        public string GetName()
        {
            return _innerAttribute.GetName() + " - this is test";
        }

        public string GetDescription()
        {
            return _innerAttribute.GetDescription();
        }

        public string GetPrompt()
        {
            return _innerAttribute.GetPrompt();
        }

        public string GetGroupName()
        {
            return _innerAttribute.GetGroupName();
        }

        public bool? GetAutoGenerateField()
        {
            return _innerAttribute.GetAutoGenerateField();
        }

        public bool? GetAutoGenerateFilter()
        {
            return _innerAttribute.GetAutoGenerateFilter();
        }

        public int? GetOrder()
        {
            return _innerAttribute.GetOrder();
        }        
    }
}
