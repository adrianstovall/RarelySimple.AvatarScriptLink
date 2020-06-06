using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class DisableAllFieldsCommand : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;

        public DisableAllFieldsCommand(IOptionObjectDecorator optionObjectDecorator)
        {
            _optionObject = optionObjectDecorator;
        }

        public IOptionObject2015 Execute()
        {
            _optionObject.DisableAllFieldObjects();

            string returnMessage = "All FieldObjects should now be disabled (with a few exceptions).";

            return _optionObject.ToReturnOptionObject(ErrorCode.Informational, returnMessage);
        }
    }
}