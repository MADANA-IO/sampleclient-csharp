/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.4.14-master.23
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
    ///  Class for testing AuthenticationServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthenticationServiceApiTests
    {
        private AuthenticationServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthenticationServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthenticationServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AuthenticationServiceApi
            //Assert.IsInstanceOf(typeof(AuthenticationServiceApi), instance);
        }

        
        /// <summary>
        /// Test AuthenticateApplication
        /// </summary>
        [Test]
        public void AuthenticateApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JsonMDNCertificate body = null;
            //var response = instance.AuthenticateApplication(body);
            //Assert.IsInstanceOf(typeof(JsonMDNToken), response, "response is JsonMDNToken");
        }
        
        /// <summary>
        /// Test AuthenticateEthereumWallet
        /// </summary>
        [Test]
        public void AuthenticateEthereumWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string wallet = null;
            //JsonMDNOAuthToken body = null;
            //var response = instance.AuthenticateEthereumWallet(wallet, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test AuthenticateUser
        /// </summary>
        [Test]
        public void AuthenticateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JsonMDNUserCredentials body = null;
            //var response = instance.AuthenticateUser(body);
            //Assert.IsInstanceOf(typeof(JsonMDNToken), response, "response is JsonMDNToken");
        }
        
        /// <summary>
        /// Test AuthenticateWithEthereumChallenge
        /// </summary>
        [Test]
        public void AuthenticateWithEthereumChallengeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string wallet = null;
            //JsonMDNOAuthToken body = null;
            //var response = instance.AuthenticateWithEthereumChallenge(wallet, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetFractalAuthenticationURL
        /// </summary>
        [Test]
        public void GetFractalAuthenticationURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetFractalAuthenticationURL();
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetNonceForEthereumWallet
        /// </summary>
        [Test]
        public void GetNonceForEthereumWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string wallet = null;
            //string authorization = null;
            //var response = instance.GetNonceForEthereumWallet(wallet, authorization);
            //Assert.IsInstanceOf(typeof(JsonMDNToken), response, "response is JsonMDNToken");
        }
        
        /// <summary>
        /// Test GetObject
        /// </summary>
        [Test]
        public void GetObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetObject();
            //Assert.IsInstanceOf(typeof(Dictionary<string, Object>), response, "response is Dictionary<string, Object>");
        }
        
        /// <summary>
        /// Test GetTwitterAuthenticationURL
        /// </summary>
        [Test]
        public void GetTwitterAuthenticationURLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTwitterAuthenticationURL();
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SetFacebookUID
        /// </summary>
        [Test]
        public void SetFacebookUIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //var response = instance.SetFacebookUID(body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SetFractalUID
        /// </summary>
        [Test]
        public void SetFractalUIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //var response = instance.SetFractalUID(body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SetTwitterUID
        /// </summary>
        [Test]
        public void SetTwitterUIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JsonMDNOAuthToken body = null;
            //var response = instance.SetTwitterUID(body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
    }

}
