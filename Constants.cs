namespace TinyMceBackwardsRadzenDatagridRepro
{
    public static class Constants
    {
        public static Dictionary<string, object> TinyMceConfig = new Dictionary<string, object>
        {
            {"menubar", false},
            {"branding", false},
            {"plugins", "lists advlist code preview"},
            {"height", 400},
            {"forced_root_block", "div"},
            {"force_br_newlines", true},
            //{"toolbar", "undo redo | bold italic underline | forecolor | bullist numlist | outdent indent | code | removeformat formatselect fontselect fontsizeselect styleselect"}
            {"toolbar", "undo redo | removeformat bold italic underline | forecolor backcolor | bullist numlist | outdent indent | preview | code"}
        };
    }
}
