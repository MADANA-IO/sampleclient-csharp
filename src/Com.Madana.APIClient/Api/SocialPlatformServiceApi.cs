/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.53
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Com.Madana.APIClient.Client;

namespace Com.Madana.APIClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISocialPlatformServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Facebook
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetPlatforms (string body = default(string));

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Facebook
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetPlatformsWithHttpInfo (string body = default(string));
        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Facebook
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ListenTwitterWebhook (string body = default(string));

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Facebook
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ListenTwitterWebhookWithHttpInfo (string body = default(string));
        /// <summary>
        /// Used to Handle Incoming Webhooks from Twitter.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Twitter
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="crcToken"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream RegisterTwitterWebhook (string crcToken = default(string));

        /// <summary>
        /// Used to Handle Incoming Webhooks from Twitter.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Twitter
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="crcToken"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> RegisterTwitterWebhookWithHttpInfo (string crcToken = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Facebook
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetPlatformsAsync (string body = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Facebook
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetPlatformsWithHttpInfoAsync (string body = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Facebook
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ListenTwitterWebhookAsync (string body = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Facebook
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ListenTwitterWebhookWithHttpInfoAsync (string body = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Used to Handle Incoming Webhooks from Twitter.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Twitter
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="crcToken"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> RegisterTwitterWebhookAsync (string crcToken = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Used to Handle Incoming Webhooks from Twitter.
        /// </summary>
        /// <remarks>
        /// Used to Handle Incoming Webhooks from Twitter
        /// </remarks>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="crcToken"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> RegisterTwitterWebhookWithHttpInfoAsync (string crcToken = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SocialPlatformServiceApi : ISocialPlatformServiceApi
    {
        private Com.Madana.APIClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialPlatformServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SocialPlatformServiceApi(String basePath)
        {
            this.Configuration = new Com.Madana.APIClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Com.Madana.APIClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialPlatformServiceApi"/> class
        /// </summary>
        /// <returns></returns>
        public SocialPlatformServiceApi()
        {
            this.Configuration = Com.Madana.APIClient.Client.Configuration.Default;

            ExceptionFactory = Com.Madana.APIClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialPlatformServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SocialPlatformServiceApi(Com.Madana.APIClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Com.Madana.APIClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Com.Madana.APIClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Com.Madana.APIClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.Madana.APIClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook. Used to Handle Incoming Webhooks from Facebook
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream GetPlatforms (string body = default(string))
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetPlatformsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook. Used to Handle Incoming Webhooks from Facebook
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse<System.IO.Stream> GetPlatformsWithHttpInfo (string body = default(string))
        {

            var localVarPath = "/platforms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlatforms", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook. Used to Handle Incoming Webhooks from Facebook
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetPlatformsAsync (string body = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetPlatformsWithHttpInfoAsync(body, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook. Used to Handle Incoming Webhooks from Facebook
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetPlatformsWithHttpInfoAsync (string body = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/platforms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPlatforms", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook. Used to Handle Incoming Webhooks from Facebook
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream ListenTwitterWebhook (string body = default(string))
        {
             ApiResponse<System.IO.Stream> localVarResponse = ListenTwitterWebhookWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook. Used to Handle Incoming Webhooks from Facebook
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse<System.IO.Stream> ListenTwitterWebhookWithHttpInfo (string body = default(string))
        {

            var localVarPath = "/platforms/twitter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListenTwitterWebhook", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook. Used to Handle Incoming Webhooks from Facebook
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ListenTwitterWebhookAsync (string body = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<System.IO.Stream> localVarResponse = await ListenTwitterWebhookWithHttpInfoAsync(body, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Facebook. Used to Handle Incoming Webhooks from Facebook
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ListenTwitterWebhookWithHttpInfoAsync (string body = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/platforms/twitter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListenTwitterWebhook", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Twitter. Used to Handle Incoming Webhooks from Twitter
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="crcToken"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream RegisterTwitterWebhook (string crcToken = default(string))
        {
             ApiResponse<System.IO.Stream> localVarResponse = RegisterTwitterWebhookWithHttpInfo(crcToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Twitter. Used to Handle Incoming Webhooks from Twitter
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="crcToken"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse<System.IO.Stream> RegisterTwitterWebhookWithHttpInfo (string crcToken = default(string))
        {

            var localVarPath = "/platforms/twitter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (crcToken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "crc_token", crcToken)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RegisterTwitterWebhook", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Twitter. Used to Handle Incoming Webhooks from Twitter
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="crcToken"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> RegisterTwitterWebhookAsync (string crcToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<System.IO.Stream> localVarResponse = await RegisterTwitterWebhookWithHttpInfoAsync(crcToken, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Used to Handle Incoming Webhooks from Twitter. Used to Handle Incoming Webhooks from Twitter
        /// </summary>
        /// <exception cref="Com.Madana.APIClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="crcToken"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> RegisterTwitterWebhookWithHttpInfoAsync (string crcToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/platforms/twitter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (crcToken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "crc_token", crcToken)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RegisterTwitterWebhook", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

    }
}
