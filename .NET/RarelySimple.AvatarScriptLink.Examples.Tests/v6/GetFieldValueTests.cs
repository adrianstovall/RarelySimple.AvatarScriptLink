﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v6
{
    [TestClass]
    public class GetFieldValueTests
    {
        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject_ReturnsErrorCode3()
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
            IParameter parameter = new Parameter("GetFieldValue,123");
            var command = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject2_ReturnsErrorCode3()
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
            IParameter parameter = new Parameter("GetFieldValue,123");
            var command = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject2015_ReturnsErrorCode3()
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
            IParameter parameter = new Parameter("GetFieldValue,123");
            var command = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject_FormCountEquals0()
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
            IParameter parameter = new Parameter("GetFieldValue,123");
            var command = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject2_FormCountEquals0()
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
            IParameter parameter = new Parameter("GetFieldValue,123");
            var command = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject2015_FormCountEquals0()
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
            IParameter parameter = new Parameter("GetFieldValue,123");
            var command = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
