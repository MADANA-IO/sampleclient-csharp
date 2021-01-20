/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.41
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
    ///  Class for testing AccountServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountServiceApiTests
    {
        private AccountServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AccountServiceApi
            //Assert.IsInstanceOf(typeof(AccountServiceApi), instance);
        }

        
        /// <summary>
        /// Test ActivateUser
        /// </summary>
        [Test]
        public void ActivateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.ActivateUser(token);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test CreatePasswordReset
        /// </summary>
        [Test]
        public void CreatePasswordResetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JsonMDNMailAddress body = null;
            //var response = instance.CreatePasswordReset(body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test RequestVerificationMail
        /// </summary>
        [Test]
        public void RequestVerificationMailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RequestVerificationMail();
            //Assert.IsInstanceOf(typeof(Dictionary<string, Object>), response, "response is Dictionary<string, Object>");
        }
        
        /// <summary>
        /// Test UpdatePassword
        /// </summary>
        [Test]
        public void UpdatePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JsonMDNPasswordReset body = null;
            //var response = instance.UpdatePassword(body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
    }

}
