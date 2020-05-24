﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v6
{
    [TestClass]
    public class CommandFactoryTests
    {
        [TestMethod]
        public void GetCommand_OptionObject_EmptyParameter_ReturnsDefaultScriptCommand()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            DefaultScriptCommand expected = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_EmptyParameter_ReturnsDefaultScriptCommand()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            DefaultScriptCommand expected = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_EmptyParameter_ReturnsDefaultScriptCommand()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            DefaultScriptCommand expected = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode0_ReturnsGetErrorCode0Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("GetErrorCode0");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode0Command expected = new GetErrorCode0Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode0_ReturnsGetErrorCode0Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("GetErrorCode0");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode0Command expected = new GetErrorCode0Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode0_ReturnsGetErrorCode0Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("GetErrorCode0");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode0Command expected = new GetErrorCode0Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode1_ReturnsGetErrorCode1Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("GetErrorCode1");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode1Command expected = new GetErrorCode1Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode1_ReturnsGetErrorCode1Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("GetErrorCode1");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode1Command expected = new GetErrorCode1Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode1_ReturnsGetErrorCode1Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("GetErrorCode1");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode1Command expected = new GetErrorCode1Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode2_ReturnsGetErrorCode2Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("GetErrorCode2");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode2Command expected = new GetErrorCode2Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode2_ReturnsGetErrorCode2Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("GetErrorCode2");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode2Command expected = new GetErrorCode2Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode2_ReturnsGetErrorCode2Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("GetErrorCode2");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode2Command expected = new GetErrorCode2Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode3_ReturnsGetErrorCode3Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("GetErrorCode3");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode3Command expected = new GetErrorCode3Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode3_ReturnsGetErrorCode3Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("GetErrorCode3");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode3Command expected = new GetErrorCode3Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode3_ReturnsGetErrorCode3Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("GetErrorCode3");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode3Command expected = new GetErrorCode3Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode4_ReturnsGetErrorCode4Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("GetErrorCode4");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode4Command expected = new GetErrorCode4Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode4_ReturnsGetErrorCode4Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("GetErrorCode4");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode4Command expected = new GetErrorCode4Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode4_ReturnsGetErrorCode4Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("GetErrorCode4");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode4Command expected = new GetErrorCode4Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode5_ReturnsGetErrorCode5Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("GetErrorCode5");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode5Command expected = new GetErrorCode5Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode5_ReturnsGetErrorCode5Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("GetErrorCode5");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode5Command expected = new GetErrorCode5Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode5_ReturnsGetErrorCode5Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("GetErrorCode5");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode5Command expected = new GetErrorCode5Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode6_ReturnsGetErrorCode6Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("GetErrorCode6");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode6Command expected = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode6_ReturnsGetErrorCode6Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("GetErrorCode6");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode6Command expected = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode6_ReturnsGetErrorCode6Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("GetErrorCode6");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetErrorCode6Command expected = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetFieldValue_ReturnsGetFieldValueCommand()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("GetFieldValue,123");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetFieldValueCommand expected = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetFieldValue_ReturnsGetFieldValueCommand()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("GetFieldValue,123");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetFieldValueCommand expected = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetFieldValue_ReturnsGetFieldValueCommand()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("GetFieldValue,123");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            GetFieldValueCommand expected = new GetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_SetFieldValue_ReturnsSetFieldValueCommand()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IParameter parameter = new Parameter("SetFieldValue,123");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            SetFieldValueCommand expected = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_SetFieldValue_ReturnsSetFieldValueCommand()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IParameter parameter = new Parameter("SetFieldValue,123");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            SetFieldValueCommand expected = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_SetFieldValue_ReturnsSetFieldValueCommand()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IParameter parameter = new Parameter("SetFieldValue,123");
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            SetFieldValueCommand expected = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
