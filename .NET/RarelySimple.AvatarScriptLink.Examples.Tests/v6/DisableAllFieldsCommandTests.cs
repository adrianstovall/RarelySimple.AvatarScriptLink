using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v6
{
    [TestClass]
    public class DisableAllFieldsCommandTests
    {
        [TestMethod]
        public void RunScript_DisableAllFields_OptionObject_ReturnsErrorCode0()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new DisableAllFieldsCommand(optionObjectDecorator);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DisableAllFields_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new DisableAllFieldsCommand(optionObjectDecorator);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DisableAllFields_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new DisableAllFieldsCommand(optionObjectDecorator);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }
    }
}
