/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.0.1-master.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Model;
using Com.Madana.APIClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Com.Madana.APIClient.Test
{
    /// <summary>
    ///  Class for testing JsonEnvironmentPublishingRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class JsonEnvironmentPublishingRequestTests
    {
        // TODO uncomment below to declare an instance variable for JsonEnvironmentPublishingRequest
        //private JsonEnvironmentPublishingRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of JsonEnvironmentPublishingRequest
            //instance = new JsonEnvironmentPublishingRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JsonEnvironmentPublishingRequest
        /// </summary>
        [Test]
        public void JsonEnvironmentPublishingRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" JsonEnvironmentPublishingRequest
            //Assert.IsInstanceOf(typeof(JsonEnvironmentPublishingRequest), instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'IpfsHash'
        /// </summary>
        [Test]
        public void IpfsHashTest()
        {
            // TODO unit test for the property 'IpfsHash'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Size'
        /// </summary>
        [Test]
        public void SizeTest()
        {
            // TODO unit test for the property 'Size'
        }
        /// <summary>
        /// Test the property 'Packages'
        /// </summary>
        [Test]
        public void PackagesTest()
        {
            // TODO unit test for the property 'Packages'
        }
        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Test]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
        }
        /// <summary>
        /// Test the property 'IpfsPrimaryPeer'
        /// </summary>
        [Test]
        public void IpfsPrimaryPeerTest()
        {
            // TODO unit test for the property 'IpfsPrimaryPeer'
        }
        /// <summary>
        /// Test the property 'IsPublic'
        /// </summary>
        [Test]
        public void IsPublicTest()
        {
            // TODO unit test for the property 'IsPublic'
        }
        /// <summary>
        /// Test the property 'Uuid'
        /// </summary>
        [Test]
        public void UuidTest()
        {
            // TODO unit test for the property 'Uuid'
        }

    }

}
