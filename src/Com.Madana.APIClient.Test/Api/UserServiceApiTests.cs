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
    ///  Class for testing UserServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserServiceApiTests
    {
        private UserServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' UserServiceApi
            //Assert.IsInstanceOf(typeof(UserServiceApi), instance);
        }

        
        /// <summary>
        /// Test CreateObject
        /// </summary>
        [Test]
        public void CreateObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string referrer = null;
            //JsonMDNUser body = null;
            //var response = instance.CreateObject(referrer, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DeleteObject
        /// </summary>
        [Test]
        public void DeleteObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.DeleteObject(username);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DeleteObject_0
        /// </summary>
        [Test]
        public void DeleteObject_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ident = null;
            //string platform = null;
            //string username = null;
            //var response = instance.DeleteObject_0(ident, platform, username);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetAvatars
        /// </summary>
        [Test]
        public void GetAvatarsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetAvatars(username);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetCertificates
        /// </summary>
        [Test]
        public void GetCertificatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetCertificates(username);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetEnclaveHistory
        /// </summary>
        [Test]
        public void GetEnclaveHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string limit = null;
            //string offset = null;
            //var response = instance.GetEnclaveHistory(username, limit, offset);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetObject2
        /// </summary>
        [Test]
        public void GetObject2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetObject2(username);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SetAvatar
        /// </summary>
        [Test]
        public void SetAvatarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //JsonMDNUserProfileImage body = null;
            //var response = instance.SetAvatar(username, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test SetSettings
        /// </summary>
        [Test]
        public void SetSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //JsonMDNUserSetting body = null;
            //var response = instance.SetSettings(username, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test UpdateObject
        /// </summary>
        [Test]
        public void UpdateObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //JsonMDNUser body = null;
            //var response = instance.UpdateObject(username, body);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
    }

}
