using Net4Lib;

namespace Net4Mvc
{
    public class MyModel
    {
        [CustomDisplay(Name = "CustomName")]
        public string MyProperty { get; set; }
    }
}
