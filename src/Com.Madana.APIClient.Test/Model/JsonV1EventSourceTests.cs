/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.38
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
    ///  Class for testing JsonV1EventSource
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class JsonV1EventSourceTests
    {
        // TODO uncomment below to declare an instance variable for JsonV1EventSource
        //private JsonV1EventSource instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of JsonV1EventSource
            //instance = new JsonV1EventSource();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JsonV1EventSource
        /// </summary>
        [Test]
        public void JsonV1EventSourceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" JsonV1EventSource
            //Assert.IsInstanceOf(typeof(JsonV1EventSource), instance);
        }


        /// <summary>
        /// Test the property 'Component'
        /// </summary>
        [Test]
        public void ComponentTest()
        {
            // TODO unit test for the property 'Component'
        }
        /// <summary>
        /// Test the property 'Host'
        /// </summary>
        [Test]
        public void HostTest()
        {
            // TODO unit test for the property 'Host'
        }

    }

}
