// <copyright file="Form1Test.cs">Copyright ©  2020</copyright>
using System;
using AESEncryptDecyptFile;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AESEncryptDecyptFile.Tests
{
    /// <summary>This class contains parameterized unit tests for Form1</summary>
    [PexClass(typeof(Form1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Form1Test
    {
    }
}
