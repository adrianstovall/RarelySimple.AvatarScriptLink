using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v2.Shared
{
    public static class DisableAllFields
    {
        public static OptionObject RunScript(OptionObject optionObject)
        {
            OptionObject returnOptionObject = new OptionObject();

            // TODO: Re-write for v2 sample
            optionObject.DisableAllFieldObjects();

            returnOptionObject.ErrorCode = 3;
            returnOptionObject.ErrorMesg = "All FieldObjects should now be disabled (with a few exceptions).";

            returnOptionObject.EntityID = optionObject.EntityID;
            returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
            returnOptionObject.Facility = optionObject.Facility;
            //returnOptionObject.NamespaceName = optionObject.NamespaceName;    // NOTE: These properties will compile but will be removed when serialized.
            returnOptionObject.OptionId = optionObject.OptionId;
            returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
            returnOptionObject.OptionUserId = optionObject.OptionUserId;
            //returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
            //returnOptionObject.ServerName = optionObject.ServerName;
            returnOptionObject.SystemCode = optionObject.SystemCode;
            //returnOptionObject.SessionToken = optionObject.SessionToken;

            return returnOptionObject;
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            // TODO: Re-write for v2 sample
            optionObject.DisableAllFieldObjects();

            returnOptionObject.ErrorCode = 3;
            returnOptionObject.ErrorMesg = "All FieldObjects should now be disabled (with a few exceptions).";

            returnOptionObject.EntityID = optionObject.EntityID;
            returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
            returnOptionObject.Facility = optionObject.Facility;
            returnOptionObject.NamespaceName = optionObject.NamespaceName;
            returnOptionObject.OptionId = optionObject.OptionId;
            returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
            returnOptionObject.OptionUserId = optionObject.OptionUserId;
            returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
            returnOptionObject.ServerName = optionObject.ServerName;
            returnOptionObject.SystemCode = optionObject.SystemCode;
            //returnOptionObject.SessionToken = optionObject.SessionToken;    // NOTE: This property will compile but will be removed when serialized.

            return returnOptionObject;
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject)
        {
            OptionObject2015 returnOptionObject = new OptionObject2015();

            // TODO: Re-write for v2 sample
            optionObject.DisableAllFieldObjects();

            returnOptionObject.ErrorCode = 3;
            returnOptionObject.ErrorMesg = "All FieldObjects should now be disabled (with a few exceptions).";

            returnOptionObject.EntityID = optionObject.EntityID;
            returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
            returnOptionObject.Facility = optionObject.Facility;
            returnOptionObject.NamespaceName = optionObject.NamespaceName;
            returnOptionObject.OptionId = optionObject.OptionId;
            returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
            returnOptionObject.OptionUserId = optionObject.OptionUserId;
            returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
            returnOptionObject.ServerName = optionObject.ServerName;
            returnOptionObject.SystemCode = optionObject.SystemCode;
            returnOptionObject.SessionToken = optionObject.SessionToken;

            return returnOptionObject;
        }
    }
}