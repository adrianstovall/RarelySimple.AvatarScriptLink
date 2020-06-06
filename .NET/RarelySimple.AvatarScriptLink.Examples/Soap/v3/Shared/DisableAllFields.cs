using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v3.Shared
{
    public static class DisableAllFields
    {
        public static OptionObject RunScript(OptionObject optionObject)
        {
            optionObject.DisableAllFieldObjects();

            string returnMessage = "All FieldObjects should now be disabled (with a few exceptions).";

            return optionObject.ToReturnOptionObject(ErrorCode.Informational, returnMessage);
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject)
        {
            optionObject.DisableAllFieldObjects();

            string returnMessage = "All FieldObjects should now be disabled (with a few exceptions).";

            return optionObject.ToReturnOptionObject(ErrorCode.Informational, returnMessage);
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject)
        {
            optionObject.DisableAllFieldObjects();

            string returnMessage = "All FieldObjects should now be disabled (with a few exceptions).";

            return optionObject.ToReturnOptionObject(ErrorCode.Informational, returnMessage);
        }
    }
}