using Net4;

namespace Net4Mvc
{
    public class MyModel
    {
        [CustomDisplay(Name = "CustomName")]
        public string MyProperty { get; set; }
    }
}
