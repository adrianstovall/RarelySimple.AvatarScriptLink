using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared
{
    public class DisableAllFieldsCommand : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject;

        public DisableAllFieldsCommand(OptionObject2015 optionObjectDecorator)
        {
            _optionObject = optionObjectDecorator;
        }

        public OptionObject2015 Execute()
        {
            _optionObject.DisableAllFieldObjects();

            string returnMessage = "All FieldObjects should now be disabled (with a few exceptions).";

            return _optionObject.ToReturnOptionObject(ErrorCode.Informational, returnMessage);
        }
    }
}