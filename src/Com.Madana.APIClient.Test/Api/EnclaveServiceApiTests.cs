/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.33
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Com.Madana.APIClient.Client;
using Com.Madana.APIClient.Api;
using Com.Madana.APIClient.Model;

namespace Com.Madana.APIClient.Test
{
    /// <summary>
    ///  Class for testing EnclaveServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EnclaveServiceApiTests
    {
        private EnclaveServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EnclaveServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EnclaveServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' EnclaveServiceApi
            //Assert.IsInstanceOf(typeof(EnclaveServiceApi), instance);
        }

        
        /// <summary>
        /// Test AddHistory
        /// </summary>
        [Test]
        public void AddHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //JsonSignedData body = null;
            //var response = instance.AddHistory(uuid, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ApproveEnclave
        /// </summary>
        [Test]
        public void ApproveEnclaveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //JsonEnclaveRunningAttestationApproval body = null;
            //var response = instance.ApproveEnclave(uuid, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test AssignEnclaveAgent
        /// </summary>
        [Test]
        public void AssignEnclaveAgentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //JsonNodeInfo body = null;
            //var response = instance.AssignEnclaveAgent(uuid, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test AttestateEnclave
        /// </summary>
        [Test]
        public void AttestateEnclaveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //JsonEnclaveRunningAttestation body = null;
            //var response = instance.AttestateEnclave(uuid, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test CreateEnclaveRunRequest
        /// </summary>
        [Test]
        public void CreateEnclaveRunRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JsonEnclaveRunRequest body = null;
            //var response = instance.CreateEnclaveRunRequest(body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetEnclave
        /// </summary>
        [Test]
        public void GetEnclaveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.GetEnclave(uuid);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetEnclaveTypes
        /// </summary>
        [Test]
        public void GetEnclaveTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEnclaveTypes();
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetEnclaves
        /// </summary>
        [Test]
        public void GetEnclavesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string created = null;
            //string limit = null;
            //string offset = null;
            //string status = null;
            //var response = instance.GetEnclaves(authorization, created, limit, offset, status);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test KillEnclave
        /// </summary>
        [Test]
        public void KillEnclaveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.KillEnclave(uuid);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
    }

}
